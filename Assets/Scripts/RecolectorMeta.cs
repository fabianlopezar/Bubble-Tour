using UnityEngine;
public class RecolectorMeta : MonoBehaviour
{    
    public int BurbujasActuales=0;
    public int BurbujasMeta=80;
    public GameObject panelFinal;

    public void Start()
    {
            panelFinal.SetActive(false);       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Agua"))
        {
            BurbujasActuales++;
            Debug.Log("Burbujas Actuales: "+BurbujasActuales);
        }
        if (BurbujasActuales > BurbujasMeta)
        {
            panelFinal.SetActive(true);
        }
    }
}
