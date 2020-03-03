namespace _200427653A1
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.toonieLabel = new System.Windows.Forms.Label();
            this.loonieLabel = new System.Windows.Forms.Label();
            this.quarterLabel = new System.Windows.Forms.Label();
            this.dimeLabel = new System.Windows.Forms.Label();
            this.nickelLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.TextBox();
            this.toonies = new System.Windows.Forms.TextBox();
            this.loonies = new System.Windows.Forms.TextBox();
            this.quarters = new System.Windows.Forms.TextBox();
            this.dimes = new System.Windows.Forms.TextBox();
            this.nickel = new System.Windows.Forms.TextBox();
            this.opCalculate = new System.Windows.Forms.Button();
            this.opClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(12, 9);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 17);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Location = new System.Drawing.Point(124, 9);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(32, 17);
            this.payLabel.TabIndex = 1;
            this.payLabel.Text = "Pay";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(230, 9);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(57, 17);
            this.changeLabel.TabIndex = 2;
            this.changeLabel.Text = "Change";
            // 
            // toonieLabel
            // 
            this.toonieLabel.AutoSize = true;
            this.toonieLabel.Location = new System.Drawing.Point(12, 96);
            this.toonieLabel.Name = "toonieLabel";
            this.toonieLabel.Size = new System.Drawing.Size(59, 17);
            this.toonieLabel.TabIndex = 3;
            this.toonieLabel.Text = "Toonies";
            // 
            // loonieLabel
            // 
            this.loonieLabel.AutoSize = true;
            this.loonieLabel.Location = new System.Drawing.Point(121, 96);
            this.loonieLabel.Name = "loonieLabel";
            this.loonieLabel.Size = new System.Drawing.Size(58, 17);
            this.loonieLabel.TabIndex = 4;
            this.loonieLabel.Text = "Loonies";
            // 
            // quarterLabel
            // 
            this.quarterLabel.AutoSize = true;
            this.quarterLabel.Location = new System.Drawing.Point(230, 96);
            this.quarterLabel.Name = "quarterLabel";
            this.quarterLabel.Size = new System.Drawing.Size(64, 17);
            this.quarterLabel.TabIndex = 5;
            this.quarterLabel.Text = "Quarters";
            // 
            // dimeLabel
            // 
            this.dimeLabel.AutoSize = true;
            this.dimeLabel.Location = new System.Drawing.Point(336, 96);
            this.dimeLabel.Name = "dimeLabel";
            this.dimeLabel.Size = new System.Drawing.Size(47, 17);
            this.dimeLabel.TabIndex = 6;
            this.dimeLabel.Text = "Dimes";
            // 
            // nickelLabel
            // 
            this.nickelLabel.AutoSize = true;
            this.nickelLabel.Location = new System.Drawing.Point(442, 96);
            this.nickelLabel.Name = "nickelLabel";
            this.nickelLabel.Size = new System.Drawing.Size(53, 17);
            this.nickelLabel.TabIndex = 7;
            this.nickelLabel.Text = "Nickels";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(15, 40);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 22);
            this.total.TabIndex = 8;
            this.total.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(127, 40);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(100, 22);
            this.pay.TabIndex = 9;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(233, 40);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(100, 22);
            this.change.TabIndex = 10;
            this.change.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // toonies
            // 
            this.toonies.Location = new System.Drawing.Point(15, 128);
            this.toonies.Name = "toonies";
            this.toonies.Size = new System.Drawing.Size(100, 22);
            this.toonies.TabIndex = 11;
            // 
            // loonies
            // 
            this.loonies.Location = new System.Drawing.Point(124, 128);
            this.loonies.Name = "loonies";
            this.loonies.Size = new System.Drawing.Size(100, 22);
            this.loonies.TabIndex = 12;
            // 
            // quarters
            // 
            this.quarters.Location = new System.Drawing.Point(233, 128);
            this.quarters.Name = "quarters";
            this.quarters.Size = new System.Drawing.Size(100, 22);
            this.quarters.TabIndex = 13;
            // 
            // dimes
            // 
            this.dimes.Location = new System.Drawing.Point(339, 128);
            this.dimes.Name = "dimes";
            this.dimes.Size = new System.Drawing.Size(100, 22);
            this.dimes.TabIndex = 14;
            // 
            // nickel
            // 
            this.nickel.Location = new System.Drawing.Point(445, 128);
            this.nickel.Name = "nickel";
            this.nickel.Size = new System.Drawing.Size(100, 22);
            this.nickel.TabIndex = 15;
            this.nickel.TextChanged += new System.EventHandler(this.nickel_TextChanged);
            // 
            // opCalculate
            // 
            this.opCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.opCalculate.Location = new System.Drawing.Point(12, 217);
            this.opCalculate.Name = "opCalculate";
            this.opCalculate.Size = new System.Drawing.Size(75, 23);
            this.opCalculate.TabIndex = 16;
            this.opCalculate.Text = "Calculate";
            this.opCalculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.opCalculate.UseVisualStyleBackColor = true;
            this.opCalculate.Click += new System.EventHandler(this.opCalculate_Click);
            // 
            // opClear
            // 
            this.opClear.Location = new System.Drawing.Point(518, 217);
            this.opClear.Name = "opClear";
            this.opClear.Size = new System.Drawing.Size(75, 23);
            this.opClear.TabIndex = 17;
            this.opClear.Text = "Wipe";
            this.opClear.UseVisualStyleBackColor = true;
            this.opClear.Click += new System.EventHandler(this.opClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 252);
            this.Controls.Add(this.opClear);
            this.Controls.Add(this.opCalculate);
            this.Controls.Add(this.nickel);
            this.Controls.Add(this.dimes);
            this.Controls.Add(this.quarters);
            this.Controls.Add(this.loonies);
            this.Controls.Add(this.toonies);
            this.Controls.Add(this.change);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.total);
            this.Controls.Add(this.nickelLabel);
            this.Controls.Add(this.dimeLabel);
            this.Controls.Add(this.quarterLabel);
            this.Controls.Add(this.loonieLabel);
            this.Controls.Add(this.toonieLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.totalLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label toonieLabel;
        private System.Windows.Forms.Label loonieLabel;
        private System.Windows.Forms.Label quarterLabel;
        private System.Windows.Forms.Label dimeLabel;
        private System.Windows.Forms.Label nickelLabel;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox pay;
        private System.Windows.Forms.TextBox change;
        private System.Windows.Forms.TextBox toonies;
        private System.Windows.Forms.TextBox loonies;
        private System.Windows.Forms.TextBox quarters;
        private System.Windows.Forms.TextBox dimes;
        private System.Windows.Forms.TextBox nickel;
        private System.Windows.Forms.Button opCalculate;
        private System.Windows.Forms.Button opClear;
    }
}

