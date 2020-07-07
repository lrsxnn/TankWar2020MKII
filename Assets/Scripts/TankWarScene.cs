using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class TankWarScene : MonoBehaviour
{

    Socket socket = null;
    //public InputField inputField;
    //public Text text;

    public void OnClickConnection()
    {
        IPHostEntry hostEntry = Dns.GetHostEntry("dztest.runfagame.cn");
        IPEndPoint ipEndPoint = new IPEndPoint(hostEntry.AddressList[0], 0);


        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        try
        {
            //socket.Connect(ipEndPoint.Address.ToString(), 26379);
            socket.Connect("127.0.0.1", 8888);
            UnityEngine.Debug.Log("Connected"+socket.Connected);
        }
        catch(SocketException e)
        {
            UnityEngine.Debug.Log(e.ToString());
            return;
        }

        //socket.Close();
    }

    public void OnClickSend()
    {
        if(socket != null)
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
