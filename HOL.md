# ASP.NET MVC 4.0 Fundamentals #

## Overview ##

This Hands-On Lab is based on MVC (Model View Controller) Music Store, a tutorial application that introduces and explains step-by-step how to use ASP.NET MVC and Visual Studio 2011. Throughout the lab you will learn the simplicity, yet power of using these technologies together. You will start with a simple application and will build it until you have a fully functional MVC Web Application.

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

 
The MVC pattern helps you to create applications that separate the different aspects of the application (input logic, business logic, and UI logic), while providing a loose coupling between these elements. This separation helps you manage complexity when you build an application, because it enables you to focus on one aspect of the implementation at a time. In addition to managing complexity, the MVC pattern makes it easier to test applications than it is to test a traditional ASP.NET Web application, encouraging the use of test-driven development (TDD) for creating an applications.

Then, the **ASP.NET MVC** framework provides an alternative to the ASP.NET Web Forms pattern for creating MVC-based Web applications. The **ASP.NET MVC** framework is a lightweight, highly testable presentation framework that (as with Web-forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication so you get all the power of the core .NET framework.  This is useful if you are already familiar with ASP.NET Web Forms because all of the libraries that you already use are available to you in ASP.NET MVC as well.

In addition, the loose coupling between the three main components of an MVC application also promotes parallel development. For instance, one developer can work on the view, a second developer can work on the controller logic, and a third developer can focus on the business logic in the model.

### Objectives ###

In this Hands-On Lab, you will learn how to:

- Create an ASP.NET MVC application from scratch based on the Music Store Application tutorial

- Add Controllers to handle URLs to the Home page of the site and for browsing its main functionality

- Add a View to customize the content displayed along with its style

- Add Model classes to contain and manage data and domain logic

- Use View Model pattern to pass information from controller actions to the view templates

 
### System Requirements ###

You must have the following items to complete this lab:

- Visual Studio 11 Express Beta for Web

 
### Setup ###

_**Installing Code Snippets**_
For convenience, much of the code you will be managing along this lab is available as Visual Studio code snippets. To install the code snippets run **.\Source\Assets\CodeSnippets.vsi** file.

_**Installing Web Platform Installer**_
This section assumes that you don't have some or all the system requirements installed. In case you do, you can simply skip this section.

Microsoft Web Platform Installer (WebPI) is a tool that manages the installation of the prerequisites for this Lab.

> **Note:** As well as the Microsoft Web Platform, WebPI can also install many of the open source applications that are available like Umbraco, Kentico, DotNetNuke and many more.  These are very useful for providing a foundation from which to customize an application to your requirements, dramatically cutting down your development time.

Please follow these steps to downloads and install Microsoft Visual Studio 2011 Edition and SQL Server 2008 Express Edition:

1. Install the Web Platform Installer 3.0. To do this, Navigate to [http://go.microsoft.com/fwlink/?LinkID=194638](http://go.microsoft.com/fwlink/?LinkID=194638) using a web browser. Click **Run** in the File Download Security Warning.

 	![File download pop up](./images/File-download-pop-up.png?raw=true "File download pop up")
 
	_File download pop up_

1. Allow the program to make changes to your computer by clicking **Yes** in the User Account Control pop up.

 
_**Running Web Platform Installer to install Lab prerequisites**_

1. The Web Platform Installer launches and shows a list of downloads. 

1. Choose the **Products** category at the top side of the window, then click the **All** folder at the left, and then clik **Add** for the following items:

	- **Visual Studio 2011**

 	![Web Platform Installer window](./images/Web-Platform-Installer-window.png?raw=true "Web Platform Installer window")
 
	_Web Platform Installer window_

1. Click on **Install**. The **Web Platform Installer** displays the list of software to be installed. Accept by clicking **I Accept**.

 	![Web Platform Installation](./images/Web-Platform-Installation.png?raw=true "Web Platform Installation")
 
	_Web Platform Installation_

1. The SQL Server Express Edition could be configured to run with **Windows Integrated Authentication** or **Mixed Mode Authentication**. To simplify this Lab, select **Windows Integrated Authentication** and click on **Continue**. SQL Server will then use your Windows credentials to connect to the databases.

 	![Web Platform Installation - SQL Server Express Authentication mode](./images/Web-Platform-Installation-–-SQL-Server-Express-Authentication-mode.png?raw=true "Web Platform Installation - SQL Server Express Authentication mode")
 
	_Web Platform Installation - SQL Server Express Authentication mode_

1. The appropriate components will be downloaded and installed.

 	![Web Platform Installation - Download progress](./images/Web-Platform-Installation-–-Download-progress.png?raw=true "Web Platform Installation - Download progress")
 
	_Web Platform Installation - Download progress_

1. If your computer doesn't have the **Microsoft.NET Framework 4.0**, a pop up will ask you to restart the computer. Click **Yes**.

 	![Web Platform Installation - Microsoft.NET Framework 4 installation](./images/Web-Platform-Installation-–-Microsoft.NET-Framework-4-installation.png?raw=true "Web Platform Installation - Microsoft.NET Framework 4 installation")
 
	_Web Platform Installation - Microsoft.NET Framework 4 installation_

1. After rebooting your PC, restart the Web Platform Installer by selecting it from the **Start** menu | **All Programs** | **Microsoft** **Web Platform Installer**.

 	![Starting Web Platform Installer](./images/Starting-Web-Platform-Installer.png?raw=true "Starting Web Platform Installer")
 
	_Starting Web Platform Installer_

1. The **Web Platform Installer** will resume downloading and installing the products. When this process is finished, the Installer will show the list of all the software installed. Click **Finish**.

 	![Web Platform Installer](./images/Web-Platform-Installer.png?raw=true "Web Platform Installer")
 
	_Web Platform Installer_

	> **Note:** If you get an error with SQL Server Express 2008 R2 installation like the following, please dismiss it. You will be able to work-around it in **ASP.NET MVC 2.0 Models and Data Access** Hands-on lab.

	> ![](./images/Note-02.png?raw=true)

	> SQL Server Express 2008 R2 installation error

1. Finally the Web Platform Installer shows the installed products. Click **Exit** to finish the setup process.

 
## Exercises ##

This Hands-On Lab is comprised by the following exercises:

1. Exercise 1: Creating MusicStore ASP.NET MVC Web Application Project

1. Exercise 2: Creating a Controller

1. Exercise 3: Passing parameters to a Controller

1. Exercise 4: Adding Ajax for Searching Activities

1. Exercise 5: Creating a View Model

1. Exercise 6: Using parameters in View

 
Estimated time to complete this lab: **45 minutes**.

> **Note:** Each exercise is accompanied by an **End** folder containing the resulting solution you should obtain after completing the exercises. You can use this solution as a guide if you need additional help working through the exercises.

 
### Next Step ###

#Click here to enter text.#
### Exercise 1: Creating MusicStore ASP.NET MVC Web Application Project ###

In this exercise, you will learn how to create an ASP.NET MVC application in Visual Studio 2010 as well as its main folder organization. Additionally, you'll learn how to add a new Controller and have it display a simple string at the Application screen.

#### Task 1 - Creating the ASP.NET MVC Web Application Project ####

1. In this task, you will create an empty ASP.NET MVC application project using the MVC Visual Studio template. Start Microsoft Visual Studio 2011 from **Start** | **All Programs** | **Microsoft Visual Studio 2011** | **Microsoft Visual Studio 2011**.

1. On the **File** menu, click **New Project**.

1. In the **New Project** dialog box select the **ASP.NET MVC 4 Web Application** project type, located under **Visual [C#|Basic],** **Web** template list.

1. Change the **Name** to **MvcMusicStore**.

1. Set the location of the solution inside a new **Begin** folder in this Exercise's installation folder, for example **C:\WebCampsTrainingKit\Labs\Beginner-ASP.NET-MVC-Fundamentals MVC3\Source\Ex01-CreatingMusicStoreProject\Begin**. Click **OK**.

 	![Create New Project Dialog Box - C](./images/Create-New-Project-Dialog-Box---C.png?raw=true "Create New Project Dialog Box - C")
 
	_Create New Project Dialog Box - C#_

1. In the **New ASP.NET MVC 4 Project** dialog box select the **Empty** template and make sure that the **View engine** selected is **ASPX**. Click **OK**.

 	![New ASP.NET MVC 4 Project Dialog Box - C](./images/New-ASP.NET-MVC-3-Project-Dialog-Box---C.png?raw=true "New ASP.NET MVC 4 Project Dialog Box - C")
 
	_New ASP.NET MVC 4 Project Dialog Box - C#_

#### Task 2 - Exploring the Solution Structure ####

The ASP.NET MVC framework includes a Visual Studio project template that helps you create Web applications that are structured to support the MVC pattern. This template creates a new MVC Web application that is configured to have the required folders, item templates, and configuration-file entries.

In this task, you will examine the solution structure to understand the involved elements and its relationships. The following folders are included even in an Empty ASP.NET MVC application because the ASP.NET MVC framework by default uses a "convention over configuration" approach and makes some default assumptions based on folder naming conventions.

1. Once the project is created, review the folder structure that has been created in the Solution Explorer on the right side:

 	![ASP.NET MVC Folder structure in Solution Explorer](./images/ASP.NET-MVC-Folder-structure-in-Solution-Explorer.png?raw=true "ASP.NET MVC Folder structure in Solution Explorer")
 
	_ASP.NET MVC Folder structure in Solution Explorer_

	1. **Content**. This folder is the recommended location to add content files such as cascading style sheet files, images, and so on. In general, the Content folder is used for static files.

	1. **Controllers.** This folder will contain the controller classes. In an MVC based application, controllers are responsible for handling end user interaction, manipulating the model, and ultimately choosing a view to render to display UI.

		> **Note:** The MVC framework requires the names of all controllers to end with "Controller"-for example, HomeController, LoginController, or ProductController.

	1. **Models**. This folder is provided for classes that represent the application model for the MVC Web application. This usually includes code that defines objects and the logic for interacting with the data store. Typically, the actual model objects will be in separate class libraries. However, when you create a new application, you might include classes and then move them into separate class libraries at a later point in the development cycle.

	1. **Scripts**. This is the recommended folder to store JavaScript files in your application.

	1. **Views**. This folder is the recommended location for views, the components responsible for displaying the application's user interface. Views use .aspx, .ascx, .cshtml and .master files, in addition to any other files that are related to rendering views. Views folder contains a folder for each controller; the folder is named with the controller-name prefix. For example, if you have a controller named **HomeController**, the Views folder will contain a folder named Home. By default, when the ASP.NET MVC framework loads a view, it looks for an .aspx file with the requested view name in the Views\controllerName folder (**Views\[ControllerName]\[Action].aspx**) or (**Views\[ControllerName]\[Action].cshtml**) for Razor Views. 

	1. **Views\Shared.** By default, there is also a folder named Shared in the Views folder, which does not correspond to any controller. The Shared folder is used for views that are shared across multiple controllers. For example, you can put the Web application's master page in the Shared folder.

		> **Note:** In addition to the folders listed previously, an MVC Web application uses the **Global.asax** file to set global URL routing defaults, and it uses the **Web.config** file to configure the application.

 
#### Task 3 - Adding a HomeController ####

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

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex1 HomeController Index - CSharp)

	````C#
	public string Index()
	{
	  return "Hello from Home";
	}
	````

#### Task 4 - Running the Application ####

In this task, you will try out the Application in a web browser.

1. Press **F5** to run the Application. The project gets compiled and the ASP.NET Web Server that is built-into Visual Web Developer starts. Visual Web Developer will automatically open a web browser pointing to the web-server URL. This will allow you to try out the web application.

 	![Application running in a web browser](./images/Application-running-in-a-web-browser.png?raw=true "Application running in a web browser")
 
	_Application running in a web browser_

	> **Note**: ASP.NET Development Server will run the website on a random free port number. In the figure above, the site is running at http://localhost:49161/, so it's using port 49161. Your port number may vary.

1. Close the browser.

 
### Next Step ###

##Click here to enter text.##
### Exercise 2: Creating a Controller ###

In this exercise, you will learn how to create a Controller to implement simple functionality of the Music Store. That controller will define action methods to handle each specific request:

- A listing page of the music genres in the Music Store

- A browse page that lists all of the music albums for a particular genre

- A details page that shows information about a specific music album

For the scope of this exercise, you will have those actions to simply return a string by now.

 
#### Task 1 - Adding a New StoreController Class ####

In this task, you will add a new Controller.

1. If not already open, start Microsoft Visual Studio 2011 from **Start** | **All Programs** | **Microsoft Visual Studio 2011** | **Microsoft Visual Studio 2011**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex02-CreatingAController\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1. Add the new controller. To do this, right-click the **Controllers** folder within the Solution Explorer, select **Add** and then the **Controller** command. Change the **Controller** **Name** to **StoreController**, and click **Add**.

 _/Add Controller Dialog_
 
#### Task 2 - Modifying the StoreController's Actions ####

In this task, you will modify Controller methods that are called **actions**. These actions are responsible for responding to URL requests and determine the content that should be sent back to the browser or user that invoked the URL.

1. The **StoreController** class already has an **Index** method. You will use it later in this Lab to implement the page that lists all genres of the music store. For now, just replace the **Index** method with the following code that returns a string "Hello from Store.Index()":

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex2 StoreController Index - CSharp)

	````C#
	public string Index()
	{
	  return "Hello from Store.Index()";
	}
	````

1. Add the **Browse** and **Details** methods. To do this, add the following code to the **StoreController**:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex2 StoreController BrowseAndDetails - CSharp)

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

#### Task 3 - Running the Application ####

In this task, you will try out the Application in a web browser.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to verify each action's implementation.

	1. **/Store**. You will see **"Hello from Store.Index()"**.

	1. **/Store/Browse**. You will see **"Hello from Store.Browse()"**.

	1. **/Store/Details**. You will see **"Hello from Store.Details()"**.

 		![Browsing StoreBrowse](./images/Browsing-StoreBrowse.png?raw=true "Browsing StoreBrowse")
 
		_Browsing /Store/Browse_

1. Close the browser.

 
### Next Step ###

#Click here to enter text.#


### Exercise 3: Passing parameters to a Controller ###

Until now, you have been returning constant strings from the Controllers. In this exercise you will learn how to pass parameters to a Controller using the URL and querystring and then making the method actions respond with text to the browser.

#### Task 1 - Adding Genre Parameter to StoreController ####

In this task, you will use the **querystring** to send parameters to the **Browse** action method in the **StoreController**.

1. If not already open, start Microsoft Visual Studio 2011 from **Start** | **All Programs** | **Microsoft Visual Studio 2011** | **Microsoft Visual Studio 2011**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex03-PassingParametersToAController\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1. Open **StoreController** class. To do this, in the **Solution Explorer**, expand the **Controllers** folder and double-click **StoreController.cs**.

1. Change the **Browse** method, adding a string parameter to request for a specific genre. ASP.NET MVC will automatically pass any querystring or form post parameters named **genre** to this action method when invoked. To do this, replace the **Browse** method with the following code:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex3 StoreController BrowseMethod - CSharp)

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

 
#### Task 2 - Running the Application ####

In this task, you will try out the Application in a web browser and use the **genre** parameter.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Browse?Genre=Disco** to verify that the action receives the genre parameter.

 	![Browsing StoreBrowseGenre=Disco](./images/Browsing-StoreBrowseGenre=Disco.png?raw=true "Browsing StoreBrowseGenre=Disco")
 
	_Browsing /Store/Browse?Genre=Disco_

1. Close the browser.

 
#### Task 3 - Adding an Id Parameter Embedded in the URL ####

In this task, you will use the **URL** to pass an **Id** parameter to the **Details** action method of the **StoreController**. ASP.NET MVC's default routing convention is to treat the segment of a URL after the action method name as a parameter named **Id**.  If your action method has a parameter named Id then ASP.NET MVC will automatically pass the URL segment to you as a parameter. In the URL **Store/Detail/5**, **Id** will be interpreted as **5**.

1. Change the **Details** method of the **StoreController**, adding an **int** parameter called **id**. To do this, replace the **Details** method with the following code:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex3 StoreController DetailsMethod - CSharp)

	````C#
	//
	// GET: /Store/Details/5
	
	public string Details(int id)
	{
	  string message = "Store.Details, ID = " + id;
	
	  return message;
	}
	````
 
#### Task 4 - Running the Application ####

In this task, you will try out the Application in a web browser and use the **Id** parameter.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Details/5** to verify that the action receives the id parameter.

 	![Browsing StoreDetails5](./images/Browsing-StoreDetails5.png?raw=true "Browsing StoreDetails5")
 
	_Browsing /Store/Details/5_

 
### Next Step ###

Exercise 4: Creating a View
 


### Exercise 4: Creating a View ###

So far you have been returning strings from controller actions. Although that's a useful way of understanding how controllers work, it's not how you'd want to build a real web application. Views are components that provide a better approach for generating HTML back to the browser with the use of template files.

In this exercise you will learn how to add a MasterPage to setup a template for common HTML content, a StyleSheet to enhance the look and feel of the site and finally a View template to enable HomeController to return HTML.

#### Task 1 - Adding a MasterPage ####

ASP.NET MasterPages are layout files that allow you to setup a template for common HTML to use across the entire website. In this task you will add a MasterPage with a common header with links to the Home page and Store area.

1. If not already open, start Microsoft Visual Studio 2011 from **Start** | **All Programs** | **Microsoft Visual Studio 2011** | **Microsoft Visual Studio 2011**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex04-CreatingAView\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1. Add a MasterPage. Because it is a shared resource you will create it under the **/Views/Shared** folder. To do this, expand the **Views** folder and right-click the **Shared** folder. Select **Add** and then the **New Item** command.

 	![Adding a new item](./images/Adding-a-new-item.png?raw=true "Adding a new item")
 
	_Adding a new item_

1. In the **Add New Item** dialog box select the **MVC 4 View Master Page (ASPX)** template, located under **Visual [C#|Basic],** **Web** template list. Change the name to **Site.Master** and click **Add**.

 ![Add new item dialog](./images/Add-New-Item-Dialog.png?raw=true "Adding a new item dialog")
 _Add New Item Dialog - C#_

1. Site.Master file is added. This template contains the HTML container layout for all pages on the site.  It includes the **<html>** element for the HTML response, as well as the **<head>** and **<body>** elements. **<asp:ContentPlaceholder>** tags within the HTML content identify regions that view templates will be able to fill in with dynamic content.

	````HTML(C#)
	<%@ Master Language="C#" Inherits="System.Web.Mvc.ViewMasterPage" %>
	
	<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
	
	<html xmlns="http://www.w3.org/1999/xhtml" >
	<head runat="server">
	    <title><asp:ContentPlaceHolder ID="TitleContent" runat="server" /></title>
	</head>
	<body>
	    <div>
	        <asp:ContentPlaceHolder ID="MainContent" runat="server">
	    
	        </asp:ContentPlaceHolder>
	    </div>
	</body>
	</html>
	````
1. Add a common header with links to the Home page and Store area on all pages in the site. In order to do that, add the following code inside the **<div>** statement.

	````HTML(C#)
	<%@ Master Language="C#" Inherits="System.Web.Mvc.ViewMasterPage" %>
	
	<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
	
	<html xmlns="http://www.w3.org/1999/xhtml" >
	<head runat="server">
	    <title><asp:ContentPlaceHolder ID="TitleContent" runat="server" /></title>
	</head>
	<body>
	    <div>
	        <div id="header">
	            <h1>ASP.NET MVC MUSIC STORE</h1>
	            <ul id="navlist">
	                <li class="first"><a href="/" id="current">Home</a></li>
	                <li><a href="/Store/">Store</a></li>
	            </ul>
	        </div>
	        <asp:ContentPlaceHolder ID="MainContent" runat="server">
	    
	        </asp:ContentPlaceHolder>
	    </div>
	</body>
	</html>
	````

> **Note:** Did you know? Visual Studio 2010 has snippets that make it easy to add commonly used code in HTML, code files and more! Try it out by typing **<div + tab (twice)** to insert a complete **div** tag.

#### Task 2 - Adding CSS Stylesheet ####

The empty project template includes a very streamlined CSS file which just includes styles used to display validation messages. You will use additional CSS and images (potentially provided by a designer) in order to enhance the look and feel of the site.

In this task, you will add a CSS stylesheet to **Site.Master** to define the styles of the site.

1. The CSS file and images are included in the Source\Assets\Content of this Lab. In order to add them to the application, drag their content from a **Windows Explorer** window into the **Solution Explorer** in Visual Web Developer Express, as shown below:

 	![Dragging style contents](./images/Dragging-style-contents.png?raw=true "Dragging style contents")
 
	_Dragging style contents_

1. A warning dialog will appear, asking for confirmation to replace Site.css file. Click **Yes**.

1. ![Warning Dialog](./images/Warning-Dialog.png?raw=true "Warning Dialog")

	_Warning Dialog_

1. Add a **<link>** element into the **<head>** tag of **Site.Master** file, with a reference to the css file you just added:

	````HTML
	<head runat="server">
	    <link href="/Content/Site.css" rel="Stylesheet" type="text/css" />
	    <title><asp:ContentPlaceHolder ID="TitleContent" runat="server" /></title>
	</head>
	````

 
#### Task 3 - Adding a View Template ####

In this task, you will add a View template to generate the HTML response that will use the Master Page and CSS added in this exercise.

1. To use a View template when browsing the site's home page, first you need to indicate that instead of returning a string, the **HomeController Index** method should return a **View**. Open **HomeController** class and change its**Index** method to return an **ActionResult,** and have it return **View()**.

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex4 HomeController Index - CSharp)

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

 	![Adding a View from within the Index method - C](./images/Adding-a-View-from-within-the-Index-method-–-C.png?raw=true "Adding a View from within the Index method - C")
 
	_Adding a View from within the Index method - C#_

1. The **Add View** Dialog appears. It allows generating View template files. By default this dialog pre-populates the name of the View template so that it matches the action method that will use it.  Because you used the **Add View** context menu within the **Index** action method of the HomeController, the **Add View** dialog has **Index** as the default view name.  Because there is a **Site.Master** MasterPage template within the project, the dialog also pre-fills that name as the master page template the View should be based on. Click **Add**.

 	![Add View Dialog](./images/Add-View-Dialog.png?raw=true "Add View Dialog")
 
	_Add View Dialog_

1. Visual Studio generates an **Index.aspx** view template inside the Views\Home folder and then opens it.

 	![Add View Dialog](./images/Add-View-Dialog.png?raw=true "Add View Dialog")
 
	_Add View Dialog_

	> **Note:** name and location of the **Index.aspx** file is relevant and follows the default ASP.NET MVC naming conventions.

	> The folder (\Views\**Home**) matches the controller name (**Home**Controller). The View template name (**Index**), matches the controller action method which will be displaying the View.

	> This way, ASP.NET MVC avoids having to explicitly specify the name or location of a View template when using this naming convention to return a View.

1. The generated View template is based on the **Site.master** template earlier defined, and contains two **<asp:content>** sections that enables you to override to fill with the page content. Update the Title to **Home**, and change the main content to **This is the Home Page**, as shown in the code below:

	````HTML
	<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	    Home
	</asp:Content>
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

	    <h2>This is the Home Page</h2>
	
	</asp:Content>
	````

1. Select **MvcMusicStore** project in the Solution Explorer and Press **F5** to run the Application.

 	![MvcMusicStore Project selected in the Solution Explorer](./images/MvcMusicStore-Project-selected-in-the-Solution-Explorer.png?raw=true "MvcMusicStore Project selected in the Solution Explorer")
 
	_MvcMusicStore Project selected in the Solution Explorer_

 
### Next Step ###

Click here to enter text.
**Exercise 4: Verification**
In order to verify that you have correctly performed all the steps in the previous exercise, proceed as follows:

1. With the application open in a browser, you should note that:

	1. The HomeController's Index action method found and displayed the **\Views\Home\Index.aspx** View template, even though the code called **return View()**, because the View template followed the standard naming convention.

	1. The Home Page displays the welcome message defined within the **\Views\Home\Index.aspx** view template.

	1. The Home Page is using the **MasterPage** template, and so the welcome message is contained within the standard site HTML layout.

 		![Home Index View using the MasterPage and style defined](./images/Home-Index-View-using-the-MasterPage-and-style-defined.png?raw=true "Home Index View using the MasterPage and style defined")
 
		_Home Index View using the MasterPage and style defined_

 
### Next Step ###

Click here to enter text.


### Exercise 5: Creating a View Model ###

So far you made your Views display hardcoded HTML, but in order to create dynamic web applications, the View template should receive information from the Controller. One common technique to be used for that purpose is the **ViewModel** pattern, which allows a Controller to package up all the information needed to generate the appropriate HTML response.

In this exercise, you will learn how to create a ViewModel class and add the needed properties: in this case the number of genres in the store and a list of those genres. Also, you will update the StoreController to use the created ViewModel and finally you will create a new View template that will display the mentioned properties in the page.

#### Task 1 - Creating a ViewModel Class ####

In this task, you will create a ViewModel class that will implement the Store genre listing scenario.

1. If not already open, start Microsoft Visual Studio 2011 from **Start** | **All Programs** | **Microsoft Visual Studio 2011** | **Microsoft Visual Studio 2011**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex05-CreatingAViewModel\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1. Create a **ViewModels** folder to hold the ViewModel. To do this, right-click the top-level **MvcMusicStore** project, select **Add** and then **New Folder**.

 	![Adding a new folder](./images/Adding-a-new-folder.png?raw=true "Adding a new folder")
 
	_Adding a new folder_

1. Name the folder **ViewModels**.

 	![ViewModels folder in Solution Explorer](./images/ViewModels-folder-in-Solution-Explorer.png?raw=true "ViewModels folder in Solution Explorer")
 
	_ViewModels folder in Solution Explorer_

1. Create a **ViewModel** class. To do this, right-click on the **ViewModels** folder recently created, select **Add** and then **Class**.

 	![Adding a new Class](./images/Adding-a-new-Class.png?raw=true "Adding a new Class")
 
	_Adding a new Class_

1. Name the class **StoreIndexViewModel** and click **Add**.

 	![Creating StoreIndexViewModel class - C](./images/Creating-StoreIndexViewModel-class-–-C.png?raw=true "Creating StoreIndexViewModel class - C")
 
	_Creating StoreIndexViewModel class - C#_

#### Task 2 - Adding Properties to the ViewModel class ####

There are two pieces of information to be passed from the StoreController to the View template in order to generate the HTML response wanted: the number of genres in the store and a list of those genres.

In this task, you will add those 2 properties to the **StoreIndexViewModel** class: **NumberOfGenres** (an integer) and **Genres** (a list of strings).

1. Add **NumberOfGenres** and **Genres** properties to the **StoreIndexViewModel** class. To do this, add the following 2 lines to the class definition:

	(Code Snippet - ASP.NET MVC 4.0  Fundamentals - Ex5 StoreIndexViewModel properties - CSharp)

	````C#
	public class StoreIndexViewModel
	{
	  public int NumberOfGenres { get; set; }
	  public List<string> Genres { get; set; }
	}
	````
	> **Note**: The **{ get; set; }** notation makes use of C#'s auto-implemented properties feature. It provides the benefits of a property without requiring us to declare a backing field.

 
#### Task 3 - Updating StoreController to use the StoreIndexViewModel ####

The **StoreIndexViewModel** class encapsulates the information needed to pass from **StoreController**'s **Index** method to a View template in order to generate a response.

In this task, you will update the **StoreController** to use the **StoreIndexViewModel**.

1. Open **StoreController** class. 

 	![Opening StoreController class](./images/Opening-StoreController-class.png?raw=true "Opening StoreController class")
 
	_Opening StoreController class_

1. In order to use the **StoreIndexViewModel** class from the **StoreController**, add the following namespace to the top of the **StoreController** code:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex5 StoreIndexViewModel using ViewModels - CSharp)

	````C#
	using MvcMusicStore.ViewModels;
	````

1. Change the **StoreController**'s **Index** action method so that it creates and populates a **StoreIndexViewModel** object and then passes it off to a View template to generate an HTML response with it.

	> **Note:** In Lab "ASP.NET MVC Models and Data Access" you will write code that retrieves the list of store genres from a database.  In the following code, you will create a **List** of dummy data genres that will populate the **StoreIndexViewModel**.

	> After creating and setting up the **StoreIndexViewModel** object, it will be passed as an argument to the **View** method. This indicates that the View template will use that object to generate an HTML response with it.

1. Replace the **Index** method with the following code:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex5 StoreController Index method - CSharp)

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

 
#### Task 4 - Creating a View Template that Uses StoreIndexViewModel ####

In this task, you will create a View template that will use a StoreIndexViewModel object passed from the Controller to display a list of genres.

1. Before creating the new View template, let's build the project so that the **Add View Dialog** knows about the **StoreIndexViewModel** class. Build the project by selecting the **Debug** menu item and then **Build MvcMusicStore**.

 	![Building the project](./images/Building-the-project.png?raw=true "Building the project")
 
	_Building the project_

1. Create a new View template. To do that, right-click inside the **Index** method and select **Add View.**

 	![Adding a View - C](./images/Adding-a-View-–-C.png?raw=true "Adding a View - C")
 
	_Adding a View - C#_

1. Because the **Add View Dialog** was invoked from the **StoreController**, it will add the View template by default in a \Views\Store\Index.aspx file.  The view will be based on the Site.Master MasterPage template. Check the **Create a strongly-typed-view** checkbox and then select the **StoreIndexViewModel** as the **Model class**. Also, make sure that the View engine selected is **ASPX (C#)**. Click **Add**.

 	![Add View Dialog - C](./images/Add-View-Dialog-–-C.png?raw=true "Add View Dialog - C")
 
	_Add View Dialog - C#_

	The \Views\Store\Index.aspx View template file is created and opened. Based on the information provided to the **Add View** dialog in the last step, the View template will expect a **StoreIndexViewModel** instance as the data to use to generate an HTML response. You will notice that by seeing that the template inherits a **ViewPage<MusicStore.ViewModels.StoreIndexViewModel>** in C# and a **ViewPage(Of MusicStore. StoreIndexViewModel)** in Visual Basic.

 
#### Task 5 - Updating the View Template ####

In this task, you will update the View template created in the last task to output the number of genres and their names within the page.

> **Note:** You will use <%: %> syntax (often referred to as "code nuggets") to execute code within the View template. There are two main ways you will see this used:

> 1. Code enclosed within <% %> will be executed

> 2. Code enclosed within <%: %> will be executed, and the result will be output to the page

1. In the Index.aspx file, replace the code inside the **Content2** ASP.NET Content control with the following:

	````HTML
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	
	    <h3> Browse Genres</h3>
	
	    <p> Select from <%: Model.NumberOfGenres %> genres</p>
	
	</asp:Content>
	````

	> **Note:** As soon as you finish typing the period after the word **Model**, Visual Studio's Intellisense feature supplies you with a list of possible properties and methods to choose from.

	> ![](./images/Note-03.png?raw=true)

	> _Getting Model properties and methods with Visual Studio's IntelliSense_

	> The **Model** property references the **StoreIndexViewModel** object that the Controller passed to the View template.  This means that you can access all of the data passed the Controller to the View template via the **Model** property, and format it into an appropriate HTML response within the View template.

	> You can just select the **NumberOfGenres** property from the Intellisense list rather than typing it in and then it will auto-complete it by pressing the **tab key**.

1. Loop over the genre list in the **StoreIndexViewModel** and create an HTML **<ul>** list using a **foreach** loop. Also change the code inside **Content1** ASP.NET Content control with a simple text: **Store Genres.**

	````HTML(C#)
	<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.ViewModels.StoreIndexViewModel>" %>
	
	<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	    Store Genres
	</asp:Content>
	
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	
	    <h3>Browse Genres</h3>
	
	    <p>Select from <%: Model.NumberOfGenres %> genres</p>
	
	    <ul>
	        <% foreach (string genreName in Model.Genres) { %>
	           <li>
	            <%: genreName %>
	           </li>
	        <% } %>
	    </ul>
	
	</asp:Content>
	````

1. Press **F5** to run the Application and browse **/Store**. You will see the list of genres passed in the **StoreIndexViewModel** object from the **StoreController** to the View template.

 	![View displaying a list of genres](./images/View-displaying-a-list-of-genres.png?raw=true "View displaying a list of genres")
 
	_View displaying a list of genres_

1. Close the browser.

 
### Next Step ###

Click here to enter text.
### Exercise 6: Using Parameters in View ###

In Exercise 3 you learned how to pass parameters to the Controller. In this exercise, you will learn how to use those parameters in the View template. For that purpose, you will be introduced first to Model classes that will help you to manage your data and domain logic. Additionally, you will learn how to create links to pages inside the ASP.NET MVC application without worrying of things like URL paths encoding.

#### Task 1 - Adding Model Classes ####

Unlike ViewModels, which are created just to pass information from the Controller to the View, Model classes are built to contain and manage data and domain logic. In this task you will add two model classes to represent these concepts: **Genre** and **Album**. In the next Hands-on Lab, these classes will be hooked to a database, mapping each one of them to a table.

1. If not already open, start Microsoft Visual Studio 2011 from **Start | All Programs | Microsoft Visual Studio 2011 | Microsoft Visual Studio 2011**.

1. In the **File** menu, choose **Open Project**. In the Open Project dialog, browse to Source\Ex06-UsingParametersInView\Begin, select **MvcMusicStore.sln** and click **Open**. Alternatively, you may continue with the solution that you obtained after completing the previous exercise.

1. Add a **Genre** Model class. To do this, right-click the **Models** folder in the **Solution Explorer**, select **Add** and then the **Class** option. Name the file **Genre.cs** and click **Add**.

 	![Add Genre Model Class - C](./images/Add-Genre-Model-Class-–-C.png?raw=true "Add Genre Model Class - C")
 
	_Add Genre Model Class - C#_

1. Add a **Name** property to the Genre class. To do this, add the following code:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex6 Genre - CSharp)

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

1. Following the same procedure as before, add an **Album** class. To do this, right-click the **Models** folder in the **Solution Explorer**, select **Add** and then the **Class** option. Name the file **Album.cs** and click **Add**.

1. Add two properties to the Album class**: Genre** and **Title**. To do this, add the following code:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex6 Album - CSharp)

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
 
#### Task 2 - Adding a StoreBrowseViewModel ####

A **StoreBrowseViewModel** will be used in this task to show the Albums that match a selected Genre.  In this task, you will create this class and then add two properties to handle the **Genre** and its **Album**'s List.

1. Add a **StoreBrowseViewModel** class. To do this, right-click the **ViewModels** folder in the **Solution Explorer**, choose **Add** and then **Class**. Name the file **StoreBrowseViewModel.cs**.

 	![Adding StoreBrowseViewModel Class - C](./images/Adding-StoreBrowseViewModel-Class-–-C.png?raw=true "Adding StoreBrowseViewModel Class - C")
 
	_Adding StoreBrowseViewModel Class - C#_

1. If you are using C#, add a reference to the Models in **StoreBrowseViewModel** class. To do this, add the following using namespace:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex6 UsingModel - CSharp)

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

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex6 ModelProperties - CSharp)

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

	> **Note:** What is**List<Album>** ?: This definition is using the **List<T>** type, where **T** constrains the type to which elements of this **List** belong to, in this case **Album** (or any of its descendants).

	> This ability to design classes and methods that defer the specification of one or more types until the class or method is declared and instantiated by client code is a feature of the C# language called **Generics**.

	> **List<T>** is the generic equivalent of the **ArrayList** type and is available in the **System.Collections.Generic** namespace**.** One of the benefits of using **generics** is that since the type is specified, you do not need to take care of type checking operations such as casting the elements into **Album** as you would do with an **ArrayList**.

 
#### Task 3 - Using the New ViewModel in the StoreController ####

 In this task, you will modify the**StoreController**'s **Browse** and **Details** action methods to use the new **StoreBrowseViewModel**.
1. If you are using C#, add a reference to the Models folder in **StoreController** class. To do this, expand the **Controllers** folder in the **Solution Explorer** and open the **StoreController** class. Then add the following code:

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex6 UsingModelInController - CSharp)

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

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex6 BrowseMethod - CSharp)

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

	(Code Snippet - ASP.NET MVC 4.0 Fundamentals - Ex6 DetailsMethod - CSharp)

	````C#
	//
	// GET: /Store/Details/5
	
	public ActionResult Details(int id)
	{
	  var album = new Album { Title = "Sample Album" };
	
	  return View(album);
	}
	````

#### Task 4 - Adding a Browse View Template ####

In this task, you will add a **Browse** View to show the Albums found for a specific Genre.

1. Before creating the new View template, you should build the project so that the **Add View Dialog** knows about the **ViewModel** class to use. Build the project by selecting the **Debug** menu item and then **Build MvcMusicStore**.

 	![Building the project in Visual Web Developer 2010](./images/Building-the-project-in-Visual-Web-Developer-2010.png?raw=true "Building the project in Visual Web Developer 2010")
 
	_Building the project in Visual Web Developer 2010_

 	![Building the project in Visual Studio 2010](./images/Building-the-project-in-Visual-Studio-2010.png?raw=true "Building the project in Visual Studio 2010")
 
	_Building the project in Visual Studio 2010_

1. Add a **Browse** View. To do this, right-click in the **Browse** action method of the **StoreController** and click **Add View**.

1. In the **Add View** dialog box, verify that the View Name is **Browse**. Check the **Create a strongly-typed view** checkbox and select **StoreBrowseViewModel** from the**Model class** dropdown. Leave the other fields with their default value. Then click **Add**.

 	![Adding a Browse View - C](./images/Adding-a-Browse-View-–-C.png?raw=true "Adding a Browse View - C")
 
	_Adding a Browse View - C#_

1. Modify the **Browse.aspx** to display the Genre's information, accessing the **StoreBrowseViewModel** object that is passed to the view template. To do this, replace the **Title Content** and the **Main Content** with the following content:

	````HTML(C#)
	<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.ViewModels.StoreBrowseViewModel>" %>
	
	<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	    Browse Albums
	</asp:Content>
	
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	
	    <h2>Browsing Genre: <%: Model.Genre.Name %></h2>
	
	    <ul>
	
	    <% foreach (var album in Model.Albums)
	       { %>
	       <li><%: album.Title %></li>
	    <% } %>
	    </ul>
	
	</asp:Content>
	````
 
#### Task 5 - Running the Application ####

In this task, you will test that the **Browse** method retrieves Albums from the **Browse** method action.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Browse?Genre=Disco** to verify that the action returns two Albums.

 	![Browsing Store Disco Albums](./images/Browsing-Store-Disco-Albums.png?raw=true "Browsing Store Disco Albums")
 
	_Browsing Store Disco Albums_

 
#### Task 6 - Displaying information About a Specific Album ####

In this task, you will implement the **Store/Details** view to display information about a specific album. In this Hands-on Lab, everything you will display about the album is already contained in the View template. So, instead of creating a **StoreDetailsViewModel** class you will use the current **StoreBrowseViewModel** template passing the Album to it.

1. Close the browser if needed, to return to the Visual Studio window. Add a new **Details** view for the **StoreController**'s**Details** action method. To do this, right-click the **Details** method in the **StoreController** class and click **Add View**.

1. In the **Add View** dialog view, verify that the **View Name** is **Details**. Check the **Create a strongly-typed view** checkbox and select **Album** from the**Model class** drop-down. Leave the other fields with their default value. Then click **Add**. This will create and open a **\Views\Store\Details.aspx** file.

 	![Adding a Details View - C](./images/Adding-a-Details-View-–-C.png?raw=true "Adding a Details View - C")
 
	_Adding a Details View - C#_

1. Modify the **Details.aspx** file to display the Album's information, accessing the **Album** object that is passed to the view template.  To do this, replace the **Main Content** with the following content:

	````HTML(C#)
	<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.Models.Album>" %>
	
	<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	    Details
	</asp:Content>
	
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	
	    <h2>Album: <%: Model.Title %></h2>
	
	</asp:Content>
	````
 
#### Task 7 - Running the Application ####

In this task, you will test that the **Details** View retrieves Album's information from the **Details action** method.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store/Details/5** to verify the album's information.

 	![Browsing Albums Detail](./images/Browsing-Albums-Detail.png?raw=true "Browsing Albums Detail")
 
	_Browsing Album's Detail_

 
#### Task 8 - Adding Links Between Pages ####

In this task, you will add a link in the Store View to have a link in every Genre name to the appropriate **/Store/Browse** URL. This way, when you click on a Genre, for instance **Disco**, it will navigate to **/Store/Browse?genre=Disco** URL.

Close the browser if needed, to return to the Visual Studio window. Update the **Index** page to add a link to the **Browse** page. To do this, in the **Solution Explorer** expand the **Views** folder, then the **Store** folder and double-click the **Index.aspx** page. Add a link to the Browse view indicating the genre selected. To do this, replace the following  code in the **Index.aspx**:	````HTML(C#)
	<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.ViewModels.StoreIndexViewModel>" %>
	
	<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	    Browse Genres
	</asp:Content>
	
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	
	    <h2>Browse Genres</h2>
	    
	    <p>Select from **<%: Model.NumberOfGenres** %></p>
	
	    <ul>
	        <% foreach (string genreName in Model.Genres)
	           { %>
	           <li>
	           <%: Html.ActionLink(genreName, "Browse", new { genre = genreName }, null) %>
	           </li>
	        <% } %>
	    </ul>
	
	</asp:Content>
	````

	> **Note**: another approach would be linking directly to the page, with a code like the following:

	> <a href="/Store/Browse?genre=<%: genreName %>"><%: genreName %></a>

	> Although this approach works, it depends on a hardcoded string. If you later rename the Controller, you will have to change this instruction manually. A better alternative is to use an **HTML Helper** method. ASP.NET MVC includes an HTML Helper method which is available for such tasks. The **Html.ActionLink()** helper method makes it easy to build HTML **<a>** links, making sure URL paths are properly URL encoded.

	> Htlm.ActionLink has several overloads. In this exercise you will use one that takes three parameters:

	> 1. Link text, which will display the Genre name

	> 2. Controller action name (**Browse**)

	> 3. Route parameter values, specifying both the name (**Genre**) and the value (**Genre name**)

 
#### Task 9 - Running the Application ####

In this task, you will test that each Genre is displayed with a link to the appropriate **/Store/Browse** URL.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store** to verify that each Genre links to the appropriate **/Store/Browse** URL.

 _/Browsing Genres with links to Browse page_
 
#### Task 10 - Using Dynamic ViewModel Collection to Pass Values ####

In this task, you will learn a simple and powerfull method to pass values between the Controller and the View without making any changes in the Model. MVC 4 provides the collection "ViewModel" than can be assigned to any dynamic value and accessed inside controllers and views as well.

You will now use ViewBag dynamic collection to pass from the controller to the view a list of "**Starred genres**". The Store Index view will access to **ViewModel** and display the information.

1. Close the browser if needed, to return to the Visual Studio window. Open **StoreController.cs** and modify **Index** method to create a list of starred genres into ViewModel collection :

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

	````VisualBasic
	Public Function Index() As ActionResult
	    'Create list of genres
	        Dim genres = New List(Of String) From {"Rock", "Jazz", "Country", "Pop", "Disco"}
	
	    'Create your view model
	    Dim viewModel = New StoreIndexViewModel With
	                    {.NumberOfGenres = genres.Count, 
	                     .Genres = genres}
	
	    ViewBag.Starred = New List(Of String) From {"Rock", "Jazz"}
	
	    Return View(viewModel) 
	End Function
	````

 **Note:** You could also use the syntax **ViewBag["Starred"]** to access the properties. 
1. The star icon **"starred.png"** is included in the **Source\Assets\Images** folder of this lab. In order to add them to the application, drag their content from a **Windows Explorer** window into the **Solution Explorer** in Visual Web Developer Express, as shown below:

 	![Adding star image to the solution](./images/Adding-star-image-to-the-solution.png?raw=true "Adding star image to the solution")
 
	_Adding star image to the solution_

1. Open the view **Store/Index.aspx** and modify the content. You will read the "starred" property in the **ViewBag** collection, and ask if the current genre name is in the list. In that case you will show a star icon right to the genre link.

	````HTML(C#)
	<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.ViewModels.StoreIndexViewModel>" %>
	
	<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	    Browse Genres
	</asp:Content>
	
	<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	
	    <h2>Browse Genres</h2>
	    
	    <p>Select from <%: Model.NumberOfGenres %></p>
	
	    <ul>
	        <% foreach (string genreName in Model.Genres)
	           { %>
	           <li>
	           <%: Html.ActionLink(genreName, "Browse", new { genre = genreName }, null) %> 
	           
	           <% if (ViewBag.Starred.Contains(genreName))  {  %>
	                <img src="../../Content/Images/starred.png" alt="Starred element" />
	           <% } %>
	           </li>
	        <% } %>
	    </ul>
	    <br/>
	    <h5> <img src="../../Content/Images/starred.png" alt="Starred element" /> Starred genres 20% Off! </h5>
	
	</asp:Content>
	````
 
#### Task 11 - Running the Application ####

In this task, you will test that the starred genres display a star icon.

1. Press **F5** to run the Application.

1. The project starts in the Home page. Change the URL to **/Store** to verify that each featured genre has the respecting label:

 	![Browsing Genres with starred elements](./images/Browsing-Genres-with-starred-elements.png?raw=true "Browsing Genres with starred elements")
 
	_Browsing Genres with starred elements_

 
### Next Step ###

Click here to enter text.
## Summary ##

By completing this Hands-On Lab you have learned the fundamentals of ASP.NET MVC:

- The core elements of an MVC application and how they interact

- How to create an ASP.NET MVC Application

- How to add and configure Controllers to handle parameters passed through the URL and querystring

- How to add a MasterPage to setup a template for common HTML content, a StyleSheet to enhance the look and feel and a View template to display HTML content

- How to use the ViewModel pattern for passing properties to the View template for them to display dynamic information

- How to use parameters passed to Controllers in the View template

- How to add links to pages inside the ASP.NET MVC application

- How to add and use dynamic properties in a View


