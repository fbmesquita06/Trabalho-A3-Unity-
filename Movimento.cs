using UnityEngine;

public class MovimentoSimples : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
    
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
    }
}

