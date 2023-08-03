using UnityEngine;
using Zenject;

public class PlayerResourcesMonoInstaller : MonoInstaller
{
    [SerializeField] PlayerResources _playerRecources;
    public override void InstallBindings()
    {
        var playerResourcesInstance = Container.InstantiatePrefabForComponent<PlayerResources>(_playerRecources);
        Container.Bind<PlayerResources>().FromInstance(playerResourcesInstance).AsSingle();
    }
}