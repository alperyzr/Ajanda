//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KurumsalAjanda.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteriler
    {
        public int Musteri_ID { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bas_Harfler { get; set; }
        public string Departman_Adi { get; set; }
        public Nullable<System.DateTime> Dogum_Tarihi { get; set; }
        public string E_Mail { get; set; }
        public string Telefon_No { get; set; }
        public string Vasfi { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public byte[] Image { get; set; }
    }
}
