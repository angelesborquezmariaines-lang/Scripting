using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC Health
    public int health = 5;

    //NPC Level
    public int level = 1;

    //NPC Speed
    public float speed = 1.2f;


    // Start is called before the first frame update
    void Start()
    {
        //Adds the value of the level to the health
        health += level;

        //Outputs the health of the NPC to the console
        print("NPC health:"+ health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition =transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
