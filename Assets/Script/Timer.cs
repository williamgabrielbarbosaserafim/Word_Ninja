using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    TextMesh tm;
    GameObject level;
    GameObject win;
    Level sLevel;
    
    int vitoria = 1;
    public float tempoFimFase = 0;
    public int tempoCronometro;
    // Start is called before the first frame update
    void Start()
    {
       
        win = GameObject.Find("Win");
        level = GameObject.Find("Level");
        sLevel = level.GetComponent<Level>();
        tm = GetComponent<TextMesh>();
        tempoFimFase = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        regrasCronometro();
        if(vitoria < sLevel.numFase)
        {
            tempoFimFase = Time.time;
            vitoria = sLevel.numFase;
        }
    }
    void regrasCronometro()
    {
        GameObject vida;
        Vida sVida;
        vida = GameObject.Find("Vida");
        sVida = vida.GetComponent<Vida>();
        
        tempoCronometro = (int)(30 - Time.time + tempoFimFase);
        if (tempoCronometro > 0 && win.transform.position.z != -2)
        {
            tm.text = tempoCronometro.ToString();
        }
        else if (win.transform.position.z == -2)
        {
            tm.text = "X";
        }
        else if(tempoCronometro <= 0)
        {
            tm.text = "0";
            sVida.lifepoints = 0;
        }
    }
}
