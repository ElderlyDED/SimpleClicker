using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class PlayerResources : MonoBehaviour
{
    [field: SerializeField] public IntReactiveProperty BitCount { get; private set; } = new();
    void Start()
    {
        
    }

    public void PlusBit(int plusBitCount) => BitCount.Value += plusBitCount;
    public void MinusBit(int minusBitCount) => BitCount.Value -= minusBitCount;



}
