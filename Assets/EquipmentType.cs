using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A Scriptable Object for defining all of the Equipment that can be bought by players and brought on contracts.
 */
[CreateAssetMenu(fileName = "New Equipment Type", menuName = "Equipment")]
public class EquipmentType : ScriptableObject
{
    public string displayName;
    public Mesh displayMesh;
    public int storeCost;
    public int missionMax;
    public int correspondsTo; // the variable in PlayerData.cs to which this SO corresponds

    [TextArea(5,15)]
    public string description;

}
