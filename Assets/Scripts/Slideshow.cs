using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slideshow : MonoBehaviour
{
    public Sprite[] images;
    public Image imageHolder;
    public Slider slider;

    private int imageIndex = 0;
    private float imageInitialSize;

    // Start is called before the first frame update
    void Start()
    {
        imageInitialSize = imageHolder.rectTransform.sizeDelta.x;
        imageHolder.sprite = images[0];
        imageHolder.preserveAspect = true;
        slider.value = 1;
        slider.onValueChanged.AddListener(Zoom);
    }

    public void ChangeImage(int step)
    {
        imageIndex += step;

        if(imageIndex >= images.Length)
        {
            imageIndex = 0;
        }
        else if(imageIndex < 0)
        {
            imageIndex = images.Length - 1;
        }

        imageHolder.sprite = images[imageIndex];
    }

    private void Zoom(float value)
    {
        float newSize = imageInitialSize * value;
        imageHolder.rectTransform.sizeDelta = new Vector2(newSize, newSize);
    }
}
