* [Model-View-ViewModel(MVVM)](https://docs.microsoft.com/en-us/windows/uwp/data-binding/data-binding-and-mvvm): Model-View-ViewModel (MVVM) is a UI architectural design pattern.
  - Benefits of MVVM
    - Enabling an iterative, exploratory coding style. Change that is isolated is less risky and easier to experiment with.
    - Simplifying unit testing. Code units that are isolated from one another can be tested individually and outside of production environments.
    - Supporting team collaboration. Decoupled code that adheres to well-designed interfaces can be developed by separate individuals or teams, and integrated later.
    - Improving maintainability. Fixing bugs in decoupled code is less likely to cause regressions in other code.
  - App Layers
    - Model: The model layer defines the types that represent your business data.
    - View: The view layer defines the UI using XAML markup.
    - View-Model: The view-model layer provides data binding targets for the view.

* How to make .NET application to run as Administartor on Visual studio 2019:

        1. Solution Explorer > Target Project > Right click > Add > New Item (Hot Key: Ctrl + Shift + A)
        2. Select "Application Manifest File (Windows Only) > Click "Add" Button
        3. Change UAC Manifest Options as follows:

``` xml
        <!--<requestedExecutionLevel level="asInvoker" uiAccess="false" />-->
        <requestedExecutionLevel  level="requireAdministrator" uiAccess="false" />
```