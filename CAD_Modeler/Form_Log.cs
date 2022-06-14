using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAD_Modeler
{
    public partial class Form_Log : Form
    {
        public List<string> MainLog = new List<string>();

        public Form_Log()
        {
            InitializeComponent();
        }

        private void Form_Log_Load(object sender, EventArgs e)
        {
            textBox_Log.ReadOnly = true;
        }

        public void AddLog(string message)
        {
            string time = DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss-");
            textBox_Log.Text = time + message + Environment.NewLine + textBox_Log.Text;
        }
    }
}
