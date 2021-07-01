using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocaDeQuestoes : MonoBehaviour
{
    public TrocarTela trocarTela;
    public Text contador;
    public float tempo;
    public GameObject PainelQuestao;
    public TempoQuestao tempoQuestao;


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
                this.PainelQuestao.SetActive(false);
                this.trocarTela.iniciarC = false;
                this.trocarTela.Esconder.SetActive(false);
                this.tempoQuestao.iniciarCQ = true;
            }
        }
    }

    void UpdateCount()
    {
        this.contador.text = tempo.ToString("F0");
    }

    public void pularC()
    {
        tempo = 0f;
    }
}
