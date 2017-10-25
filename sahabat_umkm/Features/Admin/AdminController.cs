using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sahabat_umkm.Models;
using sahabat_umkm.Classes;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace sahabat_umkm.Controllers
{
    public class AdminController : Controller
    {
        private readonly m_news _context;

        public AdminController(m_news context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            ViewData["SubTitle"] = "Login Administrator";

            return View("Index");
        }

        public IActionResult FormAgama()
        {
            ViewData["Title"] = "Manage Data";
            ViewData["Subtitle"] = "Data Agama";
            return View();
        }

        //[HttpPost]
        [ValidateAntiForgeryToken]
        public string GetAllDataAgama()
        {
            string result = "";

            DataResponseMessage _returnMessage = new DataResponseMessage();
            _returnMessage.data = null; _returnMessage.status = false; _returnMessage.remark = "LoadData"; _returnMessage.message = "Gagal";
            try
            {
                var m_agama_data = (
                  from data in _context.m_agama
                  select new
                  {
                      data.m_agama_id,
                      data.nama_agama,
                      data.status_aktif
                  }
                 ).ToList();

                _returnMessage.data = m_agama_data;
                _returnMessage.status = true; _returnMessage.remark = "LoadData"; _returnMessage.message = "Sukses"; result = Newtonsoft.Json.JsonConvert.SerializeObject(_returnMessage);
                //GLSDashboardCoreGlobal.writeActivityLog(HttpContext, User.Identity.Name, "m_user_group", "GetAllData", JsonConvert.SerializeObject(id));
            }
            catch (Exception e) { }
            return result;
        }

        [ValidateAntiForgeryToken]
        public async Task<string> SimpanDataAgama(m_agama paramData)
        {

            DataResponseMessage _returnMessage = new DataResponseMessage();
            _returnMessage.status = false; _returnMessage.data = ""; _returnMessage.remark = "Save"; _returnMessage.message = "";

            try
            {
                if (_context.m_agama.Any(e => e.m_agama_id == paramData.m_agama_id))
                {
                    if (_context.m_agama.Any(e => e.nama_agama == paramData.nama_agama))
                    {
                        string get_nama_agama = _context.m_agama.Where(a => a.m_agama_id == paramData.m_agama_id).Single().nama_agama.ToString();
                        if (paramData.nama_agama.ToLower() == get_nama_agama.ToLower())
                        {
                            _context.m_agama.Update(paramData);
                            _returnMessage.status = true; _returnMessage.message = "Data berhasil diubah";
                        }
                        else
                        {
                            _returnMessage.status = false;
                            _returnMessage.message = "Data sudah ada";
                        }

                    }
                    else
                    {
                        _context.m_agama.Update(paramData);
                        _returnMessage.status = true; _returnMessage.message = "Data berhasil diubah";
                    }
                }
                else
                {
                    if (_context.m_agama.Any(e => e.nama_agama == paramData.nama_agama))
                    {
                        _returnMessage.status = false;
                        _returnMessage.message = "Data sudah ada";
                    }
                    else
                    {
                        _context.m_agama.Add(paramData);
                        _returnMessage.status = true; _returnMessage.message = "Data berhasil ditambahkan";
                    }

                }

                await _context.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                _returnMessage.message = ex.Message;
            }

            return JsonConvert.SerializeObject(_returnMessage);
        }

        [ValidateAntiForgeryToken]
        public async Task<string> HapusDataAgama(int id)
        {
            Response.ContentType = "application/json; charset=utf-8";
            DataResponseMessage _returnMessage = new DataResponseMessage();
            _returnMessage.status = false;
            _returnMessage.data = "";
            _returnMessage.remark = "Delete";
            _returnMessage.message = "";

            try
            {
                var rowInDB = await _context.m_agama.AsNoTracking().SingleOrDefaultAsync(m => m.m_agama_id == id);
                if (rowInDB == null)
                {
                    _returnMessage.status = false;
                    _returnMessage.message = "Data tidak ada";
                }
                else
                {
                    _context.m_agama.Remove(rowInDB);
                    await _context.SaveChangesAsync();
                    _returnMessage.status = true;
                    _returnMessage.message = "Data telah dihapus";
                }
            }
            catch (Exception ex)
            {
                _returnMessage.message = ex.Message;
            }
            return JsonConvert.SerializeObject(_returnMessage);
        }
    }
}