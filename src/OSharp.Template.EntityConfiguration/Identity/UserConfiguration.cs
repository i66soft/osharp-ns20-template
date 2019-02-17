﻿// -----------------------------------------------------------------------
//  <copyright file="UserConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:48</last-date>
// -----------------------------------------------------------------------

using OSharp.Template.Identity.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using OSharp.Entity;


namespace OSharp.Template.EntityConfiguration.Identity
{
    public class UserConfiguration : EntityTypeConfigurationBase<User, int>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(m => m.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(m => m.NormalizeEmail).HasName("EmailIndex");

            builder.Property(m => m.ConcurrencyStamp).IsConcurrencyToken();
        }
    }
}