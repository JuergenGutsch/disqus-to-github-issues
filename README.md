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

## Please note

You need make few changes before use this script:

- Edit `CheckThreadUrl` function in `DisqusToGithubIssues/Program.cs`.  It has code for verification domain for which comments will be added. You need remove that block or change to domain of your blog. Without that changes import will not be working.

```C#
if (!url.StartsWith("http://asp.net-hacker.rocks") &&
    !url.StartsWith("https://asp.net-hacker.rocks"))
{
    return false;
}
```

- In function `PostIssuesToGitHub` you can find templates of imported messages. Possibly you will customise that.

```C#
var message = $@"Comment written by **{post.Author}** on **{post.CreatedAt}**

{post.Message}
";
```

## Run with Docker

Firstly build local image

```bash
$ docker build -t disqus-to-github-issues .
```

Then you can run import 

```bash
$ docker run --rm \
    -v <path to Disqus XML file on host machine>:/app/disqus.xml \
    disqus-to-github-issues:latest \
    run \
        /app/disqus.xml \
        <GitHub username> \
        <GitHub repo name> \
        <GitHub personal access token>
```