using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sahabat_umkm.Migrations
{
    public partial class m_news_1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_agama",
                columns: table => new
                {
                    m_agama_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nama_agama = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sequence_agama = table.Column<int>(type: "int", nullable: false),
                    status_aktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_agama", x => x.m_agama_id);
                });

            migrationBuilder.CreateTable(
                name: "m_feature_group",
                columns: table => new
                {
                    m_feature_group_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    feature_group_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_feature_group", x => x.m_feature_group_id);
                });

            migrationBuilder.CreateTable(
                name: "m_golongan_darah",
                columns: table => new
                {
                    m_golongan_darah_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nama_golongan_darah = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_golongan_darah", x => x.m_golongan_darah_id);
                });

            migrationBuilder.CreateTable(
                name: "m_jenis_bidang_usaha",
                columns: table => new
                {
                    m_jenis_bidang_usaha_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nama_jenis_bidang_usaha = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_jenis_bidang_usaha", x => x.m_jenis_bidang_usaha_id);
                });

            migrationBuilder.CreateTable(
                name: "m_jenjang_pendidikan",
                columns: table => new
                {
                    m_jenjang_pendidikan_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nama_jenjang_pendidikan = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    status_aktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_jenjang_pendidikan", x => x.m_jenjang_pendidikan_id);
                });

            migrationBuilder.CreateTable(
                name: "m_kelurahan_desa",
                columns: table => new
                {
                    m_kelurahan_desa_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jenis_kabupaten_kota = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    kode_pos = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    nama_kabupaten_kota = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nama_kecamatan = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nama_kelurahan_desa = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nama_propinsi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_kelurahan_desa", x => x.m_kelurahan_desa_id);
                });

            migrationBuilder.CreateTable(
                name: "m_parameter",
                columns: table => new
                {
                    m_parameter_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    parameter_group = table.Column<string>(type: "longtext", nullable: false),
                    parameter_key = table.Column<string>(type: "longtext", nullable: false),
                    parameter_value = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_parameter", x => x.m_parameter_id);
                });

            migrationBuilder.CreateTable(
                name: "m_pilihan_omzet",
                columns: table => new
                {
                    m_pilihan_omzet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pilihan_omzet = table.Column<string>(type: "longtext", nullable: false),
                    urutan_pilihan_omzet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_pilihan_omzet", x => x.m_pilihan_omzet_id);
                });

            migrationBuilder.CreateTable(
                name: "m_user_group",
                columns: table => new
                {
                    m_user_group_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_group_default = table.Column<bool>(type: "bit", nullable: false),
                    user_group_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_user_group", x => x.m_user_group_id);
                });

            migrationBuilder.CreateTable(
                name: "t_kategori_posting",
                columns: table => new
                {
                    t_kategori_posting_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nama_kategori_posting = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_kategori_posting", x => x.t_kategori_posting_id);
                });

            migrationBuilder.CreateTable(
                name: "m_feature",
                columns: table => new
                {
                    m_feature_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    feature_icon = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    feature_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    feature_private = table.Column<bool>(type: "bit", nullable: false),
                    feature_sequence = table.Column<int>(type: "int", nullable: false),
                    feature_url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    m_feature_group_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_feature", x => x.m_feature_id);
                    table.ForeignKey(
                        name: "FK_m_feature_m_feature_group_m_feature_group_id",
                        column: x => x.m_feature_group_id,
                        principalTable: "m_feature_group",
                        principalColumn: "m_feature_group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_data_anggota",
                columns: table => new
                {
                    t_data_anggota_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    alamat_ktp_anggota = table.Column<string>(type: "longtext", nullable: false),
                    alamat_tempat_tinggal_anggota = table.Column<string>(type: "longtext", nullable: false),
                    asosiasi_komunitas_anggota = table.Column<string>(type: "longtext", nullable: false),
                    email_anggota = table.Column<string>(type: "longtext", nullable: false),
                    kesediaan_mendaftar_sebagai_anggota = table.Column<bool>(type: "bit", nullable: false),
                    m_jenjang_pendidikan_id = table.Column<int>(type: "int", nullable: false),
                    m_kelurahan_desa_id_ktp_anggota = table.Column<int>(type: "int", nullable: false),
                    m_kelurahan_desa_id_tt_anggota = table.Column<int>(type: "int", nullable: false),
                    nama_belakang_anggota = table.Column<string>(type: "longtext", nullable: false),
                    nama_depan_anggota = table.Column<string>(type: "longtext", nullable: false),
                    nomor_ktp_anggota = table.Column<string>(type: "longtext", nullable: false),
                    rt_ktp_anggota = table.Column<string>(type: "longtext", nullable: false),
                    rt_tempat_tinggal_anggota = table.Column<string>(type: "longtext", nullable: false),
                    rw_ktp_anggota = table.Column<string>(type: "longtext", nullable: false),
                    rw_tempat_tinggal_anggota = table.Column<string>(type: "longtext", nullable: false),
                    tanggal_pendaftaran_anggota = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    telepon_anggota = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_data_anggota", x => x.t_data_anggota_id);
                    table.ForeignKey(
                        name: "FK_t_data_anggota_m_jenjang_pendidikan_m_jenjang_pendidikan_id",
                        column: x => x.m_jenjang_pendidikan_id,
                        principalTable: "m_jenjang_pendidikan",
                        principalColumn: "m_jenjang_pendidikan_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_data_anggota_m_kelurahan_desa_m_kelurahan_desa_id_ktp_anggota",
                        column: x => x.m_kelurahan_desa_id_ktp_anggota,
                        principalTable: "m_kelurahan_desa",
                        principalColumn: "m_kelurahan_desa_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_data_anggota_m_kelurahan_desa_m_kelurahan_desa_id_tt_anggota",
                        column: x => x.m_kelurahan_desa_id_tt_anggota,
                        principalTable: "m_kelurahan_desa",
                        principalColumn: "m_kelurahan_desa_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "m_user",
                columns: table => new
                {
                    m_user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    m_user_group_id = table.Column<int>(type: "int", nullable: false),
                    user_active = table.Column<bool>(type: "bit", nullable: false),
                    user_email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    user_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    user_password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_user", x => x.m_user_id);
                    table.ForeignKey(
                        name: "FK_m_user_m_user_group_m_user_group_id",
                        column: x => x.m_user_group_id,
                        principalTable: "m_user_group",
                        principalColumn: "m_user_group_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_posting",
                columns: table => new
                {
                    t_posting_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    isi_posting = table.Column<string>(type: "longtext", nullable: false),
                    judul_posting = table.Column<string>(type: "longtext", nullable: false),
                    status_posting = table.Column<string>(type: "longtext", nullable: false),
                    t_kategori_posting_id = table.Column<int>(type: "int", nullable: false),
                    tanggal_posting = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    thumbnail_posting = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_posting", x => x.t_posting_id);
                    table.ForeignKey(
                        name: "FK_t_posting_t_kategori_posting_t_kategori_posting_id",
                        column: x => x.t_kategori_posting_id,
                        principalTable: "t_kategori_posting",
                        principalColumn: "t_kategori_posting_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feature_map",
                columns: table => new
                {
                    feature_map_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    m_feature_id = table.Column<int>(type: "int", nullable: false),
                    m_user_group_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feature_map", x => x.feature_map_id);
                    table.ForeignKey(
                        name: "FK_feature_map_m_feature_m_feature_id",
                        column: x => x.m_feature_id,
                        principalTable: "m_feature",
                        principalColumn: "m_feature_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_feature_map_m_user_group_m_user_group_id",
                        column: x => x.m_user_group_id,
                        principalTable: "m_user_group",
                        principalColumn: "m_user_group_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_data_usaha",
                columns: table => new
                {
                    t_data_usaha_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    alamat_usaha = table.Column<string>(type: "longtext", nullable: false),
                    deskripsi_usaha = table.Column<string>(type: "longtext", nullable: false),
                    jabatan_bisnis = table.Column<string>(type: "longtext", nullable: false),
                    ktp_usaha = table.Column<string>(type: "longtext", nullable: false),
                    m_jenis_bidang_usaha_id = table.Column<int>(type: "int", nullable: false),
                    m_kelurahan_desa_id = table.Column<int>(type: "int", nullable: false),
                    m_pilihan_omzet_id = table.Column<int>(type: "int", nullable: false),
                    nama_badan_usaha = table.Column<string>(type: "longtext", nullable: false),
                    nama_bisnis = table.Column<string>(type: "longtext", nullable: false),
                    npwp_usaha = table.Column<string>(type: "longtext", nullable: false),
                    sosmed_usaha_fb = table.Column<string>(type: "longtext", nullable: false),
                    sosmed_usaha_ig = table.Column<string>(type: "longtext", nullable: false),
                    sosmed_usaha_tw = table.Column<string>(type: "longtext", nullable: false),
                    t_data_anggota_id = table.Column<int>(type: "int", nullable: false),
                    tahun_pendirian_usaha = table.Column<string>(type: "longtext", nullable: false),
                    website_usaha = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_data_usaha", x => x.t_data_usaha_id);
                    table.ForeignKey(
                        name: "FK_t_data_usaha_m_jenis_bidang_usaha_m_jenis_bidang_usaha_id",
                        column: x => x.m_jenis_bidang_usaha_id,
                        principalTable: "m_jenis_bidang_usaha",
                        principalColumn: "m_jenis_bidang_usaha_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_data_usaha_m_kelurahan_desa_m_kelurahan_desa_id",
                        column: x => x.m_kelurahan_desa_id,
                        principalTable: "m_kelurahan_desa",
                        principalColumn: "m_kelurahan_desa_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_data_usaha_m_pilihan_omzet_m_pilihan_omzet_id",
                        column: x => x.m_pilihan_omzet_id,
                        principalTable: "m_pilihan_omzet",
                        principalColumn: "m_pilihan_omzet_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_data_usaha_t_data_anggota_t_data_anggota_id",
                        column: x => x.t_data_anggota_id,
                        principalTable: "t_data_anggota",
                        principalColumn: "t_data_anggota_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_info_bekraf",
                columns: table => new
                {
                    t_info_bekraf_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    deskripsikan_tentang_bekraf = table.Column<string>(type: "longtext", nullable: false),
                    harapan_terhadap_bekraf = table.Column<string>(type: "longtext", nullable: false),
                    keahlian_khusus = table.Column<string>(type: "longtext", nullable: false),
                    kota_event_bekraf = table.Column<string>(type: "longtext", nullable: false),
                    publikasi_event_bekraf = table.Column<string>(type: "longtext", nullable: false),
                    t_data_anggota_id = table.Column<int>(type: "int", nullable: false),
                    tahu_bekraf = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_info_bekraf", x => x.t_info_bekraf_id);
                    table.ForeignKey(
                        name: "FK_t_info_bekraf_t_data_anggota_t_data_anggota_id",
                        column: x => x.t_data_anggota_id,
                        principalTable: "t_data_anggota",
                        principalColumn: "t_data_anggota_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_data_pemegang_saham",
                columns: table => new
                {
                    t_data_pemegang_saham_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ktp_pemegang_saham = table.Column<string>(type: "longtext", nullable: false),
                    npwp_pemegang_saham = table.Column<string>(type: "longtext", nullable: false),
                    persentase_saham = table.Column<string>(type: "longtext", nullable: false),
                    t_data_usaha_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_data_pemegang_saham", x => x.t_data_pemegang_saham_id);
                    table.ForeignKey(
                        name: "FK_t_data_pemegang_saham_t_data_usaha_t_data_usaha_id",
                        column: x => x.t_data_usaha_id,
                        principalTable: "t_data_usaha",
                        principalColumn: "t_data_usaha_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_hak_kekayaan_intelektual",
                columns: table => new
                {
                    t_hak_kekayaan_intelektual_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    definisi_hak_kekayaan_intelektual = table.Column<string>(type: "longtext", nullable: false),
                    kendala_saat_menjalankan_usaha = table.Column<string>(type: "longtext", nullable: false),
                    konsep_keuangan_usaha = table.Column<string>(type: "longtext", nullable: false),
                    nama_hak_kekayaan_intelektual = table.Column<string>(type: "longtext", nullable: false),
                    penjelasan_hak_kekayaan_intelektual = table.Column<string>(type: "longtext", nullable: false),
                    penjelasan_tempat_usaha = table.Column<string>(type: "longtext", nullable: false),
                    pernah_melakukan_kredit_pinjaman = table.Column<string>(type: "longtext", nullable: false),
                    pernah_mendapat_bantuan_pemerintah_swasta = table.Column<string>(type: "longtext", nullable: false),
                    t_data_usaha_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_hak_kekayaan_intelektual", x => x.t_hak_kekayaan_intelektual_id);
                    table.ForeignKey(
                        name: "FK_t_hak_kekayaan_intelektual_t_data_usaha_t_data_usaha_id",
                        column: x => x.t_data_usaha_id,
                        principalTable: "t_data_usaha",
                        principalColumn: "t_data_usaha_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_pendirian_legalitas",
                columns: table => new
                {
                    t_pendirian_legalitas_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    penjelasan_domisili_usaha = table.Column<string>(type: "longtext", nullable: false),
                    surat_keterangan_domisili_usaha = table.Column<string>(type: "longtext", nullable: false),
                    t_data_usaha_id = table.Column<int>(type: "int", nullable: false),
                    usulan_nama_perusahaan = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_pendirian_legalitas", x => x.t_pendirian_legalitas_id);
                    table.ForeignKey(
                        name: "FK_t_pendirian_legalitas_t_data_usaha_t_data_usaha_id",
                        column: x => x.t_data_usaha_id,
                        principalTable: "t_data_usaha",
                        principalColumn: "t_data_usaha_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_feature_map_m_feature_id",
                table: "feature_map",
                column: "m_feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_feature_map_m_user_group_id",
                table: "feature_map",
                column: "m_user_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_m_feature_m_feature_group_id",
                table: "m_feature",
                column: "m_feature_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_m_user_m_user_group_id",
                table: "m_user",
                column: "m_user_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_anggota_m_jenjang_pendidikan_id",
                table: "t_data_anggota",
                column: "m_jenjang_pendidikan_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_anggota_m_kelurahan_desa_id_ktp_anggota",
                table: "t_data_anggota",
                column: "m_kelurahan_desa_id_ktp_anggota");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_anggota_m_kelurahan_desa_id_tt_anggota",
                table: "t_data_anggota",
                column: "m_kelurahan_desa_id_tt_anggota");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_pemegang_saham_t_data_usaha_id",
                table: "t_data_pemegang_saham",
                column: "t_data_usaha_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_usaha_m_jenis_bidang_usaha_id",
                table: "t_data_usaha",
                column: "m_jenis_bidang_usaha_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_usaha_m_kelurahan_desa_id",
                table: "t_data_usaha",
                column: "m_kelurahan_desa_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_usaha_m_pilihan_omzet_id",
                table: "t_data_usaha",
                column: "m_pilihan_omzet_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_data_usaha_t_data_anggota_id",
                table: "t_data_usaha",
                column: "t_data_anggota_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_hak_kekayaan_intelektual_t_data_usaha_id",
                table: "t_hak_kekayaan_intelektual",
                column: "t_data_usaha_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_info_bekraf_t_data_anggota_id",
                table: "t_info_bekraf",
                column: "t_data_anggota_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_pendirian_legalitas_t_data_usaha_id",
                table: "t_pendirian_legalitas",
                column: "t_data_usaha_id");

            migrationBuilder.CreateIndex(
                name: "IX_t_posting_t_kategori_posting_id",
                table: "t_posting",
                column: "t_kategori_posting_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "feature_map");

            migrationBuilder.DropTable(
                name: "m_agama");

            migrationBuilder.DropTable(
                name: "m_golongan_darah");

            migrationBuilder.DropTable(
                name: "m_parameter");

            migrationBuilder.DropTable(
                name: "m_user");

            migrationBuilder.DropTable(
                name: "t_data_pemegang_saham");

            migrationBuilder.DropTable(
                name: "t_hak_kekayaan_intelektual");

            migrationBuilder.DropTable(
                name: "t_info_bekraf");

            migrationBuilder.DropTable(
                name: "t_pendirian_legalitas");

            migrationBuilder.DropTable(
                name: "t_posting");

            migrationBuilder.DropTable(
                name: "m_feature");

            migrationBuilder.DropTable(
                name: "m_user_group");

            migrationBuilder.DropTable(
                name: "t_data_usaha");

            migrationBuilder.DropTable(
                name: "t_kategori_posting");

            migrationBuilder.DropTable(
                name: "m_feature_group");

            migrationBuilder.DropTable(
                name: "m_jenis_bidang_usaha");

            migrationBuilder.DropTable(
                name: "m_pilihan_omzet");

            migrationBuilder.DropTable(
                name: "t_data_anggota");

            migrationBuilder.DropTable(
                name: "m_jenjang_pendidikan");

            migrationBuilder.DropTable(
                name: "m_kelurahan_desa");
        }
    }
}
