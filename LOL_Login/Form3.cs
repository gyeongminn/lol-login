using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_Login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // 설정값 불러와서 체크
            if (Properties.Settings.Default.resolution == false)
                RadioButton_FHD.Checked = true;
            else
                RadioButton_QHD.Checked = true;

            if (Properties.Settings.Default.scaling == 100)
                RadioButton_100.Checked = true;
            else
                RadioButton_125.Checked = true;
        }

        private void RadioButton_FHD_CheckedChanged(object sender, EventArgs e)
        {
            // 설정값 변경 후 저장
            Properties.Settings.Default.resolution = false;
        }

        private void RadioButton_QHD_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.resolution = true;
        }

        private void RadioButton_100_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.scaling = 100;
        }

        private void RadioButton_125_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.scaling = 125;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}
