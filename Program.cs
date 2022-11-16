namespace TestAppUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listaUsers = new List<User>();
            User tempUser = new User();

            int respuesta;
            int usuarioSeleccionado;
            bool dentroPrograma = true;
            
            do
            {
                Console.WriteLine("Hola, elige una opción:");
                Console.WriteLine("1. Ver a todos los usuarios");
                Console.WriteLine("2. Ver usuario");
                Console.WriteLine("3. Agregar usuario");
                Console.WriteLine("4. Buscar usuarios con disponibilidad");
                Console.WriteLine("5. Borrar usuario");
                Console.WriteLine("6. Salir");

                respuesta = int.Parse(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        List<User> tempListaUsers = listaUsers.OrderBy(x => x.Availability).Reverse().ToList();
                        
                        tempListaUsers.ForEach(delegate(User t)
                        {
                            Console.WriteLine(t.Username + " " + t.Password + " " + t.Availability);
                        });

                        break;

                    case 2:
                        Console.WriteLine("Dame el username del usuario a mostrar");
                        string varNombreUsuario = Console.ReadLine();

                        if (listaUsers.Exists(usuario => usuario.Username == varNombreUsuario))
                        {
                            User tempUser2 = listaUsers.Find(usuario => usuario.Username == varNombreUsuario);
                            Console.WriteLine(tempUser2.Username + " " + tempUser2.Password + " " + tempUser2.Availability);
                        }
                        else
                            Console.WriteLine("El usuario no existe");
                        
                        break;

                    case 3:
                        Console.WriteLine("Dame un username");
                        tempUser.Username = Console.ReadLine();
                    
                        Console.WriteLine("Dame un password");
                        tempUser.Password = Console.ReadLine();
                    
                        Console.WriteLine("Dame una disponibilidad");
                        tempUser.Availability = Convert.ToInt16(Console.ReadLine());

                        listaUsers.Add(new User(tempUser.Username, tempUser.Password, tempUser.Availability));
                        break;
                    
                    case 4:
                        List<User> tempListaUsers2 = listaUsers.Where(x => x.Availability > 50).ToList();

                        tempListaUsers2.ForEach(delegate(User t)
                        {
                            Console.WriteLine(t.Username + " " + t.Password + " " + t.Availability);
                        });
                    
                        break;

                    case 5:
                        Console.WriteLine("Dame el username del usuario a borrar");
                        string varNombreUsuarioBorrar = Console.ReadLine();

                        if (listaUsers.Exists(usuario => usuario.Username == varNombreUsuarioBorrar))
                        {
                            User tempUser2 = listaUsers.Find(usuario => usuario.Username == varNombreUsuarioBorrar);
                            listaUsers.Remove(tempUser2);
                            Console.WriteLine("Usuario borrado correctamente");
                        }
                        else
                            Console.WriteLine("El usuario no existe");

                        break;

                    case 6:
                        dentroPrograma = false;
                        break;
                }
            }
            while(dentroPrograma);

            Console.WriteLine("Adios");
        }
    }
}