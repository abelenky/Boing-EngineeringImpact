namespace EngineeringImpact
{
	partial class EngineeringImpact
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
			this.Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button
			// 
			this.Button.Location = new System.Drawing.Point(12, 12);
			this.Button.Name = "Button";
			this.Button.Size = new System.Drawing.Size(959, 31);
			this.Button.TabIndex = 0;
			this.Button.Text = "Engineering Impact";
			this.Button.UseVisualStyleBackColor = true;
			this.Button.Click += new System.EventHandler(this.OnClick);
			// 
			// EngineeringImpact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 49);
			this.Controls.Add(this.Button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EngineeringImpact";
			this.Text = "Cerner Engineering Impact";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Button;
	}
}

