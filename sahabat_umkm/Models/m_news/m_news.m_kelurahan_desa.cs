﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 23-Oct-17 11:03:20
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

namespace m_news_context
{
    public partial class m_kelurahan_desa {

        public m_kelurahan_desa()
        {
            this.t_data_anggota_ktp_anggota = new List<t_data_anggota>();
            this.t_data_anggota_tt_anggota = new List<t_data_anggota>();
            this.t_data_usaha = new List<t_data_usaha>();
            OnCreated();
        }

        public virtual int m_kelurahan_desa_id
        {
            get;
            set;
        }

        public virtual string nama_kelurahan_desa
        {
            get;
            set;
        }

        public virtual string nama_kecamatan
        {
            get;
            set;
        }

        public virtual string nama_kabupaten_kota
        {
            get;
            set;
        }

        public virtual string jenis_kabupaten_kota
        {
            get;
            set;
        }

        public virtual string nama_propinsi
        {
            get;
            set;
        }

        public virtual string kode_pos
        {
            get;
            set;
        }

        public virtual IList<t_data_anggota> t_data_anggota_ktp_anggota
        {
            get;
            set;
        }

        public virtual IList<t_data_anggota> t_data_anggota_tt_anggota
        {
            get;
            set;
        }

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
