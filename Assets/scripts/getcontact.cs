using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class getcontact : MonoBehaviour
{
    [SerializeField] GameObject nameinputfield;
    public string name;
    [SerializeField] GameObject mobileinputfield;
    public string mobilenum;
    [SerializeField] GameObject addressinputfield;
    public string address;
    [SerializeField] GameObject mailinputfield;
    public string mail;
    public string id;
    public void assignname()
    {

        name = nameinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignmobilenum()
    {
        mobilenum = mobileinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignaddress()
    {
        address = addressinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void assignmail()
    {
        mail = mailinputfield.GetComponent<TMP_InputField>().text.ToString();
    }
    public void contactdetailssave()
    {
        assignname();
        assignmobilenum();
        assignaddress();
        assignmail();

        savesystem.contactsave(id,this);

    }
}
