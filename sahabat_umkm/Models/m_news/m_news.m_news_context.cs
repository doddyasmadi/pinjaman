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
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Reflection;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using m_news_context;

namespace sahabat_umkm
{

    public partial class m_news_context : DbContext
    {

        public m_news_context() :
            base()
        {
            OnCreated();
        }

        public m_news_context(DbContextOptions<m_news_context> options) :
            base(options)
        {
            OnCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            CustomizeConfiguration(ref optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        partial void CustomizeConfiguration(ref DbContextOptionsBuilder optionsBuilder);

        public virtual DbSet<m_user> m_users
        {
            get;
            set;
        }

        public virtual DbSet<m_user_group> m_user_groups
        {
            get;
            set;
        }

        public virtual DbSet<feature_map> feature_maps
        {
            get;
            set;
        }

        public virtual DbSet<m_feature> m_features
        {
            get;
            set;
        }

        public virtual DbSet<m_feature_group> m_feature_groups
        {
            get;
            set;
        }

        public virtual DbSet<m_parameter> m_parameters
        {
            get;
            set;
        }

        public virtual DbSet<m_kelurahan_desa> m_kelurahan_desas
        {
            get;
            set;
        }

        public virtual DbSet<m_agama> m_agamas
        {
            get;
            set;
        }

        public virtual DbSet<m_golongan_darah> m_golongan_darahs
        {
            get;
            set;
        }

        public virtual DbSet<m_jenjang_pendidikan> m_jenjang_pendidikans
        {
            get;
            set;
        }

        public virtual DbSet<m_jenis_bidang_usaha> m_jenis_bidang_usahas
        {
            get;
            set;
        }

        public virtual DbSet<m_pilihan_omzet> m_pilihan_omzets
        {
            get;
            set;
        }

        public virtual DbSet<t_data_anggota> t_data_anggotas
        {
            get;
            set;
        }

        public virtual DbSet<t_data_usaha> t_data_usahas
        {
            get;
            set;
        }

        public virtual DbSet<t_posting> t_postings
        {
            get;
            set;
        }

        public virtual DbSet<t_kategori_posting> t_kategori_posting
        {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.m_userMapping(modelBuilder);
            this.Customizem_userMapping(modelBuilder);

            this.m_user_groupMapping(modelBuilder);
            this.Customizem_user_groupMapping(modelBuilder);

            this.feature_mapMapping(modelBuilder);
            this.Customizefeature_mapMapping(modelBuilder);

            this.m_featureMapping(modelBuilder);
            this.Customizem_featureMapping(modelBuilder);

            this.m_feature_groupMapping(modelBuilder);
            this.Customizem_feature_groupMapping(modelBuilder);

            this.m_parameterMapping(modelBuilder);
            this.Customizem_parameterMapping(modelBuilder);

            this.m_kelurahan_desaMapping(modelBuilder);
            this.Customizem_kelurahan_desaMapping(modelBuilder);

            this.m_agamaMapping(modelBuilder);
            this.Customizem_agamaMapping(modelBuilder);

            this.m_golongan_darahMapping(modelBuilder);
            this.Customizem_golongan_darahMapping(modelBuilder);

            this.m_jenjang_pendidikanMapping(modelBuilder);
            this.Customizem_jenjang_pendidikanMapping(modelBuilder);

            this.m_jenis_bidang_usahaMapping(modelBuilder);
            this.Customizem_jenis_bidang_usahaMapping(modelBuilder);

            this.m_pilihan_omzetMapping(modelBuilder);
            this.Customizem_pilihan_omzetMapping(modelBuilder);

            this.t_data_anggotaMapping(modelBuilder);
            this.Customizet_data_anggotaMapping(modelBuilder);

            this.t_data_usahaMapping(modelBuilder);
            this.Customizet_data_usahaMapping(modelBuilder);

            this.t_postingMapping(modelBuilder);
            this.Customizet_postingMapping(modelBuilder);

            this.t_kategori_postingMapping(modelBuilder);
            this.Customizet_kategori_postingMapping(modelBuilder);

            RelationshipsMapping(modelBuilder);
            CustomizeMapping(ref modelBuilder);
        }
    
        #region m_user Mapping

        private void m_userMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_user>().ToTable(@"m_user");
            modelBuilder.Entity<m_user>().Property<int>(x => x.m_user_id).HasColumnName(@"m_user_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_user>().Property<string>(x => x.user_name).HasColumnName(@"user_name").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            modelBuilder.Entity<m_user>().Property<string>(x => x.user_password).HasColumnName(@"user_password").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_user>().Property<string>(x => x.user_email).HasColumnName(@"user_email").ValueGeneratedNever().HasMaxLength(50);
            modelBuilder.Entity<m_user>().Property<bool>(x => x.user_active).HasColumnName(@"user_active").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_user>().Property<int>(x => x.m_user_group_id).HasColumnName(@"m_user_group_id").ValueGeneratedNever();
            modelBuilder.Entity<m_user>().HasKey(@"m_user_id");
        }
	
        partial void Customizem_userMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_user_group Mapping

        private void m_user_groupMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_user_group>().ToTable(@"m_user_group");
            modelBuilder.Entity<m_user_group>().Property<int>(x => x.m_user_group_id).HasColumnName(@"m_user_group_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_user_group>().Property<string>(x => x.user_group_name).HasColumnName(@"user_group_name").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_user_group>().Property<bool>(x => x.user_group_default).HasColumnName(@"user_group_default").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_user_group>().HasKey(@"m_user_group_id");
        }
	
        partial void Customizem_user_groupMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region feature_map Mapping

        private void feature_mapMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<feature_map>().ToTable(@"feature_map");
            modelBuilder.Entity<feature_map>().Property<int>(x => x.feature_map_id).HasColumnName(@"feature_map_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<feature_map>().Property<int>(x => x.m_user_group_id).HasColumnName(@"m_user_group_id").ValueGeneratedNever();
            modelBuilder.Entity<feature_map>().Property<int>(x => x.m_feature_id).HasColumnName(@"m_feature_id").ValueGeneratedNever();
            modelBuilder.Entity<feature_map>().HasKey(@"feature_map_id");
        }
	
        partial void Customizefeature_mapMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_feature Mapping

        private void m_featureMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_feature>().ToTable(@"m_feature");
            modelBuilder.Entity<m_feature>().Property<int>(x => x.m_feature_id).HasColumnName(@"m_feature_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_feature>().Property<string>(x => x.feature_name).HasColumnName(@"feature_name").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_feature>().Property<int>(x => x.feature_sequence).HasColumnName(@"feature_sequence").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_feature>().Property<string>(x => x.feature_url).HasColumnName(@"feature_url").IsRequired().ValueGeneratedNever().HasMaxLength(255);
            modelBuilder.Entity<m_feature>().Property<string>(x => x.feature_icon).HasColumnName(@"feature_icon").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            modelBuilder.Entity<m_feature>().Property<bool>(x => x.feature_private).HasColumnName(@"feature_private").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_feature>().Property<int>(x => x.m_feature_group_id).HasColumnName(@"m_feature_group_id").ValueGeneratedNever();
            modelBuilder.Entity<m_feature>().HasKey(@"m_feature_id");
        }
	
        partial void Customizem_featureMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_feature_group Mapping

        private void m_feature_groupMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_feature_group>().ToTable(@"m_feature_group");
            modelBuilder.Entity<m_feature_group>().Property<int>(x => x.m_feature_group_id).HasColumnName(@"m_feature_group_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_feature_group>().Property<string>(x => x.feature_group_name).HasColumnName(@"feature_group_name").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_feature_group>().HasKey(@"m_feature_group_id");
        }
	
        partial void Customizem_feature_groupMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_parameter Mapping

        private void m_parameterMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_parameter>().ToTable(@"m_parameter");
            modelBuilder.Entity<m_parameter>().Property<int>(x => x.m_parameter_id).HasColumnName(@"m_parameter_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_parameter>().Property<string>(x => x.parameter_group).HasColumnName(@"parameter_group").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_parameter>().Property<string>(x => x.parameter_key).HasColumnName(@"parameter_key").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_parameter>().Property<string>(x => x.parameter_value).HasColumnName(@"parameter_value").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_parameter>().HasKey(@"m_parameter_id");
        }
	
        partial void Customizem_parameterMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_kelurahan_desa Mapping

        private void m_kelurahan_desaMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_kelurahan_desa>().ToTable(@"m_kelurahan_desa");
            modelBuilder.Entity<m_kelurahan_desa>().Property<int>(x => x.m_kelurahan_desa_id).HasColumnName(@"m_kelurahan_desa_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_kelurahan_desa>().Property<string>(x => x.nama_kelurahan_desa).HasColumnName(@"nama_kelurahan_desa").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_kelurahan_desa>().Property<string>(x => x.nama_kecamatan).HasColumnName(@"nama_kecamatan").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_kelurahan_desa>().Property<string>(x => x.nama_kabupaten_kota).HasColumnName(@"nama_kabupaten_kota").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_kelurahan_desa>().Property<string>(x => x.jenis_kabupaten_kota).HasColumnName(@"jenis_kabupaten_kota").IsRequired().ValueGeneratedNever().HasMaxLength(20);
            modelBuilder.Entity<m_kelurahan_desa>().Property<string>(x => x.nama_propinsi).HasColumnName(@"nama_propinsi").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_kelurahan_desa>().Property<string>(x => x.kode_pos).HasColumnName(@"kode_pos").IsRequired().ValueGeneratedNever().HasMaxLength(5);
            modelBuilder.Entity<m_kelurahan_desa>().HasKey(@"m_kelurahan_desa_id");
        }
	
        partial void Customizem_kelurahan_desaMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_agama Mapping

        private void m_agamaMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_agama>().ToTable(@"m_agama");
            modelBuilder.Entity<m_agama>().Property<int>(x => x.m_agama_id).HasColumnName(@"m_agama_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_agama>().Property<string>(x => x.nama_agama).HasColumnName(@"nama_agama").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            modelBuilder.Entity<m_agama>().Property<bool>(x => x.status_aktif).HasColumnName(@"status_aktif").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_agama>().Property<int>(x => x.sequence_agama).HasColumnName(@"sequence_agama").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_agama>().HasKey(@"m_agama_id");
        }
	
        partial void Customizem_agamaMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_golongan_darah Mapping

        private void m_golongan_darahMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_golongan_darah>().ToTable(@"m_golongan_darah");
            modelBuilder.Entity<m_golongan_darah>().Property<int>(x => x.m_golongan_darah_id).HasColumnName(@"m_golongan_darah_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_golongan_darah>().Property<string>(x => x.nama_golongan_darah).HasColumnName(@"nama_golongan_darah").IsRequired().ValueGeneratedNever().HasMaxLength(5);
            modelBuilder.Entity<m_golongan_darah>().HasKey(@"m_golongan_darah_id");
        }
	
        partial void Customizem_golongan_darahMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_jenjang_pendidikan Mapping

        private void m_jenjang_pendidikanMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_jenjang_pendidikan>().ToTable(@"m_jenjang_pendidikan");
            modelBuilder.Entity<m_jenjang_pendidikan>().Property<int>(x => x.m_jenjang_pendidikan_id).HasColumnName(@"m_jenjang_pendidikan_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_jenjang_pendidikan>().Property<string>(x => x.nama_jenjang_pendidikan).HasColumnName(@"nama_jenjang_pendidikan").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            modelBuilder.Entity<m_jenjang_pendidikan>().Property<bool>(x => x.status_aktif).HasColumnName(@"status_aktif").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_jenjang_pendidikan>().HasKey(@"m_jenjang_pendidikan_id");
        }
	
        partial void Customizem_jenjang_pendidikanMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_jenis_bidang_usaha Mapping

        private void m_jenis_bidang_usahaMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_jenis_bidang_usaha>().ToTable(@"m_jenis_bidang_usaha");
            modelBuilder.Entity<m_jenis_bidang_usaha>().Property<int>(x => x.m_jenis_bidang_usaha_id).HasColumnName(@"m_jenis_bidang_usaha_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_jenis_bidang_usaha>().Property<string>(x => x.nama_jenis_bidang_usaha).HasColumnName(@"nama_jenis_bidang_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_jenis_bidang_usaha>().HasKey(@"m_jenis_bidang_usaha_id");
        }
	
        partial void Customizem_jenis_bidang_usahaMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region m_pilihan_omzet Mapping

        private void m_pilihan_omzetMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_pilihan_omzet>().ToTable(@"m_pilihan_omzet");
            modelBuilder.Entity<m_pilihan_omzet>().Property<int>(x => x.m_pilihan_omzet_id).HasColumnName(@"m_pilihan_omzet_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<m_pilihan_omzet>().Property<string>(x => x.pilihan_omzet).HasColumnName(@"pilihan_omzet").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_pilihan_omzet>().Property<int>(x => x.urutan_pilihan_omzet).HasColumnName(@"urutan_pilihan_omzet").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<m_pilihan_omzet>().HasKey(@"m_pilihan_omzet_id");
        }
	
        partial void Customizem_pilihan_omzetMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region t_data_anggota Mapping

        private void t_data_anggotaMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_data_anggota>().ToTable(@"t_data_anggota");
            modelBuilder.Entity<t_data_anggota>().Property<int>(x => x.t_data_anggota_id).HasColumnName(@"t_data_anggota_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.nama_depan_anggota).HasColumnName(@"nama_depan_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.nama_belakang_anggota).HasColumnName(@"nama_belakang_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.email_anggota).HasColumnName(@"email_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.telepon_anggota).HasColumnName(@"telepon_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.nomor_ktp_anggota).HasColumnName(@"nomor_ktp_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.alamat_ktp_anggota).HasColumnName(@"alamat_ktp_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.rt_ktp_anggota).HasColumnName(@"rt_ktp_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.rw_ktp_anggota).HasColumnName(@"rw_ktp_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.alamat_tempat_tinggal_anggota).HasColumnName(@"alamat_tempat_tinggal_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.rt_tempat_tinggal_anggota).HasColumnName(@"rt_tempat_tinggal_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.rw_tempat_tinggal_anggota).HasColumnName(@"rw_tempat_tinggal_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<string>(x => x.asosiasi_komunitas_anggota).HasColumnName(@"asosiasi_komunitas_anggota").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<int>(x => x.m_kelurahan_desa_id_ktp_anggota).HasColumnName(@"m_kelurahan_desa_id_ktp_anggota").ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<int>(x => x.m_kelurahan_desa_id_tt_anggota).HasColumnName(@"m_kelurahan_desa_id_tt_anggota").ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().Property<int>(x => x.m_jenjang_pendidikan_id).HasColumnName(@"m_jenjang_pendidikan_id").ValueGeneratedNever();
            modelBuilder.Entity<t_data_anggota>().HasKey(@"t_data_anggota_id");
        }
	
        partial void Customizet_data_anggotaMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region t_data_usaha Mapping

        private void t_data_usahaMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_data_usaha>().ToTable(@"t_data_usaha");
            modelBuilder.Entity<t_data_usaha>().Property<int>(x => x.t_data_usaha_id).HasColumnName(@"t_data_usaha_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.nama_badan_usaha).HasColumnName(@"nama_badan_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.nama_bisnis).HasColumnName(@"nama_bisnis").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.jabatan_bisnis).HasColumnName(@"jabatan_bisnis").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.deskripsi_usaha).HasColumnName(@"deskripsi_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.tahun_pendirian_usaha).HasColumnName(@"tahun_pendirian_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.alamat_usaha).HasColumnName(@"alamat_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<int>(x => x.m_jenis_bidang_usaha_id).HasColumnName(@"m_jenis_bidang_usaha_id").ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<int>(x => x.m_pilihan_omzet_id).HasColumnName(@"m_pilihan_omzet_id").ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<int>(x => x.m_kelurahan_desa_id).HasColumnName(@"m_kelurahan_desa_id").ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.website_usaha).HasColumnName(@"website_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.sosmed_usaha_fb).HasColumnName(@"sosmed_usaha_fb").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.sosmed_usaha_ig).HasColumnName(@"sosmed_usaha_ig").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.sosmed_usaha_tw).HasColumnName(@"sosmed_usaha_tw").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.ktp_usaha).HasColumnName(@"ktp_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<string>(x => x.npwp_usaha).HasColumnName(@"npwp_usaha").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().Property<int>(x => x.t_data_anggota_id).HasColumnName(@"t_data_anggota_id").ValueGeneratedNever();
            modelBuilder.Entity<t_data_usaha>().HasKey(@"t_data_usaha_id");
        }
	
        partial void Customizet_data_usahaMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region t_posting Mapping

        private void t_postingMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_posting>().ToTable(@"t_posting");
            modelBuilder.Entity<t_posting>().Property<int>(x => x.t_posting_id).HasColumnName(@"t_posting_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<t_posting>().Property<string>(x => x.judul_posting).HasColumnName(@"judul_posting").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_posting>().Property<string>(x => x.isi_posting).HasColumnName(@"isi_posting").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_posting>().Property<System.DateTime>(x => x.tanggal_posting).HasColumnName(@"tanggal_posting").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_posting>().Property<string>(x => x.status_posting).HasColumnName(@"status_posting").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_posting>().Property<int>(x => x.t_kategori_posting_id).HasColumnName(@"t_kategori_posting_id").ValueGeneratedNever();
            modelBuilder.Entity<t_posting>().HasKey(@"t_posting_id");
        }
	
        partial void Customizet_postingMapping(ModelBuilder modelBuilder);

        #endregion
    
        #region t_kategori_posting Mapping

        private void t_kategori_postingMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_kategori_posting>().ToTable(@"t_kategori_posting");
            modelBuilder.Entity<t_kategori_posting>().Property<int>(x => x.t_kategori_posting_id).HasColumnName(@"t_kategori_posting_id").IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<t_kategori_posting>().Property<string>(x => x.nama_kategori_posting).HasColumnName(@"nama_kategori_posting").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<t_kategori_posting>().HasKey(@"t_kategori_posting_id");
        }
	
        partial void Customizet_kategori_postingMapping(ModelBuilder modelBuilder);

        #endregion

        private void RelationshipsMapping(ModelBuilder modelBuilder)
        {

        #region m_user Navigation properties

            modelBuilder.Entity<m_user>().HasOne(x => x.m_user_group).WithMany(op => op.m_user).OnDelete(DeleteBehavior.Restrict).IsRequired(true).HasForeignKey(@"m_user_group_id");

        #endregion

        #region m_user_group Navigation properties

            modelBuilder.Entity<m_user_group>().HasMany(x => x.m_user).WithOne(op => op.m_user_group).OnDelete(DeleteBehavior.Restrict).IsRequired(true).HasForeignKey(@"m_user_group_id");
            modelBuilder.Entity<m_user_group>().HasMany(x => x.feature_map).WithOne(op => op.m_user_group).OnDelete(DeleteBehavior.Restrict).IsRequired(true).HasForeignKey(@"m_user_group_id");

        #endregion

        #region feature_map Navigation properties

            modelBuilder.Entity<feature_map>().HasOne(x => x.m_user_group).WithMany(op => op.feature_map).OnDelete(DeleteBehavior.Restrict).IsRequired(true).HasForeignKey(@"m_user_group_id");
            modelBuilder.Entity<feature_map>().HasOne(x => x.m_feature).WithMany(op => op.feature_map).OnDelete(DeleteBehavior.Restrict).IsRequired(true).HasForeignKey(@"m_feature_id");

        #endregion

        #region m_feature Navigation properties

            modelBuilder.Entity<m_feature>().HasMany(x => x.feature_map).WithOne(op => op.m_feature).OnDelete(DeleteBehavior.Restrict).IsRequired(true).HasForeignKey(@"m_feature_id");
            modelBuilder.Entity<m_feature>().HasOne(x => x.m_feature_group).WithMany(op => op.m_feature).IsRequired(true).HasForeignKey(@"m_feature_group_id");

        #endregion

        #region m_feature_group Navigation properties

            modelBuilder.Entity<m_feature_group>().HasMany(x => x.m_feature).WithOne(op => op.m_feature_group).IsRequired(true).HasForeignKey(@"m_feature_group_id");

        #endregion

        #region m_kelurahan_desa Navigation properties

            modelBuilder.Entity<m_kelurahan_desa>().HasMany(x => x.t_data_anggota_ktp_anggota).WithOne(op => op.m_kelurahan_desa_ktp_anggota).IsRequired(true).HasForeignKey(@"m_kelurahan_desa_id_ktp_anggota");
            modelBuilder.Entity<m_kelurahan_desa>().HasMany(x => x.t_data_anggota_tt_anggota).WithOne(op => op.m_kelurahan_desa_tt_anggota).IsRequired(true).HasForeignKey(@"m_kelurahan_desa_id_tt_anggota");
            modelBuilder.Entity<m_kelurahan_desa>().HasMany(x => x.t_data_usaha).WithOne(op => op.m_kelurahan_desa).IsRequired(true).HasForeignKey(@"m_kelurahan_desa_id");

        #endregion

        #region m_jenjang_pendidikan Navigation properties

            modelBuilder.Entity<m_jenjang_pendidikan>().HasMany(x => x.t_data_anggota).WithOne(op => op.m_jenjang_pendidikan).IsRequired(true).HasForeignKey(@"m_jenjang_pendidikan_id");

        #endregion

        #region m_jenis_bidang_usaha Navigation properties

            modelBuilder.Entity<m_jenis_bidang_usaha>().HasMany(x => x.t_data_usaha).WithOne(op => op.m_jenis_bidang_usaha).IsRequired(true).HasForeignKey(@"m_jenis_bidang_usaha_id");

        #endregion

        #region m_pilihan_omzet Navigation properties

            modelBuilder.Entity<m_pilihan_omzet>().HasMany(x => x.t_data_usaha).WithOne(op => op.m_pilihan_omzet).IsRequired(true).HasForeignKey(@"m_pilihan_omzet_id");

        #endregion

        #region t_data_anggota Navigation properties

            modelBuilder.Entity<t_data_anggota>().HasOne(x => x.m_kelurahan_desa_ktp_anggota).WithMany(op => op.t_data_anggota_ktp_anggota).IsRequired(true).HasForeignKey(@"m_kelurahan_desa_id_ktp_anggota");
            modelBuilder.Entity<t_data_anggota>().HasOne(x => x.m_kelurahan_desa_tt_anggota).WithMany(op => op.t_data_anggota_tt_anggota).IsRequired(true).HasForeignKey(@"m_kelurahan_desa_id_tt_anggota");
            modelBuilder.Entity<t_data_anggota>().HasOne(x => x.m_jenjang_pendidikan).WithMany(op => op.t_data_anggota).IsRequired(true).HasForeignKey(@"m_jenjang_pendidikan_id");
            modelBuilder.Entity<t_data_anggota>().HasMany(x => x.t_data_usaha).WithOne(op => op.t_data_anggota).IsRequired(true).HasForeignKey(@"t_data_anggota_id");

        #endregion

        #region t_data_usaha Navigation properties

            modelBuilder.Entity<t_data_usaha>().HasOne(x => x.m_jenis_bidang_usaha).WithMany(op => op.t_data_usaha).IsRequired(true).HasForeignKey(@"m_jenis_bidang_usaha_id");
            modelBuilder.Entity<t_data_usaha>().HasOne(x => x.m_pilihan_omzet).WithMany(op => op.t_data_usaha).IsRequired(true).HasForeignKey(@"m_pilihan_omzet_id");
            modelBuilder.Entity<t_data_usaha>().HasOne(x => x.m_kelurahan_desa).WithMany(op => op.t_data_usaha).IsRequired(true).HasForeignKey(@"m_kelurahan_desa_id");
            modelBuilder.Entity<t_data_usaha>().HasOne(x => x.t_data_anggota).WithMany(op => op.t_data_usaha).IsRequired(true).HasForeignKey(@"t_data_anggota_id");

        #endregion

        #region t_posting Navigation properties

            modelBuilder.Entity<t_posting>().HasOne(x => x.t_kategori_posting).WithMany(op => op.t_posting).IsRequired(true).HasForeignKey(@"t_kategori_posting_id");

        #endregion

        #region t_kategori_posting Navigation properties

            modelBuilder.Entity<t_kategori_posting>().HasMany(x => x.t_posting).WithOne(op => op.t_kategori_posting).IsRequired(true).HasForeignKey(@"t_kategori_posting_id");

        #endregion
        }

        partial void CustomizeMapping(ref ModelBuilder modelBuilder);

        public bool HasChanges()
        {
            return ChangeTracker.Entries().Any(e => e.State == Microsoft.EntityFrameworkCore.EntityState.Added || e.State == Microsoft.EntityFrameworkCore.EntityState.Modified || e.State == Microsoft.EntityFrameworkCore.EntityState.Deleted);
        }

        partial void OnCreated();
    }
}
