using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class ControleurJoueur : MonoBehaviour
{
	public float vitesse;
    public Text countText;
    public Text TextMessage;
    private Rigidbody rb;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
      count = 0;
      SetCountText ();
        countText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mouvement * vitesse);
    }
    public void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Cible")) {
            other.gameObject.SetActive (false) ;
            count = count + 1;
            SetCountText ();
        }
        if(other.gameObject.CompareTag("enemy"))
        {
            TextMessage.text = "Game Over";

        }
    }
    
    void SetCountText (){
        if (count < 1)
            countText.text = "";
        else
            countText.text = "Count: " + count.ToString ();
        
        if (count >= 8)
        {
            TextMessage.text = "You Win!";
        }
    }


}
