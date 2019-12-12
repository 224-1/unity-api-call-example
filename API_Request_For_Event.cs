using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Networking;
// commented code is only for console output not for API
public class firsttry : MonoBehaviour
{
    public Event e;
    void Start()
    {
    }
    void Update () {
     bool x=Input.anyKeyDown;
        if (x) {
            StartCoroutine(OnGUI ());
        }
}
     IEnumerator OnGUI () {
        //creating web object
        WWWForm form = new WWWForm();
        //for storing the event
        e = Event.current;
        //for keyborad event
        if(Event.current!=null){
            if (e.isKey)
            {
                //storing the key in string fromat
                string key = e.keyCode.ToString();
                Debug.Log(key);
                //adding the key in string format
                form.AddField("my event",key);
                //sending post request
                UnityWebRequest www = UnityWebRequest.Post("http://www.my-server.com/myform", form);
                yield return www.SendWebRequest();
                if (www.isNetworkError || www.isHttpError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("Form upload complete!");
                }
            }
            //for mouse events
            else if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("Left Click");
                form.AddField("my event","Left Click");
                //sending post request
                UnityWebRequest www = UnityWebRequest.Post("http://www.my-server.com/myform", form);
                yield return www.SendWebRequest();
                if (www.isNetworkError || www.isHttpError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("Form upload complete!");
                }
            }
            else if(Input.GetMouseButtonDown(1))
            {
                Debug.Log("Right Click");
                form.AddField("my event","Right Click");
                //sending post request
                UnityWebRequest www = UnityWebRequest.Post("http://www.my-server.com/myform", form);
                yield return www.SendWebRequest();
                if (www.isNetworkError || www.isHttpError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("Form upload complete!");
                }
            }
            else;
        }
    }
}

/* this is code for just console output*/


/*
public class firsttry : MonoBehaviour
{
    public Event e;
    void Start()
    {
    
    }
    void Update () {
     bool x=Input.anyKeyDown;
        if (x) {
            OnGUI ();
        }
}
 
     void OnGUI () {
        //for storing the event
        e = Event.current;
        //for keyborad event
        if(Event.current!=null){
        if (e.isKey){
            string key = e.keyCode.ToString();
            Debug.Log(key);
        }
        //for mouse events
        else if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click");
        }
        else if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Click");
        }
        else;
        }
    }
}
*/