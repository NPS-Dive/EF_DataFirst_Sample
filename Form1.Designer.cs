namespace EF_DataFirst
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
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
            {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteQuery = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCSApprentices = new System.Windows.Forms.Button();
            this.btnNotSC = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnPage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetList = new System.Windows.Forms.Button();
            this.btnGetListTailored = new System.Windows.Forms.Button();
            this.btnSpInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1303, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsert.Location = new System.Drawing.Point(289, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(189, 38);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert Apprentice";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(97, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(159, 34);
            this.txtCode.TabIndex = 4;
            this.txtCode.Enter += new System.EventHandler(this.txtAge_Enter);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            this.txtCode.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 34);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtAge_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(97, 110);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(159, 34);
            this.txtFamily.TabIndex = 6;
            this.txtFamily.TextChanged += new System.EventHandler(this.txtFamily_TextChanged);
            this.txtFamily.Enter += new System.EventHandler(this.txtAge_Enter);
            this.txtFamily.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(97, 154);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(159, 34);
            this.txtAge.TabIndex = 7;
            this.txtAge.Enter += new System.EventHandler(this.txtAge_Enter);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(289, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Edit Apprentice";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(289, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Apprentice";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteQuery
            // 
            this.btnDeleteQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnDeleteQuery.Location = new System.Drawing.Point(6, 32);
            this.btnDeleteQuery.Name = "btnDeleteQuery";
            this.btnDeleteQuery.Size = new System.Drawing.Size(181, 38);
            this.btnDeleteQuery.TabIndex = 4;
            this.btnDeleteQuery.Text = "Delete Query";
            this.btnDeleteQuery.UseVisualStyleBackColor = false;
            this.btnDeleteQuery.Click += new System.EventHandler(this.btnDeleteQuery_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPage);
            this.groupBox2.Controls.Add(this.btnJoin);
            this.groupBox2.Controls.Add(this.btnNotSC);
            this.groupBox2.Controls.Add(this.btnCSApprentices);
            this.groupBox2.Controls.Add(this.btnDeleteQuery);
            this.groupBox2.Location = new System.Drawing.Point(484, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Queries";
            // 
            // btnCSApprentices
            // 
            this.btnCSApprentices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnCSApprentices.Location = new System.Drawing.Point(6, 77);
            this.btnCSApprentices.Name = "btnCSApprentices";
            this.btnCSApprentices.Size = new System.Drawing.Size(181, 38);
            this.btnCSApprentices.TabIndex = 5;
            this.btnCSApprentices.Text = "Selected Course";
            this.btnCSApprentices.UseVisualStyleBackColor = false;
            this.btnCSApprentices.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNotSC
            // 
            this.btnNotSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnNotSC.Location = new System.Drawing.Point(6, 121);
            this.btnNotSC.Name = "btnNotSC";
            this.btnNotSC.Size = new System.Drawing.Size(213, 38);
            this.btnNotSC.TabIndex = 6;
            this.btnNotSC.Text = "Not selected Course";
            this.btnNotSC.UseVisualStyleBackColor = false;
            this.btnNotSC.Click += new System.EventHandler(this.btnNotSC_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnJoin.Location = new System.Drawing.Point(205, 32);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(181, 38);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Join Query";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnPage
            // 
            this.btnPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnPage.Location = new System.Drawing.Point(205, 76);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(181, 38);
            this.btnPage.TabIndex = 8;
            this.btnPage.Text = "Paging Query";
            this.btnPage.UseVisualStyleBackColor = false;
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOutput);
            this.groupBox3.Controls.Add(this.btnSpInput);
            this.groupBox3.Controls.Add(this.btnGetListTailored);
            this.groupBox3.Controls.Add(this.btnGetList);
            this.groupBox3.Location = new System.Drawing.Point(888, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 197);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stored procedures";
            // 
            // btnGetList
            // 
            this.btnGetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetList.Location = new System.Drawing.Point(6, 32);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(138, 38);
            this.btnGetList.TabIndex = 8;
            this.btnGetList.Text = "SP GetList";
            this.btnGetList.UseVisualStyleBackColor = false;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // btnGetListTailored
            // 
            this.btnGetListTailored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetListTailored.Location = new System.Drawing.Point(6, 76);
            this.btnGetListTailored.Name = "btnGetListTailored";
            this.btnGetListTailored.Size = new System.Drawing.Size(138, 38);
            this.btnGetListTailored.TabIndex = 9;
            this.btnGetListTailored.Text = "SP GetList1";
            this.btnGetListTailored.UseVisualStyleBackColor = false;
            this.btnGetListTailored.Click += new System.EventHandler(this.btnGetListTailored_Click);
            // 
            // btnSpInput
            // 
            this.btnSpInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSpInput.Location = new System.Drawing.Point(6, 120);
            this.btnSpInput.Name = "btnSpInput";
            this.btnSpInput.Size = new System.Drawing.Size(138, 38);
            this.btnSpInput.TabIndex = 10;
            this.btnSpInput.Text = "SP Input";
            this.btnSpInput.UseVisualStyleBackColor = false;
            this.btnSpInput.Click += new System.EventHandler(this.btnSpInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btnOutput.Location = new System.Drawing.Point(165, 33);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(138, 38);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.Text = "SP Output";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1303, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Framework: DataFirst";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteQuery;
        private System.Windows.Forms.Button btnCSApprentices;
        private System.Windows.Forms.Button btnNotSC;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.Button btnGetListTailored;
        private System.Windows.Forms.Button btnSpInput;
        private System.Windows.Forms.Button btnOutput;
        }
    }

