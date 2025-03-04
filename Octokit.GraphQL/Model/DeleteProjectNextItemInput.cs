namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DeleteProjectNextItem
    /// </summary>
    public class DeleteProjectNextItemInput
    {
        /// <summary>
        /// The ID of the Project from which the item should be removed. This field is required.
        /// **Upcoming Change on 2022-10-01 UTC**
        /// **Description:** `projectId` will be removed. Follow the ProjectV2 guide at https://github.blog/changelog/2022-06-23-the-new-github-issues-june-23rd-update/, to find a suitable replacement.
        /// **Reason:** The `ProjectNext` API is deprecated in favour of the more capable `ProjectV2` API.
        /// </summary>
        public ID? ProjectId { get; set; }

        /// <summary>
        /// The ID of the item to be removed. This field is required.
        /// **Upcoming Change on 2022-10-01 UTC**
        /// **Description:** `itemId` will be removed. Follow the ProjectV2 guide at https://github.blog/changelog/2022-06-23-the-new-github-issues-june-23rd-update/, to find a suitable replacement.
        /// **Reason:** The `ProjectNext` API is deprecated in favour of the more capable `ProjectV2` API.
        /// </summary>
        public ID? ItemId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}