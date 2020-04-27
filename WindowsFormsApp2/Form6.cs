using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class Form6 : Form
    {
        public List<string> _listname = new List<string>();
        public Form6()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox_state.SelectedItem.ToString();
            label_RoomstateBefore.Text = curItem;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ch_save_Click(object sender, EventArgs e)
        {

          // if(label_doctor.Text!=null || textBox_charger.Text!= null || label_RoomstateBefore !=null)
         if(label_doctor.Text!=null)
            {
                LabeldoctorNow.Text = label_doctor.Text;
            }
         if(textBox_charger.Text != null)
            {
                label_charger.Text = textBox_charger.Text;
            }
         if (label_RoomstateBefore.Text != null)
            {
                label_RoomstateNow.Text = label_RoomstateBefore.Text;
            }
    
        }

        private void List_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = null;
            if (list_name.SelectedItem.ToString() != null)
            curItem = list_name.SelectedItem.ToString(); 
            label_doctor.Text = curItem;
        }
    }
}
