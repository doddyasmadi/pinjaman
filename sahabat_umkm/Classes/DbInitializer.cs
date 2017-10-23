using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using sahabat_umkm;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Migrations;


public static class DbInitializer {
  public static void Initialize() {
    using (var context = new m_news()) {

      context.Database.Migrate();

      if (context.m_users.Any() || context.m_feature_groups.Any()) { // Look for any user.
        return;   // DB has been seeded
      }

      //m_feature_group
      List<m_feature_group> m_feature_group = new List<m_feature_group>
      {
                new m_feature_group{feature_group_name="Data" },
                new m_feature_group{feature_group_name="Akses" },
                };
      foreach (m_feature_group m_feature_group_data in m_feature_group) { context.m_feature_groups.Add(m_feature_group_data); }
      context.SaveChanges();

      //m_feature
      int m_feature_group_id = 1;
      List<m_feature> m_feature1 = new List<m_feature>
      {
                    new m_feature{feature_name="Dashboard", feature_sequence=1, feature_url="Dashboard", feature_icon="icon-tachometer", feature_private=true, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="Unggah Data", feature_sequence=2, feature_url="data_upload", feature_icon="icon-upload3", feature_private=true, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="Tampilkan Data", feature_sequence=3, feature_url="data_display", feature_icon="icon-display", feature_private=true, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="Pivot Data", feature_sequence=4, feature_url="data_pivot", feature_icon="icon-filter", feature_private=true, m_feature_group_id=m_feature_group_id},
                };
      m_feature_group_id = 2;
      List<m_feature> m_feature2 = new List<m_feature>
        {
                    new m_feature{feature_name="Feature Group", feature_sequence=1, feature_url="m_feature_group", feature_icon="icon-list-alt", feature_private=true, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="Feature", feature_sequence=2, feature_url="m_feature", feature_icon="icon-list", feature_private=true, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="User Group", feature_sequence=3, feature_url="m_user_group", feature_icon="icon-users2", feature_private=false, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="User", feature_sequence=4, feature_url="m_user", feature_icon="icon-user", feature_private=false, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="Data Dinas", feature_sequence=5, feature_url="data_dinas_pendidikan", feature_icon="icon-building", feature_private=false, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="Daftar Sekolah", feature_sequence=6, feature_url="daftar_sekolah", feature_icon="icon-home3", feature_private=false, m_feature_group_id=m_feature_group_id},
                    new m_feature{feature_name="Log Viewer", feature_sequence=7, feature_url="log_viewer", feature_icon="icon-history", feature_private=true, m_feature_group_id=m_feature_group_id},
                  };
      List<m_feature> m_feature = m_feature1.Concat(m_feature2).ToList(); //add several list together
      foreach (m_feature m_feature_data in m_feature) { context.m_features.Add(m_feature_data); }
      context.SaveChanges();

      //m_user_group
      List<m_user_group> m_user_group = new List<m_user_group>
        {
                    new m_user_group{user_group_name="Administrator", user_group_default=true},
                  };
      foreach (m_user_group m_user_group_data in m_user_group) { context.m_user_groups.Add(m_user_group_data); }
      context.SaveChanges();

      //m_user
      List<m_user> m_user = new List<m_user>
        {
                    new m_user{user_name="Admin", user_password=PasswordStorage.CreateHash("Admin"), user_email="admin@email.com", user_active=true, m_user_group_id=1},
                  };
      foreach (m_user m_user_data in m_user) { context.m_users.Add(m_user_data); }
      context.SaveChanges();


    }
  }
}
