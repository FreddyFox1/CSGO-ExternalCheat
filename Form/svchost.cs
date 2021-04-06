using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Engine.General;
using Engine.Globals;

namespace FFx
{
    public partial class svchost : Form
    {
        private BaseVars bs;
        private Color Color;

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
                    if (Color != Color.Empty)
                        Wallhack.On(bs, Color);
                    else
                        Wallhack.On(bs);
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
                    Radar.On(bs);
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
                    BunnyHope.On(bs);
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
                    NoFlash.On(bs);
                })
                {
                    IsBackground = true,
                    Priority = ThreadPriority.Normal
                }.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Color = colorDialog.Color;
            button1.BackColor = Color;

        }
    }
}