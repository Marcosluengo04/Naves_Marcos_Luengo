using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float velociad;
    [SerializeField] private float vidas;
    [SerializeField] private GameObject balaintanciada;
    [SerializeField] private GameObject PuntoSalida;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnearBala)();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (-1, 0, 0) .normalized *velociad * Time.deltaTime);
    }

    public void RecibirDanho( float danhoRecibido)
    { 
        vidas -= danhoRecibido;
        if (vidas < 0)
        {
            Destroy(this.gameObject);

        }

        

    

    }



    private IEnumerator SpawnearBala()
    {

        while (true)
        {
            Instantiate(balaintanciada, PuntoSalida.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }



    }






}  








