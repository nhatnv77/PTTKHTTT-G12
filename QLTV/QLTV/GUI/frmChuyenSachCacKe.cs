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
    public partial class frmChuyenSachCacKe : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenSachCacKe()
        {
            InitializeComponent();
        }

        private void LoadKe1()
        {
            if (lkKe1.EditValue != null)
            {
                if (lkKe1.EditValue == lkKe2.EditValue)
                {
                    XDialog.Error("Đã hiển thị sách trong kệ này! Vui lòng chọn kệ khác!");
                    lkKe1.EditValue = null;
                    bdsSach.DataSource = null;
                }
                else
                {
                    string maKe = lkKe1.EditValue.ToString();
                    KeSach ke = Data.Instance.KeSach.Find(maKe);
                    bdsSach.DataSource = ke.Sach.ToList();
                }
            }
            btnChuyenXuong.Enabled = bdsSach.Count > 0;
        }

        private void LoadKe2()
        {

            if (lkKe2.EditValue != null)
            {
                if (lkKe2.EditValue == lkKe1.EditValue)
                {
                    XDialog.Error("Đã hiển thị sách trong kệ này! Vui lòng chọn kệ khác!");
                    lkKe2.EditValue = null;
                    bdsSach2.DataSource = null;
                }
                else
                {
                    string maKe = lkKe2.EditValue.ToString();
                    KeSach ke = Data.Instance.KeSach.Find(maKe);
                    bdsSach2.DataSource = ke.Sach.ToList();
                }
            }
            btnChuyenLen.Enabled = bdsSach2.Count > 0;
        }

        private void LoadData()
        {
            bdsKe.DataSource = Data.Instance.KeSach.ToList();
            bdsKe2.DataSource = Data.Instance.KeSach.ToList();
            LoadKe1();
            LoadKe2();
        }

        private void frmChuyenSachCacKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lkKho1_EditValueChanged(object sender, EventArgs e)
        {
            LoadKe1();
        }

        private void lkKho2_EditValueChanged(object sender, EventArgs e)
        {
            LoadKe2();
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
            if (lkKe2.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kệ sách cần chuyển tới!");
                return;
            }
            string maKe = lkKe2.EditValue.ToString();
            KeSach ke = Data.Instance.KeSach.Find(maKe);
            book.KeSach = ke;
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
            if (lkKe1.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kệ sách cần chuyển tới!");
                return;
            }
            string maKe = lkKe1.EditValue.ToString();
            KeSach ke = Data.Instance.KeSach.Find(maKe);
            book.KeSach = ke;
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