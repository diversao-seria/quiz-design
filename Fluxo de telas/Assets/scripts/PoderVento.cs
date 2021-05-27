using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderVento : MonoBehaviour
{
    public GameObject Sumir1;
    public GameObject Sumir2;
    public GameObject Revelar;
    public GameObject Botao;
    public GerenteDeCena gerenteDeCena;
    public int quest;


    // Start is called before the first frame update
    void Start()
    {
        quest = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(quest != gerenteDeCena.questao)
        {
            StartCoroutine(EsperaEVolta());
        }
    }

    public void Ventar()
    {
        quest = gerenteDeCena.questao;
        this.Botao.SetActive(false);
        this.Revelar.SetActive(true);
        StartCoroutine(EsperaESome());
    }

    IEnumerator EsperaESome()
    {
        yield return new WaitForSeconds(1);
        this.Sumir1.SetActive(false);
        this.Sumir2.SetActive(false);
        this.Revelar.SetActive(false);
        print("ventou");

    }
    IEnumerator EsperaEVolta()
    {
        yield return new WaitForSeconds(1);
        this.Sumir1.SetActive(true);
        this.Sumir2.SetActive(true);
        

    }


}
