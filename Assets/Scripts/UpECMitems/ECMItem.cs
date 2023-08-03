using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class ECMItem : MonoBehaviour
{
    [Inject] PlayerResources _playerResources;
    [SerializeField] int _ecmCoast;
    [SerializeField] int _clickCoast;
    [SerializeField] string _ecmID;
    [SerializeField] string _ecmName;

    [SerializeField] TextMeshProUGUI _nameECMitem;
    [SerializeField] TextMeshProUGUI _btnText;
    void Start()
    {
        if (PlayerPrefs.GetInt(_ecmID) == 1)
            _btnText.text = "SOLD";
        _nameECMitem.text = _ecmName;
    }

    public void BuyECMbtn()
    {
        if (PlayerPrefs.GetInt(_ecmID) == 0 && _playerResources.BitCount.Value >= _ecmCoast)
        {
            _playerResources.MinusBit(_ecmCoast);
            PlayerPrefs.SetInt("NowClickCoast", _clickCoast);
            PlayerPrefs.SetInt(_ecmID, 1);
        }
        else
        {
            Debug.Log("No Bits");
        }
    }
}
