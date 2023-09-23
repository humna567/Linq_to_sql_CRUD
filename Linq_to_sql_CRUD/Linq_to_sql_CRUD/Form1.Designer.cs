namespace Linq_to_sql_CRUD
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
            this.label2 = new System.Windows.Forms.Label();
            this.NAMEtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GENDERtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AGEtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CLASStextBox = new System.Windows.Forms.TextBox();
            this.INSERTbutton = new System.Windows.Forms.Button();
            this.UPDATEbutton = new System.Windows.Forms.Button();
            this.DELETEbutton = new System.Windows.Forms.Button();
            this.CLEARbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS DETAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME ";
            // 
            // NAMEtextBox
            // 
            this.NAMEtextBox.Location = new System.Drawing.Point(255, 87);
            this.NAMEtextBox.Name = "NAMEtextBox";
            this.NAMEtextBox.Size = new System.Drawing.Size(161, 23);
            this.NAMEtextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "GENDER";
            // 
            // GENDERtextBox
            // 
            this.GENDERtextBox.Location = new System.Drawing.Point(255, 130);
            this.GENDERtextBox.Name = "GENDERtextBox";
            this.GENDERtextBox.Size = new System.Drawing.Size(161, 23);
            this.GENDERtextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "AGE";
            // 
            // AGEtextBox
            // 
            this.AGEtextBox.Location = new System.Drawing.Point(255, 170);
            this.AGEtextBox.Name = "AGEtextBox";
            this.AGEtextBox.Size = new System.Drawing.Size(161, 23);
            this.AGEtextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "CLASS ";
            // 
            // CLASStextBox
            // 
            this.CLASStextBox.Location = new System.Drawing.Point(255, 217);
            this.CLASStextBox.Name = "CLASStextBox";
            this.CLASStextBox.Size = new System.Drawing.Size(161, 23);
            this.CLASStextBox.TabIndex = 3;
            // 
            // INSERTbutton
            // 
            this.INSERTbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTbutton.Location = new System.Drawing.Point(122, 265);
            this.INSERTbutton.Name = "INSERTbutton";
            this.INSERTbutton.Size = new System.Drawing.Size(99, 47);
            this.INSERTbutton.TabIndex = 4;
            this.INSERTbutton.Text = "INSERT";
            this.INSERTbutton.UseVisualStyleBackColor = true;
            this.INSERTbutton.Click += new System.EventHandler(this.INSERTbutton_Click);
            // 
            // UPDATEbutton
            // 
            this.UPDATEbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbutton.Location = new System.Drawing.Point(237, 265);
            this.UPDATEbutton.Name = "UPDATEbutton";
            this.UPDATEbutton.Size = new System.Drawing.Size(93, 47);
            this.UPDATEbutton.TabIndex = 5;
            this.UPDATEbutton.Text = "UPDATE";
            this.UPDATEbutton.UseVisualStyleBackColor = true;
            this.UPDATEbutton.Click += new System.EventHandler(this.UPDATEbutton_Click);
            // 
            // DELETEbutton
            // 
            this.DELETEbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEbutton.Location = new System.Drawing.Point(345, 265);
            this.DELETEbutton.Name = "DELETEbutton";
            this.DELETEbutton.Size = new System.Drawing.Size(93, 47);
            this.DELETEbutton.TabIndex = 6;
            this.DELETEbutton.Text = "DELETE";
            this.DELETEbutton.UseVisualStyleBackColor = true;
            this.DELETEbutton.Click += new System.EventHandler(this.DELETEbutton_Click);
            // 
            // CLEARbutton
            // 
            this.CLEARbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEARbutton.Location = new System.Drawing.Point(455, 264);
            this.CLEARbutton.Name = "CLEARbutton";
            this.CLEARbutton.Size = new System.Drawing.Size(93, 47);
            this.CLEARbutton.TabIndex = 7;
            this.CLEARbutton.Text = "CLEAR";
            this.CLEARbutton.UseVisualStyleBackColor = true;
            this.CLEARbutton.Click += new System.EventHandler(this.CLEARbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 185);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CLEARbutton);
            this.Controls.Add(this.DELETEbutton);
            this.Controls.Add(this.UPDATEbutton);
            this.Controls.Add(this.INSERTbutton);
            this.Controls.Add(this.CLASStextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AGEtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GENDERtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NAMEtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NAMEtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GENDERtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AGEtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CLASStextBox;
        private System.Windows.Forms.Button INSERTbutton;
        private System.Windows.Forms.Button UPDATEbutton;
        private System.Windows.Forms.Button DELETEbutton;
        private System.Windows.Forms.Button CLEARbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

