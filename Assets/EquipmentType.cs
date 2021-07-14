using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A Scriptable Object for all the Equipment that can be bought by players and brought on contracts.
 */
public class EquipmentType : ScriptableObject
{
    string displayName;
    Mesh displayMesh;
    int storeCost;
    int missionMax;
}
