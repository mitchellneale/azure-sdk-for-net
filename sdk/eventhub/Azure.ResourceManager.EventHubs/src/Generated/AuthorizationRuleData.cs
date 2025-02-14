// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing the AuthorizationRule data model. </summary>
    public partial class AuthorizationRuleData : ProxyResource
    {
        /// <summary> Initializes a new instance of AuthorizationRuleData. </summary>
        public AuthorizationRuleData()
        {
            Rights = new ChangeTrackingList<AccessRights>();
        }

        /// <summary> Initializes a new instance of AuthorizationRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="systemData"> The system meta data relating to this resource. </param>
        /// <param name="rights"> The rights associated with the rule. </param>
        internal AuthorizationRuleData(ResourceIdentifier id, string name, ResourceType type, string location, SystemData systemData, IList<AccessRights> rights) : base(id, name, type, location)
        {
            SystemData = systemData;
            Rights = rights;
        }

        /// <summary> The system meta data relating to this resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> The rights associated with the rule. </summary>
        public IList<AccessRights> Rights { get; }
    }
}
