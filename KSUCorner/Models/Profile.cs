//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KSUCorner.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool EmailIsPublic { get; set; }
        public string Gender { get; set; }
        public bool GenderIsPublic { get; set; }
        public System.DateTime BirthDate { get; set; }
        public bool BirthDateIsPublic { get; set; }
        public string AvatarPath { get; set; }
        public int AvatarWidth { get; set; }
        public int AvatarHeight { get; set; }
        public bool AvatarIsPublic { get; set; }
        public string Interests { get; set; }
        public bool InterestsIsPublic { get; set; }
        public string AboutMe { get; set; }
        public bool AboutMeIsPublic { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
    }
}
