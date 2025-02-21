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
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableStreamAnalyticsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStreamAnalyticsResourceGroupResource"/> class for mocking. </summary>
        protected MockableStreamAnalyticsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStreamAnalyticsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStreamAnalyticsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of StreamingJobResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StreamingJobResources and their operations over a StreamingJobResource. </returns>
        public virtual StreamingJobCollection GetStreamingJobs()
        {
            return GetCachedClient(client => new StreamingJobCollection(client, Id));
        }

        /// <summary>
        /// Gets details about the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StreamingJobResource>> GetStreamingJobAsync(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetStreamingJobs().GetAsync(jobName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details about the specified streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StreamingJobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The name of the streaming job. </param>
        /// <param name="expand"> The $expand OData query parameter. This is a comma-separated list of additional streaming job properties to include in the response, beyond the default set returned when this parameter is absent. The default set is all streaming job properties other than 'inputs', 'transformation', 'outputs', and 'functions'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StreamingJobResource> GetStreamingJob(string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetStreamingJobs().Get(jobName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of StreamAnalyticsClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StreamAnalyticsClusterResources and their operations over a StreamAnalyticsClusterResource. </returns>
        public virtual StreamAnalyticsClusterCollection GetStreamAnalyticsClusters()
        {
            return GetCachedClient(client => new StreamAnalyticsClusterCollection(client, Id));
        }

        /// <summary>
        /// Gets information about the specified cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamAnalyticsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StreamAnalyticsClusterResource>> GetStreamAnalyticsClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetStreamAnalyticsClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamAnalyticsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StreamAnalyticsClusterResource> GetStreamAnalyticsCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetStreamAnalyticsClusters().Get(clusterName, cancellationToken);
        }
    }
}
