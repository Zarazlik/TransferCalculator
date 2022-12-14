using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TransferСalculation.History
{
    internal class HistoryManager
    {     
        public List<DayExchangec> GetLastDays(short CountDays)
        {   
            List<DayExchangec> days = new List<DayExchangec>();
            string[] strings;

            using (StreamReader SR = new StreamReader(Application.StartupPath + "\\History.txt"))
            {
                strings = SR.ReadToEnd().Split("\r\n");
            }

            foreach(string str in strings)
            {
                string[] dstastrings = str.Split(' ');
                DayExchangec de = new DayExchangec();
                de.date = DateOnly.Parse(dstastrings[0]);
                de.RUBtoTL = double.Parse(dstastrings[1]);
                de.TLtoUSD = double.Parse(dstastrings[2]);
                days.Add(de);
            }

            return days;
        }
        
        public void Write(DayExchangec dayExchangec)
        {
            string str = "";

            using (StreamReader SR = new StreamReader(Application.StartupPath + "\\History.txt"))
            {
                char[] c = new char[10];
                SR.Read(c,0,10);
                foreach(char ch in c)
                {
                    str += ch;
                }
            }

            if (str != dayExchangec.date.ToString())
            {
                using (StreamReader SR = new StreamReader(Application.StartupPath + "\\History.txt"))
                {
                    str = SR.ReadToEnd();
                }
                using (FileStream FS = File.OpenWrite(Application.StartupPath + "\\History.txt"))
                {
                    FS.Write(Encoding.UTF8.GetBytes
                        (dayExchangec.date.ToString() + " " + dayExchangec.RUBtoTL.ToString() + " " + dayExchangec.TLtoUSD.ToString() + "\r\n" + str));
                }
            }
        }
    }
}
