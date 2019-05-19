// Jeremías 29:11
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjetoShow : MonoBehaviour
{
    public string idioma;
    public int master;
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9; //MODELOS 3D
    public TextMeshProUGUI txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10; //TEMA PRINCIPAL MODELO 3D
    public TextMeshProUGUI p1, p2, p3, p4, p5, p6, p7, p8, p9; //PARRAFO VENTANA MODAL
    public TextMeshProUGUI ptxt1, ptxt2, ptxt3, ptxt4, ptxt5, ptxt6, ptxt7, ptxt8, ptxt9;  //TEMA VENTANA MODAL
    public Button btn1, btn2; // BOTONES DE INFORMACION

    void Start()
    {
        idioma = Languages.lang;
        Debug.Log(idioma);

        master = Mostrar.opc;
        Debug.Log(master);

        if (idioma == "Español")
        {
            btn1.GetComponentInChildren<Text>().text = "Información";
            btn2.GetComponentInChildren<Text>().text = "Cerrar";
            txt10.text = "Museo";
        }
        else if (idioma == "Ingles")
        {
            btn1.GetComponentInChildren<Text>().text = "Information";
            btn2.GetComponentInChildren<Text>().text = "Close";
            txt10.text = "Museum";
        }


        switch (master)
        {
            case 1:
                obj1.SetActive(true);
                txt1.gameObject.SetActive(true);
                p1.gameObject.SetActive(true);
                ptxt1.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt1.text = "Esfinge de perro";
                    p1.text = "Las esfinges de perros fueron utilizadas en ceremonias de carácter votivo, " +
                   "hechos del mismo barro utilizado en los incensarios, los primeros encontrados fueron " +
                   "restos cerámicos, entre ellos una figura casi completa. Don Ernesto Uribe un año encontró " +
                   "la cabeza de una figura y probablemente parte de una con ruedas.";
                    ptxt1.text = "Esfinge de perro";
                }
                else if (idioma == "Ingles")
                {
                    txt1.text = "Dog sphinx";
                    p1.text = "The sphinxes of dogs were used in ceremonies of votive character, made of the same mud used " +
                        "in the censers, the first found were ceramic remains, among them an almost complete figure. Don Ernesto " +
                        "Uribe one year found the head of a figure and probably part of one with wheels.";
                    ptxt1.text = "Dog sphinx";
                }
                break;

            case 2:
                obj2.SetActive(true);
                txt2.gameObject.SetActive(true);
                p2.gameObject.SetActive(true);
                ptxt2.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt2.text = "Esfinje de jaguar";
                    p2.text = "La esfinge del jaguar fue otro objeto utilizado en los sacrificios religiosos de Cihuatán, " +
                        "hechos de barro y de carácter votivo. Las pequeñas estatuas de esfinge fueron encontradas de forma sentada, " +
                        "ninguna figura pudo ser restaurada completamente por sus daños, fueron encontradas en el templo de los ídolos.";
                    ptxt2.text = "Esfinje de jaguar";
                }
                else if (idioma == "Ingles")
                {
                    txt2.text = "Jaguar sphinx";
                    p2.text = "The sphinx of the jaguar was another object used in the religious sacrifices of Cihuatán, made of clay and votive character." +
                        " The small statues of sphinx were found in a sitting position, no figure could be completely restored by their damage, they were found " +
                        "in the temple of the idols.";
                    ptxt2.text = "Jaguar sphinx";
                }

                break;

            case 3:
                obj3.SetActive(true);
                txt3.gameObject.SetActive(true);
                p3.gameObject.SetActive(true);
                ptxt3.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt3.text = "Traje típico";
                    p3.text = "";
                    ptxt3.text = "Traje típico";
                }
                else if (idioma == "Ingles")
                {
                    txt3.text = "Typical costume";
                    p3.text = "";
                    ptxt3.text = "Typical costume";
                }

                break;

            case 4:
                obj4.SetActive(true);
                txt4.gameObject.SetActive(true);
                p4.gameObject.SetActive(true);
                ptxt4.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt4.text = "Incensario gigante";
                    p4.text = "Gran parte de la cerámica desenterrada pertenece a una clase de incensario gigante, con paredes gruesas y decoración al patillaje " +
                        "de considerable variedad y temas: incluyen formas “reloj de arena” o bicónicas, con fondos compuestos de grandes discos de barro removibles. " +
                        "Sus adornos incluyen caras modeladas del dios de la lluvia Tlaloc, las de otros dioses y de espigas. Su altura máxima pudo haber excedido los 1.5 m " +
                        "y diámetro máximo sobrepasa 1m.";
                    ptxt4.text = "Incensario gigante";
                }
                else if (idioma == "Ingles")
                {
                    txt4.text = "Giant censer";
                    p4.text = "Much of the unearthed ceramics belongs to a kind of giant incense burner, with thick walls and palette decoration of considerable variety and themes: they include " +
                        "'hourglass' or biconical shapes, with backgrounds composed of large removable mud disks. Its ornaments include patterned faces of the rain god Tlaloc, those of other gods and spikes. " +
                        "Its maximum height may have exceeded 1.5 m and maximum diameter exceeds 1m.";
                    ptxt4.text = "Giant censer";
                }


                break;

            case 5:
                obj5.SetActive(true);
                txt5.gameObject.SetActive(true);
                p5.gameObject.SetActive(true);
                ptxt5.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt5.text = "Tablilla de mazapán";
                    p5.text = "";
                    ptxt5.text = "Tablilla de mazapán";
                }
                else if (idioma == "Ingles")
                {
                    txt5.text = "Marzipan tablet";
                    p5.text = "";
                    ptxt5.text = "Marzipan tablet";
                }

                break;

            case 6:
                obj6.SetActive(true);
                txt6.gameObject.SetActive(true);
                p6.gameObject.SetActive(true);
                ptxt6.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt6.text = "Punta de flecha";
                    p6.text = "";
                    ptxt6.text = "Punta de flecha";
                }
                else if (idioma == "Ingles")
                {
                    txt6.text = "Arrowhead";
                    p6.text = "";
                    ptxt6.text = "Arrowhead";
                }

                break;

            case 7:
                obj7.SetActive(true);
                txt7.gameObject.SetActive(true);
                p7.gameObject.SetActive(true);
                ptxt7.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt7.text = "Plato de cerámica";
                    p7.text = "";
                    ptxt7.text = "Plato de cerámica";
                }
                else if (idioma == "Ingles")
                {
                    txt7.text = "Ceramic dish";
                    p7.text = "";
                    ptxt7.text = "Ceramic dish";
                }

                break;

            case 8:
                obj8.SetActive(true);
                txt8.gameObject.SetActive(true);
                p8.gameObject.SetActive(true);
                ptxt8.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt8.text = "Máscara de cráneo";
                    p8.text = "";
                    ptxt8.text = "Máscara de cráneo";
                }
                else if (idioma == "Ingles")
                {
                    txt8.text = "Skull mask";
                    p8.text = "";
                    ptxt8.text = "Skull mask";
                }

                break;

            case 9:
                obj9.SetActive(true);
                txt9.gameObject.SetActive(true);
                p9.gameObject.SetActive(true);
                ptxt9.gameObject.SetActive(true);

                if (idioma == "Español")
                {
                    txt9.text = "Máscara";
                    p9.text = "";
                    ptxt9.text = "Máscara";
                }
                else if (idioma == "Ingles")
                {
                    txt9.text = "Mask";
                    p9.text = "";
                    ptxt9.text = "Mask";
                }

                break;

        }


    }

    public void btnIdioma()
    {
        if (idioma == "Español")
        {
            btn1.GetComponentInChildren<Text>().text = "Información";
            btn2.GetComponentInChildren<Text>().text = "Cerrar";
        }
        else if (idioma == "Ingles")
        {
            btn1.GetComponentInChildren<Text>().text = "Information";
            btn2.GetComponentInChildren<Text>().text = "Close";
        }
    }

    void Update()
    {
        idioma = Languages.lang;
        Debug.Log(idioma);

        master = Mostrar.opc;
        Debug.Log(master);
    }
}
