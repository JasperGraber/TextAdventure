using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using Random = UnityEngine.Random;

public class MyAdventure : MonoBehaviour
{
    
//Hier worden alle States aangeduid. 
    private enum States
    {
        MainMenu,

        Controls,

        SecretWarning,
        SecretMenu,
        Handyman,
        Peacekeeper,
        Casanova,
        WrongExit,
        GreedySurvivor,
        Coldblooded,
        HungryHobo,
        VampiresDream,
        HealthyDiet,
        Doctor,
        
        GameWarning,
        Prologue,

        FindCar,
        Roadblock,
        DriveThrough,
        BrokenCar,
        WolfKillCar,
        FindWayCar,
        Flee,
        SurrenderKill,

        FindHouse,
        SearchHouse,
        SearchBasement,
        LadyKill,
        SearchAttic,
        ContinueSearch,

        WalkingSupermarket,
        WolfEntranceKill,
        StaffEntrance,
        WolfEncounter,
        FindFood,
        SearchingSupermarket,
        GreedyKill,

        ContinueCity,
        Hungry,
        StarvationKill,
        BleedingKill,
        FreezeKill,
        
        ContinueSearch2,
        SearchHouse2,
        LadyKill2,
        SearchBasement2,
        SearchAttic2,
        WalkingSupermarket2,
        WolfEntranceKill2,
        StaffEntrance2,
        WolfEncounter2,
        FindFood2,
        SearchingSupermarket2,
        FindMedicals2,
        Hungry2,
        Heal2,
        Part2,
        
        SearchingSupermarket3,
        ContinueCity3,
        FindMedicals3,
        Hungry3,
        Eat3,
        
        ContinueCity4,
        Hungry4,
        
        SearchingSupermarket5,
        ContinueCity5,
        Hungry5,
        
        ContinueCity6,
    }
    
//Dit geeft de eerste state aan.
    private States currentState = States.MainMenu;
    
//Hier wordt de eerste Void gestart.
    void Start()
    {
        MainMenu(); 
    }
    
//Hier wordt gecontrolleerd wat de gebruiker invoert door middel van switches.
    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.MainMenu:
                if (input == "start")
                {
                    GameWarning();
                }
                else if (input == "controls")
                {
                    Controls();
                }
                else if (input == "secret")
                {
                    SecretWarning();
                }
                else if (input == "exit")
                {
                    Application.Quit();
                }
                else if (input == "Start")
                {
                    GameWarning();
                }
                else if (input == "Controls")
                {
                    Controls();
                }
                else if (input == "Secret")
                {
                    SecretWarning();
                }
                else if (input == "Exit")
                {
                    Application.Quit();
                }
                else
                {
                    MainMenu();
                }
                
                break;

            case States.Controls:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    Controls();
                }

                break;

            case States.SecretWarning:
                if (input == "yes")
                {
                    SecretMenu();
                }
                else if (input == "YES")
                {
                    SecretMenu();
                }
                else if (input == "no")
                {
                    MainMenu();
                }
                else if (input == "NO")
                {
                    MainMenu();
                }
                else
                {
                    SecretWarning();
                }

                break;

            case States.SecretMenu:
                if (input == "1")
                {
                    Handyman();
                }
                else if (input == "2")
                {
                    Peacekeeper();
                }
                else if (input == "3")
                {
                    Casanova();
                }
                else if (input == "4")
                {
                    WrongExit();
                }
                else if (input == "5")
                {
                    GreedySurvivor();
                }
                else if (input == "6")
                {
                    Coldblooded();
                }
                else if (input == "7")
                {
                    HungryHobo();
                }
                else if (input == "8")
                {
                    VampiresDream();
                }
                else if (input == "9")
                {
                    HealthyDiet();
                }
                else if (input == "10")
                {
                    Doctor();
                }
                else
                {
                    SecretMenu();
                }
                
                break;
            
            case States.Handyman:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    Handyman();
                }
                
                break;

            case States.Peacekeeper:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    Peacekeeper();
                }
                
                break;
            
            case States.Casanova:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    Casanova();
                }
                
                break;
            
            case States.WrongExit:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    WrongExit();
                }

                break;
            
            case States.GreedySurvivor:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    GreedySurvivor();
                }

                break;
            
            case States.Coldblooded:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    Coldblooded();
                }

                break;
            
            case States.HungryHobo:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    HungryHobo();
                }

                break;
            
            case States.VampiresDream:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    VampiresDream();
                }

                break;
            
            case States.HealthyDiet:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    HealthyDiet();
                }

                break;
            
            case States.Doctor:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    Doctor();
                }

                break;
            
            case States.GameWarning:
                if (input == "yes")
                {
                    Prologue();
                }
                else if (input == "YES")
                {
                    Prologue();
                }
                else if (input == "no")
                {
                    MainMenu();
                }
                else if (input == "NO")
                {
                    MainMenu();
                }
                else
                {
                    GameWarning();
                }

                break;

            case States.Prologue:
                if (input == "next")
                {
                    FindCar();
                }
                else if (input == "NEXT")
                {
                    FindCar();
                }
                else
                {
                    Prologue();
                }

                break;

            case States.FindCar:
                if (input == "1")
                {
                    Roadblock();
                }
                else if (input == "2")
                {
                    FindHouse();
                }
                else
                {
                    FindCar();
                }

                break;

            case States.Roadblock:
                if (input == "1")
                {
                    DriveThrough();
                }
                else if (input == "2")
                {
                    FindWayCar();
                }
                else
                {
                    Roadblock();
                }

                break;

            case States.DriveThrough:
                if (input == "next")
                {
                    BrokenCar();
                }
                else if (input == "NEXT")
                {
                    BrokenCar();
                }
                else
                {
                    DriveThrough();
                }

                break;

            case States.BrokenCar:
                if (input == "1")
                {
                    WolfKillCar();
                }
                else if (input == "2")
                {
                    WalkingSupermarket();
                }
                else
                {
                    BrokenCar();
                }

                break;

            case States.WolfKillCar:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    WolfKillCar();
                }

                break;

            case States.FindWayCar:
                if (input == "1")
                {
                    SurrenderKill();
                }
                else if (input == "2")
                {
                    Flee();
                }
                else
                {
                    FindWayCar();
                }

                break;

            case States.Flee:
                if (input == "next")
                {
                    WalkingSupermarket();
                }
                else if (input == "NEXT")
                {
                    WalkingSupermarket();
                }
                else
                {
                    Flee();
                }

                break;

            case States.SurrenderKill:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    SurrenderKill();
                }

                break;

            case States.FindHouse:
                if (input == "1")
                {
                    SearchHouse();
                }
                else if (input == "2")
                {
                    WalkingSupermarket();
                }
                else
                {
                    FindHouse();
                }

                break;

            case States.SearchHouse:
                if (input == "1")
                {
                    SearchAttic();
                }
                else if (input == "2")
                {
                    SearchBasement();
                }
                else if (input == "3")
                {
                    WalkingSupermarket();
                }
                else
                {
                    SearchHouse();
                }

                break;

            case States.SearchBasement:
                if (input == "1")
                {
                    LadyKill();
                }
                else if (input == "2")
                {
                    ContinueSearch();
                }
                else
                {
                    SearchBasement();
                }

                break;
            
            case States.LadyKill:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    LadyKill();
                }
                
                break;
            
            case States.ContinueSearch:
                if (input == "1")
                {
                    SearchHouse();
                }
                else if (input == "2")
                {
                    WalkingSupermarket();
                }
                else
                {
                    ContinueSearch();
                }

                break;

            case States.SearchAttic:
                if (input == "1")
                {
                    ContinueSearch2();
                }
                else if (input == "2")
                {
                    ContinueSearch();
                }
                else
                {
                    SearchAttic();
                }

                break;
            
            case States.WalkingSupermarket:
                if (input == "1")
                {
                    WolfEntranceKill();
                }
                else if (input == "2")
                {
                    StaffEntrance();
                }
                else if (input == "3")
                {
                    ContinueCity();
                }
                else
                {
                    WalkingSupermarket();
                }
                
                break;
            
            case States.WolfEntranceKill:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    WolfEntranceKill();
                }
                
                break;
            
            
            case States.StaffEntrance:
                if (input == "1")
                {
                    WolfEntranceKill();
                }
                else if (input == "2")
                {
                    WolfEncounter();
                }
                else
                {
                    StaffEntrance();
                }
                
                break;

            case States.WolfEncounter:
                if (input == "1")
                {
                    ContinueCity();
                }
                else if (input == "2")
                {
                    FindFood();
                }
                else
                {
                    WolfEncounter();
                }
                
                break;
            
            case States.FindFood:
                if (input == "1")
                {
                    SearchingSupermarket5();
                }
                else if (input == "2")
                {
                    SearchingSupermarket();
                }
                else
                {
                    FindFood();
                }
                
                break;
            
            case States.SearchingSupermarket:
                if (input == "1")
                {
                    GreedyKill();
                }
                else if (input == "2")
                {
                    ContinueCity();
                }
                else
                {
                    SearchingSupermarket();
                }
                
                break;
            
            case States.GreedyKill:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    GreedyKill();
                }
                
                break;
            
            case States.ContinueCity:
                if (input == "1")
                {
                    Hungry();
                }
                else if (input == "2")
                {
                    FreezeKill();
                }
                else
                {
                    ContinueCity();
                }
                
                break;
            
            case States.FreezeKill:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    FreezeKill();
                }
                
                break;
            
            case States.Hungry:
                if (input == "1")
                {
                    StarvationKill();
                }
                else if (input == "2")
                {
                    BleedingKill();
                }
                else
                {
                    Hungry();
                }
                
                break;
            
            case States.StarvationKill:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    StarvationKill();
                }
                
                break;
            
            case States.BleedingKill:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    BleedingKill();
                }
                
                break;
            
                case States.ContinueSearch2:
                if (input == "1")
                {
                    SearchHouse2();
                }
                else if (input == "2")
                {
                    WalkingSupermarket2();
                }
                else
                {
                    ContinueSearch2();
                }

                break;
                
            case States.SearchHouse2:
                if (input == "1")
                {
                    SearchAttic2();
                }
                else if (input == "2")
                {
                    SearchBasement2();
                }
                else if (input == "3")
                {
                    WalkingSupermarket2();
                }
                else
                {
                    SearchHouse2();
                }

                break;
            
            case States.SearchBasement2:
                if (input == "1")
                {
                    LadyKill2();
                }
                else if (input == "2")
                {
                    ContinueSearch2();
                }
                else
                {
                    SearchBasement2();
                }

                break;
            
            case States.LadyKill2:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    LadyKill2();
                }
                
                break;
            
            case States.SearchAttic2:
                if (input == "1")
                {
                    ContinueSearch2();
                }
                else
                {
                    SearchAttic2();
                }

                break;
            
            case States.WalkingSupermarket2:
                if (input == "1")
                {
                    WolfEntranceKill2();
                }
                else if (input == "2")
                {
                    StaffEntrance2();
                }
                else if (input == "3")
                {
                    ContinueCity();
                }
                else
                {
                    WalkingSupermarket2();
                }
                
                break;
            
            case States.WolfEntranceKill2:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    WolfEntranceKill2();
                }
                
                break;
            
            
            case States.StaffEntrance2:
                if (input == "1")
                {
                    WolfEntranceKill2();
                }
                else if (input == "2")
                {
                    WolfEncounter2();
                }
                else
                {
                    StaffEntrance2();
                }
                
                break;

            case States.WolfEncounter2:
                if (input == "1")
                {
                    ContinueCity();
                }
                else if (input == "2")
                {
                    FindFood();
                }
                else if (input == "3")
                {
                    FindFood2();
                }
                else
                {
                    WolfEncounter2();
                }
                
                break;
            
            case States.FindFood2:
                if (input == "1")
                {
                    SearchingSupermarket3();
                }
                else if (input == "2")
                {
                    SearchingSupermarket2();
                }
                else
                {
                    FindFood2();
                }
                
                break;
            
            case States.SearchingSupermarket2:
                if (input == "1")
                {
                    FindMedicals2();
                }
                else if (input == "2")
                {
                    ContinueCity();
                }
                else
                { 
                    SearchingSupermarket2();
                }
                
                break;
            
            case States.FindMedicals2:
                if (input == "1")
                {
                    ContinueCity3();
                }
                else if (input == "2")
                {
                    ContinueCity();
                }
                else
                { 
                    FindMedicals2();
                }
                
                break;
            
            case States.ContinueCity3:
                if (input == "1")
                {
                    Hungry2();
                }
                else if (input == "2")
                {
                    FreezeKill();
                }
                else
                {
                    ContinueCity3();
                }
                
                break;

            case States.Hungry2:
                if (input == "1")
                {
                    StarvationKill();
                }
                else if (input == "2")
                {
                    Heal2();
                }
                else
                {
                    Hungry2();
                }
                
                break;
            
            case States.SearchingSupermarket3:
                if (input == "1")
                {
                    FindMedicals3();
                }
                else if (input == "2")
                {
                    ContinueCity4();
                }
                else
                { 
                    SearchingSupermarket3();
                }
                
                break;
            
            case States.FindMedicals3:
                if (input == "1")
                {
                    ContinueCity5();
                }
                else if (input == "2")
                {
                    ContinueCity4();
                }
                else
                { 
                    FindMedicals3();
                }
                
                break;
            
            case States.ContinueCity4:
                if (input == "1")
                {
                    Hungry3();
                }
                else if (input == "2")
                {
                    FreezeKill();
                }
                else
                {
                    ContinueCity4();
                }
                
                break;

            case States.Hungry3:
                if (input == "1")
                {
                    StarvationKill();
                }
                else if (input == "2")
                {
                    BleedingKill();
                }
                else if (input == "3")
                {
                    Eat3();
                }
                else
                {
                    Hungry3();
                }
                
                break;
            
            case States.ContinueCity5:
                if (input == "1")
                {
                    Hungry4();
                }
                else if (input == "2")
                {
                    FreezeKill();
                }
                else
                {
                    ContinueCity5();
                }
                
                break;
            
            case States.Hungry4:
                if (input == "1")
                {
                    StarvationKill();
                }
                else if (input == "2")
                {
                    Heal2();
                }
                else if (input == "3")
                {
                    Eat3();
                }
                else
                {
                    Hungry4();
                }
                
                break;
            
            case States.SearchingSupermarket5:
                if (input == "1")
                {
                    GreedyKill();
                }
                else if (input == "2")
                {
                    ContinueCity6();
                }
                else
                {
                    SearchingSupermarket5();
                }
                
                break;

            case States.ContinueCity6:
                if (input == "1")
                {
                    Hungry5();
                }
                else if (input == "2")
                {
                    FreezeKill();
                }
                else
                {
                    ContinueCity6();
                }
                
                break;
                
            case States.Hungry5:
                if (input == "1")
                {
                    StarvationKill();
                }
                else if (input == "2")
                {
                    BleedingKill();
                }
                else if (input == "3")
                {
                    Eat3();
                }
                else
                {
                    Hungry5();
                }
                
                break;
            
            case States.Eat3:
                if (input == "next")
                {
                    Part2();
                }
                else if (input == "NEXT")
                {
                    Part2();
                }
                else
                {
                    Eat3();
                }
                
                break;
            
            case States.Heal2:
                if (input == "next")
                {
                    Part2();
                }
                else if (input == "NEXT")
                {
                    Part2();
                }
                else
                {
                    Heal2();
                }
                
                break;
            
            case States.Part2:
                if (input == "back")
                {
                    MainMenu();
                }
                else if (input == "BACK")
                {
                    MainMenu();
                }
                else
                {
                    Part2();
                }
                
                break;
        }
    }

//Hier worden alle Voids aangeduid.    
        void MainMenu()
        {
            currentState = States.MainMenu;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                          Alphacore");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                     Controls            Start            Secret");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                                 Exit");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("         Type the word you want to go to and hit enter.");
            Terminal.WriteLine(" ");
        }

        void Controls()
        {
            currentState = States.Controls;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                              Controls");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("The game is simple. In order to win, you'll have to choose");
            Terminal.WriteLine("all the correct answers. To do so, just type the number");
            Terminal.WriteLine("of the answer and hit enter.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void SecretWarning()
        {
            currentState = States.SecretWarning;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                   ! SPOILER ALERT !");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                   Are you sure you want to continue?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                     Type YES or NO.");
            Terminal.WriteLine(" ");
        }

        void SecretMenu()
        {
            currentState = States.SecretMenu;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                          Secret Menu");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            1 = Handyman                      6 = Coldblooded");
            Terminal.WriteLine("            2 = Peacekeeper               7 = Hungry Hobo");
            Terminal.WriteLine("            3 = Casanova                       8 = Vampire's Dream");
            Terminal.WriteLine("            4 = Wrong Exit                   9 = Healthy Diet");
            Terminal.WriteLine("            5 = Greedy Survivor         10 = Doctor");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Type the number of the ending you want to see");
            Terminal.WriteLine("the answers of.");
            Terminal.WriteLine(" ");
        }

        void Handyman()
        {
            currentState = States.Handyman;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                             Handyman");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 1");
            Terminal.WriteLine("            Choice 2 = 1");
            Terminal.WriteLine("            Choice 3 = 1");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
            
        }
        
        void Peacekeeper()
        {
            currentState = States.Peacekeeper;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                          Peacekeeper");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 1");
            Terminal.WriteLine("            Choice 2 = 2");
            Terminal.WriteLine("            Choice 3 = 1");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
            
        }
        
        void Casanova()
        {
            currentState = States.Casanova;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                             Casanova");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2");
            Terminal.WriteLine("            Choice 2 = 1");
            Terminal.WriteLine("            Choice 3 = 2");
            Terminal.WriteLine("            Choice 4 = 1");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void WrongExit()
        {
            currentState = States.WrongExit;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                           Wrong Exit");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2");
            Terminal.WriteLine("            Choice 2 = 2");
            Terminal.WriteLine("            Choice 3 = 1");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void GreedySurvivor()
        {
            currentState = States.GreedySurvivor;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                       Greedy Survivor");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2");
            Terminal.WriteLine("            Choice 2 = 2");
            Terminal.WriteLine("            Choice 3 = 2");
            Terminal.WriteLine("            Choice 4 = 2");
            Terminal.WriteLine("            Choice 5 = 2");
            Terminal.WriteLine("            Choice 6 = 1");
            Terminal.WriteLine("            Choice 7 = 1");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void Coldblooded()
        {
            currentState = States.Coldblooded;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                            Coldblooded");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2");
            Terminal.WriteLine("            Choice 2 = 2");
            Terminal.WriteLine("            Choice 3 = 3");
            Terminal.WriteLine("            Choice 4 = 2");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void HungryHobo()
        {
            currentState = States.HungryHobo;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                          Hungry Hobo");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2");
            Terminal.WriteLine("            Choice 2 = 2");
            Terminal.WriteLine("            Choice 3 = 3");
            Terminal.WriteLine("            Choice 4 = 1");
            Terminal.WriteLine("            Choice 5 = 1");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void VampiresDream()
        {
            currentState = States.VampiresDream;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                       Vampire's Dream");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2");
            Terminal.WriteLine("            Choice 2 = 2");
            Terminal.WriteLine("            Choice 3 = 3");
            Terminal.WriteLine("            Choice 4 = 1");
            Terminal.WriteLine("            Choice 5 = 2");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void HealthyDiet()
        {
            currentState = States.HealthyDiet;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                          Healthy Diet");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2");
            Terminal.WriteLine("            Choice 2 = 2");
            Terminal.WriteLine("            Choice 3 = 2");
            Terminal.WriteLine("            Choice 4 = 2");
            Terminal.WriteLine("            Choice 5 = 2");
            Terminal.WriteLine("            Choice 6 = 1");
            Terminal.WriteLine("            Choice 7 = 2");
            Terminal.WriteLine("            Choice 8 = 1");
            Terminal.WriteLine("            Choice 9 = 3");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void Doctor()
        {
            currentState = States.Doctor;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                                Doctor");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("            Choice 1 = 2                         Choice 10 = 1");
            Terminal.WriteLine("            Choice 2 = 1                         Choice 11 = 1");
            Terminal.WriteLine("            Choice 3 = 1                         Choice 12 = 1");
            Terminal.WriteLine("            Choice 4 = 1                         Choice 13 = 2");
            Terminal.WriteLine("            Choice 5 = 2");
            Terminal.WriteLine("            Choice 6 = 2");
            Terminal.WriteLine("            Choice 7 = 2");
            Terminal.WriteLine("            Choice 8 = 3");
            Terminal.WriteLine("            Choice 9 = 2");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void GameWarning()
        {
            currentState = States.GameWarning;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                    Are you sure you want to continue?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                       Type YES or NO.");
            Terminal.WriteLine(" ");
        }

        void Prologue()
        {
            currentState = States.Prologue;
            Terminal.ClearScreen();
            Terminal.WriteLine("                                            Prologue");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("It's the year 2034. It is winter. The world has come to");
            Terminal.WriteLine("an end due to the consequences of climate change, war");
            Terminal.WriteLine("and overpopulation. The United States, Russia, and China");
            Terminal.WriteLine("have started a nuclear war in which 8.3 billion people got");
            Terminal.WriteLine("killed...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Fortunately, you are one of the few people who survived.");
            Terminal.WriteLine("The earth's population is less than 200 million and");
            Terminal.WriteLine("still declining...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                              Type NEXT to go continue.");
            Terminal.WriteLine(" ");
        }

        void FindCar()
        {
            currentState = States.FindCar;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Some strangers told you to go to the city. They said there");
            Terminal.WriteLine("where more survivors down there. There is clean water,");
            Terminal.WriteLine("food and a save place to take shelter. After you have");
            Terminal.WriteLine("walked for 3 hours you come across an abandoned car...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Wow, that car is in perfect condition! If I steal");
            Terminal.WriteLine("          it, it would save me 2 full days of walking.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Steal the car.");
            Terminal.WriteLine("2 = Continue walking.");
            Terminal.WriteLine(" ");
        }

        void Roadblock()
        {
            currentState = States.Roadblock;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You enter the car and start driving down the road. After");
            Terminal.WriteLine("driving for an hour you come across a roadblock...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Damn it! I didn't see that coming. I could search for");
            Terminal.WriteLine("          another way to the city or I could just smash it and");
            Terminal.WriteLine("          have the risk that my car brakes down.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Smash through it.");
            Terminal.WriteLine("2 = Find another way.");
            Terminal.WriteLine(" ");
        }

        void DriveThrough()
        {
            currentState = States.DriveThrough;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("As you decided, you put your car in reverse and slowly");
            Terminal.WriteLine("drive backwards...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("There's now 50m between you and the roadblock. You put ");
            Terminal.WriteLine("your car back in gear 1 and start to accelerate. You're");
            Terminal.WriteLine("driving faster and faster and a couple seconds later you");
            Terminal.WriteLine("hit the roadblock...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                              Type NEXT to continue.");
            Terminal.WriteLine(" ");
        }

        void BrokenCar()
        {
            currentState = States.BrokenCar;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Your car starts to smoke and you quickly get out. You open");
            Terminal.WriteLine("up the hood...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Shit! Why didn't I think this through. Maybe I can");
            Terminal.WriteLine("          try to repair it. Or I'll just continue on foot. It");
            Terminal.WriteLine("          shouldn't be that far anymore.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Try to repair the car.");
            Terminal.WriteLine("2 = Continue on foot.");
            Terminal.WriteLine(" ");
        }

        void WolfKillCar()
        {
            currentState = States.WolfKillCar;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("As soon as you started to repair your car, a wolf jumped");
            Terminal.WriteLine("out of the bushes and bit you in your neck...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void FindWayCar()
        {
            currentState = States.FindWayCar;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You turn your car and enter the nearest exit. After 10");
            Terminal.WriteLine("minutes you come across a narrow road. You don't trust");
            Terminal.WriteLine("it and suddenly you got surrounded by 2 men...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("STRANGER 1: Yo! Get your ass out of the car and put");
            Terminal.WriteLine("                         your hands in the air!");
            Terminal.WriteLine("STRANGER 2: We are not playing with you!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Surrender yourself.");
            Terminal.WriteLine("2 = Try to flee.");
            Terminal.WriteLine(" ");
        }

        void Flee()
        {
            currentState = States.Flee;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You decided to flee. You quickly turn your car and start");
            Terminal.WriteLine("to drive back in the direction you came from. As you come");
            Terminal.WriteLine("closer to the roadblock you saw earlier, you came across");
            Terminal.WriteLine("another way to the city...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("As soon as you enter the exit, you run out of gas and your");
            Terminal.WriteLine("car starts to decelerate. You look in your mirrors but you");
            Terminal.WriteLine("don't see them anymore. You carefully leave the car...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Shit! Now I have to walk to the city!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                              Type NEXT to go continue.");
            Terminal.WriteLine(" ");
        }

        void SurrenderKill()
        {
            currentState = States.SurrenderKill;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You surrendered yourself and got blindfolded. After 10");
            Terminal.WriteLine("minutes of walking one the strangers took off your");
            Terminal.WriteLine("blindfold. The other stranger points a gun to your head...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go to back the main menu.");
            Terminal.WriteLine(" ");
        }

        void FindHouse()
        {
            currentState = States.FindHouse;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continued walking. After 4 hours you start to see");
            Terminal.WriteLine("a house in the distance. It looks old and abandoned. You");
            Terminal.WriteLine("also hear someone calling for help...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Who is screaming? Maybe I should take a look and");
            Terminal.WriteLine("          see what's wrong.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Search the old house.");
            Terminal.WriteLine("2 = Continue walking.");
            Terminal.WriteLine(" ");
        }

        void SearchHouse()
        {
            currentState = States.SearchHouse;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("The screaming gets louder as you enter the house. The");
            Terminal.WriteLine("house is old and dusty. There are cobwebs everywhere");
            Terminal.WriteLine("and there is no sign of life...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: It seems like the screaming is coming out of the");
            Terminal.WriteLine("          basement. Should I go take a look?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Search the attic.");
            Terminal.WriteLine("2 = Search the basement.");
            Terminal.WriteLine("3 = Leave the house.");
            Terminal.WriteLine(" ");
        }

        void SearchAttic()
        {
            currentState = States.SearchAttic;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You walk upstairs. The attic is filled with dusty shelves");
            Terminal.WriteLine("and boxes. You decided to open one of the boxes...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Look at that. An old rifle! Maybe I should take it");
            Terminal.WriteLine("          with me just in case.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take the gun.");
            Terminal.WriteLine("2 = Leave the gun.");
            Terminal.WriteLine(" ");
        }

        void SearchBasement()
        {
            currentState = States.SearchBasement;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You carefully open the door to the basement. You slowly");
            Terminal.WriteLine("walk down the stairs. When you enter the basement you");
            Terminal.WriteLine("see a woman covered in blood and tied up to a chair...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("WOMAN: Please! Help me!");
            Terminal.WriteLine("YOU: Why should I trust you? Maybe this is a trap.");
            Terminal.WriteLine("WOMAN: It's not. Please untie me quick! My wrists hurt.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Release the woman.");
            Terminal.WriteLine("2 = Leave the woman.");
            Terminal.WriteLine(" ");
            
        }

        void LadyKill()
        {
            currentState = States.LadyKill;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("As you start untying her, the woman jumps away and");
            Terminal.WriteLine("grabs a knife. She points the knife at you and without");
            Terminal.WriteLine("hesitating stabs you in your neck...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void ContinueSearch()
        {
            currentState = States.ContinueSearch;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Would you like to continue searching the house or do you");
            Terminal.WriteLine("want to leave the house and continue walking?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Continue searching.");
            Terminal.WriteLine("2 = Leave the house.");
            Terminal.WriteLine(" ");
        }

        void WalkingSupermarket()
        {
            currentState = States.WalkingSupermarket;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You decided to continue walking. After you walked for");
            Terminal.WriteLine("half an hour you come across a supermarket. You walk");
            Terminal.WriteLine("towards it but hear a strange noise...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I don't know if it's safe. Maybe I should find");
            Terminal.WriteLine("          another way inside? Or just continue.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Enter through main entrance.");
            Terminal.WriteLine("2 = Search for another entrance.");
            Terminal.WriteLine("3 = Continue walking.");
            Terminal.WriteLine(" ");
        }

        void WolfEntranceKill()
        {
            currentState = States.WolfEntranceKill;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You carefully opened the front door. You now see that a");
            Terminal.WriteLine("wolf is making these strange noises. You try to sneak");
            Terminal.WriteLine("past it, but the wolf notices. He jumps at you and tears");
            Terminal.WriteLine("you apart...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void StaffEntrance()
        {
            currentState = States.StaffEntrance;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You decided to look around the building. As you walk");
            Terminal.WriteLine("closer to the back of the building you see a small wall");
            Terminal.WriteLine("lamp. Under the lamp is a door. It has a little sign which");
            Terminal.WriteLine("says: 'Authorized personnel only'...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm not so sure about this. I'm not authorized and I");
            Terminal.WriteLine("          don't want to get into trouble using this entrance!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Enter through main entrance.");
            Terminal.WriteLine("2 = Enter through staff entrance.");
            Terminal.WriteLine(" ");
        }

        void WolfEncounter()
        {
            currentState = States.WolfEncounter;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You carefully opened the front door. You now see that a");
            Terminal.WriteLine("wolf is making these strange noises. It looks like the wolf");
            Terminal.WriteLine("is eating a corpse...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Shit! I don't want to be his next victim. I could sneak");
            Terminal.WriteLine("          past it but it's better to run away while it's still safe.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Run away.");
            Terminal.WriteLine("2 = Sneak past it.");
            Terminal.WriteLine(" ");
        }

        void FindFood()
        {
            currentState = States.FindFood;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("After walking trough the aisles you arrive at the food");
            Terminal.WriteLine("department. Most shelves have already been raided but");
            Terminal.WriteLine("fortunately there are still some sealed cans of beans...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm already starting to get hungry so I should");
            Terminal.WriteLine("          take these last ones before someone else does.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take the food.");
            Terminal.WriteLine("2 = Leave the food.");
            Terminal.WriteLine(" ");
        }
        
        void SearchingSupermarket()
        {
            currentState = States.SearchingSupermarket;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Would you like to continue searching the supermarket or");
            Terminal.WriteLine("do you want to leave and continue your journey?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Continue searching.");
            Terminal.WriteLine("2 = Continue your journey.");
            Terminal.WriteLine(" ");
        }

        void GreedyKill()
        {
            currentState = States.GreedyKill;
            Terminal.ClearScreen();
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You carefully continued searching the supermarket. All");
            Terminal.WriteLine("of a sudden you hear a loud noise. You get shocked and");
            Terminal.WriteLine("you knock over a shelf, but the wolf notices. He jumps");
            Terminal.WriteLine("you and tears you apart...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void ContinueCity()
        {
            currentState = States.ContinueCity;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continue your journey to the city. By now, you start");
            Terminal.WriteLine("to doubt whether there really is a safe place where you can");
            Terminal.WriteLine("life in a society. After a while it started to snow...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so cold. If I don't take shelter in the next couple");
            Terminal.WriteLine("          of minutes I might freeze to death. Luckily I see a");
            Terminal.WriteLine("          building over there. I should take shelter there.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take shelter.");
            Terminal.WriteLine("2 = Continue walking.");
            Terminal.WriteLine(" ");
        }

        void FreezeKill()
        {
            currentState = States.FreezeKill;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You decided to walk further. You're freezing. After you");
            Terminal.WriteLine("walked for 10 minutes you can't feel your toes and fingers");
            Terminal.WriteLine("anymore. You start to get exhausted and your heartbeat");
            Terminal.WriteLine("is raising. Everything becomes blurry and you fall down");
            Terminal.WriteLine("in the snow. You die...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");   
        }
        
        void Hungry()
        {
            currentState = States.Hungry;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You enter the building. Your stomach is rumbling. You");
            Terminal.WriteLine("are very hungry because you haven't eaten for 5 days...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so hungry. If I don't eat now I don't think");
            Terminal.WriteLine("          that I'll make it. I don't have much choice.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Starve to death.");
            Terminal.WriteLine("2 = Cut off your hand.");
            Terminal.WriteLine(" ");
        }

        void StarvationKill()
        {
            currentState = States.StarvationKill;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You decided not to eat. Your stomach hurts and you start");
            Terminal.WriteLine("to feel dizzy. After a while you pass out. You're still dizzy");
            Terminal.WriteLine("when you wake up. You pass out again, but this time you");
            Terminal.WriteLine("don't wake up...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void BleedingKill()
        {
            currentState = States.BleedingKill;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You see a sharp edge of a fence. You are rubbing your palm over");
            Terminal.WriteLine("the fence. There's blood everywhere. You are losing blood to");
            Terminal.WriteLine("quickly and you fall down on the ground...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }

        void ContinueSearch2()
        {
            currentState = States.ContinueSearch2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Would you like to continue searching the house or do you");
            Terminal.WriteLine("want to leave the house and continue walking?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Continue searching.");
            Terminal.WriteLine("2 = Leave the house.");
            Terminal.WriteLine(" ");
        }
        
        void SearchHouse2()
        {
            currentState = States.SearchHouse2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("The screaming gets louder as you enter the house. The");
            Terminal.WriteLine("house is old and dusty. There are cobwebs everywhere");
            Terminal.WriteLine("and there is no sign of life...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: It seems like the screaming is coming out of the");
            Terminal.WriteLine("          basement. Should I go take a look?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Search the attic.");
            Terminal.WriteLine("2 = Search the basement.");
            Terminal.WriteLine("3 = Leave the house.");
            Terminal.WriteLine(" ");
        }
        
        void WalkingSupermarket2()
        {
            currentState = States.WalkingSupermarket2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You decided to continue walking. After you walked for");
            Terminal.WriteLine("half an hour you come across a supermarket. You walk");
            Terminal.WriteLine("towards it but hear a strange noise...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I don't know if it's safe. Maybe I should find");
            Terminal.WriteLine("          another way inside? Or just continue.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Enter through main entrance.");
            Terminal.WriteLine("2 = Search for another entrance.");
            Terminal.WriteLine("3 = Continue walking.");
            Terminal.WriteLine(" ");
        }
        
        void SearchBasement2()
        {
            currentState = States.SearchBasement2;
            Terminal.ClearScreen();
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You carefully open the door to the basement. You slowly");
            Terminal.WriteLine("walk down the stairs. When you enter the basement you");
            Terminal.WriteLine("see a woman covered in blood and tied up to a chair...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("WOMAN: Please! Help me!");
            Terminal.WriteLine("YOU: Why should I trust you? Maybe this is a trap.");
            Terminal.WriteLine("WOMAN: It's not. Please untie me quick! My wrists hurt.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Release the woman.");
            Terminal.WriteLine("2 = Leave the woman.");
            Terminal.WriteLine(" ");
            
        }

        void LadyKill2()
        {
            currentState = States.LadyKill2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("As you start untying her, the woman jumps away and");
            Terminal.WriteLine("grabs a knife. She points the knife at you and without");
            Terminal.WriteLine("hesitating stabs you in your neck...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go to back the main menu.");
            Terminal.WriteLine(" ");
        }
        
        void SearchAttic2()
        {
            currentState = States.SearchAttic2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You walk upstairs. The attic is filled with dusty shelves");
            Terminal.WriteLine("and boxes. You decided to open one of the boxes...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: There's nothing here anymore. I should move on.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Go downstairs");
            Terminal.WriteLine(" ");
        }
        
        void WolfEntranceKill2()
        {
            currentState = States.WolfEntranceKill2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU DIED!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You carefully opened the front door. You now see that a");
            Terminal.WriteLine("wolf is making these strange noises. You try to sneak");
            Terminal.WriteLine("past it, but the wolf notices. He jumps you and tears");
            Terminal.WriteLine("you apart...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                  Type BACK to go to back the main menu.");
            Terminal.WriteLine(" ");
        }

        void StaffEntrance2()
        {
            currentState = States.StaffEntrance2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You decided to look around the building. As you walk");
            Terminal.WriteLine("closer to the back of the building you see a small wall");
            Terminal.WriteLine("lamp. Under the lamp is a door called. It has a little sign");
            Terminal.WriteLine("which says: 'Authorized personnel only'...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm not so sure about this. I'm not authorized and I");
            Terminal.WriteLine("          don't want to get into trouble using this entrance!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Enter through main entrance.");
            Terminal.WriteLine("2 = Enter through staff entrance.");
            Terminal.WriteLine(" ");
        }

        void WolfEncounter2()
        {
            currentState = States.WolfEncounter2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You carefully opened the front door. You now see that a");
            Terminal.WriteLine("wolf is making these strange noises. It looks like the wolf");
            Terminal.WriteLine("is eating a corpse...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Shit! I don't want to be his next victim. I could sneak");
            Terminal.WriteLine("          past it but it's better to run away now it's still safe.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Run away.");
            Terminal.WriteLine("2 = Sneak past it.");
            Terminal.WriteLine("3 = Shoot it.");
            Terminal.WriteLine(" ");
        }

        void FindFood2()
        {
            currentState = States.FindFood2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("After walking trough the aisles you arrive at the food");
            Terminal.WriteLine("department. Most shelves have already been raided but");
            Terminal.WriteLine("fortunately there are still some sealed cans of beans...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm already starting to get hungry so I should");
            Terminal.WriteLine("          take these last ones before someone else does.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take the food.");
            Terminal.WriteLine("2 = Leave the food.");
            Terminal.WriteLine(" ");
        }
        
        void SearchingSupermarket2()
        {
            currentState = States.SearchingSupermarket2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Would you like to continue searching the supermarket or");
            Terminal.WriteLine("do you want to leave and continue your journey?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Continue searching.");
            Terminal.WriteLine("2 = Leave the supermarket.");
            Terminal.WriteLine(" ");
        }
        
        void FindMedicals2()
        {
            currentState = States.FindMedicals2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continued searching the supermarket. After walking");
            Terminal.WriteLine("trough the aisles you arrive at the drugs department.");
            Terminal.WriteLine("Most shelves have already been raided but fortunately");
            Terminal.WriteLine("there are still some medical supplies left...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Look at that. Some medical supplies! Maybe I should");
            Terminal.WriteLine("          take them with me just in case.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take them.");
            Terminal.WriteLine("2 = Leave them.");
            Terminal.WriteLine(" ");
        }
        
        void ContinueCity3()
        {
            currentState = States.ContinueCity3;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continued your journey to the city. By now, you start");
            Terminal.WriteLine("to doubt whether there really is a safe place where I can");
            Terminal.WriteLine("life in a society. After a while it started to snow...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so cold. If I don't take shelter in the next couple");
            Terminal.WriteLine("          of minutes I might freeze to death. Luckily I see a");
            Terminal.WriteLine("          building over there. I should take shelter there.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take shelter.");
            Terminal.WriteLine("2 = Continue walking.");
            Terminal.WriteLine(" ");
        }
    
        void Hungry2()
        {
            currentState = States.Hungry2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You enter the building. Your stomach is rumbling. You");
            Terminal.WriteLine("are very hungry because you haven't eaten for 5 days...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so hungry. If I don't eat now I don't think");
            Terminal.WriteLine("          that I'll make it. I don't have much choice.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Starve to death.");
            Terminal.WriteLine("2 = Cut off your hand.");
            Terminal.WriteLine(" ");
        }

        void Heal2()
        {
            currentState = States.Heal2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU WON!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You see a sharp edge of a fence. You are rubbing your");
            Terminal.WriteLine("palm over the fence. There's blood everywhere. You use"); 
            Terminal.WriteLine("your medical supplies to stop the wound from bleeding...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                              Type NEXT to go continue.");
            Terminal.WriteLine(" ");
        }

        void SearchingSupermarket3()
        {
            currentState = States.SearchingSupermarket3;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Would you like to continue searching the supermarket or");
            Terminal.WriteLine("do you want to leave and continue your journey?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Continue searching.");
            Terminal.WriteLine("2 = Leave the supermarket.");
            Terminal.WriteLine(" ");
        }
        
        void FindMedicals3()
        {
            currentState = States.FindMedicals3;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continued searching the supermarket. After walking");
            Terminal.WriteLine("trough the aisles you arrive at the drugs department.");
            Terminal.WriteLine("Most shelves have already been raided but fortunately");
            Terminal.WriteLine("there are still some medical supplies left...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: Look at that. Some medical supplies! Maybe I should");
            Terminal.WriteLine("          take them with me just in case.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take them.");
            Terminal.WriteLine("2 = Leave them.");
            Terminal.WriteLine(" ");
        }
        
        void ContinueCity4()
        {
            currentState = States.ContinueCity4;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continued your journey to the city. By now, you start");
            Terminal.WriteLine("to doubt whether there really is a safe place where I can");
            Terminal.WriteLine("life in a society. After a while it started to snow...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so cold. If I don't take shelter in the next couple");
            Terminal.WriteLine("          of minutes I might freeze to death. Luckily I see a");
            Terminal.WriteLine("          building over there. I should take shelter there.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take shelter.");
            Terminal.WriteLine("2 = Continue walking.");
            Terminal.WriteLine(" ");
        }
        
        void Hungry3()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You enter the building. Your stomach is rumbling. You");
            Terminal.WriteLine("are very hungry because you haven't eaten for 5 days...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so hungry. If I don't eat now I don't think");
            Terminal.WriteLine("          that I'll make it. I don't have much choice.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Starve to death.");
            Terminal.WriteLine("2 = Cut off your hand.");
            Terminal.WriteLine(" ");
        }

        void Eat3()
        {
            currentState = States.Eat3;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                         YOU WON!");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You consumed the canned beans you found earlier in the");
            Terminal.WriteLine("supermarket..."); 
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                              Type NEXT to go continue.");
            Terminal.WriteLine(" ");
            
        }
        
        void Hungry4()
        {
            currentState = States.Hungry4;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You enter the building. Your stomach is rumbling. You");
            Terminal.WriteLine("very hungry because you haven't eaten for 5 days...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so hungry. If I don't eat now I don't think");
            Terminal.WriteLine("          that I'll make it. I don't have much choice.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Starve to death.");
            Terminal.WriteLine("2 = Cut off your hand.");
            Terminal.WriteLine("3 = Eat the food.");
            Terminal.WriteLine(" ");
        }

        void ContinueCity5()
        {
            currentState = States.ContinueCity5;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continued your journey to the city. By now, you start");
            Terminal.WriteLine("to doubt whether there really is a safe place where I can");
            Terminal.WriteLine("life in a society. After a while it started to snow...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so cold. If I don't take shelter in the next couple");
            Terminal.WriteLine("          of minutes I might freeze to death. Luckily I see a");
            Terminal.WriteLine("          building over there. I should take shelter there.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take shelter.");
            Terminal.WriteLine("2 = Continue walking.");
            Terminal.WriteLine(" ");
        }

        void SearchingSupermarket5()
        {
            currentState = States.SearchingSupermarket5;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Would you like to continue searching the supermarket or");
            Terminal.WriteLine("do you want to leave and continue your journey?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Continue searching.");
            Terminal.WriteLine("2 = Leave the supermarket.");
            Terminal.WriteLine(" ");
        }
        
        void ContinueCity6()
        {
            currentState = States.ContinueCity6;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You continued your journey to the city. By now, you start");
            Terminal.WriteLine("to doubt whether there really is a safe place where I can");
            Terminal.WriteLine("life in a society. After a while it started to snow...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so cold. If I don't take shelter in the next couple");
            Terminal.WriteLine("          of minutes I might freeze to death. Luckily I see a");
            Terminal.WriteLine("          building over there. I should take shelter there.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Take shelter.");
            Terminal.WriteLine("2 = Continue walking.");
            Terminal.WriteLine(" ");
        }

        void Hungry5()
        {
            currentState = States.Hungry5;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine("You enter the building. Your stomach is rumbling. You");
            Terminal.WriteLine("very hungry because you haven't eaten for 5 days...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("YOU: I'm so hungry. If I don't eat now I don't think");
            Terminal.WriteLine("          that I'll make it. I don't have much choice.");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("What should I do?");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("1 = Starve to death.");
            Terminal.WriteLine("2 = Cut off your hand.");
            Terminal.WriteLine("3 = Eat the food.");
            Terminal.WriteLine(" ");
        }

        void Part2()
        {
            currentState = States.Part2;
            Terminal.ClearScreen();
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                                   To be continued?...");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(" ");
            Terminal.WriteLine("                Type BACK to go back to the main menu.");
            Terminal.WriteLine(" ");
        }
}

