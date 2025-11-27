using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{ 

    // Método para clique (tela de título)
    public void OnMouseDown()
    {

        // Ao clicar na tela tela de título, troca para a cena principal do jogo
        SceneManager.LoadScene(0);

    }    
       
}
