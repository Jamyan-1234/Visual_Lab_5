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
            food1halfch.Enabled = false;
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
            food4fullq.Enabled = false;














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







        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

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



        private void food4fullch_CheckedChanged(object sender, EventArgs e)
        {
            if (food4fullch.Checked == true)                     //FOOD 4 FULL CHECKBOX
            {
                food4fullq.Enabled = true;
            }                                                    //FOOD 4 FULL CHECKBOX
            else
            {
                food4fullq.Enabled = false;
                food4fullq.Text = string.Empty;                  //FOOD 4 FULL CHECKBOX
            }
        }
    }
}
