
namespace AXL.co
{
    partial class CreateGraph
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
            this.topGradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.titlePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.createLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.graphNamePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.graphNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.graphNameLabel = new System.Windows.Forms.Label();
            this.graphTypePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.graphTypeLabel = new System.Windows.Forms.Label();
            this.graphTypeCmbBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.xVariablePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.xValueTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.xVariableLabel = new System.Windows.Forms.Label();
            this.yVariablePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.yValueTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.yVariableLabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.createGraphBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.titlePanel.SuspendLayout();
            this.graphNamePanel.SuspendLayout();
            this.graphTypePanel.SuspendLayout();
            this.xVariablePanel.SuspendLayout();
            this.yVariablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topGradientPanel
            // 
            this.topGradientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topGradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.topGradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(235)))));
            this.topGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.topGradientPanel.Name = "topGradientPanel";
            this.topGradientPanel.ShadowDecoration.Parent = this.topGradientPanel;
            this.topGradientPanel.Size = new System.Drawing.Size(477, 4);
            this.topGradientPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.createLabel);
            this.titlePanel.Controls.Add(this.tableLabel);
            this.titlePanel.Location = new System.Drawing.Point(0, 6);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.ShadowDecoration.Parent = this.titlePanel;
            this.titlePanel.Size = new System.Drawing.Size(202, 41);
            this.titlePanel.TabIndex = 18;
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Roboto Slab", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createLabel.Location = new System.Drawing.Point(8, 4);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(98, 32);
            this.createLabel.TabIndex = 1;
            this.createLabel.Text = "Create:";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Roboto Slab", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.tableLabel.Location = new System.Drawing.Point(110, 4);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(88, 32);
            this.tableLabel.TabIndex = 12;
            this.tableLabel.Text = "Graph";
            // 
            // graphNamePanel
            // 
            this.graphNamePanel.Controls.Add(this.graphNameTxtBox);
            this.graphNamePanel.Controls.Add(this.graphNameLabel);
            this.graphNamePanel.Location = new System.Drawing.Point(17, 79);
            this.graphNamePanel.Name = "graphNamePanel";
            this.graphNamePanel.ShadowDecoration.Parent = this.graphNamePanel;
            this.graphNamePanel.Size = new System.Drawing.Size(443, 85);
            this.graphNamePanel.TabIndex = 19;
            // 
            // graphNameTxtBox
            // 
            this.graphNameTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.graphNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.graphNameTxtBox.DefaultText = "";
            this.graphNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.graphNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.graphNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.graphNameTxtBox.DisabledState.Parent = this.graphNameTxtBox;
            this.graphNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.graphNameTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.graphNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.graphNameTxtBox.FocusedState.Parent = this.graphNameTxtBox;
            this.graphNameTxtBox.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.graphNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.graphNameTxtBox.HoverState.Parent = this.graphNameTxtBox;
            this.graphNameTxtBox.Location = new System.Drawing.Point(13, 29);
            this.graphNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.graphNameTxtBox.Name = "graphNameTxtBox";
            this.graphNameTxtBox.PasswordChar = '\0';
            this.graphNameTxtBox.PlaceholderText = "";
            this.graphNameTxtBox.SelectedText = "";
            this.graphNameTxtBox.ShadowDecoration.Parent = this.graphNameTxtBox;
            this.graphNameTxtBox.Size = new System.Drawing.Size(416, 43);
            this.graphNameTxtBox.TabIndex = 5;
            // 
            // graphNameLabel
            // 
            this.graphNameLabel.AutoSize = true;
            this.graphNameLabel.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.graphNameLabel.Location = new System.Drawing.Point(9, 5);
            this.graphNameLabel.Name = "graphNameLabel";
            this.graphNameLabel.Size = new System.Drawing.Size(95, 19);
            this.graphNameLabel.TabIndex = 4;
            this.graphNameLabel.Text = "Graph Name";
            // 
            // graphTypePanel
            // 
            this.graphTypePanel.Controls.Add(this.graphTypeLabel);
            this.graphTypePanel.Controls.Add(this.graphTypeCmbBox);
            this.graphTypePanel.Location = new System.Drawing.Point(17, 183);
            this.graphTypePanel.Name = "graphTypePanel";
            this.graphTypePanel.ShadowDecoration.Parent = this.graphTypePanel;
            this.graphTypePanel.Size = new System.Drawing.Size(442, 75);
            this.graphTypePanel.TabIndex = 20;
            // 
            // graphTypeLabel
            // 
            this.graphTypeLabel.AutoSize = true;
            this.graphTypeLabel.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphTypeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.graphTypeLabel.Location = new System.Drawing.Point(9, 5);
            this.graphTypeLabel.Name = "graphTypeLabel";
            this.graphTypeLabel.Size = new System.Drawing.Size(88, 19);
            this.graphTypeLabel.TabIndex = 4;
            this.graphTypeLabel.Text = "Graph Type";
            // 
            // graphTypeCmbBox
            // 
            this.graphTypeCmbBox.BackColor = System.Drawing.Color.Transparent;
            this.graphTypeCmbBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.graphTypeCmbBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphTypeCmbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.graphTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphTypeCmbBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.graphTypeCmbBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.graphTypeCmbBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.graphTypeCmbBox.FocusedState.Parent = this.graphTypeCmbBox;
            this.graphTypeCmbBox.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphTypeCmbBox.ForeColor = System.Drawing.Color.White;
            this.graphTypeCmbBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.graphTypeCmbBox.HoverState.Parent = this.graphTypeCmbBox;
            this.graphTypeCmbBox.ItemHeight = 30;
            this.graphTypeCmbBox.Items.AddRange(new object[] {
            "Line",
            "Bar",
            "Pie",
            "Column"});
            this.graphTypeCmbBox.ItemsAppearance.Parent = this.graphTypeCmbBox;
            this.graphTypeCmbBox.Location = new System.Drawing.Point(13, 28);
            this.graphTypeCmbBox.Name = "graphTypeCmbBox";
            this.graphTypeCmbBox.ShadowDecoration.Parent = this.graphTypeCmbBox;
            this.graphTypeCmbBox.Size = new System.Drawing.Size(416, 36);
            this.graphTypeCmbBox.TabIndex = 6;
            // 
            // xVariablePanel
            // 
            this.xVariablePanel.Controls.Add(this.xValueTxtBox);
            this.xVariablePanel.Controls.Add(this.xVariableLabel);
            this.xVariablePanel.Location = new System.Drawing.Point(17, 277);
            this.xVariablePanel.Name = "xVariablePanel";
            this.xVariablePanel.ShadowDecoration.Parent = this.xVariablePanel;
            this.xVariablePanel.Size = new System.Drawing.Size(443, 85);
            this.xVariablePanel.TabIndex = 20;
            // 
            // xValueTxtBox
            // 
            this.xValueTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.xValueTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xValueTxtBox.DefaultText = "";
            this.xValueTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.xValueTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.xValueTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xValueTxtBox.DisabledState.Parent = this.xValueTxtBox;
            this.xValueTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xValueTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.xValueTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.xValueTxtBox.FocusedState.Parent = this.xValueTxtBox;
            this.xValueTxtBox.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValueTxtBox.ForeColor = System.Drawing.Color.White;
            this.xValueTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.xValueTxtBox.HoverState.Parent = this.xValueTxtBox;
            this.xValueTxtBox.Location = new System.Drawing.Point(13, 29);
            this.xValueTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.xValueTxtBox.Name = "xValueTxtBox";
            this.xValueTxtBox.PasswordChar = '\0';
            this.xValueTxtBox.PlaceholderText = "";
            this.xValueTxtBox.SelectedText = "";
            this.xValueTxtBox.ShadowDecoration.Parent = this.xValueTxtBox;
            this.xValueTxtBox.Size = new System.Drawing.Size(416, 43);
            this.xValueTxtBox.TabIndex = 5;
            // 
            // xVariableLabel
            // 
            this.xVariableLabel.AutoSize = true;
            this.xVariableLabel.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xVariableLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.xVariableLabel.Location = new System.Drawing.Point(9, 5);
            this.xVariableLabel.Name = "xVariableLabel";
            this.xVariableLabel.Size = new System.Drawing.Size(158, 19);
            this.xVariableLabel.TabIndex = 4;
            this.xVariableLabel.Text = "X variable / Horizontal";
            // 
            // yVariablePanel
            // 
            this.yVariablePanel.Controls.Add(this.yValueTxtBox);
            this.yVariablePanel.Controls.Add(this.yVariableLabel);
            this.yVariablePanel.Location = new System.Drawing.Point(17, 378);
            this.yVariablePanel.Name = "yVariablePanel";
            this.yVariablePanel.ShadowDecoration.Parent = this.yVariablePanel;
            this.yVariablePanel.Size = new System.Drawing.Size(443, 85);
            this.yVariablePanel.TabIndex = 21;
            // 
            // yValueTxtBox
            // 
            this.yValueTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.yValueTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yValueTxtBox.DefaultText = "";
            this.yValueTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yValueTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yValueTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yValueTxtBox.DisabledState.Parent = this.yValueTxtBox;
            this.yValueTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yValueTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.yValueTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yValueTxtBox.FocusedState.Parent = this.yValueTxtBox;
            this.yValueTxtBox.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValueTxtBox.ForeColor = System.Drawing.Color.White;
            this.yValueTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.yValueTxtBox.HoverState.Parent = this.yValueTxtBox;
            this.yValueTxtBox.Location = new System.Drawing.Point(13, 29);
            this.yValueTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.yValueTxtBox.Name = "yValueTxtBox";
            this.yValueTxtBox.PasswordChar = '\0';
            this.yValueTxtBox.PlaceholderText = "";
            this.yValueTxtBox.SelectedText = "";
            this.yValueTxtBox.ShadowDecoration.Parent = this.yValueTxtBox;
            this.yValueTxtBox.Size = new System.Drawing.Size(416, 43);
            this.yValueTxtBox.TabIndex = 5;
            // 
            // yVariableLabel
            // 
            this.yVariableLabel.AutoSize = true;
            this.yVariableLabel.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yVariableLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.yVariableLabel.Location = new System.Drawing.Point(9, 5);
            this.yVariableLabel.Name = "yVariableLabel";
            this.yVariableLabel.Size = new System.Drawing.Size(139, 19);
            this.yVariableLabel.TabIndex = 4;
            this.yVariableLabel.Text = "Y variable / Vertical";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.createGraphBtn;
            // 
            // exitBtn
            // 
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Image = global::AXL.co.Properties.Resources.cancel;
            this.exitBtn.Location = new System.Drawing.Point(419, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(50, 48);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // createGraphBtn
            // 
            this.createGraphBtn.CheckedState.Parent = this.createGraphBtn;
            this.createGraphBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createGraphBtn.CustomImages.Parent = this.createGraphBtn;
            this.createGraphBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(235)))));
            this.createGraphBtn.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGraphBtn.ForeColor = System.Drawing.Color.White;
            this.createGraphBtn.HoverState.Parent = this.createGraphBtn;
            this.createGraphBtn.Location = new System.Drawing.Point(148, 494);
            this.createGraphBtn.Name = "createGraphBtn";
            this.createGraphBtn.ShadowDecoration.Parent = this.createGraphBtn;
            this.createGraphBtn.Size = new System.Drawing.Size(180, 45);
            this.createGraphBtn.TabIndex = 22;
            this.createGraphBtn.Text = "Create Graph";
            // 
            // CreateGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(477, 570);
            this.Controls.Add(this.createGraphBtn);
            this.Controls.Add(this.yVariablePanel);
            this.Controls.Add(this.xVariablePanel);
            this.Controls.Add(this.graphTypePanel);
            this.Controls.Add(this.graphNamePanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.topGradientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGraph";
            this.Load += new System.EventHandler(this.CreateGraph_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateGraph_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateGraph_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateGraph_MouseUp);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.graphNamePanel.ResumeLayout(false);
            this.graphNamePanel.PerformLayout();
            this.graphTypePanel.ResumeLayout(false);
            this.graphTypePanel.PerformLayout();
            this.xVariablePanel.ResumeLayout(false);
            this.xVariablePanel.PerformLayout();
            this.yVariablePanel.ResumeLayout(false);
            this.yVariablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel topGradientPanel;
        private Guna.UI2.WinForms.Guna2CircleButton exitBtn;
        private Guna.UI2.WinForms.Guna2Panel titlePanel;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Label tableLabel;
        private Guna.UI2.WinForms.Guna2Panel graphNamePanel;
        private Guna.UI2.WinForms.Guna2TextBox graphNameTxtBox;
        private System.Windows.Forms.Label graphNameLabel;
        private Guna.UI2.WinForms.Guna2Panel graphTypePanel;
        private System.Windows.Forms.Label graphTypeLabel;
        private Guna.UI2.WinForms.Guna2ComboBox graphTypeCmbBox;
        private Guna.UI2.WinForms.Guna2Panel xVariablePanel;
        private Guna.UI2.WinForms.Guna2TextBox xValueTxtBox;
        private System.Windows.Forms.Label xVariableLabel;
        private Guna.UI2.WinForms.Guna2Panel yVariablePanel;
        private Guna.UI2.WinForms.Guna2TextBox yValueTxtBox;
        private System.Windows.Forms.Label yVariableLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton createGraphBtn;
    }
}