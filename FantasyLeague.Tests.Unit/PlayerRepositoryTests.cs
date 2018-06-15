//using FantasyLeague.Data;
//using System;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Builder.Internal;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Moq;
//using Xunit;

//namespace FantasyLeague.Tests.Unit
//{
//    public class PlayerRepositoryTests
//    {
//        [Fact]
//        public void GetAll_AllPlayersReturned()
//        {
//            var services = new ServiceCollection();
//            var appBuilder = new Mock<IApplicationBuilder>();
//            var hostingEnvironment = new Mock<IHostingEnvironment>();
//            var configuration = new Mock<IConfiguration>();
//            var target = new Startup(configuration.Object);
//            target.ConfigureServices(services);
//            target.Configure(appBuilder.Object, hostingEnvironment.Object);

//            var playerRepository = new PlayerRepository();
//        }
//    }
//}
