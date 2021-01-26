using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    private bool connected;

    private float mZCoord;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pin") && !other.gameObject.GetComponent<Pin>().GetConnected())
        {
            connected = true;
            Debug.Log("Dragging turned off...");
        }
    }

    void OnMouseDown()

    {
        if (!connected)
        {
            var position = gameObject.transform.position;
            mZCoord = Camera.main.WorldToScreenPoint(
                position).z;


            // Store offset = gameobject world pos - mouse world pos

            mOffset = position - GetMouseAsWorldPoint();
        }

    }


    private Vector3 GetMouseAsWorldPoint()

    {
        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;


        // z coordinate of game object on screen

        mousePoint.z = mZCoord;


        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }


    void OnMouseDrag()
    {
        if (!connected)
        {
            transform.position = GetMouseAsWorldPoint() + mOffset;
        }
    }
}