using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class Movement : MonoBehaviour
{
    [Tooltip("Step size in meters")][SerializeField] float speed= 10f;

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);
    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);
    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);
    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);

    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();
    }

    void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
        moveLeft.Disable();
        moveRight.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp.IsPressed())
        {
            transform.position += new Vector3(0, speed* Time.deltaTime, 0);
        }
        else if (moveDown.IsPressed())
        {
            transform.position += new Vector3(0, -speed* Time.deltaTime, 0);
        }
        else if (moveLeft.IsPressed())
        {
            transform.position += new Vector3(-speed* Time.deltaTime, 0, 0);
            if (GetComponent<SpriteRenderer>().flipX == false)
                GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (moveRight.IsPressed())
        {
            transform.position += new Vector3(speed* Time.deltaTime, 0, 0);
            if (GetComponent<SpriteRenderer>().flipX == true)
                GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
