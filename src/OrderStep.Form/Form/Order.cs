using OrderStep.Api.Model;
using OrderStep.Api.Model.Request;
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
    public partial class Order : Form
    {
        Timer Timer = new Timer();

        public Order(params object[] arg)
        {
            InitializeComponent();
            StartTime();
            Load(arg);
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

        private void addButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(dataGridView1.Rows.Count.ToString());
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index == 0)
            {
                return;
            }

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            {
                return;
            }

            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            dataGridView1.CurrentCell.ReadOnly = false;
            dataGridView1.BeginEdit(true);
        }

        private void saveButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            var orderList = new List<OrderRequest>();
            
            foreach(DataGridViewRow dataGridRow in dataGridView1.Rows)
            {
                if(dataGridRow.Cells[0].Value == null)
                {
                    continue;
                }

                var order = new OrderRequest()
                {
                    Id = dataGridRow.Cells[0].Value.ToString() ?? string.Empty,
                    VendorCode = dataGridRow.Cells[1].Value.ToString() ?? string.Empty,
                    Name = dataGridRow.Cells[2].Value.ToString() ?? string.Empty,
                    Weight = dataGridRow.Cells[3].Value.ToString() ?? string.Empty,
                    Count = int.Parse(dataGridRow.Cells[4].Value.ToString() ?? string.Empty),
                    Address = dataGridRow.Cells[5].Value.ToString() ?? string.Empty,
                    Price = double.Parse(dataGridRow.Cells[6].Value.ToString() ?? string.Empty)
                };

                orderList.Add(order);
            }
            
        }
    }
}
