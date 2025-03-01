// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteConfigWeb along with the instance operations that can be performed on it. </summary>
    public partial class SiteConfigWeb : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteConfigWeb"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;
        private readonly SiteConfigAutoGeneratedData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigWeb"/> class for mocking. </summary>
        protected SiteConfigWeb()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteConfigWeb"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SiteConfigWeb(ArmResource options, SiteConfigAutoGeneratedData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigWeb"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteConfigWeb(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigWeb"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteConfigWeb(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteConfigAutoGeneratedData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_GetConfiguration
        /// <summary> Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteConfigWeb>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigWeb(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_GetConfiguration
        /// <summary> Description for Gets the configuration of an app, such as platform version and bitness, default documents, virtual applications, Always On, etc. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteConfigWeb> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigWeb(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_CreateOrUpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public async virtual Task<WebAppCreateOrUpdateConfigurationOperation> CreateOrUpdateAsync(SiteConfigAutoGeneratedData siteConfig, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken).ConfigureAwait(false);
                var operation = new WebAppCreateOrUpdateConfigurationOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_CreateOrUpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public virtual WebAppCreateOrUpdateConfigurationOperation CreateOrUpdate(SiteConfigAutoGeneratedData siteConfig, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken);
                var operation = new WebAppCreateOrUpdateConfigurationOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_UpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public async virtual Task<Response<SiteConfigWeb>> UpdateAsync(SiteConfigAutoGeneratedData siteConfig, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.Update");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.UpdateConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigWeb(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_UpdateConfiguration
        /// <summary> Description for Updates the configuration of an app. </summary>
        /// <param name="siteConfig"> JSON representation of a SiteConfig object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteConfig"/> is null. </exception>
        public virtual Response<SiteConfigWeb> Update(SiteConfigAutoGeneratedData siteConfig, CancellationToken cancellationToken = default)
        {
            if (siteConfig == null)
            {
                throw new ArgumentNullException(nameof(siteConfig));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.Update");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.UpdateConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteConfig, cancellationToken);
                return Response.FromValue(new SiteConfigWeb(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_ListConfigurationSnapshotInfo
        /// <summary> Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteConfigurationSnapshotInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteConfigurationSnapshotInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListConfigurationSnapshotInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteConfigurationSnapshotInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListConfigurationSnapshotInfoNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web
        /// OperationId: WebApps_ListConfigurationSnapshotInfo
        /// <summary> Description for Gets a list of web app configuration snapshots identifiers. Each element of the list contains a timestamp and the ID of the snapshot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteConfigurationSnapshotInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfo(CancellationToken cancellationToken = default)
        {
            Page<SiteConfigurationSnapshotInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListConfigurationSnapshotInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteConfigurationSnapshotInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigWeb.GetConfigurationSnapshotInfo");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListConfigurationSnapshotInfoNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        #region SiteConfigSnapshot

        /// <summary> Gets a collection of SiteConfigSnapshots in the SiteConfigWeb. </summary>
        /// <returns> An object representing collection of SiteConfigSnapshots and their operations over a SiteConfigWeb. </returns>
        public SiteConfigSnapshotCollection GetSiteConfigSnapshots()
        {
            return new SiteConfigSnapshotCollection(this);
        }
        #endregion
    }
}
