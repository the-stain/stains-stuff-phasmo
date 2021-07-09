using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                    anomalyTemp = currentReceiver.GetComponent<Anomaly>().floatValue;
                }
            }
        }


    }
}
