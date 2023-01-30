using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransContactUs
    {
        public int TransContactUsId { get; set; }
       [DisplayName("ContactUs Title")]
        //[Required(ErrorMessage = "Insert Title")]

        public string TransContactUsTitle { get; set; }
        [DisplayName("ContactUs FirstName")]
        //[Required(ErrorMessage = "Insert FirstName")]
        public string TransContactUsFirstName { get; set; }
        [DisplayName("ContactUs LastName")]
        //[Required(ErrorMessage = "Insert LastName")]
        public string TransContactUsLastName { get; set; }
        [DisplayName("ContactUs StudentNumber")]
        //[Required(ErrorMessage = "Insert StudentNumber")]

        public string TransContactUsStudentNumber { get; set; }
        [DisplayName("ContactUs Discrption")]
        //[Required(ErrorMessage = "Insert Discrption")]
        public string TransContactUsDiscrption { get; set; }
        [DisplayName("ContactUs Date")]
        //[Required(ErrorMessage = "Insert Date")]
        public DateTime? TransContactUsDate { get; set; }
        [DisplayName("ContactUs UrlImage")]
        //[Required(ErrorMessage = "Insert Image")]
        public string TransContactUrlImage { get; set; }
        [DisplayName("ContactUs LinkUrl")]
        //[Required(ErrorMessage = "Insert LinkUrl")]
        public string TransContactLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
