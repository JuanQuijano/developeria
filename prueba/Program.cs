string permission = "Pepe";
int level = 70;

Console.WriteLine(permission.Contains("Admin") 
    ? level > 55 ? "Welcome, Super Admin": "Welcome, Admin user" 
    : "No tienes permisos suficientes");

Console.WriteLine((permission.Contains("Manager") & level > 20 )? "Contact an Admin for access.": "No tienes permisos suficientes");

