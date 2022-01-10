using QLTV.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Util
{
    public static class CodeGenerator
    {
        public static string SinhMaKho()
        {
            string prefix = "KH";
            List<string> ids = Data.Instance.Kho.Select(k => k.MaKho.Substring(prefix.Length)).ToList();
            int i = 0;
            while (true)
            {
                ++i;
                string ma = i.ToString("000");
                bool isExist = false;
                foreach (string id in ids)
                {
                    if (ma == id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    ids.Remove(ma);
                    continue;
                }
                return prefix + ma;
            }
        }

        public static string SinhMaDoiTac()
        {
            string prefix = "DT";
            List<string> ids = Data.Instance.DoiTac.Select(d => d.MaDoiTac.Substring(prefix.Length)).ToList();
            int i = 0;
            while (true)
            {
                ++i;
                string ma = i.ToString("000");
                bool isExist = false;
                foreach (string id in ids)
                {
                    if (ma == id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    ids.Remove(ma);
                    continue;
                }
                return prefix + ma;
            }
        }

        public static string SinhMaTacGia()
        {
            string prefix = "TG";
            List<string> ids = Data.Instance.TacGia.Select(t => t.MaTacGia.Substring(prefix.Length)).ToList();
            int i = 0;
            while (true)
            {
                ++i;
                string ma = i.ToString("000");
                bool isExist = false;
                foreach (string id in ids)
                {
                    if (ma == id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    ids.Remove(ma);
                    continue;
                }
                return prefix + ma;
            }
        }

        public static string SinhMaDocGia()
        {
            string prefix = "DG";
            List<string> ids = Data.Instance.DocGia.Select(d => d.MaDG.Substring(prefix.Length)).ToList();
            int i = 0;
            while (true)
            {
                ++i;
                string ma = i.ToString("000");
                bool isExist = false;
                foreach (string id in ids)
                {
                    if (ma == id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    ids.Remove(ma);
                    continue;
                }
                return prefix + ma;
            }
        }

        public static string SinhMaTheDocGia()
        {
            string prefix = "TH";
            List<string> ids = Data.Instance.TheDocGia.Select(d => d.MaTheDG.Substring(prefix.Length)).ToList();
            int i = 0;
            while (true)
            {
                ++i;
                string ma = i.ToString("000");
                bool isExist = false;
                foreach (string id in ids)
                {
                    if (ma == id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    ids.Remove(ma);
                    continue;
                }
                return prefix + ma;
            }
        }

        public static string SinhMaPhieuMuon()
        {
            string prefix = "PM";
            List<string> ids = Data.Instance.PhieuMuon.Select(p => p.MaPhieuMuon.Substring(prefix.Length)).ToList();
            int i = 0;
            while (true)
            {
                ++i;
                string ma = i.ToString("000");
                bool isExist = false;
                foreach (string id in ids)
                {
                    if (ma == id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    ids.Remove(ma);
                    continue;
                }
                return prefix + ma;
            }
        }

        public static string SinhMaPhieuTra()
        {
            string prefix = "PT";
            List<string> ids = Data.Instance.PhieuTra.Select(p => p.MaPhieuTra.Substring(prefix.Length)).ToList();
            int i = 0;
            while (true)
            {
                ++i;
                string ma = i.ToString("000");
                bool isExist = false;
                foreach (string id in ids)
                {
                    if (ma == id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    ids.Remove(ma);
                    continue;
                }
                return prefix + ma;
            }
        }
    }
}
