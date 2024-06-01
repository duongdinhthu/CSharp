using System;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;
// using newproject.view;
using session5;
namespace ProjectManagement{
    class Program{
        public static void Main(string[] args)
        {
        // View view = new View();
        // view.Test();
        Atom1 atom1 = new Atom1();
        atom1.Sesion();
        }
    }
}