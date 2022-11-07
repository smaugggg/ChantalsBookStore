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

1113 - Restarting the classes turned out to be the right choise
		I was able to recreate them and pay closer attention to the ppts provided
		Everything appears to be working at the moment. Running/Building to make sure.

1120 - Currently getting 2 Errors about package downgrades. 
		https://learn.microsoft.com/en-us/nuget/reference/errors-and-warnings/nu1605?f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(NU1605)%26rd%3Dtrue
	   Trying to figure out how to fix it, but I don't really understand.

1136 - Got the packages downgraded to 3.1.16 to resolve the last two errors I had using the package manager
		Slide 35 Complete

1141 - Created the Customers Area and updated the routes in Startup.cs
		It's getting late so I'll have to work on this more at home/Thursday. 
		Committing to Github before leaving 

	20221103
0001 - Good evening. 
		I cloned the repo to my home computer to get some work done. Lets have a party. 
0005 - IT won't run on my home computer but it was running no problem at school. 
		Made the changes to the dropdown menu button as needed, but I'll have to check tomorrow morning. 
0013 - Did everything through moving _ViewImports and _ViewStart to the Customers Area
		It runs now and appears to work. Lovely!
0016 - Completed Part 1! Ready to show Andrew tomorrow and get to work on Part 2!


	20221106
1713 - Beginning Part 2. Built solution, confirmed no errors:
		========== Build: 4 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
1716 - Attempted to add migration per ppt. Wrong default project selected as predicted!
1717 - Cute 'lil migration created! : BookstoreMigration000.cs
1718 - Database updated per ppt. Build succeeded/done.
		Application runs!
1722 - Created the Category model and added the migration for it: AddCategoryToDb.cs
1735 - Created the IRepository Interface. 
1905 - Took a break to eat and now I'm back. 
		Was having some issues with the Repository class on slide 7.
		It appeared that for some reasing the using statement into the data folder wasn't working. 
		I tried multiple things:
			Moving the DbContext to another folder of a different name. 
			Copying the contents of DbContext and making another one in a different folder. 
			Still nothing. 
		So now I've moved it outside inthe the base .DataAccess project and I'm going to create the Repository class and see what happens I guess. 
1910 - So I wrote out what it said on Slide 7 regarding the public class Repository, and then used the little lightbulb for suggestions. 
		Now it's recognizing everything and everything is back where it should be??????????
		It's working... but I don't know why it wasn't working in the first place. 
			THat's frustrating but also not?
1919 - Finished slide 10, comitting to github.