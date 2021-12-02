using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolim : MonoBehaviour
{
    float instanciado;
    // Start is called before the first frame update
    void Start()
    {
        instanciado = Time.time;
        transform.position = new Vector3(-18, -13, 0);
        transform.Rotate(0, 0, 180);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time)*0.2f, 0, 0);
        destruirTrampolim();
    }
    public void destruirTrampolim()//Destroi o trampolim após as condições estabelecidas
    {
        if(Time.time - instanciado >= 10)
        {
            Destroy(gameObject);
        }
    }
    
}
//Powerup que faz as palavras começarem uma nova parabola a partir da altura dele