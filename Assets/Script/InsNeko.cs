using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsNeko : MonoBehaviour
{
    public GameObject nekoPrefab;
    GameObject nekoAtual;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void instanciarNeko()
    {
        nekoAtual = Instantiate(nekoPrefab, transform.position, Quaternion.identity);
    }
}
