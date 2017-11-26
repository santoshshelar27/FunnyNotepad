namespace FunnyNotepad
{
    partial class Form1
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInput.Location = new System.Drawing.Point(0, 0);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(618, 469);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
            this.rtbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbInput_KeyDown);
            this.rtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbInput_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 469);
            this.Controls.Add(this.rtbInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funny Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
    }
}

