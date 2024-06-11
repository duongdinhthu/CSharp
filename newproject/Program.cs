using System;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;
// using newproject.view;
using newproject.mvc.view;
// using newproject.mvcExample.view;
using session5;
// using newproject.mvcExample.view;
namespace newproject{
    class Program{
        public static void Main(string[] args)
        {
        // View view = new View();
        // view.Test();
        // Atom1 atom1 = new Atom1();
        // atom1.Sesion();
        // View view = new View();
        // view.Start();
        View view = new View();
        view.UpdateCustomer();
        }
    }
}