using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ExchangeToggle : Toggle {
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        targetGraphic.enabled = isOn;
    }
}
