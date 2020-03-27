# Disqus comments to GitHub issues

I created this tool to migrate Disqus comments to GitHub issues.  
I did the migration to move back from Disqus as a comment system for my blog.  
I wanted to have full control and full ownership of the comments of my blog.  
I wrote more about that in this blog post: https://asp.net-hacker.rocks/2018/11/19/github-comments.html
I found a service called [utterances](https://utteranc.es/) that provides a small script that integrates GitHub issues as blog comments on a web page.

Utterances works awesomely great and I needed a way to move my old Disquss comments to my GitHub repo. 

Disqus provides a way to export all comments to a XML file that needs to be downloaded and to be stored somewhere on your computer.

## How to use this tool

First, go to https://disqus.com/ and go through their Export tool to export all the comments on your site to an XML file.

The source file `program.cs` is the entry point. Compile the code and run the compiled exe with four command-line arguments: <path to Disqus XML file>, <GitHub username>, <GitHub repo name>, <GitHub personal access token>
