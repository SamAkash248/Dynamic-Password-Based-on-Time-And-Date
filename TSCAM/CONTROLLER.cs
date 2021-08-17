using System;
using System.Collections.Generic;
using System.Linq;

namespace TimeSecure
{
    public class CONTROLLER
    {
        public static void Swap(ref string x, ref string y)
        {
            string tempswap = x;
            x = y;
            y = tempswap;
        }

        public static void PassAlter(ref string set1, ref string set2, ref string set3, ref string set4, ref string set5, ref string set6, out string Alterpass)
        {
            string tempset = set1;
            set1 = set4;
            set4 = tempset;
            Alterpass = set1 + set2 + set3 + set4 + set5 + set6;
        }

        public static void EAlterSplit(string main, out string set1, out string set2, out string set3, out string set4, out string set5, out string set6)
        {
            char[] c = main.ToCharArray();
            set1 = new string(c[0..1]);
            set2 = new string(c[1..2]);
            set3 = new string(c[2..4]);
            set4 = new string(c[4..7]);
            set5 = new string(c[7..9]);
            set6 = new string(c[9..11]);
        }
        public static void EPassSplit(string newpass, out string pass1, out string pass2)
        {
            char[] c = newpass.ToCharArray();
            pass1 = new string(c[0..7]);
            pass2 = new string(c[7..11]);
        }
        public static void DAlterSplit(string main, out string dpass1,out string dpass2)
        {
            char[] c = main.ToCharArray();
            string s1 = new string(c[0..2]);
            string s2 = new string(c[2..58]);
            string s3 = new string(c[58..62]);
            string s4 = new string(c[62..94]);
            string s5 = new string(c[94..96]);
            dpass1 = new string(s2);
            dpass2 = new string(s4);
        }

        #region Password Generator

        public static string  mddvalue;
        public static string tcvalue;
        public static Dictionary<string, string> tw = new Dictionary<string, string>()
        {
            {"0","z"},
            {"1","o"},
            {"2","t"},
            {"3","t"},
            {"4","f"},
            {"5","f"},
            {"6","s"},
            {"7","s"},
            {"8","e"},
            {"9","n"}
        };
        public static string tw1;
        public static string tw2;
        public static string words;

        public static void MDDGenerator(out string MDDcode)
        {
            var dt = DateTime.Now;
            string month = new string(dt.ToString("MMMM"));
            string date = new string(dt.ToString("dd"));
            string day = new string(dt.ToString("dddd"));
            string time = new string(dt.ToString("HHmm"));
            Char[] t = time.ToCharArray();
            Char[] M = month.ToCharArray();
            Char[] dd = day.ToCharArray();
            Char[] d = date.ToCharArray();
            string M1 = new string(M[0..1]);
            string dd1 = new string(dd[0..1]);
            string d1 = new string(d[0..2]);
            string t4 = new string(t[3..4]);
            if (t4 == "1" || t4 == "3" || t4 == "5" || t4 == "7" || t4 == "9")
            {
                mddvalue = M1.ToLower() + d1 + dd1.ToUpper();
            }
            if (t4 == "2" || t4 == "4" || t4 == "6" || t4 == "8")
            {
                mddvalue = d1 + dd1.ToLower() + M1.ToUpper();
            }
            if (t4 == "0")
            {
                mddvalue = dd1.ToLower() + d1 + M1.ToUpper();
            }
            MDDcode = mddvalue;
        }

        public static void TCGenerator(out string TCcode)
        {
            var dt = DateTime.Now;
            string time = new string(dt.ToString("HHmm"));
            Char[] t = time.ToCharArray();
            string t1 = new string(t[0..1]);
            string t2 = new string(t[1..2]);
            string t3 = new string(t[2..3]);
            string t4 = new string(t[3..4]);
            CONTROLLER.Talter(t1, t2, t3, t4, out string code);
            TCcode = code;
        }
        public static void Twords(string time1, string time2,out string twords)
        {
            for (int i = 0; i < 10; i++)
            {
                string key1 = tw.ElementAt(i).Key;
                string value1 = tw.ElementAt(i).Value;
                if (time1 == key1)
                {
                    tw1 = value1;
                }
            }
            for (int j = 0; j < 10; j++)
            {
                string key2 = tw.ElementAt(j).Key;
                string value2 = tw.ElementAt(j).Value;
                if (time2 == key2)
                {
                    tw2 = value2;
                }
            }
            twords = tw1.ToLower() + tw2.ToUpper();
        }
        public static void Talter(string t1, string t2, string t3, string t4, out string newvalue)
        {
            

            if (t4 == "1" || t4 == "7")
            {
                tcvalue = new string(t1 + t2);
                Twords(t1, t2, out string twords);
                words = twords;
            }
            if (t4 == "6")
            {
                tcvalue = new string(t4 + t3);
                Twords(t4, t3, out string twords);
                words = twords;
            }
            if (t4 == "2" || t4 == "5" || t4 == "8")
            {
                tcvalue = new string(t3 + t4);
                Twords(t3, t4, out string twords);
                words = twords;
            }
            if (t4 == "4" || t4 == "9")
            {
                tcvalue = new string(t4 + t3);
                Twords(t4, t3, out string twords);
                words = twords;
            }
            if (t4 == "3")
            {
                tcvalue = new string(t2 + t1);
                Twords(t2, t1, out string twords);
                words = twords;
            }
            if (t4 == "0")
            {
                tcvalue = new string(t4 + t3);
                Twords(t4, t3, out string twords);
                words = twords;
            }
            newvalue = tcvalue + words;
        }
        #endregion
    }
}