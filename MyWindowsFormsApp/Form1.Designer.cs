
namespace MyWindowsFormsApp
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
            this.CreateProduct = new System.Windows.Forms.GroupBox();
            this.Create = new System.Windows.Forms.Button();
            this.PriceText = new System.Windows.Forms.RichTextBox();
            this.DesText = new System.Windows.Forms.RichTextBox();
            this.ProNameText = new System.Windows.Forms.RichTextBox();
            this.Price = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.DeleteProduct = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteIdText = new System.Windows.Forms.RichTextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.GroupBox();
            this.Update = new System.Windows.Forms.Button();
            this.EditPriceText = new System.Windows.Forms.RichTextBox();
            this.EditDesText = new System.Windows.Forms.RichTextBox();
            this.EditNameText = new System.Windows.Forms.RichTextBox();
            this.Edit_Price = new System.Windows.Forms.Label();
            this.Edit_Description = new System.Windows.Forms.Label();
            this.Edit_Name = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.EditIdText = new System.Windows.Forms.RichTextBox();
            this.Edit_Id = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ShowAllProducts = new System.Windows.Forms.Button();
            this.ShowAllShopRecords = new System.Windows.Forms.Button();
            this.CreateProduct.SuspendLayout();
            this.DeleteProduct.SuspendLayout();
            this.Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateProduct
            // 
            this.CreateProduct.Controls.Add(this.Create);
            this.CreateProduct.Controls.Add(this.PriceText);
            this.CreateProduct.Controls.Add(this.DesText);
            this.CreateProduct.Controls.Add(this.ProNameText);
            this.CreateProduct.Controls.Add(this.Price);
            this.CreateProduct.Controls.Add(this.Description);
            this.CreateProduct.Controls.Add(this.ProductName);
            this.CreateProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateProduct.Location = new System.Drawing.Point(28, 22);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(610, 239);
            this.CreateProduct.TabIndex = 2;
            this.CreateProduct.TabStop = false;
            this.CreateProduct.Text = "CreateProduct";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(7, 197);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(578, 28);
            this.Create.TabIndex = 8;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(136, 148);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(448, 31);
            this.PriceText.TabIndex = 6;
            this.PriceText.Text = "";
            // 
            // DesText
            // 
            this.DesText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DesText.Location = new System.Drawing.Point(136, 61);
            this.DesText.Name = "DesText";
            this.DesText.Size = new System.Drawing.Size(448, 75);
            this.DesText.TabIndex = 5;
            this.DesText.Text = "";
            // 
            // ProNameText
            // 
            this.ProNameText.Location = new System.Drawing.Point(136, 25);
            this.ProNameText.Name = "ProNameText";
            this.ProNameText.Size = new System.Drawing.Size(448, 31);
            this.ProNameText.TabIndex = 4;
            this.ProNameText.Text = "";
            this.ProNameText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(7, 151);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(45, 20);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            this.Price.Click += new System.EventHandler(this.label3_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(7, 63);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(93, 20);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            this.Description.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(7, 28);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(110, 20);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "ProductName";
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Controls.Add(this.Delete);
            this.DeleteProduct.Controls.Add(this.DeleteIdText);
            this.DeleteProduct.Controls.Add(this.Id);
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteProduct.Location = new System.Drawing.Point(28, 278);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(610, 117);
            this.DeleteProduct.TabIndex = 3;
            this.DeleteProduct.TabStop = false;
            this.DeleteProduct.Text = "DeleteProduct";
            this.DeleteProduct.Enter += new System.EventHandler(this.DeleteProduct_Enter);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(7, 75);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(578, 28);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteIdText
            // 
            this.DeleteIdText.Location = new System.Drawing.Point(136, 30);
            this.DeleteIdText.Name = "DeleteIdText";
            this.DeleteIdText.Size = new System.Drawing.Size(448, 32);
            this.DeleteIdText.TabIndex = 1;
            this.DeleteIdText.Text = "";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(56, 33);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(23, 20);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.Update);
            this.Edit.Controls.Add(this.EditPriceText);
            this.Edit.Controls.Add(this.EditDesText);
            this.Edit.Controls.Add(this.EditNameText);
            this.Edit.Controls.Add(this.Edit_Price);
            this.Edit.Controls.Add(this.Edit_Description);
            this.Edit.Controls.Add(this.Edit_Name);
            this.Edit.Controls.Add(this.Find);
            this.Edit.Controls.Add(this.EditIdText);
            this.Edit.Controls.Add(this.Edit_Id);
            this.Edit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edit.Location = new System.Drawing.Point(688, 22);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(531, 373);
            this.Edit.TabIndex = 4;
            this.Edit.TabStop = false;
            this.Edit.Text = "Edit";
            this.Edit.Enter += new System.EventHandler(this.Edit_Enter);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(18, 332);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(507, 28);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // EditPriceText
            // 
            this.EditPriceText.Location = new System.Drawing.Point(166, 256);
            this.EditPriceText.Name = "EditPriceText";
            this.EditPriceText.Size = new System.Drawing.Size(359, 35);
            this.EditPriceText.TabIndex = 9;
            this.EditPriceText.Text = "";
            this.EditPriceText.TextChanged += new System.EventHandler(this.richTextBox9_TextChanged);
            // 
            // EditDesText
            // 
            this.EditDesText.Location = new System.Drawing.Point(166, 161);
            this.EditDesText.Name = "EditDesText";
            this.EditDesText.Size = new System.Drawing.Size(359, 79);
            this.EditDesText.TabIndex = 8;
            this.EditDesText.Text = "";
            // 
            // EditNameText
            // 
            this.EditNameText.Location = new System.Drawing.Point(166, 111);
            this.EditNameText.Name = "EditNameText";
            this.EditNameText.Size = new System.Drawing.Size(359, 34);
            this.EditNameText.TabIndex = 7;
            this.EditNameText.Text = "";
            this.EditNameText.TextChanged += new System.EventHandler(this.richTextBox7_TextChanged);
            // 
            // Edit_Price
            // 
            this.Edit_Price.AutoSize = true;
            this.Edit_Price.Location = new System.Drawing.Point(18, 259);
            this.Edit_Price.Name = "Edit_Price";
            this.Edit_Price.Size = new System.Drawing.Size(80, 20);
            this.Edit_Price.TabIndex = 5;
            this.Edit_Price.Text = "Edit_Price";
            // 
            // Edit_Description
            // 
            this.Edit_Description.AutoSize = true;
            this.Edit_Description.Location = new System.Drawing.Point(18, 163);
            this.Edit_Description.Name = "Edit_Description";
            this.Edit_Description.Size = new System.Drawing.Size(128, 20);
            this.Edit_Description.TabIndex = 4;
            this.Edit_Description.Text = "Edit_Description";
            // 
            // Edit_Name
            // 
            this.Edit_Name.AutoSize = true;
            this.Edit_Name.Location = new System.Drawing.Point(18, 114);
            this.Edit_Name.Name = "Edit_Name";
            this.Edit_Name.Size = new System.Drawing.Size(87, 20);
            this.Edit_Name.TabIndex = 3;
            this.Edit_Name.Text = "Edit_Name";
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(18, 63);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(560, 28);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // EditIdText
            // 
            this.EditIdText.Location = new System.Drawing.Point(166, 25);
            this.EditIdText.Name = "EditIdText";
            this.EditIdText.Size = new System.Drawing.Size(359, 31);
            this.EditIdText.TabIndex = 1;
            this.EditIdText.Text = "";
            // 
            // Edit_Id
            // 
            this.Edit_Id.AutoSize = true;
            this.Edit_Id.Location = new System.Drawing.Point(18, 28);
            this.Edit_Id.Name = "Edit_Id";
            this.Edit_Id.Size = new System.Drawing.Size(58, 20);
            this.Edit_Id.TabIndex = 0;
            this.Edit_Id.Text = "Edit_Id";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(224, 412);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(995, 300);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ShowAllProducts
            // 
            this.ShowAllProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAllProducts.Location = new System.Drawing.Point(28, 472);
            this.ShowAllProducts.Name = "ShowAllProducts";
            this.ShowAllProducts.Size = new System.Drawing.Size(171, 29);
            this.ShowAllProducts.TabIndex = 6;
            this.ShowAllProducts.Text = "ShowAllProducts";
            this.ShowAllProducts.UseVisualStyleBackColor = true;
            this.ShowAllProducts.Click += new System.EventHandler(this.ShowAllProducts_Click);
            // 
            // ShowAllShopRecords
            // 
            this.ShowAllShopRecords.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAllShopRecords.Location = new System.Drawing.Point(28, 563);
            this.ShowAllShopRecords.Name = "ShowAllShopRecords";
            this.ShowAllShopRecords.Size = new System.Drawing.Size(171, 29);
            this.ShowAllShopRecords.TabIndex = 7;
            this.ShowAllShopRecords.Text = "ShowAllShopRecords";
            this.ShowAllShopRecords.UseVisualStyleBackColor = true;
            this.ShowAllShopRecords.Click += new System.EventHandler(this.ShowAllShopRecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 732);
            this.Controls.Add(this.ShowAllShopRecords);
            this.Controls.Add(this.ShowAllProducts);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.CreateProduct);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CreateProduct.ResumeLayout(false);
            this.CreateProduct.PerformLayout();
            this.DeleteProduct.ResumeLayout(false);
            this.DeleteProduct.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateProduct;
        private System.Windows.Forms.RichTextBox ProNameText;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox DesText;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.GroupBox DeleteProduct;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.GroupBox Edit;
        private System.Windows.Forms.Label Edit_Id;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox EditNameText;
        private System.Windows.Forms.Label Edit_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Edit_Name;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label Edit_Description;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ShowAllProducts;
        private System.Windows.Forms.Button ShowAllShopRecords;
        private System.Windows.Forms.RichTextBox PriceText;
        private System.Windows.Forms.RichTextBox DeleteIdText;
        private System.Windows.Forms.RichTextBox EditIdText;
        private System.Windows.Forms.RichTextBox EditDesText;
        private System.Windows.Forms.RichTextBox EditPriceText;
    }
}

