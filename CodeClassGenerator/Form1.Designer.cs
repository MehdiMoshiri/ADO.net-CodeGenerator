namespace CodeClassGenerator
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
            this.txt_output_1 = new System.Windows.Forms.TextBox();
            this.btn_copy1 = new System.Windows.Forms.Button();
            this.txt_nameClass = new System.Windows.Forms.TextBox();
            this.txt_nametable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.list_tables = new System.Windows.Forms.ListBox();
            this.lbl_server = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.dataSet11 = new CodeClassGenerator.DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reload = new System.Windows.Forms.Button();
            this.rad_t = new System.Windows.Forms.RadioButton();
            this.rad_views = new System.Windows.Forms.RadioButton();
            this.rad_b = new System.Windows.Forms.RadioButton();
            this.com_db = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.rad_class = new System.Windows.Forms.RadioButton();
            this.rad_id = new System.Windows.Forms.RadioButton();
            this.rad_title = new System.Windows.Forms.RadioButton();
            this.rad_titlefull = new System.Windows.Forms.RadioButton();
            this.rad_update = new System.Windows.Forms.RadioButton();
            this.rad_updatefull = new System.Windows.Forms.RadioButton();
            this.rad_insert = new System.Windows.Forms.RadioButton();
            this.rad_insertfull = new System.Windows.Forms.RadioButton();
            this.rad_insertfullOut = new System.Windows.Forms.RadioButton();
            this.btn_generate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rad_classApi = new System.Windows.Forms.RadioButton();
            this.rad_create = new System.Windows.Forms.RadioButton();
            this.rad_classTtoC = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_output_1
            // 
            this.txt_output_1.Location = new System.Drawing.Point(684, 137);
            this.txt_output_1.Multiline = true;
            this.txt_output_1.Name = "txt_output_1";
            this.txt_output_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output_1.Size = new System.Drawing.Size(203, 308);
            this.txt_output_1.TabIndex = 25;
            // 
            // btn_copy1
            // 
            this.btn_copy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_copy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy1.Location = new System.Drawing.Point(541, 412);
            this.btn_copy1.Name = "btn_copy1";
            this.btn_copy1.Size = new System.Drawing.Size(131, 33);
            this.btn_copy1.TabIndex = 0;
            this.btn_copy1.Text = "copy";
            this.btn_copy1.UseVisualStyleBackColor = false;
            this.btn_copy1.Click += new System.EventHandler(this.btn_copy1_Click);
            // 
            // txt_nameClass
            // 
            this.txt_nameClass.Location = new System.Drawing.Point(684, 38);
            this.txt_nameClass.Name = "txt_nameClass";
            this.txt_nameClass.Size = new System.Drawing.Size(150, 20);
            this.txt_nameClass.TabIndex = 20;
            // 
            // txt_nametable
            // 
            this.txt_nametable.Location = new System.Drawing.Point(684, 86);
            this.txt_nametable.Name = "txt_nametable";
            this.txt_nametable.Size = new System.Drawing.Size(150, 20);
            this.txt_nametable.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "class name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "table name";
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(541, 377);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(131, 33);
            this.btn_new.TabIndex = 27;
            this.btn_new.Text = "new";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(686, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "output Code";
            // 
            // list_tables
            // 
            this.list_tables.FormattingEnabled = true;
            this.list_tables.Location = new System.Drawing.Point(346, 34);
            this.list_tables.Name = "list_tables";
            this.list_tables.Size = new System.Drawing.Size(163, 420);
            this.list_tables.TabIndex = 7;
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_server.Location = new System.Drawing.Point(68, 31);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(48, 17);
            this.lbl_server.TabIndex = 0;
            this.lbl_server.Text = "server";
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(123, 26);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(154, 26);
            this.txt_server.TabIndex = 1;
            this.txt_server.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Database Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "User Password";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(123, 116);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(154, 26);
            this.txt_password.TabIndex = 8;
            this.txt_password.Text = "15421";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "User ";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(123, 86);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(154, 26);
            this.txt_user.TabIndex = 6;
            this.txt_user.Text = "sa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Objects";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(123, 191);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(118, 33);
            this.btn_load.TabIndex = 12;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADO.net Code Ganarator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reload);
            this.groupBox1.Controls.Add(this.rad_t);
            this.groupBox1.Controls.Add(this.rad_views);
            this.groupBox1.Controls.Add(this.rad_b);
            this.groupBox1.Controls.Add(this.com_db);
            this.groupBox1.Controls.Add(this.lbl_server);
            this.groupBox1.Controls.Add(this.txt_server);
            this.groupBox1.Controls.Add(this.btn_load);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect To Server (SQL Server)";
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.White;
            this.btn_reload.BackgroundImage = global::CodeClassGenerator.Properties.Resources.reload;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Location = new System.Drawing.Point(281, 55);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(26, 28);
            this.btn_reload.TabIndex = 4;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // rad_t
            // 
            this.rad_t.AutoSize = true;
            this.rad_t.Checked = true;
            this.rad_t.Location = new System.Drawing.Point(166, 160);
            this.rad_t.Name = "rad_t";
            this.rad_t.Size = new System.Drawing.Size(57, 17);
            this.rad_t.TabIndex = 11;
            this.rad_t.TabStop = true;
            this.rad_t.Text = "Tables";
            this.rad_t.UseVisualStyleBackColor = true;
            // 
            // rad_views
            // 
            this.rad_views.AutoSize = true;
            this.rad_views.Location = new System.Drawing.Point(93, 160);
            this.rad_views.Name = "rad_views";
            this.rad_views.Size = new System.Drawing.Size(53, 17);
            this.rad_views.TabIndex = 10;
            this.rad_views.Text = "Views";
            this.rad_views.UseVisualStyleBackColor = true;
            // 
            // rad_b
            // 
            this.rad_b.AutoSize = true;
            this.rad_b.Location = new System.Drawing.Point(16, 160);
            this.rad_b.Name = "rad_b";
            this.rad_b.Size = new System.Drawing.Size(47, 17);
            this.rad_b.TabIndex = 9;
            this.rad_b.Text = "Both";
            this.rad_b.UseVisualStyleBackColor = true;
            // 
            // com_db
            // 
            this.com_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_db.FormattingEnabled = true;
            this.com_db.Location = new System.Drawing.Point(123, 55);
            this.com_db.Name = "com_db";
            this.com_db.Size = new System.Drawing.Size(154, 28);
            this.com_db.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(840, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "copy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(840, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 33);
            this.button2.TabIndex = 22;
            this.button2.Text = "copy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(15, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 33);
            this.button7.TabIndex = 2;
            this.button7.Text = "Insert K i";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(15, 325);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 33);
            this.button8.TabIndex = 3;
            this.button8.Text = "Excute Bool out";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // rad_class
            // 
            this.rad_class.AutoSize = true;
            this.rad_class.Checked = true;
            this.rad_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_class.Location = new System.Drawing.Point(525, 3);
            this.rad_class.Name = "rad_class";
            this.rad_class.Size = new System.Drawing.Size(112, 21);
            this.rad_class.TabIndex = 8;
            this.rad_class.TabStop = true;
            this.rad_class.Text = "Class Norml";
            this.rad_class.UseVisualStyleBackColor = true;
            // 
            // rad_id
            // 
            this.rad_id.AutoSize = true;
            this.rad_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_id.Location = new System.Drawing.Point(525, 87);
            this.rad_id.Name = "rad_id";
            this.rad_id.Size = new System.Drawing.Size(136, 21);
            this.rad_id.TabIndex = 11;
            this.rad_id.Text = "select by id full";
            this.rad_id.UseVisualStyleBackColor = true;
            // 
            // rad_title
            // 
            this.rad_title.AutoSize = true;
            this.rad_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_title.Location = new System.Drawing.Point(525, 59);
            this.rad_title.Name = "rad_title";
            this.rad_title.Size = new System.Drawing.Size(123, 21);
            this.rad_title.TabIndex = 10;
            this.rad_title.Text = "select by title";
            this.rad_title.UseVisualStyleBackColor = true;
            // 
            // rad_titlefull
            // 
            this.rad_titlefull.AutoSize = true;
            this.rad_titlefull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_titlefull.Location = new System.Drawing.Point(525, 115);
            this.rad_titlefull.Name = "rad_titlefull";
            this.rad_titlefull.Size = new System.Drawing.Size(150, 21);
            this.rad_titlefull.TabIndex = 12;
            this.rad_titlefull.Text = "select by title full";
            this.rad_titlefull.UseVisualStyleBackColor = true;
            // 
            // rad_update
            // 
            this.rad_update.AutoSize = true;
            this.rad_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_update.Location = new System.Drawing.Point(525, 143);
            this.rad_update.Name = "rad_update";
            this.rad_update.Size = new System.Drawing.Size(78, 21);
            this.rad_update.TabIndex = 13;
            this.rad_update.Text = "Update";
            this.rad_update.UseVisualStyleBackColor = true;
            // 
            // rad_updatefull
            // 
            this.rad_updatefull.AutoSize = true;
            this.rad_updatefull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_updatefull.Location = new System.Drawing.Point(525, 171);
            this.rad_updatefull.Name = "rad_updatefull";
            this.rad_updatefull.Size = new System.Drawing.Size(105, 21);
            this.rad_updatefull.TabIndex = 14;
            this.rad_updatefull.Text = "Update full";
            this.rad_updatefull.UseVisualStyleBackColor = true;
            // 
            // rad_insert
            // 
            this.rad_insert.AutoSize = true;
            this.rad_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_insert.Location = new System.Drawing.Point(525, 199);
            this.rad_insert.Name = "rad_insert";
            this.rad_insert.Size = new System.Drawing.Size(67, 21);
            this.rad_insert.TabIndex = 15;
            this.rad_insert.Text = "Insert";
            this.rad_insert.UseVisualStyleBackColor = true;
            // 
            // rad_insertfull
            // 
            this.rad_insertfull.AutoSize = true;
            this.rad_insertfull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_insertfull.Location = new System.Drawing.Point(525, 227);
            this.rad_insertfull.Name = "rad_insertfull";
            this.rad_insertfull.Size = new System.Drawing.Size(94, 21);
            this.rad_insertfull.TabIndex = 16;
            this.rad_insertfull.Text = "Insert full";
            this.rad_insertfull.UseVisualStyleBackColor = true;
            // 
            // rad_insertfullOut
            // 
            this.rad_insertfullOut.AutoSize = true;
            this.rad_insertfullOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_insertfullOut.Location = new System.Drawing.Point(525, 255);
            this.rad_insertfullOut.Name = "rad_insertfullOut";
            this.rad_insertfullOut.Size = new System.Drawing.Size(140, 21);
            this.rad_insertfullOut.TabIndex = 17;
            this.rad_insertfullOut.Text = "Insert full out id";
            this.rad_insertfullOut.UseVisualStyleBackColor = true;
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(541, 342);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(131, 33);
            this.btn_generate.TabIndex = 26;
            this.btn_generate.Text = "Run";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(15, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "ForLoopGetData";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rad_classApi
            // 
            this.rad_classApi.AutoSize = true;
            this.rad_classApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_classApi.Location = new System.Drawing.Point(525, 31);
            this.rad_classApi.Name = "rad_classApi";
            this.rad_classApi.Size = new System.Drawing.Size(93, 21);
            this.rad_classApi.TabIndex = 9;
            this.rad_classApi.Text = "Class Api";
            this.rad_classApi.UseVisualStyleBackColor = true;
            // 
            // rad_create
            // 
            this.rad_create.AutoSize = true;
            this.rad_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_create.Location = new System.Drawing.Point(525, 283);
            this.rad_create.Name = "rad_create";
            this.rad_create.Size = new System.Drawing.Size(79, 21);
            this.rad_create.TabIndex = 28;
            this.rad_create.Text = "Create ";
            this.rad_create.UseVisualStyleBackColor = true;
            // 
            // rad_classTtoC
            // 
            this.rad_classTtoC.AutoSize = true;
            this.rad_classTtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_classTtoC.Location = new System.Drawing.Point(525, 311);
            this.rad_classTtoC.Name = "rad_classTtoC";
            this.rad_classTtoC.Size = new System.Drawing.Size(112, 21);
            this.rad_classTtoC.TabIndex = 29;
            this.rad_classTtoC.Text = "class T to C";
            this.rad_classTtoC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 460);
            this.Controls.Add(this.rad_classTtoC);
            this.Controls.Add(this.rad_create);
            this.Controls.Add(this.rad_classApi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.rad_insertfullOut);
            this.Controls.Add(this.rad_insertfull);
            this.Controls.Add(this.rad_insert);
            this.Controls.Add(this.rad_updatefull);
            this.Controls.Add(this.rad_update);
            this.Controls.Add(this.rad_titlefull);
            this.Controls.Add(this.rad_title);
            this.Controls.Add(this.rad_id);
            this.Controls.Add(this.rad_class);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.list_tables);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nametable);
            this.Controls.Add(this.txt_nameClass);
            this.Controls.Add(this.btn_copy1);
            this.Controls.Add(this.txt_output_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_output_1;
        private System.Windows.Forms.Button btn_copy1;
        private System.Windows.Forms.TextBox txt_nameClass;
        private System.Windows.Forms.TextBox txt_nametable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_tables;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_load;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox com_db;
        private System.Windows.Forms.RadioButton rad_t;
        private System.Windows.Forms.RadioButton rad_views;
        private System.Windows.Forms.RadioButton rad_b;
        private System.Windows.Forms.RadioButton rad_class;
        private System.Windows.Forms.RadioButton rad_id;
        private System.Windows.Forms.RadioButton rad_title;
        private System.Windows.Forms.RadioButton rad_titlefull;
        private System.Windows.Forms.RadioButton rad_update;
        private System.Windows.Forms.RadioButton rad_updatefull;
        private System.Windows.Forms.RadioButton rad_insert;
        private System.Windows.Forms.RadioButton rad_insertfull;
        private System.Windows.Forms.RadioButton rad_insertfullOut;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.RadioButton rad_classApi;
        private System.Windows.Forms.RadioButton rad_create;
        private System.Windows.Forms.RadioButton rad_classTtoC;
    }
}



 
