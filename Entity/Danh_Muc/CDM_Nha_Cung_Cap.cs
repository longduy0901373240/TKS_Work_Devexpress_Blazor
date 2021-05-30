﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.Danh_Muc
{
    public class CDM_Nha_Cung_Cap
    {
        private int m_intAuto_ID;
        private string m_strTen_Nha_Cung_Cap;
        private string m_strDia_Chi;
        private string m_strDien_Thoai;
        private int m_intdeleted;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        public CDM_Nha_Cung_Cap()
        {
            ResetData();
        }
        public void ResetData()
        {
            m_intAuto_ID = CConst.INT_VALUE_NULL;
            m_strTen_Nha_Cung_Cap = CConst.STR_VALUE_NULL;
            m_strDia_Chi = CConst.STR_VALUE_NULL;
            m_strDien_Thoai = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_ALL;
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
        public string Ten_Nha_Cung_Cap
        {
            get
            {
                return m_strTen_Nha_Cung_Cap;
            }
            set
            {
                m_strTen_Nha_Cung_Cap = value.Trim();
            }
        }
        public string Dia_Chi
        {
            get
            {
                return m_strDia_Chi;
            }
            set
            {
                m_strDia_Chi = value.Trim();
            }
        }
        public string Dien_Thoai
        {
            get
            {
                return m_strDien_Thoai;
            }
            set
            {
                m_strDien_Thoai = value.Trim();
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
