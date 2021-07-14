using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 07/11/2021
 * Instantiates one spawner at a specific location. Currently just for testing so I can
 * get my feet on the ground experimenting with Detector.cs
 */


public class AnomalySpawner : MonoBehaviour
{
    public Anomaly anomalyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Vector3 is just a random spot in the scene that was convenient
        Instantiate(anomalyPrefab, new Vector3(6.0f, 1.0f, 12.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
