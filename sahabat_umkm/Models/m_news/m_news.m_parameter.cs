﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 20-Oct-17 13:52:13
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
    public partial class m_parameter {

        public m_parameter()
        {
            OnCreated();
        }

        public virtual int m_parameter_id
        {
            get;
            set;
        }

        public virtual string parameter_group
        {
            get;
            set;
        }

        public virtual string parameter_key
        {
            get;
            set;
        }

        public virtual string parameter_value
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
