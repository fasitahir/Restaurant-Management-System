
namespace HotelManagementSystem
{
    partial class UpdateMenuUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearFieldB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addItemB = new System.Windows.Forms.Button();
            this.itemPriceTb = new System.Windows.Forms.TextBox();
            this.itemNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.menuGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.menuGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuGridView.Enabled = false;
            this.menuGridView.Location = new System.Drawing.Point(0, 337);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuGridView.Size = new System.Drawing.Size(598, 209);
            this.menuGridView.TabIndex = 2;
            this.menuGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.menuGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.clearFieldB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addItemB);
            this.panel1.Controls.Add(this.itemPriceTb);
            this.panel1.Controls.Add(this.itemNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 254);
            this.panel1.TabIndex = 4;
            // 
            // clearFieldB
            // 
            this.clearFieldB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearFieldB.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFieldB.ForeColor = System.Drawing.Color.Blue;
            this.clearFieldB.Location = new System.Drawing.Point(132, 219);
            this.clearFieldB.Name = "clearFieldB";
            this.clearFieldB.Size = new System.Drawing.Size(300, 32);
            this.clearFieldB.TabIndex = 25;
            this.clearFieldB.Text = "Clear";
            this.clearFieldB.UseVisualStyleBackColor = false;
            this.clearFieldB.Click += new System.EventHandler(this.clearFieldB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(132, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(132, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 23;
            // 
            // addItemB
            // 
            this.addItemB.BackColor = System.Drawing.Color.RoyalBlue;
            this.addItemB.FlatAppearance.BorderSize = 0;
            this.addItemB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemB.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addItemB.Location = new System.Drawing.Point(132, 143);
            this.addItemB.Name = "addItemB";
            this.addItemB.Size = new System.Drawing.Size(300, 32);
            this.addItemB.TabIndex = 22;
            this.addItemB.Text = "Update Item";
            this.addItemB.UseVisualStyleBackColor = false;
            this.addItemB.Click += new System.EventHandler(this.addItemB_Click);
            // 
            // itemPriceTb
            // 
            this.itemPriceTb.BackColor = System.Drawing.Color.LightGray;
            this.itemPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemPriceTb.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTb.Location = new System.Drawing.Point(132, 100);
            this.itemPriceTb.Multiline = true;
            this.itemPriceTb.Name = "itemPriceTb";
            this.itemPriceTb.Size = new System.Drawing.Size(300, 31);
            this.itemPriceTb.TabIndex = 21;
            // 
            // itemNameTb
            // 
            this.itemNameTb.BackColor = System.Drawing.Color.LightGray;
            this.itemNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemNameTb.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTb.Location = new System.Drawing.Point(132, 32);
            this.itemNameTb.Multiline = true;
            this.itemNameTb.Name = "itemNameTb";
            this.itemNameTb.Size = new System.Drawing.Size(300, 31);
            this.itemNameTb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "New Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = " Name: ";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Location = new System.Drawing.Point(132, 181);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(300, 32);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UpdateMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuGridView);
            this.Name = "UpdateMenuUC";
            this.Size = new System.Drawing.Size(598, 546);
            this.Load += new System.EventHandler(this.UpdateMenuUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addItemB;
        private System.Windows.Forms.TextBox itemPriceTb;
        private System.Windows.Forms.TextBox itemNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearFieldB;
        private System.Windows.Forms.Button deleteButton;
    }
}
