﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 23-Oct-17 11:14:38
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

namespace sahabat_umkm
{
    public partial class m_jenis_bidang_usaha {

        public m_jenis_bidang_usaha()
        {
            this.t_data_usaha = new List<t_data_usaha>();
            OnCreated();
        }

        public virtual int m_jenis_bidang_usaha_id
        {
            get;
            set;
        }

        public virtual string nama_jenis_bidang_usaha
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
