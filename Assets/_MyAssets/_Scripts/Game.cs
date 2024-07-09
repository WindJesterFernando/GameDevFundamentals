using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game Instance { get; private set; } // Static object of the class.
    public SoundManager SOMA;

    private void Awake() // Ensure there is only one instance.
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Will persist between scenes.
            Initialize();
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances.
        }
    }

    private void Initialize()
    {
        SOMA = new SoundManager();
        SOMA.Initialize(gameObject);
        SOMA.AddSound("Jump", Resources.Load<AudioClip>("jump"), SoundManager.SoundType.SOUND_SFX);
        SOMA.AddSound("Roll", Resources.Load<AudioClip>("roll"), SoundManager.SoundType.SOUND_SFX);
        SOMA.AddSound("StillDre", Resources.Load<AudioClip>("StillDre"), SoundManager.SoundType.SOUND_MUSIC);
        

        SOMA.AddSound("I_Ran", Resources.Load<AudioClip>("I_Ran"), SoundManager.SoundType.SOUND_MUSIC);
        SOMA.AddSound("Battle", Resources.Load<AudioClip>("Battle"), SoundManager.SoundType.SOUND_MUSIC);
        
        

        SOMA.PlayMusic("StillDre");
        
    }
}




//DONE:
//change tiles to whatever-whatever
//add background
//setup background
//move camera
//scrolling background
//slower scrolling back-background 
//fix gaps
//make background loop
//make loop seamless
//play music
//load new music track


//animate sonic
    //store frames
    
    //change frames
    //conditions for each animation
    //time for each frame



//TODO:




//spawn obstacles
//Obstacle shapes: triangle, circle, square
//scrolling forground

//????Add hazard tiles????
//???give floor collision detection????







