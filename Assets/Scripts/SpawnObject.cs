using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    
    void Start()
    {

        // Armazena o Rigidbody2D do objeto que vai ser instanciado em uma variável
        Rigidbody2D objectRB = GetComponent<Rigidbody2D>();

        // Armazena uma direção aleatória com range (X,Y) para o impulso
        Vector3 forceDirection = new Vector3(Random.Range(-10f, 10f), 12f, 0).normalized * 12f;
        
        // Aplica o impulso no objeto instanciado, baseado na direção armazenada acima
        objectRB.AddForce(forceDirection, ForceMode2D.Impulse);
        
    }

    void Update(){

        // Verifica se a posição do objeto instanciado está fora da câmera
        if(transform.position.y < -7){

            // Se sim, destrói o objeto
            Destroy(gameObject);

        }

    }
 
}
