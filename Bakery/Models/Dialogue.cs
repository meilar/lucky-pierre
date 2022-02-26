namespace Bakery.Models
{
  public class Dialogue
  {

    public static string Intro = @"
        Welcome to Pierre's Bakery. We sell baked goods, BREAD and PASTRIES.
        Do you know what JAMES BEARD said about bread? 
        
        'Good bread is the most fundamentally satisfying of all foods; 
        and good bread with fresh butter, the greatest of feasts.'

        We have a YUKON HERITAGE DAY special this weekend.

                      Bread                         Pastries
                    =========                     ===========
                    $5 per loaf                     $2 each
                    BUY 2 GET 1 FREE!               $5 for 3

    ";

        public static string About = @"
      ---------------------------------------------------------


                                  (
                                  )
                            __..---..__
                        ,-='  /  |  \  `=-.
                        :--..___________..--;
                        \.,_____________,./
      


        PIERRE'S BAKERY was established in 1932, when Pierre 'Pip' Flower-Pounder
        made a pie for his friend Jim, and Jim said 'Huh, this is pretty good. You
        should open a bakery.' 

        For the past nine decades, PIERRE'S BAKERY has been providing quality past-
        ries, pies, cakes, and small desserts to the Montavilla neighborhood. Pip
        retired in 1957, but his grand-daughter E. Claire has stepped up to run the
        business. 

        Come visit us soon!

        Press ENTER to return to the navigation menu.
    ";
    
    public static string BreadPrompt = @"
        Would you like to buy any BREAD? Enter a number of loaves to purchase, 
        or enter 0 to decline.
    ";

    public static string Success = @"
        Success. Returning you to navigation menu.
    ";
    public static string Error = @"
        I'm afraid I don't understand you. Let's try again. 
        Press ENTER to return to the navigation menu.
    ";

    public static string NavPrompt = @"
        Enter 'bread' to purchase bread. Enter 'pastry' to purchase pastry.  
        Enter 'order' to display your current order. Enter 'restart' to start 
        your order all over again. Enter 'about' to learn about Pierre's Bakery. 
        Or, enter 'checkout' to pay and start chowing down on that delicious bread.
    ";

    public static string PastriesPrompt = @"
        As ALAIN BREMOND-TORRENT once wrote:

        'The softest pain on earth must be the pain au chocolat.'

        Would you like to buy any PASTRIES? Enter a number of treats to purchase, 
        or enter 0 to decline.
    ";

    public static string Outtro = @"
        Oh, and don't forget, as MAHATMA GHANDI said:

        'There are people in the world so hungry, 
                
                that God cannot appear to them 
                        
                                    except in the form of bread.'

    ";

        public static string Banner = @"
      --------------------------------------------------------------------------          
        ____  _                             ____        __                  
       / __ \(_)__  _____________  _____   / __ )____ _/ /_____  _______  __
      / /_/ / / _ \/ ___/ ___/ _ \/ ___/  / __  / __ `/ //_/ _ \/ ___/ / / /
     / ____/ /  __/ /  / /  /  __(__  )  / /_/ / /_/ / ,< /  __/ /  / /_/ / 
    /_/   /_/\___/_/  /_/   \___/____/  /_____/\__,_/_/|_|\___/_/   \__, /  
                                                                  /____/   

        Version 1. 0 (c) 2022 Matthew Eilar

      --------------------------------------------------------------------------          

        Press ENTER to continue.
    ";

    
    public static string Grafix = @"
                   ______                ____               __
                  / ____/___  ____  ____/ / /_  __  _____  / /
                 / / __/ __ \/ __ \/ __  / __ \/ / / / _ \/ / 
                / /_/ / /_/ / /_/ / /_/ / /_/ / /_/ /  __/_/  
                \____/\____/\____/\__,_/_.___/\__, /\___(_)   
                                            /____/                                                                  
                                                                                        
                                        ██████                                    
                            ████████████░░░░░░██                                  
                          ██░░░░░░░░░░░░██░░░░░░██████                            
                        ██░░░░░░░░░░░░░░██░░░░░░██░░░░██                          
                      ██░░░░░░░░░░░░░░░░░░██░░░░██░░░░░░██                        
                      ██░░░░░░░░░░░░░░░░░░░░██░░██░░░░░░██                        
                      ██░░░░░░░░░░░░░░░░░░░░██░░████████                          
                    ██░░████░░░░░░░░░░░░░░░░██░░██                                
                    ██░░░░░░████░░░░░░░░░░░░████                                  
                  ██░░░░░░░░░░░░████░░░░░░░░██                                    
                  ██░░░░░░░░░░░░░░░░██░░░░██                                      
                    ██░░░░░░░░░░░░░░██████                                        
                  ██░░████████░░░░░░██                                            
                  ██░░░░░░░░░░██████                                              
                    ██░░░░░░░░░░██                                                
                  ██░░██████████                                                  
                  ██░░░░░░░░██                                                    
                    ██░░░░██                                                      
                      ████         
    
    ";
  }
}