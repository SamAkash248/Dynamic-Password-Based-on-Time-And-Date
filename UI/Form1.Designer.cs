
namespace UI
{
    partial class TS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input1 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timelabel = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input1.Location = new System.Drawing.Point(210, 302);
            this.input1.Name = "input1";
            this.input1.PasswordChar = '*';
            this.input1.Size = new System.Drawing.Size(386, 35);
            this.input1.TabIndex = 0;
            this.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(267, 366);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(114, 39);
            this.btn.TabIndex = 1;
            this.btn.Text = "Check";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password Check";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(746, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dynamic Password Based On Time And Date With Period Access";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timelabel.Location = new System.Drawing.Point(236, 91);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(343, 118);
            this.timelabel.TabIndex = 5;
            this.timelabel.Text = "00:00";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sec.Location = new System.Drawing.Point(346, 209);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(118, 79);
            this.sec.TabIndex = 6;
            this.sec.Text = "00";
            // 
            // TS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 494);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.input1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label sec;
    }
}

