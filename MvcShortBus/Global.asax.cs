using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Core;
using MvcShortBus.Models;

namespace MvcShortBus
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			AutoMapperConfig.Register();
		}
	}

	public class AutoMapperConfig
	{
		public static void Register()
		{
			Mapper.CreateMap<Contact, ContactItem>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ContactId));
			Mapper.CreateMap<HomeAddModel, Contact>()
				.ForMember(dest => dest.Skills, opt => opt.Ignore())
				.ForMember(dest => dest.Active, opt => opt.Ignore())
				.ForMember(dest => dest.ContactId, opt => opt.Ignore());
			Mapper.AssertConfigurationIsValid();
		}
	}
}