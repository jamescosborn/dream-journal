# Dream Journal

![Morpheus Dream, from Neil Gaiman's Sandman series](https://nerdist.com/wp-content/uploads/2017/04/663307.jpg)

Somewhere between Reality and Nevermore, your subconscious is up to all sorts of kooky stuff. Why not take a closer look and turn over some metaphysical stones?

The benefits of dream journals are vast. Even the Ancient Egyptians realized the value of 'Dream Books.' According to an article on collective-evolution.com, keeping a dream journal can offer all sorts of benefits:

* Faster problem solving
* Overcoming anxiety
* Opportunity to lucid dream
* Better spiritual awareness

With this Dream Journal app, the user will be able to:

* View a list of all __Entries__
* View details for an entry:   
  * Author  
  * Body  
  * Approx. Sleep Time  
  * Approx. Waking Time  
  * What Were You Doing Before Sleep  
  * Cat Nap (bool)  
  * Experienced Lucidity (bool)  
  * Moment of Lucidity  
  * Tags  
  * Self-Analysis  


* Create a new entry
* Make a comment, or __Interpretation__ on an entry
* Interpretations have the following details:  
  * Author  
  * Body


* Edit and Delete entries  

_Further exploration:_

* Add user authentication, and display unique user email or username for Entries and Interpretations

## Getting Started

To start the website, you'll need the following:

* A command prompt (Terminal or GitBash recommended)
* A web browser (Chrome recommended)
* A local server environment (MAMP recommended)

### Installation Steps

1. In your command prompt, enter:  
  `git clone https://github.com/jamescosborn/dream-scanner.git`
2. Start your SQL server on MAMP.
3. Navigate to the folder with the .csproj in it and enter:   
`dotnet restore`    
`dotnet ef database update`  
4. Enter:  `dotnet run`
5. In a web browser, navigate to http://localhost:5000 (if the command prompt displays a different local host number, enter that one)

### Technologies Used

GitBash  
GitHub   
Atom   
C#  
.NET Core (v1.1)  
Visual Studio 2017  

## Scheduled Updates

* Styling of Views/Entries/Details.cshtml  
* Add Interpretations (CRUD)
* Add User login
* Add User roles, admin role
* Admin can Delete individual Interpretations
* User can only edit and delete their own Entries and Interpretations
* Update AsleepTime and WakeTime from strings to DateTimes
* Method for finding TimeAsleep from comparing AsleepTime and WakeTime
* Method for applying CatNap based on AsleepTime (<1 hour, remove CatNap bool from Entry object)
* Search method for Tags
* __Implement Twitter API to tweet out Dream Summaries!__


## Known Bugs

* line break becomes off center when resizing the browser window on Views/Entries/Create  
* Edit method for Entries is non-functional  

## Contributors

James Carl Osborn  
jamescarlosborn@gmail.com  

## Project Specs

| Description        | Input           | Output  |
| ------------- |:-------------:| -----:|
| User is greeted with a landing page       | localhost:5000       | User sees landing page    |
| User can navigate to a blog section with a collection of dream scanner __entries__       | Clicks "Enter/View List"       | User is shown all dream scanner entries    |
| Clicking on an entry, the user will see all the entry's specific dream __interpretations__       | Clicks "Entry A"       | User sees all interpretations of "Entry A"    |
| User can log a new entry | Clicks "Create new entry" | User inputs their dream to be saved in the list |

## Technical Specs
-blank, placeholder for future

## Developer Notes  
-none right now

## Sources

The incredible and surprising benefits of keeping a dream journal  
http://www.collective-evolution.com/2017/10/04/the-incredible-surprising-benefits-of-keeping-a-dream-journal/

## License

This project is licensed under the MIT License.

## Acknowledgments

Thank you to my teachers, fellow students, friends, family and pets for your continued support and inspiration.  

:shipit:
