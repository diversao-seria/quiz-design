using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoQuestao : MonoBehaviour
{
    public Perguntas perguntas;
    public GerenteDeCena gerenteDeCena;
    public TrocarTela trocarTela;
    public GameObject efeitoNC;
    public GameObject Gelo;
    public Text contador;
    public float tempo;
    public bool iniciarCQ;
    public bool Avan�ou;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gelo.activeInHierarchy == true)
        {
            iniciarCQ = false;
            StartCoroutine(Congelar());
        }

        if (iniciarCQ)
        {

            if (tempo > 0f)
            {
                this.tempo -= Time.deltaTime;
                UpdateCount();
            }
            else
            {
                if (Avan�ou == false)
                {
                    gerenteDeCena.Errou();
                    perguntas.ativado = true;
                    efeitoNC.SetActive(false);
                    Avan�ou = true;
                    trocarTela.NextQ();

                }
            }
        }
    }

    void UpdateCount()
    {
        this.contador.text = tempo.ToString("F0");
    }

    IEnumerator Congelar()
    {
        yield return new WaitForSeconds(5);
        iniciarCQ = true;



    }
}
