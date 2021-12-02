using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poderes : MonoBehaviour
{
    public GameObject trampolimPrefab;
    GameObject trampolimAtual;
    public GameObject nekoPrefab;
    GameObject nekoAtual;
    public GameObject raioPrefab;
    GameObject raioAtual;
    GameObject botaoPW;
    BtnPower sBotaoPw;

    BoxCollider bc;

    public bool nekoInstanciado;
    public bool raioInstanciado;

    bool tocouOBotao = false;
    public int powerUp;
    // Start is called before the first frame update
    void Start()
    {
        botaoPW = GameObject.Find("BotaoPW");
        sBotaoPw = botaoPW.GetComponent<BtnPower>(); 
        bc = GetComponent<BoxCollider>();
        powerUp = 99;
    }

    // Update is called once per frame
    void Update()
    {
        if (sBotaoPw.usarPU)
        {
            for(int i = 0; i <1; i++)
            {
                listaPowerUps();
            }
        }
    }
    public void listaPowerUps()
    {
        if (powerUp <= 34 && powerUp > 0)
        {
            trampolimAtual = Instantiate(trampolimPrefab, new Vector3(-11.3f, 9.8f, 0), Quaternion.identity);
            Debug.Log("Trampolim Instanciado");
        }
        else if (powerUp <= 66)
        {
            nekoAtual = Instantiate(nekoPrefab, new Vector3(-9,-12,-0.59f), Quaternion.identity);
            nekoAtual.transform.localScale = new Vector3(5f, 5f, 4f);
            nekoAtual.transform.Rotate(-180, 0, 180);
        }
        else if (powerUp <= 100)
        {
            for (int i = 0; i < 2; i++)
            {
                raioAtual = Instantiate(raioPrefab, transform.position, Quaternion.identity);
                raioAtual.transform.position = new Vector3(0, 20, 0);
            }
            Debug.Log("Raio Instanciado");
        }
        sBotaoPw.usarPU = false;
        powerUp = 0;
    }
    

}
//Guarda as caracteristicas dos powerups para definir se podem ou não ser usados
