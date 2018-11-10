namespace WS.Forms
{
    partial class ListForm
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
            this.listViewLabel = new System.Windows.Forms.Label();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.comboBoxLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLabel
            // 
            this.listViewLabel.AutoSize = true;
            this.listViewLabel.Location = new System.Drawing.Point(264, 214);
            this.listViewLabel.Name = "listViewLabel";
            this.listViewLabel.Size = new System.Drawing.Size(0, 13);
            this.listViewLabel.TabIndex = 6;
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.Location = new System.Drawing.Point(140, 156);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.listBoxLabel.TabIndex = 5;
            // 
            // comboBoxLabel
            // 
            this.comboBoxLabel.AutoSize = true;
            this.comboBoxLabel.Location = new System.Drawing.Point(12, 82);
            this.comboBoxLabel.Name = "comboBoxLabel";
            this.comboBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.comboBoxLabel.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(267, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(291, 143);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(140, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.listViewLabel);
            this.Controls.Add(this.listBoxLabel);
            this.Controls.Add(this.comboBoxLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.backButton);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label comboBoxLabel;
        private System.Windows.Forms.Label listBoxLabel;
        private System.Windows.Forms.Label listViewLabel;
    }
}