using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ClickHandler : MonoBehaviour
{
    [Inject] InputHandler _inputHandler;
    
    void Start()
    {
    }

    void OnEnable()
    {
        _inputHandler.click += ClickOnObject;
    }

    void OnDisable()
    {
        _inputHandler.click -= ClickOnObject;
    }

    void ClickOnObject()
    {
        Debug.Log("Click");
   
    }
}
