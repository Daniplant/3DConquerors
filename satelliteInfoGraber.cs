using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;


[System.Serializable]
public struct SateliteData{
    
    public string name;
    public int id;
    public float latitude;
    public float longitute;
    public float altitude;
    public float velocity;
    public string visibility;
    public float footprint;
    public double timestamp;
    public float daynum;
    public float solar_lat;
    public float solar_lon; 
    public string units;

}

//[System.Serializable]
public class SateliteInfoGraber
{

    // longitute, latitude
    public string getJsonStringTo(string link){
        WebClient client = new WebClient();
        Debug.Log(client.DownloadString(link));
        return client.DownloadString(link);
    }


    public SateliteData createDataFromJSON()
    {
        //Debug.Log(JsonUtility.FromJson<SatelliteInfoGraber>(getJsonStringTo("https://api.wheretheiss.at/v1/satellites/25544")));
        return JsonUtility.FromJson<SateliteData>(getJsonStringTo("https://api.wheretheiss.at/v1/satellites/25544"));
        //return (SateliteData)JsonUtility.FromJson(getJsonStringTo("https://api.wheretheiss.at/v1/satellites/25544"), typeof(SateliteData));
    }
}