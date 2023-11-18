﻿module App

open System
open Elmish
open Elmish.Avalonia

type Model =  
    { 
        View: View
    }

and View = 
    | CounterView
    | ChartView
    | AboutView
    | FilePickerView

type Msg = 
    | SetView of View
    | GoHome

let init () = 
    { 
        View = CounterView
    }

let update (msg: Msg) (model: Model) = 
    match msg with
    | SetView view -> { View = view }   
    | GoHome -> { View = CounterView }


let app = 
    Program.mkAvaloniaSimple init update
    |> Program.withErrorHandler (fun (_, ex) -> printfn $"Error: {ex.Message}")
    //|> Program.withConsoleTrace
    |> Program.mkStore
