﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ems_universal_app
{
    class validation
    {
        public int ID = 0000000000000;

  public validation()
        {
            ID = 000000000000;
        }

        public string IDValidation(string id)
    {
        string msg =  "";
       string  ID = id;
        
            //this try catch haddle error for entering a alphabetically value
                 try
                         {
                           Convert.ToInt64(ID);
                         }
                 catch(Exception )
                            {
                                msg = "your ID must be numeric values";
                              return msg;
                            }

          if (msg == "")
          {
              //check if the ID enter is a SA valid ID
              try
              {
                  Convert.ToInt64(ID);
              }
              catch (Exception)
              {
                  msg = "your ID is not a vaild SA ID";
                  return msg;
              }

          }


          return msg; 
        }

//this method will validate text field
  public string validateString(string text)
    {
            string Text = text;
            string msg = "";
           string numeric = "0123456789";

            if (Text == "")
            {
               msg = " text field is empty please provide "; 
            }
            else
                {
                for(int x = 0; x < Text.Length; x++)
                {
                    for(int y = 0; y < 9 ; y++)
                        {
                            if(Text[x] == numeric[y] )
                             {
                                    msg = "'txtname' can not contain numeric value";
                                    x = 100;
                                     break;
                             }

                           }

                }

             }

      return msg;
   }

//this method will validate cell number
 public string validateCellNum(string cellnum)
    {
            string cellNum = cellnum ;
            string msg = "";
           string alphabet = "abcdefghigklmnopqrstuvwxyz";

           if (cellNum == "")
            {
                msg = " text field is empty please provide ";
            }
           else if(cellnum.Length != 10)
           {
               msg = "cell number must be 10 digit long";

           }
            else
                {
               // this code is for checking if cell number dont contain alphabetic value
                    for (int x = 0; x < cellNum.Length; x++)
                        {
                    for (int y = 0; y < alphabet.Length; y++)
                        {
                            if (cellNum[x] == alphabet[y])
                             {
                                    msg = "'txtname' can not contain alphabetic value";
                                    x = 100;
                                     break;
                             }

                        }

                         }

             }

      return msg;
   }
        // this method will validate email
        public string validateEmail(string eml)
      {
          string msg = "";
          string Email = eml.Trim();
            int count = 0;
         string  validChars = "abcdefghijklmnopqrstuvwxyz0123456789.@_";

         for (int x = 0; x < Email.Length; x++)

             for (int y = 0; y < validChars.Length; y++ )
             {
                 if(Email[x] ==validChars[y])
                 {
                     count += 1;
                     break;
                 }

             }
            if(count != Email.Length)
            {
                msg = "please check your email is invalid";
            }
                 return msg;
      }
        // this method will validate password
        public string validatePassword(string pssword, string Vpassword) 
        {
            string msg = "";
            string password = pssword;
            string verifyPsswrd = Vpassword;
            if (password != verifyPsswrd)
            {
                msg = "please make sure that you enter the same password";
            }
            else
            {
                if(password.Length < 6)
                {
                    msg = "please make sure your password is more than 8 characters";

                }
            }

            return msg;
        }
    



    }
}
