
namespace HotelManagementSystem.UI
{
    partial class CustomerWinForm
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
            this.viewMenuBtn = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddReviewBtn = new System.Windows.Forms.Button();
            this.billDividerBtn = new System.Windows.Forms.Button();
            this.tipCalculatorBtn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tip_Calculator1 = new HotelManagementSystem.UI.Tip_Calculator();
            this.menuUC1 = new HotelManagementSystem.MenuUC();
            this.billDividerUC1 = new HotelManagementSystem.UI.BillDividerUC();
            this.addReviewUC1 = new HotelManagementSystem.UI.AddReviewUC();
            this.SuspendLayout();
            // 
            // viewMenuBtn
            // 
            this.viewMenuBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.viewMenuBtn.FlatAppearance.BorderSize = 0;
            this.viewMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMenuBtn.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenuBtn.ForeColor = System.Drawing.Color.Black;
            this.viewMenuBtn.Location = new System.Drawing.Point(619, 233);
            this.viewMenuBtn.Name = "viewMenuBtn";
            this.viewMenuBtn.Size = new System.Drawing.Size(169, 35);
            this.viewMenuBtn.TabIndex = 0;
            this.viewMenuBtn.Text = "View Menu";
            this.viewMenuBtn.UseVisualStyleBackColor = false;
            this.viewMenuBtn.Click += new System.EventHandler(this.viewMenuBtn_Click);
            // 
            // Customers
            // 
            this.Customers.AutoSize = true;
            this.Customers.BackColor = System.Drawing.Color.BurlyWood;
            this.Customers.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Location = new System.Drawing.Point(327, 175);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(216, 45);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Location = new System.Drawing.Point(379, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 170);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Location = new System.Drawing.Point(457, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 170);
            this.panel2.TabIndex = 3;
            // 
            // AddReviewBtn
            // 
            this.AddReviewBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.AddReviewBtn.FlatAppearance.BorderSize = 0;
            this.AddReviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReviewBtn.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddReviewBtn.ForeColor = System.Drawing.Color.Black;
            this.AddReviewBtn.Location = new System.Drawing.Point(619, 295);
            this.AddReviewBtn.Name = "AddReviewBtn";
            this.AddReviewBtn.Size = new System.Drawing.Size(169, 35);
            this.AddReviewBtn.TabIndex = 4;
            this.AddReviewBtn.Text = "Add Review";
            this.AddReviewBtn.UseVisualStyleBackColor = false;
            this.AddReviewBtn.Click += new System.EventHandler(this.AddReviewBtn_Click);
            // 
            // billDividerBtn
            // 
            this.billDividerBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.billDividerBtn.FlatAppearance.BorderSize = 0;
            this.billDividerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billDividerBtn.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDividerBtn.ForeColor = System.Drawing.Color.Black;
            this.billDividerBtn.Location = new System.Drawing.Point(619, 357);
            this.billDividerBtn.Name = "billDividerBtn";
            this.billDividerBtn.Size = new System.Drawing.Size(169, 35);
            this.billDividerBtn.TabIndex = 5;
            this.billDividerBtn.Text = "Bill Divider";
            this.billDividerBtn.UseVisualStyleBackColor = false;
            this.billDividerBtn.Click += new System.EventHandler(this.billDividerBtn_Click);
            // 
            // tipCalculatorBtn
            // 
            this.tipCalculatorBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.tipCalculatorBtn.FlatAppearance.BorderSize = 0;
            this.tipCalculatorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipCalculatorBtn.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipCalculatorBtn.ForeColor = System.Drawing.Color.Black;
            this.tipCalculatorBtn.Location = new System.Drawing.Point(619, 420);
            this.tipCalculatorBtn.Name = "tipCalculatorBtn";
            this.tipCalculatorBtn.Size = new System.Drawing.Size(169, 35);
            this.tipCalculatorBtn.TabIndex = 6;
            this.tipCalculatorBtn.Text = "Tip Calculate";
            this.tipCalculatorBtn.UseVisualStyleBackColor = false;
            this.tipCalculatorBtn.Click += new System.EventHandler(this.tipCalculatorBtn_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.BurlyWood;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(619, 481);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(169, 35);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BurlyWood;
            this.panel3.Location = new System.Drawing.Point(660, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 495);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BurlyWood;
            this.panel4.Location = new System.Drawing.Point(767, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 495);
            this.panel4.TabIndex = 4;
            // 
            // tip_Calculator1
            // 
            this.tip_Calculator1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tip_Calculator1.Location = new System.Drawing.Point(-3, 2);
            this.tip_Calculator1.Name = "tip_Calculator1";
            this.tip_Calculator1.Size = new System.Drawing.Size(804, 546);
            this.tip_Calculator1.TabIndex = 11;
            // 
            // menuUC1
            // 
            this.menuUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuUC1.Location = new System.Drawing.Point(-3, -4);
            this.menuUC1.Name = "menuUC1";
            this.menuUC1.Size = new System.Drawing.Size(804, 552);
            this.menuUC1.TabIndex = 8;
            this.menuUC1.Load += new System.EventHandler(this.menuUC1_Load);
            // 
            // billDividerUC1
            // 
            this.billDividerUC1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.billDividerUC1.Location = new System.Drawing.Point(-3, -4);
            this.billDividerUC1.Name = "billDividerUC1";
            this.billDividerUC1.Size = new System.Drawing.Size(804, 546);
            this.billDividerUC1.TabIndex = 12;
            // 
            // addReviewUC1
            // 
            this.addReviewUC1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addReviewUC1.Location = new System.Drawing.Point(-3, -4);
            this.addReviewUC1.Name = "addReviewUC1";
            this.addReviewUC1.Size = new System.Drawing.Size(804, 546);
            this.addReviewUC1.TabIndex = 13;
            // 
            // CustomerWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.CustomerBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tipCalculatorBtn);
            this.Controls.Add(this.billDividerBtn);
            this.Controls.Add(this.AddReviewBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.viewMenuBtn);
            this.Controls.Add(this.menuUC1);
            this.Controls.Add(this.tip_Calculator1);
            this.Controls.Add(this.billDividerUC1);
            this.Controls.Add(this.addReviewUC1);
            this.MaximumSize = new System.Drawing.Size(816, 582);
            this.MinimumSize = new System.Drawing.Size(816, 582);
            this.Name = "CustomerWinForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CustomerWinForm";
            this.Load += new System.EventHandler(this.CustomerWinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewMenuBtn;
        private System.Windows.Forms.Label Customers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddReviewBtn;
        private System.Windows.Forms.Button billDividerBtn;
        private System.Windows.Forms.Button tipCalculatorBtn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MenuUC menuUC1;
        private Tip_Calculator tip_Calculator1;
        private BillDividerUC billDividerUC1;
        private AddReviewUC addReviewUC1;
    }
}