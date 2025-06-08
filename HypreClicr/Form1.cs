using System.ComponentModel;
using System.Numerics;

namespace HypreClicr
{
    public partial class Form1 : Form
    {
        int points = 0;
        int level = 0;

        int clickPower = 1;
        int income = 0;



        Dictionary<string, int> upgradeCost = new Dictionary<string, int> {
            {"Click", 10 },
            {"Income", 50 },
            {"IncomeSpeed", 2000 },
            {"ClickCost", 500 }
        };

        Dictionary<string, bool> passives = new Dictionary<string, bool>
        {
            {"IncomeSpeed", false },
            {"Progress", false },
            {"ClickCost", false }
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            incomeTimer.Enabled = true;
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            add_points(clickPower);
            add_progress(clickPower);
        }

        private void add_points(int p)
        {
            points += p;
            pointsLabel.Text = pointsLabel.Text = $"Points: {points}";
        }

        private void rm_points(int p)
        {
            points -= p;
            pointsLabel.Text = pointsLabel.Text = $"Points: {points}";
        }

        private void next_level()
        {
            level++;
            levelLabel.Text = $"Level: {level}";
            progressBar1.Maximum = (int)(progressBar1.Maximum * 1.5);
            progressBar1.Value = 0;
        }

        private void add_progress(int p)
        {
            if (progressBar1.Value + p < progressBar1.Maximum)
            {
                progressBar1.Value += p;
            }
            else
            {
                next_level();

            }

        }

        private void upgradeClickButton_Click(object sender, EventArgs e)
        {
            if (upgradeCost["Click"] <= points)
            {
                clickPower++;
                rm_points(upgradeCost["Click"]);
                upgradeCost["Click"] = (int)(upgradeCost["Click"] * 2);
                if (passives["ClickCost"])
                {
                    upgradeCost["Click"] = (int)(upgradeCost["Click"] * 0.7);
                }
                powerLabel.Text = $"Click Power: {clickPower}";
                upgradeClickButton.Text = $"Upgrade Click Power: {upgradeCost["Click"]}";
            }
        }

        private void incomeTimer_Tick(object sender, EventArgs e)
        {
            add_points(income);
        }

        private void upgradeIncomeButton_Click(object sender, EventArgs e)
        {
            if (upgradeCost["Income"] <= points)
            {
                income += 5;
                rm_points(upgradeCost["Income"]);
                upgradeCost["Income"] = (int)(upgradeCost["Income"] * 1.5);
                incomeLabel.Text = $"Passive Income: {income}";
                upgradeIncomeButton.Text = $"Upgrade Passive Income: {upgradeCost["Income"]}";
            }
        }

        private void incomeSpeedButton_Click(object sender, EventArgs e)
        {
            if (upgradeCost["IncomeSpeed"] <= points)
            {
                rm_points(upgradeCost["IncomeSpeed"]);
                passives["IncomeSpeed"] = true;
                incomeTimer.Interval = 1500;

                incomeSpeedButton.Text = "Sold";
                incomeSpeedButton.Enabled = false;
            }
        }

        private void clickCostButton_Click(object sender, EventArgs e)
        {
            if (upgradeCost["ClickCost"] <= points)
            {
                rm_points(upgradeCost["ClickCost"]);
                passives["ClickCost"] = true;

                upgradeCost["Click"] = (int)(upgradeCost["Click"] * 0.7);
                upgradeClickButton.Text = $"Upgrade Click Power: {upgradeCost["Click"]}";

                clickCostButton.Text = "Sold";
                clickCostButton.Enabled = false;
            }
        }
    }
}
