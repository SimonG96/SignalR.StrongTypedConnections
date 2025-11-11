// Author: Simon.Gockner
// Created: 2025-09-03
// Copyright(c) 2025 SimonG. All Rights Reserved.

namespace Debug.SignalR.StrongTypedConnections.SampleClasses;

public interface ISampleClient
{
    Task ReceivedHandshake(Guid clientId);
    Task ReceiveData(Guid clientId, string data);
}