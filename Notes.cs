/*
 * Using tutorial: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio
 * 
 * Test PostTodoItem with Postman
Create a new request.

Set the HTTP method to POST.

Set the URI to https://localhost:<port>/api/TodoItems. For example, https://localhost:5001/api/TodoItems.

Select the Body tab.

Select the raw radio button.

Set the type to JSON (application/json).

In the request body enter JSON for a to-do item:

JSON

Copy
{
  "name":"walk dog",
  "isComplete":true
}
Select Send.
 * 
 * To test in Postman:

Select the Headers tab in the Response pane.

Copy the Location header value:

Headers tab of the Postman console

Set the HTTP method to GET.

Set the URI to https://localhost:<port>/api/TodoItems/1. For example, https://localhost:5001/api/TodoItems/1.

Select Send.
 *
 *Test Get with Postman
Create a new request.
Set the HTTP method to GET.
Set the request URI to https://localhost:<port>/api/TodoItems. For example, https://localhost:5001/api/TodoItems.
Set Two pane view in Postman.
Select Send.
This app uses an in-memory database. If the app is stopped and started, the preceding GET request will not return any data. If no data is returned, POST data to the app.
 *
 *Test the PutTodoItem method
This sample uses an in-memory database that must be initialized each time the app is started. There must be an item in the database before you make a PUT call. Call GET to ensure there's an item in the database before making a PUT call.

Update the to-do item that has Id = 1 and set its name to "feed fish":

JSON

Copy
  {
    "Id":1,
    "name":"feed fish",
    "isComplete":true
  }
 *
 *Test the DeleteTodoItem method
Use Postman to delete a to-do item:

Set the method to DELETE.
Set the URI of the object to delete (for example https://localhost:5001/api/TodoItems/1).
Select Send.
 *
 *11/26/2020 - Stopped at Call the web API with JavaScript, continue here...
 *
 */
