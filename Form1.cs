using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Classwork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            

            listView1.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ma_Sinh_Vien");
            listView1.Columns.Add("Ho_Ten");
            listView1.Columns.Add("Ngay_Sinh");
            listView1.Columns.Add("Lop");

            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = txtMSSV.Text;
            lvItem.SubItems.Add(txtHovaten.Text);
            lvItem.SubItems.Add(dt.Text);
            lvItem.SubItems.Add(txtLop.Text);
            
            listView1.Items.Add(lvItem);  

        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {
           try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch
            {
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0) { return; }
            txtMSSV.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtHovaten.Text = listView1.SelectedItems[0].SubItems[1].Text;
            dt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtLop.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}
