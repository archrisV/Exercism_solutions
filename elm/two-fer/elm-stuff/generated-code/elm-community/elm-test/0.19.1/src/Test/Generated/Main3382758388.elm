module Test.Generated.Main3382758388 exposing (main)

import Tests

import Test.Reporter.Reporter exposing (Report(..))
import Console.Text exposing (UseColor(..))
import Test.Runner.Node
import Test

main : Test.Runner.Node.TestProgram
main =
    [     Test.describe "Tests" [Tests.tests] ]
        |> Test.concat
        |> Test.Runner.Node.run { runs = Nothing, report = (ConsoleReport UseColor), seed = 99034305538162, processes = 16, paths = ["C:\\Users\\Chris\\Exercism\\elm\\two-fer\\tests\\Tests.elm"]}