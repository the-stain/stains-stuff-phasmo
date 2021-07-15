using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * Detector.cs allows for detection of anomalies, ideally by both Equipment objects and Ghosts.
 * Currently built just for temp anomalies for the purpose of understanding how to use raycasts.
 */

public class Detector : MonoBehaviour
{
    [SerializeField]
    private float minInteractionDistance;

    [SerializeField]
    private GameObject rayOrigin;

    private Ray ray;
    private Anomaly currentReceiver;
    public float anomalyTemp;

    // Update is called once per frame
    void Update()
    {
        CheckRaycast();
    }

    private void CheckRaycast()
    {
        ray = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.distance < minInteractionDistance)
            {


                currentReceiver = hit.transform.gameObject.GetComponent<Anomaly>();

                if (currentReceiver != null)
                {
                    anomalyTemp = currentReceiver.GetComponent<Anomaly>().temp;
                }
            }
        }
    }
}
