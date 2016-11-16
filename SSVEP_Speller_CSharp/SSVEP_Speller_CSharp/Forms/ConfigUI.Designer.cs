namespace SSVEP_Speller_CSharp.Forms
{
    partial class ConfigUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigUI));
            this.label1 = new System.Windows.Forms.Label();
            this.subject_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_num = new System.Windows.Forms.TextBox();
            this.run_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.session_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.target_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_targets = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.twitter_account = new System.Windows.Forms.ComboBox();
            this.classifier = new System.Windows.Forms.ComboBox();
            this.feedback = new System.Windows.Forms.ComboBox();
            this.speller_mode = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.refresh_rate = new System.Windows.Forms.TextBox();
            this.freq_resol = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.min_freq = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.stimulus_duration = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SCREEN_HEIGHT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SCREEN_WIDTH = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject ID";
            // 
            // subject_id
            // 
            this.subject_id.Location = new System.Drawing.Point(229, 44);
            this.subject_id.Name = "subject_id";
            this.subject_id.Size = new System.Drawing.Size(253, 20);
            this.subject_id.TabIndex = 1;
            this.subject_id.Text = "XXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group #";
            // 
            // group_num
            // 
            this.group_num.Location = new System.Drawing.Point(229, 79);
            this.group_num.Name = "group_num";
            this.group_num.Size = new System.Drawing.Size(253, 20);
            this.group_num.TabIndex = 3;
            this.group_num.Text = "1";
            // 
            // run_num
            // 
            this.run_num.Location = new System.Drawing.Point(229, 150);
            this.run_num.Name = "run_num";
            this.run_num.Size = new System.Drawing.Size(253, 20);
            this.run_num.TabIndex = 7;
            this.run_num.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Run #";
            // 
            // session_num
            // 
            this.session_num.Location = new System.Drawing.Point(229, 115);
            this.session_num.Name = "session_num";
            this.session_num.Size = new System.Drawing.Size(253, 20);
            this.session_num.TabIndex = 5;
            this.session_num.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(39, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Session #";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(23, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 154);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subject Information";
            // 
            // target_text
            // 
            this.target_text.Location = new System.Drawing.Point(229, 300);
            this.target_text.Name = "target_text";
            this.target_text.Size = new System.Drawing.Size(253, 20);
            this.target_text.TabIndex = 15;
            this.target_text.Text = "THE QUICK BROWN FOX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(39, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Target Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(39, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Speller Mode";
            // 
            // num_targets
            // 
            this.num_targets.Location = new System.Drawing.Point(229, 229);
            this.num_targets.Name = "num_targets";
            this.num_targets.Size = new System.Drawing.Size(253, 20);
            this.num_targets.TabIndex = 11;
            this.num_targets.Text = "30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(39, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Number of Targets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Paradigm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.twitter_account);
            this.panel2.Controls.Add(this.classifier);
            this.panel2.Controls.Add(this.feedback);
            this.panel2.Controls.Add(this.speller_mode);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(23, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 222);
            this.panel2.TabIndex = 17;
            // 
            // twitter_account
            // 
            this.twitter_account.FormattingEnabled = true;
            this.twitter_account.Items.AddRange(new object[] {
            "Columbia ",
            "Nick Waytowich"});
            this.twitter_account.Location = new System.Drawing.Point(205, 187);
            this.twitter_account.Name = "twitter_account";
            this.twitter_account.Size = new System.Drawing.Size(253, 21);
            this.twitter_account.TabIndex = 32;
            this.twitter_account.Text = "Columbia";
            // 
            // classifier
            // 
            this.classifier.FormattingEnabled = true;
            this.classifier.Items.AddRange(new object[] {
            "CCA",
            "Combined-CCA",
            "Dummy"});
            this.classifier.Location = new System.Drawing.Point(205, 153);
            this.classifier.Name = "classifier";
            this.classifier.Size = new System.Drawing.Size(253, 21);
            this.classifier.TabIndex = 31;
            this.classifier.Text = "CCA";
            // 
            // feedback
            // 
            this.feedback.FormattingEnabled = true;
            this.feedback.Items.AddRange(new object[] {
            "Feedback (online)",
            "No Feedback (offline)"});
            this.feedback.Location = new System.Drawing.Point(205, 116);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(253, 21);
            this.feedback.TabIndex = 30;
            this.feedback.Text = "Feedback (online)";
            // 
            // speller_mode
            // 
            this.speller_mode.FormattingEnabled = true;
            this.speller_mode.Items.AddRange(new object[] {
            "Free Spell",
            "Copy Spell"});
            this.speller_mode.Location = new System.Drawing.Point(205, 44);
            this.speller_mode.Name = "speller_mode";
            this.speller_mode.Size = new System.Drawing.Size(253, 21);
            this.speller_mode.TabIndex = 29;
            this.speller_mode.Text = "Free Spell";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(15, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 22;
            this.label20.Text = "Classifier";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(15, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Twitter Account";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(15, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(15, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Feedback";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Stimulus Config";
            // 
            // refresh_rate
            // 
            this.refresh_rate.Location = new System.Drawing.Point(229, 586);
            this.refresh_rate.Name = "refresh_rate";
            this.refresh_rate.Size = new System.Drawing.Size(253, 20);
            this.refresh_rate.TabIndex = 25;
            this.refresh_rate.Text = "60";
            // 
            // freq_resol
            // 
            this.freq_resol.Location = new System.Drawing.Point(229, 551);
            this.freq_resol.Name = "freq_resol";
            this.freq_resol.Size = new System.Drawing.Size(253, 20);
            this.freq_resol.TabIndex = 24;
            this.freq_resol.Text = "0.2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(39, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Frequency Resolution (Hz)";
            // 
            // min_freq
            // 
            this.min_freq.Location = new System.Drawing.Point(229, 515);
            this.min_freq.Name = "min_freq";
            this.min_freq.Size = new System.Drawing.Size(253, 20);
            this.min_freq.TabIndex = 22;
            this.min_freq.Text = "8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(39, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Min Frequency (Hz)";
            // 
            // stimulus_duration
            // 
            this.stimulus_duration.Location = new System.Drawing.Point(229, 480);
            this.stimulus_duration.Name = "stimulus_duration";
            this.stimulus_duration.Size = new System.Drawing.Size(253, 20);
            this.stimulus_duration.TabIndex = 20;
            this.stimulus_duration.Text = "4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(39, 480);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Stimulus Duration";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SCREEN_HEIGHT);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.SCREEN_WIDTH);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(23, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 222);
            this.panel3.TabIndex = 26;
            // 
            // SCREEN_HEIGHT
            // 
            this.SCREEN_HEIGHT.Location = new System.Drawing.Point(205, 187);
            this.SCREEN_HEIGHT.Name = "SCREEN_HEIGHT";
            this.SCREEN_HEIGHT.Size = new System.Drawing.Size(253, 20);
            this.SCREEN_HEIGHT.TabIndex = 21;
            this.SCREEN_HEIGHT.Text = "1080";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(15, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 15);
            this.label17.TabIndex = 20;
            this.label17.Text = "Screen Height";
            // 
            // SCREEN_WIDTH
            // 
            this.SCREEN_WIDTH.Location = new System.Drawing.Point(205, 152);
            this.SCREEN_WIDTH.Name = "SCREEN_WIDTH";
            this.SCREEN_WIDTH.Size = new System.Drawing.Size(253, 20);
            this.SCREEN_WIDTH.TabIndex = 19;
            this.SCREEN_WIDTH.Text = "1920";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(15, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 15);
            this.label18.TabIndex = 7;
            this.label18.Text = "Screen Width";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(15, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "Refresh Rate";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(543, 33);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(99, 23);
            this.StartBtn.TabIndex = 28;
            this.StartBtn.Text = "Start Speller";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(543, 649);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(99, 23);
            this.ExitBtn.TabIndex = 29;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ConfigUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 699);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.refresh_rate);
            this.Controls.Add(this.freq_resol);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.min_freq);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.stimulus_duration);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.target_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_targets);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.run_num);
            this.Controls.Add(this.session_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.group_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subject_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigUI";
            this.Text = "SSVEP Speller - Parameter Configuration";
            this.Load += new System.EventHandler(this.ConfigUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subject_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox group_num;
        private System.Windows.Forms.TextBox run_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox session_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox target_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox num_targets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox refresh_rate;
        private System.Windows.Forms.TextBox freq_resol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox min_freq;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox stimulus_duration;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SCREEN_HEIGHT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SCREEN_WIDTH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox speller_mode;
        private System.Windows.Forms.ComboBox classifier;
        private System.Windows.Forms.ComboBox feedback;
        private System.Windows.Forms.ComboBox twitter_account;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}