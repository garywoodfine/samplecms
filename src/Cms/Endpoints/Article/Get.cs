using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Cms.Aspects;
using Cms.Attributes;
using Cms.Endpoints.Article.Request;
using Cms.Endpoints.Article.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Cms.Endpoints.Article
{
    [Route("/article")]
    public class Get : BaseAsyncEndpoint
        .WithRequest<ArticleRequest>
        .WithResponse<ArticleResponse>
    {
        public Get()
        {
        }

        [HttpGet("{category}/{id}")]
        [SwaggerOperation(
            Summary = "Retrieve an article by id ",
            Description = "Retrieves a full articles ",
            OperationId = "EF0A3653-153F-4E73-8D20-621C9F9FFDC9",
            Tags = new[] {"Article"})
        ]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ArticleResponse))]
        [Produces("application/json")]
        public async override  Task<ActionResult<ArticleResponse>> HandleAsync([FromRoute] ArticleRequest request,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return await Task.Run(() =>
                new OkObjectResult(new ArticleResponse
                {
                    Content = "blah blah blah blah blah ",
                    Description = "This is a Fine Description",
                    Published = DateTime.Now,
                    Summary = "this is a fine Summary",
                    SubHeading = "This is a sub heading"

                }), cancellationToken);

        }
    }
}
