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

    [SerializeField]
    private float playerSpeed = 3.0f;

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
      TryWalk();  
    }

    public void TryWalk()
    {
        if (Input.GetMouseButton(0) && activeMode == InputMode.WALK)
        {
            Vector3 forward = Camera.main.transform.forward;

            Vector3 newPosition = transform.position + forward * Time.deltaTime * playerSpeed;

        }
    }
}
