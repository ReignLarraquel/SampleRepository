
namespace AXL.co
{
    partial class AddTable
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
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.titlePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.createLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.gradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ColorThemePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ColorThemeLabel = new System.Windows.Forms.Label();
            this.colorThemeCmbBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addImageButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TableNamePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tableNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.tableImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.createTableBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.titlePanel.SuspendLayout();
            this.ColorThemePanel.SuspendLayout();
            this.TableNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableImage)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = global::AXL.co.Properties.Resources.cancel;
            this.exitButton.Location = new System.Drawing.Point(427, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(36, 35);
            this.exitButton.TabIndex = 15;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.createLabel);
            this.titlePanel.Controls.Add(this.tableLabel);
            this.titlePanel.Location = new System.Drawing.Point(0, 6);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.ShadowDecoration.Parent = this.titlePanel;
            this.titlePanel.Size = new System.Drawing.Size(200, 41);
            this.titlePanel.TabIndex = 17;
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
            this.tableLabel.Size = new System.Drawing.Size(81, 32);
            this.tableLabel.TabIndex = 12;
            this.tableLabel.Text = "Table";
            // 
            // gradientPanel
            // 
            this.gradientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.gradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(235)))));
            this.gradientPanel.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.ShadowDecoration.Parent = this.gradientPanel;
            this.gradientPanel.Size = new System.Drawing.Size(473, 5);
            this.gradientPanel.TabIndex = 14;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.createTableBtn;
            // 
            // ColorThemePanel
            // 
            this.ColorThemePanel.Controls.Add(this.ColorThemeLabel);
            this.ColorThemePanel.Controls.Add(this.colorThemeCmbBox);
            this.ColorThemePanel.Location = new System.Drawing.Point(15, 444);
            this.ColorThemePanel.Name = "ColorThemePanel";
            this.ColorThemePanel.ShadowDecoration.Parent = this.ColorThemePanel;
            this.ColorThemePanel.Size = new System.Drawing.Size(442, 75);
            this.ColorThemePanel.TabIndex = 22;
            // 
            // ColorThemeLabel
            // 
            this.ColorThemeLabel.AutoSize = true;
            this.ColorThemeLabel.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorThemeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ColorThemeLabel.Location = new System.Drawing.Point(9, 5);
            this.ColorThemeLabel.Name = "ColorThemeLabel";
            this.ColorThemeLabel.Size = new System.Drawing.Size(99, 19);
            this.ColorThemeLabel.TabIndex = 4;
            this.ColorThemeLabel.Text = "Color Theme";
            // 
            // colorThemeCmbBox
            // 
            this.colorThemeCmbBox.BackColor = System.Drawing.Color.Transparent;
            this.colorThemeCmbBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.colorThemeCmbBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorThemeCmbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorThemeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorThemeCmbBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.colorThemeCmbBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.colorThemeCmbBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.colorThemeCmbBox.FocusedState.Parent = this.colorThemeCmbBox;
            this.colorThemeCmbBox.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorThemeCmbBox.ForeColor = System.Drawing.Color.White;
            this.colorThemeCmbBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.colorThemeCmbBox.HoverState.Parent = this.colorThemeCmbBox;
            this.colorThemeCmbBox.ItemHeight = 30;
            this.colorThemeCmbBox.Items.AddRange(new object[] {
            "Default",
            "Alizarin",
            "Carrot",
            "SunFlower",
            "Amethyst",
            "FeterRiver",
            "Emerald",
            "GreenSea",
            "Turquoise",
            "WetAsphalt"});
            this.colorThemeCmbBox.ItemsAppearance.Parent = this.colorThemeCmbBox;
            this.colorThemeCmbBox.Location = new System.Drawing.Point(13, 28);
            this.colorThemeCmbBox.Name = "colorThemeCmbBox";
            this.colorThemeCmbBox.ShadowDecoration.Parent = this.colorThemeCmbBox;
            this.colorThemeCmbBox.Size = new System.Drawing.Size(416, 36);
            this.colorThemeCmbBox.TabIndex = 6;
            // 
            // addImageButton
            // 
            this.addImageButton.BackColor = System.Drawing.Color.Transparent;
            this.addImageButton.CheckedState.Parent = this.addImageButton;
            this.addImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImageButton.CustomImages.Parent = this.addImageButton;
            this.addImageButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(235)))));
            this.addImageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addImageButton.ForeColor = System.Drawing.Color.White;
            this.addImageButton.HoverState.Parent = this.addImageButton;
            this.addImageButton.Image = global::AXL.co.Properties.Resources.plus__1_;
            this.addImageButton.Location = new System.Drawing.Point(284, 224);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addImageButton.ShadowDecoration.Parent = this.addImageButton;
            this.addImageButton.Size = new System.Drawing.Size(57, 55);
            this.addImageButton.TabIndex = 19;
            this.addImageButton.UseTransparentBackground = true;
            // 
            // TableNamePanel
            // 
            this.TableNamePanel.Controls.Add(this.tableNameTxtBox);
            this.TableNamePanel.Controls.Add(this.TableNameLabel);
            this.TableNamePanel.Location = new System.Drawing.Point(15, 333);
            this.TableNamePanel.Name = "TableNamePanel";
            this.TableNamePanel.ShadowDecoration.Parent = this.TableNamePanel;
            this.TableNamePanel.Size = new System.Drawing.Size(442, 85);
            this.TableNamePanel.TabIndex = 21;
            // 
            // tableNameTxtBox
            // 
            this.tableNameTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tableNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableNameTxtBox.DefaultText = "";
            this.tableNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tableNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tableNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tableNameTxtBox.DisabledState.Parent = this.tableNameTxtBox;
            this.tableNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tableNameTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tableNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tableNameTxtBox.FocusedState.Parent = this.tableNameTxtBox;
            this.tableNameTxtBox.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.tableNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.tableNameTxtBox.HoverState.Parent = this.tableNameTxtBox;
            this.tableNameTxtBox.Location = new System.Drawing.Point(13, 29);
            this.tableNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.tableNameTxtBox.Name = "tableNameTxtBox";
            this.tableNameTxtBox.PasswordChar = '\0';
            this.tableNameTxtBox.PlaceholderText = "";
            this.tableNameTxtBox.SelectedText = "";
            this.tableNameTxtBox.ShadowDecoration.Parent = this.tableNameTxtBox;
            this.tableNameTxtBox.Size = new System.Drawing.Size(416, 43);
            this.tableNameTxtBox.TabIndex = 5;
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TableNameLabel.Location = new System.Drawing.Point(9, 5);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(91, 19);
            this.TableNameLabel.TabIndex = 4;
            this.TableNameLabel.Text = "Table Name";
            // 
            // tableImage
            // 
            this.tableImage.BackColor = System.Drawing.Color.Transparent;
            this.tableImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tableImage.Location = new System.Drawing.Point(130, 79);
            this.tableImage.Name = "tableImage";
            this.tableImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.tableImage.ShadowDecoration.Parent = this.tableImage;
            this.tableImage.Size = new System.Drawing.Size(211, 200);
            this.tableImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tableImage.TabIndex = 18;
            this.tableImage.TabStop = false;
            this.tableImage.UseTransparentBackground = true;
            // 
            // createTableBtn
            // 
            this.createTableBtn.CheckedState.Parent = this.createTableBtn;
            this.createTableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTableBtn.CustomImages.Parent = this.createTableBtn;
            this.createTableBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(235)))));
            this.createTableBtn.Font = new System.Drawing.Font("Roboto Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTableBtn.ForeColor = System.Drawing.Color.White;
            this.createTableBtn.HoverState.Parent = this.createTableBtn;
            this.createTableBtn.Location = new System.Drawing.Point(144, 563);
            this.createTableBtn.Name = "createTableBtn";
            this.createTableBtn.ShadowDecoration.Parent = this.createTableBtn;
            this.createTableBtn.Size = new System.Drawing.Size(180, 45);
            this.createTableBtn.TabIndex = 23;
            this.createTableBtn.Text = "Create Table";
            this.createTableBtn.Click += new System.EventHandler(this.createTableBtn_Click);
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(473, 639);
            this.Controls.Add(this.createTableBtn);
            this.Controls.Add(this.ColorThemePanel);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.TableNamePanel);
            this.Controls.Add(this.tableImage);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.gradientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTable";
            this.Load += new System.EventHandler(this.AddTable_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddTable_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddTable_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddTable_MouseUp);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ColorThemePanel.ResumeLayout(false);
            this.ColorThemePanel.PerformLayout();
            this.TableNamePanel.ResumeLayout(false);
            this.TableNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Panel titlePanel;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Label tableLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel gradientPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel ColorThemePanel;
        private System.Windows.Forms.Label ColorThemeLabel;
        private Guna.UI2.WinForms.Guna2ComboBox colorThemeCmbBox;
        private Guna.UI2.WinForms.Guna2CircleButton addImageButton;
        private Guna.UI2.WinForms.Guna2Panel TableNamePanel;
        private Guna.UI2.WinForms.Guna2TextBox tableNameTxtBox;
        private System.Windows.Forms.Label TableNameLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox tableImage;
        private Guna.UI2.WinForms.Guna2GradientButton createTableBtn;
    }
}