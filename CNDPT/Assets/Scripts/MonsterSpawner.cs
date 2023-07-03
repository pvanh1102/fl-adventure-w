using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;
    
    [SerializeField]
    private Transform leftPos, rightPos;
    
    private int randomIndex;
    private int randomSide;
    [SerializeField]//Để SerializeField để tùy chỉnh từng màn
    private int secondMin;
    [SerializeField]
    private int secondMax;
    private int monsterScale;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
        
    }
    IEnumerator SpawnMonster() 
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(secondMin, secondMax));//trả về số giây để respawn monster
            
            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);
            
            spawnedMonster = Instantiate(monsterReference[randomIndex]);//Instantiate sẽ trả về bản copy của obj mà ta truyền vào

            monsterScale = -40;
            //left
            if (randomSide == 0)
            {
                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(3, 7);
            }
            else
            {
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(3, 7);
                if (spawnedMonster.name == "Bug(Clone)"||spawnedMonster.name == "Slime(Clone)")
                {
                    monsterScale = 40;
                }     
                spawnedMonster.transform.localScale = new Vector3(monsterScale, 40, 0);
             //right
            }
        }   
    }
}
