using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfetiSpawn : MonoBehaviour
{
    public GameObject cubePrefab,clone;
    public int cantmaxcubos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            int contador = 0;
            while (contador < cantmaxcubos)
            {
               clone = Instantiate(cubePrefab, transform.position, Quaternion.identity);
                contador++;
                Destroy(clone, 3);
            }
           

            //clone = Instantiate(cubePrefab, transform.position, Quaternion.identity);
            //Destroy(clone, 3);
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
