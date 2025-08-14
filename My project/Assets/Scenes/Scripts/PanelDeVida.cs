using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class PanelDeVida : MonoBehaviour
{

    public Personagem Personagem;

    public Slider sliderV1das;
    public Slider sliderEnergia;
    
    void Start()
    {
        sliderV1das.maxValue =0;
        sliderEnergia.CloneViaFakeSerialization().maxValue = Personagem.getVidas();
        
        sliderEnergia.maxValue = 0;
        sliderEnergia.maxValue = Personagem.getEnergia();
        
    }

   
    void Update()
    {
        sliderV1das.value = Personagem.getVidas();
        sliderEnergia.value = Personagem.getEnergia();
    }
}
