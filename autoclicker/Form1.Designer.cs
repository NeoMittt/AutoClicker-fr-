namespace autoclicker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonMiddle = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxMins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoClicka = new System.Windows.Forms.PictureBox();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSecs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMils = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonHot = new System.Windows.Forms.Button();
            this.buttonPick = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AutoClicka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonMiddle
            // 
            this.radioButtonMiddle.AutoSize = true;
            this.radioButtonMiddle.Location = new System.Drawing.Point(83, 53);
            this.radioButtonMiddle.Name = "radioButtonMiddle";
            this.radioButtonMiddle.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMiddle.TabIndex = 3;
            this.radioButtonMiddle.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStart.Location = new System.Drawing.Point(183, 202);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(114, 43);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(12, 225);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(65, 20);
            this.textBoxX.TabIndex = 8;
            this.textBoxX.Tag = "cordss";
            this.textBoxX.Text = "0";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMins
            // 
            this.textBoxMins.Location = new System.Drawing.Point(197, 12);
            this.textBoxMins.Name = "textBoxMins";
            this.textBoxMins.Size = new System.Drawing.Size(100, 20);
            this.textBoxMins.TabIndex = 10;
            this.textBoxMins.Text = "0";
            this.textBoxMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mins:";
            // 
            // AutoClicka
            // 
            this.AutoClicka.Image = ((System.Drawing.Image)(resources.GetObject("AutoClicka.Image")));
            this.AutoClicka.Location = new System.Drawing.Point(-27, 12);
            this.AutoClicka.Name = "AutoClicka";
            this.AutoClicka.Size = new System.Drawing.Size(233, 187);
            this.AutoClicka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AutoClicka.TabIndex = 14;
            this.AutoClicka.TabStop = false;
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Location = new System.Drawing.Point(115, 53);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonRight.TabIndex = 15;
            this.radioButtonRight.TabStop = true;
            this.radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(53, 53);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonLeft.TabIndex = 16;
            this.radioButtonLeft.TabStop = true;
            this.radioButtonLeft.Tag = "mouse";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Secs:";
            // 
            // textBoxSecs
            // 
            this.textBoxSecs.Location = new System.Drawing.Point(197, 53);
            this.textBoxSecs.Name = "textBoxSecs";
            this.textBoxSecs.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecs.TabIndex = 17;
            this.textBoxSecs.Text = "0";
            this.textBoxSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSecs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecs_KeyPress);
            this.textBoxSecs.Leave += new System.EventHandler(this.textBoxSecs_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Msecs:";
            // 
            // textBoxMils
            // 
            this.textBoxMils.Location = new System.Drawing.Point(197, 97);
            this.textBoxMils.Name = "textBoxMils";
            this.textBoxMils.Size = new System.Drawing.Size(100, 20);
            this.textBoxMils.TabIndex = 19;
            this.textBoxMils.Text = "1";
            this.textBoxMils.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMils.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMils_KeyPress);
            this.textBoxMils.Leave += new System.EventHandler(this.textBoxMils_Leave);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Enabled = false;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelX.Location = new System.Drawing.Point(35, 202);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 20);
            this.labelX.TabIndex = 22;
            this.labelX.Tag = "cordss";
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Enabled = false;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelY.Location = new System.Drawing.Point(119, 202);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(19, 20);
            this.labelY.TabIndex = 24;
            this.labelY.Tag = "cordss";
            this.labelY.Text = "Y";
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(96, 225);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(65, 20);
            this.textBoxY.TabIndex = 23;
            this.textBoxY.Tag = "cordss";
            this.textBoxY.Text = "0";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonHot
            // 
            this.buttonHot.Location = new System.Drawing.Point(183, 251);
            this.buttonHot.Name = "buttonHot";
            this.buttonHot.Size = new System.Drawing.Size(114, 34);
            this.buttonHot.TabIndex = 25;
            this.buttonHot.Text = "Hotkeys";
            this.buttonHot.UseVisualStyleBackColor = true;
            this.buttonHot.Click += new System.EventHandler(this.buttonHot_Click);
            // 
            // buttonPick
            // 
            this.buttonPick.Enabled = false;
            this.buttonPick.Location = new System.Drawing.Point(12, 251);
            this.buttonPick.Name = "buttonPick";
            this.buttonPick.Size = new System.Drawing.Size(149, 34);
            this.buttonPick.TabIndex = 26;
            this.buttonPick.Tag = "cordss";
            this.buttonPick.Text = "PickLocation";
            this.buttonPick.UseVisualStyleBackColor = true;
            this.buttonPick.Click += new System.EventHandler(this.buttonPick_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "EnableCords";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "mouse",
            "keyboard"});
            this.comboBox11.Location = new System.Drawing.Point(159, 163);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 21);
            this.comboBox11.TabIndex = 28;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.Image = global::autoclicker.Properties.Resources.keyboard;
            this.pictureBoxKey.Location = new System.Drawing.Point(9, 30);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(144, 154);
            this.pictureBoxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKey.TabIndex = 30;
            this.pictureBoxKey.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 298);
            this.Controls.Add(this.pictureBoxKey);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonPick);
            this.Controls.Add(this.buttonHot);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMils);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSecs);
            this.Controls.Add(this.radioButtonLeft);
            this.Controls.Add(this.radioButtonRight);
            this.Controls.Add(this.radioButtonMiddle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMins);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.AutoClicka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoClicka";
            ((System.ComponentModel.ISupportInitialize)(this.AutoClicka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonMiddle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxMins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AutoClicka;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSecs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMils;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonHot;
        private System.Windows.Forms.Button buttonPick;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.PictureBox pictureBoxKey;
    }
}

