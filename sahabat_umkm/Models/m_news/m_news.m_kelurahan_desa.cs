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
    public partial class m_kelurahan_desa {

        public m_kelurahan_desa()
        {
            this.t_data_anggota_ktp_anggota = new List<t_data_anggota>();
            this.t_data_anggota_tt_anggota = new List<t_data_anggota>();
            this.t_data_usaha = new List<t_data_usaha>();
            OnCreated();
        }

        [DataMember(Order=1)]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int m_kelurahan_desa_id
        {
            get;
            set;
        }

        [DataMember(Order=2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string nama_kelurahan_desa
        {
            get;
            set;
        }

        [DataMember(Order=3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string nama_kecamatan
        {
            get;
            set;
        }

        [DataMember(Order=4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string nama_kabupaten_kota
        {
            get;
            set;
        }

        [DataMember(Order=5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string jenis_kabupaten_kota
        {
            get;
            set;
        }

        [DataMember(Order=6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string nama_propinsi
        {
            get;
            set;
        }

        [DataMember(Order=7)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string kode_pos
        {
            get;
            set;
        }

        [DataMember(Order=8, EmitDefaultValue=false)]
        public virtual IList<t_data_anggota> t_data_anggota_ktp_anggota
        {
            get;
            set;
        }

        [DataMember(Order=9, EmitDefaultValue=false)]
        public virtual IList<t_data_anggota> t_data_anggota_tt_anggota
        {
            get;
            set;
        }

        [DataMember(Order=10, EmitDefaultValue=false)]
        public virtual IList<t_data_usaha> t_data_usaha
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
