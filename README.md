# Puzzle #81: Dashboard Dilemma

Help Carl and Jeff create a dashboard where components can be added and removed at will.

YouTube Video: https://youtu.be/qNy24pd5nvc

Blazor Puzzle Home Page: https://blazorpuzzle.com

## The Challenge

In this puzzle, we explore the dynamic management of Blazor components loaded from a Razor Class Library. You'll need to implement a solution that allows components to be dynamically added, removed, and managed on a dashboard-style page.

### Setup

The solution consists of three projects:

- A Blazor Web App (`Puzzle81`)
- A Razor Class Library (`MyComponents`) containing various dashboard components:
  - KPI Summary
  - Sales Chart
  - Team Activity
- A Shared Library defining common interfaces

### Requirements

1. Create a dashboard page that can dynamically load components from the `MyComponents` library
2. Implement the ability to add and remove components at runtime
3. The solution should maintain component state when adding/removing components

### Tips

- Look into Blazor's `DynamicComponent` feature
- Consider using a component registry pattern
- Think about component state persistence

Join Carl and Jeff as they explore different approaches to solving this Blazor puzzle!
