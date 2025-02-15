﻿using DAL;
using DTO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace BLL
{
    public class DonHangBLL
    {
        private DonHangDAL _dal;
        public DonHangBLL()
        {
            _dal = new DonHangDAL();
        }
        public string Update(DONHANGDataTable dh)
        {
            if (dh == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Update(dh);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Create(EditDTO.DonHang dh, EditDTO.ChiTietDonHang[] dhs)
        {

            if (dh == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Create(dh, dhs);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Delete(string id)
        {
            try
            {
                _dal.Delete(id);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public IEnumerable<ResponseDTO.DonHang> GetAll()
        {

            return _dal.GetAll();
        }
    }
}
