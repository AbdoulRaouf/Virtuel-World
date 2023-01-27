using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BackGround : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    /*[SerializeField] private List<Button> buttonList= new List<Button>(6);
    [SerializeField] private List<Image> imageList= new List<Image>(6);*/
    [SerializeField] public Image defaultImage;
    [SerializeField] public Image backGroundImage;
    [SerializeField] private bool isHovering = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true;
        backGroundImage.gameObject.SetActive(true);
        defaultImage.gameObject.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false;
        backGroundImage.gameObject.SetActive(false);
        defaultImage.gameObject.SetActive(true);
    }

    private void Start()
    {
        defaultImage.gameObject.SetActive(true);
        
    }
    void Update()
    {
        if (isHovering)
        {
            Debug.Log("over button");
        }
        else
        {
            Debug.Log("none button");
        }
    }
}
