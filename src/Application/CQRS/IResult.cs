namespace CleanArchitectureBDD.Application.CQRS;

public interface IResult
{
}

public interface IListResult : ICollection<IResult>
{
}
