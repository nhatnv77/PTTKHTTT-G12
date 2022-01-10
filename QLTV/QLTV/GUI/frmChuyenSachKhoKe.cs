using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QLTV.DAO;
using QLTV.Entity;
using QLTV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class frmChuyenSachKhoKe : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenSachKhoKe()
        {
            InitializeComponent();
        }

        private void LoadKho()
        {
            if (lkKho.EditValue != null)
            {
                string maKho = lkKho.EditValue.ToString();
                Kho kho = Data.Instance.Kho.Find(maKho);
                bdsSach.DataSource = kho.Sach.ToList();
            }
            btnChuyenXuong.Enabled = bdsSach.Count > 0;
        }

        private void LoadKe()
        {
            if (lkKeSach.EditValue != null)
            {
                string maKe = lkKeSach.EditValue.ToString();
                KeSach ke = Data.Instance.KeSach.Find(maKe);
                bdsSach2.DataSource = ke.Sach.ToList();
            }
            btnChuyenLen.Enabled = bdsSach2.Count > 0;
        }

        private void LoadData()
        {
            bdsKho.DataSource = Data.Instance.Kho.ToList();
            bdsKeSach.DataSource = Data.Instance.KeSach.ToList();
            LoadKho();
            LoadKe();
        }

        private void frmChuyenSachCacKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lkKho_EditValueChanged(object sender, EventArgs e)
        {
            LoadKho();
        }

        private void lkKeSach_EditValueChanged(object sender, EventArgs e)
        {
            LoadKe();
        }

        private void gvSach1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string fileName = (string)view.GetRowCellValue(e.ListSourceRowIndex, "TuaSach.HinhAnh");
                if (string.IsNullOrEmpty(fileName))
                {
                    e.Value = null;
                    return;
                }
                if (!ImageData.Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = DevExpress.Utils.FilesHelper
                            .FindingFileName(Application.StartupPath, ImageData.ImageDir + fileName, false);
                        img = Image.FromFile(filePath);
                    }
                    catch
                    {
                    }
                    ImageData.Images.Add(fileName, img);
                }
                e.Value = ImageData.Images[fileName];
            }
        }

        private void gvSach2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string fileName = (string)view.GetRowCellValue(e.ListSourceRowIndex, "TuaSach.HinhAnh");
                if (string.IsNullOrEmpty(fileName))
                {
                    e.Value = null;
                    return;
                }
                if (!ImageData.Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = DevExpress.Utils.FilesHelper
                            .FindingFileName(Application.StartupPath, ImageData.ImageDir + fileName, false);
                        img = Image.FromFile(filePath);
                    }
                    catch
                    {
                    }
                    ImageData.Images.Add(fileName, img);
                }
                e.Value = ImageData.Images[fileName];
            }
        }

        private void btnChuyenXuong_Click(object sender, EventArgs e)
        {
            Sach book = bdsSach.Current as Sach;
            if (lkKeSach.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kệ sách cần chuyển sách tới!");
                return;
            }
            string maKe = lkKeSach.EditValue.ToString();
            KeSach ke = Data.Instance.KeSach.Find(maKe);
            book.KeSach = ke;
            book.Kho = null;
            try
            {
                Data.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi chuyển sách!\n" + ex.Message);
            }
            LoadData();
        }

        private void btnChuyenLen_Click(object sender, EventArgs e)
        {
            Sach book = bdsSach2.Current as Sach;
            if (lkKho.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kho cần chuyển sách tới!");
                return;
            }
            string maKho = lkKho.EditValue.ToString();
            Kho kho = Data.Instance.Kho.Find(maKho);
            book.Kho = kho;
            book.KeSach = null;
            try
            {
                Data.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi chuyển sách!\n" + ex.Message);
            }
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}