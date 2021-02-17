
namespace WindowsFormsAppClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ProductList = new System.Windows.Forms.GroupBox();
            this.UpdateProductList = new System.Windows.Forms.Button();
            this.AddToList = new System.Windows.Forms.Button();
            this.ShoppingList = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Finish_Shopping = new System.Windows.Forms.Button();
            this.AccountText = new System.Windows.Forms.TextBox();
            this.Total_Account = new System.Windows.Forms.Label();
            this.P_Num = new System.Windows.Forms.TextBox();
            this.Selected_Product_Num = new System.Windows.Forms.Label();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.ProductList.SuspendLayout();
            this.ShoppingList.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(442, 488);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // ProductList
            // 
            this.ProductList.Controls.Add(this.UpdateProductList);
            this.ProductList.Controls.Add(this.AddToList);
            this.ProductList.Controls.Add(this.checkedListBox1);
            this.ProductList.Location = new System.Drawing.Point(17, 23);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(454, 590);
            this.ProductList.TabIndex = 1;
            this.ProductList.TabStop = false;
            this.ProductList.Text = "ProductList";
            // 
            // UpdateProductList
            // 
            this.UpdateProductList.Location = new System.Drawing.Point(7, 526);
            this.UpdateProductList.Name = "UpdateProductList";
            this.UpdateProductList.Size = new System.Drawing.Size(206, 46);
            this.UpdateProductList.TabIndex = 2;
            this.UpdateProductList.Text = "UpdateProductList";
            this.UpdateProductList.UseVisualStyleBackColor = true;
            this.UpdateProductList.Click += new System.EventHandler(this.UpdateProductList_Click);
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(248, 526);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(200, 46);
            this.AddToList.TabIndex = 1;
            this.AddToList.Text = "AddToList";
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // ShoppingList
            // 
            this.ShoppingList.Controls.Add(this.Cancel);
            this.ShoppingList.Controls.Add(this.Finish_Shopping);
            this.ShoppingList.Controls.Add(this.AccountText);
            this.ShoppingList.Controls.Add(this.Total_Account);
            this.ShoppingList.Controls.Add(this.P_Num);
            this.ShoppingList.Controls.Add(this.Selected_Product_Num);
            this.ShoppingList.Controls.Add(this.RemoveSelected);
            this.ShoppingList.Controls.Add(this.checkedListBox2);
            this.ShoppingList.Location = new System.Drawing.Point(520, 23);
            this.ShoppingList.Name = "ShoppingList";
            this.ShoppingList.Size = new System.Drawing.Size(530, 590);
            this.ShoppingList.TabIndex = 2;
            this.ShoppingList.TabStop = false;
            this.ShoppingList.Text = "ShoppingList";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(347, 526);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(170, 46);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Finish_Shopping
            // 
            this.Finish_Shopping.Location = new System.Drawing.Point(6, 526);
            this.Finish_Shopping.Name = "Finish_Shopping";
            this.Finish_Shopping.Size = new System.Drawing.Size(301, 46);
            this.Finish_Shopping.TabIndex = 6;
            this.Finish_Shopping.Text = "Finish Shopping, Click To Pay";
            this.Finish_Shopping.UseVisualStyleBackColor = true;
            this.Finish_Shopping.Click += new System.EventHandler(this.Finish_Shopping_Click);
            // 
            // AccountText
            // 
            this.AccountText.Location = new System.Drawing.Point(213, 466);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(304, 27);
            this.AccountText.TabIndex = 5;
            // 
            // Total_Account
            // 
            this.Total_Account.AutoSize = true;
            this.Total_Account.Location = new System.Drawing.Point(73, 469);
            this.Total_Account.Name = "Total_Account";
            this.Total_Account.Size = new System.Drawing.Size(114, 20);
            this.Total_Account.TabIndex = 4;
            this.Total_Account.Text = "Total_Account";
            // 
            // P_Num
            // 
            this.P_Num.Location = new System.Drawing.Point(213, 422);
            this.P_Num.Name = "P_Num";
            this.P_Num.Size = new System.Drawing.Size(304, 27);
            this.P_Num.TabIndex = 3;
            // 
            // Selected_Product_Num
            // 
            this.Selected_Product_Num.AutoSize = true;
            this.Selected_Product_Num.Location = new System.Drawing.Point(7, 425);
            this.Selected_Product_Num.Name = "Selected_Product_Num";
            this.Selected_Product_Num.Size = new System.Drawing.Size(180, 20);
            this.Selected_Product_Num.TabIndex = 2;
            this.Selected_Product_Num.Text = "Selected_Product_Num";
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Location = new System.Drawing.Point(7, 352);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(510, 47);
            this.RemoveSelected.TabIndex = 1;
            this.RemoveSelected.Text = "RemoveSelected";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(7, 26);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(510, 312);
            this.checkedListBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 635);
            this.Controls.Add(this.ShoppingList);
            this.Controls.Add(this.ProductList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ProductList.ResumeLayout(false);
            this.ShoppingList.ResumeLayout(false);
            this.ShoppingList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox ProductList;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.GroupBox ShoppingList;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label Selected_Product_Num;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.TextBox P_Num;
        private System.Windows.Forms.Label Total_Account;
        private System.Windows.Forms.TextBox AccountText;
        private System.Windows.Forms.Button Finish_Shopping;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button UpdateProductList;
    }
}

