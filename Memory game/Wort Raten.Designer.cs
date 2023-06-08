namespace Memory_game
{
    partial class Wort_Raten
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
            this.lb_Wort_Raten = new System.Windows.Forms.Label();
            this.lb_Text = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Zahl_Info = new System.Windows.Forms.Label();
            this.lb_Versuche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Wort_Raten
            // 
            this.lb_Wort_Raten.AutoSize = true;
            this.lb_Wort_Raten.BackColor = System.Drawing.Color.Gray;
            this.lb_Wort_Raten.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Wort_Raten.ForeColor = System.Drawing.Color.White;
            this.lb_Wort_Raten.Location = new System.Drawing.Point(307, 20);
            this.lb_Wort_Raten.Name = "lb_Wort_Raten";
            this.lb_Wort_Raten.Size = new System.Drawing.Size(441, 73);
            this.lb_Wort_Raten.TabIndex = 3;
            this.lb_Wort_Raten.Text = "Rate das Wort";
            // 
            // lb_Text
            // 
            this.lb_Text.AutoSize = true;
            this.lb_Text.BackColor = System.Drawing.Color.Gray;
            this.lb_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Text.ForeColor = System.Drawing.Color.White;
            this.lb_Text.Location = new System.Drawing.Point(107, 229);
            this.lb_Text.Name = "lb_Text";
            this.lb_Text.Size = new System.Drawing.Size(256, 73);
            this.lb_Text.TabIndex = 4;
            this.lb_Text.Text = "xxxxxxx";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 47);
            this.textBox1.TabIndex = 5;
            //this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPressed);
            // 
            // lb_Zahl_Info
            // 
            this.lb_Zahl_Info.AutoSize = true;
            this.lb_Zahl_Info.BackColor = System.Drawing.Color.Gray;
            this.lb_Zahl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Zahl_Info.ForeColor = System.Drawing.Color.White;
            this.lb_Zahl_Info.Location = new System.Drawing.Point(539, 753);
            this.lb_Zahl_Info.Name = "lb_Zahl_Info";
            this.lb_Zahl_Info.Size = new System.Drawing.Size(462, 73);
            this.lb_Zahl_Info.TabIndex = 6;
            this.lb_Zahl_Info.Text = "Words: 0 von 0";
            // 
            // lb_Versuche
            // 
            this.lb_Versuche.AutoSize = true;
            this.lb_Versuche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Versuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Versuche.ForeColor = System.Drawing.Color.White;
            this.lb_Versuche.Location = new System.Drawing.Point(545, 699);
            this.lb_Versuche.Name = "lb_Versuche";
            this.lb_Versuche.Size = new System.Drawing.Size(296, 39);
            this.lb_Versuche.TabIndex = 7;
            this.lb_Versuche.Text = "Versuche: 0 times";
            // 
            // Wort_Raten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 835);
            this.Controls.Add(this.lb_Versuche);
            this.Controls.Add(this.lb_Zahl_Info);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Text);
            this.Controls.Add(this.lb_Wort_Raten);
            this.Name = "Wort_Raten";
            this.Text = "Wort_Raten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Wort_Raten;
        private System.Windows.Forms.Label lb_Text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Zahl_Info;
        private System.Windows.Forms.Label lb_Versuche;
    }
}