using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location_Generator
{
    public partial class fmLocGen : Form
    {

        int _currentLocation = 0;

        public fmLocGen()
        {
            InitializeComponent();
        }

        public void btnNextLoc_Click(object sender, EventArgs e)
        {
            GenerateNumber(); 
        }

        public void GenerateNumber()
        {
            var locID = RandomNumberGenerator.NumberBetween();

            if (locID == _currentLocation)
            {
                GenerateNumber();
            }
            else
            {
                _currentLocation = locID;

                foreach (var item in Place.Locations)
                {
                    if (item.ID == locID)
                    {
                        lblLocation.Text = item.Name;

                        lblDescr.Text = item.Description;
                    }
                }
            }

            
        }
        
    }
}
