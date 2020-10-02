using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Outlook;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Security.Cryptography;

namespace OutlookControll
{

    public partial class AddItemsForm : Form
    {

        public MailSendType SendType = MailSendType.NoSend;
        public AddItemsForm()
        {
            InitializeComponent();
        }

        string ExpirationDate;
        
        // Dnesni datum odeslani zpravy
        string ThisDate = DateTime.Now.ToString("d/M/yyyy");

        private void Txt_phone_text(object sender, EventArgs e)
        // Nacteni promenne Phone_text
        {

        }
        // Promenna Phone Number a prirazeni
        public string Txt_phone1
        {
            get { return txt_phone.Text; }
            set { txt_phone.Text = value; }
        }

        private void Btn_cancel_encrypt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_send_ecrypt_Click(object sender, EventArgs e)
        {
                // vytvoreni a inicializace tlacitka Btn_standard_Click
                Button Btn_send_ecrypt_Click = new Button();

                // Tlacitko po stistknuti vrati hodnotu DialogResult.OK
                Btn_send_ecrypt_Click.DialogResult = DialogResult.OK;

                Controls.Add(Btn_send_ecrypt_Click);

            if (Txt_phone1 != null)
            {
                MessageBox.Show("Není zadáno telefonní číslo, nelze odeslat email.", "Varování");
                
                ();
                
            } else {

                // testovani zobrazovanych promennych z formulare a generovani ID
                List<string> MyListValues = new List<string>() { Txt_phone1, ThisDate, ExpirationDate };
                string delimetr = "\n";
                string messageBoxContent = String.Join(delimetr, MyListValues);
                MessageBox.Show(messageBoxContent);
            }

        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            // 1 den
            ExpirationDate = DateTime.Now.AddDays(+1).ToString("d/M/yyyy");
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            // 7 dni
            ExpirationDate = DateTime.Now.AddDays(+7).ToString("d/M/yyyy");
        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {
            // 30 dni
            ExpirationDate = DateTime.Now.AddDays(+30).ToString("d/M/yyyy");
        }

        private void ExpirationDateGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
