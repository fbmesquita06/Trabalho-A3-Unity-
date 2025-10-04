using UnityEngine;

public class MovimentoSimples : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        // Move o objeto para frente a cada frame
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
    }
}
