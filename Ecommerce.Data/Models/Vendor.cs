using System;
using System.Collections.Generic;

namespace Ecommerce.Data.Models;

public partial class Vendor
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string BusinessType { get; set; } = null!;

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Pincode { get; set; } = null!;

    public Guid CategoryId { get; set; }

    public DateOnly CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Category Category { get; set; } = null!;
}
