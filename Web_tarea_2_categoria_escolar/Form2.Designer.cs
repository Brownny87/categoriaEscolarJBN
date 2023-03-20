namespace Web_tarea_2_categoria_escolar
{
    partial class convMon
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
            this.boxCop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.boxUsd = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxCny = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxEur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxCop
            // 
            this.boxCop.Location = new System.Drawing.Point(41, 89);
            this.boxCop.Margin = new System.Windows.Forms.Padding(4);
            this.boxCop.Name = "boxCop";
            this.boxCop.Size = new System.Drawing.Size(139, 27);
            this.boxCop.TabIndex = 4;
            this.boxCop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxCop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCop_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "De COP";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(70, 238);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Calcular";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // boxUsd
            // 
            this.boxUsd.Location = new System.Drawing.Point(300, 60);
            this.boxUsd.Margin = new System.Windows.Forms.Padding(4);
            this.boxUsd.Name = "boxUsd";
            this.boxUsd.ReadOnly = true;
            this.boxUsd.Size = new System.Drawing.Size(212, 27);
            this.boxUsd.TabIndex = 8;
            this.boxUsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxUsd.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(396, 238);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 20);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Limpiar";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "A:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "USD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "CNY";
            // 
            // boxCny
            // 
            this.boxCny.Location = new System.Drawing.Point(300, 162);
            this.boxCny.Margin = new System.Windows.Forms.Padding(4);
            this.boxCny.Name = "boxCny";
            this.boxCny.ReadOnly = true;
            this.boxCny.Size = new System.Drawing.Size(212, 27);
            this.boxCny.TabIndex = 12;
            this.boxCny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "EUR";
            // 
            // boxEur
            // 
            this.boxEur.Location = new System.Drawing.Point(300, 108);
            this.boxEur.Margin = new System.Windows.Forms.Padding(4);
            this.boxEur.Name = "boxEur";
            this.boxEur.ReadOnly = true;
            this.boxEur.Size = new System.Drawing.Size(212, 27);
            this.boxEur.TabIndex = 14;
            this.boxEur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxEur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxCny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.boxUsd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxCop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "convMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Divisas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxCop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox boxUsd;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxCny;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxEur;
    }
}