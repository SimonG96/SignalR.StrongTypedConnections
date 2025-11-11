// Author: Simon.Gockner
// Created: 2025-09-02
// Copyright(c) 2025 SimonG. All Rights Reserved.

using Debug.SignalR.StrongTypedConnections.SampleClasses;
using Microsoft.AspNetCore.SignalR.Client;
using SignalR.StrongTypedConnections.Generators;

namespace Debug.SignalR.StrongTypedConnections;

public class Sample
{
    private ISampleHub _connection = new HubConnectionBuilder().Build().ToStrongTypedHub<ISampleHub>();
    private ISecondHub _secondConnection = new HubConnectionBuilder().Build().ToStrongTypedHub<ISecondHub>();
}