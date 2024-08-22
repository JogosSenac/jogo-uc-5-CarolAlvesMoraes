using TMPro;
using UnityEngine;

public class Fruta : MonoBehaviour
{
    // Static variable to keep track of the total count of collected coins
    public static int ContaFruta = 0;
    public GameObject objetoTexto;

    void Start()
    {
        objetoTexto = GameObject.FindWithTag("TextoFruta");

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            ContaFruta++;
            objetoTexto.GetComponent<TextMeshProUGUI>().text = "Frutas: " + ContaFruta;
        }
       
    }
}