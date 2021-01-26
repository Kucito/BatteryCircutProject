using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOT_gate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chip.PinLength()/2-1; i+=3)
        {
            if ((chip.GetPin(i).IsInput() && chip.GetPin(i + 1).IsInput()) && (chip.GetPin(i).GetOn() && chip.GetPin(i + 1).GetOn()))
            {
                chip.GetPin(i+2).SetOn(false);
            }
            else
            {
                chip.GetPin(i+2).SetOn(true);
            }
        }
        for (int i = chip.PinLength()/2+1; i < chip.PinLength()-2; i+=3)
        {
            if ((chip.GetPin(i).IsInput() && chip.GetPin(i + 1).IsInput()) && (chip.GetPin(i).GetOn() && chip.GetPin(i + 1).GetOn()))
            {
                chip.GetPin(i+2).SetOn(false);
            }
            else
            {
                chip.GetPin(i+2).SetOn(true);
            }
        }
    }
}