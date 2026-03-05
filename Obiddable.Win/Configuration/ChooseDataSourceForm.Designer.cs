
namespace Obiddable.Win.UI;

partial class ChooseDataSourceForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseDataSourceForm));
        sqliteRadioButton = new RadioButton();
        msSqlRadioButton = new RadioButton();
        sqliteFilePathTextBox = new TextBox();
        sqliteBrowseButton = new Button();
        label1 = new Label();
        label2 = new Label();
        msSqlConnectionStringTextBox = new TextBox();
        toolStrip1 = new ToolStrip();
        cancelButton = new ToolStripButton();
        saveChangesButton = new ToolStripButton();
        msSqlServerTestButton = new Button();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // sqliteRadioButton
        // 
        sqliteRadioButton.AutoSize = true;
        sqliteRadioButton.Location = new Point(12, 12);
        sqliteRadioButton.Name = "sqliteRadioButton";
        sqliteRadioButton.Size = new Size(90, 19);
        sqliteRadioButton.TabIndex = 0;
        sqliteRadioButton.TabStop = true;
        sqliteRadioButton.Text = "Local SQLite";
        sqliteRadioButton.UseVisualStyleBackColor = true;
        sqliteRadioButton.CheckedChanged += SqliteRadioButton_CheckedChanged;
        // 
        // msSqlRadioButton
        // 
        msSqlRadioButton.AutoSize = true;
        msSqlRadioButton.Location = new Point(12, 98);
        msSqlRadioButton.Name = "msSqlRadioButton";
        msSqlRadioButton.Size = new Size(135, 19);
        msSqlRadioButton.TabIndex = 1;
        msSqlRadioButton.TabStop = true;
        msSqlRadioButton.Text = "Microsoft SQL Server";
        msSqlRadioButton.UseVisualStyleBackColor = true;
        msSqlRadioButton.CheckedChanged += MsSqlRadioButton_CheckedChanged;
        // 
        // sqliteFilePathTextBox
        // 
        sqliteFilePathTextBox.Location = new Point(28, 37);
        sqliteFilePathTextBox.Name = "sqliteFilePathTextBox";
        sqliteFilePathTextBox.ReadOnly = true;
        sqliteFilePathTextBox.Size = new Size(343, 23);
        sqliteFilePathTextBox.TabIndex = 2;
        // 
        // sqliteBrowseButton
        // 
        sqliteBrowseButton.Enabled = false;
        sqliteBrowseButton.Location = new Point(376, 38);
        sqliteBrowseButton.Margin = new Padding(2);
        sqliteBrowseButton.Name = "sqliteBrowseButton";
        sqliteBrowseButton.Size = new Size(73, 22);
        sqliteBrowseButton.TabIndex = 9;
        sqliteBrowseButton.Text = "Browse...";
        sqliteBrowseButton.UseVisualStyleBackColor = true;
        sqliteBrowseButton.Click += SqliteBrowseButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = SystemColors.ControlDarkDark;
        label1.Location = new Point(28, 63);
        label1.Name = "label1";
        label1.Size = new Size(231, 15);
        label1.TabIndex = 10;
        label1.Text = "Local file database stored on this machine.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = SystemColors.ControlDarkDark;
        label2.Location = new Point(28, 126);
        label2.Name = "label2";
        label2.Size = new Size(103, 15);
        label2.TabIndex = 11;
        label2.Text = "Connection String";
        // 
        // msSqlConnectionStringTextBox
        // 
        msSqlConnectionStringTextBox.Location = new Point(154, 123);
        msSqlConnectionStringTextBox.Name = "msSqlConnectionStringTextBox";
        msSqlConnectionStringTextBox.Size = new Size(217, 23);
        msSqlConnectionStringTextBox.TabIndex = 12;
        // 
        // toolStrip1
        // 
        toolStrip1.Dock = DockStyle.Bottom;
        toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
        toolStrip1.Items.AddRange(new ToolStripItem[] { cancelButton, saveChangesButton });
        toolStrip1.Location = new Point(0, 168);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(460, 32);
        toolStrip1.TabIndex = 13;
        toolStrip1.Text = "toolStrip1";
        // 
        // cancelButton
        // 
        cancelButton.Alignment = ToolStripItemAlignment.Right;
        cancelButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        cancelButton.Image = (Image)resources.GetObject("cancelButton.Image");
        cancelButton.ImageTransparentColor = Color.Magenta;
        cancelButton.Name = "cancelButton";
        cancelButton.Padding = new Padding(5);
        cancelButton.Size = new Size(57, 29);
        cancelButton.Text = "Cancel";
        cancelButton.Click += CancelButton_Click;
        // 
        // saveChangesButton
        // 
        saveChangesButton.Alignment = ToolStripItemAlignment.Right;
        saveChangesButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        saveChangesButton.Image = (Image)resources.GetObject("saveChangesButton.Image");
        saveChangesButton.ImageTransparentColor = Color.Magenta;
        saveChangesButton.Name = "saveChangesButton";
        saveChangesButton.Padding = new Padding(5);
        saveChangesButton.Size = new Size(94, 29);
        saveChangesButton.Text = "Save Changes";
        saveChangesButton.Click += SaveChangesButton_Click;
        // 
        // msSqlServerTestButton
        // 
        msSqlServerTestButton.Enabled = false;
        msSqlServerTestButton.Location = new Point(376, 126);
        msSqlServerTestButton.Margin = new Padding(2);
        msSqlServerTestButton.Name = "msSqlServerTestButton";
        msSqlServerTestButton.Size = new Size(73, 22);
        msSqlServerTestButton.TabIndex = 14;
        msSqlServerTestButton.Text = "Test";
        msSqlServerTestButton.UseVisualStyleBackColor = true;
        msSqlServerTestButton.Click += TestButton_Click;
        // 
        // ChooseDataSourceForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(460, 200);
        ControlBox = false;
        Controls.Add(msSqlServerTestButton);
        Controls.Add(toolStrip1);
        Controls.Add(msSqlConnectionStringTextBox);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(sqliteBrowseButton);
        Controls.Add(sqliteFilePathTextBox);
        Controls.Add(msSqlRadioButton);
        Controls.Add(sqliteRadioButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ChooseDataSourceForm";
        Text = "Choose Data Source...";
        Load += ChooseDataSourceForm_Load;
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RadioButton sqliteRadioButton;
    private RadioButton msSqlRadioButton;
    public TextBox sqliteFilePathTextBox;
    private Button sqliteBrowseButton;
    private Label label1;
    private Label label2;
    public TextBox msSqlConnectionStringTextBox;
    private ToolStrip toolStrip1;
    private ToolStripButton cancelButton;
    private ToolStripButton saveChangesButton;
    private Button msSqlServerTestButton;
}