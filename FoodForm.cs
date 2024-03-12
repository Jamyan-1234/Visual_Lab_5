using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5

{
    public partial class FoodForm : Form
    {

        public FoodForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }










        ///////////////////////////////////////////////////////////////////////////////
        private void checkBox1_CheckedChanged(object sender, EventArgs e)             //
        {                                                                             //
            if (food1halfch.Checked == true)                      //Food1Halfcheckbox
            {
                food1halfq.Enabled = true;
            }                                                      //Food1Halfcheckbox
            else
            {
                food1halfq.Enabled = false;                         //Food1Halfcheckbox                   //
            }                                                                         //
        }///////////////////////////////////////////////////////////////////////////////






        private void FoodForm_Load(object sender, EventArgs e)
        {
            food1halfch.Enabled = false;                      //FOOD
            food1halfq.Enabled = false;        //
            food1fullch.Enabled = false;//
            food1fullq.Enabled = false;
            //MAIN LOGIC//
            //
            food2halfch.Enabled = false;//
            food2halfq.Enabled = false;
            food2fullch.Enabled = false;//
            food2fullq.Enabled = false;

            //
            food3halfch.Enabled = false;//
            food3halfq.Enabled = false;
            food3fullch.Enabled = false;
            food3fullq.Enabled = false;


            food4halfch.Enabled = false;
            food4halfq.Enabled = false;
            food4fullch.Enabled = false;
            food4fullq.Enabled = false;                       //FOOD








            zuush1halfch.Enabled = false;                     //ZUUSH
            zuush1halfq.Enabled = false;        //
            zuush1fullch.Enabled = false;//
            zuush1fullq.Enabled = false;

            zuush2halfch.Enabled = false;//
            zuush2halfq.Enabled = false;
            zuush2fullch.Enabled = false;//
            zuush2fullq.Enabled = false;


            zuush3halfch.Enabled = false;
            zuush3halfq.Enabled = false;
            zuush3fullch.Enabled = false;
            zuush3fullq.Enabled = false;                     //ZUUSH









        }









        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox18_CheckedChanged(object sender, EventArgs e)                             //
        {
            if (food4.Checked == true)                               //FOOD 4 CHECKBOX                 //
            {
                food4halfch.Enabled = true;
                food4fullch.Enabled = true;


            }
            else
            {
                food4halfch.Enabled = false;
                food4halfq.Enabled = false;                      //FOOD 4 CHECKBOX
                food4fullch.Enabled = false;
                food4fullq.Enabled = false;

                food4halfch.Checked = false;
                food4halfq.Text = "";
                food4fullch.Checked = false;
                food4fullq.Text = "";                            //FOOD 4 CHECKBOX
                                                                 //
            }
        }/////////////////////////////////////////////////////////////////////////////////////////////////






        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush2.Checked == true)                               //ZUUSH 2 CHECKBOX 
            {
                zuush2halfch.Enabled = true;
                zuush2halfq.Enabled = false;
                zuush2fullch.Enabled = true;


            }
            else
            {
                zuush2halfch.Enabled = false;
                zuush2halfq.Enabled = false;                      //ZUUSH 2 CHECKBOX
                zuush2fullch.Enabled = false;
                zuush2fullq.Enabled = false;

                zuush2halfch.Checked = false;
                zuush2halfq.Text = "";
                zuush2fullch.Checked = false;
                zuush2fullq.Text = "";                            //ZUUSH 2 CHECKBOX
                                                                  //
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////










        /////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush3.Checked == true)                               //ZUUSH 3 CHECKBOX 
            {
                zuush3halfch.Enabled = true;
                zuush3halfq.Enabled = false;
                zuush3fullch.Enabled = true;


            }
            else
            {
                zuush3halfch.Enabled = false;
                zuush3halfq.Enabled = false;                      //ZUUSH 3 CHECKBOX
                zuush3fullch.Enabled = false;
                zuush3fullq.Enabled = false;

                zuush3halfch.Checked = false;
                zuush3halfq.Text = "";
                zuush3fullch.Checked = false;
                zuush3fullq.Text = "";                            //ZUUSH 3 CHECKBOX
                                                                  //
            }
        }


















        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox15_CheckedChanged(object sender, EventArgs e)                             //
        {
            if (food1.Checked == true)                               //FOOD 1 CHECKBOX                 //
            {
                food1halfch.Enabled = true;
                food1fullch.Enabled = true;


            }
            else
            {
                food1halfch.Enabled = false;
                food1halfq.Enabled = false;                      //FOOD 1 CHECKBOX
                food1fullch.Enabled = false;
                food1fullq.Enabled = false;

                food1halfch.Checked = false;
                food1halfq.Text = "";
                food1fullch.Checked = false;
                food1fullq.Text = "";                            //FOOD 1 CHECKBOX

            }

            //                                                                                          //
        }/////////////////////////////////////////////////////////////////////////////////////////////








        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void food2_CheckedChanged(object sender, EventArgs e)                                   //
        {//
            if (food2.Checked == true)                               //FOOD 2 CHECKBOX                 //
            {
                food2halfch.Enabled = true;
                food2halfq.Enabled = false;
                food2fullch.Enabled = true;


            }
            else
            {
                food2halfch.Enabled = false;
                food2halfq.Enabled = false;                      //FOOD 2 CHECKBOX
                food2fullch.Enabled = false;
                food2fullq.Enabled = false;

                food2halfch.Checked = false;
                food2halfq.Text = "";
                food2fullch.Checked = false;
                food2fullq.Text = "";                            //FOOD 2 CHECKBOX
                                                                 //
            }                                                                                           //
        }/////////////////////////////////////////////////////////////////////////////////////////////////









        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void food3_CheckedChanged(object sender, EventArgs e)                                  //
        {
            if (food3.Checked == true)                               //FOOD 3 CHECKBOX                 //
            {
                food3halfch.Enabled = true;
                food3fullch.Enabled = true;


            }
            else
            {
                food3halfch.Enabled = false;
                food3halfq.Enabled = false;                      //FOOD 3 CHECKBOX
                food3fullch.Enabled = false;
                food3fullq.Enabled = false;

                food3halfch.Checked = false;
                food3halfq.Text = "";
                food3fullch.Checked = false;
                food3fullq.Text = "";                            //FOOD 3 CHECKBOX
                                                                 //
            }                                                                                            //
        }//////////////////////////////////////////////////////////////////////////////////////////////////





        private void food1fullq_TextChanged(object sender, EventArgs e)
        {

        }




        ///////////////////////////////////////////////////////////////////////////////
        private void food1fullch_CheckedChanged_1(object sender, EventArgs e)         //
        {
            if (food1fullch.Checked == true)                     //FOOD 1 FULL CHECKBOX
            {
                food1fullq.Enabled = true;
            }                                                    //FOOD 1 FULL CHECKBOX
            else
            {
                food1fullq.Enabled = false;
                food1fullq.Text = string.Empty;                  //FOOD 1 FULL CHECKBOX
            }                                                                          //
        }//////////////////////////////////////////////////////////////////////////////







        private void food1halfq_TextChanged(object sender, EventArgs e)
        {

        }



        ///////////////////////////////////////////////////////////////////////////////////////////
        private void food2halfch_CheckedChanged_1(object sender, EventArgs e)                    //
        {
            if (food2halfch.Checked == true)                      //Food2Halfcheckbox
            {
                food2halfq.Enabled = true;
            }                                                      //Food2Halfcheckbox
            else
            {
                food2halfq.Enabled = false;                         //Food2Halfcheckbox                   
            }                                                                                    //
        }///////////////////////////////////////////////////////////////////////////////////////////





        //}///////////////////////////////////////////////////////////////////////////////////////////
        private void food2fullch_CheckedChanged(object sender, EventArgs e)                         //
        {                                                                                            //
            if (food2fullch.Checked == true)                     //FOOD 2 FULL CHECKBOX
            {
                food2fullq.Enabled = true;
            }                                                    //FOOD 2 FULL CHECKBOX
            else
            {
                food2fullq.Enabled = false;
                food2fullq.Text = string.Empty;                  //FOOD 2 FULL CHECKBOX
            }                                                                                         //
        }                                                                                            //
        //}///////////////////////////////////////////////////////////////////////////////////////////




        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void food3halfch_CheckedChanged(object sender, EventArgs e)                              //
        {                                                                                                 //
            if (food3halfch.Checked == true)                      //Food3Halfcheckbox
            {
                food3halfq.Enabled = true;
            }                                                      //Food3Halfcheckbox
            else
            {
                food3halfq.Enabled = false;                         //Food3Halfcheckbox                   //
            }
        }///////////////////////////////////////////////////////////////////////////////////////////////////  




        //
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void food3fullch_CheckedChanged(object sender, EventArgs e)                               //
        {
            if (food3fullch.Checked == true)                     //FOOD 3 FULL CHECKBOX
            {
                food3fullq.Enabled = true;
            }                                                    //FOOD 3 FULL CHECKBOX
            else
            {
                food3fullq.Enabled = false;
                food3fullq.Text = string.Empty;                  //FOOD 3 FULL CHECKBOX
            }
        }                                                                                                 //
                                                                                                          ///////////////////////////////////////////////////////////////////////////////////////////////////








        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void food4halfch_CheckedChanged_1(object sender, EventArgs e)                             //
        {
            if (food4halfch.Checked == true)                      //Food4Halfcheckbox
            {
                food4halfq.Enabled = true;
            }                                                      //Food4Halfcheckbox
            else
            {
                food4halfq.Enabled = false;                         //Food4Halfcheckbox                   //
            }
        }///////////////////////////////////////////////////////////////////////////////////////////////////










        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void food4fullch_CheckedChanged(object sender, EventArgs e)                                //
        {
            if (food4fullch.Checked == true)                     //FOOD 4 FULL CHECKBOX
            {
                food4fullq.Enabled = true;
            }                                                    //FOOD 4 FULL CHECKBOX
            else
            {
                food4fullq.Enabled = false;
                food4fullq.Text = string.Empty;                  //FOOD 4 FULL CHECKBOX
            }                                                                                               //
        }////////////////////////////////////////////////////////////////////////////////////////////////////






        private void label2_Click(object sender, EventArgs e)
        {

        }



        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void zuush1_CheckedChanged(object sender, EventArgs e)                                   //
        {
            if (zuush1.Checked == true)                               //ZUUSH 1 CHECKBOX 
            {
                zuush1halfch.Enabled = true;
                zuush1halfq.Enabled = false;
                zuush1fullch.Enabled = true;


            }
            else
            {
                zuush1halfch.Enabled = false;
                zuush1halfq.Enabled = false;                      //ZUUSH 1 CHECKBOX
                zuush1fullch.Enabled = false;
                zuush1fullq.Enabled = false;

                zuush1halfch.Checked = false;
                zuush1halfq.Text = "";
                zuush1fullch.Checked = false;
                zuush1fullq.Text = "";                            //ZUUSH 1 CHECKBOX
                                                                  //
            }
        }///////////////////////////////////////////////////////////////////////////////////////////////









        ///////////////////////////////////////////////////////////////////////////////////////////////
        private void zuush1halfch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush1halfch.Checked == true)                      //ZUUSH 1 Half checkbox
            {
                zuush1halfq.Enabled = true;
            }                                                      //ZUUSH 1 Half checkbox
            else
            {
                zuush1halfq.Enabled = false;                         //ZUUSH 1 Half checkbox                   //
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////










        ///////////////////////////////////////////////////////////////////////////////////////////////
        private void zuush1fullch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush1fullch.Checked == true)                     //ZUUSH 1 FULL CHECKBOX
            {
                zuush1fullq.Enabled = true;
            }                                                    //ZUUSH 1 FULL CHECKBOX
            else
            {
                zuush1fullq.Enabled = false;
                zuush1fullq.Text = string.Empty;                  //ZUUSH 1 FULL CHECKBOX
            }
        }






        private void zuush2halfch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush2halfch.Checked == true)                      //ZUUSH 2 Half checkbox
            {
                zuush2halfq.Enabled = true;
            }                                                      //ZUUSH 2 Half checkbox
            else
            {
                zuush2halfq.Enabled = false;                         //ZUUSH 2 Half checkbox                   //
            }
        }





        private void zuush2fullch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush2fullch.Checked == true)                     //ZUUSH 2 FULL CHECKBOX
            {
                zuush2fullq.Enabled = true;
            }                                                    //ZUUSH 2 FULL CHECKBOX
            else
            {
                zuush2fullq.Enabled = false;
                zuush2fullq.Text = string.Empty;                  //ZUUSH 2 FULL CHECKBOX
            }
        }







        private void zuush3halfch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush3halfch.Checked == true)                      //ZUUSH 3 Half checkbox
            {
                zuush3halfq.Enabled = true;
            }                                                      //ZUUSH 3 Half checkbox
            else
            {
                zuush3halfq.Enabled = false;                         //ZUUSH 3 Half checkbox                   //
            }
        }

        private void zuush3fullch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush3fullch.Checked == true)                     //ZUUSH 3 FULL CHECKBOX
            {
                zuush3fullq.Enabled = true;
            }                                                    //ZUUSH 3 FULL CHECKBOX
            else
            {
                zuush3fullq.Enabled = false;
                zuush3fullq.Text = string.Empty;                  //ZUUSH 3 FULL CHECKBOX
            }
        }
    }
}
