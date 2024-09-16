/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

namespace Beef.Demo.Api.Controllers;

/// <summary>
/// Provides the <see cref="Contact"/> Web API functionality.
/// </summary>
[AllowAnonymous]
[Consumes(System.Net.Mime.MediaTypeNames.Application.Json)]
[Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
public partial class ContactController : ControllerBase
{
    private readonly WebApi _webApi;
    private readonly IContactManager _manager;
    private readonly Microsoft.Extensions.Configuration.IConfiguration _config;

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactController"/> class.
    /// </summary>
    /// <param name="webApi">The <see cref="WebApi"/>.</param>
    /// <param name="manager">The <see cref="IContactManager"/>.</param>
    /// <param name="config">The <see cref="Microsoft.Extensions.Configuration.IConfiguration"/>.</param>
    public ContactController(WebApi webApi, IContactManager manager, Microsoft.Extensions.Configuration.IConfiguration config)
        { _webApi = webApi.ThrowIfNull(); _manager = manager.ThrowIfNull(); _config = config.ThrowIfNull(); ContactControllerCtor(); }

    partial void ContactControllerCtor(); // Enables additional functionality to be added to the constructor.

    /// <summary>
    /// Gets the <c>Contact</c> array that contains the items that match the selection criteria.
    /// </summary>
    /// <returns>The <c>Contact</c> array</returns>
    [HttpGet("api/v1/contacts/query", Name="Contact_GetByQuery")]
    [Paging]
    [Query]
    [ProducesResponseType(typeof(Common.Entities.ContactCollection), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public Task<IActionResult> GetByQuery()
        => _webApi.GetAsync<ContactCollectionResult>(Request, p => _manager.GetByQueryAsync(p.RequestOptions.Query, p.RequestOptions.Paging), alternateStatusCode: HttpStatusCode.NoContent);

    /// <summary>
    /// Gets the <c>Contact</c> array that contains the items that match the selection criteria.
    /// </summary>
    /// <returns>The <c>Contact</c> array</returns>
    [HttpGet("api/v1/contacts", Name="Contact_GetAll")]
    [ProducesResponseType(typeof(Common.Entities.ContactCollection), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public Task<IActionResult> GetAll()
        => _webApi.GetAsync<ContactCollectionResult>(Request, p => _manager.GetAllAsync(), alternateStatusCode: HttpStatusCode.NoContent);

    /// <summary>
    /// Gets the specified <c>Contact</c>.
    /// </summary>
    /// <param name="id">The <c>Contact</c> identifier.</param>
    /// <returns>The selected <c>Contact</c> where found.</returns>
    [HttpGet("api/v1/contacts/{id}", Name="Contact_Get")]
    [ProducesResponseType(typeof(Common.Entities.Contact), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public Task<IActionResult> Get(Guid id)
        => _webApi.GetAsync<Contact?>(Request, p => _manager.GetAsync(id));

    /// <summary>
    /// Creates a new <c>Contact</c>.
    /// </summary>
    /// <returns>The created <c>Contact</c>.</returns>
    [HttpPost("api/v1/contacts", Name="Contact_Create")]
    [AcceptsBody(typeof(Common.Entities.Contact))]
    [ProducesResponseType(typeof(Common.Entities.Contact), (int)HttpStatusCode.Created)]
    public Task<IActionResult> Create()
        => _webApi.PostAsync<Contact, Contact>(Request, p => _manager.CreateAsync(p.Value!), statusCode: HttpStatusCode.Created);

    /// <summary>
    /// Updates an existing <c>Contact</c>.
    /// </summary>
    /// <param name="id">The <c>Contact</c> identifier.</param>
    /// <returns>The updated <c>Contact</c>.</returns>
    [HttpPut("api/v1/contacts/{id}", Name="Contact_Update")]
    [AcceptsBody(typeof(Common.Entities.Contact))]
    [ProducesResponseType(typeof(Common.Entities.Contact), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public Task<IActionResult> Update(Guid id)
        => _webApi.PutAsync<Contact, Contact>(Request, p => _manager.UpdateAsync(p.Value!, id));

    /// <summary>
    /// Patches an existing <c>Contact</c>.
    /// </summary>
    /// <param name="id">The <c>Contact</c> identifier.</param>
    /// <returns>The patched <c>Contact</c>.</returns>
    [HttpPatch("api/v1/contacts/{id}", Name="Contact_Patch")]
    [AcceptsBody(typeof(Common.Entities.Contact), HttpConsts.MergePatchMediaTypeName)]
    [ProducesResponseType(typeof(Common.Entities.Contact), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public Task<IActionResult> Patch(Guid id)
        => _webApi.PatchAsync<Contact>(Request, get: _ => _manager.GetAsync(id), put: p => _manager.UpdateAsync(p.Value!, id));

    /// <summary>
    /// Deletes the specified <c>Contact</c>.
    /// </summary>
    /// <param name="id">The <c>Contact</c> identifier.</param>
    [HttpDelete("api/v1/contacts/{id}", Name="Contact_Delete")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public Task<IActionResult> Delete(Guid id)
        => _webApi.DeleteAsync(Request, p => _manager.DeleteAsync(id));

    /// <summary>
    /// Raise Event.
    /// </summary>
    /// <param name="throwError">Indicates whether throw a DivideByZero exception.</param>
    [HttpPost("api/v1/contacts/raise", Name="Contact_RaiseEvent")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public Task<IActionResult> RaiseEvent(bool throwError)
        => _webApi.PostAsync(Request, p => _manager.RaiseEventAsync(throwError), statusCode: HttpStatusCode.NoContent, operationType: CoreEx.OperationType.Unspecified);
}

#pragma warning restore
#nullable restore