﻿using System.Threading.Tasks;

namespace AggregateSource
{
    /// <summary>
    /// Represents an asynchronous, virtual collection of <typeparamref name="TAggregateRoot"/>.
    /// </summary>
    /// <typeparam name="TAggregateRoot">The type of the aggregate root in this collection.</typeparam>
    public interface IAsyncRepository<TAggregateRoot>
    {
        /// <summary>
        /// Gets the aggregate root entity associated with the specified aggregate identifier.
        /// </summary>
        /// <param name="identifier">The aggregate identifier.</param>
        /// <returns>An instance of <typeparamref name="TAggregateRoot"/>.</returns>
        /// <exception cref="AggregateNotFoundException">Thrown when an aggregate is not found.</exception>
        Task<TAggregateRoot> GetAsync(string identifier);

        /// <summary>
        /// Attempts to get the aggregate root entity associated with the aggregate identifier.
        /// </summary>
        /// <param name="identifier">The aggregate identifier.</param>
        /// <returns>The found <typeparamref name="TAggregateRoot"/>, or empty if not found.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        Task<Optional<TAggregateRoot>> GetOptionalAsync(string identifier);

        /// <summary>
        /// Adds the aggregate root entity to this collection using the specified aggregate identifier.
        /// </summary>
        /// <param name="identifier">The aggregate identifier.</param>
        /// <param name="root">The aggregate root entity.</param>
        void Add(string identifier, TAggregateRoot root);
    }
}