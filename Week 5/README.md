# Databases I guess? #

## How to talk to your database friends ##

1. Connection
   * Which DB are you trying to reach?
1. Command
   * What would you like to do?
1. Execution
   * Actually do the command and provide a place to return data.

## C# is back ##

Not just arrays in C#!

`string[] names = new string[3];`

C# has the `List<T> Class` (System.Collections.Generic)

## Data Normalization ##

Handling horizontal and vertical Repetition

Organize the data into fields in your tables!

Unnormalized form, first normalized form, second normalized form...

UNF, 1NF, 2NF, 3NF are usually as much detail as we need.

Is our table full of repetition? How can we address that?

### Data Integrity ###

Less repeated data, fewer typos, correct it once, make sure it's always "Philadelphia" not "Philly"

Capture the relationships between the data

## Basic SQL Syntax ##

`SELECT <column_names> FROM <table_name> WHERE <condition>;`

`INSERT INTO <table_name> (<col_1>, <col_2>) VALUES (<val_1>, <val_2>);`

## C# Execute SQL ##

```csharp
string insertStmt = "INSERT INTO phone_tbl (phone_number) VALUES ('123-456-7890')"
```

## SQL UPDATE ##

`UPDATE` can obliterate every row in a column

`UPDATE Addresses SET Name = 'Now the Name column is dead';`

Never run code against production. Always test it in development first. Then test QA. No 'typing' code immediately against production! TEST IT!

## SQL Injection Attacks ##

![Exploits of a Mom](https://imgs.xkcd.com/comics/exploits_of_a_mom.png)

Keep up with the latest trends in web security and best practices using [OWASP](https://owasp.org)
