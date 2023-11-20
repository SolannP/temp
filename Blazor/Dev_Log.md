

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
	  "title" : ""
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
I ended up make it as much as simple as possible. Kernel have data and format is made in a way to avoid the use of attribut or mapping : data is store as snake case. Bdd is axternal lib.
It's not because there is some naming convention style that we have to follow it blindly.
Nice separation of consernce is really great, I know were to put logic and I think anyone comming would understand how it work.

Very fast way to add service into blazor (like second, when generated using postman ..)
Could be greate to make like postman for test but in the same wen navigator + export into rest sharp or http call or blazor service.

