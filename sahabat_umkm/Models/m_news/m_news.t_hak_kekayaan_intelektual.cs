﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 25-Oct-17 11:36:25
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace sahabat_umkm
{
    [DataContract(IsReference = true)]
    public partial class t_hak_kekayaan_intelektual {

        public t_hak_kekayaan_intelektual()
        {
            OnCreated();
        }

        [DataMember(Order=1)]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int t_hak_kekayaan_intelektual_id
        {
            get;
            set;
        }

        [DataMember(Order=2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string nama_hak_kekayaan_intelektual
        {
            get;
            set;
        }

        [DataMember(Order=3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string penjelasan_hak_kekayaan_intelektual
        {
            get;
            set;
        }

        [DataMember(Order=4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string definisi_hak_kekayaan_intelektual
        {
            get;
            set;
        }

        [DataMember(Order=5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string konsep_keuangan_usaha
        {
            get;
            set;
        }

        [DataMember(Order=6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string pernah_melakukan_kredit_pinjaman
        {
            get;
            set;
        }

        [DataMember(Order=7)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string pernah_mendapat_bantuan_pemerintah_swasta
        {
            get;
            set;
        }

        [DataMember(Order=8)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string penjelasan_tempat_usaha
        {
            get;
            set;
        }

        [DataMember(Order=9)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string kendala_saat_menjalankan_usaha
        {
            get;
            set;
        }

        [DataMember(Order=10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int t_data_usaha_id
        {
            get;
            set;
        }

        public virtual t_data_usaha t_data_usaha
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
