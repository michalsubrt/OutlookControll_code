using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace OutlookControll
{
    public partial class EncryptionRibbon
    {
        private void EncryptionRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Options_Click(object sender, RibbonControlEventArgs e)
        {
            OptionsForm f3 = new OptionsForm();
            f3.ShowDialog();
        }

        private void options_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
