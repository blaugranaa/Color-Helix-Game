using UnityEngine;
using UnityEngine.UI;
public class RestartButton : Button
{
    Color transparency;
    Image btnImage;
    protected override void OnEnable()
    {
        base.OnEnable();
        btnImage = GetComponent<Image>();
        transparency = btnImage.color;

        EventManager.OnLevelFail.AddListener(RestartProcess);
        onClick.AddListener(() =>
        {
            transparency.a = 0;
            btnImage.color = transparency;
        });
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        EventManager.OnLevelFail.RemoveListener(RestartProcess);
        onClick.RemoveListener(() =>
        {
            transparency.a = 0;
            btnImage.color = transparency;
        });
    }

    private void RestartProcess()
    {
        transparency.a = 255;
        btnImage.color = transparency;
    }
}
