using Reflex.Core;
using UnityEngine;

public class ProjectInstaller
{
public void InstallBindings(ContainerBuilder builder) {
    builder.AddSingleton("Hello");
}
}
