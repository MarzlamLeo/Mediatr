using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;
using WebApplication1.ReposeDto.ReadReposeDto;

namespace WebApplication1.AutoMapper
{
    public class ResolverAge: IValueResolver<TestEntity, GetTestResposeDto, int>
    {
        public int Resolve(TestEntity source, GetTestResposeDto destination, int member, ResolutionContext context)
        {
            return source.Age + 1;
        }
    }
    public class ResolverName : IValueResolver<TestEntity, GetTestResposeDto, string>
    {
        public string Resolve(TestEntity source, GetTestResposeDto destination, string member, ResolutionContext context)
        {
            return source.Name + "是我的名字";
        }
    }
}
