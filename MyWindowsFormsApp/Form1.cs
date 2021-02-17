using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReference1;

namespace MyWindowsFormsApp
{
    public partial class Form1 : Form
    {
        WebService1SoapClient webService1 = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "http://localhost:65225/WebService1.asmx";
        }

        private void CreateProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            string NewName = ProNameText.Text;
            string NewDes = DesText.Text;
            double NewPrice = Convert.ToDouble(PriceText.Text);
            webService1.CreateProduct(NewName, NewDes, NewPrice);
            MessageBox.Show("Create Successfully!");
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string D_ID = DeleteIdText.Text;
            if(webService1.DeleteProduct(D_ID) == 0)
            {
                MessageBox.Show("Delete Successfully!");
            }
            else
            {
                MessageBox.Show("Can't find!");
            }
            
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string F_ID = EditIdText.Text;
            Product product = webService1.Find(F_ID);
            if(product == null)
            {
                MessageBox.Show("Can't find!");
            }
            else
            {
                EditNameText.Text = product.Name;
                EditDesText.Text = product.Description;
                EditPriceText.Text = product.Price.ToString();
            }
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string E_Id = EditIdText.Text;
            string E_Name = EditNameText.Text;
            string E_Des = EditDesText.Text;
            double E_pri = Convert.ToDouble(EditPriceText.Text);
            webService1.Edit(E_Id, E_Name, E_Des, E_pri);
            MessageBox.Show("Update Successfully!");
        }

        private void ShowAllProducts_Click(object sender, EventArgs e)
        {
            this.listView1.Clear();  //从控件中移除所有项和列（包括列表头）。

            this.listView1.View = View.Details;

            ColumnHeader ch = new ColumnHeader();
            ch.Text = "Product_Id";   //设置列标题
            ch.Width = 500;    //设置列宽度
            ch.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.listView1.Columns.Add(ch);    //将列头添加到ListView控件。

            ColumnHeader ch1 = new ColumnHeader();
            ch1.Text = "Name";   //设置列标题
            ch1.Width = 120;    //设置列宽度
            ch1.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.listView1.Columns.Add(ch1);    //将列头添加到ListView控件。

            ColumnHeader ch2 = new ColumnHeader();
            ch2.Text = "Description";   //设置列标题
            ch2.Width = 120;    //设置列宽度
            ch2.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.listView1.Columns.Add(ch2);    //将列头添加到ListView控件。

            ColumnHeader ch3 = new ColumnHeader();
            ch3.Text = "Price";   //设置列标题
            ch3.Width = 120;    //设置列宽度
            ch3.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.listView1.Columns.Add(ch3);    //将列头添加到ListView控件。

            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

            Product[] products = webService1.ShowAllProducts();

            for (int i = 0; i < products.Length; i++)   //添加10行数据
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = products[i].Id;
                lvi.SubItems.Add(products[i].Name);
                lvi.SubItems.Add(products[i].Description);
                lvi.SubItems.Add(products[i].Price.ToString());
                this.listView1.Items.Add(lvi);
            }

            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
            MessageBox.Show("共找到" + products.Length.ToString() + "种商品。");
        }

        private void ShowAllShopRecords_Click(object sender, EventArgs e)
        {
            this.listView1.Clear();  //从控件中移除所有项和列（包括列表头）。
            this.listView1.View = View.Details;

            ColumnHeader ch = new ColumnHeader();
            ch.Text = "Record_Id";   //设置列标题
            ch.Width = 500;    //设置列宽度
            ch.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.listView1.Columns.Add(ch);    //将列头添加到ListView控件。

            ColumnHeader ch1 = new ColumnHeader();
            ch1.Text = "Time";   //设置列标题
            ch1.Width = 120;    //设置列宽度
            ch1.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.listView1.Columns.Add(ch1);    //将列头添加到ListView控件。

            ColumnHeader ch2 = new ColumnHeader();
            ch2.Text = "Sum";   //设置列标题
            ch2.Width = 120;    //设置列宽度
            ch2.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式
            this.listView1.Columns.Add(ch2);    //将列头添加到ListView控件。
            
            this.listView1.BeginUpdate();

            ShopRecord[] shopRecords = webService1.GetShopRecords();

            for (int i = 0; i < shopRecords.Length; i++)   //添加10行数据
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = shopRecords[i].Id;
                lvi.SubItems.Add(shopRecords[i].Time.ToString());
                lvi.SubItems.Add(shopRecords[i].Sum.ToString());
                this.listView1.Items.Add(lvi);
            }

            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
            MessageBox.Show("共找到" + shopRecords.Length.ToString() + "条记录。");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
