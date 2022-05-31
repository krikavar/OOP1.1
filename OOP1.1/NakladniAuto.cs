using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1._1
{
	internal class NakladniAuto
	{
		public string spz;
		public int nosnost;
		public int hmotnost_nakladu;

		public NakladniAuto(string spz, int nosnost)
		{
			this.hmotnost_nakladu = 0;
			this.spz = spz;
			this.nosnost = nosnost;
		}
		public void NalozNaklad(int hmotnost_nakladu)
		{
			if ((this.hmotnost_nakladu + hmotnost_nakladu) <= this.nosnost)
			{
				this.hmotnost_nakladu += hmotnost_nakladu;
			}
			else
			{
				MessageBox.Show("Nemohlo být naloženo: " + (hmotnost_nakladu - (this.nosnost - this.hmotnost_nakladu)));
				this.hmotnost_nakladu += (this.nosnost - this.hmotnost_nakladu);
			}
		}
		public void VylozNaklad(int hmotnost_nakladu)
		{
			if (hmotnost_nakladu <= this.hmotnost_nakladu)
			{
				this.hmotnost_nakladu -= hmotnost_nakladu;
			}
			else
			{
				MessageBox.Show("Nemohlo být vyloženo: " + (hmotnost_nakladu - this.hmotnost_nakladu));
				this.hmotnost_nakladu = 0;
			}
		}
		public override string ToString()
		{
			return "Nakladni auto " + this.spz + " má nosnost " + this.nosnost + " t a má naloženo " + this.hmotnost_nakladu;
		}
	
	}
}
