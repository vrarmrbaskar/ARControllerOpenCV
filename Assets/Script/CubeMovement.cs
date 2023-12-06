using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update

    // UpdReceive class instance
    public UDPReceive udpReceive;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Receive data from UDP
        string data = udpReceive.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);
        // Receiving data in the format of  X - Co-ordinate , Y-Co-ordinate and Area as Y -co-ordinate
        //(255,361,50012) example data (x,y,area)
        string[] info = data.Split(',');

        float x = 5 - float.Parse(info[0]) / 100;
        float y = float.Parse(info[1]) / 100;
        float z = -2 + float.Parse(info[2]) / 1000;

        // Instance of the gameObj ,whose Postion would be updated
        gameObject.transform.localPosition = new Vector3(x, y, z);
        gameObject.transform.localEulerAngles = new Vector3(x*10, y*10, z);


    }
}

