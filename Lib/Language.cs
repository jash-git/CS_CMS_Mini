using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Lib
{
    public class Language
    {

        static public ArrayList ALStrName = new ArrayList();
        static public ArrayList ALStrValue = new ArrayList();

        static public String m_StrMainMenu01;
        static public String m_StrMainMenu02;
        static public String m_StrMainMenu03;
        static public String m_StrMainMenu04;

        static public String m_StrSubMenu01_01;
        static public String m_StrSubMenu01_02;

        static public String m_StrSubMenu02_01;
        static public String m_StrSubMenu02_02;
        static public String m_StrSubMenu02_03;

        static public String m_StrSubMenu03_01;
        static public String m_StrSubMenu03_02;
        static public String m_StrSubMenu03_03;
        static public String m_StrSubMenu03_04;

        static public String m_StrSubMenu04_01;

        static public void initVar(int intswitch=0)
        {
            //ReadLangSet(Int32.Parse(CpuReaderTest.QRCode.m_Settings.m_StrLanguage));
            ReadLangSet(intswitch);
            ALStr2Var();
        }
        static public void ReadLangSet(int index)
        {
            //ALStr.Clear();
            //int i = 0;
            ALStrName.Clear();
            ALStrValue.Clear();
            StreamReader sr = null;
            switch (index)
            {
                case 0:
                    sr = new StreamReader("language\\tw.sycsv");//csv->sycsv//修改語系檔放在執行檔目錄下的language資料夾中 at 2017/04/06
                    break;
                case 1:
                    sr = new StreamReader("language\\cn.sycsv");//csv->sycsv//修改語系檔放在執行檔目錄下的language資料夾中 at 2017/04/06
                    break;
                case 2:
                    sr = new StreamReader("language\\en.sycsv");//csv->sycsv//修改語系檔放在執行檔目錄下的language資料夾中 at 2017/04/06
                    break;
                case 3:
                    sr = new StreamReader("language\\other.sycsv");//csv->sycsv//修改語系檔放在執行檔目錄下的language資料夾中 at 2017/04/06
                    break;
            }
            while (!sr.EndOfStream)// 每次讀取一行，直到檔尾
            {
                string line = sr.ReadLine();// 讀取文字到 line 變數
                if (line.Length > 0 && line.IndexOf(',') > 0)
                {
                    //String StrBuf = line.Substring(line.IndexOf(',') + 1);
                    string[] strs = line.Split(',');
                    ALStrName.Add(strs[0]);
                    ALStrValue.Add(strs[1]);
                    //ALStr.Add(StrBuf);
                    //i++;
                }
            }
            sr.Close();// 關閉串流
        }
        static public void ALStr2Var()
        {
            m_StrMainMenu01 = (String)ALStrValue[ALStrName.IndexOf("m_StrMainMenu01")];
            m_StrMainMenu02 = (String)ALStrValue[ALStrName.IndexOf("m_StrMainMenu02")];
            m_StrMainMenu03 = (String)ALStrValue[ALStrName.IndexOf("m_StrMainMenu03")];
            m_StrMainMenu04 = (String)ALStrValue[ALStrName.IndexOf("m_StrMainMenu04")];

            m_StrSubMenu01_01 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu01_01")];
            m_StrSubMenu01_02 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu01_02")];

            m_StrSubMenu02_01 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu02_01")];
            m_StrSubMenu02_02 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu02_02")];
            m_StrSubMenu02_03 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu02_03")];

            m_StrSubMenu03_01 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu03_01")];
            m_StrSubMenu03_02 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu03_02")];
            m_StrSubMenu03_03 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu03_03")];
            m_StrSubMenu03_04 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu03_04")];

            m_StrSubMenu04_01 = (String)ALStrValue[ALStrName.IndexOf("m_StrSubMenu04_01")];
        }
}//Language
}
