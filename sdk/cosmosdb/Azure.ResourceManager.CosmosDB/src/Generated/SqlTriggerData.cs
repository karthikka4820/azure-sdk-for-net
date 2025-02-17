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
    /// <summary> A class representing the SqlTrigger data model. </summary>
    public partial class SqlTriggerData : TrackedResource
    {
        /// <summary> Initializes a new instance of SqlTriggerData. </summary>
        /// <param name="location"> The location. </param>
        public SqlTriggerData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SqlTriggerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"></param>
        internal SqlTriggerData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, SqlTriggerPropertiesResource resource) : base(id, name, type, tags, location)
        {
            Resource = resource;
        }

        /// <summary> Gets or sets the resource. </summary>
        public SqlTriggerPropertiesResource Resource { get; set; }
    }
}
