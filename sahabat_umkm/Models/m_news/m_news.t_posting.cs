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
    public partial class t_posting {

        public t_posting()
        {
            OnCreated();
        }

        [DataMember(Order=1)]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int t_posting_id
        {
            get;
            set;
        }

        [DataMember(Order=2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string judul_posting
        {
            get;
            set;
        }

        [DataMember(Order=3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string isi_posting
        {
            get;
            set;
        }

        [DataMember(Order=4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual System.DateTime tanggal_posting
        {
            get;
            set;
        }

        [DataMember(Order=5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string status_posting
        {
            get;
            set;
        }

        [DataMember(Order=6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string thumbnail_posting
        {
            get;
            set;
        }

        [DataMember(Order=7)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int t_kategori_posting_id
        {
            get;
            set;
        }

        public virtual t_kategori_posting t_kategori_posting
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
