namespace autoclicker
{
    partial class BindForm
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
            this.buttonkey2 = new System.Windows.Forms.Button();
            this.buttonkey1 = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.textBoxkey1 = new System.Windows.Forms.TextBox();
            this.textBoxkey2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxkey3 = new System.Windows.Forms.TextBox();
            this.buttonkey3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonkey2
            // 
            this.buttonkey2.Location = new System.Drawing.Point(12, 102);
            this.buttonkey2.Name = "buttonkey2";
            this.buttonkey2.Size = new System.Drawing.Size(75, 46);
            this.buttonkey2.TabIndex = 3;
            this.buttonkey2.Text = "PickPosition key";
            this.buttonkey2.UseVisualStyleBackColor = true;
            this.buttonkey2.Click += new System.EventHandler(this.buttonkey2_Click);
            // 
            // buttonkey1
            // 
            this.buttonkey1.Location = new System.Drawing.Point(12, 50);
            this.buttonkey1.Name = "buttonkey1";
            this.buttonkey1.Size = new System.Drawing.Size(75, 46);
            this.buttonkey1.TabIndex = 4;
            this.buttonkey1.Text = "Start/Stop key";
            this.buttonkey1.UseVisualStyleBackColor = true;
            this.buttonkey1.Click += new System.EventHandler(this.buttonkey1_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 210);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(59, 32);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCansel.Location = new System.Drawing.Point(123, 210);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(59, 32);
            this.buttonCansel.TabIndex = 6;
            this.buttonCansel.Text = "Cancel";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // textBoxkey1
            // 
            this.textBoxkey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxkey1.Location = new System.Drawing.Point(107, 50);
            this.textBoxkey1.Multiline = true;
            this.textBoxkey1.Name = "textBoxkey1";
            this.textBoxkey1.ReadOnly = true;
            this.textBoxkey1.Size = new System.Drawing.Size(75, 46);
            this.textBoxkey1.TabIndex = 7;
            this.textBoxkey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxkey2
            // 
            this.textBoxkey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxkey2.Location = new System.Drawing.Point(107, 102);
            this.textBoxkey2.Multiline = true;
            this.textBoxkey2.Name = "textBoxkey2";
            this.textBoxkey2.ReadOnly = true;
            this.textBoxkey2.Size = new System.Drawing.Size(75, 46);
            this.textBoxkey2.TabIndex = 8;
            this.textBoxkey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Press any key except Escape.";
            this.label2.Visible = false;
            // 
            // textBoxkey3
            // 
            this.textBoxkey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxkey3.Location = new System.Drawing.Point(107, 153);
            this.textBoxkey3.Multiline = true;
            this.textBoxkey3.Name = "textBoxkey3";
            this.textBoxkey3.ReadOnly = true;
            this.textBoxkey3.Size = new System.Drawing.Size(75, 46);
            this.textBoxkey3.TabIndex = 12;
            this.textBoxkey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonkey3
            // 
            this.buttonkey3.Location = new System.Drawing.Point(12, 153);
            this.buttonkey3.Name = "buttonkey3";
            this.buttonkey3.Size = new System.Drawing.Size(75, 46);
            this.buttonkey3.TabIndex = 11;
            this.buttonkey3.Text = "Keyboard key";
            this.buttonkey3.UseVisualStyleBackColor = true;
            this.buttonkey3.Click += new System.EventHandler(this.buttonkey3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Set your binds.";
            // 
            // BindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCansel;
            this.ClientSize = new System.Drawing.Size(207, 254);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxkey3);
            this.Controls.Add(this.buttonkey3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxkey2);
            this.Controls.Add(this.textBoxkey1);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonkey1);
            this.Controls.Add(this.buttonkey2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HotKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonkey2;
        private System.Windows.Forms.Button buttonkey1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.TextBox textBoxkey1;
        private System.Windows.Forms.TextBox textBoxkey2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxkey3;
        private System.Windows.Forms.Button buttonkey3;
        private System.Windows.Forms.Label label3;
    }
}