namespace OutlookControll
{
    partial class EncryptionRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EncryptionRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonTab Encrypt;
            this.encrypting = this.Factory.CreateRibbonGroup();
            this.options = this.Factory.CreateRibbonButton();
            Encrypt = this.Factory.CreateRibbonTab();
            Encrypt.SuspendLayout();
            this.encrypting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            Encrypt.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            Encrypt.Groups.Add(this.encrypting);
            Encrypt.Label = "TabAddIns";
            Encrypt.Name = "Encrypt";
            Encrypt.Position = this.Factory.RibbonPosition.AfterOfficeId("");
            // 
            // encrypting
            // 
            this.encrypting.Items.Add(this.options);
            this.encrypting.Label = "Šifrování";
            this.encrypting.Name = "encrypting";
            // 
            // options
            // 
            this.options.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.options.Image = global::OutlookControll.Properties.Resources.logoPHP;
            this.options.Label = "Nastavení";
            this.options.Name = "options";
            this.options.ShowImage = true;
            this.options.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Options_Click);
            // 
            // EncryptionRibbon
            // 
            this.Name = "EncryptionRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(Encrypt);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EncryptionRibbon_Load);
            Encrypt.ResumeLayout(false);
            Encrypt.PerformLayout();
            this.encrypting.ResumeLayout(false);
            this.encrypting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup encrypting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton options;
    }

    partial class ThisRibbonCollection
    {
        internal EncryptionRibbon EncryptionRibbon
        {
            get { return this.GetRibbon<EncryptionRibbon>(); }
        }
    }
}
