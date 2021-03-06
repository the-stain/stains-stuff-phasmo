using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A Scriptable Object that holds data for anything using the Detector component. Ideally built to accommodate Equipment objects (like 
 * the EMF Reader) and Ghost behaviors (like the Hantu's heat-responsive movement speed).
 */
[CreateAssetMenu(fileName = "New Detection Type", menuName = "Detector")]
public class DetectorType : ScriptableObject
{
    public float detectPingInterval; // allows for a custom rate of detection querying

}
