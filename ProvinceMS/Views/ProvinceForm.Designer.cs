namespace ProvinceMS.Views
{
    partial class ProvinceForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvinceForm));
            txtProvinceName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNew = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            dgvProvinces = new DataGridView();
            districtsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            provincesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            townsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            provincesContextBindingSource = new BindingSource(components);
            provinceBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBoxTown = new TextBox();
            label3 = new Label();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProvinces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)provincesContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)provinceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtProvinceName
            // 
            txtProvinceName.Location = new Point(22, 165);
            txtProvinceName.Name = "txtProvinceName";
            txtProvinceName.Size = new Size(739, 31);
            txtProvinceName.TabIndex = 0;
            txtProvinceName.TextChanged += txtProvinceName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 36);
            label1.Name = "label1";
            label1.Size = new Size(164, 45);
            label1.TabIndex = 1;
            label1.Text = "Provinces";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Provinces";
            // 
            // txtNew
            // 
            txtNew.ForeColor = Color.DeepSkyBlue;
            txtNew.Location = new Point(22, 225);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(112, 34);
            txtNew.TabIndex = 3;
            txtNew.Text = "New";
            txtNew.UseVisualStyleBackColor = true;
            txtNew.Click += txtNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(613, 670);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += Cancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(376, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += Delete_Click;
            // 
            // dgvProvinces
            // 
            dgvProvinces.AllowUserToOrderColumns = true;
            dgvProvinces.AutoGenerateColumns = false;
            dgvProvinces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvinces.Columns.AddRange(new DataGridViewColumn[] { districtsDataGridViewTextBoxColumn, provincesDataGridViewTextBoxColumn, townsDataGridViewTextBoxColumn });
            dgvProvinces.DataSource = provincesContextBindingSource;
            dgvProvinces.Location = new Point(22, 482);
            dgvProvinces.Name = "dgvProvinces";
            dgvProvinces.RowHeadersWidth = 62;
            dgvProvinces.RowTemplate.Height = 33;
            dgvProvinces.Size = new Size(732, 182);
            dgvProvinces.TabIndex = 7;
            dgvProvinces.CellContentClick += dgvProvinces_CellContentClick;
            // 
            // districtsDataGridViewTextBoxColumn
            // 
            districtsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            districtsDataGridViewTextBoxColumn.DataPropertyName = "Districts";
            districtsDataGridViewTextBoxColumn.HeaderText = "Districts";
            districtsDataGridViewTextBoxColumn.MinimumWidth = 8;
            districtsDataGridViewTextBoxColumn.Name = "districtsDataGridViewTextBoxColumn";
            // 
            // provincesDataGridViewTextBoxColumn
            // 
            provincesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            provincesDataGridViewTextBoxColumn.DataPropertyName = "Provinces";
            provincesDataGridViewTextBoxColumn.HeaderText = "Provinces";
            provincesDataGridViewTextBoxColumn.MinimumWidth = 8;
            provincesDataGridViewTextBoxColumn.Name = "provincesDataGridViewTextBoxColumn";
            // 
            // townsDataGridViewTextBoxColumn
            // 
            townsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            townsDataGridViewTextBoxColumn.DataPropertyName = "Towns";
            townsDataGridViewTextBoxColumn.HeaderText = "Towns";
            townsDataGridViewTextBoxColumn.MinimumWidth = 8;
            townsDataGridViewTextBoxColumn.Name = "townsDataGridViewTextBoxColumn";
            // 
            // provincesContextBindingSource
            // 
            provincesContextBindingSource.DataSource = typeof(Models.ProvincesContext);
            // 
            // provinceBindingSource
            // 
            provinceBindingSource.DataSource = typeof(Models.Province);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(258, 225);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Close_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 307);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(735, 33);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Province";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(26, 362);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(735, 33);
            comboBox2.TabIndex = 11;
            comboBox2.Text = "District";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBoxTown
            // 
            textBoxTown.Location = new Point(138, 415);
            textBoxTown.Name = "textBoxTown";
            textBoxTown.Size = new Size(270, 31);
            textBoxTown.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 418);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 13;
            label3.Text = "Enter town :";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(424, 413);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(64, 34);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // ProvinceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 721);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(textBoxTown);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvProvinces);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNew);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProvinceName);
            Name = "ProvinceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProvinceForm";
            Load += ProvinceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProvinces).EndInit();
            ((System.ComponentModel.ISupportInitialize)provincesContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)provinceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProvinceName;
        private Label label1;
        private Label label2;
        private Button txtNew;
        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
        private DataGridView dgvProvinces;
        private DataGridViewTextBoxColumn ProvinceId;
        private DataGridViewTextBoxColumn ProvinceName;
        private BindingSource provinceBindingSource;
        private PictureBox pictureBox1;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBoxTown;
        private Label label3;
        private Button buttonAdd;
        private BindingSource provincesContextBindingSource;
        private DataGridViewTextBoxColumn districtsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn provincesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn townsDataGridViewTextBoxColumn;
    }
}