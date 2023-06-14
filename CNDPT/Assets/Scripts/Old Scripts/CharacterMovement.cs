using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField] protected Vector3 worldPos;                                                        //tạo biến để lấy giá trị của con trỏ chuột
    [SerializeField] public float speed = 0.5f;                                                         // biến này là tốc độ di chuyển của vật chủ theo con trỏ
    private void FixedUpdate()
    {
        this.worldPos = InputManager.instance.mouseWorldPos;                                            // lấy vị trí của chuột
        this.worldPos.z = 0;                                                                            // vì làm trên môi trường 2D nên fix cứng luôn tọa độ z = 0 (vì tọa độ này dùng trong môi trường 3D)
        Vector3 newposition = Vector3.Lerp(transform.parent.position, this.worldPos, speed);            // tạo 1 biến mới có kiểu là vector3, biến này để nhận giá trị vị trí của chuột
        transform.parent.position = newposition;                                                        // biến vị trí hiện tại thành vị trí của biến vừa lấy, lấy .parent để tương tác với obj cha của nó, là knight nhiều hơn
    }
}
