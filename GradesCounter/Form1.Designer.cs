namespace GradesCounter
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
            this.label1 = new System.Windows.Forms.Label();
            this._numMark = new System.Windows.Forms.NumericUpDown();
            this._btnAdd = new System.Windows.Forms.Button();
            this._lstMarks = new System.Windows.Forms.ListBox();
            this.VysledkyLabel = new System.Windows.Forms.Label();
            this._lblOutput = new System.Windows.Forms.Label();
            this._btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numMark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počítání známek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _numMark
            // 
            this._numMark.Location = new System.Drawing.Point(148, 313);
            this._numMark.Name = "_numMark";
            this._numMark.Size = new System.Drawing.Size(120, 20);
            this._numMark.TabIndex = 1;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(133, 372);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "Přidat";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _lstMarks
            // 
            this._lstMarks.FormattingEnabled = true;
            this._lstMarks.Location = new System.Drawing.Point(157, 88);
            this._lstMarks.Name = "_lstMarks";
            this._lstMarks.Size = new System.Drawing.Size(120, 95);
            this._lstMarks.TabIndex = 3;
            // 
            // VysledkyLabel
            // 
            this.VysledkyLabel.AutoSize = true;
            this.VysledkyLabel.Location = new System.Drawing.Point(145, 207);
            this.VysledkyLabel.Name = "VysledkyLabel";
            this.VysledkyLabel.Size = new System.Drawing.Size(132, 13);
            this.VysledkyLabel.TabIndex = 4;
            this.VysledkyLabel.Text = "Vaše průměrná známka je:";
            // 
            // _lblOutput
            // 
            this._lblOutput.AutoSize = true;
            this._lblOutput.Location = new System.Drawing.Point(190, 246);
            this._lblOutput.Name = "_lblOutput";
            this._lblOutput.Size = new System.Drawing.Size(13, 13);
            this._lblOutput.TabIndex = 5;
            this._lblOutput.Text = "0";
            // 
            // _btnRemove
            // 
            this._btnRemove.Location = new System.Drawing.Point(214, 372);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(75, 23);
            this._btnRemove.TabIndex = 6;
            this._btnRemove.Text = "Odebrat";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this._btnRemove);
            this.Controls.Add(this._lblOutput);
            this.Controls.Add(this.VysledkyLabel);
            this.Controls.Add(this._lstMarks);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._numMark);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._numMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _numMark;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.ListBox _lstMarks;
        private System.Windows.Forms.Label VysledkyLabel;
        private System.Windows.Forms.Label _lblOutput;
        private System.Windows.Forms.Button _btnRemove;
    }
}

