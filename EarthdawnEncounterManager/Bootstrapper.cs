using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EarthdawnEncounterManager.Data;
using EarthdawnEncounterManager.Data.Contracts;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.WebApi;

namespace EarthdawnEncounterManager.Web
{
    public static class Bootstrapper
    {
        /// <summary>
        /// Instantiates and loads a <see cref="UnityContainer"/>
        /// </summary>
        /// <returns>An initialized instance of <see cref="UnityContainer"/></returns>
        public static IUnityContainer Initialize()
        {
            var container = BuildUnityContainer();

            GlobalConfiguration.Configuration.DependencyResolver = new Microsoft.Practices.Unity.WebApi.UnityDependencyResolver(container);

            return container;
        }

        /// <summary>
        /// Registers the scaffolding‎ of linked types
        /// </summary>
        /// <param name="container">An initialized instance of <see cref="UnityContainer"/></param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Necessary for IoC registration")]
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IEarthdawnSessionRepository, EarthdawnSessionRepository>();
            container.RegisterType<ICampaignRepository, CampaignRepository>();
            container.RegisterType<IPlayerRepository, PlayerRepository>();
            container.RegisterType<IEnemyRepository, EnemyRepository>();
            //UnityConfigurationSection section = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
            //section.Configure(container);
        }

        /// <summary>
        /// Creates an instance of a unity container containing all registered types
        /// </summary>
        /// <returns>An initialized instance of <see cref="UnityContainer"/></returns>
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }
    }
}