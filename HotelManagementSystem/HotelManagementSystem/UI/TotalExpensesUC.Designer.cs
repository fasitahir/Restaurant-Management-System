
namespace HotelManagementSystem.UI
{
    partial class TotalExpensesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.otherExpensesTb = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TotalExpenses = new System.Windows.Forms.Label();
            this.otherExpenses = new System.Windows.Forms.Label();
            this.workerExpenses = new System.Windows.Forms.Label();
            this.productExpenses = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 102);
            this.panel1.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.LightGray;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(0, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(64, 25);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(211, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Expenses";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(25, 265);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(194, 30);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addBtn.Location = new System.Drawing.Point(25, 219);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(194, 30);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Other Expenses";
            // 
            // otherExpensesTb
            // 
            this.otherExpensesTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.otherExpensesTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otherExpensesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherExpensesTb.Location = new System.Drawing.Point(12, 171);
            this.otherExpensesTb.Multiline = true;
            this.otherExpensesTb.Name = "otherExpensesTb";
            this.otherExpensesTb.Size = new System.Drawing.Size(218, 20);
            this.otherExpensesTb.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(12, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 2);
            this.panel5.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.otherExpensesTb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 397);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.TotalExpenses);
            this.panel4.Controls.Add(this.otherExpenses);
            this.panel4.Controls.Add(this.workerExpenses);
            this.panel4.Controls.Add(this.productExpenses);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(248, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 397);
            this.panel4.TabIndex = 3;
            // 
            // TotalExpenses
            // 
            this.TotalExpenses.AutoSize = true;
            this.TotalExpenses.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalExpenses.Location = new System.Drawing.Point(54, 219);
            this.TotalExpenses.Name = "TotalExpenses";
            this.TotalExpenses.Size = new System.Drawing.Size(294, 27);
            this.TotalExpenses.TabIndex = 3;
            this.TotalExpenses.Text = "Overall Total Expenses: ";
            // 
            // otherExpenses
            // 
            this.otherExpenses.AutoSize = true;
            this.otherExpenses.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherExpenses.Location = new System.Drawing.Point(53, 171);
            this.otherExpenses.Name = "otherExpenses";
            this.otherExpenses.Size = new System.Drawing.Size(358, 27);
            this.otherExpenses.TabIndex = 2;
            this.otherExpenses.Text = "Total Other Small Expensess:";
            // 
            // workerExpenses
            // 
            this.workerExpenses.AutoSize = true;
            this.workerExpenses.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerExpenses.Location = new System.Drawing.Point(54, 121);
            this.workerExpenses.Name = "workerExpenses";
            this.workerExpenses.Size = new System.Drawing.Size(338, 27);
            this.workerExpenses.TabIndex = 1;
            this.workerExpenses.Text = "Total Expenses on Workers:";
            // 
            // productExpenses
            // 
            this.productExpenses.AutoSize = true;
            this.productExpenses.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productExpenses.Location = new System.Drawing.Point(54, 75);
            this.productExpenses.Name = "productExpenses";
            this.productExpenses.Size = new System.Drawing.Size(351, 27);
            this.productExpenses.TabIndex = 0;
            this.productExpenses.Text = "Total Expenses on Products: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TotalExpensesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TotalExpensesUC";
            this.Size = new System.Drawing.Size(801, 499);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otherExpensesTb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TotalExpenses;
        private System.Windows.Forms.Label otherExpenses;
        private System.Windows.Forms.Label workerExpenses;
        private System.Windows.Forms.Label productExpenses;
        private System.Windows.Forms.Timer timer1;
    }
}
