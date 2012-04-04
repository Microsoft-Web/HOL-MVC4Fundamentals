<a name="HOLTitle" />
# ASP.NET MVC 4 Fundamentals #

---

<a name="Overview" />
## Overview ##

This Hands-On Lab is based on MVC (Model View Controller) Music Store, a tutorial application that introduces and explains step-by-step how to use ASP.NET MVC and Visual Studio. Throughout the lab you will learn the simplicity, yet power of using these technologies together. You will start with a simple application and will build it until you have a fully functional MVC Web Application.

This Lab will work with ASP.NET MVC 4.

If you wish to explore the ASP.NET MVC 3 version of the tutorial application, you will find it in [http://mvcmusicstore.codeplex.com/](http://mvcmusicstore.codeplex.com/).

> **Note:** This Hands-On Lab assumes that the developer has basic experience with Web Development and technologies such as HTML and JavaScript.

### The Music Store application ###

The Music Store web application to be built throughout this Lab comprises three main parts: shopping, checkout, and administration. Visitors will be able to browse albums by genre, add albums to their cart, review their selection and finally proceed to checkout to login and complete the order. Additionally, store administrators will be able to manage the store's available albums as well as their main properties.

 ![Music Store screens](./images/Music-Store-screens.png?raw=true "Music Store screens")
 
_Music Store screens_

### MVC Essentials ###

Music Store application will be built using **Model View Controller (MVC)**, an architectural pattern that separates an application into three main components:

- **Models**: Model objects are the parts of the application that implement the domain logic. Often, model objects also retrieve and store model state in a database.

- **Views:** Views are the components that display the application's user interface (UI). Typically, this UI is created from the model data. An example would be the edit view of Albums that displays text boxes and a drop-down list based on the current state of an Album object.

- **Controllers:** Controllers are the components that handle user interaction, manipulate the model, and ultimately select a view to render the UI. In an MVC application, the view only displays information; the controller handles and responds to user input and interaction.

 
The MVC pattern helps you to create applications that separate the different aspects of the application (input logic, business logic, and UI logic), while providing a loose coupling between these elements. This separation helps you manage complexity when you build an application, because it enables you to focus on one aspect of the implementation at a time. In addition to managing complexity, the MVC pattern makes it easier to test applications than it is to test a traditional ASP.NET Web application, encouraging the use of test-driven development (TDD) for creating applications.

Then, the **ASP.NET MVC** framework provides an alternative to the ASP.NET Web Forms pattern for creating MVC-based Web applications. The **ASP.NET MVC** framework is a lightweight, highly testable presentation framework that (as with Web-forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication so you get all the power of the core .NET framework.  This is useful if you are already familiar with ASP.NET Web Forms because all the libraries that you already use are available in ASP.NET MVC as well.

In addition, the loose coupling between the three main components of an MVC application also promotes parallel development. For instance, one developer can work on the view, a second developer can work on the controller logic, and a third developer can focus on the business logic in the model.

<a name="Objectives" />
### Objectives ###

In this Hands-On Lab, you will learn how to:

- Create an ASP.NET MVC application from scratch based on the Music Store Application tutorial

- Add Controllers to handle URLs to the Home page of the site and for browsing its main functionality

- Add a View to customize the content displayed along with its style

- Add Model classes to contain and manage data and domain logic

- Use View Model pattern to pass information from controller actions to the view templates

- Explore the MVC 4 new template for internet applications
 
<a name="SystemRequirements" />
### System Requirements ###

You must have the following items to complete this lab:

- Visual Studio 11 Express Beta for Web

<a name="Setup" />
### Setup ###

_**Installing Code Snippets**_

For convenience, much of the code you will be managing along this lab is available as Visual Studio code snippets. To install the code snippets run **.\Source\Assets\CodeSnippets.vsi** file.

_**Installing Web Platform Installer**_

This section assumes that you don't have some or all the system requirements installed. In case you do, you can simply skip this section.

Microsoft Web Platform Installer (WebPI) is a tool that manages the installation of the prerequisites for this Lab.

> **Note:** As well as the Microsoft Web Platform, WebPI can also install many of the open source applications that are available like Umbraco, Kentico, DotNetNuke and many more.  These are very useful for providing a foundation from which to customize an application to your requirements, dramatically cutting down your development time.

Please follow these steps to download and install Microsoft Visual Studio 11 Express Beta for Web:

1. Install **Visual Studio 11 Express Beta for Web**. To do this, navigate to [http://www.microsoft.com/web/gallery/install.aspx?appid=VWD11_BETA&prerelease=true](http://www.microsoft.com/web/gallery/install.aspx?appid=VWD11_BETA&prerelease=true) using a web browser. 

	![Web Platform Installer 4.0 window](./images/Microsoft-Web-Platform-Installer-4.png?raw=true "Web Platform Installer 4.0 download")

	_Web Platform Installer 4.0 download_

1. The Web Platform Installer launches and shows Visual Studio 11 Express Beta for Web Installation. Click on **Install**.

 	![Visual Studio 11 Express Beta for Web Installer window](./images/Microsoft-VS-11-Install.png?raw=true "Visual Studio 11 Express Beta for Web Installer window")
 
	_Visual Studio 11 Express Beta for Web Installer window_

1. The **Web Platform Installer** displays the list of software to be installed. Accept by clicking **I Accept**.

 	![Web Platform Installer window](./images/Microsoft-Web-Platform-Installer-Prerequisites.png?raw=true "Web Platform Installer window")
 
	_Web Platform Installer window_

1. The appropriate components will be downloaded and installed.

 	![Web Platform Installation - Download progress](./images/Web-Platform-Installation-Download-progress.png?raw=true "Web Platform Installation - Download progress")
 
	_Web Platform Installation - Download progress_

1. The **Web Platform Installer** will resume downloading and installing the products. When this process is finished, the Installer will show the list of all the software installed. Click **Finish**.

 	![Web Platform Installer](./images/Web-Platform-Installer.png?raw=true "Web Platform Installer")
 
	_Web Platform Installer_

---
<a name="Exercises" />
## Exercises ##

This Hands-On Lab is comprised by the following exercises:

1. [Exercise 1: Creating MusicStore ASP.NET MVC Web Application Project](#Exercise1)

1. [Exercise 2: Creating a Controller](#Exercise2)

1. [Exercise 3: Passing parameters to a Controller](#Exercise3)

1. [Exercise 4: Adding Ajax for Searching Activities](#Exercise4)

1. [Exercise 5: Creating a View Model](#Exercise5)

1. [Exercise 6: Using parameters in View](#Exercise6)

1. [Exercise 7: A lap around MVC4 New Template](#Exercise7)
 
Estimated time to complete this lab: **45 minutes**.

> **Note:** Each exercise is accompanied by an **End** folder containing the resulting solution you should obtain after completing the exercises. You can use this solution as a guide if you need additional help working through the exercises.

<a name="Exercise1" />
### Exercise 1: Creating MusicStore ASP.NET MVC Web Application Project ###

In this exercise, you will learn how to create an ASP.NET MVC application in Visual Studio 11 Express as well as its main folder organization. Additionally, you'll learn how to add a new Controller and have it display a simple string at the Application screen.

<a name="Ex1Task1" />
#### Task 1 - Creating the ASP.NET MVC Web Application Project####

1. In this task, you will create an empty ASP.NET MVC application project using the MVC Visual Studio template. Start Microsoft Visual Studio 11 from **Start** | **All Programs** | **Microsoft Visual Studio 11 Express** | **Visual Studio 11 Express Beta for Web**.

1. On the **File** menu, click **New Project**.

1. In the **New Project** dialog box select the **ASP.NET MVC 4 Web Application** project type, located under **Visual C#,** **Web** template list.

1. Change the **Name** to **MvcMusicStore**.

1. Set the location of the solution inside a new **Begin** folder in this Exercise's installation folder, for example **C:\WebCampsTrainingKit\Labs\Beginner-ASP.NET-MVC-Fundamentals MVC4\Source\Ex01-CreatingMusicStoreProject\Begin**. Click **OK**.

 	![Create New Project Dialog Box](./images/Create-New-Project-Dialog-Box.png?raw=true "Create New Project Dialog Box")
 
	_Create New Project Dialog Box_

1. In the **New ASP.NET MVC 4 Project** dialog box select the **Empty** template and make sure that the **View engine** selected is **Razor**. Click **OK**.

 	![New ASP.NET MVC 4 Project Dialog Box](./images/New-ASP.NET-MVC-3-Project-Dialog-Box.png?raw=true "New ASP.NET MVC 4 Project Dialog Box")
 
	_New ASP.NET MVC 4 Project Dialog Box_

<a name="Ex1Task2" />
#### Task 2 - Exploring the Solution Structure####

The ASP.NET MVC framework includes a Visual Studio project template that helps you create Web applications that are structured to support the MVC pattern. This template creates a new MVC Web application that is configured to have the required folders, item templates, and configuration-file entries.

In this task, you will examine the solution structure to understand the involved elements and its relationships. The following folders are included even in an Empty ASP.NET MVC application because the ASP.NET MVC framework by default uses a "convention over configuration" approach and makes some default assumptions based on folder naming conventions.

1. Once the project is created, review the folder structure that has been created in the Solution Explorer on the right side:

 	![ASP.NET MVC Folder structure in Solution Explorer](./images/ASP.NET-MVC-Folder-structure-in-Solution-Explorer.png?raw=true "ASP.NET MVC Folder structure in Solution Explorer")
 
	_ASP.NET MVC Folder structure in Solution Explorer_

	1. **Content**. This folder is the recommended location to add content files such as cascading style sheet files, images, and so on. In general, the Content folder is used for static files.

	1. **Controllers.** This folder will contain the controller classes. In an MVC based application, controllers are responsible for handling end user interaction, manipulating the model, and ultimately choosing a view to render the UI.

		> **Note:** The MVC framework requires the names of all controllers to end with "Controller"-for example, HomeController, LoginController, or ProductController.

	1. **Models**. This folder is provided for classes that represent the application model for the MVC Web application. This usually includes code that defines objects and the logic for interacting with the data store. Typically, the actual model objects will be in separate class libraries. However, when you create a new application, you might include classes and then move them into separate class libraries at a later point in the development cycle.

	1. **Scripts**. This is the recommended folder to store JavaScript files in your application.

	1. **Views**. This folder is the recommended location for views, the components responsible for displaying the application's user interface. Views use .aspx, .ascx, .cshtml and .master files, in addition to any other files that are related to rendering views. Views folder contains a folder for each controller; the folder is named with the controller-name prefix. For example, if you have a controller named **HomeController**, the Views folder will contain a folder named Home. By default, when the ASP.NET MVC framework loads a view, it looks for an .aspx file with the requested view name in the Views\controllerName folder (**Views\[ControllerName]\[Action].aspx**) or (**Views\[ControllerName]\[Action].cshtml**) for Razor Views. 

	1. **Views\Shared.** By default, there is also a folder named Shared in the Views folder, which does not correspond to any controller. The Shared folder is used for views that are shared across multiple controllers. For example, you can put the Web application's layout master page in the Shared folder.

		> **Note:** In addition to the folders listed previously, an MVC Web application uses the **Global.asax** file to set global URL routing defaults, and it uses the **Web.config** file to configure the application.

 
<a name="Ex1Task3" />
#### Task 3 - Adding a HomeController####

In ASP.NET applications that do not use the MVC framework, user interaction is organized around pages, and around raising and handling events from those pages. In contrast, user interaction with ASP.NET MVC applications is organized around controllers and their action methods.

On the other hand, ASP.NET MVC framework maps URLs to classes that are referred to as controllers. Controllers process incoming requests, handle user input and interactions, execute appropriate application logic and determine the response to send back to the client (display HTML, download a file, redirect to a different URL, etc.). In the case of displaying HTML, a controller class typically calls a separate view component to generate the HTML markup for the request. In an MVC application, the view only displays information; the controller handles and responds to user input and interaction.

In this task, you will add a Controller class that will handle URLs to the Home page of the Music Store site.

1. Right-click the **Controllers** folder within the Solution Explorer, select **Add** and then the **Controller** command:

 	![Add a Controller Command](./images/Add-a-Controller-Command.png?raw=true "Add a Controller Command")
 
	_Add a Controller Command_

1. The **Add Controller** dialog appears. Name the controller **HomeController** and press **Add**.

 	![Add Controller Dialog](./images/Add-Controller-Dialog.png?raw=true "Add Controller Dialog")
 
	_Add Controller Dialog_

1. The file **HomeController.cs** is created in the **Controllers** folder. In order to have the **HomeController** return a string on its Index action, replace the **Index** method with the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex1 HomeController Index_)

	<!-- mark:1-5 -->
	````C#
	public string Index()
	{
	  return "Hello from Home";
	}
	````

<a name="Ex1Task4" />
#### Task 4 - Running the Application####

In this task, you will try out the Application in a web browser.

1. Press **F5** to run the Application. The project gets compiled and the local IIS Web Server starts. The local IIS Web Server will automatically open a web browser pointing to the web-server URL. This will allow you to try out the web application.

 	![Application running in a web browser](./images/Application-running-in-a-web-browser.png?raw=true "Application running in a web browser")
 
	_Application running in a web browser_

	> **Note**: The local IIS Web Server will run the website on a random free port number. In the figure above, the site is running at http://localhost:3013/, so it's using port 3013. Your port number may vary.

1. Close the browser.

<a name="Exercise2" />
### Exercise 2: Creating a Controller ###

In this exercise, you will learn how to create a Controller to implement simple functionality of the Music Store. That controller will define action methods to handle each specific request:

- A listing page of the music genres in the Music Store

- A browse page that lists all of the music albums for a particular genre

- A details page that shows information about a specific music album

For the scope of this exercise, you will have those actions to simply return a string by now.

 
<a name="Ex2Task1" />
#### Task 1 - Adding a New StoreController Class####

In this task, you will add a new Controller.

1. If not already open, start Microsoft Visual Studio 11 Express Beta for Web from **Start** | **All Programs** | **Microsoft Visual Studio 11 Express** | **Visual Studio 11 Express Beta for Web**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex02-CreatingAController\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1.	Follow these steps to install the **NuGet** package dependencies.

	a.	Open the **NuGet** **Package Manager Console**. To do this, select **Tools | Library Package Manager | Package Manager Console**.

	b.	In the **Package Manager Console,** type **Install-Package NuGetPowerTools**.

	c.	After installing the package, type **Enable-PackageRestore**.

	d.	Build the solution. The **NuGet** dependencies will be downloaded and installed automatically.

	>**Note:** One of the advantages of using NuGet is that you don't have to ship all the libraries in your project, reducing the project size. With NuGet Power Tools, by specifying the package versions in the Packages.config file, you will be able to download all the required libraries the first time you run the project. This is why you will have to run these steps after you open an existing solution from this lab.
	
	>For more information, see this article: <http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages>.

1. Add the new controller. To do this, right-click the **Controllers** folder within the Solution Explorer, select **Add** and then the **Controller** command. Change the **Controller** **Name** to **StoreController**, and click **Add**.

	![Add Controller Dialog](./images/Add-controller-dialog-2.png?raw=true "Add Controller Dialog")
 
	_Add Controller Dialog_
 
<a name="Ex2Task2" />
#### Task 2 - Modifying the StoreController's Actions####

In this task, you will modify Controller methods that are called **actions**. These actions are responsible for responding to URL requests and determine the content that should be sent back to the browser or user that invoked the URL.

1. The **StoreController** class already has an **Index** method. You will use it later in this Lab to implement the page that lists all genres of the music store. For now, just replace the **Index** method with the following code that returns a string "Hello from Store.Index()":

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex2 StoreController Index_)

	<!-- mark:1-5 -->
	````C#
	public string Index()
	{
	  return "Hello from Store.Index()";
	}
	````

1. Add the **Browse** and **Details** methods. To do this, add the following code to the **StoreController**:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex2 StoreController BrowseAndDetails_)

	<!-- mark:1-15 -->
	````C#
	//
	// GET: /Store/Browse
	
	public string Browse()
	{
	  return "Hello from Store.Browse()";
	}
	
	//
	// GET: /Store/Details
	
	public string Details()
	{
	  return "Hello from Store.Details()";
	}
	````

<a name="Ex2Task3" />
#### Task 3 - Running the Application####

In this task, you will try out the Application in a web browser.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to verify each action's implementation.

	1. **/Store**. You will see **"Hello from Store.Index()"**.

	1. **/Store/Browse**. You will see **"Hello from Store.Browse()"**.

	1. **/Store/Details**. You will see **"Hello from Store.Details()"**.

 		![Browsing StoreBrowse](./images/Browsing-StoreBrowse.png?raw=true "Browsing StoreBrowse")
 
		_Browsing /Store/Browse_

1. Close the browser.

<a name="Exercise3" />
### Exercise 3: Passing parameters to a Controller ###

Until now, you have been returning constant strings from the Controllers. In this exercise you will learn how to pass parameters to a Controller using the URL and querystring and then making the method actions respond with text to the browser.

<a name="Ex3Task1" />
#### Task 1 - Adding Genre Parameter to StoreController####

In this task, you will use the **querystring** to send parameters to the **Browse** action method in the **StoreController**.

1. If not already open, start Microsoft Visual Studio 11 Express Beta for Web from **Start** | **All Programs** | **Microsoft Visual Studio 11 Express** | **Visual Studio 11 Express Beta for Web**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex03-PassingParametersToAController\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1.	Follow these steps to install the **NuGet** package dependencies.

	a.	Open the **NuGet** **Package Manager Console**. To do this, select **Tools | Library Package Manager | Package Manager Console**.

	b.	In the **Package Manager Console,** type **Install-Package NuGetPowerTools**.

	c.	After installing the package, type **Enable-PackageRestore**.

	d.	Build the solution. The **NuGet** dependencies will be downloaded and installed automatically.

	>**Note:** One of the advantages of using NuGet is that you don't have to ship all the libraries in your project, reducing the project size. With NuGet Power Tools, by specifying the package versions in the Packages.config file, you will be able to download all the required libraries the first time you run the project. This is why you will have to run these steps after you open an existing solution from this lab.
	
	>For more information, see this article: <http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages>.

1. Open **StoreController** class. To do this, in the **Solution Explorer**, expand the **Controllers** folder and double-click **StoreController.cs**.

1. Change the **Browse** method, adding a string parameter to request for a specific genre. ASP.NET MVC will automatically pass any querystring or form post parameters named **genre** to this action method when invoked. To do this, replace the **Browse** method with the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex3 StoreController BrowseMethod_)

	<!-- mark:1-10 -->
	````C#
	//
	// GET: /Store/Browse?genre=Disco
	
	public string Browse(string genre)
	{
	  string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
	
	  return message;
	}
	````

	> **Note:** You are using the **HttpUtility.HtmlEncode** utility method to prevents users from injecting Javascript into the View with a link like **/Store/Browse?Genre=&lt;script>window.location='http://hackersite.com'</script&gt;**.

	> For further explanation, please visit [this msdn article](http://msdn.microsoft.com/en-us/library/a2a4yykt(v=VS.80).aspx).

 
<a name="Ex3Task2" />
#### Task 2 - Running the Application####

In this task, you will try out the Application in a web browser and use the **genre** parameter.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Browse?Genre=Disco** to verify that the action receives the genre parameter.

 	![Browsing StoreBrowseGenre=Disco](./images/Browsing-StoreBrowseGenre=Disco.png?raw=true "Browsing StoreBrowseGenre=Disco")
 
	_Browsing /Store/Browse?Genre=Disco_

1. Close the browser.

 
<a name="Ex3Task3" />
#### Task 3 - Adding an Id Parameter Embedded in the URL####

In this task, you will use the **URL** to pass an **Id** parameter to the **Details** action method of the **StoreController**. ASP.NET MVC's default routing convention is to treat the segment of a URL after the action method name as a parameter named **Id**.  If your action method has a parameter named Id then ASP.NET MVC will automatically pass the URL segment to you as a parameter. In the URL **Store/Details/5**, **Id** will be interpreted as **5**.

1. Change the **Details** method of the **StoreController**, adding an **int** parameter called **id**. To do this, replace the **Details** method with the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex3 StoreController DetailsMethod_)

	<!-- mark:1-9 -->
	````C#
	//
	// GET: /Store/Details/5
	
	public string Details(int id)
	{
	  string message = "Store.Details, ID = " + id;
	
	  return message;
	}
	````
 
<a name="Ex3Task4" />
#### Task 4 - Running the Application####

In this task, you will try out the Application in a web browser and use the **Id** parameter.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Details/5** to verify that the action receives the id parameter.

 	![Browsing StoreDetails5](./images/Browsing-StoreDetails5.png?raw=true "Browsing StoreDetails5")
 
	_Browsing /Store/Details/5_

<a name="Exercise4" />
### Exercise 4: Creating a View ###

So far you have been returning strings from controller actions. Although that's a useful way of understanding how controllers work, it's not how you'd want to build a real web application. Views are components that provide a better approach for generating HTML back to the browser with the use of template files.

In this exercise you will learn how to add a layout master page to setup a template for common HTML content, a StyleSheet to enhance the look and feel of the site and finally a View template to enable HomeController to return HTML.

<a name="Ex4Task1" />
#### Task 1 - Modifying the file _layout.cshtml####

The file ~/Views/Shared/_layout.cshtml allows you to setup a template for common HTML to use across the entire website. In this task you will add a layout master page with a common header with links to the Home page and Store area.

1. If not already open, start Microsoft Visual Studio 11 Express Beta for Web from **Start** | **All Programs** | **Microsoft Visual Studio 11 Express** | **Visual Studio 11 Express Beta for Web**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex04-CreatingAView\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1.	Follow these steps to install the **NuGet** package dependencies.

	a.	Open the **NuGet** **Package Manager Console**. To do this, select **Tools | Library Package Manager | Package Manager Console**.

	b.	In the **Package Manager Console,** type **Install-Package NuGetPowerTools**.

	c.	After installing the package, type **Enable-PackageRestore**.

	d.	Build the solution. The **NuGet** dependencies will be downloaded and installed automatically.

	>**Note:** One of the advantages of using NuGet is that you don't have to ship all the libraries in your project, reducing the project size. With NuGet Power Tools, by specifying the package versions in the Packages.config file, you will be able to download all the required libraries the first time you run the project. This is why you will have to run these steps after you open an existing solution from this lab.
	
	>For more information, see this article: <http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages>.

1. The file _layout.cshtml contains the HTML container layout for all pages on the site.  It includes the **\<html\>** element for the HTML response, as well as the **\<head\>** and **\<body\>** elements. **@RenderBody()** within the HTML body identify regions that view templates will be able to fill in with dynamic content.

	````HTML(C#)
	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8" />
			<meta name="viewport" content="width=device-width" />
			<title>@ViewBag.Title</title>
			<link href="@System.Web.Optimization.BundleTable.Bundles.ResolveBundleUrl("~/Content/css")" rel="stylesheet" type="text/css" />
			<link href="@System.Web.Optimization.BundleTable.Bundles.ResolveBundleUrl("~/Content/themes/base/css")" rel="stylesheet" type="text/css" />
			<script src="@System.Web.Optimization.BundleTable.Bundles.ResolveBundleUrl("~/Scripts/js")"></script>
		</head>
		<body>
			@RenderBody()
		</body>
	</html>
	````
	
1. Add a common header with links to the Home page and Store area on all pages in the site. In order to do that, add the following code inside the **\<div\>** statement.
	<!-- mark:12-19 -->
	````HTML(C#)
	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8" />
			<meta name="viewport" content="width=device-width" />
			<title>@ViewBag.Title</title>
			<link href="@System.Web.Optimization.BundleTable.Bundles.ResolveBundleUrl("~/Content/css")" rel="stylesheet" type="text/css" />
			<link href="@System.Web.Optimization.BundleTable.Bundles.ResolveBundleUrl("~/Content/themes/base/css")" rel="stylesheet" type="text/css" />
			<script src="@System.Web.Optimization.BundleTable.Bundles.ResolveBundleUrl("~/Scripts/js")"></script>
		</head>
		<body>
			<div id="header">
				<h1>
					ASP.NET MVC MUSIC STORE</h1>
				<ul id="navlist">
					<li class="first"><a href="/" id="current">Home</a></li>
					<li><a href="/Store/">Store</a></li>
				</ul>
			</div>

			@RenderBody()
		</body>
	</html>
	````
	
	>**Note:** Did you know? Visual Studio 11 has snippets that make it easy to add commonly used code in HTML, code files and more! Try it out by typing **\<div\>** and pressing **TAB** twice to insert a complete **div** tag.
	
<a name="Ex4Task2" />
#### Task 2 - Adding CSS Stylesheet####

The empty project template includes a very streamlined CSS file which just includes styles used to display basic forms and validation messages. You will use additional CSS and images (potentially provided by a designer) in order to enhance the look and feel of the site.

In this task, you will add a CSS stylesheet to define the styles of the site.

1. The CSS file and images are included in the **Source\Assets\Content** folder of this Lab. In order to add them to the application, drag their content from a **Windows Explorer** window into the **Solution Explorer** in Visual Web Developer Express, as shown below:

 	![Dragging style contents](./images/Dragging-style-contents.png?raw=true "Dragging style contents")
 
	_Dragging style contents_

1. A warning dialog will appear, asking for confirmation to replace Site.css file. Click **Yes**.

	![Warning Dialog](./images/Warning-Dialog.png?raw=true "Warning Dialog")

	_Warning Dialog_

 
<a name="Ex4Task3" />
#### Task 3 - Adding a View Template####

In this task, you will add a View template to generate the HTML response that will use the layout master page and CSS added in this exercise.

1. To use a View template when browsing the site's home page, first you need to indicate that instead of returning a string, the **HomeController Index** method should return a **View**. Open **HomeController** class and change its **Index** method to return an **ActionResult,** and have it return **View()**.

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex4 HomeController Index_)
	
	<!-- mark:3-10 -->
	````C#
	public class HomeController : Controller
	{
	    //
	    // GET: /Home/
	
	    public ActionResult Index()
	    {
	        return View();
	    }
	}
	````

1. Now, you need to add an appropriate View template. To do this, **right-click** inside the **Index** action method and select **Add View**. This will bring up the Add View dialog.

 	![Adding a View from within the Index method](./images/Adding-a-View-from-within-the-Index-method.png?raw=true "Adding a View from within the Index method")
 
	_Adding a View from within the Index method_

1. The **Add View** Dialog appears. It allows generating View template files. By default this dialog pre-populates the name of the View template so that it matches the action method that will use it.  Because you used the **Add View** context menu within the **Index** action method of the HomeController, the **Add View** dialog has Index as the default view name. Click **Add**.

 	![Add View Dialog](./images/Add-View-Dialog.png?raw=true "Add View Dialog")
 
	_Add View Dialog_

1. Visual Studio generates an **Index.cshtml** view template inside the Views\Home folder and then opens it.

 	![Add View Dialog](./images/Add-View-Dialog-solution.png?raw=true "Add View Dialog")
 
	_Add View Dialog_

	> **Note:** name and location of the **Index.cshtml** file is relevant and follows the default ASP.NET MVC naming conventions.

	> The folder \\Views\\**Home** matches the controller name (**Home**Controller). The View template name (**Index**), matches the controller action method which will be displaying the View.

	> This way, ASP.NET MVC avoids having to explicitly specify the name or location of a View template when using this naming convention to return a View.

1. The generated View template is based on the **\_layout.cshtml** template earlier defined. Update the ViewBag.Title property to **Home**, and change the main content to **This is the Home Page**, as shown in the code below:
	<!-- mark:1-5 -->
	````HTML
	@{
		ViewBag.Title = "Home";
	}

	<h2>This is the Home Page</h2>
	````

1. Select **MvcMusicStore** project in the Solution Explorer and Press **F5** to run the Application.

**Exercise 4: Verification**

In order to verify that you have correctly performed all the steps in the previous exercise, proceed as follows:

With the application opened in a browser, you should note that:

1. The HomeController's Index action method found and displayed the **\Views\Home\Index.cshtml** View template, even though the code called **return View()**, because the View template followed the standard naming convention.

1. The Home Page displays the welcome message defined within the **\Views\Home\Index.cshtml** view template.

1. The Home Page is using the **_layout.cshtml** template, and so the welcome message is contained within the standard site HTML layout.

	![Home Index View using the defined LayoutPage and style](./images/Home-Index-View-using-the-layoutPage-and-style-defined.png?raw=true "Home Index View using the defined LayoutPage and style")

	_Home Index View using the defined LayoutPage and style_

<a name="Exercise5" />
### Exercise 5: Creating a View Model ###

So far you made your Views display hardcoded HTML, but in order to create dynamic web applications, the View template should receive information from the Controller. One common technique to be used for that purpose is the **ViewModel** pattern, which allows a Controller to package up all the information needed to generate the appropriate HTML response.

In this exercise, you will learn how to create a ViewModel class and add the needed properties: in this case, the number of genres in the store and a list of those genres. Also, you will update the StoreController to use the created ViewModel and finally you will create a new View template that will display the mentioned properties in the page.

<a name="Ex5Task1" />
#### Task 1 - Creating a ViewModel Class####

In this task, you will create a ViewModel class that will implement the Store genre listing scenario.

1. If not already open, start Microsoft Visual Studio 11 Express Beta for Web from **Start** | **All Programs** | **Microsoft Visual Studio 11 Express** | **Visual Studio 11 Express Beta for Web**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex05-CreatingAViewModel\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1.	Follow these steps to install the **NuGet** package dependencies.

	a.	Open the **NuGet** **Package Manager Console**. To do this, select **Tools | Library Package Manager | Package Manager Console**.

	b.	In the **Package Manager Console,** type **Install-Package NuGetPowerTools**.

	c.	After installing the package, type **Enable-PackageRestore**.

	d.	Build the solution. The **NuGet** dependencies will be downloaded and installed automatically.

	>**Note:** One of the advantages of using NuGet is that you don't have to ship all the libraries in your project, reducing the project size. With NuGet Power Tools, by specifying the package versions in the Packages.config file, you will be able to download all the required libraries the first time you run the project. This is why you will have to run these steps after you open an existing solution from this lab.
	
	>For more information, see this article: <http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages>.

1. Create a **ViewModels** folder to hold the ViewModel. To do this, right-click the top-level **MvcMusicStore** project, select **Add** and then **New Folder**.

 	![Adding a new folder](./images/Adding-a-new-folder.png?raw=true "Adding a new folder")
 
	_Adding a new folder_

1. Name the folder **ViewModels**.

 	![ViewModels folder in Solution Explorer](./images/ViewModels-folder-in-Solution-Explorer.png?raw=true "ViewModels folder in Solution Explorer")
 
	_ViewModels folder in Solution Explorer_

1. Create a **ViewModel** class. To do this, right-click on the **ViewModels** folder recently created, select **Add** and then **New Item**. Under **Code**, choose the **Class** item and name the file **StoreIndexViewModel.cs**, then click **Add**.

 	![Adding a new Class](./images/Adding-a-new-Class.png?raw=true "Adding a new Class")
 
	_Adding a new Class_

 	![Creating StoreIndexViewModel class](./images/Creating-StoreIndexViewModel-class.png?raw=true "Creating StoreIndexViewModel class")
 
	_Creating StoreIndexViewModel class_

<a name="Ex5Task2" />
#### Task 2 - Adding Properties to the ViewModel class####

There are two pieces of information to be passed from the StoreController to the View template in order to generate the expected HTML response: the number of genres in the store and a list of those genres.

In this task, you will add those 2 properties to the **StoreIndexViewModel** class: **NumberOfGenres** (an integer) and **Genres** (a list of strings).

1. Add **NumberOfGenres** and **Genres** properties to the **StoreIndexViewModel** class. To do this, add the following 2 lines to the class definition:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex5 StoreIndexViewModel properties_)

	<!-- mark:3-5 -->
	````C#
	public class StoreIndexViewModel
	{
	  public int NumberOfGenres { get; set; }
	  public List<string> Genres { get; set; }
	}
	````
	> **Note**: The **{ get; set; }** notation makes use of C#'s auto-implemented properties feature. It provides the benefits of a property without requiring us to declare a backing field.

 
<a name="Ex5Task3" />
#### Task 3 - Updating StoreController to use the StoreIndexViewModel####

The **StoreIndexViewModel** class encapsulates the information needed to pass from **StoreController**'s **Index** method to a View template in order to generate a response.

In this task, you will update the **StoreController** to use the **StoreIndexViewModel**.

1. Open **StoreController** class. 

 	![Opening StoreController class](./images/Opening-StoreController-class.png?raw=true "Opening StoreController class")
 
	_Opening StoreController class_

1. In order to use the **StoreIndexViewModel** class from the **StoreController**, add the following namespace to the top of the **StoreController** code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex5 StoreIndexViewModel using ViewModels_)

	<!-- mark:1-2 -->
	````C#
	using MvcMusicStore.ViewModels;
	````

1. Change the **StoreController**'s **Index** action method so that it creates and populates a **StoreIndexViewModel** object and then passes it off to a View template to generate an HTML response with it.

	> **Note:** In Lab "ASP.NET MVC Models and Data Access" you will write code that retrieves the list of store genres from a database.  In the following code, you will create a **List** of dummy data genres that will populate the **StoreIndexViewModel**.

	> After creating and setting up the **StoreIndexViewModel** object, it will be passed as an argument to the **View** method. This indicates that the View template will use that object to generate an HTML response with it.

1. Replace the **Index** method with the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex5 StoreController Index method_)

	<!-- mark:1-13 -->
	````C#
	public ActionResult Index()
	{
	    // Create a list of genres
	    var genres = new List<string> {"Rock", "Jazz", "Country", "Pop", "Disco"};
	
	    // Create our view model
	    var viewModel = new StoreIndexViewModel { 
	        NumberOfGenres = genres.Count(),
	        Genres = genres
	    };
	
	    return View(viewModel);
	}
	````

	> **Note:** If you're unfamiliar with C#, you may assume that using **var** means that the **viewModel** variable is late-bound. That's not correct - the C# compiler is using type-inference based on what you assign to the variable to determine that **viewModel** is of type **StoreIndexViewModel**. Also, by compiling the local **viewModel** variable as a **StoreIndexViewModel** type you get compile-time checking and Visual Studio code-editor support.

 
<a name="Ex5Task4" />
#### Task 4 - Creating a View Template that Uses StoreIndexViewModel####

In this task, you will create a View template that will use a StoreIndexViewModel object passed from the Controller to display a list of genres.

1. Before creating the new View template, let's build the project so that the **Add View Dialog** knows about the **StoreIndexViewModel** class. Build the project by selecting the **Debug** menu item and then **Build MvcMusicStore**.

 	![Building the project](./images/Building-the-project.png?raw=true "Building the project")
 
	_Building the project_

1. Create a new View template. To do that, right-click inside the **Index** method and select **Add View.**

 	![Adding a View](./images/Adding-a-View.png?raw=true "Adding a View")
 
	_Adding a View_

1. Because the **Add View Dialog** was invoked from the **StoreController**, it will add the View template by default in a \Views\Store\Index.cshtml file. Check the **Create a strongly-typed-view** checkbox and then select **StoreIndexViewModel** as the **Model class**. Also, make sure that the View engine selected is **Razor**. Click **Add**.

 	![Add View Dialog](./images/Add-View-Dialog-2.png?raw=true "Add View Dialog")
 
	_Add View Dialog_

	The \Views\Store\Index.cshtml View template file is created and opened. Based on the information provided to the **Add View** dialog in the last step, the View template will expect a **StoreIndexViewModel** instance as the data to use to generate an HTML response. You will notice that by seeing that the template inherits a **ViewPage<MusicStore.ViewModels.StoreIndexViewModel>** in C#.

 
<a name="Ex5Task5" />
#### Task 5 - Updating the View Template####

In this task, you will update the View template created in the last task to output the number of genres and their names within the page.

> **Note:** You will use @ syntax (often referred to as "code nuggets") to execute code within the View template.

1. In the Index.cshtml file, replace the code inside with the following:
	<!-- mark:1-9 -->
	````HTML
	@model MvcMusicStore.ViewModels.StoreIndexViewModel

	@{
		ViewBag.Title = "Browse Genres";
	}

	<h2>Browse Genres</h2>

	<p> Select from @Model.NumberOfGenres genres</p>
	````

	> **Note:** As soon as you finish typing the period after the word **Model**, Visual Studio's Intellisense feature supplies you with a list of possible properties and methods to choose from.

	> ![](./images/Intelisense.png?raw=true)

	> _Getting Model properties and methods with Visual Studio's IntelliSense_

	> The **Model** property references the **StoreIndexViewModel** object that the Controller passed to the View template.  This means that you can access all of the data passed from the Controller to the View template via the **Model** property, and format it into an appropriate HTML response within the View template.

	> You can just select the **NumberOfGenres** property from the Intellisense list rather than typing it in and then it will auto-complete it by pressing the **tab key**.

1. Loop over the genre list in **StoreIndexViewModel** and create an HTML **\<ul\>** list using a **foreach** loop. Also change the title to **Browse Genres.**
	<!-- mark:1-17 -->
	````HTML(C#)
	@model MvcMusicStore.ViewModels.StoreIndexViewModel

	@{
		ViewBag.Title = "Browse Genres";
	}

	<h2>Browse Genres</h2>

	<p> Select from @Model.NumberOfGenres genres</p>

	<ul>
		@foreach (string genreName in Model.Genres) {
			<li>
				@genreName
			</li>
			}
	</ul>
	````

1. Press **F5** to run the Application and browse **/Store**. You will see the list of genres passed in the **StoreIndexViewModel** object from the **StoreController** to the View template.

 	![View displaying a list of genres](./images/View-displaying-a-list-of-genres.png?raw=true "View displaying a list of genres")
 
	_View displaying a list of genres_

1. Close the browser.

<a name="Exercise6" />
### Exercise 6: Using Parameters in View ###

In Exercise 3 you learned how to pass parameters to the Controller. In this exercise, you will learn how to use those parameters in the View template. For that purpose, you will be introduced first to Model classes that will help you to manage your data and domain logic. Additionally, you will learn how to create links to pages inside the ASP.NET MVC application without worrying of things like URL paths encoding.

<a name="Ex6Task1" />
#### Task 1 - Adding Model Classes####

Unlike ViewModels, which are created just to pass information from the Controller to the View, Model classes are built to contain and manage data and domain logic. In this task you will add two model classes to represent these concepts: **Genre** and **Album**. In the next Hands-on Lab, these classes will be hooked to a database, mapping each one of them to a table.

1. If not already open, start Microsoft Visual Studio 11 Express Beta for Web from **Start** | **All Programs** | **Microsoft Visual Studio 11 Express** | **Visual Studio 11 Express Beta for Web**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex06-UsingParametersInView\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1.	Follow these steps to install the **NuGet** package dependencies.

	a.	Open the **NuGet** **Package Manager Console**. To do this, select **Tools | Library Package Manager | Package Manager Console**.

	b.	In the **Package Manager Console,** type **Install-Package NuGetPowerTools**.

	c.	After installing the package, type **Enable-PackageRestore**.

	d.	Build the solution. The **NuGet** dependencies will be downloaded and installed automatically.

	>**Note:** One of the advantages of using NuGet is that you don't have to ship all the libraries in your project, reducing the project size. With NuGet Power Tools, by specifying the package versions in the Packages.config file, you will be able to download all the required libraries the first time you run the project. This is why you will have to run these steps after you open an existing solution from this lab.
	
	>For more information, see this article: <http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages>.

1. Add a **Genre** Model class. To do this, right-click the **Models** folder in the **Solution Explorer**, select **Add** and then the **New Item** option. Under **Code**, choose the **Class** item and name the file **Genre.cs**, then click **Add**.

	![Adding a class](./images/Adding-a-class.png?raw=true "Adding a class")

	_Adding a new item_

 	![Add Genre Model Class](./images/Add-Genre-Model-Class.png?raw=true "Add Genre Model Class")
 
	_Add Genre Model Class_

1. Add a **Name** property to the Genre class. To do this, add the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex6 Genre_)

	<!-- mark:10-11 -->
	````C#
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	
	namespace MvcMusicStore.Models
	{
	    public class Genre
	    {
	        public string Name { get; set; }
	    }
	}
	````

1. Following the same procedure as before, add an **Album** class. To do this, right-click the **Models** folder in the **Solution Explorer**, select **Add** and then the **New Item** option. Under **Code**, choose the **Class** item and name the file **Album.cs**, then click **Add**.

1. Add two properties to the Album class**: Genre** and **Title**. To do this, add the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex6 Album_)

	<!-- mark:10-12 -->
	````C#
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	
	namespace MvcMusicStore.Models
	{
	    public class Album
	    {
	        public string Title { get; set; }
	        public Genre Genre { get; set; }
	    }
	}
	````
 
<a name="Ex6Task2" />
#### Task 2 - Adding a StoreBrowseViewModel####

A **StoreBrowseViewModel** will be used in this task to show the Albums that match a selected Genre.  In this task, you will create this class and then add two properties to handle the **Genre** and its **Album**'s List.

1. Add a **StoreBrowseViewModel** class. To do this, right-click the **ViewModels** folder in the **Solution Explorer**, select **Add** and then the **New Item** option. Under **Code**, choose the **Class** item and name the file **StoreBrowseViewModel.cs**, then click **Add**.

1. Add a reference to the Models in **StoreBrowseViewModel** class. To do this, add the following using namespace:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex6 UsingModel_)

	<!-- mark:5-6 -->
	````C#
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using MvcMusicStore.Models;
	
	namespace MvcMusicStore.ViewModels
	{
	    public class StoreBrowseViewModel
	    {
	    }
	}
	````

1. Add two properties to **StoreBrowseViewModel** class:  **Genre** and **Albums.** To do this, add the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex6 ModelProperties_)

	<!-- mark:11-13 -->
	````C#
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using MvcMusicStore.Models;
	
	namespace MvcMusicStore.ViewModels
	{
	    public class StoreBrowseViewModel
	    {
	        public Genre Genre { get; set; }
	        public List<Album> Albums { get; set; }
	    }
	}
	````

	> **Note:** What is **List\<Album\>** ?: This definition is using the **List<T>** type, where **T** constrains the type to which elements of this **List** belong to, in this case **Album** (or any of its descendants).

	> This ability to design classes and methods that defer the specification of one or more types until the class or method is declared and instantiated by client code is a feature of the C# language called **Generics**.

	> **List<T>** is the generic equivalent of the **ArrayList** type and is available in the **System.Collections.Generic** namespace**.** One of the benefits of using **generics** is that since the type is specified, you do not need to take care of type checking operations such as casting the elements into **Album** as you would do with an **ArrayList**.

 
<a name="Ex6Task3" />
#### Task 3 - Using the New ViewModel in the StoreController####

 In this task, you will modify the **StoreController**'s **Browse** and **Details** action methods to use the new **StoreBrowseViewModel**.

1. Add a reference to the Models folder in **StoreController** class. To do this, expand the **Controllers** folder in the **Solution Explorer** and open the **StoreController** class. Then add the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex6 UsingModelInController_)

	<!-- mark:7-9 -->
	````C#
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	
	using MvcMusicStore.ViewModels;
	using MvcMusicStore.Models;
	````

1. Replace the **Browse** action method to use the **StoreViewBrowseController** class**.** You will create a Genre and two new Albums objects with dummy data (in the next Hands-on Lab you will consume real data from a database). To do this, replace the **Browse** method with the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex6 BrowseMethod_)

	<!-- mark:1-24 -->
	````C#
	//
	// GET: /Store/Browse?genre=Disco
	
	public ActionResult Browse(string genre)
	{
	    var genreModel = new Genre()
	    {
	        Name = genre
	    };
	
	    var albums = new List<Album>()
	    {
	        new Album() { Title = genre + " Album 1" },
	        new Album() { Title = genre + " Album 2" }
	    };
	
	    var viewModel = new StoreBrowseViewModel()
	    {
	        Genre = genreModel,
	        Albums = albums
	    };
	
	    return View(viewModel);
	}
	````

1. Replace the **Details** action method to use the **StoreViewBrowseController** class**.** You will create a new **Album** object to be returned to the **View**. To do this, replace the **Details** method with the following code:

	(Code Snippet - _ASP.NET MVC 4 Fundamentals - Ex6 DetailsMethod_)

	<!-- mark:1-10 -->
	````C#
	//
	// GET: /Store/Details/5
	
	public ActionResult Details(int id)
	{
	  var album = new Album { Title = "Sample Album" };
	
	  return View(album);
	}
	````

<a name="Ex6Task4" />
#### Task 4 - Adding a Browse View Template####

In this task, you will add a **Browse** View to show the Albums found for a specific Genre.

1. Before creating the new View template, you should build the project so that the **Add View Dialog** knows about the **ViewModel** class to use. Build the project by selecting the **Debug** menu item and then **Build MvcMusicStore**.

 	![Building the project in Visual Studio 11](./images/Building-the-project-in-Visual-Studio-11.png?raw=true "Building the project in Visual Studio 11")
 
	_Building the project in Visual Studio 11_

1. Add a **Browse** View. To do this, right-click in the **Browse** action method of the **StoreController** and click **Add View**.

1. In the **Add View** dialog box, verify that the View Name is **Browse**. Check the **Create a strongly-typed view** checkbox and select **StoreBrowseViewModel** from the **Model class** dropdown. Leave the other fields with their default value. Then click **Add**.

 	![Adding a Browse View](./images/Adding-a-Browse-View.png?raw=true "Adding a Browse View")
 
	_Adding a Browse View_

1. Modify the **Browse.cshtml** to display the Genre's information, accessing the **StoreBrowseViewModel** object that is passed to the view template. To do this, replace the content with the following:
	<!-- mark:1-14 -->
	````HTML(C#)
	@model MvcMusicStore.ViewModels.StoreBrowseViewModel

	@{
		ViewBag.Title = "Browse Albums";
	}

	<h2>Browsing Genre: @Model.Genre.Name</h2>

	<ul>
		@foreach (var album in Model.Albums)
		{
			<li>@album.Title</li>
		}
	</ul>
	````
 
<a name="Ex6Task5" />
#### Task 5 - Running the Application####

In this task, you will test that the **Browse** method retrieves Albums from the **Browse** method action.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Browse?Genre=Disco** to verify that the action returns two Albums.

 	![Browsing Store Disco Albums](./images/Browsing-Store-Disco-Albums.png?raw=true "Browsing Store Disco Albums")
 
	_Browsing Store Disco Albums_

 
<a name="Ex6Task6" />
#### Task 6 - Displaying information About a Specific Album####

In this task, you will implement the **Store/Details** view to display information about a specific album. In this Hands-on Lab, everything you will display about the album is already contained in the **View** template. So, instead of creating a **StoreDetailsViewModel** class you will use the current **StoreBrowseViewModel** template passing the Album to it.

1. Close the browser if needed, to return to the Visual Studio window. Add a new **Details** view for the **StoreController**'s **Details** action method. To do this, right-click the **Details** method in the **StoreController** class and click **Add View**.

1. In the **Add View** dialog view, verify that the **View Name** is **Details**. Check the **Create a strongly-typed view** checkbox and select **Album** from the **Model class** drop-down. Leave the other fields with their default value. Then click **Add**. This will create and open a **\Views\Store\Details.cshtml** file.

 	![Adding a Details View](./images/Adding-a-Details-View.png?raw=true "Adding a Details View")
 
	_Adding a Details View_

1. Modify the **Details.cshtml** file to display the Album's information, accessing the **Album** object that is passed to the view template.  To do this, replace the content with the following:

	<!-- mark:1-8 -->
	````HTML(C#)
	@model MvcMusicStore.Models.Album

	@{
		ViewBag.Title = "Details";
	}

	<h2>Album: @Model.Title</h2>
	````
 
<a name="Ex6Task7" />
#### Task 7 - Running the Application####

In this task, you will test that the **Details** View retrieves Album's information from the **Details action** method.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Details/5** to verify the album's information.

 	![Browsing Albums Detail](./images/Browsing-Albums-Detail.png?raw=true "Browsing Albums Detail")
 
	_Browsing Album's Detail_

 
<a name="Ex6Task8" />
#### Task 8 - Adding Links Between Pages####

In this task, you will add a link in the Store View to have a link in every Genre name to the appropriate **/Store/Browse** URL. This way, when you click on a Genre, for instance **Disco**, it will navigate to **/Store/Browse?genre=Disco** URL.

1. Close the browser if needed, to return to the Visual Studio window. Update the **Index** page to add a link to the **Browse** page. To do this, in the **Solution Explorer** expand the **Views** folder, then the **Store** folder and double-click the **Index.cshtml** page. Add a link to the Browse view indicating the genre selected. To do this, replace the following  code in the **Index.cshtml**:	
	
	<!-- mark:1-17 -->
	````HTML(C#)
	@model MvcMusicStore.ViewModels.StoreIndexViewModel

	@{
		ViewBag.Title = "Browse Genres";
	}

	<h2>Browse Genres</h2>

	<p> Select from @Model.NumberOfGenres genres</p>

	<ul>
		@foreach (string genreName in Model.Genres) {
			<li>
				@Html.ActionLink(genreName, "Browse", new { genre = genreName }, null)
			</li>
			}
	</ul>
	````

	> **Note**: another approach would be linking directly to the page, with a code like the following:

	> &lt;a href="/Store/Browse?genre=@genreName">@genreName</a&gt;

	> Although this approach works, it depends on a hardcoded string. If you later rename the Controller, you will have to change this instruction manually. A better alternative is to use an **HTML Helper** method. ASP.NET MVC includes an HTML Helper method which is available for such tasks. The **Html.ActionLink()** helper method makes it easy to build HTML **<a>** links, making sure URL paths are properly URL encoded.

	> Htlm.ActionLink has several overloads. In this exercise you will use one that takes three parameters:

	>	1. Link text, which will display the Genre name

	>	2. Controller action name (**Browse**)

	>	3. Route parameter values, specifying both the name (**Genre**) and the value (**Genre name**)

 
<a name="Ex6Task9" />
#### Task 9 - Running the Application####

In this task, you will test that each Genre is displayed with a link to the appropriate **/Store/Browse** URL.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store** to verify that each Genre links to the appropriate **/Store/Browse** URL.

	![Browsing Genres with links to Browse page](./images/Browsing-genres-with-links-to-Browse-page.png?raw=true "Browsing Genres with links to Browse page")

	_Browsing Genres with links to Browse page_
 
<a name="Ex6Task10" />
#### Task 10 - Using Dynamic ViewModel Collection to Pass Values####

In this task, you will learn a simple and powerful method to pass values between the Controller and the View without making any changes in the Model. MVC 4 provides the collection "ViewModel" than can be assigned to any dynamic value and accessed inside controllers and views as well.

You will now use ViewBag dynamic collection to pass a list of "**Starred genres**" from the controller to the view. The Store Index view will access to **ViewModel** and display the information.

1. Close the browser if needed, to return to the Visual Studio window. Open **StoreController.cs** and modify **Index** method to create a list of starred genres into ViewModel collection :
	<!-- mark:13-14 -->
	````C#
	public ActionResult Index()
	{
	    // Create list of genres
	    var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };
	
	    // Create your view model
	    var viewModel = new StoreIndexViewModel
	    {
	        NumberOfGenres = genres.Count,
	        Genres = genres
	    };
	
	    ViewBag.Starred = new List<string> { "Rock", "Jazz" };
	            
	    return View(viewModel);
	}
	````

	> **Note:** You could also use the syntax **ViewBag["Starred"]** to access the properties. 

1. The star icon **"starred.png"** is included in the **Source\Assets\Images** folder of this lab. In order to add them to the application, drag their content from a **Windows Explorer** window into the **Solution Explorer** in Visual Web Developer Express, as shown below:

 	![Adding star image to the solution](./images/Adding-star-image-to-the-solution.png?raw=true "Adding star image to the solution")
 
	_Adding star image to the solution_

1. Open the view **Store/Index.cshtml** and modify the content. You will read the "starred" property in the **ViewBag** collection, and ask if the current genre name is in the list. In that case you will show a star icon right to the genre link.
	
	<!-- mark:16-18,22-24 -->
	````HTML(C#)
	@model MvcMusicStore.ViewModels.StoreIndexViewModel

	@{
		ViewBag.Title = "Browse Genres";
	}

	<h2>Browse Genres</h2>

	<p> Select from @Model.NumberOfGenres genres</p>

	<ul>
		@foreach (string genreName in Model.Genres) {
			<li>
				@Html.ActionLink(genreName, "Browse", new { genre = genreName }, null)

				@if (ViewBag.Starred.Contains(genreName)) { 
					<img src="../../Content/Images/starred.png" alt="Starred element" />
				}
			</li>
			}
	</ul>
	<br />
	<h5><img src="../../Content/Images/starred.png" alt="Starred element" />Starred genres 20% Off!</h5>
	````
 
<a name="Ex6Task11" />
#### Task 11 - Running the Application####

In this task, you will test that the starred genres display a star icon.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store** to verify that each featured genre has the respecting label:

 	![Browsing Genres with starred elements](./images/Browsing-Genres-with-starred-elements.png?raw=true "Browsing Genres with starred elements")
 
	_Browsing Genres with starred elements_

	
<a name="Exercise7" />
### Exercise 7: A lap around MVC4 new template ###

In this exercise, you will explore the enhancements in the ASP.NET MVC4 project templates, taking a look at the most relevant features of the new template.

<a name="Ex7Task1" />
#### Task 1: Exploring the MVC4 Internet Application Template####

1. If not already open, start Microsoft Visual Studio 11 Express Beta for Web from **Start** | **All Programs** | **Microsoft Visual Studio 11 Express** | **Visual Studio 11 Express Beta for Web**.

1. Select the **File | New | Project** menu command. In the **New Project** dialog, select the **Visual C#|Web** template on the left pane tree, and choose the **ASP**.**NET MVC 4 Web Application.** Name the project **MusicStore**, select a location (or leave the default) and click **OK**. 

	![Creating a new MVC4 Project](images/creating-a-new-mvc4-project.png?raw=true "Creating a new MVC4 Project")

	_Creating a new MVC4 Project_

1. In the **New ASP.NET MVC 4 Project** dialog, select the **Internet Application** project template and click **OK**. Notice you can select either Razor or ASP.NET as the view engine.

	![Creating a new MVC4 Internet Application](images/creating-a-new-mvc4-internet-application.png?raw=true "Creating a new MVC4 Internet Application")

	_Creating a new MVC4 Internet Application_

	>**Note**: Razor syntax has been introduced in ASP.NET MVC 3. Its goal is to minimize the number of characters and keystrokes required in a file, enabling a fast and fluid coding workflow. Razor leverages existing C#/VB (or other) language skills and delivers a template markup syntax that enables an awesome HTML construction workflow.

1.	Press **F5** to run the solution and see the renewed templates. You can check out the following features:

	1. **Modern-style templates**

		The templates have been renewed, providing more modern-looking styles.

		![MVC4 restyled templates](images/mvc4-restyled-templates.png?raw=true "MVC4 restyled templates")

		_MVC4 restyled templates_

	1. **Richer UI with JavaScript**

		Another enhancement to default project templates is the use of JavaScript to provide a more interactive JavaScript. The Login and Register links used in the template exemplify how to use the jQuery UI Dialog to display a fancy login screen. Click the **Log in** link located on the upper-right corner of the home page. Then, click the register link located next to the login link.

		![Log in and Register links](images/login-and-register-links.png?raw=true "Log in and Register links")
		
		_Log in and Register links_
		
			
		![log-in-dialog](images/log-in-dialog.png?raw=true "Log in dialog")

		_Log in dialog_

		
		![Register-dialog](images/register-dialog.png?raw=true "Register dialog")

		_Register dialog_
	
	1. **Adaptive Rendering**
		
		Check out resizing the browser window and notice how the page layout dynamically adapts to the new window size. These templates use the adaptive rendering technique to render properly in both desktop and mobile platforms without any customization. 

		![MVC 4 project template in different browser sizes](images/mvc-4-project-template-in-different-browser-s.png?raw=true "MVC 4 project template in different browser sizes")
		
		_MVC 4 project template in different browser sizes_
		
1. Close the browser to stop the debugger and return to Visual Studio.

1. Now you are able to explore the solution and check out some of the new features introduced by ASP.NET MVC 4 in the project template.

	![MVC4-internet-application-project-template](images/MVC4-internet-application-project-template.png?raw=true "The MVC4 Internet Application Project Template")

	_The MVC4 Internet Application Project Template_	

	1. **HTML5 markup**

		Browse template views to find out the new theme markup.

		![New template, using Razor and HTML5 markup (About.cshtml)](images/new-template-using-razor-and-html5-markup-abo.png?raw=true "New template, using Razor and HTML5 markup (About.cshtml)")

		_New template, using Razor and HTML5 markup (About.cshtml)_

	1. **JavaScript libraries included**

		* **jQuery**: jQuery  simplifies HTML document traversing, event handling, animating, and Ajax interactions.
		
		* **jQuery UI**: This library provides abstractions for low-level interaction and animation, advanced effects and themeable widgets, built on top of the jQuery JavaScript Library.
			
			>**Note:** You can learn about jQuery and jQuery UI in <http://docs.jquery.com/>.
			
		* **KnockoutJS**: The MVC4 default template now includes **KnockoutJS**, a JavaScript MVVM framework that lets you create rich and highly responsive web applications using JavaScript and HTML. Like in MVC3, jQuery and jQuery UI libraries are also included in ASP.NET MVC 4.

			>**Note:** You can get more information about KnockOutJS library in this link: <http://learn.knockoutjs.com/>.
		
		* **Modernizr**: This library runs automatically, making your site compatible with older browsers when using HTML5 and CSS3 technologies.

			>**Note:** You can get more information about Modernizr library in this link: <http://www.modernizr.com/>.


	1. **ASP.NET Universal providers included in the solution**
	
		ASP.NET Universal Providers extend Session, Membership, Roles and Profile support to SQL Compact Edition and SQL Azure. By only configuring the right connection string, your application will be able to work with SQL Server (plus Express), SQL Server Compact or SQL Azure.

		![ASP.NET Universal Providers reference is now included](images/aspnet-universal-providers-reference-is-now-i.png?raw=true "ASP.NET Universal Providers reference is now included")

		_ASP.NET Universal Providers reference is now included_

		>**Note:** ASP.NET Universal Providers Library is also available for MVC3 projects in the NuGet public feed. You can learn more about SQL Azure in this link: <http://msdn.microsoft.com/en-us/wazplatformtrainingcourse_sqlazure_unit>.

---
	
<a name="Summary" />
## Summary ##

By completing this Hands-On Lab you have learned the fundamentals of ASP.NET MVC:

- The core elements of an MVC application and how they interact

- How to create an ASP.NET MVC Application

- How to add and configure Controllers to handle parameters passed through the URL and querystring

- How to add a layout master page to setup a template for common HTML content, a StyleSheet to enhance the look and feel and a View template to display HTML content

- How to use the ViewModel pattern for passing properties to the View template for them to display dynamic information

- How to use parameters passed to Controllers in the View template

- How to add links to pages inside the ASP.NET MVC application

- How to add and use dynamic properties in a View

- The enhancements in the ASP.NET MVC 4 project templates