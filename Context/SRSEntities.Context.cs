﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SRSEntities : DbContext
    {
        public SRSEntities()
            : base("name=SRSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<lookup_header> lookup_header { get; set; }
        public virtual DbSet<lookup_line> lookup_line { get; set; }
        public virtual DbSet<master_list> master_list { get; set; }
        public virtual DbSet<Masterlist2> Masterlist2 { get; set; }
        public virtual DbSet<rendeman> rendemen { get; set; }
        public virtual DbSet<shared_core_sampling> shared_core_sampling { get; set; }
        public virtual DbSet<shared_timbangan_in> shared_timbangan_in { get; set; }
        public virtual DbSet<tbl_error> tbl_error { get; set; }
        public virtual DbSet<tbl_kabupaten> tbl_kabupaten { get; set; }
        public virtual DbSet<tbl_kecamatan> tbl_kecamatan { get; set; }
        public virtual DbSet<tbl_kelurahan> tbl_kelurahan { get; set; }
        public virtual DbSet<tbl_pendaftaran_mobil> tbl_pendaftaran_mobil { get; set; }
        public virtual DbSet<tbl_periode_giling> tbl_periode_giling { get; set; }
        public virtual DbSet<tbl_periode_trx> tbl_periode_trx { get; set; }
        public virtual DbSet<tbl_transit_core_sampling> tbl_transit_core_sampling { get; set; }
        public virtual DbSet<tbl_transit_scan_id_device> tbl_transit_scan_id_device { get; set; }
        public virtual DbSet<tbl_transit_scan_id_timbangan> tbl_transit_scan_id_timbangan { get; set; }
        public virtual DbSet<tbl_transit_timbangan> tbl_transit_timbangan { get; set; }
        public virtual DbSet<tblTicketNo> tblTicketNoes { get; set; }
        public virtual DbSet<tblTransaction> tblTransactions { get; set; }
        public virtual DbSet<Tiket> Tikets { get; set; }
        public virtual DbSet<tiket_backup> tiket_backup { get; set; }
        public virtual DbSet<tiket_header> tiket_header { get; set; }
        public virtual DbSet<tiket_history> tiket_history { get; set; }
        public virtual DbSet<tiket_template> tiket_template { get; set; }
        public virtual DbSet<trans_data_header> trans_data_header { get; set; }
        public virtual DbSet<trans_data_header2> trans_data_header2 { get; set; }
        public virtual DbSet<trans_data_line> trans_data_line { get; set; }
        public virtual DbSet<trans_data_saldo> trans_data_saldo { get; set; }
        public virtual DbSet<trans_data_type> trans_data_type { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<user_access_list> user_access_list { get; set; }
        public virtual DbSet<user_master_form> user_master_form { get; set; }
        public virtual DbSet<user_master_menu> user_master_menu { get; set; }
        public virtual DbSet<user_master_modules> user_master_modules { get; set; }
        public virtual DbSet<user_menu> user_menu { get; set; }
        public virtual DbSet<user_table> user_table { get; set; }
        public virtual DbSet<user_table_group> user_table_group { get; set; }
        public virtual DbSet<device_config> device_config { get; set; }
        public virtual DbSet<field_object> field_object { get; set; }
    
        public virtual int AngsuranTampil(string trans_id, string partner_id)
        {
            var trans_idParameter = trans_id != null ?
                new ObjectParameter("trans_id", trans_id) :
                new ObjectParameter("trans_id", typeof(string));
    
            var partner_idParameter = partner_id != null ?
                new ObjectParameter("partner_id", partner_id) :
                new ObjectParameter("partner_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AngsuranTampil", trans_idParameter, partner_idParameter);
        }
    
        public virtual int CariNamaPetani(string petani)
        {
            var petaniParameter = petani != null ?
                new ObjectParameter("petani", petani) :
                new ObjectParameter("petani", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CariNamaPetani", petaniParameter);
        }
    
        public virtual int spInsertTrans(string jenis_transaksi, string partner_id, Nullable<System.DateTime> date_issued, string ref_notes, Nullable<int> year_period, string create_by, Nullable<decimal> jmlbayar, string base_entry)
        {
            var jenis_transaksiParameter = jenis_transaksi != null ?
                new ObjectParameter("jenis_transaksi", jenis_transaksi) :
                new ObjectParameter("jenis_transaksi", typeof(string));
    
            var partner_idParameter = partner_id != null ?
                new ObjectParameter("partner_id", partner_id) :
                new ObjectParameter("partner_id", typeof(string));
    
            var date_issuedParameter = date_issued.HasValue ?
                new ObjectParameter("date_issued", date_issued) :
                new ObjectParameter("date_issued", typeof(System.DateTime));
    
            var ref_notesParameter = ref_notes != null ?
                new ObjectParameter("ref_notes", ref_notes) :
                new ObjectParameter("ref_notes", typeof(string));
    
            var year_periodParameter = year_period.HasValue ?
                new ObjectParameter("year_period", year_period) :
                new ObjectParameter("year_period", typeof(int));
    
            var create_byParameter = create_by != null ?
                new ObjectParameter("create_by", create_by) :
                new ObjectParameter("create_by", typeof(string));
    
            var jmlbayarParameter = jmlbayar.HasValue ?
                new ObjectParameter("jmlbayar", jmlbayar) :
                new ObjectParameter("jmlbayar", typeof(decimal));
    
            var base_entryParameter = base_entry != null ?
                new ObjectParameter("base_entry", base_entry) :
                new ObjectParameter("base_entry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertTrans", jenis_transaksiParameter, partner_idParameter, date_issuedParameter, ref_notesParameter, year_periodParameter, create_byParameter, jmlbayarParameter, base_entryParameter);
        }
    
        public virtual ObjectResult<spLoadCicilan_Result> spLoadCicilan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spLoadCicilan_Result>("spLoadCicilan");
        }
    }
}
