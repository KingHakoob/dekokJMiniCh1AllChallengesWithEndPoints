// Jacob Dekok
// 10/25/2022
// Mini Challenge #1 - All Mini Challenges with Endpoints
// This is a recreation of all of our previous Mini Challenges
// with a postman friendly format
// Peer Reviewed by: Freddy Aguilar - The mini challenge was successfully converted
// to API format and functioned on Postman. I entered my input at the end of the url
// and it output The sentence with my output.


using Microsoft.AspNetCore.Mvc;

namespace dekokJMiniCh_1AllChallengesWithEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AllForOneController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh1/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}";
    }

    [HttpGet]
    [Route("MiniCh2/{num1}/{num2}")]

    public int Adding(int num1, int num2)
    {
        return num1 + num2;
    }

    [HttpGet]
    [Route("MiniCh3/{userName}/{userFavFood}")]

    public string AskingQuestions(string userName, string userFavFood)
    {
        return $"What's your name? What is your favorite food?       My name is {userName}, and my favorite food is {userFavFood}.";
    }

    [HttpGet]
    [Route("MiniCh4/{num1}/{num2}")]

    public string GreaterOrLess(int num1, int num2)
    {
        if (num1 > num2) return $"{num1} is greater than {num2}";
        if (num1 < num2) return $"{num2} is greater than {num1}";
        else return $"{num1} is equal to {num2}";
    }

    [HttpGet]
    [Route("MiniCh5")]

    public string MadLib()
    {
        return "Who can tell me what a happy lib is?(MadLib)";
    }

    [HttpGet]
    [Route("MiniCh6/{num}")]

    public string OddOrEven(int num)
    {
        if (num % 2 == 0) return $"{num} is even"; else return $"{num} is odd";
    }

    [HttpGet]
    [Route("MiniCh7/{word}")]

    public string ReverseIt(string word)
    {
        char[] charArray = word.ToCharArray();
        string reversedInput = "";

        for (int i = charArray.Length - 1; i > -1; i--)
        {

            reversedInput += charArray[i];
        }

        return reversedInput;
    }

    [HttpGet]
    [Route("MiniCh8/{userQuestion}")]

    public string Magic8(string userQuestion)
    {
        Random random = new Random();
        string[] answer = {"Yes", "No", "Maybe", "Certainly",
    "Definately", "Definately Not"};

        int index = random.Next(answer.Length);
        return answer[index];
    }

    [HttpGet]
    [Route("MiniCh9/{restaruantType}")]

    public string RestaurantPicker(string restaruantType)
    {
        Random random = new Random();

        string[] fastFood = {"Mc Donalds", "Carls Jr", "Wendys", "Taco Bell", "Sonic",
    "Panda Express", "In n Out", "Chic Fil A", "Caines", "Popeyes"};

        string[] delivery = {"Round Table", "Dominos", "Chinese", "Mountain Mikes", "Door Dash Chipotle",
    "Door Dash Sushi", "Door Dash Burger King", "Sandwich", "Door Dash Carls Jr", "Dennys"};

        string[] dineIn = {"Pizza Plus / Gold Dust Pizza", "Veronas", "Esmeraldas", "Masumi", "Mikes Grill House",
    "Brothers", "Taqueria", "Las Casuelas", "Texas Roadhouse", "Red Robbins"};

        string[] all = {"Mc Donalds", "Carls Jr", "Wendys", "Taco Bell", "Sonic",
    "Panda Express", "In n Out", "Chic Fil A", "Caines", "Popeyes", "Round Table", "Dominos", "Chinese", "Mountain Mikes", "Door Dash Chipotle",
    "Door Dash Sushi", "Door Dash Burger King", "Sandwich", "Door Dash Carls Jr", "Dennys", "Pizza Plus / Gold Dust Pizza", "Veronas", "Esmeraldas",
    "Masumi", "Mikes Grill House", "Brothers", "Taqueria", "Las Casuelas", "Texas Roadhouse", "Red Robbins"};

        int fastFoodIndex = random.Next(fastFood.Length);
        int deliveryIndex = random.Next(delivery.Length);
        int dineInIndex = random.Next(dineIn.Length);
        int allIndex = random.Next(all.Length);

        if (restaruantType == "fastfood") return fastFood[fastFoodIndex];
        if (restaruantType == "delivery") return delivery[deliveryIndex];
        if (restaruantType == "dinein") return dineIn[dineInIndex];
        if (restaruantType == "all") return all[allIndex];
        else return "Not a valid restaruant type";
    }

}