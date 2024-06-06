using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajescript : MonoBehaviour
{
    public int nivelhambre;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void tomaralimento(int valoralimentario)
    {
        nivelhambre -= valoralimentario;
        if (nivelhambre <= 0)
        {
            nivelhambre = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        alimentostript alimento;
        alimento = other.GetComponent<alimentostript>();
        if (alimento)
        {
            tomaralimento(alimento.valoralimentario);
            Destroy(other.gameObject);
        }
    }
}
