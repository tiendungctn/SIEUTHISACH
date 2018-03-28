using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SieuThiSach.DAL;

namespace SieuThiSach.SO
{
    class UserInformation
    {
        #region Thông số User 
        public static string Code;
        public static string Pass;
        public static string vMaNV(string Code)
        {
            DataLoading DL = new DataLoading();
            return DL.NameReturn("MA_NHAN_VIEN", "[USER]", "CODE = '" + Code + "'");
        }
        public static string vMaDV(string Code)
        {
            DataLoading DL = new DataLoading();
            return DL.NameReturn("MA_DVI", "[USER]", "CODE = '" + Code + "'");
        }        
        public static string vName(string MaNV, string MaDV)
        {
            DataLoading DL = new DataLoading();
            return DL.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + MaNV + "' and MA_DVI = '" + MaDV + "'");
        }

        public static string MaNV = vMaNV(Code);
        public static string MaDV = vMaDV(Code);
        public static string Name = vName(MaNV, MaDV);
        #endregion
    }
}
