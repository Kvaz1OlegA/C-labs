namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptionButton = new System.Windows.Forms.Button();
            this.DecryptionButton = new System.Windows.Forms.Button();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PrimesGen = new System.Windows.Forms.Button();
            this.textBox_original = new System.Windows.Forms.TextBox();
            this.textBox_encrypted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KeysGen = new System.Windows.Forms.Button();
            this.clear_primes = new System.Windows.Forms.Button();
            this.clear_keys = new System.Windows.Forms.Button();
            this.clear_original_textbox = new System.Windows.Forms.Button();
            this.clear_encrypted_textbox = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_n_interlocutor = new System.Windows.Forms.TextBox();
            this.textBox_e_interlocutor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_signature_origin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.digital_signature_button = new System.Windows.Forms.Button();
            this.confirming_signature_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.upload_signature_button = new System.Windows.Forms.Button();
            this.save_signature_button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_signature_encrypted = new System.Windows.Forms.TextBox();
            this.save_to_file_button = new System.Windows.Forms.Button();
            this.upload_from_file_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptionButton
            // 
            this.EncryptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptionButton.Location = new System.Drawing.Point(977, 905);
            this.EncryptionButton.Name = "EncryptionButton";
            this.EncryptionButton.Size = new System.Drawing.Size(121, 44);
            this.EncryptionButton.TabIndex = 0;
            this.EncryptionButton.Text = "Encrypt";
            this.EncryptionButton.UseVisualStyleBackColor = true;
            this.EncryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // DecryptionButton
            // 
            this.DecryptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptionButton.Location = new System.Drawing.Point(1472, 905);
            this.DecryptionButton.Name = "DecryptionButton";
            this.DecryptionButton.Size = new System.Drawing.Size(121, 44);
            this.DecryptionButton.TabIndex = 1;
            this.DecryptionButton.Text = "Decrypt";
            this.DecryptionButton.UseVisualStyleBackColor = true;
            this.DecryptionButton.Click += new System.EventHandler(this.DecryptionButton_Click);
            // 
            // textBox_p
            // 
            this.textBox_p.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_p.Location = new System.Drawing.Point(31, 36);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.ReadOnly = true;
            this.textBox_p.Size = new System.Drawing.Size(800, 22);
            this.textBox_p.TabIndex = 2;
            // 
            // textBox_q
            // 
            this.textBox_q.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_q.Location = new System.Drawing.Point(31, 81);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.ReadOnly = true;
            this.textBox_q.Size = new System.Drawing.Size(800, 22);
            this.textBox_q.TabIndex = 3;
            // 
            // textBox_d
            // 
            this.textBox_d.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_d.Location = new System.Drawing.Point(31, 139);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.ReadOnly = true;
            this.textBox_d.Size = new System.Drawing.Size(800, 22);
            this.textBox_d.TabIndex = 4;
            // 
            // textBox_n
            // 
            this.textBox_n.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_n.Location = new System.Drawing.Point(31, 49);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.ReadOnly = true;
            this.textBox_n.Size = new System.Drawing.Size(800, 22);
            this.textBox_n.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "d( d*e = 1 ( mod φ(n) ) )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "n(p * q)";
            // 
            // textBox_e
            // 
            this.textBox_e.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_e.Location = new System.Drawing.Point(31, 94);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.ReadOnly = true;
            this.textBox_e.Size = new System.Drawing.Size(800, 22);
            this.textBox_e.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "e( (d,φ(n) ) = 1 )";
            // 
            // PrimesGen
            // 
            this.PrimesGen.Location = new System.Drawing.Point(31, 109);
            this.PrimesGen.Name = "PrimesGen";
            this.PrimesGen.Size = new System.Drawing.Size(147, 42);
            this.PrimesGen.TabIndex = 12;
            this.PrimesGen.Text = "Generate primes";
            this.PrimesGen.UseVisualStyleBackColor = true;
            this.PrimesGen.Click += new System.EventHandler(this.PrimesGen_Click);
            // 
            // textBox_original
            // 
            this.textBox_original.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_original.Location = new System.Drawing.Point(918, 38);
            this.textBox_original.Multiline = true;
            this.textBox_original.Name = "textBox_original";
            this.textBox_original.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_original.Size = new System.Drawing.Size(463, 862);
            this.textBox_original.TabIndex = 13;
            // 
            // textBox_encrypted
            // 
            this.textBox_encrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_encrypted.Location = new System.Drawing.Point(1424, 38);
            this.textBox_encrypted.Multiline = true;
            this.textBox_encrypted.Name = "textBox_encrypted";
            this.textBox_encrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_encrypted.Size = new System.Drawing.Size(463, 862);
            this.textBox_encrypted.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1128, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Original text";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1596, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Encrypted text";
            // 
            // KeysGen
            // 
            this.KeysGen.Location = new System.Drawing.Point(31, 167);
            this.KeysGen.Name = "KeysGen";
            this.KeysGen.Size = new System.Drawing.Size(147, 42);
            this.KeysGen.TabIndex = 17;
            this.KeysGen.Text = "Generate Keys";
            this.KeysGen.UseVisualStyleBackColor = true;
            this.KeysGen.Click += new System.EventHandler(this.KeysGen_Click);
            // 
            // clear_primes
            // 
            this.clear_primes.Location = new System.Drawing.Point(184, 109);
            this.clear_primes.Name = "clear_primes";
            this.clear_primes.Size = new System.Drawing.Size(147, 42);
            this.clear_primes.TabIndex = 18;
            this.clear_primes.Text = "Clear";
            this.clear_primes.UseVisualStyleBackColor = true;
            this.clear_primes.Click += new System.EventHandler(this.clear_primes_Click);
            // 
            // clear_keys
            // 
            this.clear_keys.Location = new System.Drawing.Point(184, 167);
            this.clear_keys.Name = "clear_keys";
            this.clear_keys.Size = new System.Drawing.Size(147, 42);
            this.clear_keys.TabIndex = 19;
            this.clear_keys.Text = "Clear";
            this.clear_keys.UseVisualStyleBackColor = true;
            this.clear_keys.Click += new System.EventHandler(this.clear_keys_Click);
            // 
            // clear_original_textbox
            // 
            this.clear_original_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_original_textbox.Location = new System.Drawing.Point(977, 955);
            this.clear_original_textbox.Name = "clear_original_textbox";
            this.clear_original_textbox.Size = new System.Drawing.Size(121, 44);
            this.clear_original_textbox.TabIndex = 20;
            this.clear_original_textbox.Text = "Clear";
            this.clear_original_textbox.UseVisualStyleBackColor = true;
            this.clear_original_textbox.Click += new System.EventHandler(this.clear_original_textbox_Click);
            // 
            // clear_encrypted_textbox
            // 
            this.clear_encrypted_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_encrypted_textbox.Location = new System.Drawing.Point(1472, 955);
            this.clear_encrypted_textbox.Name = "clear_encrypted_textbox";
            this.clear_encrypted_textbox.Size = new System.Drawing.Size(121, 44);
            this.clear_encrypted_textbox.TabIndex = 21;
            this.clear_encrypted_textbox.Text = "Clear";
            this.clear_encrypted_textbox.UseVisualStyleBackColor = true;
            this.clear_encrypted_textbox.Click += new System.EventHandler(this.clear_encrypted_textbox_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_p);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_q);
            this.panel1.Controls.Add(this.PrimesGen);
            this.panel1.Controls.Add(this.clear_primes);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 171);
            this.panel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Prime number generator";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox_d);
            this.panel2.Controls.Add(this.textBox_n);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_e);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.clear_keys);
            this.panel2.Controls.Add(this.KeysGen);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 226);
            this.panel2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Your pair of keys";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(172)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox_n_interlocutor);
            this.panel3.Controls.Add(this.textBox_e_interlocutor);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 193);
            this.panel3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "e";
            // 
            // textBox_n_interlocutor
            // 
            this.textBox_n_interlocutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_n_interlocutor.Location = new System.Drawing.Point(32, 96);
            this.textBox_n_interlocutor.Name = "textBox_n_interlocutor";
            this.textBox_n_interlocutor.Size = new System.Drawing.Size(800, 22);
            this.textBox_n_interlocutor.TabIndex = 23;
            // 
            // textBox_e_interlocutor
            // 
            this.textBox_e_interlocutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_e_interlocutor.Location = new System.Drawing.Point(31, 47);
            this.textBox_e_interlocutor.Name = "textBox_e_interlocutor";
            this.textBox_e_interlocutor.Size = new System.Drawing.Size(800, 22);
            this.textBox_e_interlocutor.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Open key of interlocutor";
            // 
            // textBox_signature_origin
            // 
            this.textBox_signature_origin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_signature_origin.Location = new System.Drawing.Point(233, 47);
            this.textBox_signature_origin.Multiline = true;
            this.textBox_signature_origin.Name = "textBox_signature_origin";
            this.textBox_signature_origin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_signature_origin.Size = new System.Drawing.Size(316, 190);
            this.textBox_signature_origin.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Field for creating a digital signature";
            // 
            // digital_signature_button
            // 
            this.digital_signature_button.Location = new System.Drawing.Point(22, 47);
            this.digital_signature_button.Name = "digital_signature_button";
            this.digital_signature_button.Size = new System.Drawing.Size(147, 42);
            this.digital_signature_button.TabIndex = 25;
            this.digital_signature_button.Text = "Create a digital signature";
            this.digital_signature_button.UseVisualStyleBackColor = true;
            this.digital_signature_button.Click += new System.EventHandler(this.digital_signature_button_Click);
            // 
            // confirming_signature_button
            // 
            this.confirming_signature_button.Location = new System.Drawing.Point(22, 95);
            this.confirming_signature_button.Name = "confirming_signature_button";
            this.confirming_signature_button.Size = new System.Drawing.Size(147, 42);
            this.confirming_signature_button.TabIndex = 26;
            this.confirming_signature_button.Text = "Confirmation of digital signature";
            this.confirming_signature_button.UseVisualStyleBackColor = true;
            this.confirming_signature_button.Click += new System.EventHandler(this.confirming_signature_button_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(172)))));
            this.panel4.Controls.Add(this.upload_signature_button);
            this.panel4.Controls.Add(this.save_signature_button);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.textBox_signature_encrypted);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.confirming_signature_button);
            this.panel4.Controls.Add(this.textBox_signature_origin);
            this.panel4.Controls.Add(this.digital_signature_button);
            this.panel4.Location = new System.Drawing.Point(12, 645);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(883, 254);
            this.panel4.TabIndex = 27;
            // 
            // upload_signature_button
            // 
            this.upload_signature_button.Location = new System.Drawing.Point(22, 191);
            this.upload_signature_button.Name = "upload_signature_button";
            this.upload_signature_button.Size = new System.Drawing.Size(147, 42);
            this.upload_signature_button.TabIndex = 30;
            this.upload_signature_button.Text = "Upload signature";
            this.upload_signature_button.UseVisualStyleBackColor = true;
            this.upload_signature_button.Click += new System.EventHandler(this.upload_signature_button_Click);
            // 
            // save_signature_button
            // 
            this.save_signature_button.Location = new System.Drawing.Point(22, 143);
            this.save_signature_button.Name = "save_signature_button";
            this.save_signature_button.Size = new System.Drawing.Size(147, 42);
            this.save_signature_button.TabIndex = 29;
            this.save_signature_button.Text = "Save signature";
            this.save_signature_button.UseVisualStyleBackColor = true;
            this.save_signature_button.Click += new System.EventHandler(this.save_signature_button_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(671, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Digital signature";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(363, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Original text";
            // 
            // textBox_signature_encrypted
            // 
            this.textBox_signature_encrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_signature_encrypted.Location = new System.Drawing.Point(555, 47);
            this.textBox_signature_encrypted.Multiline = true;
            this.textBox_signature_encrypted.Name = "textBox_signature_encrypted";
            this.textBox_signature_encrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_signature_encrypted.Size = new System.Drawing.Size(316, 190);
            this.textBox_signature_encrypted.TabIndex = 24;
            // 
            // save_to_file_button
            // 
            this.save_to_file_button.Location = new System.Drawing.Point(1646, 906);
            this.save_to_file_button.Name = "save_to_file_button";
            this.save_to_file_button.Size = new System.Drawing.Size(121, 43);
            this.save_to_file_button.TabIndex = 28;
            this.save_to_file_button.Text = "Save to file";
            this.save_to_file_button.UseVisualStyleBackColor = true;
            this.save_to_file_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // upload_from_file_button
            // 
            this.upload_from_file_button.Location = new System.Drawing.Point(1646, 955);
            this.upload_from_file_button.Name = "upload_from_file_button";
            this.upload_from_file_button.Size = new System.Drawing.Size(121, 43);
            this.upload_from_file_button.TabIndex = 29;
            this.upload_from_file_button.Text = "Upload from file";
            this.upload_from_file_button.UseVisualStyleBackColor = true;
            this.upload_from_file_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.upload_from_file_button);
            this.Controls.Add(this.save_to_file_button);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_encrypted_textbox);
            this.Controls.Add(this.clear_original_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_encrypted);
            this.Controls.Add(this.textBox_original);
            this.Controls.Add(this.DecryptionButton);
            this.Controls.Add(this.EncryptionButton);
            this.Name = "Form1";
            this.Text = "Rsa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptionButton;
        private System.Windows.Forms.Button DecryptionButton;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PrimesGen;
        private System.Windows.Forms.TextBox textBox_original;
        private System.Windows.Forms.TextBox textBox_encrypted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button KeysGen;
        private System.Windows.Forms.Button clear_primes;
        private System.Windows.Forms.Button clear_keys;
        private System.Windows.Forms.Button clear_original_textbox;
        private System.Windows.Forms.Button clear_encrypted_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_n_interlocutor;
        private System.Windows.Forms.TextBox textBox_e_interlocutor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_signature_origin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button digital_signature_button;
        private System.Windows.Forms.Button confirming_signature_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_signature_encrypted;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button save_to_file_button;
        private System.Windows.Forms.Button upload_from_file_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button upload_signature_button;
        private System.Windows.Forms.Button save_signature_button;
    }
}

