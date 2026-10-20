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
            txtAnimal = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtScore = new TextBox();
            btnAdd = new Button();
            dgvAnimals = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSummary = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSave = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            txtHousing = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtStatus = new TextBox();
            label8 = new Label();
            txtTotal = new TextBox();
            txtAvgAge = new TextBox();
            label9 = new Label();
            txtAvgScore = new TextBox();
            label10 = new Label();
            txtCritical = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtSerious = new TextBox();
            label14 = new Label();
            txtStable = new TextBox();
            label15 = new Label();
            txtReady = new TextBox();
            label16 = new Label();
            TxtRecover = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Animal ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 71);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 100);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Species";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 129);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 158);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Recovery Score";
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(152, 42);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(216, 23);
            txtAnimal.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 23);
            txtName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(150, 100);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(218, 23);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(151, 129);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(217, 23);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(151, 158);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(216, 23);
            txtScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 22);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.Dock = DockStyle.Right;
            dgvAnimals.Location = new Point(472, 0);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.RowTemplate.Height = 24;
            dgvAnimals.Size = new Size(766, 631);
            dgvAnimals.TabIndex = 11;
            dgvAnimals.CellClick += dgvAnimals_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(153, 252);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 22);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(225, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 22);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(297, 252);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(66, 22);
            btnSummary.TabIndex = 15;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 302);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(216, 23);
            txtSearch.TabIndex = 16;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(11, 305);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 15);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Search ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(15, 366);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(66, 22);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(300, 366);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(66, 22);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(105, 331);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 22);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtHousing
            // 
            txtHousing.Location = new Point(151, 216);
            txtHousing.Name = "txtHousing";
            txtHousing.ReadOnly = true;
            txtHousing.Size = new Size(216, 23);
            txtHousing.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 216);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 22;
            label6.Text = "housing Unit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 187);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 24;
            label7.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(150, 187);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(216, 23);
            txtStatus.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 470);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 26;
            label8.Text = "Total animals";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(132, 470);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 27;
            // 
            // txtAvgAge
            // 
            txtAvgAge.Location = new Point(132, 499);
            txtAvgAge.Name = "txtAvgAge";
            txtAvgAge.ReadOnly = true;
            txtAvgAge.Size = new Size(100, 23);
            txtAvgAge.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 499);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 28;
            label9.Text = "avg Age";
            // 
            // txtAvgScore
            // 
            txtAvgScore.Location = new Point(132, 528);
            txtAvgScore.Name = "txtAvgScore";
            txtAvgScore.ReadOnly = true;
            txtAvgScore.Size = new Size(100, 23);
            txtAvgScore.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 528);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 30;
            label10.Text = "avg Recovery Score";
            // 
            // txtCritical
            // 
            txtCritical.Location = new Point(336, 475);
            txtCritical.Name = "txtCritical";
            txtCritical.ReadOnly = true;
            txtCritical.Size = new Size(100, 23);
            txtCritical.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(247, 446);
            label11.Name = "label11";
            label11.Size = new Size(181, 15);
            label11.TabIndex = 32;
            label11.Text = "Number of animals in each Satus";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(247, 478);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 34;
            label12.Text = "Critical";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(247, 507);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 36;
            label13.Text = "Serious";
            // 
            // txtSerious
            // 
            txtSerious.Location = new Point(336, 504);
            txtSerious.Name = "txtSerious";
            txtSerious.ReadOnly = true;
            txtSerious.Size = new Size(100, 23);
            txtSerious.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(247, 536);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 38;
            label14.Text = "Stable";
            // 
            // txtStable
            // 
            txtStable.Location = new Point(336, 533);
            txtStable.Name = "txtStable";
            txtStable.ReadOnly = true;
            txtStable.Size = new Size(100, 23);
            txtStable.TabIndex = 37;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(247, 594);
            label15.Name = "label15";
            label15.Size = new Size(83, 15);
            label15.TabIndex = 40;
            label15.Text = "Release-Ready";
            // 
            // txtReady
            // 
            txtReady.Location = new Point(336, 591);
            txtReady.Name = "txtReady";
            txtReady.ReadOnly = true;
            txtReady.Size = new Size(100, 23);
            txtReady.TabIndex = 39;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(247, 565);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 42;
            label16.Text = "Recovering";
            // 
            // TxtRecover
            // 
            TxtRecover.Location = new Point(336, 562);
            TxtRecover.Name = "TxtRecover";
            TxtRecover.ReadOnly = true;
            TxtRecover.Size = new Size(100, 23);
            TxtRecover.TabIndex = 41;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1238, 631);
            Controls.Add(label16);
            Controls.Add(TxtRecover);
            Controls.Add(label15);
            Controls.Add(txtReady);
            Controls.Add(label14);
            Controls.Add(txtStable);
            Controls.Add(label13);
            Controls.Add(txtSerious);
            Controls.Add(label12);
            Controls.Add(txtCritical);
            Controls.Add(label11);
            Controls.Add(txtAvgScore);
            Controls.Add(label10);
            Controls.Add(txtAvgAge);
            Controls.Add(label9);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtHousing);
            Controls.Add(btnSearch);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSummary);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvAnimals);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSummary;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSave;
        private Button btnExit;
        private Button btnSearch;
        private TextBox txtHousing;
        private Label label6;
        private Label label7;
        private TextBox txtStatus;
        private Label label8;
        private TextBox txtTotal;
        private TextBox txtAvgAge;
        private Label label9;
        private TextBox txtAvgScore;
        private Label label10;
        private TextBox txtCritical;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtSerious;
        private Label label14;
        private TextBox txtStable;
        private Label label15;
        private TextBox txtReady;
        private Label label16;
        private TextBox TxtRecover;
    }
}

