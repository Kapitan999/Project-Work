using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteAndObjectSwitchButton : MonoBehaviour
{
    #region Настройки
    [SerializeField] private GameObject switchObject = null;
    [SerializeField] private Sprite altSprite = null;
    #endregion


    #region внутренние методы
    private void ToggleSpriteAndObject()
    {
        var image = GetComponent<Image>();
        var sprite = image.sprite;
        image.sprite = altSprite;
        altSprite = sprite;

        var switchComponent = switchObject.GetComponent<ISwitch>();
        if (switchComponent == null)
        {
            Debug.LogWarning(name + " не нашёл ISwitch на " + switchObject.name);
        }
        else
        {
            switchComponent.SetOn(!switchComponent.IsOn());
        }
    }
    #endregion


    #region методы Unity
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ToggleSpriteAndObject);
    }
    #endregion
}
