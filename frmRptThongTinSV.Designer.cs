
namespace BTL
{
    partial class frmRptThongTinSV
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
            this.crystalReportViewerTTSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerTTSV
            // 
            this.crystalReportViewerTTSV.ActiveViewIndex = -1;
            this.crystalReportViewerTTSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTTSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTTSV.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTTSV.Name = "crystalReportViewerTTSV";
            this.crystalReportViewerTTSV.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerTTSV.TabIndex = 0;
            this.crystalReportViewerTTSV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRptThongTinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerTTSV);
            this.Name = "frmRptThongTinSV";
            this.Text = "frmRptThongTinSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptThongTinSV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTTSV;
    }
}