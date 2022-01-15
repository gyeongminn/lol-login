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
    public partial class Form2 : Form
    {
        readonly Form1 frm1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear(); //초기화
            // DataGridView에 값 불러오기
            for (int i = 0; i < Properties.Settings.Default.num; i++)
            {
                DataGridView.Rows.Add(frm1.name[i], frm1.id[i], frm1.pw[i]);
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            DataGridView.Rows.Add(); 
            Properties.Settings.Default.num++;
            Properties.Settings.Default.Save();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Properties.Settings.Default.num; i++)
            {
                if (DataGridView.Rows[i].Selected == true)
                {
                    DataGridView.Rows.Remove(DataGridView.Rows[i]);
                    Properties.Settings.Default.num--;
                    Properties.Settings.Default.Save();                    
                }
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            // 초기화
            Properties.Settings.Default.name = "";
            Properties.Settings.Default.id = "";
            Properties.Settings.Default.pw = "";
            frm1.ComboBox_Select_ID.Items.Clear();

            // DataGridView의 값을 읽어와 설정값으로 저장
            for (int i = 0; i < Properties.Settings.Default.num; i++)
            {
                Properties.Settings.Default.name += DataGridView.Rows[i].Cells[0].FormattedValue.ToString() + ',';
                Properties.Settings.Default.id += DataGridView.Rows[i].Cells[1].FormattedValue.ToString() + ',';
                Properties.Settings.Default.pw += DataGridView.Rows[i].Cells[2].FormattedValue.ToString() + ',';
            }

            // String 설정값을 String 배열로 나눠 저장
            frm1.name = Properties.Settings.Default.name.Split(',');
            frm1.id = Properties.Settings.Default.id.Split(',');
            frm1.pw = Properties.Settings.Default.pw.Split(',');
            Properties.Settings.Default.Save();

            // ComboBox에 저장
            for (int i = 0; i < Properties.Settings.Default.num; i++)
            {
                frm1.ComboBox_Select_ID.Items.Add(frm1.name[i]);
            }

            frm1.RichTextBox_Status.AppendText("저장되었습니다.\n");
            this.Close();
        }
    }
}
