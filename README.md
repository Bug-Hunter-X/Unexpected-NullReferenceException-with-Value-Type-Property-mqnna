# Unexpected NullReferenceException with Value Type Property in C#

This repository demonstrates a scenario where a `NullReferenceException` can occur when working with a value type property in C#, even though value types are not typically nullable.

The bug arises because the value type is declared as nullable, making it possible for it to hold a null value. Accessing a member of such a nullable value type, without first checking for null, results in the exception.

The solution shows how to safely handle this by using the null-conditional operator or checking for null explicitly before accessing the property.