# Parsing Element Chat Export #

 Script to quickly find and organize code snippets.

[Element](https://element.io/) chats can be exported as JSON. This python script reads an exported JSON, filters for messages with a `{` character (assumed to indicate code), and exports the results with the sender's username.