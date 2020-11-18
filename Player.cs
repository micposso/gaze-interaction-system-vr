using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// need something to track the state outside the class

public enum InputMode
{
    NONE,
    TELEPORT,
    WALK,
    STEPS,
    TELEPORTSPOT
}

public class Player : MonoBehaviour
{   
    // singleton design pattern. only one instance of the class. allow the class to be accessed from anywhere in the code

    public static Player instance;

    public GameObject teleport;

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
      TryStep();
    }

    public void TryWalk()
    {
        if (Input.GetMouseButton(0) && activeMode == InputMode.WALK)
        {
            print("walking");
            Vector3 forward = Camera.main.transform.forward;

            Vector3 newPosition = transform.position + forward * Time.deltaTime * playerSpeed;

            transform.position = newPosition;

        }
    }

    public void TryStep()
    {
        if (Input.GetMouseButton(0) && activeMode == InputMode.STEPS)
        {
            print("steps");
            Vector3 forward = Camera.main.transform.forward / 3;
            print(forward);
            Vector3 newPosition = transform.position + forward;

            transform.position = newPosition;

        }
    }

}
