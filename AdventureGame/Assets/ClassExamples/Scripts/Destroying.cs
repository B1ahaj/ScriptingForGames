using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Util/Destruction Util")]
public class Destroying: ScriptableObject
{
    public void Destroyer(GameObject gameObject)
    {
        Object.Destroy(gameObject);
    }
}
