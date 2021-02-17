using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReferenceClient;

namespace WindowsFormsAppClient
{
    public partial class Form1 : Form
    {
        WebService2SoapClient webService2 = new WebService2SoapClient(WebService2SoapClient.EndpointConfiguration.WebService2Soap);
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "http://localhost:65225/WebService2.asmx";
            Product[] products = webService2.GetProductList();
            for (int i = 0; i < products.Length; i++)
            {
                checkedListBox1.Items.Add(products[i].Name + "\t " + products[i].Description + "\t  " + products[i].Price.ToString());
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            Product[] products = webService2.GetProductList();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    //MessageBox.Show(checkedListBox1.GetItemText(checkedListBox1.Items[i]));
                    webService2.AddProductToShoppingList(products[i].Id);
                }
            }
            Update_ShoppingList();
            Update_Output();

        }

        private void Update_ShoppingList()
        {
            checkedListBox2.Items.Clear();
            SelectedProduct[] selectedP = webService2.ShowSelectedProducts();
            for (int i = 0; i < selectedP.Length; i++)
            {
                checkedListBox2.Items.Add(selectedP[i].Name + "\t" + selectedP[i].Price.ToString() + "\t *" + selectedP[i].num.ToString());
                checkedListBox2.SetItemChecked(i, false);
            }
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            SelectedProduct[] selectedP = webService2.ShowSelectedProducts();
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    webService2.RemoveSelected(selectedP[i].Id);
                }
                checkedListBox2.SetItemChecked(i, false);
            }
            Update_ShoppingList();
            Update_Output();
        }

        private void Update_Output()
        {
            P_Num.Text = webService2.GetNum().ToString();
            AccountText.Text = webService2.GetAccount().ToString();
        }

        private void Finish_Shopping_Click(object sender, EventArgs e)
        {
            webService2.FinishShopping();
            MessageBox.Show("You need to pay " + AccountText.Text + " for products.");
            Update_ShoppingList();
            Update_Output();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            webService2.ClearShoppingList();
            Update_ShoppingList();
            Update_Output();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateProductList_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            Product[] products = webService2.GetProductList();
            for (int i = 0; i < products.Length; i++)
            {
                checkedListBox1.Items.Add(products[i].Name + "\t " + products[i].Description + "\t  " + products[i].Price.ToString());
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
