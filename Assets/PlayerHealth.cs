using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int maxHealth = 100;
    [SerializeField] int startingHealth = 100;

    [SerializeField] int collisionDamage = 10;


    int currentHealth;
    readonly List<IHealthObserver> observers = new List<IHealthObserver>();

    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;
    


    void Awake()
    {
        currentHealth = Mathf.Clamp(startingHealth, 0, maxHealth);
    }



    void Start()
    {
        NotifyObservers();
    }


    public void RegisterObserver(IHealthObserver observer)
    {


        observers.Add(observer);
        observer.OnHealthChanged(currentHealth, maxHealth);
    }

    void NotifyObservers


        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
