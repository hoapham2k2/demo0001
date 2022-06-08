using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApp4
{
    public partial class Form1 : MaterialForm
    {
        Font btnFont = new Font("Times New Roman", 12);
        public void editButtonAnh(Button x)
        {
            //chỉnh kích thước button
            x.Width = 220;
            x.Height = 360;
            x.Padding = new Padding(0, 0, 0, 10);
            x.FlatStyle = FlatStyle.Flat;
            x.FlatAppearance.BorderSize = 0;
            //chỉnh text
            x.Text = "Harry Potter and The Philosophi's stone";
            x.TextAlign = ContentAlignment.BottomCenter;
            x.Font = btnFont;
            //chỉnh ảnh
            x.ImageList = anhIcon;
            x.ImageIndex = 1;
            x.ImageAlign = ContentAlignment.TopCenter;
            //thêm sự kiện click
            x.Click += new EventHandler(btnClick);
        }

        public void btnClick(object Sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!!");
            Form2 frm = new Form2(a);
            frm.Show();
            this.Hide();
        }






        public void initBtn()
        {
            flowLayoutPanel1.Controls.Clear();
          
            for (int i = 0; i < 10; i++)
            {
                Button x = new Button();
                editButtonAnh(x);
                flowLayoutPanel1.Controls.Add(x);
            }
        }

        public void initDashBoard()
        {
            
            
            initBtn();
            materialComboBox1.Show();

        }

        public Form1()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            InitializeComponent();
            initDashBoard();


        }

        public Form1(int x)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            if (x == 0)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            else if (x == 1)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            InitializeComponent();
            initDashBoard();
           


        }
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public int a = 0;
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == true)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                a = 1;
            }
            else
                if (materialSwitch1.Checked == false)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                a = 0;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton1.Checked == true)
            {
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
                this.Refresh();
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked == true)
            {
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
                this.Refresh();
            }

        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(materialRadioButton3.Checked == true)
            {
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                this.Refresh();
            }
        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
