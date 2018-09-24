namespace FormUI
{
    partial class Dashboard
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
            this.MovieListbox = new System.Windows.Forms.ListBox();
            this.DirFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.DirLastNameTextBox = new System.Windows.Forms.TextBox();
            this.DirLastNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchByDirectorBtn = new System.Windows.Forms.Button();
            this.SearchByDirectorBtnLabel = new System.Windows.Forms.Label();
            this.SearchByDirectorHeader = new System.Windows.Forms.Label();
            this.ActorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ActorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.ActorFirstNameLabel = new System.Windows.Forms.Label();
            this.ActorLastNameLabel = new System.Windows.Forms.Label();
            this.SearchByActorBtn = new System.Windows.Forms.Button();
            this.SearchByActorBtnLabel = new System.Windows.Forms.Label();
            this.SearchByActorHeader = new System.Windows.Forms.Label();
            this.ShowAllMoviesBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieListbox
            // 
            this.MovieListbox.FormattingEnabled = true;
            this.MovieListbox.Location = new System.Drawing.Point(12, 79);
            this.MovieListbox.Name = "MovieListbox";
            this.MovieListbox.Size = new System.Drawing.Size(317, 446);
            this.MovieListbox.TabIndex = 0;
            // 
            // DirFirstNameTextBox
            // 
            this.DirFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirFirstNameTextBox.Location = new System.Drawing.Point(541, 134);
            this.DirFirstNameTextBox.Name = "DirFirstNameTextBox";
            this.DirFirstNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.DirFirstNameTextBox.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(403, 134);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(101, 24);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // DirLastNameTextBox
            // 
            this.DirLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirLastNameTextBox.Location = new System.Drawing.Point(541, 187);
            this.DirLastNameTextBox.Name = "DirLastNameTextBox";
            this.DirLastNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.DirLastNameTextBox.TabIndex = 1;
            // 
            // DirLastNameLabel
            // 
            this.DirLastNameLabel.AutoSize = true;
            this.DirLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirLastNameLabel.Location = new System.Drawing.Point(403, 186);
            this.DirLastNameLabel.Name = "DirLastNameLabel";
            this.DirLastNameLabel.Size = new System.Drawing.Size(99, 24);
            this.DirLastNameLabel.TabIndex = 2;
            this.DirLastNameLabel.Text = "Last Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SearchByDirectorBtn
            // 
            this.SearchByDirectorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDirectorBtn.Location = new System.Drawing.Point(541, 232);
            this.SearchByDirectorBtn.Name = "SearchByDirectorBtn";
            this.SearchByDirectorBtn.Size = new System.Drawing.Size(183, 30);
            this.SearchByDirectorBtn.TabIndex = 4;
            this.SearchByDirectorBtn.Text = "Search";
            this.SearchByDirectorBtn.UseVisualStyleBackColor = true;
            this.SearchByDirectorBtn.Click += new System.EventHandler(this.SearchByDirectorBtn_Click);
            // 
            // SearchByDirectorBtnLabel
            // 
            this.SearchByDirectorBtnLabel.AutoSize = true;
            this.SearchByDirectorBtnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDirectorBtnLabel.Location = new System.Drawing.Point(403, 238);
            this.SearchByDirectorBtnLabel.Name = "SearchByDirectorBtnLabel";
            this.SearchByDirectorBtnLabel.Size = new System.Drawing.Size(113, 24);
            this.SearchByDirectorBtnLabel.TabIndex = 5;
            this.SearchByDirectorBtnLabel.Text = "Find Movies";
            // 
            // SearchByDirectorHeader
            // 
            this.SearchByDirectorHeader.AutoSize = true;
            this.SearchByDirectorHeader.Location = new System.Drawing.Point(404, 95);
            this.SearchByDirectorHeader.Name = "SearchByDirectorHeader";
            this.SearchByDirectorHeader.Size = new System.Drawing.Size(133, 13);
            this.SearchByDirectorHeader.TabIndex = 6;
            this.SearchByDirectorHeader.Text = "Search Movies By Director";
            // 
            // ActorFirstNameTextBox
            // 
            this.ActorFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorFirstNameTextBox.Location = new System.Drawing.Point(936, 134);
            this.ActorFirstNameTextBox.Name = "ActorFirstNameTextBox";
            this.ActorFirstNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.ActorFirstNameTextBox.TabIndex = 1;
            // 
            // ActorLastNameTextBox
            // 
            this.ActorLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorLastNameTextBox.Location = new System.Drawing.Point(936, 187);
            this.ActorLastNameTextBox.Name = "ActorLastNameTextBox";
            this.ActorLastNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.ActorLastNameTextBox.TabIndex = 1;
            // 
            // ActorFirstNameLabel
            // 
            this.ActorFirstNameLabel.AutoSize = true;
            this.ActorFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorFirstNameLabel.Location = new System.Drawing.Point(798, 134);
            this.ActorFirstNameLabel.Name = "ActorFirstNameLabel";
            this.ActorFirstNameLabel.Size = new System.Drawing.Size(101, 24);
            this.ActorFirstNameLabel.TabIndex = 2;
            this.ActorFirstNameLabel.Text = "First Name";
            // 
            // ActorLastNameLabel
            // 
            this.ActorLastNameLabel.AutoSize = true;
            this.ActorLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorLastNameLabel.Location = new System.Drawing.Point(798, 186);
            this.ActorLastNameLabel.Name = "ActorLastNameLabel";
            this.ActorLastNameLabel.Size = new System.Drawing.Size(99, 24);
            this.ActorLastNameLabel.TabIndex = 2;
            this.ActorLastNameLabel.Text = "Last Name";
            // 
            // SearchByActorBtn
            // 
            this.SearchByActorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByActorBtn.Location = new System.Drawing.Point(936, 232);
            this.SearchByActorBtn.Name = "SearchByActorBtn";
            this.SearchByActorBtn.Size = new System.Drawing.Size(183, 30);
            this.SearchByActorBtn.TabIndex = 4;
            this.SearchByActorBtn.Text = "Search";
            this.SearchByActorBtn.UseVisualStyleBackColor = true;
            this.SearchByActorBtn.Click += new System.EventHandler(this.SearchByActorBtn_Click);
            // 
            // SearchByActorBtnLabel
            // 
            this.SearchByActorBtnLabel.AutoSize = true;
            this.SearchByActorBtnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByActorBtnLabel.Location = new System.Drawing.Point(798, 238);
            this.SearchByActorBtnLabel.Name = "SearchByActorBtnLabel";
            this.SearchByActorBtnLabel.Size = new System.Drawing.Size(113, 24);
            this.SearchByActorBtnLabel.TabIndex = 5;
            this.SearchByActorBtnLabel.Text = "Find Movies";
            // 
            // SearchByActorHeader
            // 
            this.SearchByActorHeader.AutoSize = true;
            this.SearchByActorHeader.Location = new System.Drawing.Point(799, 95);
            this.SearchByActorHeader.Name = "SearchByActorHeader";
            this.SearchByActorHeader.Size = new System.Drawing.Size(121, 13);
            this.SearchByActorHeader.TabIndex = 6;
            this.SearchByActorHeader.Text = "Search Movies By Actor";
            // 
            // ShowAllMoviesBtn
            // 
            this.ShowAllMoviesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllMoviesBtn.Location = new System.Drawing.Point(407, 495);
            this.ShowAllMoviesBtn.Name = "ShowAllMoviesBtn";
            this.ShowAllMoviesBtn.Size = new System.Drawing.Size(153, 30);
            this.ShowAllMoviesBtn.TabIndex = 4;
            this.ShowAllMoviesBtn.Text = "Show All Movies";
            this.ShowAllMoviesBtn.UseVisualStyleBackColor = true;
            this.ShowAllMoviesBtn.Click += new System.EventHandler(this.ShowAllMoviesBtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(407, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(317, 73);
            this.button5.TabIndex = 3;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(802, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1131, 537);
            this.Controls.Add(this.SearchByActorHeader);
            this.Controls.Add(this.SearchByActorBtnLabel);
            this.Controls.Add(this.SearchByDirectorHeader);
            this.Controls.Add(this.SearchByActorBtn);
            this.Controls.Add(this.SearchByDirectorBtnLabel);
            this.Controls.Add(this.ShowAllMoviesBtn);
            this.Controls.Add(this.SearchByDirectorBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ActorLastNameLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ActorFirstNameLabel);
            this.Controls.Add(this.DirLastNameLabel);
            this.Controls.Add(this.ActorLastNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.ActorFirstNameTextBox);
            this.Controls.Add(this.DirLastNameTextBox);
            this.Controls.Add(this.DirFirstNameTextBox);
            this.Controls.Add(this.MovieListbox);
            this.Name = "Dashboard";
            this.Text = "My Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MovieListbox;
        private System.Windows.Forms.TextBox DirFirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox DirLastNameTextBox;
        private System.Windows.Forms.Label DirLastNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchByDirectorBtn;
        private System.Windows.Forms.Label SearchByDirectorBtnLabel;
        private System.Windows.Forms.Label SearchByDirectorHeader;
        private System.Windows.Forms.TextBox ActorFirstNameTextBox;
        private System.Windows.Forms.TextBox ActorLastNameTextBox;
        private System.Windows.Forms.Label ActorFirstNameLabel;
        private System.Windows.Forms.Label ActorLastNameLabel;
        private System.Windows.Forms.Button SearchByActorBtn;
        private System.Windows.Forms.Label SearchByActorBtnLabel;
        private System.Windows.Forms.Label SearchByActorHeader;
        private System.Windows.Forms.Button ShowAllMoviesBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}

