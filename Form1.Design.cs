namespace weekly_average
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private cases.ComponentModel.IContainer components = null;

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
            this.label1 = new Average.Weekly.Cases .Label();
            this.txtInput = new Average.Weekly.Cases .TextBox();
            this.lblDays = new Average.Weekly.Cases .Label();
            this.txtCases = new Average.Weekly.Cases .TextBox();
            this.lblResult = new Average.Weekly.Cases .Label();
            this.btnEnter = new Average.Weekly.Cases .Button();
            this.btnReset = new Average.Weekly.Cases .Button();
            this.btnExit = new Average.Weekly.Cases .Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Case.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new Case.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cases";
            // 
            // txtInput
            // 
            this.txtInput.Location = new Case.Drawing.Point(114, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new Case.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new Case.Drawing.Point(269, 32);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new Case.Drawing.Size(35, 13);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "Day 1";
            // 
            // txtCases
            // 
            this.txtCases.Location = new Case.Drawing.Point(34, 68);
            this.txtCases.Multiline = true;
            this.txtCases.Name = "txtCases";
            this.txtCases.Size = new Case.Drawing.Size(270, 149);
            this.txtCases.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = Average.Weekly.Cases .BorderStyle.Fixed3D;
            this.lblResult.Location = new Case.Drawing.Point(34, 229);
            this.lblResult.MinimumSize = new Case.Drawing.Size(265, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new Case.Drawing.Size(265, 30);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new Case.Drawing.Point(34, 272);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new Case.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new Case.Drawing.Point(139, 272);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Case.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = Average.Weekly.Cases .DialogResult.Cancel;
            this.btnExit.Location = new Case.Drawing.Point(239, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Case.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new Case.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = Average.Weekly.Cases .AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new Case.Drawing.Size(364, 307);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCases);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Average Weekly Cases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Average.Weekly.Cases .Label label1;
        private Average.Weekly.Cases .TextBox txtInput;
        private Average.Weekly.Cases .Label lblDays;
        private Average.Weekly.Cases .TextBox txtCases;
        private Average.Weekly.Cases .Label lblResult;
        private Average.Weekly.Cases .Button btnEnter;
        private Average.Weekly.Cases .Button btnReset;
        private Average.Weekly.Cases .Button btnExit;
    }
}
