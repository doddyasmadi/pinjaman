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
    public partial class t_posting {

        public t_posting()
        {
            OnCreated();
        }

        public virtual int t_posting_id
        {
            get;
            set;
        }

        public virtual string judul_posting
        {
            get;
            set;
        }

        public virtual string isi_posting
        {
            get;
            set;
        }

        public virtual System.DateTime tanggal_posting
        {
            get;
            set;
        }

        public virtual string status_posting
        {
            get;
            set;
        }

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
