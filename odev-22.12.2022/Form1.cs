using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_22._12._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        int row;
        int MaxX = 700;
        // int MaxY = 489;
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int x = button1.Size.Width;
            int LocationX = button1.Location.X;
            int y = button1.Size.Height;
            int LocationY = button1.Location.Y;
           
          
           

          


            if (MaxX > LocationX && row %2 == 0)
            {
                button1.Location = new Point(LocationX + x, LocationY);
            }
             else if(row%2==1)
            {
      
                button1.Location = new Point(LocationX-x, LocationY);
                if (LocationX < 100)
                {
                    button1.Location = new Point(LocationX, LocationY + y);
                    row++;
                }
               
            }else
            {
                button1.Location = new Point(LocationX, LocationY+y);
                row++;
            }

            if (row > 7)
            {
                MessageBox.Show("OYUN BİTTİ....");
                Application.Exit();
            }     
                  
             
            

        }

        
    }
}
