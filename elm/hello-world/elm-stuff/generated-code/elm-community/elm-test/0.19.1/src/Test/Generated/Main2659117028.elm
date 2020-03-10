module Test.Generated.Main2659117028 exposing (main)

import Tests

import Test.Reporter.Reporter exposing (Report(..))
import Console.Text exposing (UseColor(..))
import Test.Runner.Node
import Test

main : Test.Runner.Node.TestProgram
main =
    [     Test.describe "Tests" [Tests.tests] ]
        |> Test.concat
        |> Test.Runner.Node.run { runs = Nothing, report = (ConsoleReport UseColor), seed = 394339127950512, processes = 16, paths = ["C:\\Users\\Chris\\Exercism\\elm\\hello-world\\tests\\Tests.elm"]}