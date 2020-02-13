namespace _79_contextmenustrip_nesnesi
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menü1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menü2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menü3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menü1ToolStripMenuItem,
            this.menü2ToolStripMenuItem,
            this.menü3ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 70);
            // 
            // menü1ToolStripMenuItem
            // 
            this.menü1ToolStripMenuItem.Name = "menü1ToolStripMenuItem";
            this.menü1ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.menü1ToolStripMenuItem.Text = "Menü 1";
            // 
            // menü2ToolStripMenuItem
            // 
            this.menü2ToolStripMenuItem.Name = "menü2ToolStripMenuItem";
            this.menü2ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.menü2ToolStripMenuItem.Text = "Menü 2";
            // 
            // menü3ToolStripMenuItem
            // 
            this.menü3ToolStripMenuItem.Name = "menü3ToolStripMenuItem";
            this.menü3ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.menü3ToolStripMenuItem.Text = "Menü 3";
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(53, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 421);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menü1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menü2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menü3ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

