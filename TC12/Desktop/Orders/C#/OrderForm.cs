using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Orders
{
	public struct Product
	{
		public Product(string valName, int valPrice, int valDiscount)
		{
			ProdName = valName;
			Price = valPrice;
			Discount = valDiscount;
		}

		public string ProdName;
		public int Price;
		public int Discount;
	}

	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class OrderForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox Group;
		private System.Windows.Forms.Button ButtonOK;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.NumericUpDown Quantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Price;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox Total;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.DateTimePicker Date;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.TextBox Street;
		public System.Windows.Forms.TextBox City;
		public System.Windows.Forms.TextBox Zip;
		public System.Windows.Forms.TextBox State;
		public System.Windows.Forms.DateTimePicker ExpDate;
		public System.Windows.Forms.TextBox CardNo;
		public System.Windows.Forms.RadioButton Visa;
		public System.Windows.Forms.RadioButton MasterCard;
		public System.Windows.Forms.RadioButton AE;
		public System.Windows.Forms.TextBox Customer;
		private System.Windows.Forms.TextBox Discount;
		public System.Windows.Forms.ComboBox ProductNames;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OrderForm(bool ProduceBugs)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			IsProduceBugs = ProduceBugs;
			Products = new Product[NumProd];
			Products[0] = new Product("MyMoney", 100, 8);
			Products[1] = new Product("FamilyAlbum", 80, 15);
			Products[2] = new Product("ScreenSaver", 20, 10);

			for (int n = 0; n < NumProd; n++)
				ProductNames.Items.Add(Products[n].ProdName);

			ProductNames.SelectedIndex = 0;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Group = new System.Windows.Forms.GroupBox();
			this.Customer = new System.Windows.Forms.TextBox();
			this.AE = new System.Windows.Forms.RadioButton();
			this.MasterCard = new System.Windows.Forms.RadioButton();
			this.Visa = new System.Windows.Forms.RadioButton();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.CardNo = new System.Windows.Forms.TextBox();
			this.ExpDate = new System.Windows.Forms.DateTimePicker();
			this.Zip = new System.Windows.Forms.TextBox();
			this.State = new System.Windows.Forms.TextBox();
			this.City = new System.Windows.Forms.TextBox();
			this.Street = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Date = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Total = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Discount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Price = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Quantity = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.ProductNames = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.Group.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
			this.SuspendLayout();
			// 
			// Group
			// 
			this.Group.Controls.Add(this.Customer);
			this.Group.Controls.Add(this.AE);
			this.Group.Controls.Add(this.MasterCard);
			this.Group.Controls.Add(this.Visa);
			this.Group.Controls.Add(this.label14);
			this.Group.Controls.Add(this.label13);
			this.Group.Controls.Add(this.label12);
			this.Group.Controls.Add(this.label11);
			this.Group.Controls.Add(this.label10);
			this.Group.Controls.Add(this.label9);
			this.Group.Controls.Add(this.label8);
			this.Group.Controls.Add(this.label7);
			this.Group.Controls.Add(this.CardNo);
			this.Group.Controls.Add(this.ExpDate);
			this.Group.Controls.Add(this.Zip);
			this.Group.Controls.Add(this.State);
			this.Group.Controls.Add(this.City);
			this.Group.Controls.Add(this.Street);
			this.Group.Controls.Add(this.label6);
			this.Group.Controls.Add(this.Date);
			this.Group.Controls.Add(this.groupBox1);
			this.Group.Controls.Add(this.Discount);
			this.Group.Controls.Add(this.label4);
			this.Group.Controls.Add(this.Price);
			this.Group.Controls.Add(this.label3);
			this.Group.Controls.Add(this.Quantity);
			this.Group.Controls.Add(this.label2);
			this.Group.Controls.Add(this.ProductNames);
			this.Group.Controls.Add(this.label1);
			this.Group.Location = new System.Drawing.Point(8, 8);
			this.Group.Name = "Group";
			this.Group.Size = new System.Drawing.Size(464, 400);
			this.Group.TabIndex = 0;
			this.Group.TabStop = false;
			// 
			// Customer
			// 
			this.Customer.Location = new System.Drawing.Point(104, 160);
			this.Customer.Name = "Customer";
			this.Customer.Size = new System.Drawing.Size(352, 20);
			this.Customer.TabIndex = 12;
			this.Customer.Text = "";
			// 
			// AE
			// 
			this.AE.Location = new System.Drawing.Point(104, 304);
			this.AE.Name = "AE";
			this.AE.Size = new System.Drawing.Size(128, 24);
			this.AE.TabIndex = 24;
			this.AE.Text = "American Express";
			// 
			// MasterCard
			// 
			this.MasterCard.Location = new System.Drawing.Point(104, 280);
			this.MasterCard.Name = "MasterCard";
			this.MasterCard.Size = new System.Drawing.Size(128, 24);
			this.MasterCard.TabIndex = 23;
			this.MasterCard.Text = "MasterCard";
			// 
			// Visa
			// 
			this.Visa.Checked = true;
			this.Visa.Location = new System.Drawing.Point(104, 256);
			this.Visa.Name = "Visa";
			this.Visa.Size = new System.Drawing.Size(128, 24);
			this.Visa.TabIndex = 22;
			this.Visa.TabStop = true;
			this.Visa.Text = "Visa";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label14.Location = new System.Drawing.Point(8, 372);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 16);
			this.label14.TabIndex = 27;
			this.label14.Text = "Expiration Date:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label13.Location = new System.Drawing.Point(8, 340);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 16);
			this.label13.TabIndex = 25;
			this.label13.Text = "Card No";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label12.Location = new System.Drawing.Point(8, 261);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(33, 16);
			this.label12.TabIndex = 21;
			this.label12.Text = "Card:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label11.Location = new System.Drawing.Point(240, 225);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 16);
			this.label11.TabIndex = 19;
			this.label11.Text = "Zip:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label10.Location = new System.Drawing.Point(8, 230);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 16);
			this.label10.TabIndex = 17;
			this.label10.Text = "State:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label9.Location = new System.Drawing.Point(240, 196);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(28, 16);
			this.label9.TabIndex = 15;
			this.label9.Text = "City:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label8.Location = new System.Drawing.Point(8, 194);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 16);
			this.label8.TabIndex = 13;
			this.label8.Text = "Street:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label7.Location = new System.Drawing.Point(8, 162);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Customer Name:";
			// 
			// CardNo
			// 
			this.CardNo.Location = new System.Drawing.Point(104, 336);
			this.CardNo.Name = "CardNo";
			this.CardNo.Size = new System.Drawing.Size(352, 20);
			this.CardNo.TabIndex = 26;
			this.CardNo.Text = "";
			// 
			// ExpDate
			// 
			this.ExpDate.CustomFormat = "MM/dd/yyyy";
			this.ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ExpDate.Location = new System.Drawing.Point(104, 368);
			this.ExpDate.Name = "ExpDate";
			this.ExpDate.ShowUpDown = true;
			this.ExpDate.Size = new System.Drawing.Size(128, 20);
			this.ExpDate.TabIndex = 28;
			this.ExpDate.Value = new System.DateTime(2005, 4, 6, 0, 0, 0, 0);
			// 
			// Zip
			// 
			this.Zip.Location = new System.Drawing.Point(328, 224);
			this.Zip.Name = "Zip";
			this.Zip.Size = new System.Drawing.Size(128, 20);
			this.Zip.TabIndex = 20;
			this.Zip.Text = "";
			// 
			// State
			// 
			this.State.Location = new System.Drawing.Point(104, 224);
			this.State.Name = "State";
			this.State.Size = new System.Drawing.Size(128, 20);
			this.State.TabIndex = 18;
			this.State.Text = "";
			// 
			// City
			// 
			this.City.Location = new System.Drawing.Point(328, 192);
			this.City.Name = "City";
			this.City.Size = new System.Drawing.Size(128, 20);
			this.City.TabIndex = 16;
			this.City.Text = "";
			// 
			// Street
			// 
			this.Street.Location = new System.Drawing.Point(104, 192);
			this.Street.Name = "Street";
			this.Street.Size = new System.Drawing.Size(128, 20);
			this.Street.TabIndex = 14;
			this.Street.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label6.Location = new System.Drawing.Point(8, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Date:";
			// 
			// Date
			// 
			this.Date.CustomFormat = "MM/dd/yyyy";
			this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Date.Location = new System.Drawing.Point(104, 128);
			this.Date.Name = "Date";
			this.Date.ShowUpDown = true;
			this.Date.Size = new System.Drawing.Size(128, 20);
			this.Date.TabIndex = 10;
			this.Date.Value = new System.DateTime(2005, 4, 6, 0, 0, 0, 0);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Total);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(312, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 48);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// Total
			// 
			this.Total.Location = new System.Drawing.Point(64, 16);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(72, 20);
			this.Total.TabIndex = 1;
			this.Total.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label5.Location = new System.Drawing.Point(8, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Total:";
			// 
			// Discount
			// 
			this.Discount.Location = new System.Drawing.Point(376, 48);
			this.Discount.Name = "Discount";
			this.Discount.Size = new System.Drawing.Size(80, 20);
			this.Discount.TabIndex = 7;
			this.Discount.Text = "0%";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label4.Location = new System.Drawing.Point(312, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = ", discount:";
			// 
			// Price
			// 
			this.Price.Location = new System.Drawing.Point(224, 48);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(80, 20);
			this.Price.TabIndex = 5;
			this.Price.Text = "$10.1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label3.Location = new System.Drawing.Point(128, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = ", price per unit:";
			// 
			// Quantity
			// 
			this.Quantity.Location = new System.Drawing.Point(64, 48);
			this.Quantity.Name = "Quantity";
			this.Quantity.Size = new System.Drawing.Size(56, 20);
			this.Quantity.TabIndex = 3;
			this.Quantity.Value = new System.Decimal(new int[] {
																   1,
																   0,
																   0,
																   0});
			this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label2.Location = new System.Drawing.Point(8, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Quantity:";
			// 
			// ProductNames
			// 
			this.ProductNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProductNames.Location = new System.Drawing.Point(64, 16);
			this.ProductNames.Name = "ProductNames";
			this.ProductNames.Size = new System.Drawing.Size(392, 21);
			this.ProductNames.TabIndex = 1;
			this.ProductNames.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product:";
			// 
			// ButtonOK
			// 
			this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.ButtonOK.Location = new System.Drawing.Point(320, 416);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(72, 24);
			this.ButtonOK.TabIndex = 1;
			this.ButtonOK.Text = "OK";
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Location = new System.Drawing.Point(400, 416);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(72, 24);
			this.ButtonCancel.TabIndex = 2;
			this.ButtonCancel.Text = "Cancel";
			// 
			// OrderForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.ButtonCancel;
			this.ClientSize = new System.Drawing.Size(482, 449);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonOK);
			this.Controls.Add(this.Group);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrderForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Order";
			this.Group.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private const int NumProd = 3;
		private const int DiscountNum = 10;
		private Product[] Products;
		private bool IsProduceBugs;

		private void Product_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Price.Text = "$" + Products[ProductNames.SelectedIndex].Price;
			Quantity_ValueChanged(sender, e);
		}

		private void Quantity_ValueChanged(object sender, System.EventArgs e)
		{
			Product CurrentProduct = Products[ProductNames.SelectedIndex];
			int DiscountPercent = 0;
			if (Quantity.Value >= DiscountNum)
				DiscountPercent = CurrentProduct.Discount;
			Discount.Text = DiscountPercent + "%";

			int TotalPrice = (int) Quantity.Value * CurrentProduct.Price;
			if (IsProduceBugs)
				DiscountPercent = 0;
			Total.Text = (TotalPrice * (100 - DiscountPercent) / 100).ToString();
		}
	}
}
