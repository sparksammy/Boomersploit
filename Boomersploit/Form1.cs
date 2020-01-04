using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Boomersploit
{
    public partial class Form1 : Form
    {
        ExploitAPI api = new ExploitAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void injectBTN_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
            timer1.Enabled = true;
        }

        private void execBTN_Click(object sender, EventArgs e)
        {
            api.SendLuaScript(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/LoukaMB/SynapseX/master/script/compatibility_layer.lua'))()");
            api.SendLuaScript(@"wait(1.2)
game.StarterGui:SetCore('SendNotification', {
Title = 'Credits';
Text = 'Sparksammy: UI. WRD: WRD API. Louka: SynapseX Api.';
Duration = 25; --how long the notification should in secounds
})");
            timer1.Enabled = false;
        }
    }
}
