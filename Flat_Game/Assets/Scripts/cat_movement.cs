using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_movement : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    public Transform catTransform;
    private bool check_left = false;
    private bool check_right = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            catTransform.position = new Vector3(transform.position.x - movementSpeed, transform.position.y, transform.position.z);
            GetComponent<Animator>().Play("left_walk");
            check_left = true;
            check_right = false;
            // transform.Translate(Vector3.left*movementSpeed);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            catTransform.position = new Vector3(transform.position.x + movementSpeed, transform.position.y, transform.position.z);
            GetComponent<Animator>().Play("right_walk");
            check_right = true;
            check_left = false;
        }
        /* else if(Input.GetKey(KeyCode.UpArrow)){
            personTransform.position = new Vector3(transform.position.x, transform.position.y + movementSpeed, transform.position.z);
            GetComponent<Animator>().Play("back_walk_ani");
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            personTransform.position = new Vector3(transform.position.x, transform.position.y - movementSpeed, transform.position.z);
            GetComponent<Animator>().Play("front_walk_ani");
        }
        */
        else if(check_left){
            GetComponent<Animator>().Play("left_still");
        }
        else if(check_right){
            GetComponent<Animator>().Play("right_still");
        }
    }
}