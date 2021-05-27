using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perguntas : MonoBehaviour
{
    public bool ativado;
    public Image barra;
    public GameObject feedback;
    public GerenteDeCena gerenteDeCena;
    


    
    public void Start()
    {
        gerenteDeCena.questao = 1;
        
    }

    
   
    void Update()
    {
        
        if (ativado == true )
        {
          if(barra.fillAmount < 1)
          {
            barra.fillAmount ++;
          }

          else
          {
                feedback.SetActive(true);

                StartCoroutine(EsperaEAvança());

                ativado = false;
          }      
            

        }
       
    }

    public void Ativar()
    {
        ativado = true;
    }

    void UpdateCount()
    {
        gerenteDeCena.contador.text = gerenteDeCena.questao.ToString();
    }

    IEnumerator EsperaEAvança()
    {
        yield return new WaitForSeconds(1);

        feedback.SetActive(false);
        gerenteDeCena.questao++;
        UpdateCount();
        barra.fillAmount=0;
        print("proxima questao");

    }

}
