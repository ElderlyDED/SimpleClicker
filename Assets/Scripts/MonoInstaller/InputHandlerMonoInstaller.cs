using UnityEngine;
using Zenject;

public class InputHandlerMonoInstaller : MonoInstaller
{
    [SerializeField] InputHandler _inputHandler;
    public override void InstallBindings()
    {
        var inputHandlerInstance = Container.InstantiatePrefabForComponent<InputHandler>(_inputHandler);
        Container.Bind<InputHandler>().FromInstance(inputHandlerInstance).AsSingle();
    }
}