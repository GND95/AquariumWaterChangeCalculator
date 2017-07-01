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

        public Form1()
        {
            InitializeComponent();
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
            decimal result = 0;
            switch (counter)
            {
                case 1:
                    result = inputArray[1] / Convert.ToDecimal(totalWeight1.Text);
                    result = result * 5; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 2:
                    result = (inputArray[1] + inputArray[2]) / Convert.ToDecimal(totalWeight2.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 10; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 3:
                    result = (inputArray[1] + inputArray[2] + inputArray[3]) / Convert.ToDecimal(totalWeight3.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 15; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 4:
                    result = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4]) / Convert.ToDecimal(totalWeight4.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 20; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 5:
                    result = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5]) / Convert.ToDecimal(totalWeight5.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 25; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 6:
                    result = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6]) / Convert.ToDecimal(totalWeight6.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 30; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 7:
                    result = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7]) / Convert.ToDecimal(totalWeight7.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 35; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 8:
                    result = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7] + inputArray[8]) / Convert.ToDecimal(totalWeight8.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 40; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 9:
                    result = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7] + inputArray[8] + inputArray[9]) / Convert.ToDecimal(totalWeight9.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 45; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
                case 10:
                    result = (inputArray[1] + inputArray[2] + inputArray[3] + inputArray[4] + inputArray[5] + inputArray[6] + inputArray[7] + inputArray[8] + inputArray[9] + inputArray[10]) / Convert.ToDecimal(totalWeight10.Text);  //adding the weight of the buckets together and then dividing by what the weight should be
                    result = result * 50; //multiply the number of gallons that SHOULD be in the (5 gallon) bucket to give how many gallons you actually have based on the percent of weight (you have) to total weight (should be) of the bucket                    
                    result = result / aquariumSize;
                    MessageBox.Show("Your water change amount is " + Math.Round((result * 100), 2).ToString() + "% of your aquarium water.", "Result");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //how to use program and credits, implement later
        }
    }
}
