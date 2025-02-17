﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Configurations that allow callers to specify details about how to execute
    /// a Single Category Classification action on a set of documents. This corresponds
    /// to a Single Category Classification task in the Text Analytics service.
    /// For example, the target project and deployment names are required
    /// for a successful custom classification action.
    /// </summary>
    public class SingleCategoryClassifyAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCategoryClassifyAction"/>
        /// class which allows callers to specify details about how to execute
        /// a Single Category Classification action on a set of documents.
        /// Sets the <see cref="ProjectName"/> and <see cref="DeploymentName"/> properties.
        /// </summary>
        /// <param name = "projectName">The target project name used in the Single Category Classification action.</param>
        /// <param name = "deploymentName">The deployment name used in the Single Category Classification action.</param>
        public SingleCategoryClassifyAction(string projectName, string deploymentName)
        {
            DeploymentName = deploymentName;
            ProjectName = projectName;
        }

        /// <summary>
        /// Gets the value of the property corresponding to the name of the target project.
        /// </summary>
        public string ProjectName { get; }

        /// <summary>
        /// Gets the value of the property corresponding to the name of the target deployment.
        /// </summary>
        public string DeploymentName { get; }

        /// <summary>
        /// The default value of this property is 'false'. This means, Text Analytics service logs your input text for 48 hours,
        /// solely to allow for troubleshooting issues.
        /// Setting this property to true, disables input logging and may limit our ability to investigate issues that occur.
        /// <para>
        /// Please see Cognitive Services Compliance and Privacy notes at <see href="https://aka.ms/cs-compliance"/> for additional details,
        /// and Microsoft Responsible AI principles at <see href="https://www.microsoft.com/ai/responsible-ai"/>.
        /// </para>
        /// </summary>
        public bool? DisableServiceLogs { get; set; }

        /// <summary>
        /// Gets or sets a name for this action. If not provided, the service will generate one.
        /// </summary>
        public string ActionName { get; set; }
    }
}
