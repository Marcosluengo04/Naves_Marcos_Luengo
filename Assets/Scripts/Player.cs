using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
    
{
    
    [SerializeField] private float velocidad;
    [SerializeField] private GameObject disparo;
    [SerializeField] private GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        LimitarMovimiento();
        Disparar();

    }

    private void Movimiento()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(h, v, 0).normalized * velocidad * Time.deltaTime);
    }

    private void LimitarMovimiento()
    {
        float x = Mathf.Clamp(transform.position.x ,-8.4f ,8.4f );
        float y = Mathf.Clamp(transform.position.y , 4.4f , 4.89f);

        transform.position = new Vector3(x, y, 0);
    }
    private void Disparar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        //quaternion. ident
            Instantiate(disparo,spawnPoint.transform.position, Quaternion.identity );
            

        
        }



    }






}
