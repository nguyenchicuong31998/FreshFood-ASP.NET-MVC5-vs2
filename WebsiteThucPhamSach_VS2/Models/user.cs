//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteThucPhamSach_VS2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int id { get; set; }
        public string display_name { get; set; }
        public Nullable<bool> gender { get; set; }
        public Nullable<System.DateTime> date_of_birth { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<bool> status { get; set; }
    }
}
