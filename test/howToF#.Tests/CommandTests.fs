module Test

open System
open Xunit
open FsUnit.Xunit
open howTo.Models


type CommandTests() =
    let mutable testCommand = null
    do testCommand <- Commands(HowTo = "Do something awesome", Platform = "xUnit", CommandLine = "dotnet test")

    [<Fact>]
    member __.``Can Change HowTo``() =
        //Act
        testCommand.HowTo <- "Execute Unit Tests"
        // Assert
        testCommand.HowTo
        |> should equal "Execute Unit Tests"

    [<Fact>]
    member __.``Can change platform``() =
        testCommand.Platform <- "xUnit"

        testCommand.Platform |> should equal "xUnit"

    interface IDisposable with
        member this.Dispose() = testCommand <- null
