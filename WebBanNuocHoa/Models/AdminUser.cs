//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanNuocHoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class AdminUser
    {

        //[Required(Errormessage = "ID not empty ...")]
        [Display(Name = "Mä User")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name not empty...")]
        //[StringLength (50,MinimumLength =5)]
        [Display(Name = "Tên User")]
        public string NameUser { get; set; }
        [Display(Name = "Vị trí")]
        public string RoleUser { get; set; }
        [Display(Name = "Nhập Mât khẩu")]
        [Required(ErrorMessage = "Pass not empty ...")]
        [DataType(DataType.Password)]
        public string PasswordUser { get; set; }
        [NotMapped]
        [Compare("PasswordUser")]
        [Display(Name = "Nhập lại mật khẩu")]
        public string ConfirmPass { get; set; }
        [NotMapped]
        public string ErrorLogin { get; set; }
    }
}

