using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField] public static InputManager instance;
    [SerializeField] public Vector3 mouseWorldPos;

    private void Awake()
    {
        instance = this;
    }
    private void FixedUpdate()
    {
        this.GetMousePos();     

    }
    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);// lấy vị trí của chuột
    }
}
