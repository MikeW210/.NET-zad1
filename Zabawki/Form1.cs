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
            speedBox.Enabled = false;
            riseBox.Enabled = false;
            accBox.Enabled = false;
        }

        // submarine faster
        private void button1_Click(object sender, EventArgs e)
        {
            if (listOfAdded.Text == "")
            {
                return;
            }
            else
            {
                Car tmp = (Car) listOfAdded.SelectedItem;
                tmp.Przyspiesz();
                speed.Text = tmp.getAcc().ToString();
               
            }
        }
        //submarine slower
        private void button2_Click(object sender, EventArgs e)
        {
            if (listOfAdded.Text == "")
            {
                return;
            }
            else
            {
                Car tmp = (Car)listOfAdded.SelectedItem;
                tmp.Zwolnij();
                speed.Text = tmp.getAcc().ToString();

                
            }

        }
        //car szybciej
        private void button5_Click(object sender, EventArgs e)
        {
                if (listOfAdded.Text == "")
                {
                    return;
                }
                else
                {
                    Submarine tmp = (Submarine)listOfAdded.SelectedItem;
                    tmp.Faster();
                    acc.Text = tmp.getSpeed().ToString();
            }

        }
        //car wolniej
        private void button6_Click(object sender, EventArgs e)
        {
                    if (listOfAdded.Text == "")
                    {
                        return;
                    }
                    else
                    {
                    Submarine tmp = (Submarine)listOfAdded.SelectedItem;
                    tmp.Slower();
                    acc.Text = tmp.getSpeed().ToString();
             }
        }
        //plane wysokosc
        private void button3_Click(object sender, EventArgs e)
        {
                        if (listOfAdded.Text == "")
                        {
                            return;
                        }
                        else
                        {
                        Plane tmp = (Plane)listOfAdded.SelectedItem;
                        tmp.Higher();
                        depth.Text = tmp.getRise().ToString();
            }
        }
        //plane niskosc
        private void button4_Click(object sender, EventArgs e)
        {
                            if (listOfAdded.Text == "")
                            {
                                return;
                            }
                            else
                            {
                                Plane tmp = (Plane)listOfAdded.SelectedItem;
                                tmp.Lower();
                                depth.Text = tmp.getRise().ToString();
            }
        }

        private void listOfToys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //przycisk add
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
                    listOfAdded.Items.Add(new Computer("Computer"));
                }
                if (listOfToys.Text == "Submarine")
                {
                    listOfAdded.Items.Add(new Submarine("Submarine"));
                }
                if (listOfToys.Text == "Plane")
                {
                    listOfAdded.Items.Add(new Plane("Plane"));
                }




        }

       
      

        private void speedBox_Enter(object sender, EventArgs e)
        {
        

        }
        //wybrane z drugiej listy
        private void listOfAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                speedBox.Enabled = true;
            }
            else
            {
                speedBox.Enabled = false;
                speed.Clear();
            }

            if (listOfAdded.SelectedItem is ISpeed)
            {
                accBox.Enabled = true;    
            }
            else
            {
                accBox.Enabled = false;
                acc.Clear();
            }

            if (listOfAdded.SelectedItem is IHeight)
            {
                riseBox.Enabled = true;
            }
            else
            {
                riseBox.Enabled = false;
                depth.Clear();
            }

            if (listOfAdded.SelectedItem as Car != null)
            {
                speed.Text = ((Car) listOfAdded.SelectedItem).getAcc().ToString();
                acc.Clear();
                depth.Clear();
            }

            if (listOfAdded.SelectedItem as Submarine != null)
            {
                speed.Clear();
                acc.Text = ((Submarine)listOfAdded.SelectedItem).getSpeed().ToString();
                depth.Clear();

            }
            if (listOfAdded.SelectedItem as Plane != null)
            {
                speed.Clear();
                acc.Clear();
                depth.Text = ((Plane)listOfAdded.SelectedItem).getRise().ToString();
            }

            if (listOfAdded.SelectedItem as Computer != null)
            {
                speed.Clear();
                acc.Clear();
                depth.Clear();
            }


            /* if (listOfAdded.SelectedItem as Computer != null)
             {
                 speedBox.Enabled = false;
                 accBox.Enabled = false;
                 riseBox.Enabled = false;




             }
             if (listOfAdded.Text.Contains("Car"))
             {

                 speedBox.Enabled = false;
                 accBox.Enabled = true;
                 riseBox.Enabled = false;




             }
             if (listOfAdded.Text.Contains("Submarine"))
             {
                 speedBox.Enabled = true;
                 accBox.Enabled = false;
                 riseBox.Enabled = false;



             }
             if (listOfAdded.Text.Contains("Plane"))
             {
                 speedBox.Enabled = false;
                 accBox.Enabled = false;
                 riseBox.Enabled = true;



             }
             */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listOfAdded.Items.Remove(listOfAdded.SelectedItem);
            speedBox.Enabled = false;
            speed.Clear();
            accBox.Enabled = false;
            acc.Clear();
            riseBox.Enabled = false;
            depth.Clear();

        }
    }
}
