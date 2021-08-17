using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* A Scriptable Object to define anything that uses the Consumable script. Geared primarily toward store-bought Equipment like the
 * Smudge Sticks, Sanity Pills, Crucifix, and Photo Camera.
 */
[CreateAssetMenu(fileName = "New Consumable Type", menuName = "Consumable")]
public class ConsumableType : ScriptableObject
{
    public int consumableUses;

}
