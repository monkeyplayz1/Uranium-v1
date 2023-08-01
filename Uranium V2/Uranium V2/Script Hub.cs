using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hovac_API;

namespace Uranium_V2
{
    public partial class Script_Hub : Form
    {

        ExploitAPI module = new ExploitAPI();
        public Script_Hub()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/aQ6pUxCS");
                module.SendLuaScript(Script);

        }

        private void button1_Click(object sender, EventArgs e)

        {

            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/1gbYJhgD");
            module.SendLuaScript(Script);


        }
    }
}
