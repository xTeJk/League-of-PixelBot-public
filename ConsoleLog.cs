using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueBot.Constants;
using LeagueBot.Windows;

namespace LeagueBot
{
    public partial class ConsoleLog : Form
    {
        public ConsoleLog()
        {
            InitializeComponent();
        }

        private void ConsoleLog_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            this.TransparencyKey = BackColor;
            //
            //TEST
            //
            Thread.Sleep(1000);
            richTextBox1.AppendText(Environment.NewLine + "[" + DateTime.Today + "] TEST");
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
