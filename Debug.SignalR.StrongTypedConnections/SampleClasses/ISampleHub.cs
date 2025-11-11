// Author: Simon.Gockner
// Created: 2025-09-02
// Copyright(c) 2025 SimonG. All Rights Reserved.

using SignalR.StrongTypedConnections;

namespace Debug.SignalR.StrongTypedConnections.SampleClasses;

public interface ISampleHub : IStrongHub<ISampleClient>
{
    Task Handshake(Guid? receivedClientId);
    Task SendData(Guid clientId, string data);
}

public interface ISecondHub : IStrongHub<ISampleClient>
{
    Task Handshake(Guid? receivedClientId);
    Task ReceiveData(Guid clientId, string data);
}