using System;
namespace  QueryApi.Domain
{
    
         public record Persona(int Id, string FirstName, string LastName, string Email, char Gender, string Job, int Age);
    
}