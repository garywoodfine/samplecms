using Microsoft.AspNetCore.Mvc;

namespace api.Endpoints.Article.Request
{
    public class ArticleRequest
    {
        [FromRoute(Name = "id")] public string Id { get; set; }
        [FromRoute(Name = "category")] public string Category { get; set; }
    }
}