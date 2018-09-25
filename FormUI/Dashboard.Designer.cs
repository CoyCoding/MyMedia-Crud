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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ActorLastNameLabel = new System.Windows.Forms.Label();
            this.ActorFirstNameLabel = new System.Windows.Forms.Label();
            this.ActorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.ActorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchByActorHeader = new System.Windows.Forms.Label();
            this.NavBar = new System.Windows.Forms.Panel();
            this.DirectorDropDownBtn = new System.Windows.Forms.Button();
            this.ActorDropDownBtn = new System.Windows.Forms.Button();
            this.MovieDropdownBtn = new System.Windows.Forms.Button();
            this.MoviePanel = new System.Windows.Forms.Panel();
            this.MoviesByActorBtn = new System.Windows.Forms.Button();
            this.AllMoviesBtn = new System.Windows.Forms.Button();
            this.MoviesByGenreBtn = new System.Windows.Forms.Button();
            this.MoviesByDirector = new System.Windows.Forms.Button();
            this.DropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.ActorPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ActorDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.DirectorPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.DirectorDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByDirectorForm1 = new FormUI.SearchByDirectorForm();
            this.searchByActorForm1 = new FormUI.SearchByActorForm();
            this.NavBar.SuspendLayout();
            this.MoviePanel.SuspendLayout();
            this.ActorPanel.SuspendLayout();
            this.DirectorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
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
            this.button2.TabIndex = 10;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
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
            // ActorLastNameTextBox
            // 
            this.ActorLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorLastNameTextBox.Location = new System.Drawing.Point(936, 187);
            this.ActorLastNameTextBox.Name = "ActorLastNameTextBox";
            this.ActorLastNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.ActorLastNameTextBox.TabIndex = 5;
            // 
            // ActorFirstNameTextBox
            // 
            this.ActorFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorFirstNameTextBox.Location = new System.Drawing.Point(936, 134);
            this.ActorFirstNameTextBox.Name = "ActorFirstNameTextBox";
            this.ActorFirstNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.ActorFirstNameTextBox.TabIndex = 4;
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
            // NavBar
            // 
            this.NavBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavBar.BackColor = System.Drawing.Color.Maroon;
            this.NavBar.Controls.Add(this.DirectorDropDownBtn);
            this.NavBar.Controls.Add(this.ActorDropDownBtn);
            this.NavBar.Controls.Add(this.MovieDropdownBtn);
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Margin = new System.Windows.Forms.Padding(0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1133, 33);
            this.NavBar.TabIndex = 1;
            // 
            // DirectorDropDownBtn
            // 
            this.DirectorDropDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DirectorDropDownBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.DirectorDropDownBtn.FlatAppearance.BorderSize = 0;
            this.DirectorDropDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirectorDropDownBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorDropDownBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DirectorDropDownBtn.Location = new System.Drawing.Point(404, 0);
            this.DirectorDropDownBtn.Name = "DirectorDropDownBtn";
            this.DirectorDropDownBtn.Size = new System.Drawing.Size(202, 33);
            this.DirectorDropDownBtn.TabIndex = 0;
            this.DirectorDropDownBtn.Text = "Directors";
            this.DirectorDropDownBtn.UseVisualStyleBackColor = false;
            this.DirectorDropDownBtn.Click += new System.EventHandler(this.DirectorDropDownBtn_Click);
            // 
            // ActorDropDownBtn
            // 
            this.ActorDropDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ActorDropDownBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.ActorDropDownBtn.FlatAppearance.BorderSize = 0;
            this.ActorDropDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActorDropDownBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorDropDownBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ActorDropDownBtn.Location = new System.Drawing.Point(202, 0);
            this.ActorDropDownBtn.Name = "ActorDropDownBtn";
            this.ActorDropDownBtn.Size = new System.Drawing.Size(202, 33);
            this.ActorDropDownBtn.TabIndex = 0;
            this.ActorDropDownBtn.Text = "Actors";
            this.ActorDropDownBtn.UseVisualStyleBackColor = false;
            this.ActorDropDownBtn.Click += new System.EventHandler(this.ActorDropDownBtn_Click);
            // 
            // MovieDropdownBtn
            // 
            this.MovieDropdownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MovieDropdownBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.MovieDropdownBtn.FlatAppearance.BorderSize = 0;
            this.MovieDropdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieDropdownBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieDropdownBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MovieDropdownBtn.Location = new System.Drawing.Point(0, 0);
            this.MovieDropdownBtn.Name = "MovieDropdownBtn";
            this.MovieDropdownBtn.Size = new System.Drawing.Size(202, 33);
            this.MovieDropdownBtn.TabIndex = 0;
            this.MovieDropdownBtn.Text = "Movies";
            this.MovieDropdownBtn.UseVisualStyleBackColor = false;
            this.MovieDropdownBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // MoviePanel
            // 
            this.MoviePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviePanel.Controls.Add(this.MoviesByActorBtn);
            this.MoviePanel.Controls.Add(this.AllMoviesBtn);
            this.MoviePanel.Controls.Add(this.MoviesByGenreBtn);
            this.MoviePanel.Controls.Add(this.MoviesByDirector);
            this.MoviePanel.Location = new System.Drawing.Point(0, 33);
            this.MoviePanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MoviePanel.Name = "MoviePanel";
            this.MoviePanel.Size = new System.Drawing.Size(202, 0);
            this.MoviePanel.TabIndex = 3;
            // 
            // MoviesByActorBtn
            // 
            this.MoviesByActorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MoviesByActorBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.MoviesByActorBtn.FlatAppearance.BorderSize = 0;
            this.MoviesByActorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviesByActorBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesByActorBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoviesByActorBtn.Location = new System.Drawing.Point(0, 33);
            this.MoviesByActorBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MoviesByActorBtn.Name = "MoviesByActorBtn";
            this.MoviesByActorBtn.Size = new System.Drawing.Size(202, 33);
            this.MoviesByActorBtn.TabIndex = 0;
            this.MoviesByActorBtn.Text = "By Actor";
            this.MoviesByActorBtn.UseVisualStyleBackColor = false;
            // 
            // AllMoviesBtn
            // 
            this.AllMoviesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AllMoviesBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.AllMoviesBtn.FlatAppearance.BorderSize = 0;
            this.AllMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllMoviesBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllMoviesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AllMoviesBtn.Location = new System.Drawing.Point(0, 0);
            this.AllMoviesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AllMoviesBtn.Name = "AllMoviesBtn";
            this.AllMoviesBtn.Size = new System.Drawing.Size(202, 33);
            this.AllMoviesBtn.TabIndex = 0;
            this.AllMoviesBtn.Text = "All Movies";
            this.AllMoviesBtn.UseVisualStyleBackColor = false;
            this.AllMoviesBtn.Click += new System.EventHandler(this.AllMoviesBtn_Click);
            // 
            // MoviesByGenreBtn
            // 
            this.MoviesByGenreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MoviesByGenreBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.MoviesByGenreBtn.FlatAppearance.BorderSize = 0;
            this.MoviesByGenreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviesByGenreBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesByGenreBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoviesByGenreBtn.Location = new System.Drawing.Point(0, 99);
            this.MoviesByGenreBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MoviesByGenreBtn.Name = "MoviesByGenreBtn";
            this.MoviesByGenreBtn.Size = new System.Drawing.Size(202, 33);
            this.MoviesByGenreBtn.TabIndex = 0;
            this.MoviesByGenreBtn.Text = "By Genre";
            this.MoviesByGenreBtn.UseVisualStyleBackColor = false;
            // 
            // MoviesByDirector
            // 
            this.MoviesByDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MoviesByDirector.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.MoviesByDirector.FlatAppearance.BorderSize = 0;
            this.MoviesByDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviesByDirector.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesByDirector.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoviesByDirector.Location = new System.Drawing.Point(0, 66);
            this.MoviesByDirector.Margin = new System.Windows.Forms.Padding(0);
            this.MoviesByDirector.Name = "MoviesByDirector";
            this.MoviesByDirector.Size = new System.Drawing.Size(202, 33);
            this.MoviesByDirector.TabIndex = 0;
            this.MoviesByDirector.Text = "By Director";
            this.MoviesByDirector.UseVisualStyleBackColor = false;
            // 
            // DropDownTimer
            // 
            this.DropDownTimer.Interval = 1;
            this.DropDownTimer.Tick += new System.EventHandler(this.DropDownTimer_Tick_1);
            // 
            // ActorPanel
            // 
            this.ActorPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ActorPanel.Controls.Add(this.button3);
            this.ActorPanel.Controls.Add(this.button4);
            this.ActorPanel.Controls.Add(this.button6);
            this.ActorPanel.Controls.Add(this.button7);
            this.ActorPanel.Location = new System.Drawing.Point(202, 33);
            this.ActorPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ActorPanel.Name = "ActorPanel";
            this.ActorPanel.Size = new System.Drawing.Size(202, 0);
            this.ActorPanel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "Actors";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "Actors";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(0, 99);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "Actors";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(0, 66);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(202, 33);
            this.button7.TabIndex = 0;
            this.button7.Text = "Actors";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // ActorDropDownTimer
            // 
            this.ActorDropDownTimer.Interval = 1;
            this.ActorDropDownTimer.Tick += new System.EventHandler(this.ActorDropDownTimer_Tick);
            // 
            // DirectorPanel
            // 
            this.DirectorPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DirectorPanel.Controls.Add(this.button8);
            this.DirectorPanel.Controls.Add(this.button13);
            this.DirectorPanel.Controls.Add(this.button14);
            this.DirectorPanel.Controls.Add(this.button15);
            this.DirectorPanel.Location = new System.Drawing.Point(404, 33);
            this.DirectorPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DirectorPanel.Name = "DirectorPanel";
            this.DirectorPanel.Size = new System.Drawing.Size(202, 0);
            this.DirectorPanel.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(0, 33);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(202, 33);
            this.button8.TabIndex = 0;
            this.button8.Text = "Directors";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(202, 33);
            this.button13.TabIndex = 0;
            this.button13.Text = "Directors";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(0, 99);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(202, 33);
            this.button14.TabIndex = 0;
            this.button14.Text = "Directors";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(0, 66);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(202, 33);
            this.button15.TabIndex = 0;
            this.button15.Text = "Directors";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // DirectorDropDownTimer
            // 
            this.DirectorDropDownTimer.Interval = 1;
            this.DirectorDropDownTimer.Tick += new System.EventHandler(this.DirectorDropDownTimer_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.runtimeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.movieBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(594, 486);
            this.dataGridView2.TabIndex = 6;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runtimeDataGridViewTextBoxColumn
            // 
            this.runtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.runtimeDataGridViewTextBoxColumn.DataPropertyName = "Runtime";
            this.runtimeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.runtimeDataGridViewTextBoxColumn.HeaderText = "Runtime";
            this.runtimeDataGridViewTextBoxColumn.Name = "runtimeDataGridViewTextBoxColumn";
            this.runtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.FillWeight = 50F;
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(FormUI.Movie);
            // 
            // searchByDirectorForm1
            // 
            this.searchByDirectorForm1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchByDirectorForm1.Location = new System.Drawing.Point(615, 39);
            this.searchByDirectorForm1.Name = "searchByDirectorForm1";
            this.searchByDirectorForm1.Size = new System.Drawing.Size(515, 486);
            this.searchByDirectorForm1.TabIndex = 5;
            // 
            // searchByActorForm1
            // 
            this.searchByActorForm1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchByActorForm1.Location = new System.Drawing.Point(0, 0);
            this.searchByActorForm1.Name = "searchByActorForm1";
            this.searchByActorForm1.Size = new System.Drawing.Size(784, 446);
            this.searchByActorForm1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1131, 537);
            this.Controls.Add(this.searchByDirectorForm1);
            this.Controls.Add(this.DirectorPanel);
            this.Controls.Add(this.ActorPanel);
            this.Controls.Add(this.MoviePanel);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Media";
            this.NavBar.ResumeLayout(false);
            this.MoviePanel.ResumeLayout(false);
            this.ActorPanel.ResumeLayout(false);
            this.DirectorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ActorLastNameLabel;
        private System.Windows.Forms.Label ActorFirstNameLabel;
        private System.Windows.Forms.TextBox ActorLastNameTextBox;
        private System.Windows.Forms.TextBox ActorFirstNameTextBox;
        private System.Windows.Forms.Label SearchByActorHeader;
        private SearchByActorForm searchByActorForm1;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button MovieDropdownBtn;
        private System.Windows.Forms.Panel MoviePanel;
        private System.Windows.Forms.Button AllMoviesBtn;
        private System.Windows.Forms.Button MoviesByActorBtn;
        private System.Windows.Forms.Button MoviesByDirector;
        private System.Windows.Forms.Button MoviesByGenreBtn;
        private System.Windows.Forms.Timer DropDownTimer;
        private System.Windows.Forms.Button ActorDropDownBtn;
        private System.Windows.Forms.Panel ActorPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer ActorDropDownTimer;
        private System.Windows.Forms.Button DirectorDropDownBtn;
        private System.Windows.Forms.Panel DirectorPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Timer DirectorDropDownTimer;
        private SearchByDirectorForm searchByDirectorForm1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}

