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
    public partial class m_pilihan_omzet {

        public m_pilihan_omzet()
        {
            this.t_data_usaha = new List<t_data_usaha>();
            OnCreated();
        }

        public virtual int m_pilihan_omzet_id
        {
            get;
            set;
        }

        public virtual string pilihan_omzet
        {
            get;
            set;
        }

        public virtual int urutan_pilihan_omzet
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
