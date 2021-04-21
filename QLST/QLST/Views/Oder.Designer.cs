namespace QLST
{
    partial class Oder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oder));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrdID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrdDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.order_ds = new QLST.order_ds();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new QLST.order_dsTableAdapters.OrdersTableAdapter();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ordersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(687, 403);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrdID,
            this.EmpID,
            this.ProID,
            this.OrdDate,
            this.Total});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // OrdID
            // 
            this.OrdID.FieldName = "OrdID";
            this.OrdID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OrdID.ImageOptions.Image")));
            this.OrdID.Name = "OrdID";
            this.OrdID.Visible = true;
            this.OrdID.VisibleIndex = 0;
            // 
            // EmpID
            // 
            this.EmpID.FieldName = "EmpID";
            this.EmpID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmpID.ImageOptions.Image")));
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = true;
            this.EmpID.VisibleIndex = 1;
            // 
            // ProID
            // 
            this.ProID.FieldName = "ProID";
            this.ProID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProID.ImageOptions.Image")));
            this.ProID.Name = "ProID";
            this.ProID.Visible = true;
            this.ProID.VisibleIndex = 2;
            // 
            // OrdDate
            // 
            this.OrdDate.FieldName = "OrdDate";
            this.OrdDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OrdDate.ImageOptions.Image")));
            this.OrdDate.Name = "OrdDate";
            this.OrdDate.Visible = true;
            this.OrdDate.VisibleIndex = 3;
            // 
            // order_ds
            // 
            this.order_ds.DataSetName = "order_ds";
            this.order_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.order_ds;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Total
            // 
            this.Total.FieldName = "Total";
            this.Total.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Total.ImageOptions.Image")));
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 4;
            // 
            // Oder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 403);
            this.Controls.Add(this.gridControl1);
            this.Name = "Oder";
            this.Text = "Oder";
            this.Load += new System.EventHandler(this.Oder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn OrdID;
        private DevExpress.XtraGrid.Columns.GridColumn EmpID;
        private DevExpress.XtraGrid.Columns.GridColumn ProID;
        private DevExpress.XtraGrid.Columns.GridColumn OrdDate;
        private order_ds order_ds;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private order_dsTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
    }
}