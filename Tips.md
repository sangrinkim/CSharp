* [Get started with unit testing](https://docs.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?view=vs-2019&tabs=xunit)

        1. (In .Net Framework case)Add a new project > Unit Test Project (.NET Framework)
        2. Add References > Select the project that contains the code you'll test
        3. Make test code as follows:
``` C#
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorldCore.Program.Main(null);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
```
        4. Test > Test Explorer(Hot Key: Ctrl + E, T)
        5. Run All Tests(or Run), Also can use Debug


* How to make .NET application to run as Administartor on Visual studio 2019:

        1. Solution Explorer > Target Project > Right click > Add > New Item (Hot Key: Ctrl + Shift + A)
        2. Select "Application Manifest File (Windows Only) > Click "Add" Button
        3. Change UAC Manifest Options as follows:

``` xml
        <!--<requestedExecutionLevel level="asInvoker" uiAccess="false" />-->
        <requestedExecutionLevel  level="requireAdministrator" uiAccess="false" />
```