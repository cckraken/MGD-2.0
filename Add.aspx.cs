using MGD_2._0.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static MGD_2._0.AppCode.clsMain;

namespace MGD_2._0
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            clsMain record = new clsMain();

            //get data from form
            record.CodeName = txtCodeName.Text;
            record.AbilityRank = txtAbilityRank.Text;
            record.Affiliation = txtAffiliation.Text;
            record.HairColour = txtHairColour.Text;
            record.Ethnicity = txtEthnicity.Text;
            record.AtMotherBase = ckdAtMotherBase.Text;
            record.DateJoined = lblCalendar.SelectedDate;

            //validate data
            Validator validator = new Validator();

            var results = validator.Validate(record);


        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}