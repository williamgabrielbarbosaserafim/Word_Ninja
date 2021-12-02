using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorGato : MonoBehaviour
{
    GameObject nekoAtual;
    public GameObject nekoPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time % 2 == 0)
        {
            instanciarNeko();
        }
    }
    void instanciarNeko()
    {
        nekoAtual = Instantiate(nekoPrefab, transform.position, Quaternion.identity);
        nekoAtual.transform.Rotate(-180, 0, 180);
    }
}
