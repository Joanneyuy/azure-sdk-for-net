// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Resource information. </summary>
    public partial class GenericResourceData : TrackedResource
    {
        /// <summary> Initializes a new instance of GenericResource. </summary>
        public GenericResourceData(Location location)
            : base(location)
        {
        }

        /// <summary> Initializes a new instance of GenericResource. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="plan"> The plan of the resource. </param>
        /// <param name="properties"> The resource properties. </param>
        /// <param name="kind"> The kind of the resource. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="createdTime"> The created time of the resource. This is only present if requested via the $expand query parameter. </param>
        /// <param name="changedTime"> The changed time of the resource. This is only present if requested via the $expand query parameter. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. This is only present if requested via the $expand query parameter. </param>
        internal GenericResourceData(ResourceIdentifier id, string name, string type, Location location, IDictionary<string, string> tags, Plan plan, object properties, string kind, string managedBy, Models.Sku sku, ResourceIdentity identity, DateTimeOffset? createdTime, DateTimeOffset? changedTime, string provisioningState) : base(id, name, type, tags, location)
        {
            Plan = plan;
            Properties = properties;
            Kind = kind;
            ManagedBy = managedBy;
            Sku = sku;
            Identity = identity;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            ProvisioningState = provisioningState;
        }

        /// <summary> The plan of the resource. </summary>
        public Plan Plan { get; set; }
        /// <summary> The resource properties. </summary>
        public object Properties { get; set; }
        /// <summary> The kind of the resource. </summary>
        public string Kind { get; set; }
        /// <summary> ID of the resource that manages this resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The SKU of the resource. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> The identity of the resource. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> The created time of the resource. This is only present if requested via the $expand query parameter. </summary>
        public DateTimeOffset? CreatedTime { get; }
        /// <summary> The changed time of the resource. This is only present if requested via the $expand query parameter. </summary>
        public DateTimeOffset? ChangedTime { get; }
        /// <summary> The provisioning state of the resource. This is only present if requested via the $expand query parameter. </summary>
        public string ProvisioningState { get; }
    }
}
