using System;
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

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("asdasd");
        if (collider.gameObject.tag == "jumperFemale" && !this.GetConnected())
        {
            collider.gameObject.transform.parent.position = gameObject.transform.position;
            this.SetConnected(true);
        }
    }
    
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("asdasd");
        if (collider.gameObject.tag == "jumperFemale" && this.GetConnected())
        {
            /*Vector3 asd = new Vector3(gameObject.transform.position.x+1,gameObject.transform.position.y,gameObject.transform.position.z);
            collider.gameObject.transform.position = asd;
            this.SetConnected(false);*/
        }
    }
}
