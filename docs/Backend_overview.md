# Frontend

_Last updated: 09.01.23_

## Table of Contents

- [Frontend](#frontend)
  - [Table of Contents](#table-of-contents)
  - [Version](#version)
  - [Project Organization](#project-organization)
  - [Component Definition](#component-definition)
  - [Styleguide](#styleguide)

## Version

1.0

## Project Organization

The following tree structure gives a basic overview of the FizzBuzz program.

<pre>
📦src
 ┣ 📂components # The components made for the app
 ┣ 📂CustomHooks # The custom made React hooks
 ┣ 📂lib # Contains mock files and text data for translation
 ┣ 📂pages # The pages that can be viewed by users (admin page requires authentication)
 ┣ 📂sass # All mixins and variables to be used for consistent styling
 ┣ 📂services # Service files (for API communication, admin authentication etc.)
 ┃ ┣ 📂ApiManager # Defines how the frontend should communicate with the API to get data
 ┣ 📂utils # Contains utility functions
 ... etc.
</pre>
<br/>
