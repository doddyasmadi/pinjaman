﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 23-Oct-17 11:52:52
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
    public partial class m_jenjang_pendidikan {

        public m_jenjang_pendidikan()
        {
            this.t_data_anggota = new List<t_data_anggota>();
            OnCreated();
        }

        [DataMember(Order=1)]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int m_jenjang_pendidikan_id
        {
            get;
            set;
        }

        [DataMember(Order=2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string nama_jenjang_pendidikan
        {
            get;
            set;
        }

        [DataMember(Order=3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual bool status_aktif
        {
            get;
            set;
        }

        [DataMember(Order=4, EmitDefaultValue=false)]
        public virtual IList<t_data_anggota> t_data_anggota
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
