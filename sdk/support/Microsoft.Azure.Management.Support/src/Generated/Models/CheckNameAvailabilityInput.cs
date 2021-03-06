// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input of CheckNameAvailability API.
    /// </summary>
    public partial class CheckNameAvailabilityInput
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        public CheckNameAvailabilityInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        /// <param name="name">The resource name to validate</param>
        /// <param name="type">The type of resource. Possible values include:
        /// 'Microsoft.Support/supportTickets',
        /// 'Microsoft.Support/communications'</param>
        public CheckNameAvailabilityInput(string name, Type type)
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource name to validate
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of resource. Possible values include:
        /// 'Microsoft.Support/supportTickets',
        /// 'Microsoft.Support/communications'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public Type Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
