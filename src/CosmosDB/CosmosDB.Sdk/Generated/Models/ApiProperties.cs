// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    public partial class ApiProperties
    {
        /// <summary>
        /// Initializes a new instance of the ApiProperties class.
        /// </summary>
        public ApiProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiProperties class.
        /// </summary>

        /// <param name="serverVersion">Describes the ServerVersion of an a MongoDB account.
        /// Possible values include: '3.2', '3.6', '4.0', '4.2'</param>
        public ApiProperties(string serverVersion = default(string))

        {
            this.ServerVersion = serverVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets describes the ServerVersion of an a MongoDB account. Possible values include: &#39;3.2&#39;, &#39;3.6&#39;, &#39;4.0&#39;, &#39;4.2&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serverVersion")]
        public string ServerVersion {get; set; }
    }
}