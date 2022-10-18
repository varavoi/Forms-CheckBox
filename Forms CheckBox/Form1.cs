using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_CheckBox
{
    public partial class Form1 : Form
    {
        bool b;
        bool k;
        bool u;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Флажок CheckBox";
            label1.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(
    label1.Font.Name, label1.Font.Size,
    (
        (bold.Checked ? FontStyle.Bold : FontStyle.Regular) |
        (italic.Checked ? FontStyle.Italic : FontStyle.Regular) |
        (underline.Checked ? FontStyle.Underline : FontStyle.Regular)
    ), GraphicsUnit.Point, 204);
        }

        private void underline_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(
        label1.Font.Name, label1.Font.Size,
        (
            (bold.Checked ? FontStyle.Bold : FontStyle.Regular) |
            (italic.Checked ? FontStyle.Italic : FontStyle.Regular) |
            (underline.Checked ? FontStyle.Underline : FontStyle.Regular)
        ), GraphicsUnit.Point, 204);
        }

        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(
         label1.Font.Name, label1.Font.Size,
         (
             (bold.Checked ? FontStyle.Bold : FontStyle.Regular) |
             (italic.Checked ? FontStyle.Italic : FontStyle.Regular) |
             (underline.Checked ? FontStyle.Underline : FontStyle.Regular)
         ), GraphicsUnit.Point, 204);
        }
       
    }
}
