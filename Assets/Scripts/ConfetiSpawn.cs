using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfetiSpawn : MonoBehaviour
{
    public GameObject cubePrefab,clone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            clone = Instantiate(cubePrefab, transform.position, Quaternion.identity);
            Destroy(clone, 3);
        }
    }
    

    //void OnCollision(Collision col)
    //{
    //    if (col.gameObject.name == "ConfetiCollisioner")
    //    {
    //        clone = Instantiate(cubePrefab, transform.position, Quaternion.identity);
    //        Destroy(clone, 3);
            
    //    }
    //}
}
