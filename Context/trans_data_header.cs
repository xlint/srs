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
    
    public partial class trans_data_header
    {
        public trans_data_header()
        {
            this.trans_data_line = new HashSet<trans_data_line>();
        }
    
        public string trans_id { get; set; }
        public Nullable<System.DateTime> date_trans { get; set; }
        public string partner_id { get; set; }
        public Nullable<bool> status { get; set; }
        public string ref_id { get; set; }
        public Nullable<bool> status_invoice { get; set; }
        public Nullable<bool> validasi { get; set; }
        public Nullable<bool> closed { get; set; }
        public Nullable<int> periode { get; set; }
        public int year_period { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string update_by { get; set; }
        public Nullable<System.DateTime> date_issued { get; set; }
        public string type_trans { get; set; }
    
        public virtual ICollection<trans_data_line> trans_data_line { get; set; }
        public virtual trans_data_type trans_data_type { get; set; }
    }
}
