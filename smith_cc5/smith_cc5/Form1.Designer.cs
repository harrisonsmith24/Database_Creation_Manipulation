﻿
namespace smith_cc5
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
            this.patientInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.patientInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.heightBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smithMedicalDataSet = new smith_cc5.smithMedicalDataSet();
            this.patientInfoTableAdapter = new smith_cc5.smithMedicalDataSetTableAdapters.patientInfoTableAdapter();
            this.tableAdapterManager = new smith_cc5.smithMedicalDataSetTableAdapters.TableAdapterManager();
            this.largeWeightBtn = new System.Windows.Forms.Button();
            this.smallWeightBtn = new System.Windows.Forms.Button();
            this.ageBtn = new System.Windows.Forms.Button();
            this.valueBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingNavigator)).BeginInit();
            this.patientInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smithMedicalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patientInfoBindingNavigator
            // 
            this.patientInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientInfoBindingNavigator.BindingSource = this.patientInfoBindingSource;
            this.patientInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientInfoBindingNavigatorSaveItem});
            this.patientInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientInfoBindingNavigator.Name = "patientInfoBindingNavigator";
            this.patientInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientInfoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.patientInfoBindingNavigator.TabIndex = 0;
            this.patientInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // patientInfoBindingNavigatorSaveItem
            // 
            this.patientInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientInfoBindingNavigatorSaveItem.Image")));
            this.patientInfoBindingNavigatorSaveItem.Name = "patientInfoBindingNavigatorSaveItem";
            this.patientInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.patientInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientInfoBindingNavigatorSaveItem_Click);
            // 
            // patientInfoDataGridView
            // 
            this.patientInfoDataGridView.AutoGenerateColumns = false;
            this.patientInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.patientInfoDataGridView.DataSource = this.patientInfoBindingSource;
            this.patientInfoDataGridView.Location = new System.Drawing.Point(40, 55);
            this.patientInfoDataGridView.Name = "patientInfoDataGridView";
            this.patientInfoDataGridView.Size = new System.Drawing.Size(682, 262);
            this.patientInfoDataGridView.TabIndex = 1;
            // 
            // heightBtn
            // 
            this.heightBtn.Location = new System.Drawing.Point(40, 364);
            this.heightBtn.Name = "heightBtn";
            this.heightBtn.Size = new System.Drawing.Size(94, 40);
            this.heightBtn.TabIndex = 2;
            this.heightBtn.Text = "Sort By Height";
            this.heightBtn.UseVisualStyleBackColor = true;
            this.heightBtn.Click += new System.EventHandler(this.heightBtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "patientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "patientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "patientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "patientName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "patientAge";
            this.dataGridViewTextBoxColumn3.HeaderText = "patientAge";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "patientHeight";
            this.dataGridViewTextBoxColumn4.HeaderText = "patientHeight";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "patientWeight";
            this.dataGridViewTextBoxColumn5.HeaderText = "patientWeight";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "patientA1cvalue";
            this.dataGridViewTextBoxColumn6.HeaderText = "patientA1cvalue";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // patientInfoBindingSource
            // 
            this.patientInfoBindingSource.DataMember = "patientInfo";
            this.patientInfoBindingSource.DataSource = this.smithMedicalDataSet;
            // 
            // smithMedicalDataSet
            // 
            this.smithMedicalDataSet.DataSetName = "smithMedicalDataSet";
            this.smithMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientInfoTableAdapter
            // 
            this.patientInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patientInfoTableAdapter = this.patientInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = smith_cc5.smithMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // largeWeightBtn
            // 
            this.largeWeightBtn.Location = new System.Drawing.Point(171, 364);
            this.largeWeightBtn.Name = "largeWeightBtn";
            this.largeWeightBtn.Size = new System.Drawing.Size(97, 40);
            this.largeWeightBtn.TabIndex = 3;
            this.largeWeightBtn.Text = "Show Weight > 200";
            this.largeWeightBtn.UseVisualStyleBackColor = true;
            this.largeWeightBtn.Click += new System.EventHandler(this.largeWeightBtn_Click);
            // 
            // smallWeightBtn
            // 
            this.smallWeightBtn.Location = new System.Drawing.Point(323, 364);
            this.smallWeightBtn.Name = "smallWeightBtn";
            this.smallWeightBtn.Size = new System.Drawing.Size(101, 40);
            this.smallWeightBtn.TabIndex = 4;
            this.smallWeightBtn.Text = "Show Weight < 100";
            this.smallWeightBtn.UseVisualStyleBackColor = true;
            this.smallWeightBtn.Click += new System.EventHandler(this.smallWeightBtn_Click);
            // 
            // ageBtn
            // 
            this.ageBtn.Location = new System.Drawing.Point(487, 364);
            this.ageBtn.Name = "ageBtn";
            this.ageBtn.Size = new System.Drawing.Size(90, 40);
            this.ageBtn.TabIndex = 5;
            this.ageBtn.Text = "Fill By Age > 70";
            this.ageBtn.UseVisualStyleBackColor = true;
            this.ageBtn.Click += new System.EventHandler(this.ageBtn_Click);
            // 
            // valueBtn
            // 
            this.valueBtn.Location = new System.Drawing.Point(638, 364);
            this.valueBtn.Name = "valueBtn";
            this.valueBtn.Size = new System.Drawing.Size(84, 40);
            this.valueBtn.TabIndex = 6;
            this.valueBtn.Text = "Fill by a1c Value > 5.7";
            this.valueBtn.UseVisualStyleBackColor = true;
            this.valueBtn.Click += new System.EventHandler(this.valueBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valueBtn);
            this.Controls.Add(this.ageBtn);
            this.Controls.Add(this.smallWeightBtn);
            this.Controls.Add(this.largeWeightBtn);
            this.Controls.Add(this.heightBtn);
            this.Controls.Add(this.patientInfoDataGridView);
            this.Controls.Add(this.patientInfoBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingNavigator)).EndInit();
            this.patientInfoBindingNavigator.ResumeLayout(false);
            this.patientInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smithMedicalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private smithMedicalDataSet smithMedicalDataSet;
        private System.Windows.Forms.BindingSource patientInfoBindingSource;
        private smithMedicalDataSetTableAdapters.patientInfoTableAdapter patientInfoTableAdapter;
        private smithMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView patientInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button heightBtn;
        private System.Windows.Forms.Button largeWeightBtn;
        private System.Windows.Forms.Button smallWeightBtn;
        private System.Windows.Forms.Button ageBtn;
        private System.Windows.Forms.Button valueBtn;
    }
}

