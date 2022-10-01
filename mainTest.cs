using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
       // SatelliteInfoGraber test = GetComponent<SatelliteInfoGraber>();  
        SateliteInfoGraber test2 = new SateliteInfoGraber();
        SateliteData data = test2.createDataFromJSON();
        Debug.Log(data.name + " " + data.id + " " + data.latitude);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
