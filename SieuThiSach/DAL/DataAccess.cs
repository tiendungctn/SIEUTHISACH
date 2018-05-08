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

        #region "Load data từ Excel"
        public int ImportExcel(int dtnumber, string table, ref DataGridView dt)
        {
            using (DbConnection cnn = oFactory.CreateConnection())
            {
                int Iret = 0;
                cnn.ConnectionString = this.ConnectionString;
                DbTransaction transaction;
                try
                {
                    cnn.Open();
                    transaction = cnn.BeginTransaction();
                    for (int i = dtnumber; i < dt.Rows.Count; i++)
                    {
                        string columns = "";
                        string value = "";
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Columns[j].HeaderText.ToString() != "")
                            {
                                if (j == 0)
                                {
                                    columns = dt.Columns[j].HeaderText.ToString();
                                    value = "N'" + dt.Rows[i].Cells[j].Value.ToString() + "'";
                                }
                                else
                                {
                                    columns = columns + "," + dt.Columns[j].HeaderText.ToString();
                                    value = value + ",N'" + dt.Rows[i].Cells[j].Value.ToString() + "'";
                                }
                            }
                        }
                        string sSql = "insert into " + table + " (" + columns + ") values (" + value + ")";
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
                    RowEr = Iret + 1;
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
        #endregion

        public int EditDataGridView(string clupdate, string table, ref DataGridView dt)
        {
            using (DbConnection cnn = oFactory.CreateConnection())
            {
                int Iret = 0;
                cnn.ConnectionString = this.ConnectionString;
                DbTransaction transaction;
                try
                {
                    cnn.Open();
                    transaction = cnn.BeginTransaction();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string columns = "";
                        string value = "";
                        string sSql = "update " + table + " set ";
                        columns = dt.Columns[clupdate].Name.ToString();
                        value = "N'" + dt.Rows[i].Cells[clupdate].Value.ToString() + "'";
                        sSql = sSql + columns + " = " + value;//Lấy giá trị
                        string columnsdk = "";
                        string valuedk = "";
                        columnsdk = dt.Columns[0].Name.ToString();
                        valuedk = "'" + dt.Rows[i].Cells[0].Value.ToString() + "'";
                        sSql = sSql + " where "+ columnsdk + " = " + valuedk;//đặt điều kiện
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
                    RowEr = Iret + 1;
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
