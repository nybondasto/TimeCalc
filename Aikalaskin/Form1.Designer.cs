namespace Aikalaskin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kloAlku = new System.Windows.Forms.TextBox();
            this.kloLoppu = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblTulos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "End time:";
            // 
            // kloAlku
            // 
            this.kloAlku.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kloAlku.Location = new System.Drawing.Point(154, 21);
            this.kloAlku.Name = "kloAlku";
            this.kloAlku.Size = new System.Drawing.Size(115, 29);
            this.kloAlku.TabIndex = 2;
            this.kloAlku.Enter += new System.EventHandler(this.EnterEvent);
            this.kloAlku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moveToEnd);
            this.kloAlku.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // kloLoppu
            // 
            this.kloLoppu.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kloLoppu.Location = new System.Drawing.Point(154, 63);
            this.kloLoppu.Name = "kloLoppu";
            this.kloLoppu.Size = new System.Drawing.Size(115, 29);
            this.kloLoppu.TabIndex = 3;
            this.kloLoppu.Enter += new System.EventHandler(this.EnterEvent);
            this.kloLoppu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moveToCalc);
            this.kloLoppu.Leave += new System.EventHandler(this.LeaveEvent);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(293, 21);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 29);
            this.btn.TabIndex = 4;
            this.btn.Text = "CALC";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblTulos
            // 
            this.lblTulos.AutoSize = true;
            this.lblTulos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTulos.Location = new System.Drawing.Point(156, 106);
            this.lblTulos.Name = "lblTulos";
            this.lblTulos.Size = new System.Drawing.Size(25, 22);
            this.lblTulos.TabIndex = 5;
            this.lblTulos.Text = "---";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTulos);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.kloLoppu);
            this.Controls.Add(this.kloAlku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kloAlku;
        private System.Windows.Forms.TextBox kloLoppu;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblTulos;
        private System.Windows.Forms.Button button1;
    }
}

