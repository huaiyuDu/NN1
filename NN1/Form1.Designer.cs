
namespace NN1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clearBtn = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.openTestButton = new System.Windows.Forms.ToolStripButton();
            this.SaveInputButton = new System.Windows.Forms.ToolStripButton();
            this.createInputButton = new System.Windows.Forms.ToolStripButton();
            this.saveTestButton = new System.Windows.Forms.ToolStripButton();
            this.createTestButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BuildBtn = new System.Windows.Forms.ToolStripButton();
            this.inputDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.testBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.logTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.clearBtn);
            this.splitContainer1.Size = new System.Drawing.Size(1135, 809);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(13, 0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.logTextBox.Size = new System.Drawing.Size(1135, 237);
            this.logTextBox.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.inputDataGridView);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer2.Panel2.Controls.Add(this.testDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(1135, 569);
            this.splitContainer2.SplitterDistance = 541;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.SaveInputButton,
            this.createInputButton,
            this.toolStripSeparator1,
            this.BuildBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(541, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(53, 24);
            this.OpenButton.Text = "Open";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1135, 27);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // clearButton
            // 
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 24);
            this.clearButton.Text = "Clear";
            // 
            // testDataGridView
            // 
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDataGridView.Location = new System.Drawing.Point(0, 0);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.RowHeadersWidth = 51;
            this.testDataGridView.RowTemplate.Height = 27;
            this.testDataGridView.Size = new System.Drawing.Size(590, 569);
            this.testDataGridView.TabIndex = 0;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTestButton,
            this.saveTestButton,
            this.createTestButton,
            this.toolStripSeparator2,
            this.testBtn});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(590, 27);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // openTestButton
            // 
            this.openTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openTestButton.Image = ((System.Drawing.Image)(resources.GetObject("openTestButton.Image")));
            this.openTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTestButton.Name = "openTestButton";
            this.openTestButton.Size = new System.Drawing.Size(53, 24);
            this.openTestButton.Text = "Open";
            // 
            // SaveInputButton
            // 
            this.SaveInputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveInputButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveInputButton.Image")));
            this.SaveInputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveInputButton.Name = "SaveInputButton";
            this.SaveInputButton.Size = new System.Drawing.Size(47, 24);
            this.SaveInputButton.Text = "Save";
            // 
            // createInputButton
            // 
            this.createInputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createInputButton.Image = ((System.Drawing.Image)(resources.GetObject("createInputButton.Image")));
            this.createInputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createInputButton.Name = "createInputButton";
            this.createInputButton.Size = new System.Drawing.Size(61, 24);
            this.createInputButton.Text = "Create";
            this.createInputButton.ToolTipText = "Create input vectors";
            this.createInputButton.Click += new System.EventHandler(this.createInputButton_Click);
            // 
            // saveTestButton
            // 
            this.saveTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveTestButton.Image = ((System.Drawing.Image)(resources.GetObject("saveTestButton.Image")));
            this.saveTestButton.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.saveTestButton.Name = "saveTestButton";
            this.saveTestButton.Size = new System.Drawing.Size(47, 24);
            this.saveTestButton.Text = "Save";
            // 
            // createTestButton
            // 
            this.createTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createTestButton.Image = ((System.Drawing.Image)(resources.GetObject("createTestButton.Image")));
            this.createTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(61, 24);
            this.createTestButton.Text = "Create";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // BuildBtn
            // 
            this.BuildBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BuildBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuildBtn.Image")));
            this.BuildBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(49, 24);
            this.BuildBtn.Text = "Build";
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // inputDataGridView
            // 
            this.inputDataGridView.AllowUserToAddRows = false;
            this.inputDataGridView.AllowUserToDeleteRows = false;
            this.inputDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.inputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataGridView.Location = new System.Drawing.Point(0, 27);
            this.inputDataGridView.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.inputDataGridView.Name = "inputDataGridView";
            this.inputDataGridView.RowHeadersWidth = 51;
            this.inputDataGridView.RowTemplate.Height = 27;
            this.inputDataGridView.Size = new System.Drawing.Size(541, 542);
            this.inputDataGridView.TabIndex = 1;
            this.inputDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputDataGridView_CellContentClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // testBtn
            // 
            this.testBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.testBtn.Image = ((System.Drawing.Image)(resources.GetObject("testBtn.Image")));
            this.testBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(44, 24);
            this.testBtn.Text = "Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 809);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.DataGridView testDataGridView;
        private System.Windows.Forms.ToolStripButton openTestButton;
        private System.Windows.Forms.ToolStripButton SaveInputButton;
        private System.Windows.Forms.ToolStripButton createInputButton;
        private System.Windows.Forms.ToolStripButton saveTestButton;
        private System.Windows.Forms.ToolStripButton createTestButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BuildBtn;
        private System.Windows.Forms.DataGridView inputDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton testBtn;
    }
}

