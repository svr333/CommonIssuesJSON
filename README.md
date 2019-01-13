# CommonIssuesJSON

[![Build status](https://img.shields.io/appveyor/ci/joelp53/commonissuesjson.svg?style=for-the-badge&logo=appveyor)](https://ci.appveyor.com/project/joelp53/commonissuesjson)

**NOTE: This is not intended to be used by anyone else except the guys from the Discord-BOT-Tutorial Discord Server**

## To Install

#### Using DotNet CLI

```bash
dotnet add package CommonIssues.JsonParser --version 1.0.3 
```

#### Using Package Manager

```bash
Install-Package CommonIssues.JsonParser -Version 1.0.3
```


## To Use In Bot

```cs
//Create a new CommonIssuesClient
var commonIssuesClient = new CommonIssuesClient();

//Get the current List of Common Issues
var issues = await commonIssuesClient.GetCommonIssuesAsync();

//Search for a specific issue (Is not case sensitive)
var search = await commonIssuesClient.SearchCommonIssuesAsync("SEARCH HERE");
```

---

## Issues

Create a new issue and i'll see if I can fix it.

## Contributing

If you want to contribute, make a fork and PR any changes you think it may need. Ensure you gice as much info as possible for the PR you're making.

---

## Author

Draxis - Initial Work

## License

Info can be found [HERE](LICENSE)
