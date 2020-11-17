using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// need something to track the state outside the class

public enum InputMode
{
    NONE,
    TELEPORT,
    WALK
}

public class Player : MonoBehaviour
{   
    // singleton design pattern. only one instance of the class. allow the class to be accessed from anywhere in the code

    public static Player instance;

    public InputMode activeMode = InputMode.NONE;
    // Start is called before the first frame update

    // runs when the gameobject appears on the scene before start
    void Awake() 
    {
        // check if there is another player, and destroy it
        if(instance != null) 
        {
            GameObject.Destroy(instance.gameObject);
        }
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
