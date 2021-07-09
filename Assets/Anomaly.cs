using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Anomalies are invisible "ghost events" (normally in the shape of a sphere) that spawn when a Ghost performs an activity. Anomalies typically interact
 * with Detectors to provide some form of information based on the specific DetectorType, which then informs Detector on how to calculate any received
 * values. Detector outputs the final value as a return, allowing it to be picked up by UI elements or even other things.
 */
public class Anomaly : MonoBehaviour
{
    public float floatValue;

    private void Start()
    {
        GenTemp();
    }

    private void GenTemp()
    {
        floatValue = Random.Range(1.0f, 9.0f);
    }
}
