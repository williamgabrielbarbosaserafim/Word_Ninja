using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalaSakura : MonoBehaviour
{
    ConstantForce cf;
    float randomForce;
    // Start is called before the first frame update
    void Start()
    {
        randomForce = Random.Range(10, 20);
        cf = GetComponent<ConstantForce>();
        cf.force = cf.force + new Vector3(randomForce, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        randomForce = Random.Range(7, 20);
       
        transform.Rotate(randomForce, 0, 0);
        destruirPetala();
    }
    void destruirPetala()
    {
        if(transform.position.x > 10)
        {
            DestroyImmediate(gameObject);
        }
    }
}
//Define a movimentação da petala de sakura do menu inicial