// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridConnectivity.Mocking;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HybridConnectivity. </summary>
    public static partial class HybridConnectivityExtensions
    {
        private static MockableHybridConnectivityArmClient GetMockableHybridConnectivityArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHybridConnectivityArmClient(client0));
        }

        /// <summary>
        /// Gets a collection of EndpointResources in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridConnectivityArmClient.GetEndpointResources(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> An object representing collection of EndpointResources and their operations over a EndpointResource. </returns>
        public static EndpointResourceCollection GetEndpointResources(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridConnectivityArmClient(client).GetEndpointResources(scope);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridConnectivityArmClient.GetEndpointResourceAsync(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EndpointResource>> GetEndpointResourceAsync(this ArmClient client, ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return await GetMockableHybridConnectivityArmClient(client).GetEndpointResourceAsync(scope, endpointName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridConnectivityArmClient.GetEndpointResource(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="endpointName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<EndpointResource> GetEndpointResource(this ArmClient client, ResourceIdentifier scope, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridConnectivityArmClient(client).GetEndpointResource(scope, endpointName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EndpointResource.CreateResourceIdentifier" /> to create an <see cref="EndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridConnectivityArmClient.GetEndpointResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="EndpointResource"/> object. </returns>
        public static EndpointResource GetEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridConnectivityArmClient(client).GetEndpointResource(id);
        }
    }
}
