/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Data;

/// <summary>
/// Provides the <see cref="Person"/> data access.
/// </summary>
public partial class PersonData : IPersonData
{
    private readonly IDatabase _db;
    private readonly IEfDb _ef;
    private readonly Microsoft.Extensions.Logging.ILogger<PersonData> _logger;
    private readonly Common.Agents.IPersonAgent _personAgent;

    #region Extensions

    private Func<Person, Task>? _createOnBeforeAsync;
    private Func<Person, Task>? _createOnAfterAsync;
    private Action<Exception>? _createOnException;
    private Func<Guid, Task>? _deleteOnBeforeAsync;
    private Func<Guid, Task>? _deleteOnAfterAsync;
    private Action<Exception>? _deleteOnException;
    private Func<Guid, Task>? _getExOnBeforeAsync;
    private Func<Person?, Guid, Task>? _getExOnAfterAsync;
    private Action<Exception>? _getExOnException;
    private Func<Person, Task>? _updateWithRollbackOnBeforeAsync;
    private Func<Person, Task>? _updateWithRollbackOnAfterAsync;
    private Action<Exception>? _updateWithRollbackOnException;
    private Action<DatabaseParameterCollection>? _getAllOnQuery;
    private Func<Task>? _getAllOnBeforeAsync;
    private Func<PersonCollectionResult, Task>? _getAllOnAfterAsync;
    private Action<Exception>? _getAllOnException;
    private Action<DatabaseParameterCollection>? _getAll2OnQuery;
    private Func<Task>? _getAll2OnBeforeAsync;
    private Func<PersonCollectionResult, Task>? _getAll2OnAfterAsync;
    private Action<Exception>? _getAll2OnException;
    private Action<DatabaseParameterCollection, PersonArgs?>? _getByArgsOnQuery;
    private Func<PersonArgs?, Task>? _getByArgsOnBeforeAsync;
    private Func<PersonCollectionResult, PersonArgs?, Task>? _getByArgsOnAfterAsync;
    private Action<Exception>? _getByArgsOnException;
    private Func<IQueryable<EfModel.Person>, PersonArgs?, IQueryable<EfModel.Person>>? _getByArgsWithEfOnQuery;
    private Func<PersonArgs?, Task>? _getByArgsWithEfOnBeforeAsync;
    private Func<PersonCollectionResult, PersonArgs?, Task>? _getByArgsWithEfOnAfterAsync;
    private Action<Exception>? _getByArgsWithEfOnException;
    private Func<Guid, Task>? _getWithEfOnBeforeAsync;
    private Func<Person?, Guid, Task>? _getWithEfOnAfterAsync;
    private Action<Exception>? _getWithEfOnException;
    private Func<Person, Task>? _createWithEfOnBeforeAsync;
    private Func<Person, Task>? _createWithEfOnAfterAsync;
    private Action<Exception>? _createWithEfOnException;
    private Func<Person, Task>? _updateWithEfOnBeforeAsync;
    private Func<Person, Task>? _updateWithEfOnAfterAsync;
    private Action<Exception>? _updateWithEfOnException;
    private Func<Guid, Task>? _deleteWithEfOnBeforeAsync;
    private Func<Guid, Task>? _deleteWithEfOnAfterAsync;
    private Action<Exception>? _deleteWithEfOnException;

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="PersonData"/> class.
    /// </summary>
    /// <param name="db">The <see cref="IDatabase"/>.</param>
    /// <param name="ef">The <see cref="IEfDb"/>.</param>
    /// <param name="logger">The <see cref="Microsoft.Extensions.Logging.ILogger{PersonData}"/>.</param>
    /// <param name="personAgent">The <see cref="Common.Agents.IPersonAgent"/>.</param>
    public PersonData(IDatabase db, IEfDb ef, Microsoft.Extensions.Logging.ILogger<PersonData> logger, Common.Agents.IPersonAgent personAgent)
        { _db = db.ThrowIfNull(); _ef = ef.ThrowIfNull(); _logger = logger.ThrowIfNull(); _personAgent = personAgent.ThrowIfNull(); PersonDataCtor(); }

    partial void PersonDataCtor(); // Enables additional functionality to be added to the constructor.

    /// <inheritdoc/>
    public Task<Person> CreateAsync(Person value) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_createOnBeforeAsync?.Invoke(value)).ConfigureAwait(false);
        var r = await _db.StoredProcedure("[Demo].[spPersonCreate]").CreateAsync(DbMapper.Default, value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_createOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _createOnException });

    /// <inheritdoc/>
    public Task DeleteAsync(Guid id) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_deleteOnBeforeAsync?.Invoke(id)).ConfigureAwait(false);
        await _db.StoredProcedure("[Demo].[spPersonDelete]").DeleteAsync(DbMapper.Default, id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_deleteOnAfterAsync?.Invoke(id)).ConfigureAwait(false);
    }, new InvokerArgs { ExceptionHandler = _deleteOnException });

    /// <inheritdoc/>
    public Task<Person?> GetAsync(Guid id)
        => _db.StoredProcedure("[Demo].[spPersonGet]").GetAsync(DbMapper.Default, id);

    /// <inheritdoc/>
    public Task<Person?> GetExAsync(Guid id) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_getExOnBeforeAsync?.Invoke(id)).ConfigureAwait(false);
        var r = await _db.StoredProcedure("[Demo].[spPersonGetEx]").GetAsync(DbMapper.Default, id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getExOnAfterAsync?.Invoke(r, id)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _getExOnException });

    /// <inheritdoc/>
    public Task<Person> UpdateAsync(Person value)
        => _db.StoredProcedure("[Demo].[spPersonUpdate]").UpdateAsync(DbMapper.Default, value);

    /// <inheritdoc/>
    public Task<Person> UpdateWithRollbackAsync(Person value) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_updateWithRollbackOnBeforeAsync?.Invoke(value)).ConfigureAwait(false);
        var r = await _db.StoredProcedure("[Demo].[spPersonUpdate]").UpdateAsync(DbMapper.Default, value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_updateWithRollbackOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _updateWithRollbackOnException });

    /// <inheritdoc/>
    public Task<PersonCollectionResult> GetAllAsync(PagingArgs? paging) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_getAllOnBeforeAsync?.Invoke()).ConfigureAwait(false);
        var r = await _db.StoredProcedure("[Demo].[spPersonGetAll]").Query(DbMapper.Default, p => _getAllOnQuery?.Invoke(p)).WithPaging(paging).SelectResultAsync<PersonCollectionResult, PersonCollection>().ConfigureAwait(false);
        await Invoker.InvokeAsync(_getAllOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _getAllOnException });

    /// <inheritdoc/>
    public Task<PersonCollectionResult> GetAll2Async() => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_getAll2OnBeforeAsync?.Invoke()).ConfigureAwait(false);
        var r = await _db.StoredProcedure("[Demo].[spPersonGetAll]").Query(DbMapper.Default, p => _getAll2OnQuery?.Invoke(p)).SelectResultAsync<PersonCollectionResult, PersonCollection>().ConfigureAwait(false);
        await Invoker.InvokeAsync(_getAll2OnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _getAll2OnException });

    /// <inheritdoc/>
    public Task<PersonCollectionResult> GetByArgsAsync(PersonArgs? args, PagingArgs? paging) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_getByArgsOnBeforeAsync?.Invoke(args)).ConfigureAwait(false);
        var r = await _db.StoredProcedure("[Demo].[spPersonGetByArgs]").Query(DbMapper.Default, p => _getByArgsOnQuery?.Invoke(p, args)).WithPaging(paging).SelectResultAsync<PersonCollectionResult, PersonCollection>().ConfigureAwait(false);
        await Invoker.InvokeAsync(_getByArgsOnAfterAsync?.Invoke(r, args)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _getByArgsOnException });

    /// <inheritdoc/>
    public Task<PersonDetailCollectionResult> GetDetailByArgsAsync(PersonArgs? args, PagingArgs? paging) => GetDetailByArgsOnImplementationAsync(args, paging);

    /// <inheritdoc/>
    public Task<Person> MergeAsync(Guid fromId, Guid toId) => MergeOnImplementationAsync(fromId, toId);

    /// <inheritdoc/>
    public Task MarkAsync() => MarkOnImplementationAsync();

    /// <inheritdoc/>
    public Task<MapCoordinates> MapAsync(MapArgs? args) => MapOnImplementationAsync(args);

    /// <inheritdoc/>
    public Task<Person?> GetNoArgsAsync() => GetNoArgsOnImplementationAsync();

    /// <inheritdoc/>
    public Task<PersonDetail?> GetDetailAsync(Guid id) => GetDetailOnImplementationAsync(id);

    /// <inheritdoc/>
    public Task<PersonDetail> UpdateDetailAsync(PersonDetail value) => UpdateDetailOnImplementationAsync(value);

    /// <inheritdoc/>
    public Task<Person?> GetNullAsync(string? name, List<string>? names) => GetNullOnImplementationAsync(name, names);

    /// <inheritdoc/>
    public Task<PersonCollectionResult> GetByArgsWithEfAsync(PersonArgs? args, PagingArgs? paging) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_getByArgsWithEfOnBeforeAsync?.Invoke(args)).ConfigureAwait(false);
        var r = await _ef.Query<Person, EfModel.Person>(q => _getByArgsWithEfOnQuery?.Invoke(q, args) ?? q).WithPaging(paging).SelectResultAsync<PersonCollectionResult, PersonCollection>().ConfigureAwait(false);
        await Invoker.InvokeAsync(_getByArgsWithEfOnAfterAsync?.Invoke(r, args)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _getByArgsWithEfOnException });

    /// <inheritdoc/>
    public Task ThrowErrorAsync() => ThrowErrorOnImplementationAsync();

    /// <inheritdoc/>
    public Task<string?> InvokeApiViaAgentAsync(Guid id) => InvokeApiViaAgentOnImplementationAsync(id);

    /// <inheritdoc/>
    public Task<Person?> GetWithEfAsync(Guid id) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_getWithEfOnBeforeAsync?.Invoke(id)).ConfigureAwait(false);
        var r = await _ef.GetAsync<Person, EfModel.Person>(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_getWithEfOnAfterAsync?.Invoke(r, id)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _getWithEfOnException });

    /// <inheritdoc/>
    public Task<Person> CreateWithEfAsync(Person value) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_createWithEfOnBeforeAsync?.Invoke(value)).ConfigureAwait(false);
        var r = await _ef.CreateAsync<Person, EfModel.Person>(value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_createWithEfOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _createWithEfOnException });

    /// <inheritdoc/>
    public Task<Person> UpdateWithEfAsync(Person value) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_updateWithEfOnBeforeAsync?.Invoke(value)).ConfigureAwait(false);
        var r = await _ef.UpdateAsync<Person, EfModel.Person>(value).ConfigureAwait(false);
        await Invoker.InvokeAsync(_updateWithEfOnAfterAsync?.Invoke(r)).ConfigureAwait(false);
        return r;
    }, new InvokerArgs { ExceptionHandler = _updateWithEfOnException });

    /// <inheritdoc/>
    public Task DeleteWithEfAsync(Guid id) => DataInvoker.Current.InvokeAsync(this, async (_, __) => 
    {
        await Invoker.InvokeAsync(_deleteWithEfOnBeforeAsync?.Invoke(id)).ConfigureAwait(false);
        await _ef.DeleteAsync<Person, EfModel.Person>(id).ConfigureAwait(false);
        await Invoker.InvokeAsync(_deleteWithEfOnAfterAsync?.Invoke(id)).ConfigureAwait(false);
    }, new InvokerArgs { ExceptionHandler = _deleteWithEfOnException });

    /// <inheritdoc/>
    public Task<FileContentResult> GetDocumentationAsync(Guid id) => GetDocumentationOnImplementationAsync(id);

    /// <summary>
    /// Provides the <see cref="Person"/> property and database column mapping.
    /// </summary>
    public partial class DbMapper : DatabaseMapper<Person, DbMapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DbMapper"/> class.
        /// </summary>
        public DbMapper()
        {
            Property(s => s.Id, "PersonId").SetPrimaryKey(false);
            Property(s => s.FirstName);
            Property(s => s.LastName);
            Property(s => s.UniqueCode);
            Property(s => s.Gender, "GenderId").SetConverter(ReferenceDataIdConverter<RefDataNamespace.Gender, Guid?>.Default);
            Property(s => s.EyeColorSid, "EyeColorCode");
            Property(s => s.Birthday).SetDbType(System.Data.DbType.Date);
            Property(s => s.Address).SetMapper(AddressData.DbMapper.Default!);
            Property(s => s.Metadata, "MetadataJson").SetConverter(ObjectToJsonConverter<Dictionary<string, string>>.Default);
            Property(s => s.ETag, "RowVersion", operationTypes: OperationTypes.AnyExceptCreate).SetConverter(StringToBase64Converter.Default);
            Property(s => s.ChangeLog).SetMapper(ChangeLogExDatabaseMapper.Default);
            DbMapperCtor();
        }
            
        partial void DbMapperCtor(); // Enables the DbMapper constructor to be extended.
    }

    /// <summary>
    /// Provides the <see cref="Person"/> to Entity Framework <see cref="EfModel.Person"/> mapping.
    /// </summary>
    public partial class EntityToModelEfMapper : Mapper<Person, EfModel.Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityToModelEfMapper"/> class.
        /// </summary>
        public EntityToModelEfMapper()
        {
            Map((s, d) => d.PersonId = s.Id, OperationTypes.Any, s => s.Id == default, d => d.PersonId = default);
            Map((s, d) => d.FirstName = s.FirstName, OperationTypes.Any, s => s.FirstName == default, d => d.FirstName = default);
            Map((s, d) => d.LastName = s.LastName, OperationTypes.Any, s => s.LastName == default, d => d.LastName = default);
            Map((s, d) => d.UniqueCode = s.UniqueCode, OperationTypes.Any, s => s.UniqueCode == default, d => d.UniqueCode = default);
            Map((s, d) => d.GenderId = ReferenceDataIdConverter<RefDataNamespace.Gender, Guid?>.Default.ToDestination.Convert(s.Gender), OperationTypes.Any, s => s.Gender == default, d => d.GenderId = default);
            Map((s, d) => d.EyeColorCode = s.EyeColorSid, OperationTypes.Any, s => s.EyeColorSid == default, d => d.EyeColorCode = default);
            Map((s, d) => d.Birthday = s.Birthday, OperationTypes.Any, s => s.Birthday == default, d => d.Birthday = default);
            Flatten(s => s.Address, OperationTypes.Any, s => s.Address == default);
            Map((s, d) => d.RowVersion = StringToBase64Converter.Default.ToDestination.Convert(s.ETag), OperationTypes.Any, s => s.ETag == default, d => d.RowVersion = default);
            Map((s, d) => d.MetadataJson = ObjectToJsonConverter<Dictionary<string, string>>.Default.ToDestination.Convert(s.Metadata), OperationTypes.Any, s => s.Metadata == default, d => d.MetadataJson = default);
            Flatten(s => s.ChangeLog, OperationTypes.Any, s => s.ChangeLog == default);
            EntityToModelEfMapperCtor();
        }

        partial void EntityToModelEfMapperCtor(); // Enables the constructor to be extended.

        /// <inheritdoc/>
        protected override void OnRegister(Mapper<Person, EfModel.Person> mapper) => mapper.Owner.Register(new Mapper<ChangeLogEx, EfModel.Person>()
            .Map((s, d) => d.CreatedBy = s.CreatedBy, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.CreatedDate = s.CreatedDate, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.UpdatedBy = s.UpdatedBy, OperationTypes.AnyExceptCreate)
            .Map((s, d) => d.UpdatedDate = s.UpdatedDate, OperationTypes.AnyExceptCreate));
    }

    /// <summary>
    /// Provides the Entity Framework <see cref="EfModel.Person"/> to <see cref="Person"/> mapping.
    /// </summary>
    public partial class ModelToEntityEfMapper : Mapper<EfModel.Person, Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelToEntityEfMapper"/> class.
        /// </summary>
        public ModelToEntityEfMapper()
        {
            Map((s, d) => d.Id = (Guid)s.PersonId!, OperationTypes.Any, s => s.PersonId == default, d => d.Id = default);
            Map((s, d) => d.FirstName = (string?)s.FirstName!, OperationTypes.Any, s => s.FirstName == default, d => d.FirstName = default);
            Map((s, d) => d.LastName = (string?)s.LastName!, OperationTypes.Any, s => s.LastName == default, d => d.LastName = default);
            Map((s, d) => d.UniqueCode = (string?)s.UniqueCode!, OperationTypes.Any, s => s.UniqueCode == default, d => d.UniqueCode = default);
            Map((s, d) => d.Gender = (string?)ReferenceDataIdConverter<RefDataNamespace.Gender, Guid?>.Default.ToSource.Convert(s.GenderId!), OperationTypes.Any, s => s.GenderId == default, d => d.Gender = default);
            Map((s, d) => d.EyeColorSid = (string?)s.EyeColorCode!, OperationTypes.Any, s => s.EyeColorCode == default, d => d.EyeColorSid = default);
            Map((s, d) => d.Birthday = (DateTime)s.Birthday!, OperationTypes.Any, s => s.Birthday == default, d => d.Birthday = default);
            Expand<Address>((d, v) => d.Address = v, OperationTypes.Any, d => d.Address = default);
            Map((s, d) => d.ETag = (string?)StringToBase64Converter.Default.ToSource.Convert(s.RowVersion!), OperationTypes.Any, s => s.RowVersion == default, d => d.ETag = default);
            Map((s, d) => d.Metadata = (Dictionary<string, string>?)ObjectToJsonConverter<Dictionary<string, string>>.Default.ToSource.Convert(s.MetadataJson!), OperationTypes.Any, s => s.MetadataJson == default, d => d.Metadata = default);
            Expand<ChangeLogEx>((d, v) => d.ChangeLog = v, OperationTypes.Any, d => d.ChangeLog = default);
            ModelToEntityEfMapperCtor();
        }

        partial void ModelToEntityEfMapperCtor(); // Enables the constructor to be extended.

        /// <inheritdoc/>
        protected override void OnRegister(Mapper<EfModel.Person, Person> mapper) => mapper.Owner.Register(new Mapper<EfModel.Person, ChangeLogEx>()
            .Map((s, d) => d.CreatedBy = s.CreatedBy, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.CreatedDate = s.CreatedDate, OperationTypes.AnyExceptUpdate)
            .Map((s, d) => d.UpdatedBy = s.UpdatedBy, OperationTypes.AnyExceptCreate)
            .Map((s, d) => d.UpdatedDate = s.UpdatedDate, OperationTypes.AnyExceptCreate));
    }
}

#pragma warning restore
#nullable restore