namespace baharfinalsudesonmez
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cdatabase = new System.Windows.Forms.Button();
            this.ctable = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.deleteccolumn = new System.Windows.Forms.Button();
            this.cleartable = new System.Windows.Forms.Button();
            this.addnewrow = new System.Windows.Forms.Button();
            this.clearcell = new System.Windows.Forms.Button();
            this.deletecrow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.create_database = new System.Windows.Forms.TextBox();
            this.create_table = new System.Windows.Forms.TextBox();
            this.add_column = new System.Windows.Forms.TextBox();
            this.update_cell = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.deletedata = new System.Windows.Forms.Button();
            this.deletetable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(509, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "List of Databases";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Update Cell";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(720, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "List of Tables";
            // 
            // cdatabase
            // 
            this.cdatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cdatabase.Location = new System.Drawing.Point(317, 39);
            this.cdatabase.Name = "cdatabase";
            this.cdatabase.Size = new System.Drawing.Size(106, 41);
            this.cdatabase.TabIndex = 6;
            this.cdatabase.Text = "Create ";
            this.cdatabase.UseVisualStyleBackColor = false;
            this.cdatabase.Click += new System.EventHandler(this.cdatabase_Click);
            // 
            // ctable
            // 
            this.ctable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ctable.Location = new System.Drawing.Point(317, 115);
            this.ctable.Name = "ctable";
            this.ctable.Size = new System.Drawing.Size(106, 38);
            this.ctable.TabIndex = 6;
            this.ctable.Text = "Create";
            this.ctable.UseVisualStyleBackColor = false;
            this.ctable.Click += new System.EventHandler(this.ctable_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.update.Location = new System.Drawing.Point(317, 269);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 38);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Location = new System.Drawing.Point(317, 196);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(106, 36);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // deleteccolumn
            // 
            this.deleteccolumn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteccolumn.Location = new System.Drawing.Point(30, 437);
            this.deleteccolumn.Name = "deleteccolumn";
            this.deleteccolumn.Size = new System.Drawing.Size(186, 28);
            this.deleteccolumn.TabIndex = 6;
            this.deleteccolumn.Text = "Delete Current Column";
            this.deleteccolumn.UseVisualStyleBackColor = false;
            this.deleteccolumn.Click += new System.EventHandler(this.deleteccolumn_Click);
            // 
            // cleartable
            // 
            this.cleartable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cleartable.Location = new System.Drawing.Point(30, 322);
            this.cleartable.Name = "cleartable";
            this.cleartable.Size = new System.Drawing.Size(141, 28);
            this.cleartable.TabIndex = 6;
            this.cleartable.Text = "Clear Table";
            this.cleartable.UseVisualStyleBackColor = false;
            this.cleartable.Click += new System.EventHandler(this.cleartable_Click);
            // 
            // addnewrow
            // 
            this.addnewrow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addnewrow.Location = new System.Drawing.Point(296, 322);
            this.addnewrow.Name = "addnewrow";
            this.addnewrow.Size = new System.Drawing.Size(141, 28);
            this.addnewrow.TabIndex = 6;
            this.addnewrow.Text = "Add New Row";
            this.addnewrow.UseVisualStyleBackColor = false;
            this.addnewrow.Click += new System.EventHandler(this.addnewrow_Click);
            // 
            // clearcell
            // 
            this.clearcell.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clearcell.Location = new System.Drawing.Point(177, 322);
            this.clearcell.Name = "clearcell";
            this.clearcell.Size = new System.Drawing.Size(103, 28);
            this.clearcell.TabIndex = 6;
            this.clearcell.Text = "Clear Cell";
            this.clearcell.UseVisualStyleBackColor = false;
            this.clearcell.Click += new System.EventHandler(this.clearcell_Click);
            // 
            // deletecrow
            // 
            this.deletecrow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deletecrow.Location = new System.Drawing.Point(30, 386);
            this.deletecrow.Name = "deletecrow";
            this.deletecrow.Size = new System.Drawing.Size(186, 28);
            this.deletecrow.TabIndex = 6;
            this.deletecrow.Text = "Delete Current Row";
            this.deletecrow.UseVisualStyleBackColor = false;
            this.deletecrow.Click += new System.EventHandler(this.deletecrow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 487);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 200);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // create_database
            // 
            this.create_database.Location = new System.Drawing.Point(177, 42);
            this.create_database.Name = "create_database";
            this.create_database.Size = new System.Drawing.Size(100, 22);
            this.create_database.TabIndex = 8;
            // 
            // create_table
            // 
            this.create_table.Location = new System.Drawing.Point(177, 120);
            this.create_table.Name = "create_table";
            this.create_table.Size = new System.Drawing.Size(100, 22);
            this.create_table.TabIndex = 9;
            // 
            // add_column
            // 
            this.add_column.Location = new System.Drawing.Point(179, 199);
            this.add_column.Name = "add_column";
            this.add_column.Size = new System.Drawing.Size(100, 22);
            this.add_column.TabIndex = 10;
            // 
            // update_cell
            // 
            this.update_cell.Location = new System.Drawing.Point(166, 272);
            this.update_cell.Name = "update_cell";
            this.update_cell.Size = new System.Drawing.Size(100, 22);
            this.update_cell.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(513, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 276);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(724, 90);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(137, 276);
            this.listBox2.TabIndex = 13;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // deletedata
            // 
            this.deletedata.BackColor = System.Drawing.Color.Red;
            this.deletedata.Location = new System.Drawing.Point(535, 386);
            this.deletedata.Name = "deletedata";
            this.deletedata.Size = new System.Drawing.Size(104, 51);
            this.deletedata.TabIndex = 14;
            this.deletedata.Text = "Delete";
            this.deletedata.UseVisualStyleBackColor = false;
            this.deletedata.Click += new System.EventHandler(this.deletedata_Click);
            // 
            // deletetable
            // 
            this.deletetable.BackColor = System.Drawing.Color.Red;
            this.deletetable.Location = new System.Drawing.Point(741, 386);
            this.deletetable.Name = "deletetable";
            this.deletetable.Size = new System.Drawing.Size(104, 51);
            this.deletetable.TabIndex = 14;
            this.deletetable.Text = "Delete";
            this.deletetable.UseVisualStyleBackColor = false;
            this.deletetable.Click += new System.EventHandler(this.deletetable_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(27, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "MySql Workbench ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 711);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deletetable);
            this.Controls.Add(this.deletedata);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.update_cell);
            this.Controls.Add(this.add_column);
            this.Controls.Add(this.create_table);
            this.Controls.Add(this.create_database);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearcell);
            this.Controls.Add(this.cleartable);
            this.Controls.Add(this.addnewrow);
            this.Controls.Add(this.deletecrow);
            this.Controls.Add(this.deleteccolumn);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.ctable);
            this.Controls.Add(this.cdatabase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mysqlworkbench";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cdatabase;
        private System.Windows.Forms.Button ctable;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button deleteccolumn;
        private System.Windows.Forms.Button cleartable;
        private System.Windows.Forms.Button addnewrow;
        private System.Windows.Forms.Button clearcell;
        private System.Windows.Forms.Button deletecrow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox create_database;
        private System.Windows.Forms.TextBox create_table;
        private System.Windows.Forms.TextBox add_column;
        private System.Windows.Forms.TextBox update_cell;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button deletedata;
        private System.Windows.Forms.Button deletetable;
        private System.Windows.Forms.Label label7;
    }
}

