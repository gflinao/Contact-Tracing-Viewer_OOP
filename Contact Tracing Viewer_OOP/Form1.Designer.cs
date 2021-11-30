
namespace Contact_Tracing_Viewer_OOP
{
    partial class TraceViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceViewer));
            this.rTBfield = new System.Windows.Forms.RichTextBox();
            this.lbltrace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnopnfle = new System.Windows.Forms.Button();
            this.btnclrfld = new System.Windows.Forms.Button();
            this.pnlLbl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTBfield
            // 
            this.rTBfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rTBfield.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBfield.ForeColor = System.Drawing.Color.White;
            this.rTBfield.Location = new System.Drawing.Point(12, 121);
            this.rTBfield.Name = "rTBfield";
            this.rTBfield.Size = new System.Drawing.Size(323, 234);
            this.rTBfield.TabIndex = 0;
            this.rTBfield.Text = "";
            this.rTBfield.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbltrace
            // 
            this.lbltrace.AutoSize = true;
            this.lbltrace.BackColor = System.Drawing.Color.Transparent;
            this.lbltrace.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltrace.Location = new System.Drawing.Point(0, 0);
            this.lbltrace.Name = "lbltrace";
            this.lbltrace.Size = new System.Drawing.Size(153, 56);
            this.lbltrace.TabIndex = 1;
            this.lbltrace.Text = "Trace";
            this.lbltrace.Click += new System.EventHandler(this.lbltrace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Tracing Record";
            // 
            // btnopnfle
            // 
            this.btnopnfle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnopnfle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopnfle.ForeColor = System.Drawing.Color.White;
            this.btnopnfle.Location = new System.Drawing.Point(12, 90);
            this.btnopnfle.Name = "btnopnfle";
            this.btnopnfle.Size = new System.Drawing.Size(85, 25);
            this.btnopnfle.TabIndex = 3;
            this.btnopnfle.Text = "Open File";
            this.btnopnfle.UseVisualStyleBackColor = false;
            this.btnopnfle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclrfld
            // 
            this.btnclrfld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclrfld.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclrfld.ForeColor = System.Drawing.Color.White;
            this.btnclrfld.Location = new System.Drawing.Point(103, 90);
            this.btnclrfld.Name = "btnclrfld";
            this.btnclrfld.Size = new System.Drawing.Size(85, 26);
            this.btnclrfld.TabIndex = 4;
            this.btnclrfld.Text = "Clear Field";
            this.btnclrfld.UseVisualStyleBackColor = false;
            this.btnclrfld.Click += new System.EventHandler(this.btnclrfld_Click);
            // 
            // pnlLbl
            // 
            this.pnlLbl.Controls.Add(this.label1);
            this.pnlLbl.Controls.Add(this.lbltrace);
            this.pnlLbl.Location = new System.Drawing.Point(12, 12);
            this.pnlLbl.Name = "pnlLbl";
            this.pnlLbl.Size = new System.Drawing.Size(158, 70);
            this.pnlLbl.TabIndex = 5;
            this.pnlLbl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLbl_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(195, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "#StayHomeSaveLives\r\n#WearMask #StaySafe";
            // 
            // TraceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_Viewer_OOP.Properties.Resources.IMG_1477;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlLbl);
            this.Controls.Add(this.btnclrfld);
            this.Controls.Add(this.btnopnfle);
            this.Controls.Add(this.rTBfield);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraceViewer";
            this.Text = "Trace Viewer";
            this.pnlLbl.ResumeLayout(false);
            this.pnlLbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBfield;
        private System.Windows.Forms.Label lbltrace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnopnfle;
        private System.Windows.Forms.Button btnclrfld;
        private System.Windows.Forms.Panel pnlLbl;
        private System.Windows.Forms.Label label2;
    }
}

