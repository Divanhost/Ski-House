namespace WS.Forms
{
    partial class MainMenuForm
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
            this.listButton = new System.Windows.Forms.Button();
            this.tablesButton = new System.Windows.Forms.Button();
            this.imagesButton = new System.Windows.Forms.Button();
            this.othersButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.showMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(82, 54);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(105, 23);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "Списки";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // tablesButton
            // 
            this.tablesButton.Location = new System.Drawing.Point(82, 84);
            this.tablesButton.Name = "tablesButton";
            this.tablesButton.Size = new System.Drawing.Size(105, 23);
            this.tablesButton.TabIndex = 1;
            this.tablesButton.Text = "Таблицы";
            this.tablesButton.UseVisualStyleBackColor = true;
            this.tablesButton.Click += new System.EventHandler(this.tablesButton_Click);
            // 
            // imagesButton
            // 
            this.imagesButton.Location = new System.Drawing.Point(82, 114);
            this.imagesButton.Name = "imagesButton";
            this.imagesButton.Size = new System.Drawing.Size(105, 23);
            this.imagesButton.TabIndex = 2;
            this.imagesButton.Text = "Изображения";
            this.imagesButton.UseVisualStyleBackColor = true;
            // 
            // othersButton
            // 
            this.othersButton.Location = new System.Drawing.Point(82, 143);
            this.othersButton.Name = "othersButton";
            this.othersButton.Size = new System.Drawing.Size(105, 23);
            this.othersButton.TabIndex = 3;
            this.othersButton.Text = "Другое";
            this.othersButton.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(82, 35);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(35, 13);
            this.userName.TabIndex = 4;
            this.userName.Text = "label1";
            this.userName.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 220);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(66, 23);
            this.openFile.TabIndex = 5;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(85, 220);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 6;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // showMB
            // 
            this.showMB.Location = new System.Drawing.Point(166, 220);
            this.showMB.Name = "showMB";
            this.showMB.Size = new System.Drawing.Size(75, 23);
            this.showMB.TabIndex = 7;
            this.showMB.Text = "Alert";
            this.showMB.UseVisualStyleBackColor = true;
            this.showMB.Click += new System.EventHandler(this.showMB_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showMB);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.othersButton);
            this.Controls.Add(this.imagesButton);
            this.Controls.Add(this.tablesButton);
            this.Controls.Add(this.listButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button tablesButton;
        private System.Windows.Forms.Button imagesButton;
        private System.Windows.Forms.Button othersButton;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button showMB;
    }
}