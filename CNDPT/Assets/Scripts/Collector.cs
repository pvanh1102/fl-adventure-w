using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Mỗi khi có một vật thể nào được gắn tag là ENEMY mà va trạm với cái này thì sẽ bị phá hủy, cái này là thùng rác để ngăn lãng phí tài nguyên
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
           
        
    }
}
