# Instructions

* [Prepare](#Prepare)
* [Clone](#Clone)
* [Develop](#Develop)
* [Push](#Push)
* [Submit](#Submit)

## Prepare

* Tooling
  * Visual Studio 2022
  * SQL Server Data Tools (SSDT) for Visual Studio 2022.
  * SQL Server 2019 LocalDB

## Clone

Clone this repository (do not fork it) and push it to your own repository.

> Note: You may use any service you prefer, not just GitHub.

<details>
    <summary>Expand for detailed instructions</summary>

Clone the repository.

```bash
git clone https://github.com/UWIT-IAM/iam-candidate-astra
```

Change the remote of your URL.

```bash
git remote set-url origin <url-of-your-repository>
```

Push to your repository.

```bash
git push
```

If you initialized the repository with files, add the `--force` option to the `push` command to overwrite them.

</details>


## Develop

1. Review the project in the [legacy](legacy) folder.
    > If you get a runtime error about being unable to access ...\bin\roslyn\csc.exe, right-click the solution and select "Restore NuGet Packages".  The first restore operation doesn't always copy the files to bin\roslyn.
    * Determine the scope of functionality.
    * Use the included **IAMCandidateTest.Database** project as a reference for the schema of the included database.
2. Create a new ASP.NET Core 6 MVC application in the [modern](modern) folder.
    * Recreate all functionality from the legacy application.
      * You do not need to recreate the same user interface.  Take liberties if you want.
    * Use modern techniques and newer language features where appropriate.
    * Architect the new application as you see fit.
    * Avoid repeating anti-patterns or reintroducing old technical debt.
      * *Note:* These have been introduced for the purposes of this test.
3. *(Optional)* Write any [final notes](FINAL_NOTES.md) you may have.  Suggested topics (not an exhaustive list):
    * Anything you might have done differently if you were to spend more time on it.
    * Techniques used, especially those used with Web Forms that are not relevent to ASP.NET Core.
    * Libraries used, particularly alternatives or substitutions due to framework differences.
    * Any arbitrary decisions you made and why you made them.
    * Challenges you faced and how you approached the solution.

## Push

Push your changes to GitHub (or whichever site you've chosen to use).  Verify that the repository is publicly visible.

## Submit

Send the URL to your repository to your recruiter.
