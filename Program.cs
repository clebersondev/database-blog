using System.Data.SqlClient;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

var connection = new SqlConnection(CONNECTION_STRING);

connection.Open();

ReadUsersWithRoles(connection);
//ReadUsers(connection);
// ReadRoles(connection);
// ReadTags(connection);
// ReadUser();
// CreateUser();
// UpdateUser();
// DeleteUser();

connection.Close();

static void ReadUsers(SqlConnection connection)
{
    var repository = new Repository<User>(connection);
    var items = repository.Get();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
        foreach (var role in item.Roles)
        {
            Console.WriteLine($" - {role.Name}");
        }
    }
}

static void ReadRoles(SqlConnection connection)
{
    var repository = new Repository<Role>(connection);
    var items = repository.Get();

    foreach (var item in items)
        Console.WriteLine(item.Name);
}

static void ReadUsersWithRoles(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var items = repository.GetWithRoles();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
        foreach (var role in item.Roles)
        {
            Console.WriteLine($" - {role.Name}");
        }
    }
}

static void ReadTags(SqlConnection connection)
{
    var repository = new Repository<Tag>(connection);
    var items = repository.Get();

    foreach (var item in items)
        Console.WriteLine(item.Name);
}

// static void ReadUser()
// {
//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         var user = connection.Get<User>(1);
//         Console.WriteLine(user.Name);
//     }
// }

// static void CreateUser()
// {
//     var user = new User()
//     {
//         Name = "Equipe Balta",
//         Email = "equipebalta-io@balta.io",
//         PasswordHash = "HASH",
//         Bio = "Equipe Balta.io",
//         Image = "https://...",
//         Slug = "equipe-balta"
//     };
//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         connection.Insert(user);
//         Console.WriteLine("Usuario adicionado com sucesso");
//     }
// }

// static void UpdateUser()
// {
//     var user = new User()
//     {
//         Id = 2,
//         Name = "Equipe | Balta",
//         Email = "equipebalta-io@balta.io",
//         PasswordHash = "HASH",
//         Bio = "Equipe | Balta.io",
//         Image = "https://...",
//         Slug = "equipe-balta"
//     };
//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         connection.Update(user);
//         Console.WriteLine("Usuario atualizado com sucesso");
//     }
// }

// static void DeleteUser()
// {
//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         var user = connection.Get<User>(2);

//         connection.Delete(user);
//         Console.WriteLine("Usuario removido com sucesso");
//     }
// }