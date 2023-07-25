using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    CompositeDisposable _disposable = new();

    public delegate void Click();
    public event Click click;

    void Start() => Observable.EveryUpdate().Subscribe(v => {
        if(Input.GetMouseButtonDown(0))
            click?.Invoke();
    }).AddTo(_disposable);
}
