using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contador : MonoBehaviour
{
    public TextMeshProUGUI textoContador;

    public void ActualizarContador(int cantidad)
    {
        textoContador.text = "Puntos: " + cantidad.ToString();
    }
}
