module Test.Generated.Main4109787338 exposing (main)

import Tests

import Test.Reporter.Reporter exposing (Report(..))
import Console.Text exposing (UseColor(..))
import Test.Runner.Node
import Test

main : Test.Runner.Node.TestProgram
main =
    [     Test.describe "Tests" [Tests.tests] ]
        |> Test.concat
        |> Test.Runner.Node.run { runs = Nothing, report = (ConsoleReport UseColor), seed = 39743425857796, processes = 16, paths = ["C:\\Users\\Chris\\Exercism\\elm\\hello-world\\tests\\Tests.elm"]}