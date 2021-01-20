//----------------------------------------------------------------------------------------------
// <copyright file="UserFeedback.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------------------------

namespace Icebreaker.Helpers
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a user
    /// </summary>
    public class UserFeedback : Document
    {
        /// <summary>
        /// Gets or sets the id of the feedback instance.
        /// This is also the <see cref="Resource.Id"/>.
        /// </summary>
        [JsonProperty("feedbackId")]
        public string FeedbackId
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        /// <summary>
        /// Gets or sets the tenant id
        /// </summary>
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the service URL
        /// </summary>
        [JsonProperty("serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets the id of the associated
        /// </summary>
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the text of the comment by the user
        /// </summary>
        [JsonProperty("feedbackText")]
        public string FeedbackText { get; set; }
    }
}