using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MagnifyHandler : MonoBehaviour
{
    public Camera magnifyCamera;
    public GameObject magnifierObject;
    Vector2 mousePos = new Vector2(0,0);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Mouse.current.position.ReadValue();
        Vector3 temp = new Vector3(mousePos.x, mousePos.y, magnifierObject.transform.position.z);

        magnifierObject.transform.position = temp;
    }
}
