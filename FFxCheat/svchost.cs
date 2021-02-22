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
            Start();
        }

        private void Start()
        {

            if (cbWh.Checked)
            {
                new Thread(() =>
                {
                    Wallhack.OnWallHack(bs);
                })
                {
                    IsBackground = true,
                    Priority = ThreadPriority.Normal
                }.Start();
            }
            if (cbRh.Checked)
            {
                new Thread(() =>
                {
                    Radar.onRadarHack(bs);
                })
                {
                    IsBackground = true,
                    Priority = ThreadPriority.Normal
                }.Start();
            }
            if (cbBh.Checked)
            {
                new Thread(() =>
                {
                    BunnyHope.onBunnyHope(bs);
                })
                {
                    IsBackground = true,
                    Priority = ThreadPriority.Normal
                }.Start();
            }
            if (cbFh.Checked)
            {
                new Thread(() =>
                {
                    NoFlash.OnNoFlash(bs);
                })
                {
                    IsBackground = true,
                    Priority = ThreadPriority.Normal
                }.Start();
            }
        }

    }
}
