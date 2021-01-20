
namespace LastNr._5
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
            this.Draw = new System.Windows.Forms.Button();
            this.theight = new System.Windows.Forms.TextBox();
            this.twidth = new System.Windows.Forms.TextBox();
            this.crownheight = new System.Windows.Forms.TextBox();
            this.tresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(726, 71);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(192, 68);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // theight
            // 
            this.theight.Location = new System.Drawing.Point(335, 71);
            this.theight.Name = "theight";
            this.theight.Size = new System.Drawing.Size(243, 31);
            this.theight.TabIndex = 1;
            this.theight.TextChanged += new System.EventHandler(this.theight_TextChanged);
            // 
            // twidth
            // 
            this.twidth.Location = new System.Drawing.Point(335, 134);
            this.twidth.Name = "twidth";
            this.twidth.Size = new System.Drawing.Size(243, 31);
            this.twidth.TabIndex = 2;
            this.twidth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // crownheight
            // 
            this.crownheight.Location = new System.Drawing.Point(335, 194);
            this.crownheight.Name = "crownheight";
            this.crownheight.Size = new System.Drawing.Size(243, 31);
            this.crownheight.TabIndex = 3;
            // 
            // tresult
            // 
            this.tresult.Location = new System.Drawing.Point(442, 280);
            this.tresult.Multiline = true;
            this.tresult.Name = "tresult";
            this.tresult.Size = new System.Drawing.Size(613, 435);
            this.tresult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Treeheight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Treewidth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crownheight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 776);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tresult);
            this.Controls.Add(this.crownheight);
            this.Controls.Add(this.twidth);
            this.Controls.Add(this.theight);
            this.Controls.Add(this.Draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox theight;
        private System.Windows.Forms.TextBox twidth;
        private System.Windows.Forms.TextBox crownheight;
        private System.Windows.Forms.TextBox tresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

