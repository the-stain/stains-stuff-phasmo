using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detector : MonoBehaviour
{
    [SerializeField]
    private float minInteractionDistance;

    [SerializeField]
    private GameObject rayOrigin;

    private Ray ray;
    private Anomaly currentReceiver;
    public float anomalyTemp;
    public Text tempDisplayUI;

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
