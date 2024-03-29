﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Util.ApplicationServices
{
    /// <summary>
    /// 应用服务
    /// </summary>
    /// <typeparam name="TDto">数据传输对象类型</typeparam>
    public interface IApiServiceBase<TDto> : IDependency where TDto : new()
    {
        /// <summary>
        /// 创建实体
        /// </summary>
        TDto Create();
        /// <summary>
        /// 通过编号获取
        /// </summary>
        /// <param name="id">实体编号</param>
        TDto Get(object id);
        /// <summary>
        /// 通过编号集合获取列表
        /// </summary>
        /// <param name="ids">Id集合字符串，多个Id用逗号分隔</param>
        List<TDto> GetByIds(string ids);
        /// <summary>
        /// 获取全部列表
        /// </summary>
        List<TDto> GetAll();
       
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        void Save(TDto dto);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids">Id集合字符串，多个Id用逗号分隔</param>
        void Delete(string ids);
    }
}
