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
    public partial class m_feature_group {

        public m_feature_group()
        {
            this.m_feature = new List<m_feature>();
            OnCreated();
        }

        [DataMember(Order=1)]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int m_feature_group_id
        {
            get;
            set;
        }

        [DataMember(Order=2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string feature_group_name
        {
            get;
            set;
        }

        [DataMember(Order=3, EmitDefaultValue=false)]
        public virtual IList<m_feature> m_feature
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
