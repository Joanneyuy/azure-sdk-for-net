// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of WebApplicationFirewallPolicy and their operations over its parent. </summary>
    public partial class WebApplicationFirewallPolicyCollection : ArmCollection, IEnumerable<WebApplicationFirewallPolicy>, IAsyncEnumerable<WebApplicationFirewallPolicy>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebApplicationFirewallPoliciesRestOperations _webApplicationFirewallPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebApplicationFirewallPolicyCollection"/> class for mocking. </summary>
        protected WebApplicationFirewallPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of WebApplicationFirewallPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WebApplicationFirewallPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webApplicationFirewallPoliciesRestClient = new WebApplicationFirewallPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or update policy with specified rule set name within a resource group. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="parameters"> Policy to be created. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WebApplicationFirewallPolicyCreateOrUpdateOperation CreateOrUpdate(string policyName, WebApplicationFirewallPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, policyName, parameters, cancellationToken);
                var operation = new WebApplicationFirewallPolicyCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates or update policy with specified rule set name within a resource group. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="parameters"> Policy to be created. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WebApplicationFirewallPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(string policyName, WebApplicationFirewallPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebApplicationFirewallPolicyCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Retrieve protection policy with specified name within a resource group. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<WebApplicationFirewallPolicy> Get(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve protection policy with specified name within a resource group. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public async virtual Task<Response<WebApplicationFirewallPolicy>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WebApplicationFirewallPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<WebApplicationFirewallPolicy> GetIfExists(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<WebApplicationFirewallPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new WebApplicationFirewallPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public async virtual Task<Response<WebApplicationFirewallPolicy>> GetIfExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<WebApplicationFirewallPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new WebApplicationFirewallPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            if (policyName == null)
            {
                throw new ArgumentNullException(nameof(policyName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the protection policies within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebApplicationFirewallPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebApplicationFirewallPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WebApplicationFirewallPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webApplicationFirewallPoliciesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WebApplicationFirewallPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webApplicationFirewallPoliciesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the protection policies within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebApplicationFirewallPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebApplicationFirewallPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WebApplicationFirewallPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webApplicationFirewallPoliciesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WebApplicationFirewallPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webApplicationFirewallPoliciesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="WebApplicationFirewallPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WebApplicationFirewallPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="WebApplicationFirewallPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WebApplicationFirewallPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebApplicationFirewallPolicy> IEnumerable<WebApplicationFirewallPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebApplicationFirewallPolicy> IAsyncEnumerable<WebApplicationFirewallPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, WebApplicationFirewallPolicy, WebApplicationFirewallPolicyData> Construct() { }
    }
}
