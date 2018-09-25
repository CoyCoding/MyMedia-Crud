namespace FormUI
{
    partial class SearchByDirectorForm
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
            this.DirLastNameLabel = new System.Windows.Forms.Label();
            this.DirFirstNameLabel = new System.Windows.Forms.Label();
            this.DirLastNameTextBox = new System.Windows.Forms.TextBox();
            this.DirFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FindByDirBtn = new System.Windows.Forms.Button();
            this.DirFindMoviesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirLastNameLabel
            // 
            this.DirLastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DirLastNameLabel.AutoSize = true;
            this.DirLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirLastNameLabel.Location = new System.Drawing.Point(117, 243);
            this.DirLastNameLabel.Name = "DirLastNameLabel";
            this.DirLastNameLabel.Size = new System.Drawing.Size(99, 24);
            this.DirLastNameLabel.TabIndex = 2;
            this.DirLastNameLabel.Text = "Last Name";
            // 
            // DirFirstNameLabel
            // 
            this.DirFirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DirFirstNameLabel.AutoSize = true;
            this.DirFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirFirstNameLabel.Location = new System.Drawing.Point(117, 191);
            this.DirFirstNameLabel.Name = "DirFirstNameLabel";
            this.DirFirstNameLabel.Size = new System.Drawing.Size(101, 24);
            this.DirFirstNameLabel.TabIndex = 2;
            this.DirFirstNameLabel.Text = "First Name";
            // 
            // DirLastNameTextBox
            // 
            this.DirLastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DirLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirLastNameTextBox.Location = new System.Drawing.Point(255, 244);
            this.DirLastNameTextBox.Name = "DirLastNameTextBox";
            this.DirLastNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.DirLastNameTextBox.TabIndex = 5;
            // 
            // DirFirstNameTextBox
            // 
            this.DirFirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DirFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirFirstNameTextBox.Location = new System.Drawing.Point(255, 191);
            this.DirFirstNameTextBox.Name = "DirFirstNameTextBox";
            this.DirFirstNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.DirFirstNameTextBox.TabIndex = 4;
            // 
            // FindByDirBtn
            // 
            this.FindByDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FindByDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindByDirBtn.Location = new System.Drawing.Point(255, 289);
            this.FindByDirBtn.Name = "FindByDirBtn";
            this.FindByDirBtn.Size = new System.Drawing.Size(183, 30);
            this.FindByDirBtn.TabIndex = 6;
            this.FindByDirBtn.Text = "Search";
            this.FindByDirBtn.UseVisualStyleBackColor = true;
            this.FindByDirBtn.Click += new System.EventHandler(this.FindByDirBtn_Click);
            // 
            // DirFindMoviesLabel
            // 
            this.DirFindMoviesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DirFindMoviesLabel.AutoSize = true;
            this.DirFindMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirFindMoviesLabel.Location = new System.Drawing.Point(117, 295);
            this.DirFindMoviesLabel.Name = "DirFindMoviesLabel";
            this.DirFindMoviesLabel.Size = new System.Drawing.Size(113, 24);
            this.DirFindMoviesLabel.TabIndex = 5;
            this.DirFindMoviesLabel.Text = "Find Movies";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Movies By Director";
            // 
            // SearchByDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirLastNameTextBox);
            this.Controls.Add(this.DirFindMoviesLabel);
            this.Controls.Add(this.DirLastNameLabel);
            this.Controls.Add(this.DirFirstNameLabel);
            this.Controls.Add(this.FindByDirBtn);
            this.Controls.Add(this.DirFirstNameTextBox);
            this.Name = "SearchByDirectorForm";
            this.Size = new System.Drawing.Size(515, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DirLastNameLabel;
        private System.Windows.Forms.Label DirFirstNameLabel;
        private System.Windows.Forms.TextBox DirLastNameTextBox;
        private System.Windows.Forms.TextBox DirFirstNameTextBox;
        private System.Windows.Forms.Button FindByDirBtn;
        private System.Windows.Forms.Label DirFindMoviesLabel;
        private System.Windows.Forms.Label label1;
    }
}
