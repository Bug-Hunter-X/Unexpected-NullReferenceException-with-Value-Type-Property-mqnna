public class MyClass
{
    public int? MyProperty { get; set; }

    public void MyMethod()
    {
        // Solution 1: Using the null-conditional operator
        int? value = MyProperty?.GetHashCode(); 

        //Solution 2: Check for null before accessing the member
        int value2 = 0; 
        if (MyProperty.HasValue)
        {
            value2 = MyProperty.Value.GetHashCode();
        }
    }
}