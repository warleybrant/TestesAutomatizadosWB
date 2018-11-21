using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Orders
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem MenuFile;
		private System.Windows.Forms.MenuItem MenuFileNew;
		private System.Windows.Forms.MenuItem MenuFileOpen;
		private System.Windows.Forms.MenuItem MenuFileSave;
		private System.Windows.Forms.MenuItem MenuFileSaveAs;
		private System.Windows.Forms.MenuItem MenuFileExit;
		private System.Windows.Forms.MenuItem MenuOrders;
		private System.Windows.Forms.MenuItem MenuOrdersNew;
		private System.Windows.Forms.MenuItem MenuOrdersEdit;
		private System.Windows.Forms.MenuItem MenuOrdersBugs;
		private System.Windows.Forms.MenuItem MenuOrdersDelete;
		private System.Windows.Forms.MenuItem MenuReport;
		private System.Windows.Forms.MenuItem MenuReportGenerate;
		private System.Windows.Forms.MenuItem MenuView;
		private System.Windows.Forms.MenuItem MenuViewLarge;
		private System.Windows.Forms.MenuItem MenuViewSmall;
		private System.Windows.Forms.MenuItem MenuViewList;
		private System.Windows.Forms.MenuItem MenuViewDetails;
		private System.Windows.Forms.ToolBar ToolBar;
		private System.Windows.Forms.ToolBarButton ToolNew;
		private System.Windows.Forms.ToolBarButton ToolOpen;
		private System.Windows.Forms.ToolBarButton ToolSave;
		private System.Windows.Forms.ToolBarButton ToolSep1;
		private System.Windows.Forms.ToolBarButton ToolOrderNew;
		private System.Windows.Forms.ToolBarButton ToolOrderEdit;
		private System.Windows.Forms.ToolBarButton ToolOrderDelete;
		private System.Windows.Forms.ToolBarButton ToolSep2;
		private System.Windows.Forms.ToolBarButton ToolLarge;
		private System.Windows.Forms.ToolBarButton ToolSmall;
		private System.Windows.Forms.ToolBarButton ToolList;
		private System.Windows.Forms.ToolBarButton ToolReport;
		private System.Windows.Forms.ImageList ImgArt;
		private System.Windows.Forms.StatusBar StatusBar;
		private System.Windows.Forms.MainMenu MainMneu;
		private System.Windows.Forms.ListView OrdersView;
		private System.Windows.Forms.ContextMenu ViewContextMenu;
		private System.Windows.Forms.MenuItem ContextNew;
		private System.Windows.Forms.MenuItem ContextEdit;
		private System.Windows.Forms.MenuItem ContextDelete;
		private System.Windows.Forms.ColumnHeader ColumnName;
		private System.Windows.Forms.ColumnHeader ColumnProduct;
		private System.Windows.Forms.ColumnHeader ColumnQuantity;
		private System.Windows.Forms.ColumnHeader ColumnDate;
		private System.Windows.Forms.ColumnHeader ColumnStreet;
		private System.Windows.Forms.ColumnHeader ColumnCity;
		private System.Windows.Forms.ColumnHeader ColumnState;
		private System.Windows.Forms.ColumnHeader ColumnZip;
		private System.Windows.Forms.ColumnHeader ColumnCard;
		private System.Windows.Forms.ColumnHeader ColumnNoCard;
		private System.Windows.Forms.ColumnHeader ColumnExpDate;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.OpenFileDialog OpenDialog;
		private System.Windows.Forms.SaveFileDialog CustomerSaveDlg;
		private System.Windows.Forms.SaveFileDialog SaveDialog;

		public MainForm(string[] args)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			Modified = false;
			FileName = "";

			for (int i = 0; i < args.Length; i++)
			{
				if ((FileName == "") && File.Exists(args[i]))
				{
					FileName = args[i];
					DoLoad();
				}

				if (args[i].ToLower() == "/dontsaveonexit")
				{
					DontSaveOnExit = true;
				}
			}
		}

		private bool IsModified;
		private bool Modified
		{
			set
			{
				IsModified = value;
				if (IsModified)
					StatusBar.Text = "Modified";
				else
					StatusBar.Text = "";
			}
			get
			{
				return IsModified;
			}
		}

		private string CurFileName;
		private string FileName
		{
			set
			{
				CurFileName = value;
				if (CurFileName == "")
					Text = "Orders - Untitled";
				else
					Text = "Orders - " + CurFileName;
			}
			get
			{
				return CurFileName;
			}
		}

		private bool DontSaveOnExit = false;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolBar = new System.Windows.Forms.ToolBar();
            this.ToolNew = new System.Windows.Forms.ToolBarButton();
            this.ToolOpen = new System.Windows.Forms.ToolBarButton();
            this.ToolSave = new System.Windows.Forms.ToolBarButton();
            this.ToolSep1 = new System.Windows.Forms.ToolBarButton();
            this.ToolOrderNew = new System.Windows.Forms.ToolBarButton();
            this.ToolOrderEdit = new System.Windows.Forms.ToolBarButton();
            this.ToolOrderDelete = new System.Windows.Forms.ToolBarButton();
            this.ToolSep2 = new System.Windows.Forms.ToolBarButton();
            this.ToolLarge = new System.Windows.Forms.ToolBarButton();
            this.ToolSmall = new System.Windows.Forms.ToolBarButton();
            this.ToolList = new System.Windows.Forms.ToolBarButton();
            this.ToolReport = new System.Windows.Forms.ToolBarButton();
            this.ImgArt = new System.Windows.Forms.ImageList(this.components);
            this.StatusBar = new System.Windows.Forms.StatusBar();
            this.MainMneu = new System.Windows.Forms.MainMenu(this.components);
            this.MenuFile = new System.Windows.Forms.MenuItem();
            this.MenuFileNew = new System.Windows.Forms.MenuItem();
            this.MenuFileOpen = new System.Windows.Forms.MenuItem();
            this.MenuFileSave = new System.Windows.Forms.MenuItem();
            this.MenuFileSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.MenuFileExit = new System.Windows.Forms.MenuItem();
            this.MenuOrders = new System.Windows.Forms.MenuItem();
            this.MenuOrdersNew = new System.Windows.Forms.MenuItem();
            this.MenuOrdersEdit = new System.Windows.Forms.MenuItem();
            this.MenuOrdersDelete = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.MenuOrdersBugs = new System.Windows.Forms.MenuItem();
            this.MenuReport = new System.Windows.Forms.MenuItem();
            this.MenuReportGenerate = new System.Windows.Forms.MenuItem();
            this.MenuView = new System.Windows.Forms.MenuItem();
            this.MenuViewLarge = new System.Windows.Forms.MenuItem();
            this.MenuViewSmall = new System.Windows.Forms.MenuItem();
            this.MenuViewList = new System.Windows.Forms.MenuItem();
            this.MenuViewDetails = new System.Windows.Forms.MenuItem();
            this.OrdersView = new System.Windows.Forms.ListView();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnProduct = new System.Windows.Forms.ColumnHeader();
            this.ColumnQuantity = new System.Windows.Forms.ColumnHeader();
            this.ColumnDate = new System.Windows.Forms.ColumnHeader();
            this.ColumnStreet = new System.Windows.Forms.ColumnHeader();
            this.ColumnCity = new System.Windows.Forms.ColumnHeader();
            this.ColumnState = new System.Windows.Forms.ColumnHeader();
            this.ColumnZip = new System.Windows.Forms.ColumnHeader();
            this.ColumnCard = new System.Windows.Forms.ColumnHeader();
            this.ColumnNoCard = new System.Windows.Forms.ColumnHeader();
            this.ColumnExpDate = new System.Windows.Forms.ColumnHeader();
            this.ViewContextMenu = new System.Windows.Forms.ContextMenu();
            this.ContextNew = new System.Windows.Forms.MenuItem();
            this.ContextEdit = new System.Windows.Forms.MenuItem();
            this.ContextDelete = new System.Windows.Forms.MenuItem();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.CustomerSaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolNew,
            this.ToolOpen,
            this.ToolSave,
            this.ToolSep1,
            this.ToolOrderNew,
            this.ToolOrderEdit,
            this.ToolOrderDelete,
            this.ToolSep2,
            this.ToolLarge,
            this.ToolSmall,
            this.ToolList,
            this.ToolReport});
            this.ToolBar.DropDownArrows = true;
            this.ToolBar.ImageList = this.ImgArt;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.ShowToolTips = true;
            this.ToolBar.Size = new System.Drawing.Size(592, 28);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar_ButtonClick);
            // 
            // ToolNew
            // 
            this.ToolNew.ImageIndex = 2;
            this.ToolNew.Name = "ToolNew";
            // 
            // ToolOpen
            // 
            this.ToolOpen.ImageIndex = 4;
            this.ToolOpen.Name = "ToolOpen";
            // 
            // ToolSave
            // 
            this.ToolSave.ImageIndex = 5;
            this.ToolSave.Name = "ToolSave";
            // 
            // ToolSep1
            // 
            this.ToolSep1.Name = "ToolSep1";
            this.ToolSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolOrderNew
            // 
            this.ToolOrderNew.ImageIndex = 3;
            this.ToolOrderNew.Name = "ToolOrderNew";
            // 
            // ToolOrderEdit
            // 
            this.ToolOrderEdit.ImageIndex = 1;
            this.ToolOrderEdit.Name = "ToolOrderEdit";
            // 
            // ToolOrderDelete
            // 
            this.ToolOrderDelete.ImageIndex = 0;
            this.ToolOrderDelete.Name = "ToolOrderDelete";
            // 
            // ToolSep2
            // 
            this.ToolSep2.Name = "ToolSep2";
            this.ToolSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolLarge
            // 
            this.ToolLarge.ImageIndex = 8;
            this.ToolLarge.Name = "ToolLarge";
            // 
            // ToolSmall
            // 
            this.ToolSmall.ImageIndex = 9;
            this.ToolSmall.Name = "ToolSmall";
            // 
            // ToolList
            // 
            this.ToolList.ImageIndex = 7;
            this.ToolList.Name = "ToolList";
            // 
            // ToolReport
            // 
            this.ToolReport.ImageIndex = 6;
            this.ToolReport.Name = "ToolReport";
            this.ToolReport.Pushed = true;
            // 
            // ImgArt
            // 
            this.ImgArt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgArt.ImageStream")));
            this.ImgArt.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.ImgArt.Images.SetKeyName(0, "");
            this.ImgArt.Images.SetKeyName(1, "");
            this.ImgArt.Images.SetKeyName(2, "");
            this.ImgArt.Images.SetKeyName(3, "");
            this.ImgArt.Images.SetKeyName(4, "");
            this.ImgArt.Images.SetKeyName(5, "");
            this.ImgArt.Images.SetKeyName(6, "");
            this.ImgArt.Images.SetKeyName(7, "");
            this.ImgArt.Images.SetKeyName(8, "");
            this.ImgArt.Images.SetKeyName(9, "");
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 327);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(592, 22);
            this.StatusBar.TabIndex = 1;
            // 
            // MainMneu
            // 
            this.MainMneu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuFile,
            this.MenuOrders,
            this.MenuReport,
            this.MenuView});
            // 
            // MenuFile
            // 
            this.MenuFile.Index = 0;
            this.MenuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuFileNew,
            this.MenuFileOpen,
            this.MenuFileSave,
            this.MenuFileSaveAs,
            this.menuItem7,
            this.MenuFileExit});
            this.MenuFile.Text = "&File";
            // 
            // MenuFileNew
            // 
            this.MenuFileNew.Index = 0;
            this.MenuFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.MenuFileNew.Text = "&New";
            this.MenuFileNew.Click += new System.EventHandler(this.MenuFileNew_Click);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Index = 1;
            this.MenuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.MenuFileOpen.Text = "&Open...";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Index = 2;
            this.MenuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.MenuFileSave.Text = "&Save";
            this.MenuFileSave.Click += new System.EventHandler(this.MenuFileSave_Click);
            // 
            // MenuFileSaveAs
            // 
            this.MenuFileSaveAs.Index = 3;
            this.MenuFileSaveAs.Text = "Save &As...";
            this.MenuFileSaveAs.Click += new System.EventHandler(this.MenuFileSaveAs_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "-";
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Index = 5;
            this.MenuFileExit.Text = "E&xit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // MenuOrders
            // 
            this.MenuOrders.Index = 1;
            this.MenuOrders.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuOrdersNew,
            this.MenuOrdersEdit,
            this.MenuOrdersDelete,
            this.menuItem12,
            this.MenuOrdersBugs});
            this.MenuOrders.Text = "&Orders";
            // 
            // MenuOrdersNew
            // 
            this.MenuOrdersNew.Index = 0;
            this.MenuOrdersNew.Shortcut = System.Windows.Forms.Shortcut.CtrlIns;
            this.MenuOrdersNew.Text = "&New order...";
            this.MenuOrdersNew.Click += new System.EventHandler(this.MenuOrdersNew_Click);
            // 
            // MenuOrdersEdit
            // 
            this.MenuOrdersEdit.Index = 1;
            this.MenuOrdersEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.MenuOrdersEdit.Text = "&Edit order...";
            this.MenuOrdersEdit.Click += new System.EventHandler(this.MenuOrdersEdit_Click);
            // 
            // MenuOrdersDelete
            // 
            this.MenuOrdersDelete.Index = 2;
            this.MenuOrdersDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.MenuOrdersDelete.Text = "&Delete order";
            this.MenuOrdersDelete.Click += new System.EventHandler(this.MenuOrdersDelete_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.Text = "-";
            // 
            // MenuOrdersBugs
            // 
            this.MenuOrdersBugs.Index = 4;
            this.MenuOrdersBugs.Text = "Work with &bugs";
            this.MenuOrdersBugs.Click += new System.EventHandler(this.MenuOrdersBugs_Click);
            // 
            // MenuReport
            // 
            this.MenuReport.Index = 2;
            this.MenuReport.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuReportGenerate});
            this.MenuReport.Text = "&Report";
            // 
            // MenuReportGenerate
            // 
            this.MenuReportGenerate.Index = 0;
            this.MenuReportGenerate.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.MenuReportGenerate.Text = "&Generate customer list...";
            this.MenuReportGenerate.Click += new System.EventHandler(this.MenuReportGenerate_Click);
            // 
            // MenuView
            // 
            this.MenuView.Index = 3;
            this.MenuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuViewLarge,
            this.MenuViewSmall,
            this.MenuViewList,
            this.MenuViewDetails});
            this.MenuView.Text = "&View";
            // 
            // MenuViewLarge
            // 
            this.MenuViewLarge.Index = 0;
            this.MenuViewLarge.Text = "L&arge Icons";
            this.MenuViewLarge.Click += new System.EventHandler(this.MenuViewLarge_Click);
            // 
            // MenuViewSmall
            // 
            this.MenuViewSmall.Index = 1;
            this.MenuViewSmall.Text = "&Small Icons";
            this.MenuViewSmall.Click += new System.EventHandler(this.MenuViewSmall_Click);
            // 
            // MenuViewList
            // 
            this.MenuViewList.Index = 2;
            this.MenuViewList.Text = "&List";
            this.MenuViewList.Click += new System.EventHandler(this.MenuViewList_Click);
            // 
            // MenuViewDetails
            // 
            this.MenuViewDetails.Checked = true;
            this.MenuViewDetails.Index = 3;
            this.MenuViewDetails.Text = "&Details";
            this.MenuViewDetails.Click += new System.EventHandler(this.MenuViewDetails_Click);
            // 
            // OrdersView
            // 
            this.OrdersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnProduct,
            this.ColumnQuantity,
            this.ColumnDate,
            this.ColumnStreet,
            this.ColumnCity,
            this.ColumnState,
            this.ColumnZip,
            this.ColumnCard,
            this.ColumnNoCard,
            this.ColumnExpDate});
            this.OrdersView.ContextMenu = this.ViewContextMenu;
            this.OrdersView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersView.FullRowSelect = true;
            this.OrdersView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrdersView.HideSelection = false;
            this.OrdersView.Location = new System.Drawing.Point(0, 28);
            this.OrdersView.MultiSelect = false;
            this.OrdersView.Name = "OrdersView";
            this.OrdersView.Size = new System.Drawing.Size(592, 299);
            this.OrdersView.TabIndex = 2;
            this.OrdersView.UseCompatibleStateImageBehavior = false;
            this.OrdersView.View = System.Windows.Forms.View.Details;
            this.OrdersView.DoubleClick += new System.EventHandler(this.ContextEdit_Click);
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Customer Name";
            this.ColumnName.Width = 120;
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.Text = "Product";
            this.ColumnProduct.Width = 101;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.Text = "Quantity";
            this.ColumnQuantity.Width = 56;
            // 
            // ColumnDate
            // 
            this.ColumnDate.Text = "Date";
            this.ColumnDate.Width = 105;
            // 
            // ColumnStreet
            // 
            this.ColumnStreet.Text = "Street";
            this.ColumnStreet.Width = 120;
            // 
            // ColumnCity
            // 
            this.ColumnCity.Text = "City";
            this.ColumnCity.Width = 120;
            // 
            // ColumnState
            // 
            this.ColumnState.Text = "State";
            this.ColumnState.Width = 120;
            // 
            // ColumnZip
            // 
            this.ColumnZip.Text = "Zip";
            this.ColumnZip.Width = 80;
            // 
            // ColumnCard
            // 
            this.ColumnCard.Text = "Card";
            this.ColumnCard.Width = 100;
            // 
            // ColumnNoCard
            // 
            this.ColumnNoCard.Text = "Card No";
            this.ColumnNoCard.Width = 100;
            // 
            // ColumnExpDate
            // 
            this.ColumnExpDate.Text = "Expiration Date";
            this.ColumnExpDate.Width = 100;
            // 
            // ViewContextMenu
            // 
            this.ViewContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ContextNew,
            this.ContextEdit,
            this.ContextDelete});
            // 
            // ContextNew
            // 
            this.ContextNew.Index = 0;
            this.ContextNew.Text = "&New order...";
            this.ContextNew.Click += new System.EventHandler(this.ContextNew_Click);
            // 
            // ContextEdit
            // 
            this.ContextEdit.Index = 1;
            this.ContextEdit.Text = "&Edit order...";
            this.ContextEdit.Click += new System.EventHandler(this.ContextEdit_Click);
            // 
            // ContextDelete
            // 
            this.ContextDelete.Index = 2;
            this.ContextDelete.Text = "&Delete order";
            this.ContextDelete.Click += new System.EventHandler(this.ContextDelete_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.DefaultExt = "tbl";
            this.OpenDialog.Filter = "Table (*.tbl)|*.tbl||";
            // 
            // SaveDialog
            // 
            this.SaveDialog.DefaultExt = "tbl";
            this.SaveDialog.FileName = "Untitled";
            this.SaveDialog.Filter = "Table (*.tbl)|*.tbl||";
            // 
            // CustomerSaveDlg
            // 
            this.CustomerSaveDlg.DefaultExt = "txt";
            this.CustomerSaveDlg.FileName = "CustomerList.txt";
            this.CustomerSaveDlg.Filter = "All files (*.*)|*.*||";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 349);
            this.Controls.Add(this.OrdersView);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ToolBar);
            this.Menu = this.MainMneu;
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainFrom_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
			Application.EnableVisualStyles();
			Application.Run(new MainForm(args));
		}

		private void ResetViewState()
		{
			MenuViewLarge.Checked = false;
			MenuViewSmall.Checked = false;
			MenuViewList.Checked = false;
			MenuViewDetails.Checked = false;

			ToolLarge.Pushed = false;
			ToolSmall.Pushed = false;
			ToolList.Pushed = false;
			ToolReport.Pushed = false;
		}

		private void MenuViewLarge_Click(object sender, System.EventArgs e)
		{
			ResetViewState();
			MenuViewLarge.Checked = true;
			ToolLarge.Pushed = true;
			OrdersView.View = View.LargeIcon;
		}

		private void MenuViewSmall_Click(object sender, System.EventArgs e)
		{
			ResetViewState();
			MenuViewSmall.Checked = true;
			ToolSmall.Pushed = true;
			OrdersView.View = View.SmallIcon;
		}

		private void MenuViewList_Click(object sender, System.EventArgs e)
		{
			ResetViewState();
			MenuViewList.Checked = true;
			ToolList.Pushed = true;
			OrdersView.View = View.List;
		}

		private void MenuViewDetails_Click(object sender, System.EventArgs e)
		{
			ResetViewState();
			MenuViewDetails.Checked = true;
			ToolReport.Pushed = true;
			OrdersView.View = View.Details;
		}

		private void MenuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void ToolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (e.Button.ImageIndex)
			{
			case 2: MenuFileNew_Click(sender, e); break;
			case 4: MenuFileOpen_Click(sender, e); break;
			case 5:	MenuFileSave_Click(sender, e); break;
			case 3: MenuOrdersNew_Click(sender, e); break;
			case 1: MenuOrdersEdit_Click(sender, e); break;
			case 0:	MenuOrdersDelete_Click(sender, e); break;
			case 8: MenuViewLarge_Click(sender, e); break;
			case 9: MenuViewSmall_Click(sender, e); break;
			case 7: MenuViewList_Click(sender, e); break;
			case 6: MenuViewDetails_Click(sender, e); break;
			}
		}

		private void ContextNew_Click(object sender, System.EventArgs e)
		{
			MenuOrdersNew_Click(sender, e);
		}

		private void ContextEdit_Click(object sender, System.EventArgs e)
		{
			MenuOrdersEdit_Click(sender, e);
		}

		private void ContextDelete_Click(object sender, System.EventArgs e)
		{
			MenuOrdersDelete_Click(sender, e);		
		}

		private void MenuOrdersNew_Click(object sender, System.EventArgs e)
		{
			OrderForm oDlg = new OrderForm(MenuOrdersBugs.Checked);
			if (oDlg.ShowDialog(this) != DialogResult.OK)
				return;

			if (oDlg.Date.Value > DateTime.Now)
			{
				MessageBox.Show(this,
					"The specified date is not valid.\r\nThe date is changed to the current one.",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				oDlg.Date.Value = DateTime.Now;
			}

			OrdersView.Items.Add("").Selected = true;
			UpdateCurrent(oDlg);
		}

		public void UpdateCurrent(OrderForm oDlg)
		{
			System.Diagnostics.Debug.Assert(OrdersView.SelectedItems.Count == 1);
				
			ListViewItem Item = OrdersView.SelectedItems[0];
			for (int n = Item.SubItems.Count; n < 11; n++)
				Item.SubItems.Add("");

			Item.Text = oDlg.Customer.Text;
			Item.SubItems[1].Text = oDlg.ProductNames.Text;
			Item.SubItems[2].Text = oDlg.Quantity.Value.ToString();
			Item.SubItems[3].Text = oDlg.Date.Value.ToShortDateString();
			Item.SubItems[4].Text = oDlg.Street.Text;
			Item.SubItems[5].Text = oDlg.City.Text;
			Item.SubItems[6].Text = oDlg.State.Text;
			Item.SubItems[7].Text = oDlg.Zip.Text;
			Item.SubItems[9].Text = oDlg.CardNo.Text;
			Item.SubItems[10].Text = oDlg.ExpDate.Value.ToShortDateString();

			if (oDlg.Visa.Checked)
				Item.SubItems[8].Text = oDlg.Visa.Text;
			else
				if (oDlg.MasterCard.Checked)
					Item.SubItems[8].Text = oDlg.MasterCard.Text;
				else
					Item.SubItems[8].Text = oDlg.AE.Text;

			Modified = true;
		}

		private void MenuOrdersEdit_Click(object sender, System.EventArgs e)
		{
			if (OrdersView.SelectedItems.Count != 1)
			{
				MessageBox.Show(this,
					"Please specify the item to edit.",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return;
			}

			ListViewItem Item = OrdersView.SelectedItems[0];
			OrderForm oDlg = new OrderForm(MenuOrdersBugs.Checked);

			oDlg.Customer.Text = Item.Text;
			oDlg.ProductNames.SelectedIndex = oDlg.ProductNames.Items.IndexOf(Item.SubItems[1].Text);
			oDlg.Quantity.Text = Item.SubItems[2].Text;
			oDlg.Date.Text = Item.SubItems[3].Text;
			oDlg.Street.Text = Item.SubItems[4].Text;
			oDlg.City.Text = Item.SubItems[5].Text;
			oDlg.State.Text = Item.SubItems[6].Text;
			oDlg.Zip.Text = Item.SubItems[7].Text;
			oDlg.CardNo.Text = Item.SubItems[9].Text;
			oDlg.ExpDate.Text = Item.SubItems[10].Text;

			if (Item.SubItems[8].Text == oDlg.Visa.Text)
				oDlg.Visa.Checked = true;
			else
				if (Item.SubItems[8].Text == oDlg.MasterCard.Text)
					oDlg.MasterCard.Checked = true;
			else
				oDlg.AE.Checked = true;

			if (oDlg.ShowDialog(this) != DialogResult.OK)
				return;

			if (oDlg.Date.Value > DateTime.Now)
			{
				MessageBox.Show(this,
					"The specified date is not valid.\r\nThe date is changed to the current one.",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				oDlg.Date.Value = DateTime.Now;
			}

			UpdateCurrent(oDlg);
		}

		private void MenuOrdersDelete_Click(object sender, System.EventArgs e)
		{
			if (OrdersView.SelectedItems.Count != 1)
			{
				MessageBox.Show(this,
					"Please specify the item to delete.",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return;
			}

			if (MessageBox.Show(this, "Delete the selected order?",
				"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
				DialogResult.Yes)
			{
				return;
			}
		
			ListViewItem Item = OrdersView.SelectedItems[0];
			int nIndex = Item.Index + 1;
			if (nIndex >= OrdersView.Items.Count)
				nIndex = Item.Index - 1;
			if (nIndex >= 0)
				OrdersView.Items[nIndex].Selected = true;

			OrdersView.Items.Remove(Item);
		}

		private void MenuFileNew_Click(object sender, System.EventArgs e)
		{
			New();
		}

		private bool New()
		{
			if (!Save())
				return false;

			Modified = false;
			FileName = "";
			OrdersView.Items.Clear();
			return true;
		}

		private bool Save()
		{
			if (!Modified)
				return true;

            string savestr = (FileName == "") ? "Untitled" : FileName;
            DialogResult res = MessageBox.Show(this, "Save changes to '" + savestr + "'?",
                "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel)
                return false;
            if (res == DialogResult.Yes)
            {
                if (FileName == "")
                {
                    if (SaveDialog.ShowDialog(this) != DialogResult.OK)
                        return false;

                    FileName = SaveDialog.FileName;
                } 
                DoSave();
            }
            return true;
		}

		private void DoSave()
		{
            StreamWriter sw = File.CreateText(SaveDialog.FileName);
			string strLine, strSubItem;

			for (int n = 0; n < OrdersView.Items.Count; n++)
			{
				strLine = OrdersView.Items[n].Text;
				for (int m = 1; m < OrdersView.Items[n].SubItems.Count; m++)
				{
					strSubItem = OrdersView.Items[n].SubItems[m].Text;
					if (m == 3 || m == 10)
						strSubItem = Convert.ToDateTime(strSubItem).ToOADate().ToString();
					strLine += "\t" + strSubItem;
				}
				sw.WriteLine(strLine);
			}

			sw.Close();
			Modified = false;
		}
		
		private void MenuFileOpen_Click(object sender, System.EventArgs e)
		{
			if (!New())
				return;
			if (OpenDialog.ShowDialog(this) != DialogResult.OK)
				return;

			FileName = OpenDialog.FileName;
			
			DoLoad();
		}
		
		private void DoLoad()
		{
			if (!File.Exists(FileName))
				return;
		
			StreamReader sr = File.OpenText(FileName);
			string strLine, strSubItem;
			ListViewItem Item;
			int nStart, nEnd, nSubIndex;
			bool bContinue;

			while ((strLine = sr.ReadLine()) != null)
			{
				Item = OrdersView.Items.Add("");
				for (int n = Item.SubItems.Count; n < 11; n++)
					Item.SubItems.Add("");

				nSubIndex = 0;
				nEnd = -1;
				bContinue = true;

				do
				{
					nStart = nEnd + 1;
					nEnd = strLine.IndexOf("\t", nStart);
					if (nEnd == -1)
					{
						nEnd = strLine.Length;
						bContinue = false;
					}

					strSubItem = strLine.Substring(nStart, nEnd - nStart);
					if (nSubIndex == 3 || nSubIndex == 10) 
						strSubItem = DateTime.FromOADate(Convert.ToDouble(strSubItem)).ToShortDateString();
					Item.SubItems[nSubIndex].Text = strSubItem;
					nSubIndex++;
					if (nSubIndex > 10)
						bContinue = false;
				}
				while (bContinue);
			}

			sr.Close();
		}

		private void MenuFileSave_Click(object sender, System.EventArgs e)
		{
			if (FileName == "")
			{
				if (SaveDialog.ShowDialog(this) != DialogResult.OK)
					return;

				FileName = SaveDialog.FileName;
			}
			else
				if (!Modified)
					return;

			DoSave();
		}

		private void MenuFileSaveAs_Click(object sender, System.EventArgs e)
		{
			if (SaveDialog.ShowDialog(this) != DialogResult.OK)
				return;

			FileName = SaveDialog.FileName;
			DoSave();
		}

		private void MainFrom_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (DontSaveOnExit)
				return;

			e.Cancel = !Save();
		}

		private void MenuOrdersBugs_Click(object sender, System.EventArgs e)
		{
			MenuOrdersBugs.Checked = !MenuOrdersBugs.Checked;
		}

		private void MenuReportGenerate_Click(object sender, System.EventArgs e)
		{
			if (CustomerSaveDlg.ShowDialog(this) != DialogResult.OK)
				return;

			StreamWriter sw = File.CreateText(CustomerSaveDlg.FileName);
			for (int n = 0; n < OrdersView.Items.Count; n++)
				sw.WriteLine(OrdersView.Items[n].Text);
			sw.Close();
		}
	}
}
