
namespace MedicalTest
{
	partial class StartScreen
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
			this.button_admin = new System.Windows.Forms.Button();
			this.button_doctor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_admin
			// 
			this.button_admin.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_admin.Location = new System.Drawing.Point(223, 211);
			this.button_admin.Name = "button_admin";
			this.button_admin.Size = new System.Drawing.Size(300, 250);
			this.button_admin.TabIndex = 0;
			this.button_admin.Text = "Администратор";
			this.button_admin.UseVisualStyleBackColor = true;
			this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
			// 
			// button_doctor
			// 
			this.button_doctor.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_doctor.Location = new System.Drawing.Point(745, 211);
			this.button_doctor.Name = "button_doctor";
			this.button_doctor.Size = new System.Drawing.Size(300, 250);
			this.button_doctor.TabIndex = 1;
			this.button_doctor.Text = "Доктор";
			this.button_doctor.UseVisualStyleBackColor = true;
			this.button_doctor.Click += new System.EventHandler(this.button_doctor_Click);
			// 
			// StartScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.button_doctor);
			this.Controls.Add(this.button_admin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "StartScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Medical Test";
			this.Load += new System.EventHandler(this.StartScreen_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_admin;
		private System.Windows.Forms.Button button_doctor;
	}
}

