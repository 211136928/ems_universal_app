using System;
using System.Collections.Generic;
using System.Text;

namespace ems_universal_app
{
    class Register
    {
        //declaring viriable
        public string ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string cellnum { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        
        //this method intitialize all viriable to empty
        public Register()
        {
            this.ID = string.Empty;
            this.name = string.Empty;
            this.surname = string.Empty;
            this.email = string.Empty;
            this.cellnum = string.Empty;
            this.password = string.Empty;
            this.gender = string.Empty;
          
        }

        public bool RegisterUser(string id, string nam, string sur,string eml,string cell, string psswrd)
        {
            bool blnRegister = false;
            ID = id;
            name = nam;
            surname = sur; email = eml;
            cellnum = cell; password = psswrd;
            age = Convert.ToInt32(2015 - Convert.ToInt32("19"+ ID.Substring(1,2)));
          int gNum = Convert.ToInt16(ID.Substring(7, 1)) ;
	            if (gNum >= 5 ) gender = "Female" ;
	            else gender = "Male" ;
            
            //string sql = "insert into user_registration values(ID,name,surname, cellnum,email,gender, username,password)";

            return blnRegister;
        }

  public bool updateDetails(string email, string cellnum, string address, string province)
        {
          //  string sqlUpdate = "update user_registration_tb set address = 'email', cell = 'cell', email = '$email' where vcode = 'code'";

            return true;
        }

    }
}
