using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Individual_Assignment
{
    public partial class OrderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if(!IsPostBack)
                for(int i = 1; i <= 10;i += 1)
                {
                    ddlperson.Items.Add(i.ToString());
                    ddldays.Items.Add(i.ToString());
                }
            
           
            
            lbdestination.Text = Session["destination"].ToString();
            if (lbdestination.Text == "Sultan Adbul Samad Building")
            {
                Imghotel.ImageUrl = "images/dorsethartamas.jpg";
                lblhotel.Text = "Dorsethartamas";
            }
            else if (lbdestination.Text == "Petaling Street Market")
            {
                Imghotel.ImageUrl = "images/ritz carlton.jpg";
                lblhotel.Text = "Ritz carlton";
            }
            else if (lbdestination.Text == "Central Market")
            {
                Imghotel.ImageUrl = "images/doubletree.jpg";
                lblhotel.Text = "Doubletree";
            }
            else if (lbdestination.Text =="Batu Caves")
            {
                Imghotel.ImageUrl = "images/hiltongarden.jpg";
                lblhotel.Text = "Hilton garden";
            }
        }
       
        
        protected void btnplaceorder_Click(object sender, EventArgs e)
        {
            

            double roomprice = 0;
            if (rdlroom.SelectedIndex == 0)
            {
                roomprice = 85.90;
            }
            else if (rdlroom.SelectedIndex == 1)
            {
                roomprice = 105.90;
            }
            else if (rdlroom.SelectedIndex == 2)
            {
                roomprice = 125.90;
            }
            int days = Convert.ToInt32(ddldays.SelectedValue);


            double totalprice = this.CalculateTotal(roomprice, days);
            string str = "";
            for (int i = 0; i < cbreq.Items.Count; i++)
            {
                //if (cbreq.Items[i].Selected == true)
                //{
                //    str += " =>" + cbreq.Items[i].ToString();
                //}
                if (cbreq.Items[i].Selected == true)
                {
                    str += "<li>"+cbreq.Items[i].ToString()+"</li>";
                }
            }
            if (Page.IsValid && tbname.Text != "" && tbemail.Text != "" && tbphone.Text != "" && cldindate.SelectedDate.Date!=DateTime.MinValue&& ddldays.SelectedValue != "" && ddlperson.SelectedValue != "" && rdlroom.SelectedValue != " ")
            {
                lblvalidmessage.Text = "Validation passed: You have inserted all required fields.";
                lblvalidmessage.ForeColor = System.Drawing.Color.Green;
                lblorder.Text = "The details of the order are listed as follows:<br/>" +
               "Selected destination: " + lbdestination.Text + "<br/>" +
               "Hotel: " + lblhotel.Text + "<br/>" +

               "Name: " + tbname.Text + "<br/>" +
               //"Gender: "+rdlgender.SelectedValue.ToString()+"<br/>"+
               "Email address: " + tbemail.Text + "<br/>" +
               "Phone number: " + tbphone.Text + "<br/>" +

               "Check in date: " + cldindate.SelectedDate.ToShortDateString() + "<br/>" +
               "Number of days: " + ddldays.SelectedValue.ToString() + "<br/>" +
               "Number of person: " + ddlperson.SelectedValue.ToString() + "<br/>" +

               "Room type: " + rdlroom.SelectedValue.ToString() + "<br/>" +
               "Room requirements: " + str + "<br/><hr/>" +
                "Total: RM" + totalprice.ToString("n");

            }
            else
            {
                lblvalidmessage.Text = "Some error detected, please enter all the required fields!";
                lblvalidmessage.ForeColor = System.Drawing.Color.Red;
            }
           

        }
        protected double CalculateTotal(double roomprice, int days)
        {
            double totalprice = roomprice * days;
            return totalprice;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            tbname.Text = "";
            //rdlgender.ClearSelection();
            tbemail.Text = "";
            tbphone.Text = "";
            cldindate.SelectedDates.Clear();
            ddldays.ClearSelection();
            ddlperson.ClearSelection();
            ddlperson.SelectedIndex = 0;
            rdlroom.ClearSelection();
            cbreq.ClearSelection();
            cbconfirmation.Checked = false;
            lblvalidmessage.Text = "";
            lblorder.Text = "";
        }
    }
}