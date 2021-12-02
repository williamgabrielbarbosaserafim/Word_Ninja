using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public GameObject lps;

    public int lifepoints = 3;
    public float espacoParaDistribuicao = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-8.27f, 2, 0);
        lifepoints = 3;
        distribuirIconesVida();
    }

    // Update is called once per frame
    void Update()
    {
        gameOver();
        
    }
    public void distribuirIconesVida()
    {
        Instantiate(lps, this.transform);

    }
    public void dano()
    {
        
        GameObject lps;
        lps = GameObject.Find("LPs(Clone)");
        Destroy(lps);
        lifepoints = lifepoints - 1;
        distribuirIconesVida();
    }
    void gameOver()
    {
        GameObject gameover;
        gameover = GameObject.Find("GameOver");
        if(lifepoints <= 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            gameover = GameObject.Find("GameOver");
            gameover.transform.position = new Vector3(0, 0, 0);
        }
    }
}
//Gerencia os atributos de Vida do usuário