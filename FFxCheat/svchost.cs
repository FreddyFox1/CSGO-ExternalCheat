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
using CoreEngine;

namespace FFxCheat
{
    public partial class svchost : Form
    {
        private BaseVars bs;
        public svchost()
        {
            InitializeComponent();
            bs = new BaseVars("csgo");
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            new Thread(() => wallhack.OnWallHack(bs));
        }

        private void butJump_Click(object sender, EventArgs e)
        {
            new Thread(() => wallhack.OnWallHack(bs));
        }

        private void butRadar_Click(object sender, EventArgs e)
        {
            new Thread(() => wallhack.OnWallHack(bs));
        }
    }
}
