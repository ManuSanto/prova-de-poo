using UnityEngine;
using UnityEngine.UI;

public class PanelDeVida : MonoBehaviour
{
    public Personagem Personagem;
    public Slider sliderVidas;
    public Slider sliderEnergia;
    void Start()
    {
        sliderVidas.maxValue = Personagem.getVidas();
        sliderEnergia.maxValue = Personagem.getEnergia();
    }

    void Update()
    {
        // Atualiza os valores das barras
        sliderVidas.value = Personagem.getVidas();
        sliderEnergia.value = Personagem.getEnergia();
    }
}