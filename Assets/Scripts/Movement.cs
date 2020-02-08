using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

<<<<<<< HEAD
    public void Move(string direction)
=======
    // Start is called before the first frame update
    void Start()
    {
        Move(Direction.East);
        Move(Direction.East);
        Move(Direction.East);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(Direction dir)
>>>>>>> f0f2aca61493527db205031de5977899e57d484e
    {
        switch(dir)
        {
            case Direction.East:
                playerObject.transform.Translate(Vector3.forward);
                break;
        }
    }
}

public enum Direction
{
    East,
    North,
    South,
    West
}