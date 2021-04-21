namespace QLST
{
    partial class Providers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Providers));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Provider = new DevExpress.XtraGrid.GridControl();
            this.provider_ds = new QLST.provider_ds();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new QLST.provider_dsTableAdapters.ProvidersTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Provider, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 488);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProID,
            this.ProName});
            this.gridView1.GridControl = this.Provider;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // ProID
            // 
            this.ProID.FieldName = "ProID";
            this.ProID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProID.ImageOptions.Image")));
            this.ProID.Name = "ProID";
            this.ProID.Visible = true;
            this.ProID.VisibleIndex = 0;
            // 
            // ProName
            // 
            this.ProName.FieldName = "Name";
            this.ProName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProName.ImageOptions.Image")));
            this.ProName.Name = "ProName";
            this.ProName.Visible = true;
            this.ProName.VisibleIndex = 1;
            // 
            // Provider
            // 
            this.Provider.DataSource = this.providersBindingSource;
            this.Provider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Provider.Location = new System.Drawing.Point(3, 3);
            this.Provider.MainView = this.gridView1;
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(843, 482);
            this.Provider.TabIndex = 0;
            this.Provider.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Provider.Click += new System.EventHandler(this.Provider_Click);
            // 
            // provider_ds
            // 
            this.provider_ds.DataSetName = "provider_ds";
            this.provider_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.provider_ds;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // Providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Providers";
            this.Text = "Provider";
            this.Load += new System.EventHandler(this.Providers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl Provider;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ProID;
        private DevExpress.XtraGrid.Columns.GridColumn ProName;
        private provider_ds provider_ds;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private provider_dsTableAdapters.ProvidersTableAdapter providersTableAdapter;
    }
}