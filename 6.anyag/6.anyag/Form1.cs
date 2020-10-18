using _6.anyag.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.anyag
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            ElsoFveny();
        }
        BindingList<RateData> Rates = new BindingList<RateData>();



        /* public void ElsoFveny()
        {
           // var mnbService = new MNBArfolyamServiceSoapBody()

           var request = new GetExchangeRatesRequestBody();
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                enDate = "2020-06-30"

            };
            
            var response = mnbService.GetExchangeRates(request);
            
            var result = response.GetExchangeRatesResult;

        }
        */
        public void XML()
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
