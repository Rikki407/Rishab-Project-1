using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;


public class timeTeller : MonoBehaviour
{
    public GameObject timeTextObject;
    //public static TimeZoneInfo FindSystemTimeZoneById (string id);
    string url = "https://worldtimeapi.org/api/timezone/Europe/Prague";

    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 1f);   
    }

   
    void UpdateTime()
    {
        StartCoroutine(getRequest(url));
    }

    IEnumerator getRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                int startTime = webRequest.downloadHandler.text.IndexOf("T",webRequest.downloadHandler.text.IndexOf("datetime",0));
                int endTime = startTime + 8;
                string time = webRequest.downloadHandler.text.Substring(startTime+1,8);
                timeTextObject.GetComponent<TextMeshPro>().text = "" + time;
            }
        }
    }
}
