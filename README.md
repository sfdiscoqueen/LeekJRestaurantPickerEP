# LeekJRestaurantPickerEP
// Jasmine Leek
// 27oct2022
// Restaurant Picker - Endpoints
// this is a webapi that allows a user to generate a random restaurant suggestion when selecting from 3 types of cuisine
// peer review: by Amardeep Mann: "Underwater adventure at Red Lobster" had me rolling. Great dialogue choices! Code looks great. I love that you didn't hardcode the array lengths in your random number generator. Using the Length property instead was very smart in case you ever add more options. API worked perfectly. Great use of an "else" to account for the user trying an invalid options. Tops work- keep it up!

User Testing Instructions:

1) Open VS Code, click "Clone Git Repository", then type this link into the toolbar: https://github.com/sfdiscoqueen/LeekJRestaurantPickerEP.git
2) Click F5 to run and debug the program. A local host will be generated through the web browser. Take note of the 4 digit host # needed for step 3.
3) Open Postman, create a new "get" request, then type this link into the toolbar: https://localhost:####/Restaurant/cuisine/{userChoice}. Replace "####" with the 4 digit host.
4) Replace {userChoice} with one of these three options: 'seafood', 'pizza', or 'bakery' - then click send to reveal your local restaurant suggestion.
5) Don't like the suggested place? Click send again to generate a new option, or repeat step 4 with a different cuisine. Enjoy!
