﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 20-Oct-17 14:37:53
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
    public partial class m_feature_group {

        public m_feature_group()
        {
            this.m_feature = new List<m_feature>();
            OnCreated();
        }

        public virtual int m_feature_group_id
        {
            get;
            set;
        }

        public virtual string feature_group_name
        {
            get;
            set;
        }

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
