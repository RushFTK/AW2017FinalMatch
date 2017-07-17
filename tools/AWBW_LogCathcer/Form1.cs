using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWBW_LogCathcer
{
    public partial class Main_Form : Form
    {
        address_visitor visitor;
        public Main_Form()
        {
            InitializeComponent();
            
        }

        private void taregtaddress_getbutton_Click(object sender, EventArgs e)
        {
            visitor = new address_visitor();
            visitor.target_address = targetaddress_textbox.Text;
            visitor.tester(stateinfo_label);
        }
    }
}
