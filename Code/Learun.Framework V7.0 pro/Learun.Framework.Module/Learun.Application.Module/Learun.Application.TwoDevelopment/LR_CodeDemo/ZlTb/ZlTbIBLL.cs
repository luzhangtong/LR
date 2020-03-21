using Learun.Util;
using System.Data;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.LR_CodeDemo
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.0 力软敏捷开发框架
    /// Copyright (c) 2013-2018 上海力软信息技术有限公司
    /// 创 建：阿路
    /// 日 期：2019-11-09 12:43
    /// 描 述：ZlTb
    /// </summary>
    public interface ZlTbIBLL
    {
        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<F_ZlTbEntity> GetPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取F_ZlTb表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        F_ZlTbEntity GetF_ZlTbEntity(string keyValue);
        #endregion

        #region 提交数据

        /// <summary>
        /// 删除实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void SaveEntity(string keyValue, F_ZlTbEntity entity);
        #endregion

    }
}
