using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{

    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //render blue color
    public void BlueColor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }

    //render red color
    public void RedColor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    //render greencolor
    public void GreenColor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }


    //render yellow color
    public void YellowColor()
    {
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;
    }

    //render pink color
    public void PinkColor()
    {
        renderer.material = BodyColorMat[4];
        CurrMat = renderer.material;
    }

    //render orange color
    public void OrangeColor()
    {
        renderer.material = BodyColorMat[5];
        CurrMat = renderer.material;
    }

    //render black color
    public void BlackColor()
    {
        renderer.material = BodyColorMat[6];
        CurrMat = renderer.material;
    }

    //render white color
    public void WhiteColor()
    {
        renderer.material = BodyColorMat[7];
        CurrMat = renderer.material;
    }
}