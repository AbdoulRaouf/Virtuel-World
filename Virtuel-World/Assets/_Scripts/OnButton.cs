using UnityEngine;
using UnityEngine.EventSystems;

public class OnButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Cursor entered button");
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Cursor exited button");
    }
}
