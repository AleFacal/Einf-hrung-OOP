
namespace Aufgabe_07_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WordCount = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 131);
            this.textBox1.TabIndex = 1;
            // 
            // WordCount
            // 
            this.WordCount.Location = new System.Drawing.Point(526, 79);
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(218, 73);
            this.WordCount.TabIndex = 2;
            this.WordCount.Text = "Count Words";
            this.WordCount.UseVisualStyleBackColor = true;
            this.WordCount.Click += new System.EventHandler(this.WordCount_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(48, 284);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(143, 25);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output/Result";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(230, 272);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(553, 333);
            this.OutputBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 642);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.WordCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button WordCount;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox OutputBox;
    }
}

