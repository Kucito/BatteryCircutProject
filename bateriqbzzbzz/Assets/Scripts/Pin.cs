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

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("JumperHead attached...");
        if (other.gameObject.CompareTag("jumperFemale") && !GetConnected())
        {
            this.SetConnected(true);
            Vector3 getPinRotation = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 180, gameObject.transform.eulerAngles.z);
            Vector3 getPinPosition = new Vector3(gameObject.transform.position.x - 0.045f, gameObject.transform.position.y, gameObject.transform.position.z);
            other.gameObject.transform.parent = gameObject.transform;
            other.gameObject.transform.eulerAngles = getPinRotation;
            other.gameObject.transform.position = getPinPosition;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
    
    void OnTriggerExit(Collider collider)
    {
        /*
        if (collider.gameObject.tag == "jumperFemale" && this.GetConnected())
        {
            collider.transform.parent = null;
            collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            collider.gameObject.GetComponent<Collider>().enabled = true;
            this.SetConnected(false);
        }
        */
    }
}
