using Learun.Util;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learun.Application.TwoDevelopment.LR_Principle
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.0 力软敏捷开发框架
    /// Copyright (c) 2013-2018 上海力软信息技术有限公司
    /// 创 建：阿路
    /// 日 期：2019-12-16 01:10
    /// 描 述：原则管理
    /// </summary>
    public class PrincipleEntity 
    {
        #region 实体成员
        /// <summary>
        /// 主键
        /// </summary>
        [Column("F_ID")]
        public string F_Id { get; set; }
        /// <summary>
        /// 原则名称
        /// </summary>
        [Column("F_PRINCIPLENAME")]
        public string F_PrincipleName { get; set; }
        /// <summary>
        /// 原则内容
        /// </summary>
        [Column("F_PRINCIPLECONTENT")]
        public string F_PrincipleContent { get; set; }
        /// <summary>
        /// 原则分类
        /// </summary>
        [Column("F_PRINCIPLECLASSIFICATION")]
        public string F_PrincipleClassification { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("F_CREATEDATE")]
        public DateTime? F_CreateDate { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public void Create()
        {
            this.F_Id = Guid.NewGuid().ToString();
            this.F_CreateDate = DateTime.Now;
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public void Modify(string keyValue)
        {
            this.F_Id = keyValue;
        }
        #endregion
        #region 扩展字段
        #endregion
    }
}

