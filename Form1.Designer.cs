namespace BaobabRidge
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAnimalID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtScore = new TextBox();
            btnAdd = new Button();
            dgvAnimals = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSummary = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 108);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Animal ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 160);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 211);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Species";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 264);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 320);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 4;
            label5.Text = "Recovery Score";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(277, 104);
            txtAnimalID.Margin = new Padding(3, 4, 3, 4);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(246, 27);
            txtAnimalID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(274, 152);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 27);
            txtName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(273, 204);
            txtSpecies.Margin = new Padding(3, 4, 3, 4);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(249, 27);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(274, 263);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(247, 27);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(273, 312);
            txtScore.Margin = new Padding(3, 4, 3, 4);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(246, 27);
            txtScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 401);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(572, 68);
            dgvAnimals.Margin = new Padding(3, 4, 3, 4);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.RowTemplate.Height = 24;
            dgvAnimals.Size = new Size(769, 420);
            dgvAnimals.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 401);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(277, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(425, 401);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(94, 29);
            btnSummary.TabIndex = 14;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1379, 563);
            Controls.Add(btnSummary);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvAnimals);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimalID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSummary;
    }
}

