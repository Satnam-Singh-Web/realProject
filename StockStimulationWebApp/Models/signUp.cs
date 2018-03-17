

using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static StockStimulationWebApp.Models.encryptionclass;

namespace StockStimulationWebApp.Models
{
    public class signUp
    {
        encryptionclass encrVar=new encryptionclass();
      private readonly  string Encryption = "RYjGP=x,<nqsU_v5->8<]}jk\"<U^gP/P_/,K\"apMdu4Xe%a<3Y";
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(35, ErrorMessage = "Maximum length of first name is 35 "), MinLength(3, ErrorMessage = "Minimum length of first name is 3"), RegularExpression("^[0-9]*$", ErrorMessage = "Sorrry, name can't include numbers")]
       public string firstname { get; set; }

        [Required]
        [MaxLength(35, ErrorMessage = "Maximum length of last name is 35 ")]
        [MinLength(3, ErrorMessage = "Minimum length of last name is 3")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Sorrry, name can't include numbers")]
        public string lastname { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        [MinLength(14,ErrorMessage = "Correct the phone number")]
        [MaxLength(14,ErrorMessage ="Correct the phone number")]
        public string phoneno { get; set; }
        [Required]
        [MinLength(14, ErrorMessage = "Minimum length for email is 14")]
        [MaxLength(35, ErrorMessage = "Maximum length of email is 35 ")]
        [EmailAddress(ErrorMessage = "Please enter correct email address")]

        public string email { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9]+$",ErrorMessage = "No special characters allowed")]
        public string username { get; set; }
        [Required]

        [MinLength(8, ErrorMessage = "Minimum length for password is 8")]
        [MaxLength(14, ErrorMessage = "Maximum length of password is 14 ")]

        public string Password;
        //public string encryptionkey { get; set; }
       [Required]

        [MinLength(8, ErrorMessage = "Minimum length for encryption key is 8")]
        [MaxLength(14, ErrorMessage = "Maximum length of encryption key is 14 ")]
        public string Encryptionkey;
        public string encryptionkey
        {
            get { return Encryptionkey; }
            set { Encryptionkey = encrVar.Encrypt(value,Encryption); }
        }
        public string password
        {
            get { return Password; } 
            set { Password = encrVar.Encrypt(value, encryptionkey); }
        }

    }
}



