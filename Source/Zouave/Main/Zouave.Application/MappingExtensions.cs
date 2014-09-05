using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Zouave.Concept;

using Zouave.Dto.Configuration;
using Zouave.Domain.Configuration;
namespace Zouave.Application
{
    /// <summary>
    /// Dto和Domain类型的相互转换
    /// 备注：添加一个Dto要加入相应的映射
    /// </summary>
    public static class MappingExtensions
    {
        #region Setting
        public static Setting ToEntity(this SettingDto dto)
        {
            return Mapper.Map<SettingDto, Setting>(dto);
        }
        public static Setting ToEntity<TDto, TEntity>(this SettingDto dto, Setting entity)
        {
            return Mapper.Map<SettingDto, Setting>(dto, entity);
        }

        public static SettingDto ToDto(this Setting entity)
        {
            return Mapper.Map<Setting, SettingDto>(entity);
        }
        public static SettingDto ToDto(this Setting entity, SettingDto dto)
        {
            return Mapper.Map<Setting, SettingDto>(entity, dto);
        }
        #endregion

    }
}
