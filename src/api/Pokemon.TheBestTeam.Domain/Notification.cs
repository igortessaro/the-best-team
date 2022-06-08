using System.Collections.ObjectModel;

namespace Pokemon.TheBestTeam.Domain;

public sealed class Notification
{
    private readonly IList<string> _erros = new List<string>();

    public Notification()
    {
    }

    public Notification(object data)
        : this()
    {
        this.Data = data;
    }

    public object? Data { get; set; }

    public IReadOnlyCollection<string> ValidationMessages => new ReadOnlyCollection<string>(this._erros);

    public bool IsValid => !ValidationMessages.Any();

    public Notification AddValidation(string message)
    {
        this._erros.Add(message);
        return this;
    }

    public Notification SetData(object data)
    {
        this.Data = data;
        return this;
    }
}
