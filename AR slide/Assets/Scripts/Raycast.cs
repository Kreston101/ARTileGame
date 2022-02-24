using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject arCamera;
    SlideControl slideControl;

    private string[] names = {"RedCube", "OrangeCube", "YellowCube",
        "GreenCube", "LBlueCube", "BlueCube", "PinkCube", "PurpleCube"};

    void Start()
    {
        slideControl = FindObjectOfType(typeof(SlideControl)) as SlideControl;
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Select();
                    break;
                case TouchPhase.Ended:
                    slideControl.DisableRB();
                    break;
            }
        }
    }
    public void Select()
    {
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out RaycastHit hit))
        {
            foreach (string i in names)
            {
                if (hit.transform.name == i)
                {
                    hit.rigidbody.isKinematic = false;
                }
            }
        }
    }
}