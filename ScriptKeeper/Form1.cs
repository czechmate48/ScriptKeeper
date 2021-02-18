using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptKeeper
{
    public enum CodeLanguage { powershell, batch }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("hello World");
        }
    }

    public class Script
    {
        public CodeLanguage language { get; set; }
        public DateTime created { get; set; }
        public string file_path;

        public Script(CodeLanguage language, DateTime created, string file_path)
        {
            this.language = language;
            this.created = created;
            this.file_path = file_path;
        }
    }


}
