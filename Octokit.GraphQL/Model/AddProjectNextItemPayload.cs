namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of AddProjectNextItem
    /// </summary>
    public class AddProjectNextItemPayload : QueryableValue<AddProjectNextItemPayload>
    {
        internal AddProjectNextItemPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The item added to the project.
        /// </summary>
        [Obsolete(@"The `ProjectNext` API is deprecated in favour of the more capable `ProjectV2` API. Follow the ProjectV2 guide at https://github.blog/changelog/2022-06-23-the-new-github-issues-june-23rd-update/, to find a suitable replacement. Removal on 2022-10-01 UTC.")]
        public ProjectNextItem ProjectNextItem => this.CreateProperty(x => x.ProjectNextItem, Octokit.GraphQL.Model.ProjectNextItem.Create);

        internal static AddProjectNextItemPayload Create(Expression expression)
        {
            return new AddProjectNextItemPayload(expression);
        }
    }
}