using Obiddable.Win.Library.UI.ListViews;

namespace Obiddable.Win.UI
{
    partial class MaintenanceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceScreen));
            toolStrip1 = new ToolStrip();
            actionsMenu = new ToolStripDropDownButton();
            helpButton = new ToolStripButton();
            configButton = new ToolStripButton();
            refreshButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            reportsButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            exportsButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            actionsMenuSeparator = new ToolStripSeparator();
            addButton = new ToolStripButton();
            editButton = new ToolStripButton();
            deleteButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            subtitleLabel = new ToolStripLabel();
            panel2 = new Panel();
            listViewMain = new SortableListView();
            topPanel = new Panel();
            backButton = new Button();
            titleLabel = new Label();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.BackColor = Color.FromArgb(236, 236, 236);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { actionsMenu, helpButton, configButton, refreshButton, toolStripSeparator1, reportsButton, toolStripSeparator4, exportsButton, toolStripSeparator3, actionsMenuSeparator, addButton, editButton, deleteButton, toolStripSeparator2, subtitleLabel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.RightToLeft = RightToLeft.No;
            toolStrip1.Size = new Size(1132, 35);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // actionsMenu
            // 
            actionsMenu.Image = (Image)resources.GetObject("actionsMenu.Image");
            actionsMenu.ImageScaling = ToolStripItemImageScaling.None;
            actionsMenu.ImageTransparentColor = Color.Magenta;
            actionsMenu.Name = "actionsMenu";
            actionsMenu.Padding = new Padding(55, 5, 0, 5);
            actionsMenu.Size = new Size(136, 32);
            actionsMenu.Text = " Actions";
            actionsMenu.VisibleChanged += actionsMenu_VisibleChanged;
            // 
            // helpButton
            // 
            helpButton.Alignment = ToolStripItemAlignment.Right;
            helpButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpButton.Image = (Image)resources.GetObject("helpButton.Image");
            helpButton.ImageScaling = ToolStripItemImageScaling.None;
            helpButton.ImageTransparentColor = Color.Magenta;
            helpButton.Name = "helpButton";
            helpButton.Padding = new Padding(5, 5, 3, 5);
            helpButton.Size = new Size(30, 32);
            helpButton.Text = "Help";
            helpButton.Click += helpButton_Click;
            // 
            // configButton
            // 
            configButton.Alignment = ToolStripItemAlignment.Right;
            configButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            configButton.Image = (Image)resources.GetObject("configButton.Image");
            configButton.ImageScaling = ToolStripItemImageScaling.None;
            configButton.ImageTransparentColor = Color.Magenta;
            configButton.Name = "configButton";
            configButton.Padding = new Padding(5, 5, 3, 5);
            configButton.Size = new Size(30, 32);
            configButton.Text = "Config";
            // 
            // refreshButton
            // 
            refreshButton.Alignment = ToolStripItemAlignment.Right;
            refreshButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            refreshButton.Image = (Image)resources.GetObject("refreshButton.Image");
            refreshButton.ImageScaling = ToolStripItemImageScaling.None;
            refreshButton.ImageTransparentColor = Color.Magenta;
            refreshButton.Name = "refreshButton";
            refreshButton.Padding = new Padding(5, 5, 0, 5);
            refreshButton.Size = new Size(27, 32);
            refreshButton.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // reportsButton
            // 
            reportsButton.Alignment = ToolStripItemAlignment.Right;
            reportsButton.Image = (Image)resources.GetObject("reportsButton.Image");
            reportsButton.ImageScaling = ToolStripItemImageScaling.None;
            reportsButton.ImageTransparentColor = Color.Magenta;
            reportsButton.Name = "reportsButton";
            reportsButton.Padding = new Padding(5);
            reportsButton.Size = new Size(115, 32);
            reportsButton.Text = "Reports Folder";
            reportsButton.Click += reportsButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 35);
            // 
            // exportsButton
            // 
            exportsButton.Alignment = ToolStripItemAlignment.Right;
            exportsButton.Image = (Image)resources.GetObject("exportsButton.Image");
            exportsButton.ImageScaling = ToolStripItemImageScaling.None;
            exportsButton.ImageTransparentColor = Color.Magenta;
            exportsButton.Name = "exportsButton";
            exportsButton.Padding = new Padding(5, 5, 6, 5);
            exportsButton.Size = new Size(114, 32);
            exportsButton.Text = "Exports Folder";
            exportsButton.Click += exportsButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 35);
            // 
            // actionsMenuSeparator
            // 
            actionsMenuSeparator.Name = "actionsMenuSeparator";
            actionsMenuSeparator.Size = new Size(6, 35);
            // 
            // addButton
            // 
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.ImageScaling = ToolStripItemImageScaling.None;
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Padding = new Padding(5);
            addButton.Size = new Size(61, 32);
            addButton.Text = "Add";
            addButton.ToolTipText = "Create New (Hotkeys: A, I, Insert)";
            // 
            // editButton
            // 
            editButton.Image = (Image)resources.GetObject("editButton.Image");
            editButton.ImageScaling = ToolStripItemImageScaling.None;
            editButton.ImageTransparentColor = Color.Magenta;
            editButton.Name = "editButton";
            editButton.Padding = new Padding(5);
            editButton.Size = new Size(59, 32);
            editButton.Text = "Edit";
            editButton.ToolTipText = "Edit Selected (Hotkey: E, Enter)";
            // 
            // deleteButton
            // 
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.ImageScaling = ToolStripItemImageScaling.None;
            deleteButton.ImageTransparentColor = Color.Magenta;
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(5);
            deleteButton.Size = new Size(72, 32);
            deleteButton.Text = "Delete";
            deleteButton.ToolTipText = "Delete Selected (Hotkey: D, Delete)";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // subtitleLabel
            // 
            subtitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtitleLabel.ForeColor = Color.Black;
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(98, 32);
            subtitleLabel.Text = "Obiddable (v1.0)";
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewMain);
            panel2.Controls.Add(toolStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1132, 625);
            panel2.TabIndex = 2;
            // 
            // listViewMain
            // 
            listViewMain.AllowColumnReorder = true;
            listViewMain.BackColor = Color.White;
            listViewMain.Dock = DockStyle.Fill;
            listViewMain.Font = new Font("Segoe UI", 10F);
            listViewMain.FullRowSelect = true;
            listViewMain.GridLines = true;
            listViewMain.Location = new Point(0, 35);
            listViewMain.Margin = new Padding(2, 1, 2, 1);
            listViewMain.MultiSelect = false;
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new Size(1132, 590);
            listViewMain.TabIndex = 1;
            listViewMain.UseCompatibleStateImageBehavior = false;
            listViewMain.View = View.Details;
            listViewMain.SelectedIndexChanged += listViewMain_SelectedIndexChanged;
            listViewMain.KeyDown += listViewMain_KeyDown;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(77, 117, 135);
            topPanel.Controls.Add(backButton);
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(2, 1, 2, 1);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1132, 71);
            topPanel.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackColor = Color.Transparent;
            backButton.FlatAppearance.BorderColor = Color.White;
            backButton.FlatAppearance.BorderSize = 2;
            backButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            backButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(1016, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 64);
            backButton.TabIndex = 1;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(236, 236, 236);
            titleLabel.Location = new Point(3, 8);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(328, 50);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Maintenance Form";
            // 
            // MaintenanceScreen
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MaintenanceScreen";
            Size = new Size(1132, 696);
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);

        }









        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton refreshButton;
        public System.Windows.Forms.ToolStripButton addButton;
        public System.Windows.Forms.ToolStripButton editButton;
        public System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.Panel panel2;
        public SortableListView listViewMain;
        public System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.ToolStripDropDownButton actionsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripLabel subtitleLabel;
        public System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ToolStripSeparator actionsMenuSeparator;
        public System.Windows.Forms.ToolStripButton configButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton reportsButton;
        public System.Windows.Forms.ToolStripButton exportsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton helpButton;
    }
}

