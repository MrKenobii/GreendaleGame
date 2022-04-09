using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    { 
        Instantiate(Player, new Vector2(-7.78f,-3.46f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
