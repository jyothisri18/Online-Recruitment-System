//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineRecritmentSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employer
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Emailid { get; set; }
        public string MobileNo { get; set; }
        public string LocationOfTheOpenings { get; set; }
        public byte[] photo { get; set; }
        public string Designation { get; set; }
        public Nullable<int> CurrentOpenings { get; set; }
        public string Experience { get; set; }
        public string EmployerClients { get; set; }
        public string Skills { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
    }
}
