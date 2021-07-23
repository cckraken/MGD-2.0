using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;

namespace MGD_2._0.AppCode
{
    public class clsShared
    {
        //create a connection to the database with class level scope
   
        //member var for current id
        clsMain thisID = new clsMain();

        //public ThisID property
        public clsMain ThisID
        {
            get
            {
                return thisID;
            }
            set
            {
                thisID = value;
            }
        }

  

        //add

        //edit

        //delete


    }


}