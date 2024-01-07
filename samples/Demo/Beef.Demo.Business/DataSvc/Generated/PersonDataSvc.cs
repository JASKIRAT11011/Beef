/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.DataSvc;

/// <summary>
/// Provides the <see cref="Person"/> data repository services.
/// </summary>
public partial class PersonDataSvc : IPersonDataSvc
{
    private readonly IPersonData _data;
    private readonly IEventPublisher _events;
    private readonly IRequestCache _cache;

    #region Extensions

    private Func<Person, Task>? _createOnAfterAsync;
    private Func<Guid, Task>? _deleteOnAfterAsync;
    private Func<Person?, Guid, Task>? _getExOnAfterAsync;
    private Func<Person, Task>? _updateWithRollbackOnAfterAsync;
    private Func<PersonCollectionResult, PagingArgs?, Task>? _getAllOnAfterAsync;
    private Func<PersonCollectionResult, Task>? _getAll2OnAfterAsync;
    private Func<PersonCollectionResult, PersonArgs?, PagingArgs?, Task>? _getByArgsOnAfterAsync;
    private Func<PersonDetailCollectionResult, PersonArgs?, PagingArgs?, Task>? _getDetailByArgsOnAfterAsync;
    private Func<Person, Guid, Guid, Task>? _mergeOnAfterAsync;
    private Func<Task>? _markOnAfterAsync;
    private Func<MapCoordinates, MapArgs?, Task>? _mapOnAfterAsync;
    private Func<Person?, Task>? _getNoArgsOnAfterAsync;
    private Func<PersonDetail?, Guid, Task>? _getDetailOnAfterAsync;
    private Func<PersonDetail, Task>? _updateDetailOnAfterAsync;
    private Func<Person?, string?, List<string>?, Task>? _getNullOnAfterAsync;
    private Func<PersonCollectionResult, PersonArgs?, PagingArgs?, Task>? _getByArgsWithEfOnAfterAsync;
    private Func<Task>? _throwErrorOnAfterAsync;
    private Func<string?, Guid, Task>? _invokeApiViaAgentOnAfterAsync;
    private Func<Person?, Guid, Task>? _getWithEfOnAfterAsync;
    private Func<Person, Task>? _createWithEfOnAfterAsync;
    private Func<Person, Task>? _updateWithEfOnAfterAsync;
    private Func<Guid, Task>? _deleteWithEfOnAfterAsync;
    private Func<FileContentResult, Guid, Task>? _getDocumentationOnAfterAsync;

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="PersonDataSvc"/> class.
    /// </summary>
    /// <param name="data">The <see cref="IPersonData"/>.</param>
    /// <param name="events">The <see cref="IEventPublisher"/>.</param>
    /// <param name="cache">The <see cref="IRequestCache"/>.</param>
    public PersonDataSvc(IPersonData data, IEventPublisher events, IRequestCache cache)
        { _data = data.ThrowIfNull(); _events = events.ThrowIfNull(); _cache = cache.ThrowIfNull(); PersonDataSvcCtor(); }

    partial void PersonDataSvcCtor(); // Enables additional functionality to be added to the constructor.

    /// <inheritdoc/>
    public Task<Person> CreateAsync(Person value) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        var r = await _data.CreateAsync(value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_createOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        _events.PublishValueEvent(r, new Uri($"/person/{r.Id}", UriKind.Relative), $"Demo.Person", "Create");
        return _cache.SetValue(r);
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public Task DeleteAsync(Guid id) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        _cache.Remove<Person>(id);
        await _data.DeleteAsync(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_deleteOnAfterAsync?.Invoke(id)).ConfigureAwait(false);
        _events.PublishValueEvent(new Person { Id = id }, new Uri($"/person/{id}", UriKind.Relative), $"Demo.Person", "Delete");
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public Task<Person?> GetAsync(Guid id) => _cache.GetOrAddAsync(id, () => _data.GetAsync(id));

    /// <inheritdoc/>
    public async Task<Person?> GetExAsync(Guid id)
    {
        if (_cache.TryGetValue(id, out Person? __val))
            return __val;

        var r = await _data.GetExAsync(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getExOnAfterAsync?.Invoke(r, id)).ConfigureAwait(false);
        return _cache.SetValue(r);
    }

    /// <inheritdoc/>
    public Task<Person> UpdateAsync(Person value) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        var r = await _data.UpdateAsync(value).ConfigureAwait(false);
        _events.PublishValueEvent(r, new Uri($"/person/{r.Id}", UriKind.Relative), $"Demo.Person", "Update");
        return _cache.SetValue(r);
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public Task<Person> UpdateWithRollbackAsync(Person value) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        var r = await _data.UpdateWithRollbackAsync(value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_updateWithRollbackOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        _events.PublishValueEvent(r, new Uri($"/person/{r.Id}", UriKind.Relative), $"Demo.Person", "Update");
        return _cache.SetValue(r);
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public async Task<PersonCollectionResult> GetAllAsync(PagingArgs? paging)
    {
        var r = await _data.GetAllAsync(paging).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getAllOnAfterAsync?.Invoke(r, paging)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public async Task<PersonCollectionResult> GetAll2Async()
    {
        var r = await _data.GetAll2Async().ConfigureAwait(false);
        await Invoker.InvokeAsync(_getAll2OnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public async Task<PersonCollectionResult> GetByArgsAsync(PersonArgs? args, PagingArgs? paging)
    {
        var r = await _data.GetByArgsAsync(args, paging).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getByArgsOnAfterAsync?.Invoke(r, args, paging)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public async Task<PersonDetailCollectionResult> GetDetailByArgsAsync(PersonArgs? args, PagingArgs? paging)
    {
        var r = await _data.GetDetailByArgsAsync(args, paging).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getDetailByArgsOnAfterAsync?.Invoke(r, args, paging)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public Task<Person> MergeAsync(Guid fromId, Guid toId) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        var r = await _data.MergeAsync(fromId, toId).ConfigureAwait(false);
        await Invoker.InvokeAsync(_mergeOnAfterAsync?.Invoke(r, fromId, toId)).ConfigureAwait(false);
        _events.Publish(
            _events.CreateValueEvent(r, new Uri($"/person/", UriKind.Relative), $"Demo.Person.{fromId}", "MergeFrom"),
            _events.CreateValueEvent(r, new Uri($"/person/", UriKind.Relative), $"Demo.Person.{toId}", "MergeTo"));

        return r;
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public Task MarkAsync() => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        await _data.MarkAsync().ConfigureAwait(false);
        await Invoker.InvokeAsync(_markOnAfterAsync?.Invoke()).ConfigureAwait(false);
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public async Task<MapCoordinates> MapAsync(MapArgs? args)
    {
        var r = await _data.MapAsync(args).ConfigureAwait(false);
        await Invoker.InvokeAsync(_mapOnAfterAsync?.Invoke(r, args)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public async Task<Person?> GetNoArgsAsync()
    {
        if (_cache.TryGetValue(new CompositeKey(), out Person? __val))
            return __val;

        var r = await _data.GetNoArgsAsync().ConfigureAwait(false);
        await Invoker.InvokeAsync(_getNoArgsOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return _cache.SetValue(r);
    }

    /// <inheritdoc/>
    public async Task<PersonDetail?> GetDetailAsync(Guid id)
    {
        if (_cache.TryGetValue(id, out PersonDetail? __val))
            return __val;

        var r = await _data.GetDetailAsync(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getDetailOnAfterAsync?.Invoke(r, id)).ConfigureAwait(false);
        return _cache.SetValue(r);
    }

    /// <inheritdoc/>
    public Task<PersonDetail> UpdateDetailAsync(PersonDetail value) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        var r = await _data.UpdateDetailAsync(value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_updateDetailOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        _events.PublishValueEvent(r, new Uri($"/person/{r.Id}", UriKind.Relative), $"Demo.Person", "Update");
        return _cache.SetValue(r);
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public Task<int> DataSvcCustomAsync() => DataSvcCustomOnImplementationAsync();

    /// <inheritdoc/>
    public async Task<Person?> GetNullAsync(string? name, List<string>? names)
    {
        var r = await _data.GetNullAsync(name, names).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getNullOnAfterAsync?.Invoke(r, name, names)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public Task<Person> EventPublishNoSendAsync(Person value) => EventPublishNoSendOnImplementationAsync(value);

    /// <inheritdoc/>
    public async Task<PersonCollectionResult> GetByArgsWithEfAsync(PersonArgs? args, PagingArgs? paging)
    {
        var r = await _data.GetByArgsWithEfAsync(args, paging).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getByArgsWithEfOnAfterAsync?.Invoke(r, args, paging)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public async Task ThrowErrorAsync()
    {
        await _data.ThrowErrorAsync().ConfigureAwait(false);
        await Invoker.InvokeAsync(_throwErrorOnAfterAsync?.Invoke()).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<string?> InvokeApiViaAgentAsync(Guid id)
    {
        var r = await _data.InvokeApiViaAgentAsync(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_invokeApiViaAgentOnAfterAsync?.Invoke(r, id)).ConfigureAwait(false);
        return r;
    }

    /// <inheritdoc/>
    public Task ParamCollAsync(AddressCollection? addresses) => ParamCollOnImplementationAsync(addresses);

    /// <inheritdoc/>
    public async Task<Person?> GetWithEfAsync(Guid id)
    {
        if (_cache.TryGetValue(id, out Person? __val))
            return __val;

        var r = await _data.GetWithEfAsync(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getWithEfOnAfterAsync?.Invoke(r, id)).ConfigureAwait(false);
        return _cache.SetValue(r);
    }

    /// <inheritdoc/>
    public async Task<Person> CreateWithEfAsync(Person value)
    {
        var r = await _data.CreateWithEfAsync(value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_createWithEfOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return _cache.SetValue(r);
    }

    /// <inheritdoc/>
    public Task<Person> UpdateWithEfAsync(Person value) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        var r = await _data.UpdateWithEfAsync(value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_updateWithEfOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        _events.PublishValueEvent(r, new Uri($"/person/{r.Id}", UriKind.Relative), $"Demo.Person", "Update");
        return _cache.SetValue(r);
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public Task DeleteWithEfAsync(Guid id) => DataSvcInvoker.Current.InvokeAsync(this, async (_, __) =>
    {
        _cache.Remove<Person>(id);
        await _data.DeleteWithEfAsync(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_deleteWithEfOnAfterAsync?.Invoke(id)).ConfigureAwait(false);
        _events.PublishValueEvent(new Person { Id = id }, new Uri($"/person/{id}", UriKind.Relative), $"Demo.Person.{id}", "Delete");
    }, new InvokerArgs { IncludeTransactionScope = true, EventPublisher = _events });

    /// <inheritdoc/>
    public async Task<FileContentResult> GetDocumentationAsync(Guid id)
    {
        var r = await _data.GetDocumentationAsync(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getDocumentationOnAfterAsync?.Invoke(r, id)).ConfigureAwait(false);
        return r;
    }
}

#pragma warning restore
#nullable restore