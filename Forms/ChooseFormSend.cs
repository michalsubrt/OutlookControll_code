using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Attachments = Microsoft.Office.Tools.Outlook.Attachments;
using Microsoft.Office.Interop.Outlook;
using System.Linq;

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


        private void Btn_encryption_Click(object sender, EventArgs e)
        { 
            Microsoft.Office.Interop.Outlook.Application application = new Microsoft.Office.Interop.Outlook.Application();
            Inspector inspector = application.ActiveInspector();

            if (inspector.CurrentItem is MailItem inspectorMailItem)
            {
                String Subject = inspectorMailItem.Subject;
                String EmailAddress = inspectorMailItem.To;

                // kontrola zda je prilozena priloha
                if (inspectorMailItem.Attachments.Count == 0)
                {

                    MessageBox.Show("Není přiložena příloha");

                    this.Hide();

                } else {

                    AddItemsForm f2 = new AddItemsForm();
                    f2.ShowDialog();

                    this.Hide();
                }

            }
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

            SendType = MailSendType.Normal;

            this.Hide();

        }

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

    }
}




