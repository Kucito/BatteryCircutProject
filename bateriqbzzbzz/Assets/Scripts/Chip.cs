using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Chip : MonoBehaviour
{
    private int pinsNum;
    private Pin[] pins;

    public Chip(int pinsNum)
    {
        this.pinsNum = pinsNum;
        pins = new Pin[this.pinsNum];
        for (int i = 0; i < pins.Length; i++)
        {
            pins[i] = new Pin();
        }
        
        for (int i = 0; i < pins.Length / 2 - 1; i+=3)
        {
            pins[i].IsInput(true);
            pins[i+1].IsInput(true);
            pins[i+2].IsInput(false);
        }        
        for (int i = pinsNum / 2 + 1; i < pins.Length; i+=3)
        {
            pins[i].IsInput(true);
            pins[i+1].IsInput(true);
            pins[i+2].IsInput(false);
        }

        pins[pinsNum / 2-1].IsInput(false);
        pins[pinsNum / 2].IsInput(false);
    }

    public Pin GetPin(int i)
    {
        return pins[i];
    }

    public void SetPinLength(int pinsNum)
    {
        this.pinsNum = pinsNum;
    }
    
    public int PinLength()
    {
        return pinsNum;
    }
}
