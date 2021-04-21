namespace QLST
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_ds = new QLST.employee_ds();
            this.emp_info = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeesTableAdapter = new QLST.employee_dsTableAdapters.EmployeesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_info)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 409);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GridControl1
            // 
            this.GridControl1.DataSource = this.employeesBindingSource;
            this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl1.Location = new System.Drawing.Point(3, 3);
            this.GridControl1.MainView = this.emp_info;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(876, 403);
            this.GridControl1.TabIndex = 0;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.emp_info});
            this.GridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employee_ds;
            // 
            // employee_ds
            // 
            this.employee_ds.DataSetName = "employee_ds";
            this.employee_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_info
            // 
            this.emp_info.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmpID,
            this.EmpName});
            this.emp_info.GridControl = this.GridControl1;
            this.emp_info.Name = "emp_info";
            this.emp_info.OptionsBehavior.Editable = false;
            // 
            // EmpID
            // 
            this.EmpID.FieldName = "EmpID";
            this.EmpID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmpID.ImageOptions.Image")));
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = true;
            this.EmpID.VisibleIndex = 0;
            // 
            // EmpName
            // 
            this.EmpName.FieldName = "Name";
            this.EmpName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmpName.ImageOptions.Image")));
            this.EmpName.Name = "EmpName";
            this.EmpName.Visible = true;
            this.EmpName.VisibleIndex = 1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView emp_info;
        private DevExpress.XtraGrid.Columns.GridColumn EmpID;
        private DevExpress.XtraGrid.Columns.GridColumn EmpName;
        private employee_ds employee_ds;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private employee_dsTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}