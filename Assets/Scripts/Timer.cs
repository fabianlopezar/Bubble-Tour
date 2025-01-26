using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 10f; // Tiempo inicial en segundos
    public TMP_Text timerText; // Asignar un componente Text si deseas mostrar el tiempo
    public bool isCounting = false;
    public GameObject panelFinal;

    void Start()
    {
        panelFinal.SetActive(false);
        isCounting = true; // Empieza a contar desde el inicio
    }

    void Update()
    {
        if (isCounting && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // Reduce el tiempo restante
            UpdateTimerUI(); // Actualiza el texto (opcional)
        }
        else if (timeRemaining <= 0)
        {
            isCounting = false;
            timeRemaining = 0;
            TimerEnded(); // Llamar la función cuando el temporizador termine
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = "" + Mathf.Ceil(timeRemaining).ToString(); // Mostrar solo segundos enteros
        }
    }

    void TimerEnded()
    {
        Debug.Log("¡El temporizador ha terminado!");
        panelFinal.SetActive(true);//Activa el panel cuando se termina el juego.
        Time.timeScale = 0f; // Detiene el tiempo
        // Aquí puedes ejecutar la acción que deseas al terminar el tiempo
    }
}
