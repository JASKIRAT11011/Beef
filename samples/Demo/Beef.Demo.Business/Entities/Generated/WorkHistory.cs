/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Business.Entities
{
    /// <summary>
    /// Represents the Work History entity.
    /// </summary>
    public partial class WorkHistory : EntityBase, IPrimaryKey
    {
        private Guid _personId;
        private string? _name;
        private DateTime _startDate;
        private DateTime? _endDate;

        /// <summary>
        /// Gets or sets the <see cref="Person"/> identifier (not serialized/read-only for internal data merging).
        /// </summary>
        [JsonIgnore]
        public Guid PersonId { get => _personId; set => SetValue(ref _personId, value, immutable: true); }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public string? Name { get => _name; set => SetValue(ref _name, value); }

        /// <summary>
        /// Gets or sets the Start Date.
        /// </summary>
        public DateTime StartDate { get => _startDate; set => SetValue(ref _startDate, value, transform: DateTimeTransform.DateOnly); }

        /// <summary>
        /// Gets or sets the End Date.
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetValue(ref _endDate, value, transform: DateTimeTransform.DateOnly); }

        /// <summary>
        /// Creates the primary <see cref="CompositeKey"/>.
        /// </summary>
        /// <returns>The <see cref="CompositeKey"/>.</returns>
        /// <param name="name">The <see cref="Name"/>.</param>
        public static CompositeKey CreatePrimaryKey(string? name) => new CompositeKey(name);

        /// <summary>
        /// Gets the primary <see cref="CompositeKey"/> (consists of the following property(s): <see cref="Name"/>).
        /// </summary>
        [JsonIgnore]
        public CompositeKey PrimaryKey => CreatePrimaryKey(Name);

        /// <inheritdoc/>
        protected override IEnumerable<IPropertyValue> GetPropertyValues()
        {
            yield return CreateProperty(nameof(PersonId), PersonId, v => PersonId = v);
            yield return CreateProperty(nameof(Name), Name, v => Name = v);
            yield return CreateProperty(nameof(StartDate), StartDate, v => StartDate = v);
            yield return CreateProperty(nameof(EndDate), EndDate, v => EndDate = v);
        }
    }

    /// <summary>
    /// Represents the <see cref="WorkHistory"/> collection.
    /// </summary>
    public partial class WorkHistoryCollection : EntityBaseCollection<WorkHistory, WorkHistoryCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkHistoryCollection"/> class.
        /// </summary>
        public WorkHistoryCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkHistoryCollection"/> class with <paramref name="items"/> to add.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public WorkHistoryCollection(IEnumerable<WorkHistory> items) => AddRange(items);
    }
}

#pragma warning restore
#nullable restore