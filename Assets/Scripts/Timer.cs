using UnityEngine;

public class Timer : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI textoTimer;
    [SerializeField] float tempoRestante;

    public string TelaPraEsconder = "FimDeJogo";
    public bool acabou = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform filho = transform.Find(TelaPraEsconder);
        filho.gameObject.SetActive(false);

        Time.timeScale = 1;
        acabou = false;
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
    // Update is called once per frame
    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante = tempoRestante - Time.deltaTime;
        }
        else
        {
            tempoRestante = 0;
            //GameOver();
            textoTimer.color = Color.red;
            acabou = true;
            Time.timeScale = 0;
            Transform filho = transform.Find(TelaPraEsconder);
            filho.gameObject.SetActive(true);
        }






        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

}
