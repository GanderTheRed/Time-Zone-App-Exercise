namespace Time_Zone_App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string City = "";                                   //Sets initial City variable.

            if (lstCity.SelectedIndex != -1)
            {
                City = lstCity.SelectedItem.ToString();         //Checks if a selection has been made in the list box, and then assigns selected value to City..
            }
            else
            {

            }

            switch(City)                                        //Switch to display timezone based on city value.
            {
                case "Denver":
                    lblTimeZoneOut.Text = "Mountain Standard Time GMT -6";
                    break;

                case "Honolulu":
                    lblTimeZoneOut.Text = "Hawaii-Aleutian Standard Time GMT -10";
                    break;

                case "Minneapolis":
                    lblTimeZoneOut.Text = "Central Daylight Saving Time GMT -5";
                    break;

                case "New York":
                    lblTimeZoneOut.Text = "Eastern Daylight Saving Time GMT -4";
                    break;

                case "San Francisco":
                    lblTimeZoneOut.Text = "Pacific Daylight Saving Time GMT -7";
                    break;

                default:
                    lblTimeZoneOut.Text = "";
                    break;


            }
        }
    }
}