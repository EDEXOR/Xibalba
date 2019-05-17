using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjetoShow : MonoBehaviour
{
    public int master;
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9; //MODELOS 3D
    public TextMeshProUGUI txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9; //TEMA PRINCIPAL MODELO 3D
    public TextMeshProUGUI p1, p2, p3, p4, p5, p6, p7, p8, p9; //PARRAFO VENTANA MODAL
    public TextMeshProUGUI ptxt1, ptxt2, ptxt3, ptxt4, ptxt5, ptxt6, ptxt7, ptxt8, ptxt9;  //TEMA VENTANA MODAL

    void Start()
    {
        master = Mostrar.valor;

        switch (master)
        {
            case 1:

                obj1.SetActive(true);

                txt1.text = "Esfinge de perro";
                //txt1.text = "Dog sphinx";
                txt1.gameObject.SetActive(true);

                p1.text = "Las esfinges de perros fueron utilizadas en ceremonias de carácter votivo, " +
                    "hechos del mismo barro utilizado en los incensarios, los primeros encontrados fueron " +
                    "restos cerámicos, entre ellos una figura casi completa. Don Ernesto Uribe un año encontró " +
                    "la cabeza de una figura y probablemente parte de una con ruedas.";
                //p1.text = "The sphinxes of dogs were used in ceremonies of votive character, made of the same mud used " +
                //    "in the censers, the first found were ceramic remains, among them an almost complete figure. Don Ernesto " +
                //    "Uribe one year found the head of a figure and probably part of one with wheels.";
                p1.gameObject.SetActive(true);


                ptxt1.text = "Esfinge de perro";
                //ptxt1.text = "Dog sphinx";
                ptxt1.gameObject.SetActive(true);

                break;
            case 2:

                obj2.SetActive(true);

                txt2.text = "Esfinje de jaguar";
                //txt2.text = "Jaguar sphinx";
                txt2.gameObject.SetActive(true);

                p2.text = "La esfinge del jaguar fue otro objeto utilizado en los sacrificios religiosos de Cihuatán, " +
                    "hechos de barro y de carácter votivo. Las Son pequeñas estatuas de esfinge se encuentran de forma sentada, " +
                    "ninguna figura pudo ser restaurada completamente por sus daños, fueron encontradas en el templo de los ídolos.";
                //p2.text = "";
                p2.gameObject.SetActive(true);


                ptxt2.text = "Esfinje de jaguar";
                //ptxt2.text = "Jaguar sphinx";
                ptxt2.gameObject.SetActive(true);
                break;
            case 3:

                obj3.SetActive(true);

                txt3.text = "Traje típico";
                //txt3.text = "Typical costume";
                txt3.gameObject.SetActive(true);


                p3.gameObject.SetActive(true);


                ptxt3.text = "Traje típico";
                //ptxt3.text = "Typical costume";
                ptxt3.gameObject.SetActive(true);
                break;
            case 4:

                obj4.SetActive(true);

                txt4.text = "Incensario gigante";
                //txt4.text = "Giant censer";
                txt4.gameObject.SetActive(true);

                p4.text = "Gran parte de la cerámica desenterrada pertenece a una clase de incensario gigante, con paredes gruesas y decoración al patillaje " +
                    "de considerable variedad y temas: incluyen formas “reloj de arena” o bicónicas, con fondos compuestos de grandes discos de barro removibles. " +
                    "Sus adornos incluyen caras modeladas del dios de la lluvia Tlaloc, las de otros dioses y de espigas. Su altura máxima pudo haber excedido los 1.5 m " +
                    "y diámetro máximo sobrepasa 1m.";
                //p4.text = "";
                p4.gameObject.SetActive(true);

                ptxt4.text = "Incensario gigante";
                //ptxt4.text = "Giant censer";
                ptxt4.gameObject.SetActive(true);
                break;
            case 5:

                obj5.SetActive(true);
                txt5.text = "Tablilla de mazapán";
                //txt5.text = "Marzipan tablet";
                txt5.gameObject.SetActive(true);


                p5.gameObject.SetActive(true);

                ptxt5.text = "Tablilla de mazapán";
                //ptxt5.text = "Marzipan tablet";
                ptxt5.gameObject.SetActive(true);
                break;
            case 6:

                obj6.SetActive(true);

                txt6.text = "Punta de flecha";
                //txt6.text = "Arrowhead";
                txt6.gameObject.SetActive(true);


                p6.gameObject.SetActive(true);

                ptxt6.text = "Punta de flecha";
                //ptxt6.text = "Arrowhead";
                ptxt6.gameObject.SetActive(true);
                break;
            case 7:

                obj7.SetActive(true);

                txt7.text = "Plato de cerámica";
                //txt7.text = "Ceramic dish";
                txt7.gameObject.SetActive(true);


                p7.gameObject.SetActive(true);

                ptxt7.text = "Plato de cerámica";
                //ptxt7.text = "Ceramic dish";
                ptxt7.gameObject.SetActive(true);
                break;
            case 8:

                obj8.SetActive(true);

                txt8.text = "Máscara de cráneo";
                //txt8.text = "Skull mask";
                txt8.gameObject.SetActive(true);


                p8.gameObject.SetActive(true);

                ptxt8.text = "Máscara de cráneo";
                //ptxt8.text = "Skull mask";
                ptxt8.gameObject.SetActive(true);
                break;
            case 9:

                obj9.SetActive(true);

                txt9.text = "Máscara";
                //txt9.text = "Mask";
                txt9.gameObject.SetActive(true);


                p9.gameObject.SetActive(true);

                ptxt9.text = "Máscara";
                //ptxt9.text = "Mask";
                ptxt9.gameObject.SetActive(true);
                break;
            default:
                Debug.Log("Ohh no! Algo ha salido mal");
                break;
        }
    }
      
    
}
