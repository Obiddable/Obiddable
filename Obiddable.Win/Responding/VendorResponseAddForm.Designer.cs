namespace Obiddable.Win.UI.Bidding.Responding
{
    partial class VendorResponseAddForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorResponseAddForm));
            vendorNameTextBox = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            savechangesButton = new ToolStripButton();
            vendorNameLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // vendorNameTextBox
            // 
            vendorNameTextBox.Location = new Point(13, 27);
            vendorNameTextBox.Margin = new Padding(4, 5, 4, 5);
            vendorNameTextBox.Name = "vendorNameTextBox";
            vendorNameTextBox.Size = new Size(488, 29);
            vendorNameTextBox.TabIndex = 0;
            vendorNameTextBox.KeyDown += VendorResponseAddForm_KeyDown;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, savechangesButton });
            toolStrip1.Location = new Point(0, 80);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(514, 32);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(5);
            toolStripButton1.Size = new Size(57, 29);
            toolStripButton1.Text = "Cancel";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // savechangesButton
            // 
            savechangesButton.Alignment = ToolStripItemAlignment.Right;
            savechangesButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            savechangesButton.Image = (Image)resources.GetObject("savechangesButton.Image");
            savechangesButton.ImageTransparentColor = Color.Magenta;
            savechangesButton.Name = "savechangesButton";
            savechangesButton.Padding = new Padding(5);
            savechangesButton.Size = new Size(94, 29);
            savechangesButton.Text = "Save Changes";
            savechangesButton.Click += savechangesButton_Click;
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vendorNameLabel.Location = new Point(10, 9);
            vendorNameLabel.Margin = new Padding(4, 0, 4, 0);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new Size(81, 13);
            vendorNameLabel.TabIndex = 5;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // VendorResponseAddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 112);
            ControlBox = false;
            Controls.Add(vendorNameLabel);
            Controls.Add(toolStrip1);
            Controls.Add(vendorNameTextBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VendorResponseAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Vendor Reponse";
            KeyDown += VendorResponseAddForm_KeyDown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton savechangesButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label vendorNameLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}