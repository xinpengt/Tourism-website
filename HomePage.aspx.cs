using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Individual_Assignment
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            table2.Visible = false;




        }

        protected void ddlDestination_SelectedIndexChanged1(object sender, EventArgs e)
        {
            table2.Visible = true;
            if (ddlDestination.SelectedIndex == 0)
            {
                imgDestination1.ImageUrl = "images/sultan1.jpeg";
                imgDestination2.ImageUrl = "images/sultan2.jpg";
                imgDestination3.ImageUrl = "Images/sultan3.jpg";
                imgDestination4.ImageUrl = "Images/sultan4.jpg";

            }
            else if (ddlDestination.SelectedIndex == 1)
            {
                imgDestination1.ImageUrl = "images/petaling1.jpg";
                imgDestination2.ImageUrl = "images/petaling2.jpg";
                imgDestination3.ImageUrl = "Images/petaling3.jpg";
                imgDestination4.ImageUrl = "Images/petaling4.jpg";
            }
            else if (ddlDestination.SelectedIndex == 2)
            {
                imgDestination1.ImageUrl = "images/central1.jpg";
                imgDestination2.ImageUrl = "images/central2.jpg";
                imgDestination3.ImageUrl = "Images/central3.jpg";
                imgDestination4.ImageUrl = "Images/central4.jpg";
            }
            else if (ddlDestination.SelectedIndex == 3)
            {
                imgDestination1.ImageUrl = "images/batu1.jpg";
                imgDestination2.ImageUrl = "images/batu2.jpg";
                imgDestination3.ImageUrl = "Images/batu3.jpg";
                imgDestination4.ImageUrl = "Images/batu4.jpg";
            }
            string[] foodarray1 = new string[] { "Fried noodles", "Nasi lemak", "Kari laksa","Nasi kandar","Kuih","Popia"};
            string[] foodarray2 = new string[] { "Kaya toast", "Rendang", "Murtabak","Roti canai","Sambal udang","Rempeyek" };
            string[] foodarray3 = new string[] { "Lemang", "Otak-otak", "Satay","Mee rebus","Lor bak","Ikan bakar" };
            string[] foodarray4 = new string[] { "Rojak", "Satar", "Wantan mee","Char kuey teow","Goreng pisang","Ketupat" };

            if (ddlDestination.SelectedIndex == 0)
            {
                blFood.DataSource = foodarray1;
                blFood.DataBind();
            }
            else if (ddlDestination.SelectedIndex == 1)
            {
                blFood.DataSource = foodarray2;
                blFood.DataBind();
            }
            else if (ddlDestination.SelectedIndex == 2)
            {
                blFood.DataSource = foodarray3;
                blFood.DataBind();
            }
            else if (ddlDestination.SelectedIndex == 3)
            {
                blFood.DataSource = foodarray4;
                blFood.DataBind();
            }
            string[] resarray1 = new string[] {"Spring","Fuego","Marble","Thirty8","Opium","Halab" };
            string[] resarray2 = new string[] {"Beta","Bobo","PRIME","Cielo","Skillet","YEN"};
            string[] resarray3 = new string[] {"Cantaloupe","NADODI","Bijian","Havana","Dewakan","Mosaic"};
            string[] resarray4 = new string[] {"TAKA","Favola","Flock","Atmosphere","AQUA","Balqis" };
           
            
            if (ddlDestination.SelectedIndex == 0)
            {
                blRes.DataSource = resarray1;
                blRes.DataBind();
            }
            else if (ddlDestination.SelectedIndex == 1)
            {
                blRes.DataSource = resarray2;
                blRes.DataBind();
            }
            else if (ddlDestination.SelectedIndex == 2)
            {
                blRes.DataSource = resarray3;
                blRes.DataBind();
            }
            else if (ddlDestination.SelectedIndex == 3)
            {
                blRes.DataSource = resarray4;
                blRes.DataBind();
            }
            if(ddlDestination.SelectedIndex==0)
            {
                lbldescription.Text = "The Sultan Abdul Samad Building is among Kuala Lumpur’s earliest Moorish-style buildings. It is set to the east of Merdeka Square (Dataran Merdeka) and the Royal Selangor Club, across from Jalan Sultan Hishamuddin. It was built in 1897 and was named after the reigning sultan of Selangor at the time.";            
            }
            else if (ddlDestination.SelectedIndex == 1)
            {
                lbldescription.Text = "Petaling Street Market is well known for both its “imitation” goods and its culturally diverse culinary options. With hundreds of vendors selling everything from designer bags to traditional fried rice noodles, Petaling Street is a destination for tourists and locals looking for a bargain. Chaotic but charming, Petaling Street Market is accessible by numerous buses, trains, taxis, and rickshaws, and the site is easily recognizable--it has multiple, well marked entrances, the primary entrance marked by a giant red arch marked “Jalan Petaling” in striking gold script.";
            }
            else if (ddlDestination.SelectedIndex == 2)
            {
                lbldescription.Text = "Central Market Kuala Lumpur is a centre for Malaysian culture, art and craft located in the heart of the city. As a building with significant historical value Central Market Kuala Lumpur has come a long way from its early beginning as a wet market built in 1888 to a delightful destination for tourists, shoppers and art lovers.";
 
            }
            else if (ddlDestination.SelectedIndex == 3)
            {
                lbldescription.Text = "Batu Caves is one of the most popular Hindu shrines outside India, dedicated to Lord Murugan. It is the focal point of Hindu festival of Thaipusam in Malaysia. It is also known as the 10th Caves or Hill for Lord Muruga as it is one of the ten most important shrines in India and Malaysia.";
            }
            
        }

        protected void lbtnno_Click(object sender, EventArgs e)
        {
            ddlDestination.ClearSelection();
            //blFood.ClearSelection();
            //blRes.ClearSelection();
        }

        protected void lbtnyes_Click(object sender, EventArgs e)
        {
            Session["destination"] = ddlDestination.SelectedValue;
            Response.Redirect("OrderPage.aspx");
        }
    }
}