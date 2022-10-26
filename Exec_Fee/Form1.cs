using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exec_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCount_Click(object sender, EventArgs e)
		{
			int age = 0;
			bool gender = true;
			int chargeFee=0;

			try
			{
				gender = GetGender();
				age = GetAge();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			//ToDo chargeStandard gender計算標準
			int value = ChargeStandard(RadioButton.XXX, txtAge.Text);
			string carCharge = chargeFee.ToString();


		}

		private int ChargeStandard(bool gender, int age)
		{
			int chargeFee;

			if (age >= 70 && gender == true)chargeFee = 2;
			else if (age >= 60 && gender == false)chargeFee = 3;
			else if (age <= 3)chargeFee = 0;
			else chargeFee = 15;
			return chargeFee;

		}

		private bool GetGender()
		{
			//ToDo Gender獲得值
			bool selection = RadioButton.ControlCollection;
			if (selection == null) throw new Exception("請選擇性別");
			if (selection == true) gender = true;
			else gender = false;
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
