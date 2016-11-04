using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PictureNavigator : MonoBehaviour {
    public PictureSlider PictureSlider;
    public Text _text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        _text.text = (PictureSlider._CurrentPicture + 1).ToString() + "/" + (PictureSlider._AmountPictures+1).ToString();
	}
}
