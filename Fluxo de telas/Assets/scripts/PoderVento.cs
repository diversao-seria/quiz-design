using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderVento : MonoBehaviour
{
    public GameObject Sumir1;
    public GameObject Sumir2;
    public GameObject Revelar;
    public GameObject Botao;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ventar()
    {
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
}
