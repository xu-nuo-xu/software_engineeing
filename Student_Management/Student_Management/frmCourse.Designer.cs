namespace Student_Management
{
    partial class frmCourse
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
            _Instance = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label couNoLabel;
            System.Windows.Forms.Label couNameLabel;
            System.Windows.Forms.Label creditLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourse));
            this.student_Manage_DB = new Student_Management.Student_Manage_DB();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Student_Management.Student_Manage_DBTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager();
            this.courseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.couNoTextBox = new System.Windows.Forms.TextBox();
            this.couNameTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据总览 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.toolStripButton2 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton3 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton4 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton5 = new MetroFramework.Controls.MetroTile();
            couNoLabel = new System.Windows.Forms.Label();
            couNameLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).BeginInit();
            this.courseBindingNavigator.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // couNoLabel
            // 
            couNoLabel.AutoSize = true;
            couNoLabel.Location = new System.Drawing.Point(28, 37);
            couNoLabel.Name = "couNoLabel";
            couNoLabel.Size = new System.Drawing.Size(63, 15);
            couNoLabel.TabIndex = 1;
            couNoLabel.Text = "Cou No:";
            // 
            // couNameLabel
            // 
            couNameLabel.AutoSize = true;
            couNameLabel.Location = new System.Drawing.Point(28, 68);
            couNameLabel.Name = "couNameLabel";
            couNameLabel.Size = new System.Drawing.Size(79, 15);
            couNameLabel.TabIndex = 3;
            couNameLabel.Text = "Cou Name:";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Location = new System.Drawing.Point(28, 99);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(63, 15);
            creditLabel.TabIndex = 5;
            creditLabel.Text = "Credit:";
            // 
            // student_Manage_DB
            // 
            this.student_Manage_DB.DataSetName = "Student_Manage_DB";
            this.student_Manage_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.student_Manage_DB;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.StuCouTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseBindingNavigator
            // 
            this.courseBindingNavigator.AddNewItem = null;
            this.courseBindingNavigator.BindingSource = this.courseBindingSource;
            this.courseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courseBindingNavigator.DeleteItem = null;
            this.courseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.courseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.courseBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.courseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courseBindingNavigator.Name = "courseBindingNavigator";
            this.courseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courseBindingNavigator.Size = new System.Drawing.Size(919, 27);
            this.courseBindingNavigator.TabIndex = 0;
            this.courseBindingNavigator.Text = "bindingNavigator1";
            this.courseBindingNavigator.RefreshItems += new System.EventHandler(this.courseBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // couNoTextBox
            // 
            this.couNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CouNo", true));
            this.couNoTextBox.Location = new System.Drawing.Point(113, 34);
            this.couNoTextBox.Name = "couNoTextBox";
            this.couNoTextBox.ReadOnly = true;
            this.couNoTextBox.Size = new System.Drawing.Size(214, 25);
            this.couNoTextBox.TabIndex = 2;
            // 
            // couNameTextBox
            // 
            this.couNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CouName", true));
            this.couNameTextBox.Location = new System.Drawing.Point(113, 65);
            this.couNameTextBox.Name = "couNameTextBox";
            this.couNameTextBox.ReadOnly = true;
            this.couNameTextBox.Size = new System.Drawing.Size(214, 25);
            this.couNameTextBox.TabIndex = 4;
            // 
            // creditTextBox
            // 
            this.creditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Credit", true));
            this.creditTextBox.Location = new System.Drawing.Point(113, 96);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.ReadOnly = true;
            this.creditTextBox.Size = new System.Drawing.Size(214, 25);
            this.creditTextBox.TabIndex = 6;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.couNoTextBox);
            this.gbEdit.Controls.Add(couNoLabel);
            this.gbEdit.Controls.Add(this.creditTextBox);
            this.gbEdit.Controls.Add(creditLabel);
            this.gbEdit.Controls.Add(couNameLabel);
            this.gbEdit.Controls.Add(this.couNameTextBox);
            this.gbEdit.Location = new System.Drawing.Point(42, 130);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(369, 142);
            this.gbEdit.TabIndex = 7;
            this.gbEdit.TabStop = false;
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(479, 130);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            this.courseDataGridView.RowTemplate.Height = 27;
            this.courseDataGridView.Size = new System.Drawing.Size(417, 413);
            this.courseDataGridView.TabIndex = 8;
            this.courseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CouNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "CouNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CouName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CouName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Credit";
            this.dataGridViewTextBoxColumn3.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // 数据总览
            // 
            this.数据总览.AutoSize = true;
            this.数据总览.Location = new System.Drawing.Point(497, 100);
            this.数据总览.Name = "数据总览";
            this.数据总览.Size = new System.Drawing.Size(113, 15);
            this.数据总览.TabIndex = 9;
            this.数据总览.Text = "数据总览(只读)";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ActiveControl = null;
            this.toolStripButton1.Location = new System.Drawing.Point(102, 362);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 108);
            this.toolStripButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton1.StyleManager = this.metroStyleManager1;
            this.toolStripButton1.TabIndex = 10;
            this.toolStripButton1.Text = "新增";
            this.toolStripButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton1.TileCount = 0;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ActiveControl = null;
            this.toolStripButton2.Location = new System.Drawing.Point(102, 476);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(249, 52);
            this.toolStripButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton2.StyleManager = this.metroStyleManager1;
            this.toolStripButton2.TabIndex = 11;
            this.toolStripButton2.Text = "修改";
            this.toolStripButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton2.TileCount = 0;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ActiveControl = null;
            this.toolStripButton3.Location = new System.Drawing.Point(183, 362);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(98, 108);
            this.toolStripButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton3.StyleManager = this.metroStyleManager1;
            this.toolStripButton3.TabIndex = 12;
            this.toolStripButton3.Text = "删除";
            this.toolStripButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton3.TileCount = 0;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ActiveControl = null;
            this.toolStripButton4.Enabled = false;
            this.toolStripButton4.Location = new System.Drawing.Point(101, 317);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(180, 39);
            this.toolStripButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton4.StyleManager = this.metroStyleManager1;
            this.toolStripButton4.TabIndex = 13;
            this.toolStripButton4.Text = "保存";
            this.toolStripButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton4.TileCount = 0;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ActiveControl = null;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Location = new System.Drawing.Point(288, 317);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(63, 153);
            this.toolStripButton5.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton5.StyleManager = this.metroStyleManager1;
            this.toolStripButton5.TabIndex = 14;
            this.toolStripButton5.Text = "放弃";
            this.toolStripButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton5.TileCount = 0;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 605);
            this.Controls.Add(this.toolStripButton5);
            this.Controls.Add(this.toolStripButton4);
            this.Controls.Add(this.toolStripButton3);
            this.Controls.Add(this.toolStripButton2);
            this.Controls.Add(this.toolStripButton1);
            this.Controls.Add(this.数据总览);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.courseBindingNavigator);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCourse";
            this.Opacity = 0.8D;
            this.StyleManager = this.metroStyleManager1;
            this.Text = "femCourse";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).EndInit();
            this.courseBindingNavigator.ResumeLayout(false);
            this.courseBindingNavigator.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Student_Manage_DB student_Manage_DB;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Student_Manage_DBTableAdapters.CourseTableAdapter courseTableAdapter;
        private Student_Manage_DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courseBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox couNoTextBox;
        private System.Windows.Forms.TextBox couNameTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.Label 数据总览;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MetroFramework.Controls.MetroTile toolStripButton1;
        private MetroFramework.Controls.MetroTile toolStripButton2;
        private MetroFramework.Controls.MetroTile toolStripButton3;
        private MetroFramework.Controls.MetroTile toolStripButton4;
        private MetroFramework.Controls.MetroTile toolStripButton5;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}