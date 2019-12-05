using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using User_Reg_BL_Library;
using RegistratioModelLibrary;
using System.Web.Http.Cors;


namespace RegistrationWEbApiProject.Controllers
{
    [EnableCors("http://localhost:4200", "*", "GET,POST,PUT")]
    public class RegisterController : ApiController

    {

        RegBL bl;

        public RegisterController()
        {
            bl = new RegBL();
        }
        // GET: api/Register

        List<RegisterModel> reg = new List<RegisterModel>();
            
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
            
        //}

        public IEnumerable<RegisterModel> Get()
        {
            reg = bl.GetAllUsers();
            return reg;

        }

        // GET: api/Register/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Register
        public void Post([FromBody]RegisterModel value)
        {
            //reg.Add(value);

            //reg = bl.GetAllUsers();
            //var user = (from u in reg
            //            select u).First();
            //if (user != null)

            //    bl.Insert_userBl(value.Firstname, value.Lastname, value.Dob.ToShortDateString(), value.Nationality, value.Phonenumber, value.Gender, value.Email, value.Password);

            //else


            //new RegisterModel();
           // try
            //{
                bl.Insert_userBl(value.Firstname, value.Lastname, value.Dob.ToShortDateString(), value.Nationality, value.Phonenumber, value.Gender, value.Email, value.Password);
           // }
            //catch(Exception e)

          //  {
             //  if(e.Message.Contains("PRIMARY KEY"))
                
                  // string msg= "exists";
                
           // }


        }

        // PUT: api/Register/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Register/5
        public void Delete(int id)
        {
        }
    }
}
