﻿namespace QuanLiSoThu
{
    partial class DSThuOm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.brnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cbSuKien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLVuonThuDataSet2 = new QuanLiSoThu.QLVuonThuDataSet2();
            this.dSThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSThuTableAdapter = new QuanLiSoThu.QLVuonThuDataSet2TableAdapters.DSThuTableAdapter();
            this.panelTitleBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVuonThuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnRestore);
            this.panelTitleBar.Controls.Add(this.brnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1082, 48);
            this.panelTitleBar.TabIndex = 49;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::QuanLiSoThu.Properties.Resources.minus_sign;
            this.btnMinimize.Location = new System.Drawing.Point(911, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(57, 48);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Image = global::QuanLiSoThu.Properties.Resources.restore;
            this.btnRestore.Location = new System.Drawing.Point(968, 0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(57, 48);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // brnClose
            // 
            this.brnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.brnClose.FlatAppearance.BorderSize = 0;
            this.brnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnClose.Image = global::QuanLiSoThu.Properties.Resources.close;
            this.brnClose.Location = new System.Drawing.Point(1025, 0);
            this.brnClose.Name = "brnClose";
            this.brnClose.Size = new System.Drawing.Size(57, 48);
            this.brnClose.TabIndex = 0;
            this.brnClose.UseVisualStyleBackColor = true;
            this.brnClose.Click += new System.EventHandler(this.brnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 169);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btnThongKe);
            this.panel6.Controls.Add(this.cbSuKien);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 162);
            this.panel6.TabIndex = 47;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnThongKe.Image = global::QuanLiSoThu.Properties.Resources.bar_chart;
            this.btnThongKe.Location = new System.Drawing.Point(47, 97);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(150, 50);
            this.btnThongKe.TabIndex = 58;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cbSuKien
            // 
            this.cbSuKien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSuKien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSuKien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuKien.FormattingEnabled = true;
            this.cbSuKien.Location = new System.Drawing.Point(159, 24);
            this.cbSuKien.Name = "cbSuKien";
            this.cbSuKien.Size = new System.Drawing.Size(321, 33);
            this.cbSuKien.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sự kiện";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dSThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLiSoThu.DSThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 217);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1082, 456);
            this.reportViewer1.TabIndex = 51;
            // 
            // qLVuonThuDataSet2
            // 
            this.qLVuonThuDataSet2.DataSetName = "QLVuonThuDataSet2";
            this.qLVuonThuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSThuBindingSource
            // 
            this.dSThuBindingSource.DataMember = "DSThu";
            this.dSThuBindingSource.DataSource = this.qLVuonThuDataSet2;
            // 
            // dSThuTableAdapter
            // 
            this.dSThuTableAdapter.ClearBeforeFill = true;
            // 
            // DSThuOm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "DSThuOm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSThuOm";
            this.Load += new System.EventHandler(this.DSThuOm_Load);
            this.Resize += new System.EventHandler(this.DSThuOm_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVuonThuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button brnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cbSuKien;
        private System.Windows.Forms.Label label7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSThuBindingSource;
        private QLVuonThuDataSet2 qLVuonThuDataSet2;
        private QLVuonThuDataSet2TableAdapters.DSThuTableAdapter dSThuTableAdapter;
    }
}