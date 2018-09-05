using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page
{
    public partial class pageEngineer : UserControl
    {
        public pageEngineer()
        {
            InitializeComponent();
        }

        private void lblDebug_Click(object sender, EventArgs e)
        {
            Form f= new pageDebug();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            
        }
    }
}
