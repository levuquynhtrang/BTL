
namespace BTL
{
    partial class FrmLSDK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogoutLSDK = new System.Windows.Forms.Button();
            this.btnTrangChuLSDK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grdLSDK = new System.Windows.Forms.DataGridView();
            this.tblLSDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet5BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet5 = new BTL.DKTCDataSet5();
            this.comNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comHocKy = new System.Windows.Forms.ComboBox();
            this.dKTCDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLSDKTableAdapter = new BTL.DKTCDataSet5TableAdapters.tblLSDKTableAdapter();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLSDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTrangChuLSDK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 51);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogoutLSDK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(498, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnLogoutLSDK
            // 
            this.btnLogoutLSDK.AutoSize = true;
            this.btnLogoutLSDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnLogoutLSDK.FlatAppearance.BorderSize = 0;
            this.btnLogoutLSDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutLSDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogoutLSDK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogoutLSDK.Location = new System.Drawing.Point(321, 18);
            this.btnLogoutLSDK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogoutLSDK.Name = "btnLogoutLSDK";
            this.btnLogoutLSDK.Size = new System.Drawing.Size(136, 32);
            this.btnLogoutLSDK.TabIndex = 0;
            this.btnLogoutLSDK.Text = "Đăng xuất";
            this.btnLogoutLSDK.UseVisualStyleBackColor = false;
            this.btnLogoutLSDK.Click += new System.EventHandler(this.btnLogoutLSDK_Click);
            // 
            // btnTrangChuLSDK
            // 
            this.btnTrangChuLSDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))), ((int)(((byte)(99)))));
            this.btnTrangChuLSDK.FlatAppearance.BorderSize = 0;
            this.btnTrangChuLSDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChuLSDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChuLSDK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrangChuLSDK.Location = new System.Drawing.Point(23, 19);
            this.btnTrangChuLSDK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTrangChuLSDK.Name = "btnTrangChuLSDK";
            this.btnTrangChuLSDK.Size = new System.Drawing.Size(151, 32);
            this.btnTrangChuLSDK.TabIndex = 0;
            this.btnTrangChuLSDK.Text = "Trang chủ";
            this.btnTrangChuLSDK.UseVisualStyleBackColor = false;
            this.btnTrangChuLSDK.Click += new System.EventHandler(this.btnTrangChuLSDK_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(53, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(855, 36);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Lịch sử đăng ký học phần";
            // 
            // grdLSDK
            // 
            this.grdLSDK.AutoGenerateColumns = false;
            this.grdLSDK.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLSDK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdLSDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLSDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.maMonDataGridViewTextBoxColumn,
            this.maLopHPDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.soTCDataGridViewTextBoxColumn,
            this.hocKiDataGridViewTextBoxColumn,
            this.namHocDataGridViewTextBoxColumn,
            this.tietHocDataGridViewTextBoxColumn,
            this.phongHocDataGridViewTextBoxColumn,
            this.giangVienDataGridViewTextBoxColumn});
            this.grdLSDK.DataSource = this.tblLSDKBindingSource;
            this.grdLSDK.Location = new System.Drawing.Point(53, 161);
            this.grdLSDK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grdLSDK.Name = "grdLSDK";
            this.grdLSDK.RowHeadersWidth = 62;
            this.grdLSDK.RowTemplate.Height = 28;
            this.grdLSDK.Size = new System.Drawing.Size(855, 320);
            this.grdLSDK.TabIndex = 15;
            // 
            // tblLSDKBindingSource
            // 
            this.tblLSDKBindingSource.DataMember = "tblLSDK";
            this.tblLSDKBindingSource.DataSource = this.dKTCDataSet5BindingSource1;
            // 
            // dKTCDataSet5BindingSource1
            // 
            this.dKTCDataSet5BindingSource1.DataSource = this.dKTCDataSet5;
            this.dKTCDataSet5BindingSource1.Position = 0;
            // 
            // dKTCDataSet5
            // 
            this.dKTCDataSet5.DataSetName = "DKTCDataSet5";
            this.dKTCDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comNamHoc
            // 
            this.comNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.comNamHoc.FormattingEnabled = true;
            this.comNamHoc.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.comNamHoc.Location = new System.Drawing.Point(141, 114);
            this.comNamHoc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comNamHoc.Name = "comNamHoc";
            this.comNamHoc.Size = new System.Drawing.Size(136, 26);
            this.comNamHoc.TabIndex = 16;
            this.comNamHoc.Text = "  Chọn --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(54, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Năm học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(286, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Học kỳ:";
            // 
            // comHocKy
            // 
            this.comHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.comHocKy.FormattingEnabled = true;
            this.comHocKy.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2",
            "Học kỳ 3"});
            this.comHocKy.Location = new System.Drawing.Point(351, 114);
            this.comHocKy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comHocKy.Name = "comHocKy";
            this.comHocKy.Size = new System.Drawing.Size(125, 26);
            this.comHocKy.TabIndex = 19;
            this.comHocKy.Text = "  Chọn --";
            this.comHocKy.SelectedIndexChanged += new System.EventHandler(this.comHocKy_SelectedIndexChanged);
            // 
            // dKTCDataSet5BindingSource
            // 
            this.dKTCDataSet5BindingSource.DataSource = this.dKTCDataSet5;
            this.dKTCDataSet5BindingSource.Position = 0;
            // 
            // tblLSDKTableAdapter
            // 
            this.tblLSDKTableAdapter.ClearBeforeFill = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maSVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã SV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Visible = false;
            this.maSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maMonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.maMonDataGridViewTextBoxColumn.HeaderText = "Mã môn";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Visible = false;
            this.maMonDataGridViewTextBoxColumn.Width = 90;
            // 
            // maLopHPDataGridViewTextBoxColumn
            // 
            this.maLopHPDataGridViewTextBoxColumn.DataPropertyName = "MaLopHP";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maLopHPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.maLopHPDataGridViewTextBoxColumn.HeaderText = "Mã LHP";
            this.maLopHPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopHPDataGridViewTextBoxColumn.Name = "maLopHPDataGridViewTextBoxColumn";
            this.maLopHPDataGridViewTextBoxColumn.Width = 90;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenMonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "Tên môn";
            this.tenMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            this.tenMonDataGridViewTextBoxColumn.Width = 165;
            // 
            // soTCDataGridViewTextBoxColumn
            // 
            this.soTCDataGridViewTextBoxColumn.DataPropertyName = "SoTC";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soTCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.soTCDataGridViewTextBoxColumn.HeaderText = "Số TC";
            this.soTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTCDataGridViewTextBoxColumn.Name = "soTCDataGridViewTextBoxColumn";
            this.soTCDataGridViewTextBoxColumn.Width = 30;
            // 
            // hocKiDataGridViewTextBoxColumn
            // 
            this.hocKiDataGridViewTextBoxColumn.DataPropertyName = "HocKi";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hocKiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.hocKiDataGridViewTextBoxColumn.HeaderText = "Học kỳ";
            this.hocKiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hocKiDataGridViewTextBoxColumn.Name = "hocKiDataGridViewTextBoxColumn";
            this.hocKiDataGridViewTextBoxColumn.Width = 70;
            // 
            // namHocDataGridViewTextBoxColumn
            // 
            this.namHocDataGridViewTextBoxColumn.DataPropertyName = "NamHoc";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.namHocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.namHocDataGridViewTextBoxColumn.HeaderText = "Năm học";
            this.namHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namHocDataGridViewTextBoxColumn.Name = "namHocDataGridViewTextBoxColumn";
            // 
            // tietHocDataGridViewTextBoxColumn
            // 
            this.tietHocDataGridViewTextBoxColumn.DataPropertyName = "TietHoc";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tietHocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.tietHocDataGridViewTextBoxColumn.HeaderText = "Tiết học";
            this.tietHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tietHocDataGridViewTextBoxColumn.Name = "tietHocDataGridViewTextBoxColumn";
            this.tietHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongHocDataGridViewTextBoxColumn
            // 
            this.phongHocDataGridViewTextBoxColumn.DataPropertyName = "PhongHoc";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phongHocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.phongHocDataGridViewTextBoxColumn.HeaderText = "Phòng học";
            this.phongHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongHocDataGridViewTextBoxColumn.Name = "phongHocDataGridViewTextBoxColumn";
            this.phongHocDataGridViewTextBoxColumn.Width = 60;
            // 
            // giangVienDataGridViewTextBoxColumn
            // 
            this.giangVienDataGridViewTextBoxColumn.DataPropertyName = "GiangVien";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.giangVienDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.giangVienDataGridViewTextBoxColumn.HeaderText = "Giảng viên";
            this.giangVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giangVienDataGridViewTextBoxColumn.Name = "giangVienDataGridViewTextBoxColumn";
            this.giangVienDataGridViewTextBoxColumn.Width = 145;
            // 
            // FrmLSDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(963, 491);
            this.Controls.Add(this.comHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comNamHoc);
            this.Controls.Add(this.grdLSDK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FrmLSDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLSDK";
            this.Load += new System.EventHandler(this.FrmLSDK_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLSDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogoutLSDK;
        private System.Windows.Forms.Button btnTrangChuLSDK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grdLSDK;
        private System.Windows.Forms.ComboBox comNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comHocKy;
        private System.Windows.Forms.BindingSource dKTCDataSet5BindingSource1;
        private DKTCDataSet5 dKTCDataSet5;
        private System.Windows.Forms.BindingSource dKTCDataSet5BindingSource;
        private System.Windows.Forms.BindingSource tblLSDKBindingSource;
        private DKTCDataSet5TableAdapters.tblLSDKTableAdapter tblLSDKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVienDataGridViewTextBoxColumn;
    }
}