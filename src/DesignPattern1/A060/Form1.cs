using A060.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A060
{
    public partial class Form1 : Form
    {
        //private int _marioX = 10;
        //private int _marioY = 10;
        private int _marioCount = 0;

        //private int _luigiX = 10;
        //private int _luigiY = 50;
        private int _luigiCount = 0;

        private List<CharaBase> _charaList = new List<CharaBase>();
        private CharaBase _selectedChara;

        private CharaBase _mario = new Mario();
        private CharaBase _luigi = new Luigi();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _charaList.Add(_mario);
            _charaList.Add(_luigi);

            _selectedChara = _charaList[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), _marioX, _marioY, 30, 30);
            //e.Graphics.FillRectangle(new SolidBrush(Color.Lime), _luigiX, _luigiY, 30, 30);

            foreach (var chara in _charaList)
            {
                e.Graphics.FillRectangle(new SolidBrush(chara.Color), chara.X, chara.Y, 30, 30);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            //if (MarioRadioButton.Checked)
            //{
            //    _marioX += 10;
            //    panel1.Refresh();
            //    return;
            //}

            //if (LuigiRadioButton.Checked)
            //{
            //    _luigiX += 20;
            //    panel1.Refresh();
            //    return;
            //}

            _selectedChara.MoveRight();
            panel1.Refresh();
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
                    _luigiCount = 0;
                    MessageBox.Show("ルイージです");
                }

                return;
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MarioRadioButton.Checked)
            {
                _selectedChara = _mario;
                return;
            }

            if (LuigiRadioButton.Checked)
            {
                _selectedChara = _luigi;
                return;
            }
        }
    }
}
