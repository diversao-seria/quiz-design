using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderVento : MonoBehaviour
{
    public List<GameObject> Sumir;
    public List<GameObject> Revelar;
    
    
    public GameObject Botao;
    public GerenteDeCena gerenteDeCena;
    public int quest;


    // Start is called before the first frame update
    void Start()
    {
        quest = gerenteDeCena.questao;
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
        
        foreach (var vento in Revelar)
        {
            vento.SetActive(true);
        }
        
        StartCoroutine(EsperaESome());
        this.Botao.SetActive(false);
    }

    IEnumerator EsperaESome()
    {
        yield return new WaitForSeconds(1);

        foreach (var vento in Revelar)
        {

           
           vento.SetActive(false);
            
            
        }
        
        foreach (var item in Sumir)
        {
            if (item.activeInHierarchy == true)
            {
                item.SetActive(false);
            }
            
        }
        print("ventou");

    }
    IEnumerator EsperaEVolta()
    {
        yield return new WaitForSeconds(1/2);

        foreach (var item in Sumir)
        {
            item.SetActive(true);
        }

    }


}
