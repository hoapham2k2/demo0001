using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApp4
{
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(MaterialSkinManager x)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = x.Theme;
            materialSkinManager.ColorScheme = x.ColorScheme;
            InitializeComponent();

        }

        public Boolean chkSound = false;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            chkSound = !chkSound;
            if (chkSound)
            {
                materialButton1.Text = "Tắt âm thanh";
                Bitmap image = Bitmap.FromFile(@"D:\Workspace\VisualStudio\WindowsFormsApp1\WindowsFormsApp4\Resource\mute_32px.png") as Bitmap;
                Bitmap resize = new Bitmap(image);
                materialButton1.Icon = resize;
            }
            else if (chkSound == false)
            {
                materialButton1.Text = "Bật âm thanh";
                Bitmap image = Bitmap.FromFile(@"D:\Workspace\VisualStudio\WindowsFormsApp1\WindowsFormsApp4\Resource\sound_32px.png") as Bitmap;
                Bitmap resize = new Bitmap(image);
                materialButton1.Icon = resize;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(MaterialSkinManager.Instance);
            frm.Show();
            this.Dispose();
        }
    }
}
