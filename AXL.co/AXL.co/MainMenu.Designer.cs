
namespace AXL.co
{
    partial class MainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.casesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.casesIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.casesLabel = new System.Windows.Forms.Label();
            this.casesCount = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.recoveriesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.recoveriesIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.deathsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.deathsIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.date = new System.Windows.Forms.Label();
            this.timee = new System.Windows.Forms.Label();
            this.dateTimePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.todoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.addToList = new Guna.UI2.WinForms.Guna2Button();
            this.todoEntry = new Guna.UI2.WinForms.Guna2TextBox();
            this.todoLabel = new System.Windows.Forms.Label();
            this.todoList = new System.Windows.Forms.ListBox();
            this.button1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.button2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.totalCases = new Guna.UI2.WinForms.Guna2Panel();
            this.totalRecoveries = new Guna.UI2.WinForms.Guna2Panel();
            this.recoveriesLabel = new System.Windows.Forms.Label();
            this.recoveriesCount = new System.Windows.Forms.Label();
            this.totalDeaths = new Guna.UI2.WinForms.Guna2Panel();
            this.deathsLabel = new System.Windows.Forms.Label();
            this.deathsCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.casesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesIcon)).BeginInit();
            this.recoveriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recoveriesIcon)).BeginInit();
            this.deathsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deathsIcon)).BeginInit();
            this.dateTimePanel.SuspendLayout();
            this.todoPanel.SuspendLayout();
            this.totalCases.SuspendLayout();
            this.totalRecoveries.SuspendLayout();
            this.totalDeaths.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // casesPanel
            // 
            this.casesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.casesPanel.Controls.Add(this.casesIcon);
            this.casesPanel.Location = new System.Drawing.Point(3, 6);
            this.casesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.casesPanel.Name = "casesPanel";
            this.casesPanel.ShadowDecoration.Parent = this.casesPanel;
            this.casesPanel.Size = new System.Drawing.Size(69, 65);
            this.casesPanel.TabIndex = 1;
            // 
            // casesIcon
            // 
            this.casesIcon.Image = global::AXL.co.Properties.Resources.mask;
            this.casesIcon.Location = new System.Drawing.Point(3, 6);
            this.casesIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.casesIcon.Name = "casesIcon";
            this.casesIcon.ShadowDecoration.Parent = this.casesIcon;
            this.casesIcon.Size = new System.Drawing.Size(63, 52);
            this.casesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.casesIcon.TabIndex = 0;
            this.casesIcon.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.casesPanel;
            // 
            // casesLabel
            // 
            this.casesLabel.AutoSize = true;
            this.casesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesLabel.ForeColor = System.Drawing.Color.White;
            this.casesLabel.Location = new System.Drawing.Point(75, 6);
            this.casesLabel.Name = "casesLabel";
            this.casesLabel.Size = new System.Drawing.Size(177, 32);
            this.casesLabel.TabIndex = 2;
            this.casesLabel.Text = "Total Cases";
            // 
            // casesCount
            // 
            this.casesCount.AutoSize = true;
            this.casesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesCount.ForeColor = System.Drawing.Color.White;
            this.casesCount.Location = new System.Drawing.Point(77, 42);
            this.casesCount.Name = "casesCount";
            this.casesCount.Size = new System.Drawing.Size(110, 24);
            this.casesCount.TabIndex = 3;
            this.casesCount.Text = "68, 057, 679";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.recoveriesPanel;
            // 
            // recoveriesPanel
            // 
            this.recoveriesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.recoveriesPanel.Controls.Add(this.recoveriesIcon);
            this.recoveriesPanel.Location = new System.Drawing.Point(3, 6);
            this.recoveriesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recoveriesPanel.Name = "recoveriesPanel";
            this.recoveriesPanel.ShadowDecoration.Parent = this.recoveriesPanel;
            this.recoveriesPanel.Size = new System.Drawing.Size(69, 65);
            this.recoveriesPanel.TabIndex = 1;
            // 
            // recoveriesIcon
            // 
            this.recoveriesIcon.Image = global::AXL.co.Properties.Resources.medical_kit;
            this.recoveriesIcon.Location = new System.Drawing.Point(3, 6);
            this.recoveriesIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recoveriesIcon.Name = "recoveriesIcon";
            this.recoveriesIcon.ShadowDecoration.Parent = this.recoveriesIcon;
            this.recoveriesIcon.Size = new System.Drawing.Size(63, 52);
            this.recoveriesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recoveriesIcon.TabIndex = 0;
            this.recoveriesIcon.TabStop = false;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.deathsPanel;
            // 
            // deathsPanel
            // 
            this.deathsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.deathsPanel.Controls.Add(this.deathsIcon);
            this.deathsPanel.Location = new System.Drawing.Point(3, 6);
            this.deathsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deathsPanel.Name = "deathsPanel";
            this.deathsPanel.ShadowDecoration.Parent = this.deathsPanel;
            this.deathsPanel.Size = new System.Drawing.Size(69, 65);
            this.deathsPanel.TabIndex = 1;
            // 
            // deathsIcon
            // 
            this.deathsIcon.Image = global::AXL.co.Properties.Resources.coronavirus;
            this.deathsIcon.Location = new System.Drawing.Point(3, 6);
            this.deathsIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deathsIcon.Name = "deathsIcon";
            this.deathsIcon.ShadowDecoration.Parent = this.deathsIcon;
            this.deathsIcon.Size = new System.Drawing.Size(63, 52);
            this.deathsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deathsIcon.TabIndex = 0;
            this.deathsIcon.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(3, 10);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(98, 44);
            this.date.TabIndex = 10;
            this.date.Text = "date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // timee
            // 
            this.timee.AutoSize = true;
            this.timee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timee.ForeColor = System.Drawing.Color.White;
            this.timee.Location = new System.Drawing.Point(253, 54);
            this.timee.Name = "timee";
            this.timee.Size = new System.Drawing.Size(69, 32);
            this.timee.TabIndex = 11;
            this.timee.Text = "time";
            this.timee.Click += new System.EventHandler(this.time_Click);
            // 
            // dateTimePanel
            // 
            this.dateTimePanel.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePanel.Controls.Add(this.date);
            this.dateTimePanel.Controls.Add(this.timee);
            this.dateTimePanel.Location = new System.Drawing.Point(813, 754);
            this.dateTimePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePanel.Name = "dateTimePanel";
            this.dateTimePanel.ShadowDecoration.Parent = this.dateTimePanel;
            this.dateTimePanel.Size = new System.Drawing.Size(400, 90);
            this.dateTimePanel.TabIndex = 12;
            this.dateTimePanel.UseTransparentBackground = true;
            // 
            // todoPanel
            // 
            this.todoPanel.BackColor = System.Drawing.Color.Transparent;
            this.todoPanel.Controls.Add(this.addToList);
            this.todoPanel.Controls.Add(this.todoEntry);
            this.todoPanel.Controls.Add(this.todoLabel);
            this.todoPanel.Controls.Add(this.todoList);
            this.todoPanel.Location = new System.Drawing.Point(21, 510);
            this.todoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todoPanel.Name = "todoPanel";
            this.todoPanel.ShadowDecoration.Parent = this.todoPanel;
            this.todoPanel.Size = new System.Drawing.Size(312, 336);
            this.todoPanel.TabIndex = 13;
            this.todoPanel.UseTransparentBackground = true;
            // 
            // addToList
            // 
            this.addToList.CheckedState.Parent = this.addToList;
            this.addToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToList.CustomImages.Parent = this.addToList;
            this.addToList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(235)))));
            this.addToList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addToList.ForeColor = System.Drawing.Color.White;
            this.addToList.HoverState.Parent = this.addToList;
            this.addToList.Image = global::AXL.co.Properties.Resources.plus__1_;
            this.addToList.Location = new System.Drawing.Point(260, 46);
            this.addToList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToList.Name = "addToList";
            this.addToList.ShadowDecoration.Parent = this.addToList;
            this.addToList.Size = new System.Drawing.Size(36, 36);
            this.addToList.TabIndex = 3;
            this.addToList.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // todoEntry
            // 
            this.todoEntry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.todoEntry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.todoEntry.DefaultText = "";
            this.todoEntry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.todoEntry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.todoEntry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.todoEntry.DisabledState.Parent = this.todoEntry;
            this.todoEntry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.todoEntry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.todoEntry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.todoEntry.FocusedState.Parent = this.todoEntry;
            this.todoEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoEntry.ForeColor = System.Drawing.Color.White;
            this.todoEntry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.todoEntry.HoverState.Parent = this.todoEntry;
            this.todoEntry.Location = new System.Drawing.Point(15, 46);
            this.todoEntry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.todoEntry.Name = "todoEntry";
            this.todoEntry.PasswordChar = '\0';
            this.todoEntry.PlaceholderText = "";
            this.todoEntry.SelectedText = "";
            this.todoEntry.ShadowDecoration.Parent = this.todoEntry;
            this.todoEntry.Size = new System.Drawing.Size(245, 36);
            this.todoEntry.TabIndex = 2;
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoLabel.ForeColor = System.Drawing.Color.White;
            this.todoLabel.Location = new System.Drawing.Point(11, 4);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(111, 32);
            this.todoLabel.TabIndex = 1;
            this.todoLabel.Text = "TO DO:";
            // 
            // todoList
            // 
            this.todoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.todoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoList.ForeColor = System.Drawing.Color.White;
            this.todoList.FormattingEnabled = true;
            this.todoList.ItemHeight = 22;
            this.todoList.Location = new System.Drawing.Point(11, 100);
            this.todoList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(291, 198);
            this.todoList.TabIndex = 0;
            this.todoList.SelectedIndexChanged += new System.EventHandler(this.todoList_SelectedIndexChanged);
            this.todoList.DoubleClick += new System.EventHandler(this.todoList_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.CheckedState.Parent = this.button1;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.CustomImages.Parent = this.button1;
            this.button1.Enabled = false;
            this.button1.FillColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverState.Parent = this.button1;
            this.button1.Image = global::AXL.co.Properties.Resources.left_map;
            this.button1.Location = new System.Drawing.Point(15, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.button1.ShadowDecoration.Parent = this.button1;
            this.button1.Size = new System.Drawing.Size(35, 54);
            this.button1.TabIndex = 14;
            this.button1.UseTransparentBackground = true;
            this.button1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.CheckedState.Parent = this.button2;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.CustomImages.Parent = this.button2;
            this.button2.FillColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverState.Parent = this.button2;
            this.button2.Image = global::AXL.co.Properties.Resources.arrow_point_to_right;
            this.button2.Location = new System.Drawing.Point(1189, 348);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.button2.ShadowDecoration.Parent = this.button2;
            this.button2.Size = new System.Drawing.Size(37, 54);
            this.button2.TabIndex = 15;
            this.button2.UseTransparentBackground = true;
            this.button2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // totalCases
            // 
            this.totalCases.BackColor = System.Drawing.Color.Transparent;
            this.totalCases.Controls.Add(this.casesPanel);
            this.totalCases.Controls.Add(this.casesLabel);
            this.totalCases.Controls.Add(this.casesCount);
            this.totalCases.Location = new System.Drawing.Point(493, 12);
            this.totalCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalCases.Name = "totalCases";
            this.totalCases.ShadowDecoration.Parent = this.totalCases;
            this.totalCases.Size = new System.Drawing.Size(266, 74);
            this.totalCases.TabIndex = 16;
            this.totalCases.UseTransparentBackground = true;
            // 
            // totalRecoveries
            // 
            this.totalRecoveries.BackColor = System.Drawing.Color.Transparent;
            this.totalRecoveries.Controls.Add(this.recoveriesPanel);
            this.totalRecoveries.Controls.Add(this.recoveriesLabel);
            this.totalRecoveries.Controls.Add(this.recoveriesCount);
            this.totalRecoveries.Location = new System.Drawing.Point(493, 12);
            this.totalRecoveries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalRecoveries.Name = "totalRecoveries";
            this.totalRecoveries.ShadowDecoration.Parent = this.totalRecoveries;
            this.totalRecoveries.Size = new System.Drawing.Size(343, 74);
            this.totalRecoveries.TabIndex = 17;
            this.totalRecoveries.UseTransparentBackground = true;
            // 
            // recoveriesLabel
            // 
            this.recoveriesLabel.AutoSize = true;
            this.recoveriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveriesLabel.ForeColor = System.Drawing.Color.White;
            this.recoveriesLabel.Location = new System.Drawing.Point(75, 6);
            this.recoveriesLabel.Name = "recoveriesLabel";
            this.recoveriesLabel.Size = new System.Drawing.Size(244, 32);
            this.recoveriesLabel.TabIndex = 2;
            this.recoveriesLabel.Text = "Total Recoveries";
            // 
            // recoveriesCount
            // 
            this.recoveriesCount.AutoSize = true;
            this.recoveriesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveriesCount.ForeColor = System.Drawing.Color.White;
            this.recoveriesCount.Location = new System.Drawing.Point(77, 39);
            this.recoveriesCount.Name = "recoveriesCount";
            this.recoveriesCount.Size = new System.Drawing.Size(110, 24);
            this.recoveriesCount.TabIndex = 3;
            this.recoveriesCount.Text = "34, 467, 234";
            // 
            // totalDeaths
            // 
            this.totalDeaths.BackColor = System.Drawing.Color.Transparent;
            this.totalDeaths.Controls.Add(this.deathsPanel);
            this.totalDeaths.Controls.Add(this.deathsLabel);
            this.totalDeaths.Controls.Add(this.deathsCount);
            this.totalDeaths.Location = new System.Drawing.Point(493, 12);
            this.totalDeaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalDeaths.Name = "totalDeaths";
            this.totalDeaths.ShadowDecoration.Parent = this.totalDeaths;
            this.totalDeaths.Size = new System.Drawing.Size(283, 74);
            this.totalDeaths.TabIndex = 18;
            this.totalDeaths.UseTransparentBackground = true;
            // 
            // deathsLabel
            // 
            this.deathsLabel.AutoSize = true;
            this.deathsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathsLabel.ForeColor = System.Drawing.Color.White;
            this.deathsLabel.Location = new System.Drawing.Point(75, 6);
            this.deathsLabel.Name = "deathsLabel";
            this.deathsLabel.Size = new System.Drawing.Size(188, 32);
            this.deathsLabel.TabIndex = 2;
            this.deathsLabel.Text = "Total Deaths";
            // 
            // deathsCount
            // 
            this.deathsCount.AutoSize = true;
            this.deathsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathsCount.ForeColor = System.Drawing.Color.White;
            this.deathsCount.Location = new System.Drawing.Point(77, 39);
            this.deathsCount.Name = "deathsCount";
            this.deathsCount.Size = new System.Drawing.Size(110, 24);
            this.deathsCount.TabIndex = 3;
            this.deathsCount.Text = "34, 467, 234";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalCases);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 846);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalDeaths);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 846);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalRecoveries);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1232, 878);
            this.panel3.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.dateTimePanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.todoPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(1233, 846);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.casesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casesIcon)).EndInit();
            this.recoveriesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recoveriesIcon)).EndInit();
            this.deathsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deathsIcon)).EndInit();
            this.dateTimePanel.ResumeLayout(false);
            this.dateTimePanel.PerformLayout();
            this.todoPanel.ResumeLayout(false);
            this.todoPanel.PerformLayout();
            this.totalCases.ResumeLayout(false);
            this.totalCases.PerformLayout();
            this.totalRecoveries.ResumeLayout(false);
            this.totalRecoveries.PerformLayout();
            this.totalDeaths.ResumeLayout(false);
            this.totalDeaths.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel casesPanel;
        private Guna.UI2.WinForms.Guna2PictureBox casesIcon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label casesLabel;
        private System.Windows.Forms.Label casesCount;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label timee;
        private Guna.UI2.WinForms.Guna2Panel dateTimePanel;
        private Guna.UI2.WinForms.Guna2Panel todoPanel;
        private Guna.UI2.WinForms.Guna2Button addToList;
        private Guna.UI2.WinForms.Guna2TextBox todoEntry;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.ListBox todoList;
        private Guna.UI2.WinForms.Guna2CircleButton button1;
        private Guna.UI2.WinForms.Guna2CircleButton button2;
        private Guna.UI2.WinForms.Guna2Panel totalCases;
        private Guna.UI2.WinForms.Guna2Panel totalRecoveries;
        private Guna.UI2.WinForms.Guna2Panel recoveriesPanel;
        private Guna.UI2.WinForms.Guna2PictureBox recoveriesIcon;
        private System.Windows.Forms.Label recoveriesLabel;
        private System.Windows.Forms.Label recoveriesCount;
        private Guna.UI2.WinForms.Guna2Panel deathsPanel;
        private Guna.UI2.WinForms.Guna2PictureBox deathsIcon;
        private Guna.UI2.WinForms.Guna2Panel totalDeaths;
        private System.Windows.Forms.Label deathsLabel;
        private System.Windows.Forms.Label deathsCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
    }
}
