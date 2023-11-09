using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A030
{
    public partial class Form1 : Form
    {
        private int _marioX = 10;
        private int _marioY = 10;
        private int _marioCount = 0;

        private int _luigiX = 10;
        private int _luigiY = 50;
        private int _luigiCount = 0;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), _marioX, _marioY, 30, 30);
            e.Graphics.FillRectangle(new SolidBrush(Color.Lime), _luigiX, _luigiY, 30, 30);
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (MarioRadioButton.Checked)
            {
                _marioX += 10;
                panel1.Refresh();
                return;
            }

            if (LuigiRadioButton.Checked)
            {
                _luigiX += 20;
                panel1.Refresh();
                return;
            }
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            if (MarioRadioButton.Checked)
            {
                _marioCount++;

                if (_marioCount == 3)
                {
                    _marioCount = 0;
                    MessageBox.Show("マリオです");
                }

                return;
            }

            if (LuigiRadioButton.Checked)
            {
                _luigiCount++;

                if (_luigiCount == 5)
                {
                    MessageBox.Show("ルイージです");
                }

                return;
            }

        }
    }
}
