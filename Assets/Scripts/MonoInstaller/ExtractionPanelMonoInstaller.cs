using UnityEngine;
using Zenject;

public class ExtractionPanelMonoInstaller : MonoInstaller
{
    [SerializeField] ExtractionPanel _extractionPanel;
    public override void InstallBindings()
    {
        Container.Bind<ExtractionPanel>().FromInstance(_extractionPanel).AsSingle();
    }
}