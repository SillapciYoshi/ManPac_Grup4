using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public Ghosts[] ghosts;
    public Pacman pacman;
    public Transform pellets;

    public int score { get; private set; }

    public int lives { get; private set; }
    // kapali kizlar keldir nokta.
    void Start()
    {
        newgame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void newgame()
    {
        setscore(3);

        Setlives(3);

    }
    private void newround()
    {
        // adi gibi yeni raunt iste  meyveleri gelir yerine koyuyo fln
        foreach (Transform pellet in this.pellets)
        {
            pellet.gameObject.SetActive(true);
        }
        tesetsrate();
    }

    private void tesetsrate()
    {
        for (int i = 0; i < this.ghosts.Length; i++)
        {
            this.ghosts[i].gameObject.SetActive(true);
        }
        this.pacman.gameObject.SetActive(true);
    }
    private void Gameover()
    {
        for (int i = 0; i < this.ghosts.Length; i++)
        {
            this.ghosts[i].gameObject.SetActive(false);
        }
    }


    private void setscore(int score)
    {
        this.score = score;
    }
    private void Setlives(int lives)
    {
        this.lives = lives;
    }
}
