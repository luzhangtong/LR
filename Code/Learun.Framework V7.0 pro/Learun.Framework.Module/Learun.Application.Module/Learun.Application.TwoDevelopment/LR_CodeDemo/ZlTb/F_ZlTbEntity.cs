using Learun.Util;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learun.Application.TwoDevelopment.LR_CodeDemo
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.0 力软敏捷开发框架
    /// Copyright (c) 2013-2018 上海力软信息技术有限公司
    /// 创 建：阿路
    /// 日 期：2019-11-09 12:43
    /// 描 述：ZlTb
    /// </summary>
    public class F_ZlTbEntity 
    {
        #region 实体成员
        /// <summary>
        /// F_Id
        /// </summary>
        [Column("F_ID")]
        public string F_Id { get; set; }
        /// <summary>
        /// F_ZlName
        /// </summary>
        [Column("F_ZLNAME")]
        public string F_ZlName { get; set; }
        /// <summary>
        /// F_ZlType
        /// </summary>
        [Column("F_ZLTYPE")]
        public string F_ZlType { get; set; }
        /// <summary>
        /// F_ZlLink
        /// </summary>
        [Column("F_ZLLINK")]
        public string F_ZlLink { get; set; }
        /// <summary>
        /// F_ZlImg
        /// </summary>
        [Column("F_ZLIMG")]
        public string F_ZlImg { get; set; }
        /// <summary>
        /// F_ZlShow
        /// </summary>
        [Column("F_ZLSHOW")]
        public string F_ZlShow { get; set; }
        /// <summary>
        /// F_ZlJK
        /// </summary>
        [Column("F_ZLJK")]
        public string F_ZlJK { get; set; }
        /// <summary>
        /// F_ZlLuoLan
        /// </summary>
        [Column("F_ZLLUOLAN")]
        public string F_ZlLuoLan { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public void Create()
        {
            this.F_Id = Guid.NewGuid().ToString();
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

