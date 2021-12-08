
namespace MedicalTest
{
	partial class DoctorScreen
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label_time = new System.Windows.Forms.Label();
			this.label_time_st = new System.Windows.Forms.Label();
			this.label_activity = new System.Windows.Forms.Label();
			this.label_activity_st = new System.Windows.Forms.Label();
			this.label_sex = new System.Windows.Forms.Label();
			this.label_age = new System.Windows.Forms.Label();
			this.label_last_name = new System.Windows.Forms.Label();
			this.label_middle_name = new System.Windows.Forms.Label();
			this.label_first_name = new System.Windows.Forms.Label();
			this.label_sex_st = new System.Windows.Forms.Label();
			this.label_age_st = new System.Windows.Forms.Label();
			this.label_last_name_st = new System.Windows.Forms.Label();
			this.label_middle_name_st = new System.Windows.Forms.Label();
			this.button_show = new System.Windows.Forms.Button();
			this.label_first_name_st = new System.Windows.Forms.Label();
			this.label_common_state = new System.Windows.Forms.Label();
			this.button_start_exam = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.button_back = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1280, 673);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1272, 643);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Список пациентов";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 22;
			this.listBox1.Location = new System.Drawing.Point(3, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(1266, 637);
			this.listBox1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label_time);
			this.tabPage2.Controls.Add(this.label_time_st);
			this.tabPage2.Controls.Add(this.label_activity);
			this.tabPage2.Controls.Add(this.label_activity_st);
			this.tabPage2.Controls.Add(this.label_sex);
			this.tabPage2.Controls.Add(this.label_age);
			this.tabPage2.Controls.Add(this.label_last_name);
			this.tabPage2.Controls.Add(this.label_middle_name);
			this.tabPage2.Controls.Add(this.label_first_name);
			this.tabPage2.Controls.Add(this.label_sex_st);
			this.tabPage2.Controls.Add(this.label_age_st);
			this.tabPage2.Controls.Add(this.label_last_name_st);
			this.tabPage2.Controls.Add(this.label_middle_name_st);
			this.tabPage2.Controls.Add(this.button_show);
			this.tabPage2.Controls.Add(this.label_first_name_st);
			this.tabPage2.Controls.Add(this.label_common_state);
			this.tabPage2.Controls.Add(this.button_start_exam);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.textBox_id);
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1272, 643);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Обследование";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label_time
			// 
			this.label_time.AutoSize = true;
			this.label_time.Location = new System.Drawing.Point(735, 387);
			this.label_time.Name = "label_time";
			this.label_time.Size = new System.Drawing.Size(48, 18);
			this.label_time.TabIndex = 19;
			this.label_time.Text = "Время";
			this.label_time.Visible = false;
			// 
			// label_time_st
			// 
			this.label_time_st.AutoSize = true;
			this.label_time_st.Location = new System.Drawing.Point(582, 387);
			this.label_time_st.Name = "label_time_st";
			this.label_time_st.Size = new System.Drawing.Size(48, 18);
			this.label_time_st.TabIndex = 18;
			this.label_time_st.Text = "Время";
			this.label_time_st.Visible = false;
			// 
			// label_activity
			// 
			this.label_activity.AutoSize = true;
			this.label_activity.Location = new System.Drawing.Point(735, 339);
			this.label_activity.Name = "label_activity";
			this.label_activity.Size = new System.Drawing.Size(104, 18);
			this.label_activity.TabIndex = 17;
			this.label_activity.Text = "Тип нагрузки";
			this.label_activity.Visible = false;
			// 
			// label_activity_st
			// 
			this.label_activity_st.AutoSize = true;
			this.label_activity_st.Location = new System.Drawing.Point(582, 339);
			this.label_activity_st.Name = "label_activity_st";
			this.label_activity_st.Size = new System.Drawing.Size(104, 18);
			this.label_activity_st.TabIndex = 16;
			this.label_activity_st.Text = "Тип нагрузки";
			this.label_activity_st.Visible = false;
			// 
			// label_sex
			// 
			this.label_sex.AutoSize = true;
			this.label_sex.Location = new System.Drawing.Point(735, 259);
			this.label_sex.Name = "label_sex";
			this.label_sex.Size = new System.Drawing.Size(32, 18);
			this.label_sex.TabIndex = 15;
			this.label_sex.Text = "Пол";
			this.label_sex.Visible = false;
			// 
			// label_age
			// 
			this.label_age.AutoSize = true;
			this.label_age.Location = new System.Drawing.Point(735, 208);
			this.label_age.Name = "label_age";
			this.label_age.Size = new System.Drawing.Size(64, 18);
			this.label_age.TabIndex = 14;
			this.label_age.Text = "Возраст";
			this.label_age.Visible = false;
			// 
			// label_last_name
			// 
			this.label_last_name.AutoSize = true;
			this.label_last_name.Location = new System.Drawing.Point(735, 151);
			this.label_last_name.Name = "label_last_name";
			this.label_last_name.Size = new System.Drawing.Size(72, 18);
			this.label_last_name.TabIndex = 13;
			this.label_last_name.Text = "Отчество";
			this.label_last_name.Visible = false;
			// 
			// label_middle_name
			// 
			this.label_middle_name.AutoSize = true;
			this.label_middle_name.Location = new System.Drawing.Point(735, 103);
			this.label_middle_name.Name = "label_middle_name";
			this.label_middle_name.Size = new System.Drawing.Size(32, 18);
			this.label_middle_name.TabIndex = 12;
			this.label_middle_name.Text = "Имя";
			this.label_middle_name.Visible = false;
			// 
			// label_first_name
			// 
			this.label_first_name.AutoSize = true;
			this.label_first_name.Location = new System.Drawing.Point(735, 55);
			this.label_first_name.Name = "label_first_name";
			this.label_first_name.Size = new System.Drawing.Size(64, 18);
			this.label_first_name.TabIndex = 11;
			this.label_first_name.Text = "Фамилия";
			this.label_first_name.Visible = false;
			// 
			// label_sex_st
			// 
			this.label_sex_st.AutoSize = true;
			this.label_sex_st.Location = new System.Drawing.Point(582, 260);
			this.label_sex_st.Name = "label_sex_st";
			this.label_sex_st.Size = new System.Drawing.Size(32, 18);
			this.label_sex_st.TabIndex = 10;
			this.label_sex_st.Text = "Пол";
			this.label_sex_st.Visible = false;
			// 
			// label_age_st
			// 
			this.label_age_st.AutoSize = true;
			this.label_age_st.Location = new System.Drawing.Point(582, 209);
			this.label_age_st.Name = "label_age_st";
			this.label_age_st.Size = new System.Drawing.Size(64, 18);
			this.label_age_st.TabIndex = 9;
			this.label_age_st.Text = "Возраст";
			this.label_age_st.Visible = false;
			// 
			// label_last_name_st
			// 
			this.label_last_name_st.AutoSize = true;
			this.label_last_name_st.Location = new System.Drawing.Point(582, 152);
			this.label_last_name_st.Name = "label_last_name_st";
			this.label_last_name_st.Size = new System.Drawing.Size(72, 18);
			this.label_last_name_st.TabIndex = 8;
			this.label_last_name_st.Text = "Отчество";
			this.label_last_name_st.Visible = false;
			// 
			// label_middle_name_st
			// 
			this.label_middle_name_st.AutoSize = true;
			this.label_middle_name_st.Location = new System.Drawing.Point(582, 104);
			this.label_middle_name_st.Name = "label_middle_name_st";
			this.label_middle_name_st.Size = new System.Drawing.Size(32, 18);
			this.label_middle_name_st.TabIndex = 7;
			this.label_middle_name_st.Text = "Имя";
			this.label_middle_name_st.Visible = false;
			// 
			// button_show
			// 
			this.button_show.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_show.Location = new System.Drawing.Point(100, 209);
			this.button_show.Name = "button_show";
			this.button_show.Size = new System.Drawing.Size(393, 148);
			this.button_show.TabIndex = 6;
			this.button_show.Text = "Показать сведения о пациенте";
			this.button_show.UseVisualStyleBackColor = true;
			this.button_show.Click += new System.EventHandler(this.button_show_Click);
			// 
			// label_first_name_st
			// 
			this.label_first_name_st.AutoSize = true;
			this.label_first_name_st.Location = new System.Drawing.Point(582, 56);
			this.label_first_name_st.Name = "label_first_name_st";
			this.label_first_name_st.Size = new System.Drawing.Size(64, 18);
			this.label_first_name_st.TabIndex = 5;
			this.label_first_name_st.Text = "Фамилия";
			this.label_first_name_st.Visible = false;
			// 
			// label_common_state
			// 
			this.label_common_state.AutoSize = true;
			this.label_common_state.Location = new System.Drawing.Point(146, 104);
			this.label_common_state.Name = "label_common_state";
			this.label_common_state.Size = new System.Drawing.Size(0, 18);
			this.label_common_state.TabIndex = 4;
			// 
			// button_start_exam
			// 
			this.button_start_exam.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_start_exam.Location = new System.Drawing.Point(100, 455);
			this.button_start_exam.Name = "button_start_exam";
			this.button_start_exam.Size = new System.Drawing.Size(393, 148);
			this.button_start_exam.TabIndex = 3;
			this.button_start_exam.Text = "Начать обследование";
			this.button_start_exam.UseVisualStyleBackColor = true;
			this.button_start_exam.Click += new System.EventHandler(this.button_start_exam_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(97, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID пациента";
			// 
			// textBox_id
			// 
			this.textBox_id.Location = new System.Drawing.Point(273, 52);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.Size = new System.Drawing.Size(220, 25);
			this.textBox_id.TabIndex = 0;
			this.textBox_id.Text = "0";
			// 
			// button_back
			// 
			this.button_back.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_back.Location = new System.Drawing.Point(12, 679);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(150, 29);
			this.button_back.TabIndex = 2;
			this.button_back.Text = "На главную";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// DoctorScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DoctorScreen";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "doctorScreen";
			this.Load += new System.EventHandler(this.DoctorScreen_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button_back;
		private System.Windows.Forms.Button button_start_exam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_id;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label_time;
		private System.Windows.Forms.Label label_time_st;
		private System.Windows.Forms.Label label_activity;
		private System.Windows.Forms.Label label_activity_st;
		private System.Windows.Forms.Label label_sex;
		private System.Windows.Forms.Label label_age;
		private System.Windows.Forms.Label label_last_name;
		private System.Windows.Forms.Label label_middle_name;
		private System.Windows.Forms.Label label_first_name;
		private System.Windows.Forms.Label label_sex_st;
		private System.Windows.Forms.Label label_age_st;
		private System.Windows.Forms.Label label_last_name_st;
		private System.Windows.Forms.Label label_middle_name_st;
		private System.Windows.Forms.Button button_show;
		private System.Windows.Forms.Label label_first_name_st;
		private System.Windows.Forms.Label label_common_state;
	}
}