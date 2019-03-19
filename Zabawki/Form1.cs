using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form1 : Form
    {
        Car car = new Car();
        Plane plane = new Plane();
        Submarine submarine = new Submarine();
        Computer computer = new Computer();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listOfAdded.Text == "")
            {
                return;
            }
            else
            {
                
         
                textBox1.Text = car.Przyspiesz().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listOfAdded.Text == "")
            {
                return;
            }
            else
            {
               
                textBox1.Text = car.Zwolnij().ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
                if (listOfAdded.Text == "")
                {
                    return;
                }
                else
                {
                    
                    textBox2.Text = submarine.Faster().ToString();
                }

        }

        private void button6_Click(object sender, EventArgs e)
        {
                    if (listOfAdded.Text == "")
                    {
                        return;
                    }
                    else
                    {
                       
                        textBox2.Text = submarine.Slower().ToString();
                    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                        if (listOfAdded.Text == "")
                        {
                            return;
                        }
                        else
                        {
                           
                            textBox3.Text = plane.Higher().ToString();
                        }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                            if (listOfAdded.Text == "")
                            {
                                return;
                            }
                            else
                            {
                                
                                textBox3.Text = plane.Lower().ToString();
                            }
        }

        private void listOfToys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
          
                if (listOfToys.SelectedItem == null)
                {
                    return;
                }

                if (listOfToys.Text == "Car")
                {
                    listOfAdded.Items.Add(new Car("Car"));
                }
                if (listOfToys.Text == "Computer")
                {
                    listOfAdded.Items.Add(new Car("Computer"));
                }
                if (listOfToys.Text == "Submarine")
                {
                    listOfAdded.Items.Add(new Car("Submarine"));
                }
                if (listOfToys.Text == "Plane")
                {
                    listOfAdded.Items.Add(new Car("Plane"));
                }




        }

       
      

        private void speedBox_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void listOfAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listOfAdded.Text.Contains("Computer"))
            {
                speedBox.Visible = false;
                accBox.Visible = false;
                riseBox.Visible = false;

               
            }
            if (listOfAdded.Text.Contains("Car"))
            {
                speedBox.Visible = false;
                accBox.Visible = true;
                riseBox.Visible = false;


            }
            if (listOfAdded.Text.Contains("Submarine"))
            {
                speedBox.Visible = true;
                accBox.Visible = false;
                riseBox.Visible = false;


            }
            if (listOfAdded.Text.Contains("Plane"))
            {
                speedBox.Visible = false;
                accBox.Visible = false;
                riseBox.Visible = true;


            }
        }
    }
}
/* public void Przyspiesz()
       {
           acc++;

       }

       public void Zwolnij()
       {
           acc--;
           if(acc <= 0)
           {
               acc = 0;
           }
       }

       public void Faster()
       {
           speed++;
       }

       public void Slower()
       {
           speed--;
           if (speed <= 0)
           {
               speed = 0;
           }
       }

       public void Higher()
       {
           height++;
       }

       public void Lower()
       {
           height--;
           if (height <= 0)
           {
               height = 0;
           }
       }
       */

