using SieuThiSach.SO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiSach.DAL
{
    class DataAccess
    {
        #region "Private Members"

        private string _connectionString = MyApp.MSSQLConnectionString;
        /// <summary>
        /// Provider may be: System.Data.SqlClient; Oracle.DataAccess.Client,...
        /// </summary>
        private string _providerName = MyApp.MSSQLProviderName;

        #endregion

        #region "Properties"

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
        public string ProviderName
        {
            get { return _providerName; }
            set { _providerName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DbProviderFactory oFactory { get; set; }

        #endregion

        #region "Constructors"

        public DataAccess()
        {
            try
            {
                this.ProviderName = MyApp.MSSQLProviderName;
                this.ConnectionString = MyApp.MSSQLConnectionString;
                this.oFactory = DbProviderFactories.GetFactory(this.ProviderName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        ~DataAccess()
        {
            oFactory = null;
        }
        #endregion

        #region Execute methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StroredProcedureName"></param>
        /// <param name="ParaMeterCollection"></param>
        /// <returns></returns>
        public DbDataReader ExecuteAsDataReaderSql(string sSql, List<KeyValuePair<string, object>> ParaMeterCollection)
        {
            try
            {
                DbConnection cnn = oFactory.CreateConnection();

                cnn.ConnectionString = this.ConnectionString;
                DbCommand cmd = oFactory.CreateCommand();
                cmd.CommandTimeout = MyApp.CmdTimeout;
                DbDataReader reader;
                cmd.Connection = cnn;
                cmd.CommandText = sSql;
                cmd.CommandType = CommandType.Text;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    DbParameter sqlParaMeter = oFactory.CreateParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    cmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop
                cnn.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return reader;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="StroredProcedureName"></param>
        /// <returns></returns>
        public DataSet ExecuteAsDataSetSql(string sSql)
        {
            try
            {
                DbConnection cnn = oFactory.CreateConnection();
                cnn.ConnectionString = this.ConnectionString;
                DbCommand cmd = oFactory.CreateCommand();
                DbDataAdapter da = oFactory.CreateDataAdapter();
                DataSet ds = new DataSet();
                cmd.Connection = cnn;
                cmd.CommandText = sSql;
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                cnn.Open();
                da.Fill(ds);

                cnn.Close();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ImportExcel(string table, ref DataGridView dt)
        {
            using (DbConnection cnn = oFactory.CreateConnection())
            {
                int Iret = 0;
                cnn.ConnectionString = this.ConnectionString;
                cnn.Open();
                DbTransaction transaction = cnn.BeginTransaction();              
                try
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string value = "";
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (j == 0) value = "N'" + dt.Rows[i].Cells[j].Value.ToString() + "'";
                            else value = value + ",N'" + dt.Rows[i].Cells[j].Value.ToString() + "'";
                        }
                        string sSql = "insert into " + table + " values (" + value + ")";
                        DbCommand cmd = oFactory.CreateCommand();
                        cmd.Connection = cnn;
                        cmd.CommandText = sSql;
                        cmd.CommandType = CommandType.Text;                       
                        cmd.Transaction = transaction;
                        Iret = Iret + cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    RowEr = Iret+1;
                    throw e;
                    transaction.Rollback();                  
                }
                finally
                {                    
                    cnn.Close();                  
                }
                return Iret;
            }
        }

        public int RowEr;

        /// <summary>
        /// Thực thi câu lệnh sql
        /// </summary>
        /// <param name="sSql"></param>
        public int ExecuteData(string sSql)
        {
            using (DbConnection cnn = oFactory.CreateConnection())
            {
                int iret = 0;
                cnn.ConnectionString = this.ConnectionString;
                try
                {
                    DbCommand cmd = oFactory.CreateCommand();
                    cmd.Connection = cnn;
                    cmd.CommandText = sSql;
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    iret = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    iret = -2;
                    throw e;

                }
                finally
                {
                    cnn.Close();
                }
                return iret;
            }
        }


        /// <summary>
        /// Thực thi câu lệnh sql - Trả lỗi
        /// </summary>
        /// <param name="sSql"></param>
        public int vExecuteData(string sSql)
        {
            int iret = 0;
            try
            {
                DbConnection cnn = oFactory.CreateConnection();
                cnn.ConnectionString = this.ConnectionString;
                DbCommand cmd = oFactory.CreateCommand();
                DbDataAdapter da = oFactory.CreateDataAdapter();
                //DataSet ds = new DataSet();
                cmd.Connection = cnn;
                cmd.CommandText = sSql;
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                cnn.Open();
                iret = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e)
            {
                iret = -1;
                throw e;
            }
            return iret;
        }
        #endregion
    }
}
