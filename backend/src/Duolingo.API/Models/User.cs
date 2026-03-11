using System;

namespace Duolingo.API.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}
