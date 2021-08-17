using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This is literally just an asset to hold a list of references to whatever. I made this solely because
 * I needed to have all of the EquipmentType assets in ShopDisplay.cs in order to create a ListItem prefab
 * for each one and I didn't want to figure out how to load them or wtf because apparently that's 
 * complicated so here
 */

[CreateAssetMenu(fileName = "New List", menuName = "List of Objects")]
public class ListSO : ScriptableObject
{
    public List<Object> stuffList;

}
