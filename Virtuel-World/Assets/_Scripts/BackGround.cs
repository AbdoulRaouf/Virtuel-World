using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image defaultImage; // l'image par d�faut 
    public Button[] buttons; // les boutons � surveiller
    public Image[] hoverImages; // les images de survol correspondantes � chaque bouton

    private void Start()
    {
        // Affiche l'image par d�faut au d�but
        //defaultImage.gameObject.SetActive(true);
        foreach (var hover in hoverImages)
        {
            hover.gameObject.SetActive(false);
        }
        // Ajoute un �couteur d'�v�nement pour chaque bouton pour d�tecter le survol
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(() => OnButtonHover(index));
        }
    }

    private void OnButtonHover(int index)
    {
        // Affiche l'image de survol correspondante lorsque le bouton est survol�
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
        // Affiche l'image de survol correspondante lorsque le bouton est survol�
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
        // Affiche l'image par d�faut lorsque le bouton n'est plus survol�
        defaultImage.gameObject.SetActive(true);
        foreach (var hover in hoverImages)
        {
            hover.gameObject.SetActive(false);
        }
    }
}
