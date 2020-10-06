using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookControll
{
    public partial class AdvanceForm : Form
    {
        public AdvanceForm()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Visible = false;


        }
        public MailSendType SendType = MailSendType.NoSend;
        


        private void Btn_encryption2_Click(object sender, EventArgs e)
        {
            string Hidden_Items = Btn_encryption2.Text;

            switch (Hidden_Items)
            {
                case "Expand":
                    flowLayoutPanel1.Visible = true;
                    break;
                case "Reduce":
                    flowLayoutPanel1.Visible = false;
                    break;
            }
            Btn_encryption2.Text = "Reduce";

                if(flowLayoutPanel1.Visible == true)
                {
                    Btn_encryption2.Text = "Reduce";
                }
                else if(panel1.Visible == false)
                {
                    Btn_encryption2.Text = "Expand";
                }
        
            }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_standard_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
