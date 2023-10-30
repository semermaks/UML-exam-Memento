using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLexamMemento.Properties;

namespace UMLexamMemento
{
	public partial class Form1 : Form
	{
		Originator o = new Originator();
		Caretaker c = new Caretaker();
		private bool now = true;
		Button btn;
		public Form1()
		{
			InitializeComponent();
		}
		private void SetSender(object sender)
		{
			switch ((sender as Button).Name)
			{
				case "button1":
					if (o.arr[0, 0] == null)
					{
						o.arr[0, 0] = now;
					}
					break;
				case "button2":
					if (o.arr[0, 1] == null)
					{
						o.arr[0, 1] = now;
					}
					break;
				case "button3":
					if (o.arr[0, 2] == null)
					{
						o.arr[0, 2] = now;
					}
					break;
				case "button4":
					if (o.arr[1, 0] == null)
					{
						o.arr[1, 0] = now;
					}
					break;
				case "button5":
					if (o.arr[1, 1] == null)
					{
						o.arr[1, 1] = now;
					}
					break;
				case "button6":
					if (o.arr[1, 2] == null)
					{
						o.arr[1, 2] = now;
					}
					break;
				case "button7":
					if (o.arr[2, 0] == null)
					{
						o.arr[2, 0] = now;
					}
					break;
				case "button8":
					if (o.arr[2, 1] == null)
					{
						o.arr[2, 1] = now;
					}
					break;
				case "button9":
					if (o.arr[2, 2] == null)
					{
						o.arr[2, 2] = now;
					}
					break;
			}
			if (now)
			{
				(sender as Button).BackgroundImage = Resources.krestik;
				now = false;
				label.Text = "Ходит нолик";
			}
			else
			{
				(sender as Button).BackgroundImage = Resources.nolik;
				now = true;
				label.Text = "Ходит крестик";
			}
			c.Memento = o.CreateMemento();
			btn = sender as Button;
			CheckWinner();
		}

		private void CheckWinner()
		{
			btnBack.Enabled = true;

			if (o.arr[0, 0] == true && o.arr[1, 1] == true && o.arr[2, 2] == true
				|| o.arr[0, 0] == true && o.arr[1, 0] == true && o.arr[2, 0] == true
				|| o.arr[0, 1] == true && o.arr[1, 1] == true && o.arr[2, 1] == true
				|| o.arr[0, 2] == true && o.arr[1, 2] == true && o.arr[2, 2] == true
				|| o.arr[0, 0] == true && o.arr[0, 1] == true && o.arr[0, 2] == true
				|| o.arr[1, 0] == true && o.arr[1, 1] == true && o.arr[1, 2] == true
				|| o.arr[2, 0] == true && o.arr[2, 1] == true && o.arr[2, 2] == true
				|| o.arr[2, 0] == true && o.arr[1, 1] == true && o.arr[0, 2] == true)
			{
				MessageBox.Show("Крестик выиграл!");
			}
			else if (o.arr[0, 0] == false && o.arr[1, 1] == false && o.arr[2, 2] == false
				|| o.arr[0, 0] == false && o.arr[1, 0] == false && o.arr[2, 0] == false
				|| o.arr[0, 1] == false && o.arr[1, 1] == false && o.arr[2, 1] == false
				|| o.arr[0, 2] == false && o.arr[1, 2] == false && o.arr[2, 2] == false
				|| o.arr[0, 0] == false && o.arr[0, 1] == false && o.arr[0, 2] == false
				|| o.arr[1, 0] == false && o.arr[1, 1] == false && o.arr[1, 2] == false
				|| o.arr[2, 0] == false && o.arr[2, 1] == false && o.arr[2, 2] == false
				|| o.arr[2, 0] == false && o.arr[1, 1] == false && o.arr[0, 2] == false)
			{
				MessageBox.Show("Нолик выиграл!");
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SetSender(sender);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			o.SetMemento(c.Memento);
			btn.BackgroundImage = null;
			if(now) now = false;
			else now = true;
		}
	}
}