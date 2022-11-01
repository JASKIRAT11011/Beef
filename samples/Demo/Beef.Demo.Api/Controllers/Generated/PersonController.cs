/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="Person"/> Web API functionality.
    /// </summary>
    [AllowAnonymous]
    [Route("api/v1/persons")]
    [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
    public partial class PersonController : ControllerBase
    {
        private readonly WebApi _webApi;
        private readonly IPersonManager _manager;
        private readonly IPersonManager _personManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonController"/> class.
        /// </summary>
        /// <param name="webApi">The <see cref="WebApi"/>.</param>
        /// <param name="manager">The <see cref="IPersonManager"/>.</param>
        /// <param name="personManager">The <see cref="IPersonManager"/>.</param>
        public PersonController(WebApi webApi, IPersonManager manager, IPersonManager personManager)
        {
            _webApi = webApi ?? throw new ArgumentNullException(nameof(webApi));
            _manager = manager ?? throw new ArgumentNullException(nameof(manager));
            _personManager = personManager ?? throw new ArgumentNullException(nameof(personManager));
            PersonControllerCtor();
        }

        partial void PersonControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Creates a new <see cref="Person"/>.
        /// </summary>
        /// <returns>The created <see cref="Person"/>.</returns>
        [HttpPost("")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.Created)]
        public Task<IActionResult> Create() =>
            _webApi.PostAsync<Person, Person>(Request, p => _manager.CreateAsync(p.Value!), statusCode: HttpStatusCode.Created, locationUri: r => new Uri($"/api/v1/persons/{r.Id}", UriKind.Relative));

        /// <summary>
        /// Deletes the specified <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> Delete(Guid id) =>
            _webApi.DeleteAsync(Request, p => _manager.DeleteAsync(id));

        /// <summary>
        /// Gets the specified <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="Person"/> where found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> Get(Guid id) =>
            _webApi.GetAsync<Person?>(Request, p => _manager.GetAsync(id));

        /// <summary>
        /// Gets the specified <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="Person"/> where found.</returns>
        [HttpGet("ex/{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> GetEx(Guid id) =>
            _webApi.GetAsync<Person?>(Request, p => _manager.GetExAsync(id));

        /// <summary>
        /// Updates an existing <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The updated <see cref="Person"/>.</returns>
        [HttpPut("{id}")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Update(Guid id) =>
            _webApi.PutAsync<Person, Person>(Request, p => _manager.UpdateAsync(p.Value!, id));

        /// <summary>
        /// Updates an existing <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The updated <see cref="Person"/>.</returns>
        [HttpPut("withRollback/{id}")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public Task<IActionResult> UpdateWithRollback(Guid id) =>
            _webApi.PutAsync<Person, Person>(Request, p => _manager.UpdateWithRollbackAsync(p.Value!, id));

        /// <summary>
        /// Patches an existing <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The patched <see cref="Person"/>.</returns>
        [HttpPatch("{id}")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public Task<IActionResult> Patch(Guid id) =>
            _webApi.PatchAsync<Person>(Request, get: _ => _manager.GetAsync(id), put: p => _manager.UpdateAsync(p.Value!, id));

        /// <summary>
        /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <returns>The <see cref="PersonCollection"/></returns>
        [HttpGet("all")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetAll() =>
            _webApi.GetAsync<PersonCollectionResult>(Request, p => _manager.GetAllAsync(p.RequestOptions.Paging), alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary>
        /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <returns>The <see cref="PersonCollection"/></returns>
        [HttpGet("allnopaging")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetAll2() =>
            _webApi.GetAsync<PersonCollectionResult>(Request, p => _manager.GetAll2Async(), alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary>
        /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="firstName">The First Name.</param>
        /// <param name="lastName">The Last Name.</param>
        /// <param name="genders">The Genders (see <see cref="RefDataNamespace.Gender"/>).</param>
        /// <returns>The <see cref="PersonCollection"/></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetByArgs(string? firstName = default, string? lastName = default, List<string>? genders = default)
        {
            var args = new PersonArgs { FirstName = firstName, LastName = lastName, GendersSids = genders };
            return _webApi.GetAsync<PersonCollectionResult>(Request, p => _manager.GetByArgsAsync(args, p.RequestOptions.Paging), alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="PersonDetailCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="firstName">The First Name.</param>
        /// <param name="lastName">The Last Name.</param>
        /// <param name="genders">The Genders (see <see cref="RefDataNamespace.Gender"/>).</param>
        /// <returns>The <see cref="PersonDetailCollection"/></returns>
        [HttpGet("argsdetail")]
        [ProducesResponseType(typeof(PersonDetailCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetDetailByArgs(string? firstName = default, string? lastName = default, List<string>? genders = default)
        {
            var args = new PersonArgs { FirstName = firstName, LastName = lastName, GendersSids = genders };
            return _webApi.GetAsync<PersonDetailCollectionResult>(Request, p => _manager.GetDetailByArgsAsync(args, p.RequestOptions.Paging), alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Merge first <see cref="Person"/> into second.
        /// </summary>
        /// <param name="fromId">The from <see cref="Person"/> identifier.</param>
        /// <param name="toId">The to <see cref="Person"/> identifier.</param>
        /// <returns>A resultant <see cref="Person"/>.</returns>
        [HttpPost("merge")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> Merge(Guid fromId, Guid toId) =>
            _webApi.PostAsync<Person>(Request, p => _manager.MergeAsync(fromId, toId), alternateStatusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Update);

        /// <summary>
        /// Mark <see cref="Person"/>.
        /// </summary>
        [HttpPost("mark")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public Task<IActionResult> Mark() =>
            _webApi.PostAsync(Request, p => _manager.MarkAsync(), statusCode: HttpStatusCode.Accepted, operationType: CoreEx.OperationType.Update);

        /// <summary>
        /// Get <see cref="Person"/> at specified <see cref="MapCoordinates"/>.
        /// </summary>
        /// <param name="coordinates">The Coordinates (see <see cref="Business.Entities.MapCoordinates"/>).</param>
        /// <returns>A resultant <see cref="MapCoordinates"/>.</returns>
        [HttpPost("map")]
        [ProducesResponseType(typeof(MapCoordinates), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> Map(MapCoordinates? coordinates = default)
        {
            var args = new MapArgs { Coordinates = coordinates };
            return _webApi.PostAsync<MapCoordinates>(Request, p => _manager.MapAsync(args), alternateStatusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Read);
        }

        /// <summary>
        /// Get no arguments.
        /// </summary>
        /// <returns>The selected <see cref="Person"/> where found.</returns>
        [HttpGet("noargsforme")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> GetNoArgs() =>
            _webApi.GetAsync<Person?>(Request, p => _manager.GetNoArgsAsync());

        /// <summary>
        /// Gets the specified <see cref="PersonDetail"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="PersonDetail"/> where found.</returns>
        [HttpGet("{id}/detail")]
        [ProducesResponseType(typeof(PersonDetail), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> GetDetail(Guid id) =>
            _webApi.GetAsync<PersonDetail?>(Request, p => _manager.GetDetailAsync(id));

        /// <summary>
        /// Updates an existing <see cref="PersonDetail"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The updated <see cref="PersonDetail"/>.</returns>
        [HttpPut("{id}/detail")]
        [AcceptsBody(typeof(Common.Entities.PersonDetail))]
        [ProducesResponseType(typeof(PersonDetail), (int)HttpStatusCode.OK)]
        public Task<IActionResult> UpdateDetail(Guid id) =>
            _webApi.PutAsync<PersonDetail, PersonDetail>(Request, p => _manager.UpdateDetailAsync(p.Value!, id));

        /// <summary>
        /// Patches an existing <see cref="PersonDetail"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The patched <see cref="PersonDetail"/>.</returns>
        [HttpPatch("{id}/detail")]
        [AcceptsBody(typeof(Common.Entities.PersonDetail))]
        [ProducesResponseType(typeof(PersonDetail), (int)HttpStatusCode.OK)]
        public Task<IActionResult> PatchDetail(Guid id) =>
            _webApi.PatchAsync<PersonDetail>(Request, get: _ => _manager.GetDetailAsync(id), put: p => _personManager.UpdateDetailAsync(p.Value!, id));

        /// <summary>
        /// Actually validating the FromBody parameter generation.
        /// </summary>
        /// <param name="person">The Person (see <see cref="Entities.Person"/>).</param>
        [HttpPost("fromBody")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public Task<IActionResult> Add([FromBody] Person person) =>
            _webApi.PostAsync(Request, p => _manager.AddAsync(person), statusCode: HttpStatusCode.Created, operationType: CoreEx.OperationType.Unspecified);

        /// <summary>
        /// Get Null.
        /// </summary>
        /// <param name="name">The Name.</param>
        /// <param name="names">The Names.</param>
        /// <returns>A resultant <see cref="Person"/>.</returns>
        [HttpGet("null")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> GetNull(string? name, List<string>? names = default) =>
            _webApi.GetAsync<Person?>(Request, p => _manager.GetNullAsync(name, names), operationType: CoreEx.OperationType.Unspecified);

        /// <summary>
        /// Validate when an Event is published but not sent.
        /// </summary>
        /// <returns>The updated <see cref="Person"/>.</returns>
        [HttpPut("publishnosend")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public Task<IActionResult> EventPublishNoSend() =>
            _webApi.PutAsync<Person, Person>(Request, p => _manager.EventPublishNoSendAsync(p.Value!));

        /// <summary>
        /// Gets the <see cref="PersonCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="firstName">The First Name.</param>
        /// <param name="lastName">The Last Name.</param>
        /// <param name="genders">The Genders (see <see cref="RefDataNamespace.Gender"/>).</param>
        /// <returns>The <see cref="PersonCollection"/></returns>
        [HttpGet("args")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> GetByArgsWithEf(string? firstName = default, string? lastName = default, List<string>? genders = default)
        {
            var args = new PersonArgs { FirstName = firstName, LastName = lastName, GendersSids = genders };
            return _webApi.GetAsync<PersonCollectionResult>(Request, p => _manager.GetByArgsWithEfAsync(args, p.RequestOptions.Paging), alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Throw Error.
        /// </summary>
        [HttpPost("error")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> ThrowError() =>
            _webApi.PostAsync(Request, p => _manager.ThrowErrorAsync(), statusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Unspecified);

        /// <summary>
        /// Invoke Api Via Agent.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>A resultant <see cref="string"/>.</returns>
        [HttpPost("invokeApi")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> InvokeApiViaAgent(Guid id) =>
            _webApi.PostAsync<string?>(Request, p => _manager.InvokeApiViaAgentAsync(id), alternateStatusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Unspecified);

        /// <summary>
        /// Param Coll.
        /// </summary>
        /// <param name="addresses">The Addresses.</param>
        [HttpPost("paramcoll")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> ParamColl([FromBody] AddressCollection? addresses) =>
            _webApi.PostAsync(Request, p => _manager.ParamCollAsync(addresses), statusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Unspecified);

        /// <summary>
        /// Gets the specified <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="Person"/> where found.</returns>
        [HttpGet("ef/{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Task<IActionResult> GetWithEf(Guid id) =>
            _webApi.GetAsync<Person?>(Request, p => _manager.GetWithEfAsync(id));

        /// <summary>
        /// Creates a new <see cref="Person"/>.
        /// </summary>
        /// <returns>The created <see cref="Person"/>.</returns>
        [HttpPost("ef")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.Created)]
        public Task<IActionResult> CreateWithEf() =>
            _webApi.PostAsync<Person, Person>(Request, p => _manager.CreateWithEfAsync(p.Value!), statusCode: HttpStatusCode.Created, locationUri: r => new Uri($"/api/v1/persons/ef/{r.Id}", UriKind.Relative));

        /// <summary>
        /// Updates an existing <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The updated <see cref="Person"/>.</returns>
        [HttpPut("ef/{id}")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public Task<IActionResult> UpdateWithEf(Guid id) =>
            _webApi.PutAsync<Person, Person>(Request, p => _manager.UpdateWithEfAsync(p.Value!, id));

        /// <summary>
        /// Deletes the specified <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        [HttpDelete("ef/{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public Task<IActionResult> DeleteWithEf(Guid id) =>
            _webApi.DeleteAsync(Request, p => _manager.DeleteWithEfAsync(id));

        /// <summary>
        /// Patches an existing <see cref="Person"/>.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The patched <see cref="Person"/>.</returns>
        [HttpPatch("ef/{id}")]
        [AcceptsBody(typeof(Common.Entities.Person))]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public Task<IActionResult> PatchWithEf(Guid id) =>
            _webApi.PatchAsync<Person>(Request, get: _ => _manager.GetAsync(id), put: p => _manager.UpdateAsync(p.Value!, id));
    }
}

#pragma warning restore
#nullable restore