
namespace BTL
{
    partial class frmQL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogoutQL = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.txtNhap_QL = new System.Windows.Forms.TextBox();
            this.comTCHP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grdQL = new System.Windows.Forms.DataGridView();
            this.maLopHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLopHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet1 = new BTL.DKTCDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.tblLopHPTableAdapter = new BTL.DKTCDataSet1TableAdapters.tblLopHPTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 116);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogoutQL);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(543, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 116);
            this.panel2.TabIndex = 1;
            // 
            // btnLogoutQL
            // 
            this.btnLogoutQL.AutoSize = true;
            this.btnLogoutQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnLogoutQL.FlatAppearance.BorderSize = 0;
            this.btnLogoutQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogoutQL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogoutQL.Location = new System.Drawing.Point(436, 76);
            this.btnLogoutQL.Name = "btnLogoutQL";
            this.btnLogoutQL.Size = new System.Drawing.Size(181, 40);
            this.btnLogoutQL.TabIndex = 0;
            this.btnLogoutQL.Text = "Đăng xuất";
            this.btnLogoutQL.UseVisualStyleBackColor = false;
            this.btnLogoutQL.Click += new System.EventHandler(this.btnLogoutQL_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(22, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(365, 39);
            this.button7.TabIndex = 1;
            this.button7.Text = "11208055 | Lê Vũ Quỳnh Trang";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrangChu.Location = new System.Drawing.Point(22, 71);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(201, 40);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // btnTk
            // 
            this.btnTk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnTk.FlatAppearance.BorderSize = 0;
            this.btnTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTk.ForeColor = System.Drawing.Color.White;
            this.btnTk.Location = new System.Drawing.Point(650, 199);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(115, 44);
            this.btnTk.TabIndex = 25;
            this.btnTk.Text = "Tìm kiếm";
            this.btnTk.UseVisualStyleBackColor = false;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // txtNhap_QL
            // 
            this.txtNhap_QL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap_QL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtNhap_QL.Location = new System.Drawing.Point(442, 210);
            this.txtNhap_QL.Multiline = true;
            this.txtNhap_QL.Name = "txtNhap_QL";
            this.txtNhap_QL.Size = new System.Drawing.Size(192, 29);
            this.txtNhap_QL.TabIndex = 24;
            this.txtNhap_QL.Text = "Nhập từ khóa";
            this.txtNhap_QL.Click += new System.EventHandler(this.txtNhap_QL_Click);
            this.txtNhap_QL.Leave += new System.EventHandler(this.txtNhap_QL_Leave);
            // 
            // comTCHP
            // 
            this.comTCHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTCHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.comTCHP.FormattingEnabled = true;
            this.comTCHP.Items.AddRange(new object[] {
            "Tên HP",
            "Mã HP",
            "Tên Giảng Viên"});
            this.comTCHP.Location = new System.Drawing.Point(198, 208);
            this.comTCHP.Name = "comTCHP";
            this.comTCHP.Size = new System.Drawing.Size(238, 30);
            this.comTCHP.TabIndex = 23;
            this.comTCHP.SelectedIndexChanged += new System.EventHandler(this.comTCHP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(88, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tìm theo: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(0, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1201, 42);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "          Quản lý học phần";
            // 
            // grdQL
            // 
            this.grdQL.AutoGenerateColumns = false;
            this.grdQL.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopHPDataGridViewTextBoxColumn,
            this.maMonDataGridViewTextBoxColumn,
            this.tenLopHPDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.giangVienDataGridViewTextBoxColumn,
            this.phongHocDataGridViewTextBoxColumn,
            this.tietHocDataGridViewTextBoxColumn});
            this.grdQL.DataSource = this.tblLopHPBindingSource;
            this.grdQL.Location = new System.Drawing.Point(71, 270);
            this.grdQL.Name = "grdQL";
            this.grdQL.RowHeadersWidth = 51;
            this.grdQL.RowTemplate.Height = 24;
            this.grdQL.Size = new System.Drawing.Size(1035, 479);
            this.grdQL.TabIndex = 26;
            // 
            // maLopHPDataGridViewTextBoxColumn
            // 
            this.maLopHPDataGridViewTextBoxColumn.DataPropertyName = "MaLopHP";
            this.maLopHPDataGridViewTextBoxColumn.Frozen = true;
            this.maLopHPDataGridViewTextBoxColumn.HeaderText = "MaLopHP";
            this.maLopHPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopHPDataGridViewTextBoxColumn.Name = "maLopHPDataGridViewTextBoxColumn";
            this.maLopHPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maLopHPDataGridViewTextBoxColumn.Width = 125;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maMonDataGridViewTextBoxColumn.Width = 90;
            // 
            // tenLopHPDataGridViewTextBoxColumn
            // 
            this.tenLopHPDataGridViewTextBoxColumn.DataPropertyName = "TenLopHP";
            this.tenLopHPDataGridViewTextBoxColumn.HeaderText = "TenLopHP";
            this.tenLopHPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLopHPDataGridViewTextBoxColumn.Name = "tenLopHPDataGridViewTextBoxColumn";
            this.tenLopHPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenLopHPDataGridViewTextBoxColumn.Width = 125;
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            this.siSoDataGridViewTextBoxColumn.HeaderText = "SiSo";
            this.siSoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            this.siSoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.siSoDataGridViewTextBoxColumn.Width = 60;
            // 
            // giangVienDataGridViewTextBoxColumn
            // 
            this.giangVienDataGridViewTextBoxColumn.DataPropertyName = "GiangVien";
            this.giangVienDataGridViewTextBoxColumn.HeaderText = "GiangVien";
            this.giangVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giangVienDataGridViewTextBoxColumn.Name = "giangVienDataGridViewTextBoxColumn";
            this.giangVienDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.giangVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongHocDataGridViewTextBoxColumn
            // 
            this.phongHocDataGridViewTextBoxColumn.DataPropertyName = "PhongHoc";
            this.phongHocDataGridViewTextBoxColumn.HeaderText = "PhongHoc";
            this.phongHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongHocDataGridViewTextBoxColumn.Name = "phongHocDataGridViewTextBoxColumn";
            this.phongHocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phongHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // tietHocDataGridViewTextBoxColumn
            // 
            this.tietHocDataGridViewTextBoxColumn.DataPropertyName = "TietHoc";
            this.tietHocDataGridViewTextBoxColumn.HeaderText = "TietHoc";
            this.tietHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tietHocDataGridViewTextBoxColumn.Name = "tietHocDataGridViewTextBoxColumn";
            this.tietHocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tietHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblLopHPBindingSource
            // 
            this.tblLopHPBindingSource.DataMember = "tblLopHP";
            this.tblLopHPBindingSource.DataSource = this.dKTCDataSet1;
            // 
            // dKTCDataSet1
            // 
            this.dKTCDataSet1.DataSetName = "DKTCDataSet1";
            this.dKTCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(71, 775);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "Xuất thông tin";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnThemmoi.FlatAppearance.BorderSize = 0;
            this.btnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.ForeColor = System.Drawing.Color.White;
            this.btnThemmoi.Location = new System.Drawing.Point(889, 775);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(217, 50);
            this.btnThemmoi.TabIndex = 27;
            this.btnThemmoi.Text = "Thêm học phần";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click_1);
            // 
            // tblLopHPTableAdapter
            // 
            this.tblLopHPTableAdapter.ClearBeforeFill = true;
            // 
            // frmQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1201, 853);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdQL);
            this.Controls.Add(this.btnTk);
            this.Controls.Add(this.txtNhap_QL);
            this.Controls.Add(this.comTCHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmQL";
            this.Text = "frmQL";
            this.Load += new System.EventHandler(this.frmQL_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogoutQL;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.TextBox txtNhap_QL;
        private System.Windows.Forms.ComboBox comTCHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemmoi;
        private DKTCDataSet1 dKTCDataSet1;
        private System.Windows.Forms.BindingSource tblLopHPBindingSource;
        private DKTCDataSet1TableAdapters.tblLopHPTableAdapter tblLopHPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietHocDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView grdQL;
    }
}