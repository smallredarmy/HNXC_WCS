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
        /// 二楼退库单据，产生任务，任务明细,更新货位错误标志， 返回任务ID。
        /// </summary>
        ///  
        /// <returns>TaskID</returns>
        public string  CreateCancelBillInTask(string TaskID,string BillNo,string NewPalletCode)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                string strTaskID = dao.CreateCancelBillInTask(TaskID, BillNo);

                TaskDao tdao = new TaskDao();
                tdao.InsertTaskDetail(strTaskID);
                tdao.UpdateTaskState(strTaskID, "1");//更新任务开始执行
                return strTaskID;
            }
        }

        /// <summary>
        /// 根据 错误烟包 查找相同入库单据信息，供用户选择入库单号。
        /// </summary>
        /// <returns></returns>
        public DataTable GetCancelBillNo(string TaskID)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();

                return dao.GetCancelBillNo(TaskID);
            }
 
        }

         /// <summary>
        /// 二楼出库托盘校验出错，由用户选定出库的入库单号OutBillNO， 补充生成 出库单。
        /// </summary>
        /// <returns>TaskID</returns>
        public string CreateCancelBillOutTask(string TaskID, string BillNo, string OutBillNO, string OLD_PALLET_CODE)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                string strTaskID = dao.CreateCancelBillOutTask(TaskID, BillNo, OutBillNO, OLD_PALLET_CODE);
                return strTaskID;
            }
        }

         /// <summary>
        /// 空托盘组出库申请
        /// </summary>
        public string CreatePalletOutBillTask(string TARGET_CODE)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                return dao.CreatePalletOutBillTask(TARGET_CODE);
            }
        }

        public void UpdateBillMasterFinished(string BillNo,string IsBill)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                dao.UpdateBillMasterFinished(BillNo,IsBill);
            }
        }

        public DataTable GetBillByType(string BillType)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
               return dao.GetBillByType(BillType);
            }
        }

        public DataTable GetCigarette()
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                return dao.GetCigarette();
            }
        }

        public DataTable GetFormula()
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                return dao.GetFormula();
            }
        }

        public DataTable GetBillInTask(string filter)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                return dao.GetBillInTask(filter);
            }
        }
        public DataTable GetBillOutTask(string filter)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                return dao.GetBillOutTask(filter);
            }
        }
        public DataTable GetBillTaskDetail(string TaskID)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                BillDao dao = new BillDao();
                return dao.GetBillTaskDetail(TaskID);
            }
        }
    }
}