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
    
    public partial class tbl_transit_core_sampling
    {
        public int doc_entry { get; set; }
        public int base_entry { get; set; }
        public string num_at_card { get; set; }
        public string car_id { get; set; }
        public string driver { get; set; }
        public string device_ip_address { get; set; }
        public Nullable<decimal> pol_manual { get; set; }
        public Nullable<decimal> brix_manual { get; set; }
        public Nullable<decimal> rendemen_manual { get; set; }
        public Nullable<decimal> pol_nir { get; set; }
        public Nullable<decimal> brix_nir { get; set; }
        public Nullable<decimal> rendemen_nir { get; set; }
        public Nullable<decimal> harga { get; set; }
        public Nullable<decimal> potongan { get; set; }
        public Nullable<int> status { get; set; }
        public string id_basket { get; set; }
        public Nullable<System.DateTime> potongan_date { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string time { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string update_by { get; set; }
        public string create_by { get; set; }
        public string house_id { get; set; }
        public Nullable<decimal> insentif { get; set; }
        public Nullable<decimal> pembayaran { get; set; }
        public string grkey { get; set; }
        public string invoicekey { get; set; }
        public Nullable<decimal> potongan_unreg_petani { get; set; }
        public string opaykey { get; set; }
    
        public virtual tbl_pendaftaran_mobil tbl_pendaftaran_mobil { get; set; }
    }
}
