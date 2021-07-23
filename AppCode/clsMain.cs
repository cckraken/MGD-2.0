using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;

namespace MGD_2._0.AppCode
{
    public class clsMain
    {
        //create a connection to the database


        //Declare private record properties
        private string codeName;
        private string abilityRank;
        private string assignedTo;
        private string affiliation;
        private string hairColour;
        private string ethnicity;
        private DateTime dateJoined;
        private String atMotherBase;
        private Int32 motherBaseID;

        //Declare public record properties + get/setters
        public Int32 MotherBaseID
        {
            get
            {
                return motherBaseID;
            }
            set
            {
                motherBaseID = value;
            }
        }

        public string CodeName
        {
            get
            {
                return codeName;
            }
            set
            {
                codeName = value;
            }
        }

        public string AbilityRank
        {
            get
            {
                return abilityRank;
            }
            set
            {
                abilityRank = value;
            }
        }

        public string AssignedTo
        {
            get
            {
                return assignedTo;
            }
            set
            {
                assignedTo = value;
            }
        }

        public string Affiliation
        {
            get
            {
                return affiliation;
            }
            set
            {
                affiliation = value;
            }
        }

        public string HairColour
        {
            get
            {
                return hairColour;
            }
            set
            {
                hairColour = value;
            }
        }

        public string Ethnicity
        {
            get
            {
                return ethnicity;
            }
            set
            {
                ethnicity = value;
            }
        }

        public DateTime DateJoined
        {
            get
            {
                return dateJoined;
            }
            set
            {
                dateJoined = value;
            }
        }

        public string AtMotherBase
        {
            get
            {
                return atMotherBase;
            }
            set
            {
                atMotherBase = value;
            }
        }

        public class Validator : AbstractValidator<clsMain>
        {
            public Validator()
            {
                RuleFor(r => r.CodeName)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Codename is empty")
                    .Length(3, 15).WithMessage("Length of Codename is invalid")
                    .NotEqual("0 - 9");

                RuleFor(r => r.AbilityRank)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Ability rank is empty")
                    .Length(2, 3).WithMessage("Ability rank must be between 2 and 3 characters")
                    .NotEqual("0 - 9");

            }
        }

    }
}