namespace _21_string
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
            this.tbxBilgi = new System.Windows.Forms.TextBox();
            this.btnUzunluk = new System.Windows.Forms.Button();
            this.btnBuyuk = new System.Windows.Forms.Button();
            this.btnKucuk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnPadRight = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnConcate = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnPadLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxBilgi
            // 
            this.tbxBilgi.Location = new System.Drawing.Point(12, 12);
            this.tbxBilgi.Name = "tbxBilgi";
            this.tbxBilgi.Size = new System.Drawing.Size(188, 20);
            this.tbxBilgi.TabIndex = 0;
            // 
            // btnUzunluk
            // 
            this.btnUzunluk.Location = new System.Drawing.Point(206, 10);
            this.btnUzunluk.Name = "btnUzunluk";
            this.btnUzunluk.Size = new System.Drawing.Size(81, 23);
            this.btnUzunluk.TabIndex = 1;
            this.btnUzunluk.Text = "Length";
            this.btnUzunluk.UseVisualStyleBackColor = true;
            this.btnUzunluk.Click += new System.EventHandler(this.btnUzunluk_Click);
            // 
            // btnBuyuk
            // 
            this.btnBuyuk.Location = new System.Drawing.Point(293, 9);
            this.btnBuyuk.Name = "btnBuyuk";
            this.btnBuyuk.Size = new System.Drawing.Size(81, 23);
            this.btnBuyuk.TabIndex = 1;
            this.btnBuyuk.Text = "ToUpper";
            this.btnBuyuk.UseVisualStyleBackColor = true;
            this.btnBuyuk.Click += new System.EventHandler(this.btnBuyuk_Click);
            // 
            // btnKucuk
            // 
            this.btnKucuk.Location = new System.Drawing.Point(380, 9);
            this.btnKucuk.Name = "btnKucuk";
            this.btnKucuk.Size = new System.Drawing.Size(81, 23);
            this.btnKucuk.TabIndex = 1;
            this.btnKucuk.Text = "ToLower";
            this.btnKucuk.UseVisualStyleBackColor = true;
            this.btnKucuk.Click += new System.EventHandler(this.btnKucuk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "StartsWith";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "EndsWith";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(206, 91);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(81, 23);
            this.btnSubstring.TabIndex = 3;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(206, 132);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(81, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(206, 170);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnPadRight
            // 
            this.btnPadRight.Location = new System.Drawing.Point(206, 444);
            this.btnPadRight.Name = "btnPadRight";
            this.btnPadRight.Size = new System.Drawing.Size(81, 23);
            this.btnPadRight.TabIndex = 6;
            this.btnPadRight.Text = "PadRight";
            this.btnPadRight.UseVisualStyleBackColor = true;
            this.btnPadRight.Click += new System.EventHandler(this.btnPadRight_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(206, 209);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(206, 247);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(81, 23);
            this.btnIndexOf.TabIndex = 6;
            this.btnIndexOf.Text = "IndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(206, 289);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(81, 23);
            this.btnLastIndexOf.TabIndex = 6;
            this.btnLastIndexOf.Text = "LastIndexOf";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnConcate
            // 
            this.btnConcate.Location = new System.Drawing.Point(206, 327);
            this.btnConcate.Name = "btnConcate";
            this.btnConcate.Size = new System.Drawing.Size(81, 23);
            this.btnConcate.TabIndex = 6;
            this.btnConcate.Text = "Concate";
            this.btnConcate.UseVisualStyleBackColor = true;
            this.btnConcate.Click += new System.EventHandler(this.btnConcate_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(206, 367);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(81, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(206, 406);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(81, 23);
            this.btnContains.TabIndex = 6;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnPadLeft
            // 
            this.btnPadLeft.Location = new System.Drawing.Point(206, 477);
            this.btnPadLeft.Name = "btnPadLeft";
            this.btnPadLeft.Size = new System.Drawing.Size(81, 23);
            this.btnPadLeft.TabIndex = 7;
            this.btnPadLeft.Text = "PadLeft";
            this.btnPadLeft.UseVisualStyleBackColor = true;
            this.btnPadLeft.Click += new System.EventHandler(this.btnPadLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 512);
            this.Controls.Add(this.btnPadLeft);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnConcate);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnPadRight);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKucuk);
            this.Controls.Add(this.btnBuyuk);
            this.Controls.Add(this.btnUzunluk);
            this.Controls.Add(this.tbxBilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBilgi;
        private System.Windows.Forms.Button btnUzunluk;
        private System.Windows.Forms.Button btnBuyuk;
        private System.Windows.Forms.Button btnKucuk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnPadRight;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnConcate;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnPadLeft;
    }
}

