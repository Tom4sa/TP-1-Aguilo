using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int monedas = 0;

    public void Sumar(int cantidad)
    {
        monedas += cantidad;
    }

    void OnGUI()
    {
        GUIStyle estilo = new GUIStyle(GUI.skin.label);
        estilo.fontSize = 32;
        estilo.fontStyle = FontStyle.Bold;
        estilo.normal.textColor = Color.yellow;
        GUI.Label(new Rect(20, 20, 400, 50), "Monedas: " + monedas, estilo);
    }
}