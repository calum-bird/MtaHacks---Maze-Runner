using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float units;

    public void Move(string direction)
    {
        switch(direction)
        {
            case "north":
                transform.Translate(Vector3.up  * units);
                break;
            case "east":
                transform.Translate(Vector3.right  * units);
                break;
            case "south":
                transform.Translate(Vector3.down  * units);
                break;
            case "west":
                transform.Translate(Vector3.left  * units);
                break;
        }
    }
}