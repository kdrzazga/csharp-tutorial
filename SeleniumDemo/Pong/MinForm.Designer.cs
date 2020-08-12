namespace Pong
{
    partial class MinForm
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
            this.mainloop = new System.Windows.Forms.Timer(this.components);
            this.lBat = new System.Windows.Forms.PictureBox();
            this.rBat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rScore_lbl = new System.Windows.Forms.Label();
            this.lScore_lbl = new System.Windows.Forms.Label();
            this.aBall = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBat)).BeginInit();
            this.SuspendLayout();
            // 
            // mainloop
            // 
            this.mainloop.Enabled = true;
            this.mainloop.Interval = 1;
            this.mainloop.Tick += new System.EventHandler(this.mainloop_Tick);
            // 
            // lBat
            // 
            this.lBat.BackColor = System.Drawing.Color.White;
            this.lBat.Location = new System.Drawing.Point(12, 12);
            this.lBat.Name = "lBat";
            this.lBat.Size = new System.Drawing.Size(25, 109);
            this.lBat.TabIndex = 0;
            this.lBat.TabStop = false;
            // 
            // rBat
            // 
            this.rBat.BackColor = System.Drawing.Color.White;
            this.rBat.Location = new System.Drawing.Point(927, 12);
            this.rBat.Name = "rBat";
            this.rBat.Size = new System.Drawing.Size(25, 109);
            this.rBat.TabIndex = 1;
            this.rBat.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // rScore_lbl
            // 
            this.rScore_lbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rScore_lbl.ForeColor = System.Drawing.Color.White;
            this.rScore_lbl.Location = new System.Drawing.Point(488, 40);
            this.rScore_lbl.Name = "rScore_lbl";
            this.rScore_lbl.Size = new System.Drawing.Size(29, 38);
            this.rScore_lbl.TabIndex = 5;
            this.rScore_lbl.Text = "0";
            // 
            // lScore_lbl
            // 
            this.lScore_lbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore_lbl.ForeColor = System.Drawing.Color.White;
            this.lScore_lbl.Location = new System.Drawing.Point(453, 40);
            this.lScore_lbl.Name = "lScore_lbl";
            this.lScore_lbl.Size = new System.Drawing.Size(29, 38);
            this.lScore_lbl.TabIndex = 6;
            this.lScore_lbl.Text = "0";
            // 
            // aBall
            // 
            this.aBall.BackColor = System.Drawing.Color.White;
            this.aBall.Location = new System.Drawing.Point(472, 253);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(20, 20);
            this.aBall.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(964, 527);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lScore_lbl);
            this.Controls.Add(this.rScore_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rBat);
            this.Controls.Add(this.lBat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.lBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer mainloop;
        public System.Windows.Forms.PictureBox lBat;
        public System.Windows.Forms.PictureBox rBat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label rScore_lbl;
        public System.Windows.Forms.Label lScore_lbl;
        private System.Windows.Forms.Panel aBall;
    }
}

