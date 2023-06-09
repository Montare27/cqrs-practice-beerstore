namespace Application.Tests.Common
{
    using Application.Common;
    using AutoMapper;
    using Infrastructure;
    using Interfaces;

    public abstract class TestBase : IDisposable
    {
        protected readonly BeerDbContext Context;

        protected readonly IMapper Mapper;

        public TestBase()
        {
            Context = BeerContextFactory.Create();
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile(new AssemblyProfile(typeof(IBeerDbContext).Assembly)));
            Mapper = config.CreateMapper();
        }
        
        public void Dispose()
        {
            BeerContextFactory.Destroy(Context);
        }
    }
}
