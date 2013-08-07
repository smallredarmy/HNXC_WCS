﻿using System;
using System.Collections.Generic;
using System.Text;
using THOK.Util;
using THOK.XC.Process.Dao;
using System.Data;
namespace THOK.XC.Process.Dal
{
    public class BillDal : BaseDal
    {

        /// <summary>
        /// 一楼，二楼空托盘组组盘入库，申请货位时，生成入库单,返回TaskID
        /// </summary>
        /// <param name="blnOne">true,一楼入库</param>
        /// <returns>TaskID</returns>
        public string CreatePalletInBillTask(bool blnOne)
        {
            BillDao dao = new BillDao();
            return dao.CreatePalletInBillTask(blnOne);
        }

         /// <summary>
        /// 空托盘组出库申请
        /// </summary>
        public string CreatePalletOutBillTask(string TARGET_CODE)
        {
            BillDao dao = new BillDao();
            return dao.CreatePalletOutBillTask(TARGET_CODE);
        }

        public void UpdateBillMasterFinished(string BillNo)
        {
            BillDao dao = new BillDao();
            dao.UpdateBillMasterFinished(BillNo);
        }
    }
}