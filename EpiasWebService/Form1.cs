using EpiasModels.Market;
using System.Net;

namespace EpiasWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGetData_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtStartDate.Value;
            DateTime endDate = dtEndDate.Value;
            EpiasModels.Market.dayAheadMCPResponse data = new dayAheadMCPResponse();

            string urlWebService = data.getURL(startDate, endDate);
            string txtWebService = "";

            try
            {
                WebClient client = new WebClient();
                txtWebService = client.DownloadString(urlWebService);
                data = Newtonsoft.Json.JsonConvert.DeserializeObject<dayAheadMCPResponse>(txtWebService);

                if (data.resultCode == "0")
                {
                    dgDataWs.DataSource = data.body.dayAheadMCPList;
                    dgDataWs2.DataSource = data.body.statistics;
                }
                else
                {
                    MessageBox.Show("Web Service Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}