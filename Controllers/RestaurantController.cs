// Jasmine Leek
// 27oct2022
// Restaurant Picker - Endpoints
// this is a webapi that allows a user to generate a random restaurant suggestion when selecting from 3 types of cuisine
// peer review: by Amardeep Mann: "Underwater adventure at Red Lobster" had me rolling. Great dialogue choices! Code looks great. I love that you didn't hardcode the array lengths in your random number generator. Using the Length property instead was very smart in case you ever add more options. API worked perfectly. Great use of an "else" to account for the user trying an invalid options. Tops work- keep it up!

using Microsoft.AspNetCore.Mvc;

namespace LeekJRestaurantPickerEP.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    [HttpGet]
    [Route("cuisine/{userChoice}")]
    public string businessName(string userChoice)
    {
        string[] seafood = new string[] { "Red Lobster", "Cocoro", "Ahipoki", "JJ's Fish & Chicken", "Ray's Chicken & Fish Mart", "Captain Crab", "Mikey's Tacos", "El Rancho", "Dynasty", "Long John Silver's" };
        string[] pizza = new string[] { "Round Table", "Domino's", "Market Tavern", "Eric's Pizza", "David's Pizza", "Michael's Pizza", "Lovotti Pizza Pub", "Alfalfa's Pizza & Deli", "Little Caesars", "Mountain Mike's Pizza" };
        string[] bakery = new string[] { "Trail Coffee", "Poppy Coffee", "M&W Dutch", "House of Shaw", "Magda's", "Panaderia Mejia", "Genova Bakery", "Toot Sweets", "La Boulangerie", "Boudin SF" };

        int index = 0;
        Random rand = new Random();

        if (userChoice == "seafood")
        {
            index = rand.Next(seafood.Length);
            string sea = seafood[index];
            return $"It's an underwater adventure at {sea}!";
        }
        else if (userChoice == "pizza")
        {
            index = rand.Next(pizza.Length);
            string slice = pizza[index];
            return $"Go enjoy pizza night at {slice}!";
        }
        else if (userChoice == "bakery")
        {
            index = rand.Next(bakery.Length);
            string baked = bakery[index];
            return $"Get some baked goodies at {baked}!";
        }
        else
        {
            return "Invalid option - please try again.";
        }
    }
}