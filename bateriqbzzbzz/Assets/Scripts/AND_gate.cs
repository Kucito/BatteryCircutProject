using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AND_gate : MonoBehaviour
{
    private Chip chip;
    public GameObject[] pins;
    
    // Start is called before the first frame update
    void Start()
    {
        chip = new Chip(14);

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chip.PinLength()/2-1; i+=3)
        {
            if ((chip.GetPin(i).IsInput() && chip.GetPin(i + 1).IsInput()) && (chip.GetPin(i).GetOn() && chip.GetPin(i + 1).GetOn()))
            {
                chip.GetPin(i+2).SetOn(true);
            }
            else
            {
                chip.GetPin(i+2).SetOn(false);
            }
        }
        for (int i = chip.PinLength()/2+1; i < chip.PinLength()-2; i+=3)
        {
            if ((chip.GetPin(i).IsInput() && chip.GetPin(i + 1).IsInput()) && (chip.GetPin(i).GetOn() && chip.GetPin(i + 1).GetOn()))
            {
                chip.GetPin(i+2).SetOn(true);
            }
            else
            {
                chip.GetPin(i+2).SetOn(false);
            }
        }
    }
}
