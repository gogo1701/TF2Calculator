namespace RefinedCalculator
{
    public partial class Form1 : Form
    {
        int scrap = 0;
        double scrapValue = 0;
        int refined = 0;
        double refinedValue = 0;
        int reclaimed = 0;
        double reclaimedValue = 0;
        double value = 0;
        public Form1()
        {
            InitializeComponent();

        }


        private void deletescrap_Click(object sender, EventArgs e)
        {
            if (scrap != 0)
            {
                if (scrap % 9 == 0)
                {
                    scrapValue = scrapValue - 0.01;
                }
                scrapValue = scrapValue - 0.11;
                scrapValue = Math.Round(scrapValue, 2);
                scrap--;
                ScrapLabel.Text = scrap.ToString();
            }
            value = scrapValue + reclaimedValue + refinedValue;
            ValueLabel.Text = "Value: " + value.ToString("F2");
        }


        private void addscrap_Click(object sender, EventArgs e)
        {
                scrap++;
            scrapValue = scrapValue + 0.11;
            ScrapLabel.Text = scrap.ToString();
            if (scrap % 9 == 0)
            {
                scrapValue = Math.Round(Math.Ceiling(scrapValue), 2);
            }
            value = scrapValue + reclaimedValue + refinedValue;
            ValueLabel.Text = "Value: " + value.ToString("F2");

        }

        private void deletereclaimed_Click(object sender, EventArgs e)
        {
            if (reclaimed != 0)
            {
                if (reclaimed % 3 == 0)
                {
                    reclaimedValue = reclaimedValue - 0.01; 
                }

                reclaimed--; 

                reclaimedValue = reclaimedValue - 0.33;
                reclaimedValue = Math.Round(reclaimedValue, 2);


                ReclaimedLabel.Text = reclaimed.ToString();
            }

            value = scrapValue + reclaimedValue + refinedValue;
            ValueLabel.Text = "Value: " + value.ToString("F2");
        }
        private void addreclaimed_Click(object sender, EventArgs e)
        {
            reclaimed++;
            reclaimedValue = reclaimedValue + 0.33;
            ReclaimedLabel.Text = reclaimed.ToString();
            if(reclaimed % 3 == 0)
            {
                reclaimedValue = Math.Round(Math.Ceiling(reclaimedValue), 2);
            }
            value = scrapValue + reclaimedValue + refinedValue;
            ValueLabel.Text = "Value: " + value.ToString("F2");
        }

        private void deleterefined_Click(object sender, EventArgs e)
        {
            if (refined != 0)
            {
                refined--;
                refinedValue--;
                RefinedLabel.Text = refined.ToString();

            }
            value = scrapValue + reclaimedValue + refinedValue;
            ValueLabel.Text = "Value: " + value.ToString("F2");
        }

        private void addrefined_Click(object sender, EventArgs e)
        {
            refined++;
            refinedValue++;
            RefinedLabel.Text = refined.ToString();
            value = scrapValue + reclaimedValue + refinedValue;
            ValueLabel.Text = "Value: " + value.ToString("F2");
        }


    }
}