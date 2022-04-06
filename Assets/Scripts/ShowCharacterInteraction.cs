using UnityEngine;
using UnityEngine.UI;

public class ShowCharacterInteraction : MonoBehaviour
{
    [SerializeField] private Image portrait = null;
    [SerializeField] private Text charName = null;
    [SerializeField] private Text charText = null;

    public void InteractWith(GameObject gameObject)
    {
        if (gameObject)
        { 
            var character = gameObject.GetComponent<CharacterData>();
            if (character)
            { 
                portrait.sprite = character.Portrait;
                charName.text = character.Name;
                charText.text = character.text;
            }
            else
            {
                Debug.LogWarning(name + " не нашёл CharacterData на " + gameObject.name);
            }
            GetComponent<ISwitch>().SetOn(true);
        }
        else
        {
            GetComponent<ISwitch>().SetOn(false);
        }
    }
}
