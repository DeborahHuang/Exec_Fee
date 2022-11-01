namespace Exec_Fee
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCount = new System.Windows.Forms.Button();
			this.radioBtnFemale = new System.Windows.Forms.RadioButton();
			this.radioBtnMale = new System.Windows.Forms.RadioButton();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.grpBoxCalResult = new System.Windows.Forms.GroupBox();
			this.lblChargeReason = new System.Windows.Forms.Label();
			this.lblCarCharge = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.grpBoxCalResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCount);
			this.groupBox1.Controls.Add(this.radioBtnFemale);
			this.groupBox1.Controls.Add(this.radioBtnMale);
			this.groupBox1.Controls.Add(this.txtAge);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblAge);
			this.groupBox1.Location = new System.Drawing.Point(29, 24);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(481, 153);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "客戶資訊";
			// 
			// btnCount
			// 
			this.btnCount.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCount.Location = new System.Drawing.Point(349, 102);
			this.btnCount.Name = "btnCount";
			this.btnCount.Size = new System.Drawing.Size(100, 32);
			this.btnCount.TabIndex = 3;
			this.btnCount.Text = "計算";
			this.btnCount.UseVisualStyleBackColor = true;
			this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
			// 
			// radioBtnFemale
			// 
			this.radioBtnFemale.AutoSize = true;
			this.radioBtnFemale.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioBtnFemale.Location = new System.Drawing.Point(405, 37);
			this.radioBtnFemale.Name = "radioBtnFemale";
			this.radioBtnFemale.Size = new System.Drawing.Size(65, 26);
			this.radioBtnFemale.TabIndex = 2;
			this.radioBtnFemale.TabStop = true;
			this.radioBtnFemale.Text = "女性";
			this.radioBtnFemale.UseVisualStyleBackColor = true;
			// 
			// radioBtnMale
			// 
			this.radioBtnMale.AutoSize = true;
			this.radioBtnMale.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioBtnMale.Location = new System.Drawing.Point(334, 37);
			this.radioBtnMale.Name = "radioBtnMale";
			this.radioBtnMale.Size = new System.Drawing.Size(65, 26);
			this.radioBtnMale.TabIndex = 2;
			this.radioBtnMale.TabStop = true;
			this.radioBtnMale.Text = "男性";
			this.radioBtnMale.UseVisualStyleBackColor = true;
			
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(91, 36);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(146, 31);
			this.txtAge.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(280, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "性別:";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAge.Location = new System.Drawing.Point(37, 41);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(48, 22);
			this.lblAge.TabIndex = 0;
			this.lblAge.Text = "年齡:";
			// 
			// grpBoxCalResult
			// 
			this.grpBoxCalResult.Controls.Add(this.lblChargeReason);
			this.grpBoxCalResult.Controls.Add(this.lblCarCharge);
			this.grpBoxCalResult.Location = new System.Drawing.Point(29, 187);
			this.grpBoxCalResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpBoxCalResult.Name = "grpBoxCalResult";
			this.grpBoxCalResult.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpBoxCalResult.Size = new System.Drawing.Size(481, 153);
			this.grpBoxCalResult.TabIndex = 1;
			this.grpBoxCalResult.TabStop = false;
			this.grpBoxCalResult.Text = "計算結果";
			// 
			// lblChargeReason
			// 
			this.lblChargeReason.AutoSize = true;
			this.lblChargeReason.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblChargeReason.Location = new System.Drawing.Point(37, 86);
			this.lblChargeReason.Name = "lblChargeReason";
			this.lblChargeReason.Size = new System.Drawing.Size(48, 22);
			this.lblChargeReason.TabIndex = 0;
			this.lblChargeReason.Text = "原因:";
			// 
			// lblCarCharge
			// 
			this.lblCarCharge.AutoSize = true;
			this.lblCarCharge.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblCarCharge.Location = new System.Drawing.Point(37, 43);
			this.lblCarCharge.Name = "lblCarCharge";
			this.lblCarCharge.Size = new System.Drawing.Size(48, 22);
			this.lblCarCharge.TabIndex = 0;
			this.lblCarCharge.Text = "車資:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 364);
			this.Controls.Add(this.grpBoxCalResult);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpBoxCalResult.ResumeLayout(false);
			this.grpBoxCalResult.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCount;
		private System.Windows.Forms.RadioButton radioBtnFemale;
		private System.Windows.Forms.RadioButton radioBtnMale;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.GroupBox grpBoxCalResult;
		private System.Windows.Forms.Label lblChargeReason;
		private System.Windows.Forms.Label lblCarCharge;
	}
}

