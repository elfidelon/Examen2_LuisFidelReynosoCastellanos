using TMPro;
using UnityEngine;

public class ControladorModelo : MonoBehaviour
{
 public GameObject modelo;
 public Animator animador;
 public TextMeshProUGUI textoBotonColocar;
 public TextMeshProUGUI textoContador;

    private int escala;
    private int lateral;
    private int frontal;

    public void ColocarObjeto()
    {
        AudioManager.Instance.ReproducirClick();
        modelo.SetActive(!modelo.activeSelf);
        if (modelo.activeSelf)
        {
            textoBotonColocar.text = "Ocultar Objeto";
        }
        else
        {
            textoBotonColocar.text = "Colocar Objeto";
        }
    }

    public void Escalar()
    {
        AudioManager.Instance.ReproducirEscalar();
        Animar("Escalar");
        escala++;
        ActualizarContador();
    }

    public void MoverLateral()
    {
        AudioManager.Instance.ReproducirLateral();
        Animar("MoverLateral");
        lateral++;
        ActualizarContador();
    }

    public void MoverFrontal()
    {
        AudioManager.Instance.ReproducirFrontal();
        Animar("MoverFrontal");
        frontal++;
        ActualizarContador();
    }

    private void Animar(string trigger)
    {
        if (modelo.activeSelf)
        {
            animador.SetTrigger(trigger);
        }
    }

    private void ActualizarContador()
    {
        textoContador.text = "Escala: " + escala + ", Lateral: " + lateral + ", Frontal " + frontal;
    }
}
