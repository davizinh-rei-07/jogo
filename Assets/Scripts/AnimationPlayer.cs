using Unity.VisualScripting;
using UnityEngine;
 
public class AnimationPlayer : MonoBehaviour
 
{
 
    [SerializeField] private Animator animPlayer;
    [SerializeField] private MovementPlayer move;
    private bool estaNoChao = true;
 
    void Start()
 
    {
 
        animPlayer = GetComponent<Animator>();
        move = GetComponent<MovementPlayer>();
 
    }
 
    void FixedUpdate()
 
    {
 
        if (Input.GetKey(KeyCode.W))
 
        {
 
            animPlayer.SetBool("Andar", true);
            move.Andar();
 
        }
 
        else
 
        {
 
            animPlayer.SetBool("Andar", false);
            move.Andar();
 
        }
 
        if (Input.GetKey(KeyCode.S))
 
        {
 
            animPlayer.SetBool("Andartras", true);
            move.Andar();
 
        }
 
        else
 
        {
 
            animPlayer.SetBool("Andartras", false);
            
 
        }
 
        //Correndo
 
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
 
        {
 
            animPlayer.SetBool("correr", true);
 
        }
 
        else
 
        {
 
            animPlayer.SetBool("correr", false);
 
        }
 
        //Ataque
 
        if (Input.GetMouseButtonDown(0))
 
        {
 
            animPlayer.SetTrigger("Ataque");
 
        }
 
        //Pular
 
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
 
        {
             animPlayer.SetTrigger("pulo");
             move.Pular();
            animPlayer.SetBool("Nopiso",false);
            estaNoChao = false;
           
 
        }
       
        //Interagir
 
        if (Input.GetKeyDown(KeyCode.E))
 
        {
 
            animPlayer.SetTrigger("Interagir");
 
        }
 
        //Pegando
 
        if (Input.GetKeyDown(KeyCode.G))
 
        {
 
            animPlayer.SetTrigger("pegar");
 
        }
 
        //Torcida
 
        if (Input.GetKeyDown(KeyCode.Q))
 
        {
 
            animPlayer.SetTrigger("Torcida");
 
        }
 
    }

    void Update()
    {
        //Pular
 
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
 
        {
            animPlayer.SetTrigger("pulo");
            move.Pular();
            animPlayer.SetBool("Nopiso",false);
            estaNoChao = false;
           
 
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Chao"))
        {
            animPlayer.SetBool("Nopiso", true);
            estaNoChao = true;
        }
    }
 
}
 
 
 