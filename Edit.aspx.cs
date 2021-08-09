using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGD_2._0
{
    public partial class Edit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DAN-PC; Database=MGD; Trusted_Connection=True;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "sproc_getAll";

            connection.Open();
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();

            List<string> MemberList = new List<string>();
            

            while (reader.Read())
            {
                string CodeName = reader["CodeName"].ToString();
                string AbilityRank = reader["AbilityRank"].ToString();
                string Affiliation = reader["Affiliation"].ToString();
                string HairColour = reader["HairColour"].ToString();
                string Ethnicity = reader["Ethnicity"].ToString();
                string AtMotherBase = reader["AtMotherBase"].ToString();
                string DateJoined = reader["DateJoined"].ToString();
                var member = CodeName + AbilityRank + Affiliation + HairColour + Ethnicity + AtMotherBase + DateJoined;
                
                MemberList.Add(member);
            }

            
            ddlExisting.DataSource = MemberList;
            ddlExisting.DataBind();
           
            
            connection.Close();

        }

        public void DropDown_SelectedIndexChanged(Object sender, EventArgs e)
        {
            var selectedItem = ddlExisting.SelectedItem.ToString();
            //txtCodeName.Text = selectedItem.Substring(0, 3);
            //txtCodeName.Text = selectedItem.ElementAt(0).ToString();
            txtCodeName.Text = selectedItem;


        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}