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
        // Pomocne stringy pro prehledny formular
        
        public string Phone_Name  = "Telefonní číslo: " ;
        public string Date_Send = "Datum odeslani: ";
        public string Date_Expiration = "Datum expirace ";
        public string ID_Message = "ID Zpravy: ";
        public string SMS_Code = "SMS Code: ";
        public string URL = "URL adresa: ";
        public string URL_Attribute = "&=";
        public string URL_Address = "https://sluzby.programhplus.cz/";

        private void Btn_cancel_encrypt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_send_ecrypt_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // vytvoreni a inicializace tlacitka Btn_standard_Click
            Button Btn_send_ecrypt_Click = new Button();

            // Tlacitko po stistknuti vrati hodnotu DialogResult.OK
            Btn_send_ecrypt_Click.DialogResult = DialogResult.OK;

            Controls.Add(Btn_send_ecrypt_Click);
=======
                // vytvoreni a inicializace tlacitka Btn_standard_Click
                Button Btn_send_ecrypt_Click = new Button();

                // Tlacitko po stistknuti vrati hodnotu DialogResult.OK
                Btn_send_ecrypt_Click.DialogResult = DialogResult.OK;

                Controls.Add(Btn_send_ecrypt_Click);
>>>>>>> c0e768362f64f2594c02ee214df8c6ed4c46652a


            if (Txt_phone1 == String.Empty)
            {
                string message = "Není zadáno telefonní číslo, nelze odeslat email.";
                string title = "Varování";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);

                AddItemsForm f2 = new AddItemsForm();
                f2.ShowDialog();
            }
<<<<<<< HEAD

            else
            {
                // prevzeti dat z ActiveCurentItem
                Microsoft.Office.Interop.Outlook.Application application = new Microsoft.Office.Interop.Outlook.Application();
                Inspector inspector = application.ActiveInspector();

                if (inspector.CurrentItem is MailItem inspectorMailItem)
                {
                    String Subject = inspectorMailItem.Subject;
                    String EmailAddress = inspectorMailItem.To;

                    // volani tridy IdMessage
                    IdMessage idMessage = new IdMessage();
                    idMessage.RandomIdMessage(100000, 999999);

                    string RiD = Convert.ToString(idMessage.RandomIdMessage(10000, 999999));

                    // volani tridy SmsPassword
                    SmsPassword smsPassword = new SmsPassword();
                    smsPassword.RNGPasswordString(6);

                    string RCode = smsPassword.RNGPasswordString(6);

                    // volani tridy UrlAttribute
                    UrlAttribute urlAttribute = new UrlAttribute();
                    urlAttribute.RNGUrlAttributeString(32);

                    string RUrl = urlAttribute.RNGUrlAttributeString(32);


                    // testovani zobrazovanych promennych z formulare a generovani ID
                    List<string> MyListValues = new List<string>() { Phone_Name + Txt_phone1,
                                                                 Date_Send + ThisDate,
                                                                 Date_Expiration + ExpirationDate,
                                                                 ID_Message + RiD,
                                                                 SMS_Code + RCode,
                                                                 URL + URL_Address + RUrl + URL_Attribute + RiD, EmailAddress, Subject};
                    string delimetr = "\n\n";
                    string messageBoxContent = String.Join(delimetr, MyListValues);
                    MessageBox.Show(messageBoxContent);
                }

            }
        }
=======
      
            else {
                // volani tridy IdMessage
                IdMessage idMessage = new IdMessage();
                idMessage.RandomIdMessage(100000,999999);

                string RiD = Convert.ToString(idMessage.RandomIdMessage(10000,999999));

                // volani tridy SmsPassword
                SmsPassword smsPassword = new SmsPassword();
                smsPassword.RNGPasswordString(6);

                string RCode = smsPassword.RNGPasswordString(6);

                // volani tridy UrlAttribute
                UrlAttribute urlAttribute = new UrlAttribute();
                urlAttribute.RNGUrlAttributeString(32);

                string RUrl = urlAttribute.RNGUrlAttributeString(32);


                // testovani zobrazovanych promennych z formulare a generovani ID
                List<string> MyListValues = new List<string>() { Phone_Name + Txt_phone1, 
                                                                 Date_Send + ThisDate, 
                                                                 Date_Expiration + ExpirationDate, 
                                                                 ID_Message + RiD, 
                                                                 SMS_Code + RCode, 
                                                                 URL + URL_Address + RUrl + URL_Attribute + RiD,};
                    string delimetr = "\n\n";
                    string messageBoxContent = String.Join(delimetr, MyListValues);
                    MessageBox.Show(messageBoxContent);
                    }

            }
>>>>>>> c0e768362f64f2594c02ee214df8c6ed4c46652a

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
