using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPs : MonoBehaviour
{
    public GameObject lifeunit;
    GameObject lifeUnitAtual;
    GameObject vida;
    Vida sVida;
    // Start is called before the first frame update
    void Start()
    {
        vida = GameObject.Find("Vida");
        sVida = vida.GetComponent<Vida>();

        transform.position = vida.transform.position;

        Transform transformPDV;
        transformPDV = vida.transform;

        for (int i = 1; i <= sVida.lifepoints; i++)
        {
            lifeUnitAtual = Instantiate(lifeunit, this.transform);
            lifeUnitAtual.transform.position = vida.transform.position + new Vector3((sVida.espacoParaDistribuicao / sVida.lifepoints) * i, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//Atribui objeto a cada ponto de vida do usuario