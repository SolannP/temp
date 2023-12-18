

Time 
date        ; début  ; fin   ; total ; comment ;
2023/10/25  ; 13h50  ; 17h03 ; 3h10  ; first ;
2023/10/26  ; 17h20  ; 18h15 ; 1h00  ; cleanning and gauge ;   
2023/10/27  ; 07h00  ; 10h00 ; 3h00  ; Learn lots more about svg ;
2023/10/29  ; 08h15  ; 09h31 ; 1h15  ; Speed calculation ;
2023/11/03  ; 10h40  ; 12h20 ; 2h40  ; Refactor and Speed ;
2023/11/08  ; 14h46  ; 18h00 ; 3h15  ; Try again using angular ;

2023/11/09  ; 11h10  ; 13h10 ; 2h00  ; Start using Blazor ;
2023/11/09  ; 15h30  ; 17h46 ; 2h15  ; Made basic stat ;
2023/11/11  ; 15h30  ; 17h12 ; 1h40  ; Logic of itertor per word
2023/11/12  ; 09h20  ; 11h10 ; 2h00  ; Speed per word;
2023/11/16  ; 07h40  ; 10h10 ; 2h30  ; little fix and better css result;
2023/11/17  ; 08h00  ; 09h30 ; 1h30 ; Made game data and ajustement;

2023/11/18  ; 07h46  ; 08h46 ; 1h00 ; data schema for basic WS (target text);
2023/11/19  ; 07h45  ; 08h45 ; 1h00 ; basic back arch and file/json handling in C#;
2023/11/19  ; 14h25  ; 15h37 ; 1h10 ; add difficulty change (increase/dicrease) on click
2023/11/21  ; 10h00  ; 12h00 ; 2h00 ; database initialised using file 
2023/11/21  ; 12h30  ; 14h00 ; 1h30 ; change schema and add basic list of game
2023/11/22  ; 11h15  ; 12h15 ; 1h00 ; page navigation possibilities
2023/11/23  ; 12h00  ; 13h30 ; 1h30 ; Bug fix ;
2023/11/23  ; 14h30  ; 15h45 ; 1h15 ; Bug fix ;
2023/11/23  ; 16h10  ; 17h00 ; 1h00 ; data ;

2023/11/24  ; 10h30  ; 11h00 ; 0h30 ; clean and test
2023/11/25  ; 08h30  ; 09h44 ; 1h15 ; look for SQL Server install using docker 
2023/11/28  ; 18h00  ; 19h45 ; 1h45 ; Make SQL server within docker working



=====================================================
Make a game for speed typing with german declinaison. 
data : 2h
game : 6h
score and info : 4h
======================================================

# Day 1 - 2023/10/25

Angular is so tricky .. But succed to make input for playing !  
Good !   

# Day 2 - 2023/10/26 

Spend some time for syncronise .ssh folder between two PC, working instantly that's great !  
Have to setup Angular (install Node, intall pkg, cmd to update...)  

Can transform the target text into editor of chalenge (Input the data like "ich mich dich", version++ "Ich Mich Dich", version++ with ë   
There is some gauge lib but I'm not very keen on use external lib.  
I prefer the most simple implementation (svg + css for animate) and that would be enought.   
In that way no, no need to work later with lib conflict, migraiton, ect.
But that represent a lot of work to create a gague from scratch.

# Day 3 - 2023/10/27 

I find lib with canvas and corresponding angular lib but I'm not confident using them : if any modification have to be done that could be hard.  
In addition, it have not been updated since several years... I will continue using SVG.  
Two possible way to animate : using svg or using css.  Svg provide interesting <animateMotion> allowing to follow the path  
Find amazing result using svg and animaiton !   

# Day 4 - 2023/10/29

Stuck with a `>`, lost about 30 minutes ...  
Think about how to calculate speed.

# Day 5 - 2023/11/03

Took just a lots of time for no reason..  
Must of the time was for good speed calculation and math trick.  
The refactoring took some of the time. I should try to code super fast and THEN refactoring.    
The time spend for the animation don't worth it, for now we have only sequential update of the gauge; not smooth like the first test.

Can add data of speed under each words if it is interesting for the user, that's rather general speed.
Section of online player score can be great (diffculty x speed?)

# Partial conclusion

It took 11 hours for now but we are far from a nice enought result.  
I should have use already existing Gauge rather spend time to make it from scratch.  
Nevertheless the time spend playing with SVG was a great way to learn how it work a little bit more and get better view onto the possibilities.    
I'm bad at coding or is framework not fitted for the task I want to achieve ? That's some time I'm using anguilar now and I feel that there is no great progression.  
When I look on [10 most popular angular web site](https://wiredelta.com/10-most-popular-angular-websites-of-2021/), it turn up that mainly are static web site (but after checks, some have already adopted for Vue.js)
Very dynamic content should not use angular. I tough i will be fitted but that's ok for basic web site when you want to add better interactivity dynamic content.  

[https://w3techs.com/technologies/details/js-angularjs](https://w3techs.com/technologies/details/js-angularjs)  is great for analisyng tools used for a web site !  
https://w3techs.com/technologies/history_overview/javascript_library/all


> The right tools for the right job : for game it's better to use game lib/tools (Gauge.js,unity,godot,phaser,...)

> Angular is good for static web site that need very dynamic effect


data : 2h => not spend yet..  
game + score and info : 6h + 4h ==> we are at 11 hour out of 10 scheduled  

# Day 6 - 2023/11/08

Spend a lot of time for nothing.

# Day 7 - 2023/11/09

Angular seem not healthy : 
  - some people on LinkedIn change there name from "Angular expert" to Angualr and react expert
  - new change again of core item (*ngIf into @if ... like razor ?) + new hydratation stuff + [...] 
Let move ot Razor/Blazor Web Assembly (WASP) or Server Rendered wich seems a more fittend alternative.  

It's very convenient when coding using blazor !  
Far better than Typescript for having the work done : not endless details, quick fix or trick  

For now there is no surpise in the behavior of the razor componenent (unlike anular/ts).
I'm amazed how, within a few hours (4h), I have managed to get a very satisfing result.
I didn't spend time in design prior to start (I was grasping the concept of razor) so some additional hours will be needed.

# Day 8 - 2023/11/11

Made the logic for word counting rather than caracter. 
A refactoring would be greate but no really needed as it's a side project. 
Maybe using an iterator pattern for the whole game is a good idea because it will be easier to grasp concept when I come back

# Day 9 - 2023/11/12

Get some surprise with object that are pass by ref and not by value. But clonable make it easier.  
Moreover, having object composed of minimal data (imutable) and properties that not store data/state but calculate into those object is really great : that's a lot of less work when updatng !

# Day 10 - 2023/11/12

As a reminder, here is the summary when casting (some time since I have to face those type conversion problem, specialy *truncation toward zero* with int/int).
+---------------------+------------------------+---------------------------+---------------------------+-----------------------------+
|      Operation      |       int / int        |      int / double         |      double / int         |     double / double         |
+---------------------+------------------------+---------------------------+---------------------------+-----------------------------+
| Result Type         |        int             |         double            |         double            |         double              |
+---------------------+------------------------+---------------------------+---------------------------+-----------------------------+
| Example             |   int result = 5 / 2;  |   double result = 5 / 2.0;|   double result = 5.0 / 2;|   double result = 5.0 / 2.0;|
|                     |   // result = 2        |   // result = 2.5         |   // result = 2.5         |   // result = 2.5           |
+---------------------+------------------------+---------------------------+---------------------------+-----------------------------+

Add fine behavior when game is finished.  
Merging first version of speed typing using character added into current stat game in a better manner.    
Using doc of razor synthax, I have succed to made great result within css.  

*A refactoring will be needed for those logic (around 4 hours) when more use cas would be covered.*
*So far I'm the only one that now how it work but within six month it wil be into god hand.*

The time scheduled for game + score and info is fine : no any extra hour have been needed.


# Day 11 - 2023/11/17

Got some trouble with array and Linq but it turn up that I wrongly split an array : I used `.Split(@"\r\n")` but the correct form was `.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);`  

The data part give me some idea, some extra feature to add if needed:  
  - two type Keyboard svg icon ([¨]+ [u] and [ALT]+[0][2][5][2]) like [here](https://stock.adobe.com/fr/images/id/375640173?k=keyboard%20key%20icon&clickref=1100lxWHLTvR&mv=affiliate&mv2=Freepik&as_camptype=&as_channel=affiliate&as_source=partnerize&as_campaign=Flaticon&as_content=api&as_audience=srp&sdid=6WTV6YJ5)  
  - FR / EN / DE and for each their transform function could be greate
  - Split exercice into categories (verbes&trad : Fahren... , frage word : WasWoher... , iregular verbe : sein,) or level (A1, A2, B1,..)

A hard version and functionS (or code snipset) for split into easier form (`Wass für ein Auto hast du ?` ==`.replace(ü/u,ä/a,ö/o,ß/ss,Ü/U,Ä/A,Ö/)` ==> `Wass fur ein Auto hast du ?` ==`.toLower()` ==> `wass fur ein auto hast du ?` == `.replace('?','!','.',',')`)  
For storage of many target text : 
  - I should add button <easier | harder> 
  - before define schema of data target including target + categories/level ?
     - A csv(or any storage) for de hard version, french hard version?, transform easier german, transform easier french, [...]
	 - markdown (or similar) for formating target result like ? Currently use a div + for each array[iline][ichar][itext], no place for format data..
  
Level basic God (with the meme picture), level asian, level hard, level medium, level easier could be nice

Could be intersting for later : 
  - I MASSIV WORKLOAD: Account to keep result and make stat
  - II MASSIV WORKLOAD: Gamifigication with achievenement (not claimed or best result trophy)
  - III MASSIV WORKLOAD: Admin interface for manage game
  
Other idea more technical : 
  - provide guard against copy past 
  - prevent SQL injection
  - Log
  - Easy deploy
  - Monitoring and Alerting  
  
  
Propose a place for noticed bug/issues from user

Read lib repository on github of C# and blazor (Mazor & blazor ?)   
Interesting book : `Framework Design Guidelines: Conventions, Idioms, and Patterns for Reusable .NET Libraries, 3rd Edition `
Online data : [Framework design guidelines](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/?redirectedfrom=MSDN)

# Conclusion 

It took the same amount of time (arround 12 hour) but the result is far better using blazor than angular.  
The drop of angular append while using it: to much time was spend because of TS trick/Angaulr work around even after lots of time using it (more than a year).  
Using blazor is far more simple : the idea create the code in one row and it work. Within angular, the idea is changed until it's compilant with angular and ts after lots of iteration and edge case.  
I feel fun when using blazor, like I didn't have when coding since some time ! But more than that, it open tons of door for crazy increase of productivity and new tools for next generation architecture (for better or worst : great power implies great responsability).
Some aspect are sill unknow with blazor but I fill more confident to solve them using blazor than angular.  

From design point of view, I noticed than the less data we have, the better it is.  
Specialy if data can be transform/compute into others data/field, then update/change is magic and so simple !  
There is some difficult surprises because object are passed as ref (when use of affectation outside plus an update, there is indeed an update inside).  
Object should propose way to copy them by value but as mentioned above, the less data we have, the easier it is !  
Use of struct (if single value similar to primitive types (int, double, etc.),instance size < 16 bytes,immutable,boxed infrequently
immutable, else class). There is [explication](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct?redirectedfrom=MSDN) but I need a deep understanding of memory usage with C#, like the exact behavior under memory allocation (heap/stack or inline) and garbage collector.  
 
And interesting thought is to propose to the user a way to store Func. In that way he will be able to perform change and that open lots of possibility for some use case (as C#/js/regex or any function that help -> chatGPT for such basic usage)  
Store data in simplest way help to reduce time to change or update. Same is true for end-point(controller). The less we have, the less work it represent.  
I read that it's fine to add column but not to delete regression). View can be used.  

> Dijkstra : "Simplicity is prerequisite for reliability." , "Simplicity is a great virtue but it requires hard work to achieve it and education to appreciate it. And to make matters worse: complexity sells better. "  
  
=====================================================
First back for static content : 4h 
  text,img, ..., data schema, separation of concenrne, basic WS for provided target text
Link Front to back : 4h 
   2h + 2h (Add Game different difficulty into game with button)
Add Game categories (dedicated dash board) : 4h
  2h (data schema) + 2h (front)
data : 2h

if time : Refactoring + Input red si faux + ancien text en vert : 5h
not needed now : SVG animation (4h, [see](https://webgyaani.com/wp-content/uploads/2018/03/10-Beautiful-Animated-CSS-SVG-Landscape-Designs-1.gif))
======================================================

Categories 
 
# Day 12 - 2023/11/18 

For design, I chose to use the less end point possible for reduce as much as possible the work to do. 
Thus, text data is provided as string and not as an url. Use of an url is good because we can make good scaling (plus no need to deal with \n\r) but add complexity (another get for front) and other end point.
Best is to have a id text like id=hash(text).
One end point for constante value accros the app. 
One end point for text.
Both are only GET.  

For POST and DELETE, consol app "UI" like an admin way can be done, there is no use right now to manage create/delete/update text using web api.  
If needed, can be addeed quickly later. Once implemented into "kernel app", that just mapping for consol app or end point web api.
But for the moment no endpoint for that, it will be update into the BDD directly with hand written id, no extra work for the moment (when using api, id will be generated).


Current schema to implement for next time : 
// all common and constant value
GET https://current-serv/constante
{
  "texts" : [ 
    { 
	  "id": "id_text",
	  "title" : "",
	},
	{ 
      "id": "id_text",
	  "title" : ""
	}],
   "tags" : [ "Verbes","Irregular Verbes","Regular verbes"]
   "categories" : [ "", "" ],
}

GET : https://current-serv/text/{id_text}
{ 
  "id_text" : "",
  "title" : "",
  "difficulties" : [
    {  
	  "title" : "easy",
	  "level" : 0,
	  "text" : "string text"
	  ?current_score: [...]
	},
	{
	  "title" : "medium",
	  "level" : 1,
	  "text" : "string text"
	  ?current_score: [...]
	},
	{
	  "title" : "hard",
	  "level" : 2,
	  "text_url" : "string text"
	  ?current_score: [...]
	}],
  "categories" : [ 
    {
      "name" : "Entrainement sur verbe",
	  "id" : "klm"
	},
	{
	  "name" : "BB",
	  "id" : "nbv"
	}],
  "tags": [ "a", "b"]
}

# Day 13 - 2023/11/19 

Spend some time thinking for onion architecture but can be death by design pattern. Must not adding other concept. Almost started to add adaptater and other layer of complexity. 
I ended up make it as much as simple as possible. Kernel have data and format is made in a way to avoid the use of attribut or mapping : data is store as snake case. Bdd is external lib.
It's not because there is some naming convention style that we have to follow it blindly.
Nice separation of consernce is really great, I know were to put logic and I think anyone comming would understand how it work.

Very fast way to add service into blazor (like second, when generated using postman ..)
Could be greate to make like postman for test but in the same wen navigator + export into rest sharp or http call or blazor service.

# Day 14 - 2023/11/21 

Connecting to Gitlab was a pain while working in a moving location, i.e. a train, have to wait 5 seconds for each email because of checking network + email code check every time.
Github is better for now while the bare metal server is not ready for propose repository hebergement.
While loading all data from another pc, I have to re-make the data file..  two possibility : add data into repo for the moment or generate in a raw.

What a surprise, make test file location independent of the computer (proper way to initialise file + test for read and update) take a lot of time (almost 2 hours).  
Have to do unit test to be sure that file connecteur was not responsible of the error.  

It turn up that the controller having ref to app was not static thus construct and destruct every time an end point/controller is call => static make it work (incoming perf issues).


_To verify if it was a good idea: if possible, a field that can be move in the superior hierarchy (name in student better in human) must be move ?_
_To verify if it was a good idea: string as object allow better extend latter (add img, link, url, color ...)_

We can add pagination to the api with common data but another end point could be usefull to.. 

Must update as bellow : 
GET https://current-serv/constante
{
  "all_texts" : [ 
    { 
	  "id": "id_text",
	  "title" : "",
	  "categories" : [ {
          "name" : "Entrainement sur verbe",
	      "id" : "klm"
	     },
	     {
	       "name" : "BB",
	       "id" : "nbv"
	  }],
      "tags": [ {"text":"a"}, {"text":"b"}]
	}],
  "all_tags" : [ {"text":"Verbes"},{"text":"Irregular Verbes",{"text":"Regular verbes"}]
  "all_categories" : [ "", "" ],
}

and 

GET : https://current-serv/text/{id_text}
{ 
  "id_text" : "",
  "title" : "",
  "difficulties" : [
    {  
	  "title" : "easy",
	  "level" : 0,
	  "text" : "string text"
	  ?current_score: [...]
	},
	{
	  "title" : "medium",
	  "level" : 1,
	  "text" : "string text"
	  ?current_score: [...]
	},
	{
	  "title" : "hard",
	  "level" : 2,
	  "text_url" : "string text"
	  ?current_score: [...]
	}]
}


# Day 15 - 2023/11/22

If add Route parameter using blazor (easy and great !).  Within one hour a was able to add routing to text and fullfill the list of game possibilities.  
Work with bootstrape (rounded) + css particularity ( .class + a.class for overide a)  
Optionnal querry can be used for level.  
Worth to read the doc, some tutorial/docs are not the art of work specialy regarding query parameter.  
Some people made complicated and ugly work around but it turn up, when reading doc, that the attribut `[Parameter] + [SupplyParameterFromQuery(Name = "level")]` work perfectly  

Made custom index for the data is a bad idea if simultaneous update : it will lock the file when create new but for now that fine (no update scheduled)
I will add EF for database rather than file. In addition it will improve my understanding of all EF stuff (not now however)

must add categorie and tag ..

GET : https://current-serv/text/{id_text}
{ 
  "id_text" : "",
  "title" : "",
  "difficulties" : [
    {  
	  "title" : "easy",
	  "level" : 0,
	  "text" : "string text"
	  ?current_score: [...]
	},
	{
	  "title" : "medium",
	  "level" : 1,
	  "text" : "string text"
	  ?current_score: [...]
	},
	{
	  "title" : "hard",
	  "level" : 2,
	  "text_url" : "string text"
	  ?current_score: [...]
	}],
	"categories" : [ {
          "name" : "Entrainement sur verbe",
		  "id":"guid"
	     },
	     {
	       "name" : "BB","id":"guid"
		   }
	  }],
    "tags": [ {"text":"a"}, {"text":"b"}]
}


Intersting possibilities for IEnumerable : 
  - Array : size defined when object instantiated (can be anonymous)
    - single dimensional: int[] array = new int[5];
    - Multidimensional : int[,] array2DDeclaration = new int[4, 2];
    - jagged null until init : int[][] arr = new int[2][]; int[][] jaggedArray2 = [[1, 3, 5, 7, 9],[0, 2, 4, 6],[11, 22]];
  - HashSet{Sorted} (does not have Select but usefull join/merge methods)
  - List{Sorted (with Icomparer)}
  - LinkedList (Add with O(1) compared to Array or List which are O(n))
  - {Sorted}Dictionary (concurent)
  - Queue / Stack
  - {ReadOnly}List/Dictionary : propose immutable collection
  
TODO: change url name for controlleur

I was not in the optimum condition for those. I notice that a bad data schema cost a lot when refactoring is needed. 
I will continu using Entity framework for data. I suspect in that way migration and refactoring can be easier.   

I confirm that functional programming is great for getting attribut that can be computed using state value and be sure there is the less data/state possible.

> external note : I read from Domain Driven Design that SMART UI is fine for some project (domain data mixed within the UI). But have dramatic result for long term and big project 

# Day 16 - 2023/11/23

Hash can be tricky because by default new make an unique object so we must implement IEquatable, GetHash and Equals(object) (available with ctrl + generate).  
Code for location is as follow `Path.GetDirectoryName(Assemblie.GetExecutingAssemblies().Location)`  
Debug is quite hard with blazor SSR: call are made by the servuer, thus impossible to see but offer a good way to hide behavior.
Work a lot for understand where this bug whith hash set come from, very curious that there is data added into first text if added twice..

Finally gor it : for an immutable list, when we proceed using select the inner object element then aggregate, it work by ref ! Update are donne into the immutable list too !  
Change Select the Agregate by SelectMany then Distinct but I doesn't find proper way to protect against inside object alteration.

public Get Set is mandatory for .NET but Computed element still present in the json, even without get set (but public!)

No built in method to make immutable element uisng cshapr, very dangerous behavior may occur.

# Conclusion 

It took around 12 hours (out of 14 hours) to add basic web service, back, architecture, blazor page navigation and update schema.  
Regarding all those change, it take minimal amount of time to update.
A bug regarding false immutable object took a lots of time to understand and solve (object asignement are by ref and not by value, even readonly collection are not safe)  
That an aspect of functional programming that must be taking carefully with C#.
It was an occasion to work on the different Collection type.
One of the most important steep is to define the schema.
Interesting concept appear while reading on DDD book : smart UI is a pattern to avoid (in some circonstances) but have some strenght.  

=====================================================
Task I : change url name for controlleur  : 1h
Task II : Explore Mud blazor  : 4h => [ ] +Video ?
Task III : Add SQL Server within Docker  : 2h 
Task IV : Link with EF : migre data to EF schema (2h) + use EF action for current data interaction (4h) 
Task V : Account creation  (create account 1h + stat reccording for each game 2h + add visual of succes 1h)  (8h)

TOTAL : 19h

if time : resolve https://github.com/MudBlazor/MudBlazor/issues/4310
======================================================


# Days 17 - 2023/11/24

Task I : change url name for controlleur made within 15 minute (not 1 hour) + variabilisation of url using appsetings.
Task II : Explore Mud blazor 

Nothing special, at frist sight, it seem wize to choose bootsrap or Mudblazor but avoid a mix of both.  

# Day 18 - 2023/11/25

Task III : Add SQL Server within Docker  : 2h  (rather explore SQL server 4h ?)

# Day 19 - 2023/11/28

I wander if add docker is maybe over engeenering the solution. I read some artciles that state to avoid docker in some case. Especialy docker compose or named image, I don't now why.  
Find interesting article that state : "Using docker-compose is fine if you are working on a single machine or don’t need to distribute containers across multiple inter-connected machines".  
In additioon it's fine for small team. For bigger one k8s is the proper way to go. 
I want to spend the minimum time for deployement and trouble shooting, docker deployement will be done incrementaly, for now let's keep SQL server instance only, automatic deployement will be added latter.
that exactly what we are looking but even, I don't waont to add special steep for configure dokcer deployement  

It take a lot of time to make it work fine. It's done, i should not have any new problem.  
I make an interactive readme/helper script as documentation
Next steep will be to know SQL Server way of working in details. I had a course with school some time ago, i can re open it + get in touch with the teacher we had.  
Schould also avoid latest and use something like 2022-CU10-ubuntu-22.04 (next time)

"Efforts to automate what must be the product of thought are naive and conterproductive"

# Side note - 2023/12/12 

Since the last input, I wanted to get more confident with SQL Server for career purpose.  
It will be the choosen BDD but it can be change using something else thanks to EF and the correct connector.  
By the past I have meet some trouble with MySQL connecteur so SQL Server is not so bad.
I started a book that cover the basic and advanced of TSQL. The book is really good, it help to have strong base and a deeper knowledge of SQL & TSQL.  
