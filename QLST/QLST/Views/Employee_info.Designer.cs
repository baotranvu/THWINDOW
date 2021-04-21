namespace QLST
{
    partial class Employee_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_info));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.EmpPhone = new DevExpress.XtraEditors.TextEdit();
            this.EmpAdd = new DevExpress.XtraEditors.TextEdit();
            this.EmpBirth = new DevExpress.XtraEditors.DateEdit();
            this.EmpGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.EmpID = new DevExpress.XtraEditors.TextEdit();
            this.Update = new DevExpress.XtraEditors.SimpleButton();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.EmpName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Root1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.Address = new DevExpress.XtraLayout.LayoutControlItem();
            this.Birthday = new DevExpress.XtraLayout.LayoutControlItem();
            this.Gender = new DevExpress.XtraLayout.LayoutControlItem();
            this.ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.EmpPhone);
            this.layoutControl1.Controls.Add(this.EmpAdd);
            this.layoutControl1.Controls.Add(this.EmpBirth);
            this.layoutControl1.Controls.Add(this.EmpGender);
            this.layoutControl1.Controls.Add(this.EmpID);
            this.layoutControl1.Controls.Add(this.Update);
            this.layoutControl1.Controls.Add(this.Delete);
            this.layoutControl1.Controls.Add(this.EmpName);
            this.layoutControl1.Controls.Add(this.simpleButton11);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(687, 18, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(439, 380);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Location = new System.Drawing.Point(22, 293);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.EmpPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.EmpPhone.Size = new System.Drawing.Size(378, 20);
            this.EmpPhone.StyleController = this.layoutControl1;
            this.EmpPhone.TabIndex = 7;
            // 
            // EmpAdd
            // 
            this.EmpAdd.Location = new System.Drawing.Point(22, 234);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Properties.Mask.EditMask = "\\p{L}+";
            this.EmpAdd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.EmpAdd.Size = new System.Drawing.Size(378, 20);
            this.EmpAdd.StyleController = this.layoutControl1;
            this.EmpAdd.TabIndex = 6;
            // 
            // EmpBirth
            // 
            this.EmpBirth.EditValue = null;
            this.EmpBirth.Location = new System.Drawing.Point(22, 175);
            this.EmpBirth.Name = "EmpBirth";
            this.EmpBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpBirth.Properties.DisplayFormat.FormatString = "";
            this.EmpBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EmpBirth.Properties.EditFormat.FormatString = "";
            this.EmpBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EmpBirth.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.EmpBirth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.EmpBirth.Size = new System.Drawing.Size(378, 20);
            this.EmpBirth.StyleController = this.layoutControl1;
            this.EmpBirth.TabIndex = 5;
            // 
            // EmpGender
            // 
            this.EmpGender.Location = new System.Drawing.Point(241, 116);
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpGender.Properties.DropDownRows = 2;
            this.EmpGender.Properties.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.EmpGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.EmpGender.Size = new System.Drawing.Size(159, 20);
            this.EmpGender.StyleController = this.layoutControl1;
            this.EmpGender.TabIndex = 4;
            // 
            // EmpID
            // 
            this.EmpID.Enabled = false;
            this.EmpID.Location = new System.Drawing.Point(22, 57);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(159, 20);
            this.EmpID.StyleController = this.layoutControl1;
            this.EmpID.TabIndex = 11;
            // 
            // Update
            // 
            this.Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Update.ImageOptions.Image")));
            this.Update.Location = new System.Drawing.Point(22, 317);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(186, 38);
            this.Update.StyleController = this.layoutControl1;
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            // 
            // Delete
            // 
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.Location = new System.Drawing.Point(212, 317);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(188, 38);
            this.Delete.StyleController = this.layoutControl1;
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(22, 116);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(215, 20);
            this.EmpName.StyleController = this.layoutControl1;
            this.EmpName.TabIndex = 10;
            // 
            // simpleButton11
            // 
            this.simpleButton11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.simpleButton11.Location = new System.Drawing.Point(22, 359);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(378, 38);
            this.simpleButton11.StyleController = this.layoutControl1;
            this.simpleButton11.TabIndex = 16;
            this.simpleButton11.Text = "Cancel";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Root1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(422, 419);
            this.Root.TextVisible = false;
            // 
            // Root1
            // 
            this.Root1.CustomizationFormText = "Root";
            this.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root1.GroupBordersVisible = false;
            this.Root1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Phone,
            this.Address,
            this.Birthday,
            this.Gender,
            this.ID,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.Name,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.Root1.Location = new System.Drawing.Point(0, 0);
            this.Root1.Name = "Root1";
            this.Root1.Size = new System.Drawing.Size(402, 399);
            this.Root1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root1.Text = "Root";
            this.Root1.TextVisible = false;
            // 
            // Phone
            // 
            this.Phone.Control = this.EmpPhone;
            this.Phone.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Phone.CustomizationFormText = "Phone";
            this.Phone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Phone.ImageOptions.Image")));
            this.Phone.Location = new System.Drawing.Point(0, 236);
            this.Phone.Name = "Phone";
            this.Phone.OptionsTableLayoutItem.RowIndex = 4;
            this.Phone.Size = new System.Drawing.Size(382, 59);
            this.Phone.TextLocation = DevExpress.Utils.Locations.Top;
            this.Phone.TextSize = new System.Drawing.Size(97, 32);
            // 
            // Address
            // 
            this.Address.Control = this.EmpAdd;
            this.Address.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Address.CustomizationFormText = "Address";
            this.Address.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Address.ImageOptions.Image")));
            this.Address.Location = new System.Drawing.Point(0, 177);
            this.Address.Name = "Address";
            this.Address.OptionsTableLayoutItem.RowIndex = 3;
            this.Address.Size = new System.Drawing.Size(382, 59);
            this.Address.TextLocation = DevExpress.Utils.Locations.Top;
            this.Address.TextSize = new System.Drawing.Size(97, 32);
            // 
            // Birthday
            // 
            this.Birthday.Control = this.EmpBirth;
            this.Birthday.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Birthday.CustomizationFormText = "Birthday";
            this.Birthday.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Birthday.ImageOptions.Image")));
            this.Birthday.Location = new System.Drawing.Point(0, 118);
            this.Birthday.Name = "Birthday";
            this.Birthday.OptionsTableLayoutItem.RowIndex = 2;
            this.Birthday.Size = new System.Drawing.Size(382, 59);
            this.Birthday.TextLocation = DevExpress.Utils.Locations.Top;
            this.Birthday.TextSize = new System.Drawing.Size(97, 32);
            // 
            // Gender
            // 
            this.Gender.Control = this.EmpGender;
            this.Gender.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Gender.CustomizationFormText = "Gender";
            this.Gender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Gender.ImageOptions.Image")));
            this.Gender.Location = new System.Drawing.Point(219, 59);
            this.Gender.Name = "Gender";
            this.Gender.OptionsTableLayoutItem.RowIndex = 1;
            this.Gender.Size = new System.Drawing.Size(163, 59);
            this.Gender.TextLocation = DevExpress.Utils.Locations.Top;
            this.Gender.TextSize = new System.Drawing.Size(97, 32);
            // 
            // ID
            // 
            this.ID.Control = this.EmpID;
            this.ID.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ID.CustomizationFormText = "Customer ID";
            this.ID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ID.ImageOptions.Image")));
            this.ID.Location = new System.Drawing.Point(0, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(163, 59);
            this.ID.Text = "Employee ID";
            this.ID.TextLocation = DevExpress.Utils.Locations.Top;
            this.ID.TextSize = new System.Drawing.Size(97, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Update;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Update";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 295);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(190, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Delete;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Delete";
            this.layoutControlItem4.Location = new System.Drawing.Point(190, 295);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(192, 42);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // Name
            // 
            this.Name.Control = this.EmpName;
            this.Name.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Name.CustomizationFormText = "Name";
            this.Name.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Name.ImageOptions.Image")));
            this.Name.Location = new System.Drawing.Point(0, 59);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(219, 59);
            this.Name.TextLocation = DevExpress.Utils.Locations.Top;
            this.Name.TextSize = new System.Drawing.Size(97, 32);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(163, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(219, 59);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton11;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 337);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(382, 42);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Employee_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 380);
            this.Controls.Add(this.layoutControl1);
            
            this.Text = "Employee_info";
            this.Load += new System.EventHandler(this.Employee_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit EmpPhone;
        private DevExpress.XtraEditors.TextEdit EmpAdd;
        private DevExpress.XtraEditors.DateEdit EmpBirth;
        private DevExpress.XtraEditors.ComboBoxEdit EmpGender;
        private DevExpress.XtraEditors.TextEdit EmpID;
        private DevExpress.XtraEditors.SimpleButton Update;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.TextEdit EmpName;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraLayout.LayoutControlGroup Root1;
        private DevExpress.XtraLayout.LayoutControlItem Phone;
        private DevExpress.XtraLayout.LayoutControlItem Address;
        private DevExpress.XtraLayout.LayoutControlItem Birthday;
        private DevExpress.XtraLayout.LayoutControlItem Gender;
        private DevExpress.XtraLayout.LayoutControlItem ID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem Name;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}