using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsRaio : MonoBehaviour
{
    public GameObject raioPreset;
    GameObject raioAtual;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetMouseButtonDown(0));
        instanciarRaio();
        
    }
    void instanciarRaio()
    {

        raioAtual = Instantiate(raioPreset, transform.position, Quaternion.identity);
    }
    
}
