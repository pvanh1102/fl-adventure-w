using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempos;
    private string PLAYER_TAG = "Player";
    [SerializeField] private float minX = -465;
    [SerializeField] private float maxX = 465;
    // Start is called before the first frame update
    void Start()
    {
        //Đoạn này dùng để gắn vị trí vào với vị trí của nhân vật or lấy vị trí của nhân vật
        player = GameObject.FindWithTag(PLAYER_TAG).transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!player)//giống với player == null
        {
            return;
        }
        tempos = transform.position;// biến tạm thời = vị trí của camera
        tempos.x = player.position.x;// Lấy vị trí theo trục X thôi vì camera di chuyển theo chiều ngang
        if(tempos.x < minX ) { tempos.x = minX;}//Dòng này và dong dưới để ngăn không cho camera đi ra khỏi màn hình
        if(tempos.x > maxX ) { tempos.x = maxX;}
        transform.position = tempos;// thay đổi vị trí của camera
    }
}
