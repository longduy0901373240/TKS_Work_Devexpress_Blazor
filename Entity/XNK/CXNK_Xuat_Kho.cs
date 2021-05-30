using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.XNK
{
    public class CXNK_Xuat_Kho
    {
        private int m_intAuto_ID;
        private string m_strSo_Phieu_Xuat_Kho;
        private DateTime m_dtmNgay_Xuat_Kho;
        private string m_strGhi_Chu;
        private double m_dblTong_So_Luong;
        private double m_dblTong_Tri_Gia;
        private int m_intdeleted;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private int m_intKho_ID;
        public CXNK_Xuat_Kho()
        {
            ResetData();
        }
        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_strSo_Phieu_Xuat_Kho = CConst.STR_VALUE_NULL;
            m_dtmNgay_Xuat_Kho = CConst.DTM_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
            m_dblTong_So_Luong = CConst.DB_VALUE_NULL;
            m_dblTong_Tri_Gia = CConst.DB_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_intKho_ID = CConst.INT_VALUE_NULL;
        }

        public int Auto_ID
        {
            get
            {
                return m_intAuto_ID;
            }
            set
            {
                m_intAuto_ID = value;
            }
        }

        public string So_Phieu_Xuat_Kho
        {
            get
            {
                return m_strSo_Phieu_Xuat_Kho;
            }
            set
            {
                m_strSo_Phieu_Xuat_Kho = value.Trim();
            }
        }

        public DateTime Ngay_Xuat_Kho
        {
            get
            {
                return m_dtmNgay_Xuat_Kho;
            }
            set
            {
                m_dtmNgay_Xuat_Kho = value;
            }
        }

        public string Ghi_Chu
        {
            get
            {
                return m_strGhi_Chu;
            }
            set
            {
                m_strGhi_Chu = value.Trim();
            }
        }
        public double Tong_So_Luong
        {
            get
            {
                return m_dblTong_So_Luong;
            }
            set
            {
                m_dblTong_So_Luong = value;
            }
        }
        public double Tong_Tri_Gia
        {
            get
            {
                return m_dblTong_Tri_Gia;
            }
            set
            {
                m_dblTong_Tri_Gia = value;
            }
        }

        public int deleted
        {
            get
            {
                return m_intdeleted;
            }
            set
            {
                m_intdeleted = value;
            }
        }
        public DateTime Created
        {
            get
            {
                return m_dtmCreated;
            }
            set
            {
                m_dtmCreated = value;
            }
        }
        public string Created_By
        {
            get
            {
                return m_strCreated_By;
            }
            set
            {
                m_strCreated_By = value.Trim();
            }
        }
        public DateTime Last_Updated
        {
            get
            {
                return m_dtmLast_Updated;
            }
            set
            {
                m_dtmLast_Updated = value;
            }
        }
        public string Last_Updated_By
        {
            get
            {
                return m_strLast_Updated_By;
            }
            set
            {
                m_strLast_Updated_By = value.Trim();
            }
        }
        public int Kho_ID
        {
            get
            {
                return m_intKho_ID;
            }
            set
            {
                m_intKho_ID = value;
            }
        }
    }
}
