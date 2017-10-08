using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class _default : System.Web.UI.Page 
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            //We want to initialize our calendars based
            //on the default conditions expressed in the video.
            //We want to do this on the page load event.
            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Today;
                Calendar2.SelectedDate = DateTime.Today.AddDays(14);
                Calendar3.SelectedDate = DateTime.Today.AddDays(21);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan Vacay;
            TimeSpan AssignLength;
            double SpyBudget;

            //First, check to make sure the dates are in the right order. If not,
            //Send them back to their initial conditions

            if (Calendar3.SelectedDate > Calendar2.SelectedDate && Calendar2.SelectedDate > Calendar1.SelectedDate)
            {
                //Safe to run our business rules

                Vacay = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
                if (Vacay.Days < 14)
                {
                    resetDates();
                    Label1.Text = "Error: Must allow at least two weeks between previous assignment and new assignment. Try again.";
                }
                else
                { //We are okay on vacation days. Let's check to make sure we have names and mission names.
                  //We could have tested for this first, but there's no rush.
                    if (TextBox1.Text.Length == 0 || TextBox2.Text.Length == 0)
                    {
                        Label1.Text = "Error: You must enter an agent name and assignment name.Try again.";
                        //No need to reset the dates because they might be okay. 
                    }
                    else
                    {  //We can compute the budget
                        AssignLength = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
                        SpyBudget = AssignLength.Days * 500.00;
                        if (AssignLength.Days > 21)
                        {
                            SpyBudget += 1000.00;
                        }
                        //Now build success string:
                        Label1.Text = "Assignment of " + TextBox1.Text + " to assignment " + TextBox2.Text + " is authorized.  " + String.Format("Budget total: {0:C}", SpyBudget);

                    }
                }
            }
            else
            {
                Label1.Text = "Error: You must keep the dates in order to request an assignment. Try again.";
                resetDates();
            }
  











        }

        private void resetDates()
        {   //this function just resets the calendars to their 
            //default settings. Note that this is different than
            //with the addition of lines that reset the 
            //calendars back to their defaults regardless
            //of selection.

            Calendar1.SelectedDate = DateTime.Today;
            Calendar2.SelectedDate = DateTime.Today.AddDays(14);
            Calendar3.SelectedDate = DateTime.Today.AddDays(21);
            Calendar1.VisibleDate = DateTime.Today;
            Calendar2.VisibleDate = DateTime.Today.AddDays(14);
            Calendar3.VisibleDate = DateTime.Today.AddDays(21);

            /*
            Calendar1.VisibleDate = Calendar1.SelectedDate;
            Calendar2.VisibleDate = Calendar2.SelectedDate;
            Calendar3.VisibleDate = Calendar3.SelectedDate;
            */
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}