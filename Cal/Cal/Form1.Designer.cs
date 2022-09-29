namespace Cal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonminous = new System.Windows.Forms.Button();
            this.buttonmulti = new System.Windows.Forms.Button();
            this.buttondevide = new System.Windows.Forms.Button();
            this.buttonsix = new System.Windows.Forms.Button();
            this.buttonfive = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonequal = new System.Windows.Forms.Button();
            this.buttonmodulos = new System.Windows.Forms.Button();
            this.buttonnine = new System.Windows.Forms.Button();
            this.buttoneight = new System.Windows.Forms.Button();
            this.buttonseven = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttondot = new System.Windows.Forms.Button();
            this.buttonzero = new System.Windows.Forms.Button();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.labelcurrentOpration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button123_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(63, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button123_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(114, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button123_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplus.Location = new System.Drawing.Point(195, 83);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(40, 40);
            this.buttonplus.TabIndex = 3;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonminous
            // 
            this.buttonminous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonminous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonminous.Location = new System.Drawing.Point(241, 83);
            this.buttonminous.Name = "buttonminous";
            this.buttonminous.Size = new System.Drawing.Size(40, 40);
            this.buttonminous.TabIndex = 4;
            this.buttonminous.Text = "-";
            this.buttonminous.UseVisualStyleBackColor = true;
            this.buttonminous.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonmulti
            // 
            this.buttonmulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmulti.Location = new System.Drawing.Point(241, 129);
            this.buttonmulti.Name = "buttonmulti";
            this.buttonmulti.Size = new System.Drawing.Size(40, 40);
            this.buttonmulti.TabIndex = 10;
            this.buttonmulti.Text = "*";
            this.buttonmulti.UseVisualStyleBackColor = true;
            this.buttonmulti.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttondevide
            // 
            this.buttondevide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondevide.Location = new System.Drawing.Point(195, 129);
            this.buttondevide.Name = "buttondevide";
            this.buttondevide.Size = new System.Drawing.Size(40, 40);
            this.buttondevide.TabIndex = 9;
            this.buttondevide.Text = "/";
            this.buttondevide.UseVisualStyleBackColor = true;
            this.buttondevide.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonsix
            // 
            this.buttonsix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsix.Location = new System.Drawing.Point(114, 129);
            this.buttonsix.Name = "buttonsix";
            this.buttonsix.Size = new System.Drawing.Size(40, 40);
            this.buttonsix.TabIndex = 8;
            this.buttonsix.Text = "6";
            this.buttonsix.UseVisualStyleBackColor = true;
            this.buttonsix.Click += new System.EventHandler(this.button123_Click);
            // 
            // buttonfive
            // 
            this.buttonfive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfive.Location = new System.Drawing.Point(63, 129);
            this.buttonfive.Name = "buttonfive";
            this.buttonfive.Size = new System.Drawing.Size(40, 40);
            this.buttonfive.TabIndex = 7;
            this.buttonfive.Text = "5";
            this.buttonfive.UseVisualStyleBackColor = true;
            this.buttonfive.Click += new System.EventHandler(this.button123_Click);
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(12, 129);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 6;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button123_Click);
            // 
            // buttonequal
            // 
            this.buttonequal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonequal.Location = new System.Drawing.Point(241, 175);
            this.buttonequal.Name = "buttonequal";
            this.buttonequal.Size = new System.Drawing.Size(40, 86);
            this.buttonequal.TabIndex = 16;
            this.buttonequal.Text = "=";
            this.buttonequal.UseVisualStyleBackColor = true;
            this.buttonequal.Click += new System.EventHandler(this.button14_Click);
            // 
            // buttonmodulos
            // 
            this.buttonmodulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmodulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodulos.Location = new System.Drawing.Point(195, 175);
            this.buttonmodulos.Name = "buttonmodulos";
            this.buttonmodulos.Size = new System.Drawing.Size(40, 40);
            this.buttonmodulos.TabIndex = 15;
            this.buttonmodulos.Text = "%";
            this.buttonmodulos.UseVisualStyleBackColor = true;
            this.buttonmodulos.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonnine
            // 
            this.buttonnine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnine.Location = new System.Drawing.Point(114, 175);
            this.buttonnine.Name = "buttonnine";
            this.buttonnine.Size = new System.Drawing.Size(40, 40);
            this.buttonnine.TabIndex = 14;
            this.buttonnine.Text = "9";
            this.buttonnine.UseVisualStyleBackColor = true;
            this.buttonnine.Click += new System.EventHandler(this.button123_Click);
            // 
            // buttoneight
            // 
            this.buttoneight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneight.Location = new System.Drawing.Point(63, 175);
            this.buttoneight.Name = "buttoneight";
            this.buttoneight.Size = new System.Drawing.Size(40, 40);
            this.buttoneight.TabIndex = 13;
            this.buttoneight.Text = "8";
            this.buttoneight.UseVisualStyleBackColor = true;
            this.buttoneight.Click += new System.EventHandler(this.button123_Click);
            // 
            // buttonseven
            // 
            this.buttonseven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonseven.Location = new System.Drawing.Point(12, 175);
            this.buttonseven.Name = "buttonseven";
            this.buttonseven.Size = new System.Drawing.Size(40, 40);
            this.buttonseven.TabIndex = 12;
            this.buttonseven.Text = "7";
            this.buttonseven.UseVisualStyleBackColor = true;
            this.buttonseven.Click += new System.EventHandler(this.button123_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(195, 221);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(40, 40);
            this.buttonclear.TabIndex = 21;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.button21_Click);
            // 
            // buttondot
            // 
            this.buttondot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondot.Location = new System.Drawing.Point(114, 221);
            this.buttondot.Name = "buttondot";
            this.buttondot.Size = new System.Drawing.Size(40, 40);
            this.buttondot.TabIndex = 20;
            this.buttondot.Text = ".";
            this.buttondot.UseVisualStyleBackColor = true;
            this.buttondot.Click += new System.EventHandler(this.button123_Click);
            // 
            // buttonzero
            // 
            this.buttonzero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonzero.Location = new System.Drawing.Point(12, 221);
            this.buttonzero.Name = "buttonzero";
            this.buttonzero.Size = new System.Drawing.Size(91, 40);
            this.buttonzero.TabIndex = 19;
            this.buttonzero.Text = "0";
            this.buttonzero.UseVisualStyleBackColor = true;
            this.buttonzero.Click += new System.EventHandler(this.button123_Click);
            // 
            // textBoxresult
            // 
            this.textBoxresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxresult.Location = new System.Drawing.Point(12, 44);
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.Size = new System.Drawing.Size(269, 24);
            this.textBoxresult.TabIndex = 22;
            this.textBoxresult.Text = "0";
            this.textBoxresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxresult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelcurrentOpration
            // 
            this.labelcurrentOpration.AutoSize = true;
            this.labelcurrentOpration.BackColor = System.Drawing.SystemColors.Window;
            this.labelcurrentOpration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcurrentOpration.Location = new System.Drawing.Point(9, 23);
            this.labelcurrentOpration.Name = "labelcurrentOpration";
            this.labelcurrentOpration.Size = new System.Drawing.Size(0, 18);
            this.labelcurrentOpration.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 283);
            this.Controls.Add(this.labelcurrentOpration);
            this.Controls.Add(this.textBoxresult);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttondot);
            this.Controls.Add(this.buttonzero);
            this.Controls.Add(this.buttonequal);
            this.Controls.Add(this.buttonmodulos);
            this.Controls.Add(this.buttonnine);
            this.Controls.Add(this.buttoneight);
            this.Controls.Add(this.buttonseven);
            this.Controls.Add(this.buttonmulti);
            this.Controls.Add(this.buttondevide);
            this.Controls.Add(this.buttonsix);
            this.Controls.Add(this.buttonfive);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.buttonminous);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonminous;
        private System.Windows.Forms.Button buttonmulti;
        private System.Windows.Forms.Button buttondevide;
        private System.Windows.Forms.Button buttonsix;
        private System.Windows.Forms.Button buttonfive;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonequal;
        private System.Windows.Forms.Button buttonmodulos;
        private System.Windows.Forms.Button buttonnine;
        private System.Windows.Forms.Button buttoneight;
        private System.Windows.Forms.Button buttonseven;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttondot;
        private System.Windows.Forms.Button buttonzero;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.Label labelcurrentOpration;
    }
}

