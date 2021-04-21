namespace QLST
{
    partial class New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Employee));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.FirstName = new DevExpress.XtraEditors.TextEdit();
            this.Phone = new DevExpress.XtraEditors.TextEdit();
            this.LastName = new DevExpress.XtraEditors.TextEdit();
            this.Date = new DevExpress.XtraEditors.DateEdit();
            this.Address = new DevExpress.XtraEditors.TextEdit();
            this.Password = new DevExpress.XtraEditors.TextEdit();
            this.Confirm = new DevExpress.XtraEditors.TextEdit();
            this.Gender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Create = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.FirstName);
            this.layoutControl1.Controls.Add(this.Phone);
            this.layoutControl1.Controls.Add(this.LastName);
            this.layoutControl1.Controls.Add(this.Date);
            this.layoutControl1.Controls.Add(this.Address);
            this.layoutControl1.Controls.Add(this.Password);
            this.layoutControl1.Controls.Add(this.Confirm);
            this.layoutControl1.Controls.Add(this.Gender);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(522, 51, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(592, 166);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // FirstName
            // 
            this.FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstName.Location = new System.Drawing.Point(121, 12);
            this.FirstName.Name = "FirstName";
            this.FirstName.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.FirstName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.FirstName.Size = new System.Drawing.Size(199, 20);
            this.FirstName.StyleController = this.layoutControl1;
            this.FirstName.TabIndex = 4;
            // 
            // Phone
            // 
            this.Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phone.Location = new System.Drawing.Point(433, 12);
            this.Phone.Name = "Phone";
            this.Phone.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.Phone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.Phone.Size = new System.Drawing.Size(147, 20);
            this.Phone.StyleController = this.layoutControl1;
            this.Phone.TabIndex = 5;
            // 
            // LastName
            // 
            this.LastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastName.Location = new System.Drawing.Point(121, 48);
            this.LastName.Name = "LastName";
            this.LastName.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.LastName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.LastName.Size = new System.Drawing.Size(199, 20);
            this.LastName.StyleController = this.layoutControl1;
            this.LastName.TabIndex = 6;
            // 
            // Date
            // 
            this.Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date.EditValue = null;
            this.Date.Location = new System.Drawing.Point(433, 48);
            this.Date.Name = "Date";
            this.Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Date.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Date.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Date.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.Date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Date.Size = new System.Drawing.Size(147, 20);
            this.Date.StyleController = this.layoutControl1;
            this.Date.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Location = new System.Drawing.Point(121, 120);
            this.Address.Name = "Address";
            this.Address.Properties.Mask.EditMask = ".+";
            this.Address.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Address.Size = new System.Drawing.Size(199, 20);
            this.Address.StyleController = this.layoutControl1;
            this.Address.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Location = new System.Drawing.Point(121, 84);
            this.Password.Name = "Password";
            this.Password.Properties.PasswordChar = '*';
            this.Password.Properties.UseSystemPasswordChar = true;
            this.Password.Size = new System.Drawing.Size(199, 20);
            this.Password.StyleController = this.layoutControl1;
            this.Password.TabIndex = 9;
            // 
            // Confirm
            // 
            this.Confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Confirm.Location = new System.Drawing.Point(433, 84);
            this.Confirm.Name = "Confirm";
            this.Confirm.Properties.PasswordChar = '*';
            this.Confirm.Properties.UseSystemPasswordChar = true;
            this.Confirm.Size = new System.Drawing.Size(147, 20);
            this.Confirm.StyleController = this.layoutControl1;
            this.Confirm.TabIndex = 10;
            // 
            // Gender
            // 
            this.Gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gender.Location = new System.Drawing.Point(433, 120);
            this.Gender.Name = "Gender";
            this.Gender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Gender.Properties.DropDownRows = 2;
            this.Gender.Properties.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.Gender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Gender.Size = new System.Drawing.Size(147, 20);
            this.Gender.StyleController = this.layoutControl1;
            this.Gender.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(592, 166);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.FirstName;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "FirstName";
            this.layoutControlItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem1.ImageOptions.Image")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(312, 36);
            this.layoutControlItem1.Text = "First name";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(106, 32);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Phone;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Phone";
            this.layoutControlItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem2.ImageOptions.Image")));
            this.layoutControlItem2.Location = new System.Drawing.Point(312, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(260, 36);
            this.layoutControlItem2.Text = "Phone number";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(106, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.LastName;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "LastName";
            this.layoutControlItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem3.ImageOptions.Image")));
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(312, 36);
            this.layoutControlItem3.Text = "Last name";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(106, 32);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Date;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Date";
            this.layoutControlItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem4.ImageOptions.Image")));
            this.layoutControlItem4.Location = new System.Drawing.Point(312, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(260, 36);
            this.layoutControlItem4.Text = "Date of birth";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(106, 32);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.Password;
            this.layoutControlItem6.CustomizationFormText = "Password";
            this.layoutControlItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem6.ImageOptions.Image")));
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(312, 36);
            this.layoutControlItem6.Text = "Password";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(106, 32);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Address;
            this.layoutControlItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem5.ImageOptions.Image")));
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(312, 38);
            this.layoutControlItem5.Text = "Address";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(106, 32);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.Confirm;
            this.layoutControlItem7.CustomizationFormText = "Confirm";
            this.layoutControlItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem7.ImageOptions.Image")));
            this.layoutControlItem7.Location = new System.Drawing.Point(312, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(260, 36);
            this.layoutControlItem7.Text = "Confirm";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(106, 32);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.Gender;
            this.layoutControlItem8.CustomizationFormText = "Gender";
            this.layoutControlItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem8.ImageOptions.Image")));
            this.layoutControlItem8.Location = new System.Drawing.Point(312, 108);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(260, 38);
            this.layoutControlItem8.Text = "Gender";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(106, 32);
            // 
            // Create
            // 
            this.Create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Create.Location = new System.Drawing.Point(3, 333);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(592, 28);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Create, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.96375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.03625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 364);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::QLST.Properties.Resources.App_logo;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(592, 152);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "New_Employee";
            this.Text = "New_Employee";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit FirstName;
        private DevExpress.XtraEditors.TextEdit Phone;
        private DevExpress.XtraEditors.TextEdit LastName;
        private DevExpress.XtraEditors.DateEdit Date;
        private DevExpress.XtraEditors.TextEdit Address;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton Create;
        private DevExpress.XtraEditors.TextEdit Password;
        private DevExpress.XtraEditors.TextEdit Confirm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.ComboBoxEdit Gender;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}