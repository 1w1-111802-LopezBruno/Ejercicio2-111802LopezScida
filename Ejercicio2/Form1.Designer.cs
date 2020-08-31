namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAllDercha = new System.Windows.Forms.Button();
            this.btnAllIzquierda = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(29, 49);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 186);
            this.lst1.TabIndex = 0;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(199, 49);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(120, 186);
            this.lst2.TabIndex = 1;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(155, 79);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(38, 23);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAllDercha
            // 
            this.btnAllDercha.Location = new System.Drawing.Point(155, 112);
            this.btnAllDercha.Name = "btnAllDercha";
            this.btnAllDercha.Size = new System.Drawing.Size(38, 23);
            this.btnAllDercha.TabIndex = 3;
            this.btnAllDercha.Text = ">>";
            this.btnAllDercha.UseVisualStyleBackColor = true;
            this.btnAllDercha.Click += new System.EventHandler(this.btnAllDercha_Click);
            // 
            // btnAllIzquierda
            // 
            this.btnAllIzquierda.Location = new System.Drawing.Point(155, 145);
            this.btnAllIzquierda.Name = "btnAllIzquierda";
            this.btnAllIzquierda.Size = new System.Drawing.Size(38, 23);
            this.btnAllIzquierda.TabIndex = 4;
            this.btnAllIzquierda.Text = "<<";
            this.btnAllIzquierda.UseVisualStyleBackColor = true;
            this.btnAllIzquierda.Click += new System.EventHandler(this.btnAllIzquierda_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(155, 178);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(38, 23);
            this.btnIzquierda.TabIndex = 5;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(114, 259);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 285);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnAllIzquierda);
            this.Controls.Add(this.btnAllDercha);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAllDercha;
        private System.Windows.Forms.Button btnAllIzquierda;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Label lbl1;
    }
}

