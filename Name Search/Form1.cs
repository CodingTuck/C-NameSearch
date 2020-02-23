using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void checkNameButton_Click(object sender, EventArgs e)
        {
            const int NAMESIZE = 200; //total number of names in each file
            string[] boyNames = new string[NAMESIZE]; //array of names
            string[] girlNames = new string[NAMESIZE]; //array of names
            int index = 0;
            string boyName;
            string girlName;
            Boolean girlInput = false;
            Boolean boyInput = false;
            StreamReader boySearchFile; //boy file input
            StreamReader girlSearchFile; //girl file input

            //get StreamReader object
            boySearchFile = File.OpenText("BoyNames.txt"); //opens file
            girlSearchFile = File.OpenText("GirlNames.txt"); //opens file

            girlName = girlTextBox.Text;
            boyName = boyTextBox.Text; //initialize boyName with user input
            if (string.IsNullOrEmpty(boyTextBox.Text) == boyInput) //tests if there is any name typed in boyTextBox
            {

                while (index < boyNames.Length && !boySearchFile.EndOfStream)
                {
                    boyNames[index] = boySearchFile.ReadLine();//initialize 0 of the file to string
                    if (boyName == boyNames[index])//if number length of array equals user input then message box shows
                    {
                        //Message box showing user input equals a name in the file
                        MessageBox.Show(boyTextBox.Text + " is in the top 200 names for boys!");
                        break;
                    }
                    index++;
                }
                if (index == boyNames.Length)
                {
                    //message box showing user input doesn't equal name in the file
                    MessageBox.Show(boyTextBox.Text + " is NOT in the top 200 names for boys!");
                }
                
            }
            index = 0; //resets index in order for loop to run
            if (string.IsNullOrEmpty(girlTextBox.Text) == girlInput) //tests if there is any name typed in girlTextBox
            {

                while (!girlSearchFile.EndOfStream) //initiate loop
                {
                    girlNames[index] = girlSearchFile.ReadLine(); //initialize 0 of the file to string
                    if (girlName == girlNames[index]) //if number length of array equals user input then message box shows
                    {
                        //Message box showing user input equals a name in the file
                        MessageBox.Show(girlTextBox.Text + " is in the top 200 names for girls!");
                        break;
                    }
                    index++;
                }
                if (index == girlNames.Length) //runs if it gets through all 200 names and the name doesn't equal
                {
                    //message box showing user input doesn't equal name in the file
                    MessageBox.Show(girlTextBox.Text + " is NOT in the top 200 names for girls!");
                }

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
