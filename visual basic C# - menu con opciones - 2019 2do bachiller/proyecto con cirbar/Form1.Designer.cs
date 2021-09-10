namespace proyecto_con_cirbar
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
            this.components = new System.ComponentModel.Container();
            this.iTalk_ProgressBar1 = new iTalk.iTalk_ProgressBar();
            this.iTalk_TextBox_Small1 = new iTalk.iTalk_TextBox_Small();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iTalk_ProgressBar1
            // 
            this.iTalk_ProgressBar1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iTalk_ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iTalk_ProgressBar1.ForeColor = System.Drawing.Color.Coral;
            this.iTalk_ProgressBar1.Location = new System.Drawing.Point(128, 26);
            this.iTalk_ProgressBar1.Maximum = ((long)(100));
            this.iTalk_ProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.iTalk_ProgressBar1.Name = "iTalk_ProgressBar1";
            this.iTalk_ProgressBar1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.iTalk_ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.iTalk_ProgressBar1.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
            this.iTalk_ProgressBar1.Size = new System.Drawing.Size(154, 154);
            this.iTalk_ProgressBar1.TabIndex = 0;
            this.iTalk_ProgressBar1.Text = "iTalk_ProgressBar1";
            this.iTalk_ProgressBar1.Value = ((long)(0));
            // 
            // iTalk_TextBox_Small1
            // 
            this.iTalk_TextBox_Small1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_TextBox_Small1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.iTalk_TextBox_Small1.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_TextBox_Small1.Location = new System.Drawing.Point(160, 247);
            this.iTalk_TextBox_Small1.MaxLength = 32767;
            this.iTalk_TextBox_Small1.Multiline = false;
            this.iTalk_TextBox_Small1.Name = "iTalk_TextBox_Small1";
            this.iTalk_TextBox_Small1.ReadOnly = false;
            this.iTalk_TextBox_Small1.Size = new System.Drawing.Size(135, 28);
            this.iTalk_TextBox_Small1.TabIndex = 1;
            this.iTalk_TextBox_Small1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.iTalk_TextBox_Small1.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "contraseña";
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(160, 375);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(144, 65);
            this.iTalk_Button_21.TabIndex = 7;
            this.iTalk_Button_21.Text = "entrar al mejor programa";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(401, 499);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iTalk_TextBox_Small1);
            this.Controls.Add(this.iTalk_ProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_ProgressBar iTalk_ProgressBar1;
        private iTalk.iTalk_TextBox_Small iTalk_TextBox_Small1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

