using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.XNK
{
    public class CXNK_Xuat_Kho_Chi_Tiet
    {
        private int m_intAuto_ID;
        private int m_intXuat_Kho_ID;
        private string m_intSession_ID;
        private int m_intSan_Pham_ID;
        private double m_dblSo_Luong;
        private double m_dblDon_Gia;
        private int m_intdeleted;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strMa_San_Pham;
        private string m_strTen_San_Pham;

        public CXNK_Xuat_Kho_Chi_Tiet()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_intXuat_Kho_ID = CConst.INT_VALUE_NULL;
            m_intSession_ID = CConst.STR_VALUE_NULL;
            m_intSan_Pham_ID = CConst.INT_VALUE_NULL;
            m_dblSo_Luong = CConst.DB_VALUE_NULL;
            m_dblDon_Gia = CConst.DB_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strMa_San_Pham = CConst.STR_VALUE_NULL;
            m_strTen_San_Pham = CConst.STR_VALUE_NULL;
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
        public int Xuat_Kho_ID
        {
            get
            {
                return m_intXuat_Kho_ID;
            }
            set
            {
                m_intXuat_Kho_ID = value;
            }
        }
        public string Session_ID
        {
            get
            {
                return m_intSession_ID;
            }
            set
            {
                m_intSession_ID = value.Trim();
            }
        }
        public int San_Pham_ID
        {
            get
            {
                return m_intSan_Pham_ID;
            }
            set
            {
                m_intSan_Pham_ID = value;
            }
        }
        public double So_Luong
        {
            get
            {
                return m_dblSo_Luong;
            }
            set
            {
                m_dblSo_Luong = value;
            }
        }
        public double Don_Gia
        {
            get
            {
                return m_dblDon_Gia;
            }
            set
            {
                m_dblDon_Gia = value;
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
        public string Ma_San_Pham
        {
            get
            {
                return m_strMa_San_Pham;
            }
            set
            {
                m_strMa_San_Pham = value.Trim();
            }
        }
        public string Ten_San_Pham
        {
            get
            {
                return m_strTen_San_Pham;
            }
            set
            {
                m_strTen_San_Pham = value.Trim();
            }
        }
        public string Thong_Tin_San_Pham
        {
            get
            {
                return Ma_San_Pham + " - " + Ten_San_Pham;
            }
            set
            {
            }
        }
        public double Tri_Gia
        {
            get { return Don_Gia * So_Luong; }
            set { }
        }
    }
}
