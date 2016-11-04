using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor;

public class PictureSlider : MonoBehaviour {
    [SerializeField]
    private List<Picture> Pictures = new List<Picture>();
    private int CurrentPicture;
    public int _CurrentPicture
    {
        get { return CurrentPicture; }
        private set { CurrentPicture = value; }
    }
    private int AmountPictures;
    public int _AmountPictures
    {
        get { return AmountPictures; }
        private set { AmountPictures = value;  }
    }
    [SerializeField]private Sprite[] Images;
    public Image Display;


    // Use this for initialization
    void Start () {
        
        Images = Resources.LoadAll<Sprite>("Images");
        foreach(Sprite _image in Images)
        {
            AddPicture(_image);
            
        }

        AmountPictures = Pictures.Count;
        Display.rectTransform.sizeDelta =new Vector2(Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
        Display.sprite = Pictures[CurrentPicture]._Picture;
	}
    public void Previous()
    {
        if (CurrentPicture>0)
        {
            CurrentPicture--;
        }
    }
    public void Next()
    {
        if (CurrentPicture < Pictures.Count)
        {
            CurrentPicture++;
        }
    }
    public void AddPicture(Sprite Picture)
    {
        Pictures.Add(new Picture(Picture));
    }
    
}
class Picture
{
    public Sprite _Picture;
    public Picture(Sprite Picture)
    {
        _Picture = Picture;
        
    }
}

