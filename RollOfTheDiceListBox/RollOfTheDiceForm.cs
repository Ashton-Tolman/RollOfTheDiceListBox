
/* Ashton Tolman
 * Spring 2026
 * RollOfTheDiceListBox
 * https://github.com/Ashton-Tolman/RollOfTheDiceListBox.git
 */
namespace RollOfTheDiceListBox
{
    public partial class RollOfTheDiceListBoxForm : Form
    {
        public RollOfTheDiceListBoxForm()
        {
            InitializeComponent();
        }


        //Custom Methods-------------------------------------------------------


        //Creates formatted string header to print as single item in list
        private void CreateHeader()
        {
            string header = "";
            int padding = 6;

            for (int i = 2; i < 13; i++)
            {
                header = header + $"{i}".PadRight(padding) + "|";
            }
            DisplayListBox.Items.Add(header);
        }

        private void AccumulateDataInString()
        {
            string finalData = "";
            Random diceRoll = new Random();
            int[] rollCount = new int[13];
            int padding = 5;

            //create counting array and collect data
            for (int i = 0; i < 1000; i++)
            {
                int rolledDice = diceRoll.Next(2, 13);
                rollCount[rolledDice]++;

            }

            for (int i = 2; i < 13; i++)
            {
                finalData += $"{rollCount[i]}".PadRight(padding) + "|";
            }
            DisplayListBox.Items.Add(finalData);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
        }

        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            string padding = "                           ";

            DisplayListBox.Items.Add(padding + "Roll Of The Dice");

            //Print header 
            CreateHeader();
            //Line break
            DisplayListBox.Items.Add(new string('-', 71));

            //Print data
            AccumulateDataInString();

            //Line break
            DisplayListBox.Items.Add(new string('-', 71));

        }
    }
}
