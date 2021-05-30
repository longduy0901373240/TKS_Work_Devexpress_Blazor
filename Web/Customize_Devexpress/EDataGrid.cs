using DevExpress.Blazor.Internal;
using DevExpress.Blazor.Internal.Grid;
using DevExpress.XtraReports.UI;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customize_Devexpress
{
    public class EDataGrid<T>: DevExpress.Blazor.DxDataGrid<T>
    {
        private readonly string pdf = "pdf";
        private readonly string xlsx = "xlsx";
        private readonly string docx = "docx";
        private readonly string csv = "csv";
        public string GetCss()
        {
            return this.CssClass;
        }

        public string[] GetFields
        {
            get
            {
                List<IDataColumnModel> li = new List<IDataColumnModel>(GetColumns);
                return li.Select(d => d.FieldName.GetValueOrDefault()).ToArray();
            }
        }

        public string[] GetCaptions
        {
            get
            {
                List<IDataColumnModel> li = new List<IDataColumnModel>(GetColumns);
                return li.Select(d => (d.Caption.GetValueOrDefault().Length == 0) ? d.FieldName.GetValueOrDefault() : d.Caption.GetValueOrDefault()).ToArray();
            }
        }

        public DefaultDataGridDataContainer<T> GetDataGridDataContainer
        {
            get
            {
                return (DefaultDataGridDataContainer<T>)this.DataContainer;
            }
        }

        public IDataColumnModel[] GetColumns
        {
            get
            {
                return this.GetDataGridDataContainer.ColumnService.AllDataColumns.GetValueOrDefault();
            }
        }

        public IDataGridFilterService GetFilterService
        {
            get
            {

                return this.FilterService;
            }
        }

        public IEnumerable<T> GetDataContainer
        {
            get
            {
                return this.DataContainer.Data.GetValueOrDefault();
            }
        }

        public async Task Export(string format, string fileName = "export")
        {
            XtraReport report = new XtraReport();
            report.DataSource = this.GetDataContainer;
            CreateReport(report);
            report.CreateDocument();

            using (MemoryStream fs = new MemoryStream())
            {
                if (format == xlsx)
                {
                    await report.ExportToXlsxAsync(fs);
                }
                else if (format == docx)
                {
                    await report.ExportToDocxAsync(fs);
                }
                else if (format == pdf)
                {
                    await report.ExportToPdfAsync(fs);
                }
                else if (format == csv)
                {
                    await report.ExportToCsvAsync(fs);
                }
                string base64String = Convert.ToBase64String(fs.ToArray(), 0, fs.ToArray().Length);
                await this.JsRuntime.InvokeAsync<object>("downloadFile", base64String, "application/" + format, fileName + "." + format);
            }

            report.Dispose();
        }

        void CreateReport(XtraReport report)
        {
            PageHeaderBand pageHeader = new PageHeaderBand() { HeightF = 23, Name = "pageHeaderBand" };
            int tableWidth = report.PageWidth - report.Margins.Left - report.Margins.Right;
            XRTable headerTable = XRTable.CreateTable(
                                new Rectangle(0,    // rect X
                                                0,          // rect Y
                                                tableWidth, // width
                                                40),        // height
                                                1,          // table row count
                                                0);         // table column count
            headerTable.Borders = DevExpress.XtraPrinting.BorderSide.All;
            headerTable.BackColor = Color.Gainsboro;
            headerTable.Font = new Font("Verdana", 10, FontStyle.Bold);
            headerTable.Rows.FirstRow.Width = tableWidth;
            headerTable.BeginInit();
            foreach (string field in GetCaptions)
            {
                XRTableCell cell = new XRTableCell();
                cell.Width = 100;
                cell.Text = field;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                headerTable.Rows.FirstRow.Cells.Add(cell);
            }
            headerTable.EndInit();
            headerTable.AdjustSize();
            pageHeader.Controls.Add(headerTable);



            DetailBand detail = new DetailBand() { HeightF = 23, Name = "detailBand" };
            XRTable detailTable = XRTable.CreateTable(
                            new Rectangle(0,    // rect X
                                            0,          // rect Y
                                            tableWidth, // width
                                            40),        // height
                                            1,          // table row count
                                            0);         // table column count



            detailTable.Width = tableWidth;
            detailTable.Rows.FirstRow.Width = tableWidth;
            detailTable.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            detailTable.BeginInit();
            foreach (string field in GetFields)
            {
                XRTableCell cell = new XRTableCell();
                ExpressionBinding binding = new ExpressionBinding("BeforePrint", "Text", String.Format("[{0}]", field));
                cell.ExpressionBindings.Add(binding);
                cell.Width = 100;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                if (field.Contains("Date"))
                    cell.TextFormatString = "{0:MM/dd/yyyy}";
                detailTable.Rows.FirstRow.Cells.Add(cell);
            }
            detailTable.Font = new Font("Verdana", 8F);
            detailTable.EndInit();
            detailTable.AdjustSize();
            detail.Controls.Add(detailTable);
            report.Bands.AddRange(new Band[] { detail, pageHeader });
        }
    }
}
