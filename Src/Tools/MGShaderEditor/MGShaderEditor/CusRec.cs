using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MGShaderEditor
{
    public partial class CusRec : Form
    {
        public class Rec
        {
            public int Width;
            public int Height;
        }

        public Rec ReturnValue;
        public CusRec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue = new Rec()
            {
                Width = (int)tbxWidth.Value,
                Height = (int)tbxHeight.Value,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CusRec_Load(object sender, EventArgs e)
        {
            tbxWidth.Value = MainForm.Config.RecWidth;
            tbxHeight.Value = MainForm.Config.RecHeight;
        }
    }
}
