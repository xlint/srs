//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRS.DeskApp.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_master_form
    {
        public user_master_form()
        {
            this.user_master_menu = new HashSet<user_master_menu>();
        }
    
        public byte[] timestamp { get; set; }
        public int form_id { get; set; }
        public string form_name { get; set; }
        public string form_file_name { get; set; }
        public string setup_series_no { get; set; }
    
        public virtual ICollection<user_master_menu> user_master_menu { get; set; }
    }
}
