using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.CSS;
using OpenQA.Selenium.Edge;
using TransferСalculation.History;

namespace TransferСalculation
{
    public partial class Form1 : Form
    {
        HistoryManager HistoryManager;
        Chart Chart;

        string EdgeDriverPath;

        DayExchangec DayExchangec = new DayExchangec();
        List<DayExchangec> History;
        int ViewDays = 90;

        #region Colculation
        double RUB;
        double TL;
        double USD;

        double ZiratTax = 0.04;
        double KoronaTax = 99;
        #endregion

        public Form1()
        {
            InitializeComponent();
            new HistoryManager().GetLastDays(ViewDays);
            Chart = new Chart(pictureBox1, ViewDays, 0, 100, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            GetData();
            DayExchangec.date = DateOnly.FromDateTime(DateTime.Now);
            new HistoryManager().Write(DayExchangec);
            panel1.Enabled = true;
            
            textBox3.Text = "100";
            Count_USD();

            History = new HistoryManager().GetLastDays(ViewDays);
            Chart.Update(HistoryToMassive());

            double[][] HistoryToMassive()
            {
                double[][] mas = new double[3][];
                for (int i = 0; )
                {

                }
            }
        }

        #region Colculation
        void Count_USD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                USD = Convert.ToDouble(textBox3.Text);
                TL = USD * DayExchangec.TLtoUSD;
                RUB = TL * DayExchangec.RUBtoTL + KoronaTax;
                ViewResoult();
            }
        }
        void Count_USD()
        {
            USD = Convert.ToDouble(textBox3.Text);
            TL = USD * DayExchangec.TLtoUSD;
            RUB = TL * DayExchangec.RUBtoTL + KoronaTax;
            ViewResoult();
        }

        void Count_TL(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                TL = Convert.ToDouble(textBox2.Text);
                USD = TL / DayExchangec.TLtoUSD;
                RUB = TL * DayExchangec.RUBtoTL + KoronaTax;
                ViewResoult();
            }
        }

        void Count_RUB(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                RUB = Convert.ToDouble(textBox1.Text);
                TL = (RUB - KoronaTax) / DayExchangec.RUBtoTL;
                USD = TL / DayExchangec.TLtoUSD;
                ViewResoult();
            }
        }
        #endregion

        void GetData()
        {
            IWebDriver webDriver = new EdgeDriver("C:\\My folder\\Programing\\Out Drivers\\Edge 107");

            //KoronaPay RUB to TL
            webDriver.Navigate().GoToUrl("https://koronapay.com/transfers/pages/online-perevod-v-turciyu.aspx");

            webDriver.FindElement(By.ClassName("select-box-display")).Click();
            webDriver.FindElement(By.XPath("/html/body/form/div[5]/div/div[1]/div/div[3]/div[3]/div[1]/div/ul/li[2]")).Click();
            webDriver.FindElement(By.ClassName("input-box")).SendKeys("1");

            while (webDriver.FindElement(By.ClassName("tariff-data")) == null) ;

            string s = "";
            while (s == "")
            {
                s = webDriver.FindElement(By.ClassName("tariff-data")).Text;
            }

            string[] list = s.Split(' ');
            DayExchangec.RUBtoTL = Convert.ToDouble(list[0]);

            Lable_RuToTl.Text = DayExchangec.RUBtoTL.ToString();


            //ZiratBank TL to USD
            webDriver.Navigate().GoToUrl("https://www.ziraatbank.com.tr/en");


            s = "";
            while (s == "")
            {
                s = webDriver.FindElement(By.XPath("/html/body/form/div[3]/div/div[2]/div[1]/div[2]/div/div/div[1]/div/div[2]/div[1]/div/div/ul/li[1]/div/div[2]/span")).Text; ;
            }
            s = s.Replace('.', ',');
            DayExchangec.TLtoUSD = Convert.ToDouble(s);
            Lable_TlToUsd.Text = DayExchangec.TLtoUSD.ToString();

            // END
            webDriver.Close();
            webDriver.Quit();
        }

        void ViewResoult()
        {
            textBox1.Text = RUB.ToString();
            textBox2.Text = TL.ToString();
            textBox3.Text = USD.ToString();
        }
    }
}