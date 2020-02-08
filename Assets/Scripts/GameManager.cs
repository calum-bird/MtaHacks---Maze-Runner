using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    public bool hasMoves = false;
    public int numMoves = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasMoves && Input.GetKeyDown("w"))
        {
            Movement movement = player.GetComponent(typeof(Movement)) as Movement;
            if(movement != null)
            {
                movement.Move("Up");
                //TODO: Check if there is a wall next to us so
                //that we do not use up moves unintentionally
                numMoves--;
            }
        }
    }
}
