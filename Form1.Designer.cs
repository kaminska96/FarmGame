namespace FarmGame
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buy_label = new System.Windows.Forms.Label();
            this.cow_radio_button = new System.Windows.Forms.RadioButton();
            this.sheep_radio_button = new System.Windows.Forms.RadioButton();
            this.chicken_radio_button = new System.Windows.Forms.RadioButton();
            this.v = new System.Windows.Forms.Label();
            this.buy_chicken = new System.Windows.Forms.Label();
            this.buy_sheep = new System.Windows.Forms.Label();
            this.sell_label = new System.Windows.Forms.Label();
            this.buy_cow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.choose_amount = new System.Windows.Forms.ComboBox();
            this.choose_label = new System.Windows.Forms.Label();
            this.buy_button = new System.Windows.Forms.Button();
            this.cost_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.hunger_bar = new System.Windows.Forms.ProgressBar();
            this.health_bar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.moveAnimal = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.c_amount_label = new System.Windows.Forms.Label();
            this.sh_amount_label = new System.Windows.Forms.Label();
            this.ch_amount_label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.day_count_label = new System.Windows.Forms.Label();
            this.sell_button = new System.Windows.Forms.PictureBox();
            this.selling_button = new System.Windows.Forms.PictureBox();
            this.wool_button = new System.Windows.Forms.PictureBox();
            this.health_button = new System.Windows.Forms.PictureBox();
            this.feed_button = new System.Windows.Forms.PictureBox();
            this.milk_button = new System.Windows.Forms.PictureBox();
            this.egg_button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.days_label = new System.Windows.Forms.Label();
            this.bal_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selling_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wool_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feed_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(214)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.selling_button);
            this.panel1.Controls.Add(this.wool_button);
            this.panel1.Controls.Add(this.health_button);
            this.panel1.Controls.Add(this.feed_button);
            this.panel1.Controls.Add(this.milk_button);
            this.panel1.Controls.Add(this.egg_button);
            this.panel1.Location = new System.Drawing.Point(210, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 101);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1088, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // buy_label
            // 
            this.buy_label.AutoSize = true;
            this.buy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_label.Location = new System.Drawing.Point(1265, 9);
            this.buy_label.Name = "buy_label";
            this.buy_label.Size = new System.Drawing.Size(66, 32);
            this.buy_label.TabIndex = 3;
            this.buy_label.Text = "Buy";
            // 
            // cow_radio_button
            // 
            this.cow_radio_button.AutoSize = true;
            this.cow_radio_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cow_radio_button.Location = new System.Drawing.Point(1094, 72);
            this.cow_radio_button.Name = "cow_radio_button";
            this.cow_radio_button.Size = new System.Drawing.Size(68, 29);
            this.cow_radio_button.TabIndex = 4;
            this.cow_radio_button.TabStop = true;
            this.cow_radio_button.Text = "cow";
            this.cow_radio_button.UseVisualStyleBackColor = true;
            this.cow_radio_button.CheckedChanged += new System.EventHandler(this.cow_radio_button_check);
            // 
            // sheep_radio_button
            // 
            this.sheep_radio_button.AutoSize = true;
            this.sheep_radio_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sheep_radio_button.Location = new System.Drawing.Point(1094, 130);
            this.sheep_radio_button.Name = "sheep_radio_button";
            this.sheep_radio_button.Size = new System.Drawing.Size(87, 29);
            this.sheep_radio_button.TabIndex = 5;
            this.sheep_radio_button.TabStop = true;
            this.sheep_radio_button.Text = "sheep";
            this.sheep_radio_button.UseVisualStyleBackColor = true;
            this.sheep_radio_button.CheckedChanged += new System.EventHandler(this.sheep_radio_button_check);
            // 
            // chicken_radio_button
            // 
            this.chicken_radio_button.AutoSize = true;
            this.chicken_radio_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chicken_radio_button.Location = new System.Drawing.Point(1094, 192);
            this.chicken_radio_button.Name = "chicken_radio_button";
            this.chicken_radio_button.Size = new System.Drawing.Size(100, 29);
            this.chicken_radio_button.TabIndex = 6;
            this.chicken_radio_button.TabStop = true;
            this.chicken_radio_button.Text = "chicken";
            this.chicken_radio_button.UseVisualStyleBackColor = true;
            this.chicken_radio_button.CheckedChanged += new System.EventHandler(this.chicken_radio_button_check);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v.Location = new System.Drawing.Point(1266, 74);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(61, 25);
            this.v.TabIndex = 7;
            this.v.Text = "250 $";
            // 
            // buy_chicken
            // 
            this.buy_chicken.AutoSize = true;
            this.buy_chicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_chicken.Location = new System.Drawing.Point(1270, 194);
            this.buy_chicken.Name = "buy_chicken";
            this.buy_chicken.Size = new System.Drawing.Size(50, 25);
            this.buy_chicken.TabIndex = 8;
            this.buy_chicken.Text = "45 $";
            // 
            // buy_sheep
            // 
            this.buy_sheep.AutoSize = true;
            this.buy_sheep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_sheep.Location = new System.Drawing.Point(1270, 132);
            this.buy_sheep.Name = "buy_sheep";
            this.buy_sheep.Size = new System.Drawing.Size(61, 25);
            this.buy_sheep.TabIndex = 9;
            this.buy_sheep.Text = "200 $";
            // 
            // sell_label
            // 
            this.sell_label.AutoSize = true;
            this.sell_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sell_label.Location = new System.Drawing.Point(1404, 9);
            this.sell_label.Name = "sell_label";
            this.sell_label.Size = new System.Drawing.Size(67, 32);
            this.sell_label.TabIndex = 10;
            this.sell_label.Text = "Sell";
            // 
            // buy_cow
            // 
            this.buy_cow.AutoSize = true;
            this.buy_cow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_cow.Location = new System.Drawing.Point(1405, 74);
            this.buy_cow.Name = "buy_cow";
            this.buy_cow.Size = new System.Drawing.Size(61, 25);
            this.buy_cow.TabIndex = 11;
            this.buy_cow.Text = "220 $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1405, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "175 $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1405, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "30 $";
            // 
            // choose_amount
            // 
            this.choose_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_amount.FormattingEnabled = true;
            this.choose_amount.Location = new System.Drawing.Point(1335, 280);
            this.choose_amount.Name = "choose_amount";
            this.choose_amount.Size = new System.Drawing.Size(136, 28);
            this.choose_amount.TabIndex = 14;
            this.choose_amount.SelectedValueChanged += new System.EventHandler(this.comboBox1SelectedVal);
            this.choose_amount.TextChanged += new System.EventHandler(this.comboBox1Text);
            // 
            // choose_label
            // 
            this.choose_label.AutoSize = true;
            this.choose_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_label.Location = new System.Drawing.Point(1160, 240);
            this.choose_label.Name = "choose_label";
            this.choose_label.Size = new System.Drawing.Size(258, 20);
            this.choose_label.TabIndex = 15;
            this.choose_label.Text = "Choose amount of animals to buy";
            // 
            // buy_button
            // 
            this.buy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_button.Location = new System.Drawing.Point(1373, 396);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(98, 36);
            this.buy_button.TabIndex = 16;
            this.buy_button.Text = "BUY";
            this.buy_button.UseVisualStyleBackColor = true;
            this.buy_button.Click += new System.EventHandler(this.buyButtonClick);
            // 
            // cost_label
            // 
            this.cost_label.AutoSize = true;
            this.cost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_label.Location = new System.Drawing.Point(1395, 344);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(23, 25);
            this.cost_label.TabIndex = 18;
            this.cost_label.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1443, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1330, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(181)))), ((int)(((byte)(96)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1098, 660);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Balance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(181)))), ((int)(((byte)(96)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1290, 661);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 39);
            this.label8.TabIndex = 22;
            this.label8.Text = "300";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(19, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(18, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(19, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Age:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(185, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Hunger:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(185, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Health:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_label.Location = new System.Drawing.Point(91, 14);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(19, 25);
            this.id_label.TabIndex = 28;
            this.id_label.Text = "-";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_label.Location = new System.Drawing.Point(91, 50);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(19, 25);
            this.type_label.TabIndex = 29;
            this.type_label.Text = "-";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_label.Location = new System.Drawing.Point(91, 88);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(19, 25);
            this.age_label.TabIndex = 30;
            this.age_label.Text = "-";
            // 
            // hunger_bar
            // 
            this.hunger_bar.ForeColor = System.Drawing.Color.Green;
            this.hunger_bar.Location = new System.Drawing.Point(277, 14);
            this.hunger_bar.Maximum = 200;
            this.hunger_bar.Name = "hunger_bar";
            this.hunger_bar.Size = new System.Drawing.Size(113, 25);
            this.hunger_bar.TabIndex = 31;
            // 
            // health_bar
            // 
            this.health_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.health_bar.Location = new System.Drawing.Point(277, 50);
            this.health_bar.Maximum = 200;
            this.health_bar.Name = "health_bar";
            this.health_bar.Size = new System.Drawing.Size(113, 25);
            this.health_bar.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(181)))), ((int)(((byte)(96)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bal_label);
            this.panel2.Location = new System.Drawing.Point(1080, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 67);
            this.panel2.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // moveAnimal
            // 
            this.moveAnimal.Enabled = true;
            this.moveAnimal.Interval = 20;
            this.moveAnimal.Tick += new System.EventHandler(this.moveAnimalTick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.id_label);
            this.panel3.Controls.Add(this.health_bar);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.age_label);
            this.panel3.Controls.Add(this.hunger_bar);
            this.panel3.Controls.Add(this.type_label);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(1080, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 132);
            this.panel3.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1100, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "You have:";
            // 
            // c_amount_label
            // 
            this.c_amount_label.AutoSize = true;
            this.c_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_amount_label.Location = new System.Drawing.Point(1267, 573);
            this.c_amount_label.Name = "c_amount_label";
            this.c_amount_label.Size = new System.Drawing.Size(18, 20);
            this.c_amount_label.TabIndex = 37;
            this.c_amount_label.Text = "0";
            // 
            // sh_amount_label
            // 
            this.sh_amount_label.AutoSize = true;
            this.sh_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sh_amount_label.Location = new System.Drawing.Point(1267, 599);
            this.sh_amount_label.Name = "sh_amount_label";
            this.sh_amount_label.Size = new System.Drawing.Size(18, 20);
            this.sh_amount_label.TabIndex = 38;
            this.sh_amount_label.Text = "0";
            // 
            // ch_amount_label
            // 
            this.ch_amount_label.AutoSize = true;
            this.ch_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch_amount_label.Location = new System.Drawing.Point(1267, 627);
            this.ch_amount_label.Name = "ch_amount_label";
            this.ch_amount_label.Size = new System.Drawing.Size(18, 20);
            this.ch_amount_label.TabIndex = 39;
            this.ch_amount_label.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(1302, 573);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 40;
            this.label17.Text = "cows";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(1302, 599);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 41;
            this.label18.Text = "sheep";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(1302, 627);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "chickens";
            // 
            // day_count_label
            // 
            this.day_count_label.AutoSize = true;
            this.day_count_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.day_count_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.day_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day_count_label.ForeColor = System.Drawing.Color.Black;
            this.day_count_label.Image = global::FarmGame.Properties.Resources.background;
            this.day_count_label.Location = new System.Drawing.Point(1013, 26);
            this.day_count_label.Name = "day_count_label";
            this.day_count_label.Size = new System.Drawing.Size(33, 36);
            this.day_count_label.TabIndex = 34;
            this.day_count_label.Text = "1";
            // 
            // sell_button
            // 
            this.sell_button.Image = global::FarmGame.Properties.Resources.cow;
            this.sell_button.Location = new System.Drawing.Point(1105, 280);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(180, 152);
            this.sell_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sell_button.TabIndex = 17;
            this.sell_button.TabStop = false;
            // 
            // selling_button
            // 
            this.selling_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selling_button.Image = global::FarmGame.Properties.Resources.sell;
            this.selling_button.Location = new System.Drawing.Point(535, 0);
            this.selling_button.Name = "selling_button";
            this.selling_button.Size = new System.Drawing.Size(99, 98);
            this.selling_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selling_button.TabIndex = 5;
            this.selling_button.TabStop = false;
            this.selling_button.Click += new System.EventHandler(this.meat_button_Click);
            // 
            // wool_button
            // 
            this.wool_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wool_button.Image = global::FarmGame.Properties.Resources.wool;
            this.wool_button.Location = new System.Drawing.Point(10, 0);
            this.wool_button.Name = "wool_button";
            this.wool_button.Size = new System.Drawing.Size(99, 98);
            this.wool_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wool_button.TabIndex = 0;
            this.wool_button.TabStop = false;
            this.wool_button.Click += new System.EventHandler(this.wool_button_Click);
            // 
            // health_button
            // 
            this.health_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.health_button.Image = global::FarmGame.Properties.Resources.health;
            this.health_button.Location = new System.Drawing.Point(430, 0);
            this.health_button.Name = "health_button";
            this.health_button.Size = new System.Drawing.Size(99, 98);
            this.health_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.health_button.TabIndex = 4;
            this.health_button.TabStop = false;
            this.health_button.Click += new System.EventHandler(this.health_button_Click);
            // 
            // feed_button
            // 
            this.feed_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feed_button.Image = global::FarmGame.Properties.Resources.feed;
            this.feed_button.Location = new System.Drawing.Point(325, 0);
            this.feed_button.Name = "feed_button";
            this.feed_button.Size = new System.Drawing.Size(99, 98);
            this.feed_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feed_button.TabIndex = 3;
            this.feed_button.TabStop = false;
            this.feed_button.Click += new System.EventHandler(this.feed_button_Click);
            // 
            // milk_button
            // 
            this.milk_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.milk_button.Image = global::FarmGame.Properties.Resources.milk;
            this.milk_button.Location = new System.Drawing.Point(220, 0);
            this.milk_button.Name = "milk_button";
            this.milk_button.Size = new System.Drawing.Size(99, 98);
            this.milk_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.milk_button.TabIndex = 2;
            this.milk_button.TabStop = false;
            this.milk_button.Click += new System.EventHandler(this.milk_button_Click);
            // 
            // egg_button
            // 
            this.egg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egg_button.Image = global::FarmGame.Properties.Resources.egg;
            this.egg_button.Location = new System.Drawing.Point(115, 0);
            this.egg_button.Name = "egg_button";
            this.egg_button.Size = new System.Drawing.Size(99, 98);
            this.egg_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.egg_button.TabIndex = 1;
            this.egg_button.TabStop = false;
            this.egg_button.Click += new System.EventHandler(this.egg_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(252)))), ((int)(((byte)(154)))));
            this.pictureBox1.BackgroundImage = global::FarmGame.Properties.Resources.background;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1090, 721);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_label.Location = new System.Drawing.Point(1100, 407);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(19, 25);
            this.amount_label.TabIndex = 43;
            this.amount_label.Text = "-";
            // 
            // days_label
            // 
            this.days_label.AutoSize = true;
            this.days_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.days_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.days_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days_label.ForeColor = System.Drawing.Color.Black;
            this.days_label.Image = global::FarmGame.Properties.Resources.background;
            this.days_label.Location = new System.Drawing.Point(927, 21);
            this.days_label.Name = "days_label";
            this.days_label.Size = new System.Drawing.Size(70, 36);
            this.days_label.TabIndex = 44;
            this.days_label.Text = "Day";
            // 
            // bal_label
            // 
            this.bal_label.AutoSize = true;
            this.bal_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(181)))), ((int)(((byte)(96)))));
            this.bal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bal_label.Location = new System.Drawing.Point(292, 9);
            this.bal_label.Name = "bal_label";
            this.bal_label.Size = new System.Drawing.Size(37, 39);
            this.bal_label.TabIndex = 45;
            this.bal_label.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1496, 708);
            this.Controls.Add(this.day_count_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ch_amount_label);
            this.Controls.Add(this.sh_amount_label);
            this.Controls.Add(this.c_amount_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cost_label);
            this.Controls.Add(this.sell_button);
            this.Controls.Add(this.buy_button);
            this.Controls.Add(this.choose_label);
            this.Controls.Add(this.choose_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buy_cow);
            this.Controls.Add(this.sell_label);
            this.Controls.Add(this.buy_sheep);
            this.Controls.Add(this.buy_chicken);
            this.Controls.Add(this.v);
            this.Controls.Add(this.chicken_radio_button);
            this.Controls.Add(this.sheep_radio_button);
            this.Controls.Add(this.cow_radio_button);
            this.Controls.Add(this.buy_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.days_label);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selling_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wool_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feed_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox wool_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox selling_button;
        private System.Windows.Forms.PictureBox health_button;
        private System.Windows.Forms.PictureBox feed_button;
        private System.Windows.Forms.PictureBox milk_button;
        private System.Windows.Forms.PictureBox egg_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label buy_label;
        private System.Windows.Forms.RadioButton cow_radio_button;
        private System.Windows.Forms.RadioButton sheep_radio_button;
        private System.Windows.Forms.RadioButton chicken_radio_button;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label buy_chicken;
        private System.Windows.Forms.Label buy_sheep;
        private System.Windows.Forms.Label sell_label;
        private System.Windows.Forms.Label buy_cow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox choose_amount;
        private System.Windows.Forms.Label choose_label;
        private System.Windows.Forms.Button buy_button;
        private System.Windows.Forms.PictureBox sell_button;
        private System.Windows.Forms.Label cost_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.ProgressBar hunger_bar;
        private System.Windows.Forms.ProgressBar health_bar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label day_count_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer moveAnimal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label c_amount_label;
        private System.Windows.Forms.Label sh_amount_label;
        private System.Windows.Forms.Label ch_amount_label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label days_label;
        private System.Windows.Forms.Label bal_label;
    }
}

