using FluentValidation;
using FluentValidation.Results;
using MGD_2._0.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static MGD_2._0.AppCode.clsMain;
using MessageBox = MGD_2._0.AppCode.MessageBox;

namespace MGD_2._0
{
    public partial class Add : System.Web.UI.Page
    {
        //initiate a binding list for the validation errors to be displayed in
        readonly BindingList<string> errors = new BindingList<string>();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            clsMain record = new clsMain();
            MessageBox alert = new MessageBox();

            //get data from text boxes
            record.CodeName = txtCodeName.Text;
            record.AbilityRank = txtAbilityRank.Text;
            record.Affiliation = txtAffiliation.Text;
            record.HairColour = txtHairColour.Text;
            record.Ethnicity = txtEthnicity.Text;
            record.AtMotherBase = ckdAtMotherBase.Checked;
            record.DateJoined = lblCalendar.SelectedDate;
            
            //validate data
            Validator validator = new Validator();
            

            var results = validator.Validate(record);
            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                    lstErrors.DataSource = errors;
                    lstErrors.DataBind();
                    alert.Show("Please fix the errors listed");
                    return;
                }
            }

            else
            {
                using (SqlConnection connection = new SqlConnection("Server=DAN-PC; Database=MGD; Trusted_Connection=True;"))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "sproc_Add";



                    command.Parameters.AddWithValue("@CodeName", record.CodeName);
                    command.Parameters.AddWithValue("@AbilityRank", record.AbilityRank);
                    command.Parameters.AddWithValue("@Affiliation", record.Affiliation);
                    command.Parameters.AddWithValue("@HairColour", record.HairColour);
                    command.Parameters.AddWithValue("@Ethnicity", record.Ethnicity);
                    command.Parameters.AddWithValue("@AtMotherBase", record.AtMotherBase);
                    command.Parameters.AddWithValue("@DateJoined", record.DateJoined);
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();

                    alert.Show("Operation succesfull");
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
}