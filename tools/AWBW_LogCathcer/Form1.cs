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
        debug_form debugger = new debug_form();
        public Main_Form()
        {
            InitializeComponent();
            if (global.debug_mode == true)
            {
                opendebugform_button.Visible = true;
                debugger.Visible = true;
            }
        }

        private void taregtaddress_getbutton_Click(object sender, EventArgs e)
        {
            visitor = new address_visitor();
            visitor.target_address = targetaddress_textbox.Text;
            visitor.tester(stateinfo_label,downloadprocess_progressbar);
        }

        private void opendebugform_button_Click(object sender, EventArgs e)
        {
            if (debugger != null)
            {
                debugger.Visible = true;
            }
        }
    }
}
