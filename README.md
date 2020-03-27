# Disqus comments to GitHub issues

I created this tool to migrate Disqus comments to GitHub issues. 
I did the migration to move back from Disquss as a comment szstem for my blog. 
I wanted to have full controll and full ownership of the comments of my blog. 
I wrote more about that in this blog post: https://asp.net-hacker.rocks/2018/11/19/github-comments.html
I found a service called [utterances](https://utteranc.es/) that provides a small script that integrates GitHub issues as blog comments on a web page.

Utterances works awesomely great and I needed a way to move my old Disquss comments to my GitHub repo. 

Disquss provides a way to export all comments to a XML file that needs to be downloaded and to be stored somewhere on your computer.

## Use this tool

Checkout the sources and open the program.cs

Unfortunately some of the values are hard coded. You need to change the repo name if needed and the repo owner name:
~~~ csharp
private const string repoName = "blog";
private const string repoOwner = "JuergenGutsch";
~~~

On line 175 you need to insert your GitHub access token: 
~~~ csharp
var basicAuth = new Credentials("secret personal token from github");
~~~

If this is done, compile the code and strart the compiled exe by passing the path to the Disquss XML as an argument

## More comes later
If I find some time, I'm going to change the hard coded parts to input arguments. Or Maybe somone else will do a PR to improve this tool :-) 
