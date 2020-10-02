using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Attachments = Microsoft.Office.Tools.Outlook.Attachments;
using Microsoft.Office.Interop.Outlook;

namespace OutlookControll


{
    public enum MailSendType
    {
        NoSend,
        Normal,
        WithAdverts,
        WithCoupon
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public MailSendType SendType = MailSendType.NoSend;
        private MailItem mailItem;

        private DialogResult GetAttachmentsInfo(MailItem mailItem)
        {
            StringBuilder attachmentInfo = new StringBuilder();
            Attachments mailAttachments = (Attachments)mailItem.Attachments;
            if (mailItem.Attachments.Count == 0)
            {
                return MessageBox.Show(" ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                return DialogResult.OK;
            }
        }
        private void Btn_encryption_Click(object sender, EventArgs e)
        {
   
            AddItemsForm f2 = new AddItemsForm();
            f2.ShowDialog();

            this.Hide();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            // vytvoreni a inicializace tlacitka Btn_standard_Click
            Button Btn_cancel_Click = new Button();

            // Tlacitko po stistknuti vrati hodnotu DialogResult.OK
            Btn_cancel_Click.DialogResult = DialogResult.Cancel;

            this.Hide();

        }

        public void Btn_standard_Click(object sender, EventArgs e)
        {
            // vytvoreni a inicializace tlacitka Btn_standard_Click
            Button Btn_standard_Click = new Button();

         // Tlacitko po stistknuti vrati hodnotu DialogResult.OK
            Btn_standard_Click.DialogResult = DialogResult.OK;

            Controls.Add(Btn_standard_Click);

            GetAttachmentsInfo(mailItem);
            
            SendType = MailSendType.Normal;

            this.Hide();

        }


    }
}


