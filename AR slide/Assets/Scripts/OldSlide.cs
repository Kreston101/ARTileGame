using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldSlide : MonoBehaviour
{
    private Rigidbody rb3d;
    private Vector2 startPos;
    private Vector2 direction;
    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Moved)
            {
                startPos = touch.position;
                direction = touch.position - startPos;
                rb3d.AddForce(new Vector2(direction.x, direction.y));
            }
        }
    }
}