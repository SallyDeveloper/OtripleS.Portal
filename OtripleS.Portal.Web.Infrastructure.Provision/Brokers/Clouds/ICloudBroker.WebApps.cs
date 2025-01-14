﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.Azure.Management.AppService.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;

namespace OtripleS.Portal.Web.Infrastructure.Provision.Brokers.Clouds
{
	public partial interface ICloudBroker
	{
		ValueTask<IWebApp> CreateWebAppAsync(
			string webAppName,
			IAppServicePlan plan,
			IResourceGroup resourceGroup);
	}
}