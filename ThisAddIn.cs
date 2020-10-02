using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Core;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Outlook;
using System.Security.Cryptography.X509Certificates;
using MailItem = Microsoft.Office.Interop.Outlook.MailItem;
using System.Runtime.InteropServices;
using Exception = Microsoft.Office.Interop.Outlook.Exception;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using System.Threading;
using Microsoft.Office.Tools;
using Microsoft.VisualStudio.Tools.Applications.Runtime;


namespace OutlookControll
{
    public partial class ThisAddIn
    {
        // Ovladani tlacitka Odeslat funguje ve vsech pripadech
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.ItemSend += new ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);
        }

        private bool ProcessEmail(Outlook.MailItem mailItem, MailSendType SendType)
        {
            switch (SendType)
            {
                case MailSendType.Normal:
                    return false;

                case MailSendType.WithAdverts:
                    //mailItem.BCC += "ad@server.xyz";
                    mailItem.HTMLBody += @"<b>Some bold text at the end :)</b>";
                    mailItem.HTMLBody += @"1233";
                    return false; // send the mail

                case MailSendType.WithCoupon:
                    mailItem.CC += "coupon@server.xyz";
                    mailItem.HTMLBody += @"";
                    return false; // send the mail

                // by default don't send the mail
                default:
                    return true;
            }
        }


        public void SendNewEncryptedEmail(object Item, MailSendType SendType)
        {


            //Outlook.MailItem newMailItem = Application.CreateItem(Outlook.OlItemType.olMailItem);
            //Outlook.MailItem mItem = Item as Outlook.MailItem;

            //newMailItem.To = mItem.To;
            //newMailItem.Subject = mItem.Subject;
            //newMailItem.HTMLBody = mItem.HTMLBody;

            //newMailItem.Send();


        }
        private void Application_ItemSend(object Item, ref bool Cancel)
        {
            if (Item is MailItem) // ensures Item is a mail item
            {
                using (Form1 form_ChooseForm = new Form1())
                {
                    DialogResult dr = form_ChooseForm.ShowDialog();
                    if (dr == DialogResult.OK) // shows the form as a dialog
                    {
                        Cancel = ProcessEmail((MailItem)Item, form_ChooseForm.SendType);
                        MessageBox.Show("The OK button on the form was clicked.");
                           
                    }
                    else
                    {
                        MessageBox.Show("Cancel process");
                        Cancel = true;

                    }

                }   
            }
        }
        private void ItemSend_Encrpyted(object Item, ref bool Cancel)
        {
                using (AddItemsForm form_AddItemsForm = new AddItemsForm())
                {
                    DialogResult dr2 = form_AddItemsForm.ShowDialog();
                    if (dr2 == DialogResult.OK) // shows the form as a dialog
                    {
                        Cancel = ProcessEmail((MailItem)Item, form_AddItemsForm.SendType);
                        MessageBox.Show("The OK button on the form was clicked.");

                    }
                    else
                    {
                        MessageBox.Show("Cancel process");
                        Cancel = true;

                    }

                }
            }
        



        /*private void Application_ItemSend(object Item, ref bool Cancel)
        {
            using (Form1 form_ChooseForm = new Form1())
            {
                form_ChooseForm.ShowDialog();

                    if (form_ChooseForm.DialogResult == DialogResult.OK)
                        {
                     
                        ProcessEmail((Outlook.MailItem)Item, form_ChooseForm.SendType);
                        }
                        else
                        {

                            Cancel = true; // process the email with the SendType

                        }
                    }
         /*   }
        
        
        /* private void Application_ItemSend(object Item, ref bool Cancel)
         {
             if (Item is Outlook.MailItem)
             {
                 Form1 f = new Form1();
                 f.Show();
             }

             Cancel = true;
         } 
         */

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        public void OptionButtonOnAction(IRibbonControl control)
        {
            if (control.Id == "OptionButton")
            {
                System.Windows.Forms.MessageBox.Show("Button clicked");
            }
        }

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon1();
        }

        //IRibbonUI myRibbon;
        //private Explorer currentExplorer;



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        
        private void CreateUserEmail(object Item, ref bool Cancel)
        {
            Outlook.MailItem mailItem = (Outlook.MailItem)
                this.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = mailItem.Subject;
            mailItem.To = "someone@example.com";
            mailItem.Body = "This is the message.";
            mailItem.Importance = Outlook.OlImportance.olImportanceLow;
            mailItem.Display(false);
        }
    }
}
