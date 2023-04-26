# Git-to-Azure

1. We begin by importing the necessary namespaces to use the ASP.NET Core framework.
2. We define a static Main method which creates a new IHostBuilder object using the CreateDefaultBuilder method and passes in the command-line arguments.
3. The IHostBuilder object is then configured to use the WebHost defaults and a Configure method is called with an app parameter. This method configures the application's request pipeline.
4. We then call UseRouting to enable routing middleware and MapGet to handle incoming GET requests to the root URL ("/").
5. Inside the MapGet method, we define an asynchronous lambda function that takes in an HttpContext object and writes a simple HTML message to the response.
6. Finally, we call Run on the IHostBuilder to start the application and listen for incoming requests.