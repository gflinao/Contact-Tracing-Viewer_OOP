using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_Viewer_OOP
{
    public partial class TraceViewer : Form
    {
        public TraceViewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt Files (*.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rTBfield.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnclrfld_Click(object sender, EventArgs e)
        {
            rTBfield.Clear();
        }

        private void lbltrace_Click(object sender, EventArgs e)
        {

        }

        private void pnlLbl_Paint(object sender, PaintEventArgs e)
        {
            pnlLbl.BackColor = Color.Transparent;
        }
    }
}
