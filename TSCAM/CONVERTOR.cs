using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSecure
{
    public class CONVERTOR
    {
        public static string SB(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public static string BS(string data)
        {
            List<byte> byteList = new List<byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
        public static void Encrypt(string pass, out string encode)
        {
            CONTROLLER.EAlterSplit(pass, out string set1, out string set2, out string set3, out string set4, out string set5, out string set6);
            CONTROLLER.PassAlter(ref set1, ref set2, ref set3, ref set4, ref set5, ref set6, out string Alterpass);
            CONTROLLER.EPassSplit(Alterpass, out string pass1, out string pass2);
            string bpass1 = new string(CONVERTOR.SB(pass1));
            string bpass2 = new string(CONVERTOR.SB(pass2));
            encode = "00" + bpass1 + "1000" + bpass2 + "00";
        }
        public static void Decrypt(string encode, out string decode)
        {
            CONTROLLER.DAlterSplit(encode, out string d1, out string d2);
            string dpass1 = new string(CONVERTOR.BS(d1));
            string dpass2 = new string(CONVERTOR.BS(d2));
            decode = dpass1 + dpass2;

        }
    }
}
