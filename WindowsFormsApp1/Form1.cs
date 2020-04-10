using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            RequestParams requestParams = new RequestParams();
            
            string startDate = dateTimePicker1.Value.ToShortDateString();
            string endDate = dateTimePicker.Value.ToShortDateString();
            string patientId = textBox1.Text;
            string idNum = textBox2.Text;

            if (string.IsNullOrEmpty(startDate) == false)
            {
                requestParams.StartTime = startDate;
            }
            if (string.IsNullOrEmpty(endDate) == false)
            {
                requestParams.EndTime = endDate;
            }
            if (string.IsNullOrEmpty(patientId) == false)
            {
                requestParams.Pid = patientId;
            }
            if (string.IsNullOrEmpty(idNum) == false)
            {
                requestParams.Gid = idNum;
            }

            string json = JsonConvert.SerializeObject(requestParams);
            MessageBox.Show(json);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    public class RequestParams
    {
        public string StartTime { get; set; }         //開始時間
        public string EndTime { get; set; }             //結束時間
        public string Pid { get; set; }          //病歷號
        public string Gid { get; set; }  //身份證字號
    }
}

