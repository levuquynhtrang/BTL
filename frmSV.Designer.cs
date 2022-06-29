
namespace BTL
{
    partial class frmSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHDDK = new System.Windows.Forms.Button();
            this.btnDKHP = new System.Windows.Forms.Button();
            this.btnLSDKHP = new System.Windows.Forms.Button();
            this.btnTCHP = new System.Windows.Forms.Button();
            this.btnHPTD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.grdMonHoc = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comNhomMon = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dKTCDataSet = new BTL.DKTCDataSet();
            this.dKTCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMonHocTableAdapter = new BTL.DKTCDataSetTableAdapters.tblMonHocTableAdapter();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhomMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKQDK = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHDDK
            // 
            this.btnHDDK.BackColor = System.Drawing.Color.White;
            this.btnHDDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHDDK.Location = new System.Drawing.Point(22, 29);
            this.btnHDDK.Name = "btnHDDK";
            this.btnHDDK.Size = new System.Drawing.Size(240, 60);
            this.btnHDDK.TabIndex = 1;
            this.btnHDDK.Text = "Hướng dẫn đăng ký ";
            this.btnHDDK.UseVisualStyleBackColor = false;
            // 
            // btnDKHP
            // 
            this.btnDKHP.BackColor = System.Drawing.Color.White;
            this.btnDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDKHP.Location = new System.Drawing.Point(22, 105);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.Size = new System.Drawing.Size(240, 60);
            this.btnDKHP.TabIndex = 1;
            this.btnDKHP.Text = "Đăng ký học phần ";
            this.btnDKHP.UseVisualStyleBackColor = false;
            this.btnDKHP.Click += new System.EventHandler(this.btnDKHP_Click);
            // 
            // btnLSDKHP
            // 
            this.btnLSDKHP.BackColor = System.Drawing.Color.White;
            this.btnLSDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLSDKHP.Location = new System.Drawing.Point(22, 181);
            this.btnLSDKHP.Name = "btnLSDKHP";
            this.btnLSDKHP.Size = new System.Drawing.Size(240, 60);
            this.btnLSDKHP.TabIndex = 1;
            this.btnLSDKHP.Text = "Lịch sử đăng ký học phần ";
            this.btnLSDKHP.UseVisualStyleBackColor = false;
            this.btnLSDKHP.Click += new System.EventHandler(this.btnLSDKHP_Click);
            // 
            // btnTCHP
            // 
            this.btnTCHP.BackColor = System.Drawing.Color.White;
            this.btnTCHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTCHP.Location = new System.Drawing.Point(22, 257);
            this.btnTCHP.Name = "btnTCHP";
            this.btnTCHP.Size = new System.Drawing.Size(240, 60);
            this.btnTCHP.TabIndex = 1;
            this.btnTCHP.Text = "Tra cứu học phần";
            this.btnTCHP.UseVisualStyleBackColor = false;
            this.btnTCHP.Click += new System.EventHandler(this.btnTCHP_Click);
            // 
            // btnHPTD
            // 
            this.btnHPTD.BackColor = System.Drawing.Color.White;
            this.btnHPTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHPTD.Location = new System.Drawing.Point(22, 333);
            this.btnHPTD.Name = "btnHPTD";
            this.btnHPTD.Size = new System.Drawing.Size(240, 60);
            this.btnHPTD.TabIndex = 1;
            this.btnHPTD.Text = "Học phần tương đương";
            this.btnHPTD.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 116);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(543, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 116);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(436, 76);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(181, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
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
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
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
            // grdMonHoc
            // 
            this.grdMonHoc.AutoGenerateColumns = false;
            this.grdMonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.SoTC,
            this.MaNhomMonHoc});
            this.grdMonHoc.DataSource = this.tblMonHocBindingSource;
            this.grdMonHoc.Location = new System.Drawing.Point(324, 238);
            this.grdMonHoc.Name = "grdMonHoc";
            this.grdMonHoc.RowHeadersWidth = 51;
            this.grdMonHoc.RowTemplate.Height = 24;
            this.grdMonHoc.Size = new System.Drawing.Size(839, 317);
            this.grdMonHoc.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(321, 145);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(842, 42);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = " Đăng ký học phần ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(157)))), ((int)(((byte)(209)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(321, 193);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 39);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Nhóm môn học";
            // 
            // comNhomMon
            // 
            this.comNhomMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comNhomMon.FormattingEnabled = true;
            this.comNhomMon.Items.AddRange(new object[] {
            "Các môn đại cương",
            "Các môn chuyên ngành"});
            this.comNhomMon.Location = new System.Drawing.Point(532, 193);
            this.comNhomMon.Name = "comNhomMon";
            this.comNhomMon.Size = new System.Drawing.Size(292, 34);
            this.comNhomMon.TabIndex = 6;
            this.comNhomMon.SelectedIndexChanged += new System.EventHandler(this.comNhomMon_SelectedIndexChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(1006, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(156, 42);
            this.button9.TabIndex = 7;
            this.button9.Text = " < Quay về";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(324, 630);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(839, 156);
            this.dataGridView2.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(975, 792);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(185, 49);
            this.button10.TabIndex = 1;
            this.button10.Text = "Xuất phiếu đăng ký";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHDDK);
            this.panel3.Controls.Add(this.btnDKHP);
            this.panel3.Controls.Add(this.btnHPTD);
            this.panel3.Controls.Add(this.btnTCHP);
            this.panel3.Controls.Add(this.btnLSDKHP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 737);
            this.panel3.TabIndex = 9;
            // 
            // dKTCDataSet
            // 
            this.dKTCDataSet.DataSetName = "DKTCDataSet";
            this.dKTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dKTCDataSetBindingSource
            // 
            this.dKTCDataSetBindingSource.DataSource = this.dKTCDataSet;
            this.dKTCDataSetBindingSource.Position = 0;
            // 
            // tblMonHocBindingSource
            // 
            this.tblMonHocBindingSource.DataMember = "tblMonHoc";
            this.tblMonHocBindingSource.DataSource = this.dKTCDataSetBindingSource;
            // 
            // tblMonHocTableAdapter
            // 
            this.tblMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.MaMon.DefaultCellStyle = dataGridViewCellStyle17;
            this.MaMon.HeaderText = "Mã môn học";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaMon.Width = 150;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.TenMon.DefaultCellStyle = dataGridViewCellStyle18;
            this.TenMon.HeaderText = "Tên môn học";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TenMon.Width = 280;
            // 
            // SoTC
            // 
            this.SoTC.DataPropertyName = "SoTC";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.SoTC.DefaultCellStyle = dataGridViewCellStyle19;
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.MinimumWidth = 6;
            this.SoTC.Name = "SoTC";
            this.SoTC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SoTC.Width = 125;
            // 
            // MaNhomMonHoc
            // 
            this.MaNhomMonHoc.DataPropertyName = "MaNhomMonHoc";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.MaNhomMonHoc.DefaultCellStyle = dataGridViewCellStyle20;
            this.MaNhomMonHoc.HeaderText = "MaNhomMonHoc";
            this.MaNhomMonHoc.MinimumWidth = 6;
            this.MaNhomMonHoc.Name = "MaNhomMonHoc";
            this.MaNhomMonHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaNhomMonHoc.Visible = false;
            this.MaNhomMonHoc.Width = 125;
            // 
            // txtKQDK
            // 
            this.txtKQDK.Location = new System.Drawing.Point(324, 576);
            this.txtKQDK.Multiline = true;
            this.txtKQDK.Name = "txtKQDK";
            this.txtKQDK.Size = new System.Drawing.Size(530, 36);
            this.txtKQDK.TabIndex = 10;
            // 
            // frmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(157)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1201, 853);
            this.Controls.Add(this.txtKQDK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.comNhomMon);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grdMonHoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button10);
            this.Name = "frmSV";
            this.Text = "Đăng ký tín chỉ";
            this.Load += new System.EventHandler(this.frmSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHDDK;
        private System.Windows.Forms.Button btnDKHP;
        private System.Windows.Forms.Button btnLSDKHP;
        private System.Windows.Forms.Button btnTCHP;
        private System.Windows.Forms.Button btnHPTD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.DataGridView grdMonHoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comNhomMon;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource dKTCDataSetBindingSource;
        private DKTCDataSet dKTCDataSet;
        private System.Windows.Forms.BindingSource tblMonHocBindingSource;
        private DKTCDataSetTableAdapters.tblMonHocTableAdapter tblMonHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomMonHoc;
        private System.Windows.Forms.TextBox txtKQDK;
    }
}

