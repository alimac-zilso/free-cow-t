using UnityEngine;
using TMPro;

public class ObjectManager : MonoBehaviour
{
    // Declara variável de referência para o texto de UI 
    public TextMeshProUGUI clickerCountText;
    
    // Declara variável para contagem de cliques
    public int clickCount = 0;

    // Declara variável de referência de posição (transform) para o ponto de spawn
    public Transform spawnPoint;

    // Declara variável de referência para o objeto (spawnpoint) 
    public GameObject spawnObject;

    // Método para clique no objeto principal
    void OnMouseDown()
    {

        // Aumenta o valor da variável de contagem
        clickCount++;

        // Seta o valor atualizado da variável no texto da UI
        clickerCountText.text = clickCount.ToString();

        // Cria objetos (instâncias) ao clicar no objeto principal
        Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);
              
    }

}
