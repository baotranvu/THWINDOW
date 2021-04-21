namespace QLST
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Customer = new DevExpress.XtraGrid.GridControl();
            this.cus_info = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.customer_ds = new QLST.customer_ds();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new QLST.customer_dsTableAdapters.CustomersTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cus_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Customer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 438);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Customer
            // 
            this.Customer.DataSource = this.customersBindingSource;
            this.Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer.Location = new System.Drawing.Point(3, 3);
            this.Customer.MainView = this.cus_info;
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(470, 432);
            this.Customer.TabIndex = 0;
            this.Customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cus_info});
            this.Customer.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cus_info
            // 
            this.cus_info.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CusID,
            this.CusName});
            this.cus_info.CustomizationFormBounds = new System.Drawing.Rectangle(558, 119, 256, 410);
            this.cus_info.GridControl = this.Customer;
            this.cus_info.Name = "cus_info";
            this.cus_info.OptionsBehavior.Editable = false;
            // 
            // CusID
            // 
            this.CusID.FieldName = "CusID";
            this.CusID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CusID.ImageOptions.Image")));
            this.CusID.Name = "CusID";
            this.CusID.Visible = true;
            this.CusID.VisibleIndex = 0;
            this.CusID.Width = 197;
            // 
            // CusName
            // 
            this.CusName.Caption = "Name";
            this.CusName.FieldName = "Name";
            this.CusName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CusName.ImageOptions.Image")));
            this.CusName.Name = "CusName";
            this.CusName.Visible = true;
            this.CusName.VisibleIndex = 1;
            this.CusName.Width = 254;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // customer_ds
            // 
            this.customer_ds.DataSetName = "customer_ds";
            this.customer_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customer_ds;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cus_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraGrid.GridControl Customer;
        private DevExpress.XtraGrid.Views.Grid.GridView cus_info;
        private DevExpress.XtraGrid.Columns.GridColumn CusID;
        private DevExpress.XtraGrid.Columns.GridColumn CusName;
        private customer_ds customer_ds;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private customer_dsTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}