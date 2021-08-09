using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;
using WebApplication1.ReposeDto.ReadReposeDto;

namespace WebApplication1.AutoMapper
{
    //自动映射配置规则 
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<源，目标>   将名字补充映射 年龄也加1
            CreateMap<TestEntity, GetTestResposeDto>()
                .ForMember(destination => destination.Age, source => source.MapFrom<ResolverAge>())
                .ForMember(destination => destination.Name, source => source.MapFrom<ResolverName>());
            //.ForMember(destination => destination.Name, source => source.MapFrom(i => i.Name+"是我的名字"))
            //.ForMember(destination => destination.Age, source => source.MapFrom(i => i.Age +1));

            //源 和 目标 的 命名约定
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();

        }
    }
}
