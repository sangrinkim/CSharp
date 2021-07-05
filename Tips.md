* How to make .NET application to run as Administartor on Visual studio 2019:

        1. Solution Explorer > Target Project > Right click > Add > New Item (Hot Key: Ctrl + Shift + A)
        2. Select "Application Manifest File (Windows Only) > Click "Add" Button
        3. Change UAC Manifest Options as follows:

``` xml
        <!--<requestedExecutionLevel level="asInvoker" uiAccess="false" />-->
        <requestedExecutionLevel  level="requireAdministrator" uiAccess="false" />
```