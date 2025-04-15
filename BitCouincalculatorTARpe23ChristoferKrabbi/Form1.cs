using System.Net;

namespace BitCouincalculatorTARpe23ChristoferKrabbi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currencyselector.SelectedItem.ToString() == "USD")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newbitcoinrate.Data.BTCUSD.VALUE;
                resultlabel.Text = $"{result} Bitcoin dollarites";
            }
        }

        private BitcoinRates GetRates()
        {
            string url = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=ccix&instruments=BTC-USD&api_key={a398491fe27ddb1ffd986003f293e46a6991327a73fd0ebbfe87229a620e7a42}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
             
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
