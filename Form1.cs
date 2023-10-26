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
        DataTable dtb = new DataTable();
        void Clear()
        {
            txtMSSV.Text = "";
            txtHovaten.Text = "";
            txtLop.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
            this.listView1.MultiSelect = true;
            
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
                foreach (ListViewItem item in listView1.Items)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            catch
            {
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            listView1.SelectedItems[0].SubItems[0].Text = txtMSSV.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtHovaten.Text;
            listView1.SelectedItems[0].SubItems[2].Text = dt.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtLop.Text;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //còn thiếu multi select
        {
            if (listView1.SelectedItems.Count==0) { return; }

            txtMSSV.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtHovaten.Text = listView1.SelectedItems[0].SubItems[1].Text;
            dt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtLop.Text = listView1.SelectedItems[0].SubItems[3].Text;

           
            
        }

        private void btnSua_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string path = "D:\\TÀI LIỆU\\Phát Triển Ứng Dụng Desktop\\Buổi 4\\New Text Document.xml" ; //Sửa file này lại
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            dtb = ds.Tables[0];
            dataGridView1.DataSource = dtb;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtb.Rows.Add(txtMSSV.Text,txtHovaten.Text,dt.Text,txtLop.Text)  ;
        }
    }
}
