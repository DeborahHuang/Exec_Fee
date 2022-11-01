using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exec_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblCarCharge.Text = String.Empty;
			lblChargeReason.Text = String.Empty;
		}

		private void btnCount_Click(object sender, EventArgs e)
		{
			int age = 0;
			bool gender = true;
			int chargeFee=0;

			try
			{				
				age = GetAge();
				gender = GetGender();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			chargeFee = ChargeStandard(age,gender);
			
			
			if (chargeFee == 3)
			{
				lblCarCharge.Text = $"您的車資為{chargeFee}元";
				lblChargeReason.Text = $"因為您為{radioBtnFemale.Text}且大於60歲";
			}

			else if (chargeFee == 2)
			{
				lblCarCharge.Text = $"您的車資為{chargeFee}元";
				lblChargeReason.Text = $"因為您為{radioBtnMale.Text}且大於70歲";
			}

			else if (chargeFee == 0)
			{
				lblCarCharge.Text = $"您的車資為{chargeFee}元";
				lblChargeReason.Text = $"3歲以下孩童免費";
			}

			else
			{
				lblCarCharge.Text = $"您的車資為15元";
				lblChargeReason.Text = $"您購買的是全票";
			}
			return;
		}

		private int ChargeStandard(int age,bool gender)
		{
			int chargeFee;
			if (age >= 70 && gender == true)chargeFee = 2;
			else if (age >= 60 && gender == false) chargeFee = 3;
			else if (age <= 3) chargeFee = 0;
			else chargeFee = 15;
			return chargeFee;
		}

		private bool GetGender()
		{
			bool gender;
			
			if (radioBtnMale.Checked) gender = true;
			if (radioBtnFemale.Checked) gender = false;
			else throw new Exception("請選擇性別");
			return gender;
		}

		private int GetAge()
		{
			string input= txtAge.Text;
			bool isInt = int.TryParse(input, out int age);
			if (isInt == false) throw new Exception("請輸入年齡");
			return age;
		}
	}
}
