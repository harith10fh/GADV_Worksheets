using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Stat()
    {
        Player player = new Player(10);
        player.TakeDamage(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
