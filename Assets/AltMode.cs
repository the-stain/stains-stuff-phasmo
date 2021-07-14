using UnityEngine;

// AltMode is a class (typically utilized by Equipment objects) that provides an on/off control for scripts used in this prefab.
// To use:
//      1. Create a child object of this script's object.
//      2. Attach the script to be controlled to the child.
//      3. Set that child object as this script's "Control Target" in the Inspector.
// Be aware that this script deactivates the entire object, so any script attached will be inactive.
// Also note that this script is intended to control scripts that are constantly running (like Detector.cs).
// Your mileage may vary with other kinds of scripts (like Consumable.cs).
public class AltMode : MonoBehaviour, IAction
{
    // controlTarget SHOULD be a child of this script's object, but it COULD be something else technically
    // That seems insecure, but I'd rather not restrict the type without good reason
    GameObject controlTarget;
    bool isModeOn;

    public void Activate()
    {
        if(isModeOn)
        {
            controlTarget.SetActive(false);
            isModeOn = false;
        }
        else
        {
            controlTarget.SetActive(true);
            isModeOn = true;
        }
    }
}
