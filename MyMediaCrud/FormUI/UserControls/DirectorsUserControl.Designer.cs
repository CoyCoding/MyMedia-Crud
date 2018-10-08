namespace FormUI
{
    partial class DirectorsUserControl
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
            this.SearchActorDirlabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchDirectorBtn = new System.Windows.Forms.Button();
            this.UpdateDirectorBtn = new System.Windows.Forms.Button();
            this.AddDirectorBtn = new System.Windows.Forms.Button();
            this.DeleteDirectorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchActorDirlabel
            // 
            this.SearchActorDirlabel.AutoSize = true;
            this.SearchActorDirlabel.Location = new System.Drawing.Point(194, 59);
            this.SearchActorDirlabel.Name = "SearchActorDirlabel";
            this.SearchActorDirlabel.Size = new System.Drawing.Size(126, 13);
            this.SearchActorDirlabel.TabIndex = 0;
            this.SearchActorDirlabel.Text = "Search for Actor/Director";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LastNameTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LastNameTextBox.Location = new System.Drawing.Point(262, 161);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(183, 31);
            this.LastNameTextBox.TabIndex = 9;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(70, 164);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(110, 24);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(70, 114);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(113, 24);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FirstNameTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.FirstNameTextBox.Location = new System.Drawing.Point(262, 111);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(183, 31);
            this.FirstNameTextBox.TabIndex = 8;
            // 
            // SearchDirectorBtn
            // 
            this.SearchDirectorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDirectorBtn.Location = new System.Drawing.Point(262, 211);
            this.SearchDirectorBtn.Name = "SearchDirectorBtn";
            this.SearchDirectorBtn.Size = new System.Drawing.Size(183, 30);
            this.SearchDirectorBtn.TabIndex = 10;
            this.SearchDirectorBtn.Text = "Search";
            this.SearchDirectorBtn.UseVisualStyleBackColor = true;
            this.SearchDirectorBtn.Click += new System.EventHandler(this.SearchDirectorBtn_Click);
            // 
            // UpdateDirectorBtn
            // 
            this.UpdateDirectorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDirectorBtn.Location = new System.Drawing.Point(262, 211);
            this.UpdateDirectorBtn.Name = "UpdateDirectorBtn";
            this.UpdateDirectorBtn.Size = new System.Drawing.Size(183, 30);
            this.UpdateDirectorBtn.TabIndex = 10;
            this.UpdateDirectorBtn.Text = "Update";
            this.UpdateDirectorBtn.UseVisualStyleBackColor = true;
            this.UpdateDirectorBtn.Click += new System.EventHandler(this.UpdateDirectorBtn_Click);
            // 
            // AddDirectorBtn
            // 
            this.AddDirectorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDirectorBtn.Location = new System.Drawing.Point(262, 211);
            this.AddDirectorBtn.Name = "AddDirectorBtn";
            this.AddDirectorBtn.Size = new System.Drawing.Size(183, 30);
            this.AddDirectorBtn.TabIndex = 10;
            this.AddDirectorBtn.Text = "Add";
            this.AddDirectorBtn.UseVisualStyleBackColor = true;
            this.AddDirectorBtn.Click += new System.EventHandler(this.AddDirectorBtn_Click);
            // 
            // DeleteDirectorBtn
            // 
            this.DeleteDirectorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDirectorBtn.Location = new System.Drawing.Point(262, 429);
            this.DeleteDirectorBtn.Name = "DeleteDirectorBtn";
            this.DeleteDirectorBtn.Size = new System.Drawing.Size(183, 30);
            this.DeleteDirectorBtn.TabIndex = 10;
            this.DeleteDirectorBtn.Text = "Delete";
            this.DeleteDirectorBtn.UseVisualStyleBackColor = true;
            this.DeleteDirectorBtn.Click += new System.EventHandler(this.DeleteDirectorBtn_Click);
            // 
            // DirectorsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteDirectorBtn);
            this.Controls.Add(this.AddDirectorBtn);
            this.Controls.Add(this.UpdateDirectorBtn);
            this.Controls.Add(this.SearchDirectorBtn);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.SearchActorDirlabel);
            this.Name = "DirectorsUserControl";
            this.Size = new System.Drawing.Size(515, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchActorDirlabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button SearchDirectorBtn;
        private System.Windows.Forms.Button UpdateDirectorBtn;
        private System.Windows.Forms.Button AddDirectorBtn;
        private System.Windows.Forms.Button DeleteDirectorBtn;
    }
}
