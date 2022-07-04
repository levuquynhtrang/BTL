
namespace BTL
{
    partial class TCHP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogoutTCHP = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comTCHP = new System.Windows.Forms.ComboBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTk = new System.Windows.Forms.Button();
            this.grdTCHP = new System.Windows.Forms.DataGridView();
            this.tblLopHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet5 = new BTL.DKTCDataSet5();
            this.tblLopHPTableAdapter = new BTL.DKTCDataSet5TableAdapters.tblLopHPTableAdapter();
            this.maLopHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSHienTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTCHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.btnLogoutTCHP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 109);
            this.panel1.TabIndex = 0;
            // 
            // btnLogoutTCHP
            // 
            this.btnLogoutTCHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnLogoutTCHP.FlatAppearance.BorderSize = 0;
            this.btnLogoutTCHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutTCHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogoutTCHP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogoutTCHP.Location = new System.Drawing.Point(1256, 58);
            this.btnLogoutTCHP.Name = "btnLogoutTCHP";
            this.btnLogoutTCHP.Size = new System.Drawing.Size(190, 58);
            this.btnLogoutTCHP.TabIndex = 0;
            this.btnLogoutTCHP.Text = "Đăng xuất";
            this.btnLogoutTCHP.UseVisualStyleBackColor = false;
            this.btnLogoutTCHP.Click += new System.EventHandler(this.btnLogoutTCHP_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(57, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1090, 56);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Tra cứu học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(68, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm theo:";
            // 
            // comTCHP
            // 
            this.comTCHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comTCHP.FormattingEnabled = true;
            this.comTCHP.ItemHeight = 25;
            this.comTCHP.Items.AddRange(new object[] {
            "Mã HP",
            "Tên HP",
            "Mã môn"});
            this.comTCHP.Location = new System.Drawing.Point(189, 246);
            this.comTCHP.Name = "comTCHP";
            this.comTCHP.Size = new System.Drawing.Size(116, 33);
            this.comTCHP.TabIndex = 4;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(356, 246);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(220, 35);
            this.txtNhap.TabIndex = 5;
            this.txtNhap.Click += new System.EventHandler(this.txtNhap_Click);
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            this.txtNhap.Leave += new System.EventHandler(this.txtNhap_Leave);
            // 
            // btnTk
            // 
            this.btnTk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnTk.FlatAppearance.BorderSize = 0;
            this.btnTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTk.Location = new System.Drawing.Point(628, 240);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(135, 49);
            this.btnTk.TabIndex = 6;
            this.btnTk.Text = "Tìm kiếm";
            this.btnTk.UseVisualStyleBackColor = false;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click_1);
            // 
            // grdTCHP
            // 
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTCHP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.grdTCHP.AutoGenerateColumns = false;
            this.grdTCHP.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTCHP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.grdTCHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTCHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopHPDataGridViewTextBoxColumn,
            this.maMonDataGridViewTextBoxColumn,
            this.tenLopHPDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.giangVienDataGridViewTextBoxColumn,
            this.phongHocDataGridViewTextBoxColumn,
            this.tietHocDataGridViewTextBoxColumn,
            this.sSHienTaiDataGridViewTextBoxColumn});
            this.grdTCHP.DataSource = this.tblLopHPBindingSource;
            this.grdTCHP.Location = new System.Drawing.Point(57, 306);
            this.grdTCHP.Name = "grdTCHP";
            this.grdTCHP.RowHeadersWidth = 51;
            this.grdTCHP.RowTemplate.Height = 24;
            this.grdTCHP.Size = new System.Drawing.Size(1090, 375);
            this.grdTCHP.TabIndex = 7;
            // 
            // tblLopHPBindingSource
            // 
            this.tblLopHPBindingSource.DataMember = "tblLopHP";
            this.tblLopHPBindingSource.DataSource = this.dKTCDataSet5BindingSource;
            // 
            // dKTCDataSet5BindingSource
            // 
            this.dKTCDataSet5BindingSource.DataSource = this.dKTCDataSet5;
            this.dKTCDataSet5BindingSource.Position = 0;
            // 
            // dKTCDataSet5
            // 
            this.dKTCDataSet5.DataSetName = "DKTCDataSet5";
            this.dKTCDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLopHPTableAdapter
            // 
            this.tblLopHPTableAdapter.ClearBeforeFill = true;
            // 
            // maLopHPDataGridViewTextBoxColumn
            // 
            this.maLopHPDataGridViewTextBoxColumn.DataPropertyName = "MaLopHP";
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maLopHPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle33;
            this.maLopHPDataGridViewTextBoxColumn.HeaderText = "Mã LHP";
            this.maLopHPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopHPDataGridViewTextBoxColumn.Name = "maLopHPDataGridViewTextBoxColumn";
            this.maLopHPDataGridViewTextBoxColumn.Width = 150;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maMonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle34;
            this.maMonDataGridViewTextBoxColumn.HeaderText = "Mã môn";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Width = 90;
            // 
            // tenLopHPDataGridViewTextBoxColumn
            // 
            this.tenLopHPDataGridViewTextBoxColumn.DataPropertyName = "TenLopHP";
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenLopHPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle35;
            this.tenLopHPDataGridViewTextBoxColumn.HeaderText = "Tên LHP";
            this.tenLopHPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLopHPDataGridViewTextBoxColumn.Name = "tenLopHPDataGridViewTextBoxColumn";
            this.tenLopHPDataGridViewTextBoxColumn.Width = 240;
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.siSoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle36;
            this.siSoDataGridViewTextBoxColumn.HeaderText = "Sĩ số";
            this.siSoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            this.siSoDataGridViewTextBoxColumn.Width = 40;
            // 
            // giangVienDataGridViewTextBoxColumn
            // 
            this.giangVienDataGridViewTextBoxColumn.DataPropertyName = "GiangVien";
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giangVienDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.giangVienDataGridViewTextBoxColumn.HeaderText = "Giảng viên";
            this.giangVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giangVienDataGridViewTextBoxColumn.Name = "giangVienDataGridViewTextBoxColumn";
            this.giangVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongHocDataGridViewTextBoxColumn
            // 
            this.phongHocDataGridViewTextBoxColumn.DataPropertyName = "PhongHoc";
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phongHocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle38;
            this.phongHocDataGridViewTextBoxColumn.HeaderText = "Phòng học";
            this.phongHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongHocDataGridViewTextBoxColumn.Name = "phongHocDataGridViewTextBoxColumn";
            this.phongHocDataGridViewTextBoxColumn.Width = 50;
            // 
            // tietHocDataGridViewTextBoxColumn
            // 
            this.tietHocDataGridViewTextBoxColumn.DataPropertyName = "TietHoc";
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tietHocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle39;
            this.tietHocDataGridViewTextBoxColumn.HeaderText = "Tiết học";
            this.tietHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tietHocDataGridViewTextBoxColumn.Name = "tietHocDataGridViewTextBoxColumn";
            this.tietHocDataGridViewTextBoxColumn.Width = 150;
            // 
            // sSHienTaiDataGridViewTextBoxColumn
            // 
            this.sSHienTaiDataGridViewTextBoxColumn.DataPropertyName = "SSHienTai";
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sSHienTaiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle40;
            this.sSHienTaiDataGridViewTextBoxColumn.HeaderText = "Sĩ số hiện tại";
            this.sSHienTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSHienTaiDataGridViewTextBoxColumn.Name = "sSHienTaiDataGridViewTextBoxColumn";
            this.sSHienTaiDataGridViewTextBoxColumn.Width = 70;
            // 
            // TCHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1174, 702);
            this.Controls.Add(this.grdTCHP);
            this.Controls.Add(this.btnTk);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.comTCHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Name = "TCHP";
            this.Text = "TCHP";
            this.Load += new System.EventHandler(this.TCHP_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTCHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogoutTCHP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comTCHP;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.DataGridView grdTCHP;
        private System.Windows.Forms.BindingSource dKTCDataSet5BindingSource;
        private DKTCDataSet5 dKTCDataSet5;
        private System.Windows.Forms.BindingSource tblLopHPBindingSource;
        private DKTCDataSet5TableAdapters.tblLopHPTableAdapter tblLopHPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSHienTaiDataGridViewTextBoxColumn;
    }
}