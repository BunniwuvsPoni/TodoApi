/*
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
 */
