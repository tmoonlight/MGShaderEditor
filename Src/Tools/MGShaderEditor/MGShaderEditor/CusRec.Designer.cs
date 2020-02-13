namespace MGShaderEditor
{
    partial class CusRec
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxWidth = new System.Windows.Forms.NumericUpDown();
            this.tbxHeight = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "height";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.tbxWidth.Location = new System.Drawing.Point(132, 42);
            this.tbxWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbxWidth.Name = "numericUpDown1";
            this.tbxWidth.Size = new System.Drawing.Size(120, 21);
            this.tbxWidth.TabIndex = 3;
            this.tbxWidth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.tbxHeight.Location = new System.Drawing.Point(132, 87);
            this.tbxHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbxHeight.Name = "numericUpDown2";
            this.tbxHeight.Size = new System.Drawing.Size(120, 21);
            this.tbxHeight.TabIndex = 3;
            this.tbxHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CusRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 196);
            this.Controls.Add(this.tbxHeight);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CusRec";
            this.Text = "CusRec";
            this.Load += new System.EventHandler(this.CusRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tbxWidth;
        private System.Windows.Forms.NumericUpDown tbxHeight;
        private System.Windows.Forms.Button button2;
    }
}