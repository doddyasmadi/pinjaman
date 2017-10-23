using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using NLog;
using sahabat_umkm.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace sahabat_umkm {
  public static class AppCoreGlobal {
    static internal string BASE_URL = "";

    static internal void writeActivityLog(HttpContext _context, string username, string fitur, string aksi, Object data, string pesan = "") {
      try {

        string user_agent = _context.Request.Headers["User-Agent"];
        UserAgent.UserAgent ua = new UserAgent.UserAgent(user_agent);
        var ipAddress = _context.Connection.RemoteIpAddress;

        Logger logger = LogManager.GetCurrentClassLogger();
        LogEventInfo theEvent = new LogEventInfo(NLog.LogLevel.Info, "activity_log", data.ToString() + pesan.ToString());

        theEvent.Properties["fitur"] = fitur;
        theEvent.Properties["aksi"] = aksi;
        theEvent.Properties["username"] = username;
        theEvent.Properties["browser_name"] = ua.Browser.Name;
        theEvent.Properties["browser_version"] = ua.Browser.Version;
        theEvent.Properties["os_name"] = ua.OS.Name;
        theEvent.Properties["os_version"] = ua.OS.Version;
        theEvent.Properties["ip_address"] = ipAddress;

        logger.Log(theEvent);
      }
      catch (Exception) {

      }
    }

    static internal string get_connection_string(string type, string db_server = "SQLServer") {
      string connection = "";
      //pradikta  
      //connection = "Server=(local);Database=Access;user id=sa; password=Med1xsoft;";
      //GLS
      //connection = "Server=.\\SQLSERVER2016;Database=Access;user id=sa; password=GL-System123;";
      //Dashboard
      if (db_server == "SQLServer") {
        if (type == "Access") {
          connection = "Server=.\\SQLSERVER2016;Database=sahabat_umkm;user id=sa; password=GL-System123;";
        }
        else if (type == "StarSchema") {
          connection = "Server=.\\SQLSERVER2016;Database=sahabat_umkm;user id=sa; password=GL-System123;";
        }
      }
      else if (db_server == "MySQL") {
        if (type == "Access") {
            //connection = "Server=localhost;Port=30000;Database=sahabat_umkm;Uid=root;Pwd=GL-System123;"; //MariaDB
            connection = "Server=localhost;Port=3306;Database=sahabat_umkm;Uid=root;Pwd=;"; //MySQL
        }
        else if (type == "StarSchema") {
            //connection = "Server=localhost;Port=30000;Database=sahabat_umkm;Uid=root;Pwd=GL-System123;"; //MariaDB
            connection = "Server=localhost;Port=3306;Database=sahabat_umkm;Uid=root;Pwd=;"; //MySQL
        }
      }
      return connection;
    }

    public static bool check_access_feature(string feature_url, int[] feature_array) {
      bool access_allowed = false;
      m_news _context = new m_news();
      try {
        int feature_id = _context.m_feature.Where(e => e.feature_url == feature_url).Single().m_feature_id;
        access_allowed = feature_array.Contains(feature_id) ? true : false;
      }
      catch {
        access_allowed = feature_url == "Dashboard" ? true : false; //override db check
      }
      return access_allowed;
    }

    public static int get_session_timeout() {
      m_news _context = new m_news();
      int session_timeout = Convert.ToInt32(_context.m_parameter.Where(e => e.parameter_key == "Session Timeout").Single().parameter_value);
      return session_timeout;
    }

    public static int get_max_archive_files() {
      m_news _context = new m_news();
      int session_timeout = Convert.ToInt32(_context.m_parameter.Where(e => e.parameter_key == "MaxArchiveFiles").Single().parameter_value);
      return session_timeout;
    }

    public static object ToNonAnonymousList<T>(this List<T> list, Type t) {
      //define system Type representing List of objects of T type:
      Type genericType = typeof(List<>).MakeGenericType(t);

      //create an object instance of defined type:
      object l = Activator.CreateInstance(genericType);

      //get method Add from from the list:
      MethodInfo addMethod = l.GetType().GetMethod("Add");

      //loop through the calling list:
      foreach (T item in list) {
        //convert each object of the list into T object by calling extension ToType<T>()
        //Add this object to newly created list:
        addMethod.Invoke(l, new[] { item.ToType(t) });
      }
      //return List of T objects:
      return l;
    }

    public static object ToType<T>(this object obj, T type) {
      //create instance of T type object:
      object tmp = Activator.CreateInstance(Type.GetType(type.ToString()));

      //loop through the properties of the object you want to covert:          
      foreach (PropertyInfo pi in obj.GetType().GetProperties()) {
        try {
          //get the value of property and try to assign it to the property of T type object:
          tmp.GetType().GetProperty(pi.Name).SetValue(tmp, pi.GetValue(obj, null), null);
        }
        catch (Exception ex) {
          //Logging.Log.Error(ex);
        }
      }
      //return the T type object:         
      return tmp;
    }

    public static byte[] SerializeAndCompress(this object obj) {
      using (var memoryStream = new MemoryStream()) {
        using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress)) {
          BinaryFormatter binaryFormatter = new BinaryFormatter();
          binaryFormatter.Serialize(gZipStream, obj);
        }
        return memoryStream.ToArray();
      }
    }

    public static T DecompressAndDeserialize<T>(this byte[] data) {
      using (MemoryStream ms = new MemoryStream(data))
      using (GZipStream zs = new GZipStream(ms, CompressionMode.Decompress, true)) {
        BinaryFormatter bf = new BinaryFormatter();
        return (T)bf.Deserialize(zs);
      }
    }

  }

}
