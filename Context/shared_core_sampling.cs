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
    
    public partial class shared_core_sampling
    {
        public int ID { get; set; }
        public System.DateTime TanggalProses { get; set; }
        public string PlatNo { get; set; }
        public string Driver { get; set; }
        public string NoTTA { get; set; }
        public Nullable<int> Line { get; set; }
        public Nullable<double> POL { get; set; }
        public Nullable<double> BRIX { get; set; }
        public string BARCODE { get; set; }
        public string Status { get; set; }
    }
}
