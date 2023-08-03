using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusSwitcher : MonoBehaviour
{
    [SerializeField] Transform _extractionPanel;
    [SerializeField] Transform _ecmPanel;
    [SerializeField] Transform _upgradePanel;
    [SerializeField] Transform _statisticPanel;

    public void ActivExtarictionPanel()
    {
        _extractionPanel.gameObject.SetActive(true);
        _ecmPanel.gameObject.SetActive(false);
        _upgradePanel.gameObject.SetActive(false);
        _statisticPanel.gameObject.SetActive(false);
    }

    public void ActivECMPanel()
    {
        _extractionPanel.gameObject.SetActive(false);
        _ecmPanel.gameObject.SetActive(true);
        _upgradePanel.gameObject.SetActive(false);
        _statisticPanel.gameObject.SetActive(false);
    }

    public void ActivUpgradePanel()
    {
        _extractionPanel.gameObject.SetActive(false);
        _ecmPanel.gameObject.SetActive(false);
        _upgradePanel.gameObject.SetActive(true);
        _statisticPanel.gameObject.SetActive(false);
    }

    public void ActivStatisticPanel()
    {
        _extractionPanel.gameObject.SetActive(false);
        _ecmPanel.gameObject.SetActive(false);
        _upgradePanel.gameObject.SetActive(false);
        _statisticPanel.gameObject.SetActive(true);
    }
}
