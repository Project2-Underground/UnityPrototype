using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Inventory inventory;

    //moving
    [SerializeField]
    float moveSpeed;
    public Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //if (target.y > 2.0f) //set boundary for click to move
            //{
            //    target = transform.position;
            //}
            target.y = gameObject.transform.position.y;
            target.z = gameObject.transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
    }
}
