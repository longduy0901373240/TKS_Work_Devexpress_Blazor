using DataLayer;
using DevExpress.Blazor;
using Entity.Danh_Muc;
using Entity.XNK;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Utility;
using Web.Customize_Devexpress;
using OfficeOpenXml;

namespace Web.Pages.XNK
{
    public partial class Nhap_Kho_Management
    {
        #region Biến lọc ngày tháng
        DateTime StartDay { get; set; } = DateTime.Now.AddMonths(-1);
        DateTime EndDay { get; set; } = DateTime.Now;
        #endregion

        #region DxDataGrid
        EDataGrid<CXNK_Nhap_Kho> _Grid_Nhap_Kho;
        DxDataGrid<CXNK_Nhap_Kho_Chi_Tiet> _Grid_Nhap_Kho_Chi_Tiet;
        #endregion

        #region List objData
        private List<CXNK_Nhap_Kho> p_objData_Nhap_Kho;
        private List<CXNK_Nhap_Kho_Chi_Tiet> p_objData_Nhap_Kho_Chi_Tiet;
        private List<CDM_Kho> p_objData_Kho;
        private List<CDM_Nha_Cung_Cap> p_objData_Nha_Cung_Cap;
        private List<CDM_San_Pham> p_objData_San_Pham;
        #endregion

        #region objItem in EditFormtemplate Nhập kho
        public bool IsNewRow_Nhap_Kho { get; set; }
        public string Error_Nhap_Kho { get; set; }
        CXNK_Nhap_Kho p_objItem_Nhap_Kho = new CXNK_Nhap_Kho();
        #endregion

        #region objItem in EditFormtemplate Nhập kho chi tiết
        public bool IsNewRow_Nhap_Kho_Chi_Tiet { get; set; }
        public string Error_Nhap_Kho_Chi_Tiet { get; set; }
        CXNK_Nhap_Kho_Chi_Tiet p_objItem_Nhap_Kho_Chi_Tiet = new CXNK_Nhap_Kho_Chi_Tiet();
        #endregion

        int p_Auto_ID = 0;
        protected override async Task OnInitializedAsync()
        {
            p_objData_Kho = await _db_Kho.List_DM_Kho();
            p_objData_Nha_Cung_Cap = await _db_Nha_Cung_Cap.List_DM_Nha_Cung_Cap();
            p_objData_San_Pham = await _db_San_Pham.List_DM_San_Pham();
            p_objData_Nhap_Kho = await _db_Nhap_Kho.List_XNK_Nhap_Kho();
        }

        #region function Nhập Kho
        void OnCancelButtonClick_Nhap_Kho()
        {
            _Grid_Nhap_Kho.CancelRowEdit();
            p_objItem_Nhap_Kho = null;
            Error_Nhap_Kho = "";
        }
        async void OnRowStarting_Nhap_Kho(CXNK_Nhap_Kho p_objItem)
        {
            p_Auto_ID = 0;
            if (p_objItem == null)
            {
                p_objItem_Nhap_Kho = new CXNK_Nhap_Kho();
                p_objItem_Nhap_Kho.Ngay_Nhap_Kho = DateTime.Now;
                IsNewRow_Nhap_Kho = true;
                p_objData_Nhap_Kho_Chi_Tiet = new List<CXNK_Nhap_Kho_Chi_Tiet>();

            }
            else
            {
                p_objItem_Nhap_Kho = p_objItem;
                p_objItem_Nhap_Kho.Ngay_Nhap_Kho = DateTime.Now;
                IsNewRow_Nhap_Kho = false;
                p_objData_Nhap_Kho_Chi_Tiet = await _db_Nhap_Kho_Chi_Tiet.F40011_List_XNK_Nhap_Kho_Chi_Tiet_By_Nhap_Kho_ID(p_objItem.Auto_ID);
                foreach (CXNK_Nhap_Kho_Chi_Tiet item in p_objData_Nhap_Kho_Chi_Tiet)
                {
                    item.Auto_ID = p_Auto_ID;
                    p_Auto_ID++;
                }
            }
        }
        void HandleValiSubmit_Nhap_Kho()
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();
                CXNK_Nhap_Kho v_obj = p_objItem_Nhap_Kho;
                if (IsNewRow_Nhap_Kho == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    double v_dbTong_So_Luong = 0;
                    double v_dbTong_Tri_Gia = 0;
                    foreach (CXNK_Nhap_Kho_Chi_Tiet item in p_objData_Nhap_Kho_Chi_Tiet)
                    {
                        v_dbTong_So_Luong += item.So_Luong;
                        v_dbTong_Tri_Gia += item.So_Luong * item.Don_Gia;
                    }
                    v_obj.Tong_So_Luong = v_dbTong_So_Luong;
                    v_obj.Tong_Tri_Gia = v_dbTong_Tri_Gia;
                    v_obj.Auto_ID = _db_Nhap_Kho.Insert_XNK_Nhap_Kho(v_conn, v_trans, v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    double v_dbTong_So_Luong = 0;
                    double v_dbTong_Tri_Gia = 0;
                    foreach (CXNK_Nhap_Kho_Chi_Tiet item in p_objData_Nhap_Kho_Chi_Tiet)
                    {
                        v_dbTong_So_Luong += item.So_Luong;
                        v_dbTong_Tri_Gia += item.So_Luong * item.Don_Gia;
                    }
                    v_obj.Tong_So_Luong = v_dbTong_So_Luong;
                    v_obj.Tong_Tri_Gia = v_dbTong_Tri_Gia;
                    _db_Nhap_Kho.Update_XNK_Nhap_Kho(v_obj);
                    _db_Nhap_Kho_Chi_Tiet.F40011_Delete_XNK_Nhap_Kho_Chi_Tiet_By_Nhap_Kho_ID(v_obj.Auto_ID, v_obj.Last_Updated_By);
                }
                foreach (CXNK_Nhap_Kho_Chi_Tiet item in p_objData_Nhap_Kho_Chi_Tiet)
                {
                    item.Nhap_Kho_ID = v_obj.Auto_ID;
                    _db_Nhap_Kho_Chi_Tiet.Insert_XNK_Nhap_Kho_Chi_Tiet(v_conn, v_trans, item);
                }
                v_trans.Commit();
                _Grid_Nhap_Kho.CancelRowEdit();
                LoadData();
                Error_Nhap_Kho = "";
            }
            catch (Exception ex)
            {
                Error_Nhap_Kho = ex.Message;
            }
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        async void OnRowDeleting_Nhap_Kho(CXNK_Nhap_Kho p_obj)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db_Nhap_Kho.F4001_Delete_XNK_Nhap_Kho(p_obj.Auto_ID, p_obj.Last_Updated_By);
            }
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        #endregion

        #region function Nhập Kho Chi Tiết
        void OnCancelButtonClick_Nhap_Kho_Chi_Tiet()
        {
            _Grid_Nhap_Kho_Chi_Tiet.CancelRowEdit();
            p_objItem_Nhap_Kho_Chi_Tiet = null;
            Error_Nhap_Kho_Chi_Tiet = "";
        }
        void OnRowStarting_Nhap_Kho_Chi_Tiet(CXNK_Nhap_Kho_Chi_Tiet p_objItem)
        {
            if (p_objItem == null)
            {
                p_objItem_Nhap_Kho_Chi_Tiet = new CXNK_Nhap_Kho_Chi_Tiet();
                IsNewRow_Nhap_Kho_Chi_Tiet = true;
            }
            else
            {
                p_objItem_Nhap_Kho_Chi_Tiet = p_objItem;
                IsNewRow_Nhap_Kho_Chi_Tiet = false;
            }
        }
        void HandleValiSubmit_Nhap_Kho_Chi_Tiet()
        {
            try
            {
                CXNK_Nhap_Kho_Chi_Tiet v_objItem = p_objItem_Nhap_Kho_Chi_Tiet;
                if (IsNewRow_Nhap_Kho_Chi_Tiet == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    v_objItem.Auto_ID = p_Auto_ID;
                    p_objData_Nhap_Kho_Chi_Tiet.Add(v_objItem);
                    p_Auto_ID++;
                }
                else
                {
                    v_objItem.Last_Updated_By = "Long";
                    var item = p_objData_Nhap_Kho_Chi_Tiet.FirstOrDefault(p => p.Auto_ID == v_objItem.Auto_ID);
                    if (item != null)
                        item = v_objItem;
                }
                _Grid_Nhap_Kho_Chi_Tiet.CancelRowEdit();
                _Grid_Nhap_Kho_Chi_Tiet.Refresh();
                Error_Nhap_Kho_Chi_Tiet = "";
            }
            catch (Exception ex)
            {
                Error_Nhap_Kho_Chi_Tiet = ex.Message;
            }
        }
        async void OnRowDeleting_Nhap_Kho_Chi_Tiet(CXNK_Nhap_Kho_Chi_Tiet p_obj)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                p_objData_Nhap_Kho_Chi_Tiet.Remove(p_obj);
            }
            await _Grid_Nhap_Kho_Chi_Tiet.Refresh();
        }
        #endregion

        #region Excel
        //IBrowserFile file;
        string p_strPath;
        private async void OnInputFileChange(InputFileChangeEventArgs e)
        {
            try
            {
                CExcel_Controller v_objexcel = new CExcel_Controller();
                string v_strWebRootPath = env.WebRootPath;
                var url = await v_objexcel.SaveFile(e.File, v_strWebRootPath);
                p_strPath = null;
                p_strPath = url;
            }
            catch (Exception ex)
            {
                await IJS.InvokeVoidAsync("alert", $"Warning! {ex.Message}");
            }
        }
        private void Import_Excel()
        {
            CExcel_Controller v_objexcel = new CExcel_Controller();
            //lọc từ vùng chọn đến hết
            DataTable v_dt_List_Range_Value_To_End = v_objexcel.List_Range_Value_To_End("A1", "C", p_strPath);
            // lọc theo vùng mình chọn
            DataTable v_dt_List_Range_Value = v_objexcel.List_Range_Value("A3", "C4", p_strPath);
            string test = v_dt_List_Range_Value_To_End.Columns[0].ToString();
            foreach (DataRow v_row in v_dt_List_Range_Value_To_End.Rows)
            {
                CXNK_Nhap_Kho_Chi_Tiet v_objItem = new CXNK_Nhap_Kho_Chi_Tiet();
                v_objItem.San_Pham_ID = CUtility.Convert_To_Int32(v_row[0]);
                v_objItem.So_Luong = CUtility.Convert_To_Double(v_row[1]);
                v_objItem.Don_Gia = CUtility.Convert_To_Double(v_row[2]);
                Add_To_NKCT(p_objData_Nhap_Kho_Chi_Tiet, v_objItem);
            }
            p_strPath = "";
            IJS.InvokeVoidAsync("Clear_InputFile");
            InvokeAsync(StateHasChanged);
            _Grid_Nhap_Kho_Chi_Tiet.Refresh();
        }

        private void Add_To_NKCT(List<CXNK_Nhap_Kho_Chi_Tiet> v_arrCNKCT, CXNK_Nhap_Kho_Chi_Tiet item)
        {
            item.Last_Updated_By = "admin";
            int p_Auto_ID = 0;
            if (v_arrCNKCT.Count == 0)
                item.Auto_ID = p_Auto_ID;
            else
                item.Auto_ID = v_arrCNKCT.Last().Auto_ID + 1;
            v_arrCNKCT.Add(item);
        }
        private void ExportExcel()
        {
            CExcel_Controller v_objexcel = new CExcel_Controller();
            byte[] v_fileContents;
            //chọn vùng và màu cho background
            Dictionary<int, string[]> v_dicBkd_Color = new Dictionary<int, string[]>();
            v_dicBkd_Color.Add(1, new string[] { "A3", "C3", "#B7DEE8" });
            //chọn vùng muốn in đậm chữ
            Dictionary<int, string[]> v_dicBold_Text = new Dictionary<int, string[]>();
            v_dicBold_Text.Add(1,new string[] { "A1","C2"});
            Dictionary<int, string[]> v_dicHeader_Field_Nhap_Kho = new Dictionary<int, string[]>();
            v_dicHeader_Field_Nhap_Kho.Add(1, new string[] { "Auto ID", "Auto_ID" });
            v_dicHeader_Field_Nhap_Kho.Add(2, new string[] { "Số Phiếu Nhập", "So_Phieu_Nhap" });
            v_dicHeader_Field_Nhap_Kho.Add(3, new string[] { "Ngày Nhập Kho", "Ngay_Nhap_Kho" });
            //Export thêm màu và tô đậm
            v_fileContents = v_objexcel.Export_Excel<CXNK_Nhap_Kho>("A1", p_objData_Nhap_Kho, v_dicHeader_Field_Nhap_Kho, v_dicBold_Text, v_dicBkd_Color);
            //Export mặc định
            //v_fileContents = v_objexcel.Export_Excel<CXNK_Nhap_Kho>("A1", p_objData_Nhap_Kho, v_dicHeader_Field_Nhap_Kho, null, null);
            IJS.InvokeVoidAsync(
                "saveAsFile",
                "test.xlsx",
                Convert.ToBase64String(v_fileContents)
                );
        }
        //private void Import_Excel()
        //{
        //    string v_strfull_Path = Path.GetFullPath(p_strPath);
        //    FileInfo v_fileInfo = new FileInfo(p_strPath);
        //    string v_strName_File = v_fileInfo.Name;
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (ExcelPackage v_excelPackage = new ExcelPackage(v_fileInfo))
        //    {
        //        int v_inti = 1;
        //        ExcelWorksheet v_excelWorkSheet = v_excelPackage.Workbook.Worksheets[$"Sheet{v_inti}"];
        //        int v_inttotalRow = v_excelWorkSheet.Dimension.End.Row;
        //        int v_inttotalColumn = v_excelWorkSheet.Dimension.End.Column;
        //        List<string> v_arrcolumnNames = new List<string>();

        //        int v_intcurrentColumn = 2;

        //        DataTable v_dt = new DataTable();
        //        foreach (var cell in v_excelWorkSheet.Cells[1, 1, 1, v_excelWorkSheet.Dimension.End.Column])
        //        {
        //            string v_strColumnName = cell.Text.Trim();

        //            if (cell.Start.Column != v_intcurrentColumn)
        //            {
        //                v_arrcolumnNames.Add(v_strColumnName);
        //                v_dt.Columns.Add(v_strColumnName);
        //                v_intcurrentColumn++;
        //            }
        //            v_arrcolumnNames.Add(v_strColumnName);

        //            int v_intoccurrences = v_arrcolumnNames.Count(x => x.Equals(v_strColumnName));
        //            if (v_intoccurrences > 1)
        //                v_strColumnName = v_strColumnName + "_" + v_intoccurrences;
        //            v_dt.Columns.Add(v_strColumnName);
        //            v_intcurrentColumn++;
        //        }
        //        for (int i = 2; i <= v_excelWorkSheet.Dimension.End.Row; i++)
        //        {
        //            var row = v_excelWorkSheet.Cells[i, 1, i, v_excelWorkSheet.Dimension.End.Column];
        //            DataRow v_Row = v_dt.NewRow();

        //            foreach (var cell in row)
        //                v_Row[cell.Start.Column - 1] = cell.Text;
        //            v_dt.Rows.Add(v_Row);
        //        }
        //        for (int row = 2; row <= v_inttotalRow; row++)
        //        {
        //            CXNK_Nhap_Kho_Chi_Tiet v_objItem = new CXNK_Nhap_Kho_Chi_Tiet();
        //            for (int col = 1; col <= v_inttotalColumn; col++)
        //            {
        //                if (col == 1) v_objItem.San_Pham_ID = CUtility.Convert_To_Int32(v_excelWorkSheet.Cells[row, col].Value.ToString());
        //                if (col == 2) v_objItem.So_Luong = CUtility.Convert_To_Double(v_excelWorkSheet.Cells[row, col].Value.ToString());
        //                if (col == 3) v_objItem.Don_Gia = CUtility.Convert_To_Double(v_excelWorkSheet.Cells[row, col].Value.ToString());
        //            }
        //            Add_To_NKCT(p_objData_Nhap_Kho_Chi_Tiet, v_objItem);
        //        }
        //    }
        //    InvokeAsync(StateHasChanged);
        //    _Grid_Nhap_Kho_Chi_Tiet.Refresh();
        //}
        //private void OnInputFileChange(InputFileChangeEventArgs e)
        //{
        //    file = e.File;
        //    StateHasChanged();
        //}
        //private async void OnSubmit()
        //{
        //    try
        //    {
        //        Stream stream = file.OpenReadStream();
        //        string newFileName = $"{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}-{file.Name}";
        //        var path = $"{env.WebRootPath}\\FileManagement\\Upload\\{newFileName}";
        //        FileStream fs = File.Create(path);
        //        await stream.CopyToAsync(fs);
        //        await IJS.InvokeVoidAsync("alert", $"{file.Name} file(s) uploaded on server");
        //        stream.Close();
        //        fs.Close();
        //        this.StateHasChanged();

        //    }
        //    catch (Exception ex)
        //    {
        //        await IJS.InvokeVoidAsync("alert", $"Warning! {ex.Message}");
        //    }
        //}
        //private void ExportExcel()
        //{
        //    byte[] fileContents;
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var excel = new ExcelPackage())
        //    {
        //        var workSheet = excel.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.TabColor = System.Drawing.Color.Black;
        //        workSheet.DefaultRowHeight = 12;
        //        workSheet.Row(1).Height = 20;
        //        workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        //        workSheet.Row(1).Style.Font.Bold = true;
        //        workSheet.Cells[1, 1].Value = "Auto ID";
        //        workSheet.Cells[1, 2].Value = "Số Phiếu Nhập";

        //        int v_row = 2;
        //        foreach (CXNK_Nhap_Kho item in p_objData_Nhap_Kho)
        //        {
        //            workSheet.Cells[v_row, 1].Value = item.Auto_ID.ToString();
        //            workSheet.Cells[v_row, 2].Value = item.So_Phieu_Nhap.ToString();
        //            v_row++;
        //        }
        //        fileContents = excel.GetAsByteArray();
        //    }
        //    IJS.InvokeAsync<CXNK_Nhap_Kho>(
        //        "saveAsFile",
        //        "test.xlsx",
        //        Convert.ToBase64String(fileContents)
        //        );
        //}

        #endregion
    }
}
