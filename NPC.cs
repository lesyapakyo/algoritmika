using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC : MonoBehaviour
{
    //Çäîðîâüå NPC
    public int health = 5;

    //Óðîâåíü NPC
    public int level = 1;

    //Ñêîðîñòü NPC
    public float speed = 1.2f;

    void Start()
    {
            health += level;
            print("Æèçíåé:" + health);
    }

    void Update()
    {
            Vector3 newPosition = transform.position;
            newPosition.z += speed * Time.deltaTime;
            transform.position = newPosition;
    }
}
