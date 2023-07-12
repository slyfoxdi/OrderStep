using OrderStep.Api.Extension.Http;
using OrderStep.Api.Intregration;
using OrderStep.Api.Model.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderStep.Api
{
    public partial class Transfer : Form
    {
        Timer Timer = new Timer();
        private readonly IOrderReference _orderReference;

        public Transfer(params object[] arg)
        {
            InitializeComponent();
            StartTime();
            Load(arg);
            var httpClientService = new OrderStepHttpClientService("http://localhost:5143/", string.Empty, string.Empty);
            _orderReference = new OrderReference(httpClientService);
        }

        private void Load(object[] arg)
        {
            var user = arg[0] as Client;
            userFioLable1.Text = user.FirstName + " " + user.LastName[0] + ".";
        }

        private void StartTime()
        {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }

        //-----------------------------------------
        void timer_Tick(object sender, EventArgs e)
        {
            timerLable1.Text = DateTime.Now.ToLongTimeString();
            dateLable1.Text = DateTime.Now.ToShortDateString();
        }

    }
}
