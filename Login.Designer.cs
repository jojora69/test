
namespace test
{
    partial class Login
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
            this.logBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.log_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(37, 115);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(242, 36);
            this.logBox.TabIndex = 0;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(37, 184);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(242, 36);
            this.passBox.TabIndex = 1;
            // 
            // log_button
            // 
            this.log_button.Location = new System.Drawing.Point(37, 267);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(93, 35);
            this.log_button.TabIndex = 2;
            this.log_button.Text = "Войти";
            this.log_button.UseVisualStyleBackColor = true;
            this.log_button.Click += new System.EventHandler(this.log_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(186, 267);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(93, 35);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.log_button);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.logBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button log_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}