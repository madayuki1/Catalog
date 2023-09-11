using System;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public String Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}