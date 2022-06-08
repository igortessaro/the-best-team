﻿namespace Pokemon.TheBestTeam.Domain.CQRS.Queries;

public sealed class TrainerSummaryQuery
{
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string NickName { get; set; } = string.Empty;
}
