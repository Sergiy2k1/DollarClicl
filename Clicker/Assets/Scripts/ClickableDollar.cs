using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableDollar : MonoBehaviour, IPointerClickHandler
{
    public EconomicController EconomicController;

    public float GrowingRate = 1f;
    public int MoneyPerClick;

    public float growingRate = 1f;

    private void Update()
    {
        if(transform.localScale.x < 1)
        {
            transform.localScale += Vector3.one * (Time.deltaTime * growingRate);
        }
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        EconomicController.Money += MoneyPerClick;
        AudioManager.Instance.PlaySFX("Click");
        transform.localScale = Vector3.one * .9f;
    }
}
