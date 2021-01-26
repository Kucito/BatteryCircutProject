using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool connected;
    private bool on;
    private bool isInput;

    public Pin(bool connected, bool on, bool isInput){
        this.connected = connected;
        this.on = on;
        this.isInput = isInput;
    }

    public Pin(){
        this.connected = false;
        this.on = true;
        this.isInput = true;
    }

    public void SetConnected(bool connected)
    {
        this.connected = connected;
    }

    public bool GetConnected()
    {
        return connected;
    }
    
    public void SetOn(bool on)
    {
        this.on = on;
    }

    public bool GetOn()
    {
        return on;
    }
    
    public void IsInput(bool isInput)
    {
        this.isInput = isInput;
    }

    public bool IsInput()
    {
        return isInput;
    }
}
