namespace FormUI
{
    partial class EditMoviesControl
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
            this.EditMovieLabel = new System.Windows.Forms.Label();
            this.RuntimeLabel = new System.Windows.Forms.Label();
            this.MovieTileLabel = new System.Windows.Forms.Label();
            this.RuntimeTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.UpdateMovieBtn = new System.Windows.Forms.Button();
            this.DeleteSelectedMovieBtn = new System.Windows.Forms.Button();
            this.AddActorToMovieBtn = new System.Windows.Forms.Button();
            this.DirectorTextBox = new System.Windows.Forms.TextBox();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditMovieLabel
            // 
            this.EditMovieLabel.AutoSize = true;
            this.EditMovieLabel.Location = new System.Drawing.Point(205, 27);
            this.EditMovieLabel.Name = "EditMovieLabel";
            this.EditMovieLabel.Size = new System.Drawing.Size(105, 13);
            this.EditMovieLabel.TabIndex = 0;
            this.EditMovieLabel.Text = "Edit Selected Movie:";
            // 
            // RuntimeLabel
            // 
            this.RuntimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RuntimeLabel.AutoSize = true;
            this.RuntimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RuntimeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeLabel.Location = new System.Drawing.Point(97, 167);
            this.RuntimeLabel.Name = "RuntimeLabel";
            this.RuntimeLabel.Size = new System.Drawing.Size(152, 24);
            this.RuntimeLabel.TabIndex = 5;
            this.RuntimeLabel.Text = "Movie Runtime";
            // 
            // MovieTileLabel
            // 
            this.MovieTileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieTileLabel.AutoSize = true;
            this.MovieTileLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieTileLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTileLabel.Location = new System.Drawing.Point(134, 67);
            this.MovieTileLabel.Name = "MovieTileLabel";
            this.MovieTileLabel.Size = new System.Drawing.Size(115, 24);
            this.MovieTileLabel.TabIndex = 6;
            this.MovieTileLabel.Text = "Movie Title";
            // 
            // RuntimeTextBox
            // 
            this.RuntimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RuntimeTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RuntimeTextBox.Location = new System.Drawing.Point(270, 164);
            this.RuntimeTextBox.Name = "RuntimeTextBox";
            this.RuntimeTextBox.Size = new System.Drawing.Size(183, 31);
            this.RuntimeTextBox.TabIndex = 8;
            this.RuntimeTextBox.Text = "HH:mm";
            // 
            // YearLabel
            // 
            this.YearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YearLabel.AutoSize = true;
            this.YearLabel.BackColor = System.Drawing.Color.Transparent;
            this.YearLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(134, 119);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(115, 24);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "Movie Year";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieTitleTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MovieTitleTextBox.Location = new System.Drawing.Point(270, 67);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(183, 31);
            this.MovieTitleTextBox.TabIndex = 9;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YearTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.YearTextBox.Location = new System.Drawing.Point(270, 116);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(183, 31);
            this.YearTextBox.TabIndex = 10;
            this.YearTextBox.Text = "YYYY";
            // 
            // UpdateMovieBtn
            // 
            this.UpdateMovieBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMovieBtn.Location = new System.Drawing.Point(270, 262);
            this.UpdateMovieBtn.Name = "UpdateMovieBtn";
            this.UpdateMovieBtn.Size = new System.Drawing.Size(183, 30);
            this.UpdateMovieBtn.TabIndex = 11;
            this.UpdateMovieBtn.Text = "Update";
            this.UpdateMovieBtn.UseVisualStyleBackColor = true;
            this.UpdateMovieBtn.Click += new System.EventHandler(this.UpdateMovieBtn_Click);
            // 
            // DeleteSelectedMovieBtn
            // 
            this.DeleteSelectedMovieBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSelectedMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedMovieBtn.Location = new System.Drawing.Point(270, 424);
            this.DeleteSelectedMovieBtn.Name = "DeleteSelectedMovieBtn";
            this.DeleteSelectedMovieBtn.Size = new System.Drawing.Size(183, 30);
            this.DeleteSelectedMovieBtn.TabIndex = 11;
            this.DeleteSelectedMovieBtn.Text = " Delete Selected";
            this.DeleteSelectedMovieBtn.UseVisualStyleBackColor = true;
            this.DeleteSelectedMovieBtn.Click += new System.EventHandler(this.DeleteSelectedMovieBtn_Click);
            // 
            // AddActorToMovieBtn
            // 
            this.AddActorToMovieBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddActorToMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddActorToMovieBtn.Location = new System.Drawing.Point(66, 424);
            this.AddActorToMovieBtn.Name = "AddActorToMovieBtn";
            this.AddActorToMovieBtn.Size = new System.Drawing.Size(183, 30);
            this.AddActorToMovieBtn.TabIndex = 11;
            this.AddActorToMovieBtn.Text = "Add Actor";
            this.AddActorToMovieBtn.UseVisualStyleBackColor = true;
            // 
            // DirectorTextBox
            // 
            this.DirectorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DirectorTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.DirectorTextBox.Location = new System.Drawing.Point(270, 213);
            this.DirectorTextBox.Name = "DirectorTextBox";
            this.DirectorTextBox.Size = new System.Drawing.Size(183, 31);
            this.DirectorTextBox.TabIndex = 8;
            this.DirectorTextBox.Text = "First Last";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.BackColor = System.Drawing.Color.Transparent;
            this.DirectorLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorLabel.Location = new System.Drawing.Point(162, 216);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(87, 24);
            this.DirectorLabel.TabIndex = 5;
            this.DirectorLabel.Text = "Director";
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieBtn.Location = new System.Drawing.Point(270, 262);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(183, 30);
            this.AddMovieBtn.TabIndex = 11;
            this.AddMovieBtn.Text = "Add";
            this.AddMovieBtn.UseVisualStyleBackColor = true;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // EditMoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddActorToMovieBtn);
            this.Controls.Add(this.DeleteSelectedMovieBtn);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.UpdateMovieBtn);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.RuntimeLabel);
            this.Controls.Add(this.MovieTileLabel);
            this.Controls.Add(this.DirectorTextBox);
            this.Controls.Add(this.RuntimeTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.EditMovieLabel);
            this.Name = "EditMoviesControl";
            this.Size = new System.Drawing.Size(515, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditMovieLabel;
        private System.Windows.Forms.Label RuntimeLabel;
        private System.Windows.Forms.Label MovieTileLabel;
        private System.Windows.Forms.TextBox RuntimeTextBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button UpdateMovieBtn;
        private System.Windows.Forms.Button DeleteSelectedMovieBtn;
        private System.Windows.Forms.Button AddActorToMovieBtn;
        private System.Windows.Forms.TextBox DirectorTextBox;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Button AddMovieBtn;
    }
}
