// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.AzureAppService_ApiService>("api");

if (builder.ExecutionContext.IsPublishMode)
{
#pragma warning disable AZPROVISION001
    api.PublishAsAppService();
#pragma warning restore AZPROVISION001
}

builder.Build().Run();
