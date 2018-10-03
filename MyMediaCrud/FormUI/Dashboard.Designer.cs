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
            System.Windows.Forms.BindingSource movieBindingSource;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NavBar = new System.Windows.Forms.Panel();
            this.SelectRowBtn = new System.Windows.Forms.Button();
            this.DirectorDropDownBtn = new System.Windows.Forms.Button();
            this.ActorDropDownBtn = new System.Windows.Forms.Button();
            this.MovieDropdownBtn = new System.Windows.Forms.Button();
            this.MoviePanel = new System.Windows.Forms.Panel();
            this.EditMoviesBtn = new System.Windows.Forms.Button();
            this.ViewMoviesBtn = new System.Windows.Forms.Button();
            this.AddMoviesBtn = new System.Windows.Forms.Button();
            this.MovieDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.ActorPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ViewActorsBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ActorDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.DirectorPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.AllDirectorsBtn = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.DirectorDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editMoviesControl1 = new FormUI.EditMoviesControl();
            this.searchMoviesControl = new FormUI.SearchMoviesControl();
            movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(movieBindingSource)).BeginInit();
            this.NavBar.SuspendLayout();
            this.MoviePanel.SuspendLayout();
            this.ActorPanel.SuspendLayout();
            this.DirectorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // NavBar
            // 
            this.NavBar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.NavBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NavBar.BackColor = System.Drawing.Color.Maroon;
            this.NavBar.Controls.Add(this.SelectRowBtn);
            this.NavBar.Controls.Add(this.DirectorDropDownBtn);
            this.NavBar.Controls.Add(this.ActorDropDownBtn);
            this.NavBar.Controls.Add(this.MovieDropdownBtn);
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Margin = new System.Windows.Forms.Padding(0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1133, 33);
            this.NavBar.TabIndex = 1;
            // 
            // SelectRowBtn
            // 
            this.SelectRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectRowBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.SelectRowBtn.FlatAppearance.BorderSize = 0;
            this.SelectRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectRowBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRowBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectRowBtn.Location = new System.Drawing.Point(606, 0);
            this.SelectRowBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SelectRowBtn.Name = "SelectRowBtn";
            this.SelectRowBtn.Size = new System.Drawing.Size(202, 33);
            this.SelectRowBtn.TabIndex = 0;
            this.SelectRowBtn.Text = "Test Button";
            this.SelectRowBtn.UseVisualStyleBackColor = false;
            this.SelectRowBtn.Click += new System.EventHandler(this.SelectRowBtn_Click);
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
            this.ActorDropDownBtn.TabIndex = 100;
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
            this.MovieDropdownBtn.Click += new System.EventHandler(this.MovieDropDownBtn_Click);
            // 
            // MoviePanel
            // 
            this.MoviePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviePanel.Controls.Add(this.EditMoviesBtn);
            this.MoviePanel.Controls.Add(this.ViewMoviesBtn);
            this.MoviePanel.Controls.Add(this.AddMoviesBtn);
            this.MoviePanel.Location = new System.Drawing.Point(0, 33);
            this.MoviePanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MoviePanel.Name = "MoviePanel";
            this.MoviePanel.Size = new System.Drawing.Size(202, 99);
            this.MoviePanel.TabIndex = 0;
            // 
            // EditMoviesBtn
            // 
            this.EditMoviesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditMoviesBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.EditMoviesBtn.FlatAppearance.BorderSize = 0;
            this.EditMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditMoviesBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMoviesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditMoviesBtn.Location = new System.Drawing.Point(0, 33);
            this.EditMoviesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EditMoviesBtn.Name = "EditMoviesBtn";
            this.EditMoviesBtn.Size = new System.Drawing.Size(202, 33);
            this.EditMoviesBtn.TabIndex = 2;
            this.EditMoviesBtn.Text = "Edit Movies";
            this.EditMoviesBtn.UseVisualStyleBackColor = false;
            this.EditMoviesBtn.Click += new System.EventHandler(this.EditMoviesBtn_Click);
            // 
            // ViewMoviesBtn
            // 
            this.ViewMoviesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewMoviesBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.ViewMoviesBtn.FlatAppearance.BorderSize = 0;
            this.ViewMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewMoviesBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewMoviesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewMoviesBtn.Location = new System.Drawing.Point(0, 0);
            this.ViewMoviesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ViewMoviesBtn.Name = "ViewMoviesBtn";
            this.ViewMoviesBtn.Size = new System.Drawing.Size(202, 33);
            this.ViewMoviesBtn.TabIndex = 1;
            this.ViewMoviesBtn.Text = "View Movies";
            this.ViewMoviesBtn.UseVisualStyleBackColor = false;
            this.ViewMoviesBtn.Click += new System.EventHandler(this.AllMoviesBtn_Click);
            // 
            // AddMoviesBtn
            // 
            this.AddMoviesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddMoviesBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.AddMoviesBtn.FlatAppearance.BorderSize = 0;
            this.AddMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMoviesBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMoviesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddMoviesBtn.Location = new System.Drawing.Point(0, 66);
            this.AddMoviesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddMoviesBtn.Name = "AddMoviesBtn";
            this.AddMoviesBtn.Size = new System.Drawing.Size(202, 33);
            this.AddMoviesBtn.TabIndex = 3;
            this.AddMoviesBtn.Text = "Add Movies";
            this.AddMoviesBtn.UseVisualStyleBackColor = false;
            this.AddMoviesBtn.Click += new System.EventHandler(this.MoviesByDirector_Click);
            // 
            // MovieDropDownTimer
            // 
            this.MovieDropDownTimer.Interval = 1;
            this.MovieDropDownTimer.Tick += new System.EventHandler(this.MovieDropDownTimer_Tick);
            // 
            // ActorPanel
            // 
            this.ActorPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ActorPanel.Controls.Add(this.button3);
            this.ActorPanel.Controls.Add(this.ViewActorsBtn);
            this.ActorPanel.Controls.Add(this.button7);
            this.ActorPanel.ForeColor = System.Drawing.Color.Black;
            this.ActorPanel.Location = new System.Drawing.Point(202, 33);
            this.ActorPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ActorPanel.Name = "ActorPanel";
            this.ActorPanel.Size = new System.Drawing.Size(202, 0);
            this.ActorPanel.TabIndex = 100;
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
            this.button3.Text = "Edit Actors";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ViewActorsBtn
            // 
            this.ViewActorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewActorsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.ViewActorsBtn.FlatAppearance.BorderSize = 0;
            this.ViewActorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewActorsBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewActorsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewActorsBtn.Location = new System.Drawing.Point(0, 0);
            this.ViewActorsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ViewActorsBtn.Name = "ViewActorsBtn";
            this.ViewActorsBtn.Size = new System.Drawing.Size(202, 33);
            this.ViewActorsBtn.TabIndex = 0;
            this.ViewActorsBtn.Text = "View Actors";
            this.ViewActorsBtn.UseVisualStyleBackColor = false;
            this.ViewActorsBtn.Click += new System.EventHandler(this.ShowAllActorsBtn_Click);
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
            this.button7.Text = "Add Actors";
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
            this.DirectorPanel.Controls.Add(this.AllDirectorsBtn);
            this.DirectorPanel.Controls.Add(this.button14);
            this.DirectorPanel.Controls.Add(this.button15);
            this.DirectorPanel.Location = new System.Drawing.Point(404, 33);
            this.DirectorPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DirectorPanel.Name = "DirectorPanel";
            this.DirectorPanel.Size = new System.Drawing.Size(202, 0);
            this.DirectorPanel.TabIndex = 100;
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
            // AllDirectorsBtn
            // 
            this.AllDirectorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AllDirectorsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.AllDirectorsBtn.FlatAppearance.BorderSize = 0;
            this.AllDirectorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllDirectorsBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllDirectorsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AllDirectorsBtn.Location = new System.Drawing.Point(0, 0);
            this.AllDirectorsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AllDirectorsBtn.Name = "AllDirectorsBtn";
            this.AllDirectorsBtn.Size = new System.Drawing.Size(202, 33);
            this.AllDirectorsBtn.TabIndex = 0;
            this.AllDirectorsBtn.Text = "All Directors";
            this.AllDirectorsBtn.UseVisualStyleBackColor = false;
            this.AllDirectorsBtn.Click += new System.EventHandler(this.AllDirectorsBtn_Click);
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
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = movieBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(0, 33);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(606, 505);
            this.dataGridView2.TabIndex = 300;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runtimeDataGridViewTextBoxColumn
            // 
            this.runtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.runtimeDataGridViewTextBoxColumn.DataPropertyName = "Runtime";
            this.runtimeDataGridViewTextBoxColumn.FillWeight = 40F;
            this.runtimeDataGridViewTextBoxColumn.HeaderText = "Runtime";
            this.runtimeDataGridViewTextBoxColumn.Name = "runtimeDataGridViewTextBoxColumn";
            this.runtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.FillWeight = 20F;
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editMoviesControl1
            // 
            this.editMoviesControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMoviesControl1.Location = new System.Drawing.Point(606, 33);
            this.editMoviesControl1.Name = "editMoviesControl1";
            this.editMoviesControl1.Size = new System.Drawing.Size(527, 505);
            this.editMoviesControl1.TabIndex = 302;
            this.editMoviesControl1.Visible = false;
            // 
            // searchMoviesControl
            // 
            this.searchMoviesControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMoviesControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchMoviesControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchMoviesControl.Location = new System.Drawing.Point(606, 33);
            this.searchMoviesControl.Name = "searchMoviesControl";
            this.searchMoviesControl.Size = new System.Drawing.Size(527, 505);
            this.searchMoviesControl.TabIndex = 301;
            this.searchMoviesControl.Visible = false;
            this.searchMoviesControl.MovieSearch_Event += new System.EventHandler(this.MoviesSearch_Event);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 537);
            this.Controls.Add(this.editMoviesControl1);
            this.Controls.Add(this.DirectorPanel);
            this.Controls.Add(this.ActorPanel);
            this.Controls.Add(this.MoviePanel);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.searchMoviesControl);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Media";
            this.TransparencyKey = System.Drawing.Color.PaleGreen;
            ((System.ComponentModel.ISupportInitialize)(movieBindingSource)).EndInit();
            this.NavBar.ResumeLayout(false);
            this.MoviePanel.ResumeLayout(false);
            this.ActorPanel.ResumeLayout(false);
            this.DirectorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button MovieDropdownBtn;
        private System.Windows.Forms.Panel MoviePanel;
        private System.Windows.Forms.Button ViewMoviesBtn;
        private System.Windows.Forms.Button EditMoviesBtn;
        private System.Windows.Forms.Button AddMoviesBtn;
        private System.Windows.Forms.Timer MovieDropDownTimer;
        private System.Windows.Forms.Button ActorDropDownBtn;
        private System.Windows.Forms.Panel ActorPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ViewActorsBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer ActorDropDownTimer;
        private System.Windows.Forms.Button DirectorDropDownBtn;
        private System.Windows.Forms.Panel DirectorPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button AllDirectorsBtn;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Timer DirectorDropDownTimer;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SelectRowBtn;
        private SearchMoviesControl searchMoviesControl;
        private EditMoviesControl editMoviesControl1;
        //private System.Collections.Generic.List<Movie> Movies;
        //private System.Collections.Generic.List<Director> Directors;
        //private System.Collections.Generic.List<Actor> Actors;
        //private System.Collections.Generic.List<System.Windows.Forms.UserControl> UserControlList;
       

    }
}

