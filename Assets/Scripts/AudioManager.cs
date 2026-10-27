using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

public AudioSource fuenteMusica;
public AudioSource fuenteEfectos;

public AudioClip musicaFondo;
public AudioClip sonidoClick;
public AudioClip sonidoEscalar;
public AudioClip sonidoLateral;
public AudioClip sonidoFrontal;

    private void Awake()
    {
        Instance = this;

        fuenteMusica.clip = musicaFondo;
        fuenteMusica.loop = true;
        fuenteMusica.Play();
    }

    public void ReproducirClick()
    {
        Reproducir(sonidoClick);
    }

    public void ReproducirEscalar()
    {
        Reproducir(sonidoEscalar);
    }

    public void ReproducirLateral()
    {
        Reproducir(sonidoLateral);
    }

    public void ReproducirFrontal()
    {
        Reproducir(sonidoFrontal);
    }

    public void CambiarVolumenMusica(float volumen)
    {
        fuenteMusica.volume = volumen;
    }

    public void CambiarVolumenEfectos(float volumen)
    {
        fuenteEfectos.volume = volumen;
    }

    private void Reproducir(AudioClip clip)
    {
        if (clip != null)
        {
            fuenteEfectos.PlayOneShot(clip);
        }
    }
}
