namespace FormUI
{
    partial class ConfirmUpdateForm
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
            this.UpdateConfirmationLabel = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateConfirmationLabel
            // 
            this.UpdateConfirmationLabel.Location = new System.Drawing.Point(41, 24);
            this.UpdateConfirmationLabel.Name = "UpdateConfirmationLabel";
            this.UpdateConfirmationLabel.Size = new System.Drawing.Size(255, 64);
            this.UpdateConfirmationLabel.TabIndex = 0;
            this.UpdateConfirmationLabel.Text = "$\"Confirm Update\"";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(44, 119);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 1;
            this.ConfirmBtn.Text = "Yes";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(221, 119);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "No";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 173);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.UpdateConfirmationLabel);
            this.Name = "ConfirmUpdateForm";
            this.Text = "Confirm Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UpdateConfirmationLabel;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}