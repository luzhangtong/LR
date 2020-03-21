using Learun.Util;
using System.Data;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.LR_Principle
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.0 力软敏捷开发框架
    /// Copyright (c) 2013-2018 上海力软信息技术有限公司
    /// 创 建：阿路
    /// 日 期：2019-12-16 01:10
    /// 描 述：原则管理
    /// </summary>
    public interface PrincipleIBLL
    {
        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<PrincipleEntity> GetPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取Principle表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        PrincipleEntity GetPrincipleEntity(string keyValue);
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
        void SaveEntity(string keyValue, PrincipleEntity entity);
        #endregion

    }
}
