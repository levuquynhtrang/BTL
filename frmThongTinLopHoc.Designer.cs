
namespace BTL
{
    partial class frmThongTinLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaLHP = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.txtTietHoc = new System.Windows.Forms.TextBox();
            this.grdDSSV = new System.Windows.Forms.DataGridView();
            this.tblSVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet5 = new BTL.DKTCDataSet5();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThongTinSV = new System.Windows.Forms.Button();
            this.dKTCDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLSDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLSDKTableAdapter = new BTL.DKTCDataSet5TableAdapters.tblLSDKTableAdapter();
            this.tblSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSVTableAdapter = new BTL.DKTCDataSet5TableAdapters.tblSVTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLSDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSVBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 82);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(11, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Thông tin lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lớp HP: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên lớp HP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sĩ số:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(9, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giảng viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phòng học:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(9, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tiết học: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtMaLHP.Location = new System.Drawing.Point(91, 53);
            this.txtMaLHP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaLHP.Multiline = true;
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.Size = new System.Drawing.Size(113, 24);
            this.txtMaLHP.TabIndex = 2;
            this.txtMaLHP.TextChanged += new System.EventHandler(this.txtMaLHP_TextChanged);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtMaMon.Location = new System.Drawing.Point(91, 84);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaMon.Multiline = true;
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(99, 24);
            this.txtMaMon.TabIndex = 2;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtTenHP.Location = new System.Drawing.Point(91, 114);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenHP.Multiline = true;
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(200, 24);
            this.txtTenHP.TabIndex = 2;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSiSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtSiSo.Location = new System.Drawing.Point(91, 146);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSiSo.Multiline = true;
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(93, 24);
            this.txtSiSo.TabIndex = 2;
            // 
            // txtGiangVien
            // 
            this.txtGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtGiangVien.Location = new System.Drawing.Point(91, 181);
            this.txtGiangVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGiangVien.Multiline = true;
            this.txtGiangVien.Name = "txtGiangVien";
            this.txtGiangVien.Size = new System.Drawing.Size(136, 24);
            this.txtGiangVien.TabIndex = 2;
            // 
            // txtPhongHoc
            // 
            this.txtPhongHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhongHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtPhongHoc.Location = new System.Drawing.Point(91, 209);
            this.txtPhongHoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhongHoc.Multiline = true;
            this.txtPhongHoc.Name = "txtPhongHoc";
            this.txtPhongHoc.Size = new System.Drawing.Size(113, 24);
            this.txtPhongHoc.TabIndex = 2;
            // 
            // txtTietHoc
            // 
            this.txtTietHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTietHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.txtTietHoc.Location = new System.Drawing.Point(91, 241);
            this.txtTietHoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTietHoc.Multiline = true;
            this.txtTietHoc.Name = "txtTietHoc";
            this.txtTietHoc.Size = new System.Drawing.Size(99, 24);
            this.txtTietHoc.TabIndex = 2;
            // 
            // grdDSSV
            // 
            this.grdDSSV.AutoGenerateColumns = false;
            this.grdDSSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDSSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.tenSVDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.maNhomMonHocDataGridViewTextBoxColumn});
            this.grdDSSV.DataSource = this.tblSVBindingSource1;
            this.grdDSSV.Location = new System.Drawing.Point(417, 194);
            this.grdDSSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdDSSV.Name = "grdDSSV";
            this.grdDSSV.RowHeadersWidth = 51;
            this.grdDSSV.RowTemplate.Height = 24;
            this.grdDSSV.Size = new System.Drawing.Size(471, 244);
            this.grdDSSV.TabIndex = 3;
            // 
            // tblSVBindingSource1
            // 
            this.tblSVBindingSource1.DataMember = "tblSV";
            this.tblSVBindingSource1.DataSource = this.dKTCDataSet5;
            // 
            // dKTCDataSet5
            // 
            this.dKTCDataSet5.DataSetName = "DKTCDataSet5";
            this.dKTCDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(413, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Danh sách sinh viên";
            // 
            // btnThongTinSV
            // 
            this.btnThongTinSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongTinSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.btnThongTinSV.Location = new System.Drawing.Point(655, 492);
            this.btnThongTinSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThongTinSV.Name = "btnThongTinSV";
            this.btnThongTinSV.Size = new System.Drawing.Size(233, 32);
            this.btnThongTinSV.TabIndex = 5;
            this.btnThongTinSV.Text = "Xuất thông tin";
            this.btnThongTinSV.UseVisualStyleBackColor = true;
            this.btnThongTinSV.Click += new System.EventHandler(this.btnThongTinSV_Click);
            // 
            // dKTCDataSet5BindingSource
            // 
            this.dKTCDataSet5BindingSource.DataSource = this.dKTCDataSet5;
            this.dKTCDataSet5BindingSource.Position = 0;
            // 
            // tblLSDKBindingSource
            // 
            this.tblLSDKBindingSource.DataMember = "tblLSDK";
            this.tblLSDKBindingSource.DataSource = this.dKTCDataSet5BindingSource;
            // 
            // tblLSDKTableAdapter
            // 
            this.tblLSDKTableAdapter.ClearBeforeFill = true;
            // 
            // tblSVBindingSource
            // 
            this.tblSVBindingSource.DataMember = "tblSV";
            this.tblSVBindingSource.DataSource = this.dKTCDataSet5BindingSource;
            // 
            // tblSVTableAdapter
            // 
            this.tblSVTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTietHoc);
            this.groupBox1.Controls.Add(this.txtPhongHoc);
            this.groupBox1.Controls.Add(this.txtGiangVien);
            this.groupBox1.Controls.Add(this.txtSiSo);
            this.groupBox1.Controls.Add(this.txtTenHP);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.txtMaLHP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.groupBox1.Location = new System.Drawing.Point(55, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(307, 313);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenSVDataGridViewTextBoxColumn
            // 
            this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.tenSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
            this.tenSVDataGridViewTextBoxColumn.Width = 190;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.Visible = false;
            this.matKhauDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNhomMonHocDataGridViewTextBoxColumn
            // 
            this.maNhomMonHocDataGridViewTextBoxColumn.DataPropertyName = "MaNhomMonHoc";
            this.maNhomMonHocDataGridViewTextBoxColumn.HeaderText = "Mã chuyên ngành";
            this.maNhomMonHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomMonHocDataGridViewTextBoxColumn.Name = "maNhomMonHocDataGridViewTextBoxColumn";
            this.maNhomMonHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmThongTinLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(963, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThongTinSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grdDSSV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmThongTinLopHoc";
            this.Text = "frmThongTinLopHoc";
            this.Load += new System.EventHandler(this.frmThongTinLopHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLSDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSVBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThongTinSV;
        private System.Windows.Forms.BindingSource dKTCDataSet5BindingSource;
        private DKTCDataSet5 dKTCDataSet5;
        private System.Windows.Forms.BindingSource tblLSDKBindingSource;
        private DKTCDataSet5TableAdapters.tblLSDKTableAdapter tblLSDKTableAdapter;
        private System.Windows.Forms.BindingSource tblSVBindingSource;
        private DKTCDataSet5TableAdapters.tblSVTableAdapter tblSVTableAdapter;
        private System.Windows.Forms.BindingSource tblSVBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtMaLHP;
        public System.Windows.Forms.TextBox txtMaMon;
        public System.Windows.Forms.TextBox txtTenHP;
        public System.Windows.Forms.TextBox txtSiSo;
        public System.Windows.Forms.TextBox txtGiangVien;
        public System.Windows.Forms.TextBox txtPhongHoc;
        public System.Windows.Forms.TextBox txtTietHoc;
        public System.Windows.Forms.DataGridView grdDSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomMonHocDataGridViewTextBoxColumn;
    }
}