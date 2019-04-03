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
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                IAccelerate car = (IAccelerate)listOfAdded.SelectedItem;
                speed.Text = car.Przyspiesz().ToString();

            }
            else
            {
                return;
               /* Car tmp = (Car) listOfAdded.SelectedItem;
                tmp.Przyspiesz();
                speed.Text = tmp.getAcc().ToString();*/
               
            }
        }
        //submarine slower
        private void button2_Click(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                IAccelerate car = (IAccelerate)listOfAdded.SelectedItem;
                speed.Text = car.Zwolnij().ToString();
            }
            else
            {
                return;
               /* Car tmp = (Car)listOfAdded.SelectedItem;
                tmp.Zwolnij();
                speed.Text = tmp.getAcc().ToString();*/

                
            }

        }
        //car szybciej
        private void button5_Click(object sender, EventArgs e)
        {
                if (listOfAdded.SelectedItem is ISpeed)
                {
                ISpeed sub = (ISpeed)listOfAdded.SelectedItem;
                acc.Text = sub.Faster().ToString();
            }
                else
                {
                return;
                   /* Submarine tmp = (Submarine)listOfAdded.SelectedItem;
                    tmp.Faster();
                    acc.Text = tmp.getSpeed().ToString();*/
            }

        }
        //car wolniej
        private void button6_Click(object sender, EventArgs e)
        {
                    if (listOfAdded.SelectedItem is ISpeed)
                    {
                        ISpeed sub = (ISpeed)listOfAdded.SelectedItem;
                        acc.Text = sub.Slower().ToString();
                     }
                    else
                    {
                return;
                    /*Submarine tmp = (Submarine)listOfAdded.SelectedItem;
                    tmp.Slower();
                    acc.Text = tmp.getSpeed().ToString();*/
             }
        }
        //plane wysokosc
        private void button3_Click(object sender, EventArgs e)
        {
                        if (listOfAdded.SelectedItem is IHeight)
                        {
                IHeight plane = (IHeight)listOfAdded.SelectedItem;
                depth.Text = plane.Lower().ToString();
            }
                        else
                        {
                return;
                       /* Plane tmp = (Plane)listOfAdded.SelectedItem;
                        tmp.Higher();
                        depth.Text = tmp.getRise().ToString();*/
            }
        }
        //plane niskosc
        private void button4_Click(object sender, EventArgs e)
        {
                            if (listOfAdded.SelectedItem is IHeight)
                            {
                IHeight plane = (IHeight)listOfAdded.SelectedItem;
                depth.Text = plane.Higher().ToString();
            }
                            else
                            {
                return;
                              /*  Plane tmp = (Plane)listOfAdded.SelectedItem;
                                tmp.Lower();
                                depth.Text = tmp.getRise().ToString();*/
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

       
      

        //wybrane z drugiej listy
        private void listOfAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                speedBox.Enabled = true;
                speed.Text = ((IAccelerate) listOfAdded.SelectedItem).getAcc().ToString();
            }
            else
            {
                speedBox.Enabled = false;
                speed.Clear();
            }

            if (listOfAdded.SelectedItem is ISpeed)
            {
                accBox.Enabled = true;    
                acc.Text = ((ISpeed)listOfAdded.SelectedItem).getSpeed().ToString();
            }
            else
            {
                accBox.Enabled = false;
                acc.Clear();
            }

            if (listOfAdded.SelectedItem is IHeight)
            {
                riseBox.Enabled = true;
                depth.Text = ((IHeight)listOfAdded.SelectedItem).getRise().ToString();
            }
            else
            {
                riseBox.Enabled = false;
                depth.Clear();
            }

           
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
