using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.Danh_Muc
{
    public class CDM_Phan_Quyen_Kho_User
    {
        private int m_intAuto_ID;
        private int m_intKho_ID;
        private string m_strMa_Dang_Nhap;
        private int m_intdeleted;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;

        public CDM_Phan_Quyen_Kho_User()
        {
            ResetData();
        }
        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_intKho_ID = CConst.INT_VALUE_NULL;
            m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
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

        public string Ma_Dang_Nhap
        {
            get
            {
                return m_strMa_Dang_Nhap;
            }
            set
            {
                m_strMa_Dang_Nhap = value.Trim();
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
    }
}
