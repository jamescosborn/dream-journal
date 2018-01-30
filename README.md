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
1) Author  
2) Body  
3) Approx. Sleep Time  
4) Approx. Waking Time  
5) What Were You Doing Before Sleep  
6) Cat Nap (bool)  
7) Experienced Lucidity (bool)  
8) Moment of Lucidity  
9) Tags  
10) Self-Analysis  


* Create a new entry
* Make a comment, or __Interpretation__ on an entry
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
  `git clone https://github.com/jamescosborn/jco-portfolio.git`
2. Start your SQL server on MAMP.
3. Navigate to the folder with the .csproj in it and enter:   
`dotnet restore`  
`dotnet ef migrations add CodeReview`     
`dotnet ef database update`  
4. Enter:  `dotnet run`
5. In a web browser, navigate to http://localhost:5000 (if the command prompt displays a different local host number, enter that one)

### Technologies Used

GitBash  
GitHub   
GitHub API  
Atom   
C#  
.NET Core (v1.1)  
Visual Studio 2017  

## Scheduled Updates

* Styling of Blog posts, index and details
* Add Email/GitHub/LinkedIn icons
* Further style landing page
* Get a new profile picture  
* Display more info for Top Starred Repos: commits?
* Style nav bar
* Bug fixes

## Known Bugs

* Microsoft.AspNetCore.Mvc.Rendering.MvcForm appears on Admin page next to Logout button

## Contributors

James Carl Osborn
jamescarlosborn@gmail.com  

## Project Specs

| Description        | Input           | Output  |
| ------------- |:-------------:| -----:|
| User is greeted with a landing page, where they see __a picture__       | localhost:5000       | User sees landing page    |
| User can navigate to a blog section with a collection of __blog posts__       | Clicks "Blogs"       | User is shown all blog posts    |
| Clicking on a blog post, the user will see all the blog's specific __comments__       | Clicks "Post A"       | User sees all comments of "Post A"    |
| User is able to log on/off as an administrator | Clicks "Admin" | User is logged in if they have the credentials |
| Only admins can Create, Read, Update, Delete posts | Create a new blog post | Blog post is added to list |
| Only admins are able to remove Comments | Remove comment from blog post | Comment no longer appears on post |
| Projects section displays the top 3 starred GitHub repos | Clicks "Projects" | The top 3 starred GitHub repos for JCO are displayed  |

## Technical Specs
-Ajax required for GET methods on Post CRUD

## Developer Notes  
For info on API calls to starred repos:   
-https://developer.github.com/v3/activity/starring/  

For info on API call parameters:  
-https://developer.github.com/v3/#parameters  

## Sources

The incredible and surprising benefits of keeping a dream journal  
http://www.collective-evolution.com/2017/10/04/the-incredible-surprising-benefits-of-keeping-a-dream-journal/

## License

This project is licensed under the MIT License.

## Acknowledgments

Thank you to my teachers, fellow students, friends, family and pets for your continued support and inspiration.  

:shipit:
