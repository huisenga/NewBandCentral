<snippet>
  <content><![CDATA[
# ${1:Band Central}
Developed per WaMS Preparation and Initiative Assessment.
## Technical Details:
-ASP.NET MVC
-Entity Framework (Code-First)
-SQL Server
-Identity
-Automapper
-AutoFac (IoC/DI)

## Afterword
My initial attempt with this project was to impletement Identity for user authentication. While the prepackaged scafolding included makes initial implementaion easy, it has alot of overhead. If I created this project from scratch again, I would consider reverting back to forms auth.

Identiy uses prebuilt managers (namely ApplicationUserManager). This caused issues when used in concert with the services I created. User objects retreived through an applicationManager could not have a band added to them as they used different dbContexts.

This project also implements autoFac using the IoC pattern. This would allow for an easier implmentation mocking and Unit Tests in the future.

]]></content>
  <tabTrigger>readme</tabTrigger>
</snippet>