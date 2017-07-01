using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium_Calculator
{
    public partial class Form1 : Form
    {
        decimal[] inputArray = new decimal[11];//has 11 items because it starts at 1 and skips 0
        int counter = 0;//to increment through the array each time the user enters a new value in the text box  
        decimal initialResult = 0; //the amount of water in pounds (and then divided by the weight of what should be in the bucket, ex: 34 lbs / 41.7 lbs to give the ratio of weight in the bucket to what the weight in the bucket should be for it to be for 5, 10, etc amount of gallons depending on how many buckets the user enters)
        decimal secondResult = 0; //the amount of water in gallons. this variable is used if the user copies the information to their clipboard
        decimal finalResult = 0; //final answer, the percentage of water changed in the aquarium

        public Form1()
        {
            InitializeComponent();
        }

        void resultMessage()
        {
            MessageBox.Show("Your water change amount is " + Math.Round((finalResult * 100), 2).ToString() + "% of your aquarium water.", "Result");
            DialogResult dialog = MessageBox.Show("Would you like to copy this information to clipboard?", "Result", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Information copied to clipboard! Use either ctrl+V or right-click and \"paste\" to use this information elsewhere.", "Result");
                String Today = DateTime.Today.ToString("d");
                Clipboard.SetText("Date: " + Today + "      Water Change Percent: " + Math.Round((finalResult * 100), 2) + "%" + "       Water Change Amount: " + Math.Round((secondResult), 2) + " Gallons");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Show();
            label4.Show();
            label5.Show();
            label8.Show();
            counter++;
            inputArray[counter] = Convert.ToDecimal(textBox1.Text);

            switch (counter)
            {
                case 1:
                    weight1.Text = inputArray[counter].ToString();
                    break;
                case 2:
                    weight2.Text = inputArray[counter].ToString();
                    break;
                case 3:
                    weight3.Text = inputArray[counter].ToString();
                    break;
                case 4:
                    weight4.Text = inputArray[counter].ToString();
                    break;
                case 5:
                    weight5.Text = inputArray[counter].ToString();
                    break;
                case 6:
                    weight6.Text = inputArray[counter].ToString();
                    break;
                case 7:
                    weight7.Text = inputArray[counter].ToString();
                    break;
                case 8:
                    weight8.Text = inputArray[counter].ToString();
                    break;
                case 9:
                    weight9.Text = inputArray[counter].ToString();
                    break;
                case 10:
                    weight10.Text = inputArray[counter].ToString();
                    break;
            }
            textBox1.Text = "";

            if (this.Height < 700) //prevent the form from being increased in size beyond the maximum allowed number of buckets
            {
                this.Height += 43; //increase the size of the form to show information about more buckets of water
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //final calculation    
            decimal aquariumSize = Convert.ToDecimal(textBox2.Text); //the number of gallons the aquarium is           
            switch (counter)
            {
                case 1:
                    initialResult = inputArray[1] / Convert.ToDecimal(totalWeight1.Text);
                    secondResult = initialResult * 5; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 2:
                    initialResult = (inputArray[1] + inputArray[2]) / Convert.ToDecimal(totalWeight2.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 10; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 3:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3]) / Convert.ToDecimal(totalWeight3.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 15; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 4:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4]) / Convert.ToDecimal(totalWeight4.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 20; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 5:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5]) / Convert.ToDecimal(totalWeight5.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 25; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 6:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6]) / Convert.ToDecimal(totalWeight6.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 30; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 7:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7]) / Convert.ToDecimal(totalWeight7.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 35; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 8:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7] + inputArray[8]) / Convert.ToDecimal(totalWeight8.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 40; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 9:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7] + inputArray[8] + inputArray[9]) / Convert.ToDecimal(totalWeight9.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 45; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
                case 10:
                    initialResult = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7] + inputArray[8] + inputArray[9] + inputArray[10]) / Convert.ToDecimal(totalWeight10.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    secondResult = initialResult * 50; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the buckets                    
                    finalResult = secondResult / aquariumSize;
                    resultMessage();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e) //credits
        {
            MessageBox.Show("Program was created by Garrett DeBlois, 2017", "Credits");
        }

        private void button4_Click(object sender, EventArgs e) //tutorial
        {
            MessageBox.Show("The left text box is for the weight of water in your bucket. If you have more than 1, five-gallon bucket, submit the first bucket and the form will dynamically increase in size to accommodate more buckets (up to a maximum of 10, five-gallon buckets).", "Tutorial Message 1 of 3");
            MessageBox.Show("You only need to enter the total size of your aquarium(in gallons) one single time, at the end right before you click the \"Calculate Total\" button. This will add all the weights of your buckets together and find out how many gallons this is and then divide that number by your aquarium gallon size to find out what percent of your aquarium water you changed this time.", "Tutorial Message 2 of 3");
            MessageBox.Show("If you would like to copy today's date, the water change percent, and the total amount of water (in gallons) you put in your aquarium this water change, click yes on the pop-up message at the end and you can then paste this information into a spreadsheet or other place so you can keep track of your aquarium water changes.", "Tutorial Message 3 of 3");
        }
    }
}
