using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public int checkNum01;
        public Form2(int x)
        {

            checkNum01 = x;
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
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1(checkNum01);
            frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(checkNum01);
            frm.Show();
            this.Hide();
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        public Boolean chkLike = false;

        private void button1_Click(object sender, EventArgs e)
        {
            chkLike = !chkLike;
            if (chkLike)
            {
                button1.Text = "Liked";
            }
            else if (chkLike == false)
            {
                button1.Text = "Like";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    chkLike = !chkLike;
        //    if(chkLike)
        //    {
        //        button1.Text = "Liked";
        //    }    
        //    else if(chkLike == false)
        //    {
        //        button1.Text = "Like";
        //    }
        //}
    }
}
