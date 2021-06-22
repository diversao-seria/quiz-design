using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocaDeQuestoes : MonoBehaviour
{
    public TrocarTela trocarTela;
    public Text contador;
    public float tempo;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (trocarTela.iniciarC)
        {
            
            if (tempo > 0f)
            {
                this.tempo -= Time.deltaTime;
                UpdateCount();
            }
            else
            {
                this.trocarTela.PainelQuestao.SetActive(false);
                this.trocarTela.iniciarC = false;
                this.trocarTela.Esconder.SetActive(false);
            }
        }
    }

    void UpdateCount()
    {
        this.contador.text = tempo.ToString("F0");
    }
}
