// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing the MongoDBDatabase data model. </summary>
    public partial class MongoDBDatabaseData : TrackedResource
    {
        /// <summary> Initializes a new instance of MongoDBDatabaseData. </summary>
        /// <param name="location"> The location. </param>
        public MongoDBDatabaseData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of MongoDBDatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"></param>
        /// <param name="options"></param>
        internal MongoDBDatabaseData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, MongoDBDatabasePropertiesResource resource, MongoDBDatabasePropertiesOptions options) : base(id, name, type, tags, location)
        {
            Resource = resource;
            Options = options;
        }

        /// <summary> Gets or sets the resource. </summary>
        public MongoDBDatabasePropertiesResource Resource { get; set; }
        /// <summary> Gets or sets the options. </summary>
        public MongoDBDatabasePropertiesOptions Options { get; set; }
    }
}
