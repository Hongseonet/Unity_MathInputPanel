using TMPro;
using UnityEngine;

public class MathRoot : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textLeft, textUpper, textBottom;
    

    public int SetLeft
    {
        get => int.Parse(textLeft.text);
        set => textLeft.text = value.ToString();
    }

    public int SetUpper
    {
        get => int.Parse(textUpper.text);
        set => textUpper.text = value.ToString();
    }

    public int SetBottom
    {
        get => int.Parse(textBottom.text);
        set => textBottom.text = value.ToString();
    }
}