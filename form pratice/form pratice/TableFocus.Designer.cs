﻿
namespace form_pratice
{
    partial class TableFocus
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DltBtnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ValuesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ColumnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NamePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(12, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Column";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NamePanel
            // 
            this.NamePanel.Controls.Add(this.label2);
            this.NamePanel.Controls.Add(this.label3);
            this.NamePanel.Controls.Add(this.label1);
            this.NamePanel.Location = new System.Drawing.Point(94, 12);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(520, 41);
            this.NamePanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DeleteBtn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column Name";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.DltBtnPanel);
            this.panel1.Controls.Add(this.ValuesPanel);
            this.panel1.Controls.Add(this.ColumnPanel);
            this.panel1.Location = new System.Drawing.Point(93, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 392);
            this.panel1.TabIndex = 0;
            // 
            // DltBtnPanel
            // 
            this.DltBtnPanel.AllowDrop = true;
            this.DltBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DltBtnPanel.AutoSize = true;
            this.DltBtnPanel.Location = new System.Drawing.Point(443, 4);
            this.DltBtnPanel.Name = "DltBtnPanel";
            this.DltBtnPanel.Size = new System.Drawing.Size(35, 378);
            this.DltBtnPanel.TabIndex = 8;
            // 
            // ValuesPanel
            // 
            this.ValuesPanel.AllowDrop = true;
            this.ValuesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValuesPanel.AutoSize = true;
            this.ValuesPanel.Location = new System.Drawing.Point(160, 3);
            this.ValuesPanel.Name = "ValuesPanel";
            this.ValuesPanel.Size = new System.Drawing.Size(261, 378);
            this.ValuesPanel.TabIndex = 7;
            // 
            // ColumnPanel
            // 
            this.ColumnPanel.AllowDrop = true;
            this.ColumnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnPanel.AutoSize = true;
            this.ColumnPanel.Location = new System.Drawing.Point(4, 4);
            this.ColumnPanel.Name = "ColumnPanel";
            this.ColumnPanel.Size = new System.Drawing.Size(150, 378);
            this.ColumnPanel.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(12, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save To Database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Values";
            // 
            // TableFocus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableFocus";
            this.Text = "TableFocus";
            this.Load += new System.EventHandler(this.TableFocus_Load);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel ColumnPanel;
        private System.Windows.Forms.FlowLayoutPanel ValuesPanel;
        private System.Windows.Forms.FlowLayoutPanel DltBtnPanel;
        private System.Windows.Forms.Label label2;
    }
}