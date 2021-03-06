﻿using Learun.Application.TwoDevelopment.LR_CodeDemo;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.0 力软敏捷开发框架
    /// Copyright (c) 2013-2018 上海力软信息技术有限公司
    /// 创 建：阿路
    /// 日 期：2019-11-09 12:43
    /// 描 述：ZlTb
    /// </summary>
    public class F_ZlTbMap : EntityTypeConfiguration<F_ZlTbEntity>
    {
        public F_ZlTbMap()
        {
            #region 表、主键
            //表
            this.ToTable("F_ZLTB");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

