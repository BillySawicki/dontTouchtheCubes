using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawn Cube Object")]
    //cube that is going to be spawned
    public GameObject spawnCube;
    //difficulty of the game 
    [Header("Default Difficulty")]
    public float difficulty = 40f;
    //time for the next cube
    //to be spawned 
    float spawn; 

    // Update is called once per frame
    void Update()
    {
        //the next cube to spawn will 
        //be based on the difficulty and 
        //game speed 
        spawn = difficulty * Time.deltaTime;
        //difficukty of the game is based on 
        //speed of the gamne times 4
        difficulty = Time.deltaTime * 4f; 
        //while loop for spawning cubes 
        //if the spawn time is greater 
        //than 0 
        while(spawn > 0){
            //spawn time minus 1
            spawn -= 1; 
            //random position of the cubes on the x and z axis 
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40f -20f, 0, Random.value * 40f - 20f);
            //random rotation of the cubes on the x and z axis 
            Quaternion qRotation = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            //Random scale of cubes on the x and z axie
            GameObject createObject = Instantiate(spawnCube, v3Pos, qRotation);
        }
    }
}
