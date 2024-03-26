/*
 * This file is automatically generated; any changes will be lost.
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoreEx.Entities;
using CoreEx.Http;
using CoreEx.Json;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Agents
{
    /// <summary>
    /// Provides the <see cref="Contact"/> HTTP agent.
    /// </summary>
    public partial class ContactAgent : TypedHttpClientBase<ContactAgent>, IContactAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactAgent"/> class.
        /// </summary>
        /// <param name="client">The underlying <see cref="HttpClient"/>.</param>
        /// <param name="jsonSerializer">The <see cref="IJsonSerializer"/>.</param>
        /// <param name="executionContext">The <see cref="CoreEx.ExecutionContext"/>.</param>
        public ContactAgent(HttpClient client, IJsonSerializer jsonSerializer, CoreEx.ExecutionContext executionContext) : base(client, jsonSerializer, executionContext) { }

        /// <inheritdoc/>
        public Task<HttpResult<ContactCollectionResult>> GetAllAsync(HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => GetAsync<ContactCollectionResult>("api/v1/contacts", requestOptions: requestOptions, cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Contact?>> GetAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => GetAsync<Contact?>("api/v1/contacts/{id}", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Contact>> CreateAsync(Contact value, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PostAsync<Contact, Contact>("api/v1/contacts", value, requestOptions: requestOptions, cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Contact>> UpdateAsync(Contact value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PutAsync<Contact, Contact>("api/v1/contacts/{id}", value, requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult<Contact>> PatchAsync(HttpPatchOption patchOption, string value, Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PatchAsync<Contact>("api/v1/contacts/{id}", patchOption, value, requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult> DeleteAsync(Guid id, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => DeleteAsync("api/v1/contacts/{id}", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<Guid>("id", id)), cancellationToken: cancellationToken);

        /// <inheritdoc/>
        public Task<HttpResult> RaiseEventAsync(bool throwError, HttpRequestOptions? requestOptions = null, CancellationToken cancellationToken = default)
            => PostAsync("api/v1/contacts/raise", requestOptions: requestOptions, args: HttpArgs.Create(new HttpArg<bool>("throwError", throwError)), cancellationToken: cancellationToken);
    }
}

#pragma warning restore
#nullable restore