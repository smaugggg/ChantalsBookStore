Chantal Monette	W0800871
WEB452-22F WEB APPS IN ASP.NET	Andrew Steele
Assignment 2

	20221101
0847 - Created the base project. 
	   I can't seem to figure out how to add areas and all that
	   So instead I skipped ahead and got a bootstrap theme from bootswatch. 
	   I combined 2 themes, because I liked the colours from Darkly, but the style of Lux. 

0928 - Got everything working. Installed Packages and all that. Now to change the namespaces.

0959 - Running into an issue with Slide 34 in the ppt. 
	   The errors are saying that the models namespace or whatever doesn't exist. 
	   That makes no sense to me. 
	   What do? Will ask Andrew after the lecture.

1016 - Restarted the project so I could get to a point before I installed the packages. I think that's where I went wrong.
	   So far so good.
	   Up to Slide 30, everything is working except the dropdown menu. 
	   Adding Projects

1022 - The default projects weren't compatible with the packages to install. 
       Changed to 5.0(out of support) to try. 

1024 - The Relational won't load into the dataaccess project. 
       Figured it out:
		I had to change to version 5.0.11 like in the pdf. DUH!!!!
	   Slide 32 Complete and working. 

1029 - Identy.EntityFrameworkCore installed
	   Namespace modified as shown
	   Class1.cs deleted for all projects. 
	   Slide 33 complete. Note that there are still 3 errors in the Startup.cs... not sure what to do. 
		Tried changing the .data to .DataAcess.Data.... still doesn't do anything. Might have to ask. 
	   Moving on for now....

1055 - I'm having a lot of errors saying that models doesn't exist in the namespace/missing a reference. 
	   I'm going to make a github repo and commit what I have but I'll have to get help here cause I've tried a few things to no avail