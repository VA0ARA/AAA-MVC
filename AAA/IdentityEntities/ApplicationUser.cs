using Microsoft.AspNetCore.Identity;
using System;

namespace AAA.IdentityEntities
{
 public class ApplicationUser : IdentityUser<Guid>
 {
  public string? PersonName { get; set; }
 }
}
