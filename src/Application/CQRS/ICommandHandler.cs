﻿namespace CleanArchitectureBDD.Application.CQRS;

public interface ICommand
{ }

public interface ICommandHandler
{ }

public interface ICommandHandler<T> : ICommandHandler where T : ICommand
{
    Task Handle(T command);
}

public interface ICommandDispatcher
{
    void Send<T>(T command) where T : ICommand;
}
