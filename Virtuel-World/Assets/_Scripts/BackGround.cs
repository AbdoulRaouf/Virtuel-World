using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image defaultImage; // l'image par défaut 
    public Button[] buttons; // les boutons à surveiller
    public Image[] hoverImages; // les images de survol correspondantes à chaque bouton

    private void Start()
    {
        // Affiche l'image par défaut au début
        //defaultImage.gameObject.SetActive(true);
        foreach (var hover in hoverImages)
        {
            hover.gameObject.SetActive(false);
        }
        // Ajoute un écouteur d'événement pour chaque bouton pour détecter le survol
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(() => OnButtonHover(index));
        }
    }

    private void OnButtonHover(int index)
    {
        // Affiche l'image de survol correspondante lorsque le bouton est survolé
        //defaultImage.gameObject.SetActive(false);
        for (int i = 0; i < hoverImages.Length; i++)
        {
            if (i == index)
            {
                hoverImages[i].gameObject.SetActive(true);
            }
            else
            {
                hoverImages[i].gameObject.SetActive(false);
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Affiche l'image de survol correspondante lorsque le bouton est survolé
        defaultImage.gameObject.SetActive(false);
        for (int i = 0; i < buttons.Length; i++)
        {
            if (eventData.pointerEnter == buttons[i].gameObject)
            {
                hoverImages[i].gameObject.SetActive(true);
                break;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Affiche l'image par défaut lorsque le bouton n'est plus survolé
        defaultImage.gameObject.SetActive(true);
        foreach (var hover in hoverImages)
        {
            hover.gameObject.SetActive(false);
        }
    }
}
