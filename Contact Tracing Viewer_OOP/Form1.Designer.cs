
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
            this.SuspendLayout();
            // 
            // rTBfield
            // 
            this.rTBfield.BackColor = System.Drawing.SystemColors.Window;
            this.rTBfield.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBfield.Location = new System.Drawing.Point(19, 135);
            this.rTBfield.Name = "rTBfield";
            this.rTBfield.Size = new System.Drawing.Size(293, 202);
            this.rTBfield.TabIndex = 0;
            this.rTBfield.Text = "";
            this.rTBfield.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbltrace
            // 
            this.lbltrace.AutoSize = true;
            this.lbltrace.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltrace.Location = new System.Drawing.Point(12, 9);
            this.lbltrace.Name = "lbltrace";
            this.lbltrace.Size = new System.Drawing.Size(153, 56);
            this.lbltrace.TabIndex = 1;
            this.lbltrace.Text = "Trace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 58);
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
            this.btnopnfle.Location = new System.Drawing.Point(19, 89);
            this.btnopnfle.Name = "btnopnfle";
            this.btnopnfle.Size = new System.Drawing.Size(85, 40);
            this.btnopnfle.TabIndex = 3;
            this.btnopnfle.Text = "Open File";
            this.btnopnfle.UseVisualStyleBackColor = false;
            this.btnopnfle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclrfld
            // 
            this.btnclrfld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnclrfld.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclrfld.ForeColor = System.Drawing.Color.White;
            this.btnclrfld.Location = new System.Drawing.Point(110, 89);
            this.btnclrfld.Name = "btnclrfld";
            this.btnclrfld.Size = new System.Drawing.Size(85, 40);
            this.btnclrfld.TabIndex = 4;
            this.btnclrfld.Text = "Clear Field";
            this.btnclrfld.UseVisualStyleBackColor = false;
            this.btnclrfld.Click += new System.EventHandler(this.btnclrfld_Click);
            // 
            // TraceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 367);
            this.Controls.Add(this.btnclrfld);
            this.Controls.Add(this.btnopnfle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltrace);
            this.Controls.Add(this.rTBfield);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraceViewer";
            this.Text = "Trace Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBfield;
        private System.Windows.Forms.Label lbltrace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnopnfle;
        private System.Windows.Forms.Button btnclrfld;
    }
}

