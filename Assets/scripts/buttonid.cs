using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buttonid : MonoBehaviour
{
    public scenemanager.nextscreen mynextcanvas;
    public List<userdata> getuserlist;
    [SerializeField] GameObject loginidinputfield;
    [SerializeField] GameObject usernotpresenttext;
    public string loginid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextcanvas()
    {

        foreach (var name in scenemanager.nextscreen.GetNames(mynextcanvas.GetType()))
        {
            if (name == mynextcanvas.ToString())
            {
                
                scenemanager.instance.changescreen(name);
            }
        }
    }
    public void logincheck()
    {
        getuserlist = savesystem.loadplayer();
        loginid = loginidinputfield.GetComponent<TMP_InputField>().text.ToString();
       
        if (!string.IsNullOrEmpty(loginid))
        {
            foreach (userdata theuserdata in getuserlist)
            {
                if (theuserdata.userid == loginid)
                {
                    Debug.Log("the next canvas ");
                    nextcanvas();
                    usernotpresenttext.active = false;
                }
                else
                {
                    usernotpresenttext.active = true;
                }
            }
        }
        else
        {
            Debug.LogError("user id is empty type again");
        }
       
        //logintext = loginbutton.GetComponent<>();
        //foreach (userdata theuser in getuserlist)
        //{
        //    if (theuser.name==)
        //    {

        //        scenemanager.instance.changescreen(name);
        //    }
        //}
    }
}
