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
    public partial class m_user_group {

        public m_user_group()
        {
            this.m_user = new List<m_user>();
            this.feature_map = new List<feature_map>();
            OnCreated();
        }

        public virtual int m_user_group_id
        {
            get;
            set;
        }

        public virtual string user_group_name
        {
            get;
            set;
        }

        public virtual bool user_group_default
        {
            get;
            set;
        }

        public virtual IList<m_user> m_user
        {
            get;
            set;
        }

        public virtual IList<feature_map> feature_map
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}