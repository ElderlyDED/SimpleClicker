using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ExtractionPanel : MonoBehaviour, IExtraction
{
    [Inject] PlayerResources _playerResources;

    void Start()
    {
        
    }

    public void Extraction()
    {
        _playerResources.PlusBit(1 + PlayerPrefs.GetInt("NowClickCoast"));
    }
}
