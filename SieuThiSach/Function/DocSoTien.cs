using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiSach.Function
{
    class DocSoTien
    {
        private string replace_special_word(string chuoi)
        {
            chuoi = chuoi.Replace("  ", " ");
            chuoi = chuoi.Replace("MƯƠI NĂM", "MƯƠI LĂM");
            chuoi = chuoi.Replace("MƯƠI MỘT", "MƯƠI MỐT");
            chuoi = chuoi.Replace("MƯƠI BỐN", "MƯƠI TƯ");
            chuoi = chuoi.Replace("BỐN MƯƠI TƯ", "BỐN MƯƠI BỐN");
            chuoi = chuoi + Convert.ToString("ĐỒNG");
            return chuoi;
        }

        public string ChuyenSo(string number)
        {
            string[] dv = new[] { "", "MƯƠI", "TRĂM", "NGHÌN", "TRIỆU", "TỶ" };
            string[] cs = new[] { "KHÔNG", "MỘT", "HAI", "BA", "BỐN", "NĂM", "SÁU", "BẢY", "TÁM", "CHÍN" };
            string doc;
            int i;
            int j;
            int k;
            int n;
            int len;
            int found;
            int ddv;
            int rd;
            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;
            i = 0;
            while (i < len)
            {
                n = (len - i + 2) % 3 + 1;
                found = 0;
                for (j = 0; j <= n - 1; j++)
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }

                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j <= n - 1; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                {
                                    if (n - j == 3)
                                        doc += cs[0] + " ";
                                    if (n - j == 2)
                                    {
                                        if (number[i + j + 1] != '0')
                                            doc += "LẺ ";
                                        ddv = 0;
                                    }
                                    break;
                                }
                            case '1':
                                {
                                    if (n - j == 3)
                                        doc += cs[1] + " ";
                                    if (n - j == 2)
                                    {
                                        doc += "MƯỜI ";
                                        ddv = 0;
                                    }

                                    if (n - j == 1)
                                    {
                                        if (i + j == 0)
                                            k = 0;
                                        else
                                            k = i + j - 1;
                                        if (number[k] != '1' && number[k] != '0')
                                            doc += "MỐT ";
                                        else
                                            doc += cs[1] + " ";
                                    }
                                    break;
                                }

                            case '5':
                                {
                                    if (i + j == len - 1)
                                        doc += "LĂM ";
                                    else
                                        doc += cs[5] + " ";
                                    break;
                                }

                            default:
                                {
                                    doc += cs[Convert.ToInt64(number[i + j]) - 48] + " ";
                                    break;
                                }
                        }
                        if (ddv == 1)
                            doc += dv[n - j - 1] + " ";
                    }
                }
                if (len - i - n > 0)
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k <= (len - i - n) / 9 - 1; k++)
                                doc += "TỶ ";
                        rd = 0;
                    }
                    else if (found != 0)
                        doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5')
                    return cs[Convert.ToInt64(number[0]) - 48];
            return replace_special_word(doc);
        }
    }
}
