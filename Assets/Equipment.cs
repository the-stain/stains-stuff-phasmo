using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Equipment.cs is a simple class used to define all the Equipment objects in the game.
 */
public class Equipment : MonoBehaviour
{
    public string ownerName; // Player ID of the owner of this instance. Used when despawning equipment of a player who has DCed from a mission.
    EquipmentType equipmentType;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
