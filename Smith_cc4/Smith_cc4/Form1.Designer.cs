
namespace Smith_cc4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label apptIDLabel;
            System.Windows.Forms.Label apptPaitentNameLabel;
            System.Windows.Forms.Label apptDateLabel;
            System.Windows.Forms.Label apptTimeLabel;
            System.Windows.Forms.Label apptDoctorNameLabel;
            this.apptListBox = new System.Windows.Forms.ListBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smith_MedicalDataSet = new Smith_cc4.smith_MedicalDataSet();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smithMedicalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new Smith_cc4.smith_MedicalDataSetTableAdapters.AppointmentsTableAdapter();
            this.tableAdapterManager = new Smith_cc4.smith_MedicalDataSetTableAdapters.TableAdapterManager();
            this.tableTableAdapter = new Smith_cc4.smith_MedicalDataSetTableAdapters.TableTableAdapter();
            this.appointmentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.appointmentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.smith_MedicalDataSet1 = new Smith_cc4.smith_MedicalDataSet1();
            this.tableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new Smith_cc4.smith_MedicalDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager1 = new Smith_cc4.smith_MedicalDataSet1TableAdapters.TableAdapterManager();
            this.apptIDTextBox = new System.Windows.Forms.TextBox();
            this.apptPaitentNameTextBox = new System.Windows.Forms.TextBox();
            this.apptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apptTimeTextBox = new System.Windows.Forms.TextBox();
            this.apptDoctorNameTextBox = new System.Windows.Forms.TextBox();
            apptIDLabel = new System.Windows.Forms.Label();
            apptPaitentNameLabel = new System.Windows.Forms.Label();
            apptDateLabel = new System.Windows.Forms.Label();
            apptTimeLabel = new System.Windows.Forms.Label();
            apptDoctorNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smith_MedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smithMedicalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingNavigator)).BeginInit();
            this.appointmentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smith_MedicalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // apptListBox
            // 
            this.apptListBox.DataSource = this.tableBindingSource3;
            this.apptListBox.DisplayMember = "apptID";
            this.apptListBox.FormattingEnabled = true;
            this.apptListBox.ItemHeight = 20;
            this.apptListBox.Location = new System.Drawing.Point(40, 76);
            this.apptListBox.Name = "apptListBox";
            this.apptListBox.Size = new System.Drawing.Size(222, 324);
            this.apptListBox.TabIndex = 0;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.smith_MedicalDataSet;
            // 
            // smith_MedicalDataSet
            // 
            this.smith_MedicalDataSet.DataSetName = "smith_MedicalDataSet";
            this.smith_MedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.smithMedicalDataSetBindingSource;
            // 
            // smithMedicalDataSetBindingSource
            // 
            this.smithMedicalDataSetBindingSource.DataSource = this.smith_MedicalDataSet;
            this.smithMedicalDataSetBindingSource.Position = 0;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.smith_MedicalDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Smith_cc4.smith_MedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsBindingNavigator
            // 
            this.appointmentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appointmentsBindingNavigator.BindingSource = this.appointmentsBindingSource;
            this.appointmentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointmentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appointmentsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.appointmentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.appointmentsBindingNavigatorSaveItem});
            this.appointmentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointmentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointmentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointmentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointmentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointmentsBindingNavigator.Name = "appointmentsBindingNavigator";
            this.appointmentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointmentsBindingNavigator.Size = new System.Drawing.Size(853, 33);
            this.appointmentsBindingNavigator.TabIndex = 1;
            this.appointmentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // appointmentsBindingNavigatorSaveItem
            // 
            this.appointmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appointmentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentsBindingNavigatorSaveItem.Image")));
            this.appointmentsBindingNavigatorSaveItem.Name = "appointmentsBindingNavigatorSaveItem";
            this.appointmentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.appointmentsBindingNavigatorSaveItem.Text = "Save Data";
            this.appointmentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.appointmentsBindingNavigatorSaveItem_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(401, 396);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(135, 69);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Close";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.smith_MedicalDataSet;
            // 
            // smith_MedicalDataSet1
            // 
            this.smith_MedicalDataSet1.DataSetName = "smith_MedicalDataSet1";
            this.smith_MedicalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource3
            // 
            this.tableBindingSource3.DataMember = "Table";
            this.tableBindingSource3.DataSource = this.smith_MedicalDataSet1;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TableTableAdapter = this.tableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Smith_cc4.smith_MedicalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // apptIDLabel
            // 
            apptIDLabel.AutoSize = true;
            apptIDLabel.Location = new System.Drawing.Point(400, 110);
            apptIDLabel.Name = "apptIDLabel";
            apptIDLabel.Size = new System.Drawing.Size(66, 20);
            apptIDLabel.TabIndex = 12;
            apptIDLabel.Text = "appt ID:";
            // 
            // apptIDTextBox
            // 
            this.apptIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource3, "apptID", true));
            this.apptIDTextBox.Location = new System.Drawing.Point(599, 110);
            this.apptIDTextBox.Name = "apptIDTextBox";
            this.apptIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.apptIDTextBox.TabIndex = 13;
            // 
            // apptPaitentNameLabel
            // 
            apptPaitentNameLabel.AutoSize = true;
            apptPaitentNameLabel.Location = new System.Drawing.Point(397, 158);
            apptPaitentNameLabel.Name = "apptPaitentNameLabel";
            apptPaitentNameLabel.Size = new System.Drawing.Size(145, 20);
            apptPaitentNameLabel.TabIndex = 13;
            apptPaitentNameLabel.Text = "appt Paitent Name:";
            // 
            // apptPaitentNameTextBox
            // 
            this.apptPaitentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource3, "apptPaitentName", true));
            this.apptPaitentNameTextBox.Location = new System.Drawing.Point(599, 155);
            this.apptPaitentNameTextBox.Name = "apptPaitentNameTextBox";
            this.apptPaitentNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.apptPaitentNameTextBox.TabIndex = 14;
            // 
            // apptDateLabel
            // 
            apptDateLabel.AutoSize = true;
            apptDateLabel.Location = new System.Drawing.Point(409, 212);
            apptDateLabel.Name = "apptDateLabel";
            apptDateLabel.Size = new System.Drawing.Size(84, 20);
            apptDateLabel.TabIndex = 14;
            apptDateLabel.Text = "appt Date:";
            // 
            // apptDateDateTimePicker
            // 
            this.apptDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource3, "apptDate", true));
            this.apptDateDateTimePicker.Location = new System.Drawing.Point(560, 207);
            this.apptDateDateTimePicker.Name = "apptDateDateTimePicker";
            this.apptDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.apptDateDateTimePicker.TabIndex = 15;
            // 
            // apptTimeLabel
            // 
            apptTimeLabel.AutoSize = true;
            apptTimeLabel.Location = new System.Drawing.Point(409, 249);
            apptTimeLabel.Name = "apptTimeLabel";
            apptTimeLabel.Size = new System.Drawing.Size(83, 20);
            apptTimeLabel.TabIndex = 15;
            apptTimeLabel.Text = "appt Time:";
            // 
            // apptTimeTextBox
            // 
            this.apptTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource3, "apptTime", true));
            this.apptTimeTextBox.Location = new System.Drawing.Point(599, 246);
            this.apptTimeTextBox.Name = "apptTimeTextBox";
            this.apptTimeTextBox.Size = new System.Drawing.Size(100, 26);
            this.apptTimeTextBox.TabIndex = 16;
            // 
            // apptDoctorNameLabel
            // 
            apptDoctorNameLabel.AutoSize = true;
            apptDoctorNameLabel.Location = new System.Drawing.Point(411, 291);
            apptDoctorNameLabel.Name = "apptDoctorNameLabel";
            apptDoctorNameLabel.Size = new System.Drawing.Size(143, 20);
            apptDoctorNameLabel.TabIndex = 16;
            apptDoctorNameLabel.Text = "appt Doctor Name:";
            // 
            // apptDoctorNameTextBox
            // 
            this.apptDoctorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource3, "apptDoctorName", true));
            this.apptDoctorNameTextBox.Location = new System.Drawing.Point(599, 288);
            this.apptDoctorNameTextBox.Name = "apptDoctorNameTextBox";
            this.apptDoctorNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.apptDoctorNameTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 508);
            this.Controls.Add(apptDoctorNameLabel);
            this.Controls.Add(this.apptDoctorNameTextBox);
            this.Controls.Add(apptTimeLabel);
            this.Controls.Add(this.apptTimeTextBox);
            this.Controls.Add(apptDateLabel);
            this.Controls.Add(this.apptDateDateTimePicker);
            this.Controls.Add(apptPaitentNameLabel);
            this.Controls.Add(this.apptPaitentNameTextBox);
            this.Controls.Add(apptIDLabel);
            this.Controls.Add(this.apptIDTextBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.appointmentsBindingNavigator);
            this.Controls.Add(this.apptListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smith_MedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smithMedicalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingNavigator)).EndInit();
            this.appointmentsBindingNavigator.ResumeLayout(false);
            this.appointmentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smith_MedicalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox apptListBox;
        private smith_MedicalDataSet smith_MedicalDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private smith_MedicalDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private smith_MedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appointmentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton appointmentsBindingNavigatorSaveItem;
        private smith_MedicalDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.BindingSource smithMedicalDataSetBindingSource;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private smith_MedicalDataSet1 smith_MedicalDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource3;
        private smith_MedicalDataSet1TableAdapters.TableTableAdapter tableTableAdapter1;
        private smith_MedicalDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox apptIDTextBox;
        private System.Windows.Forms.TextBox apptPaitentNameTextBox;
        private System.Windows.Forms.DateTimePicker apptDateDateTimePicker;
        private System.Windows.Forms.TextBox apptTimeTextBox;
        private System.Windows.Forms.TextBox apptDoctorNameTextBox;
    }
}

