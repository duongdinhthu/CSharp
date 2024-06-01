using System;
using System.Collections.Generic;
namespace session5;
class Atom1
{
    public void Sesion()
    {
        List<Atom> atoms = new List<Atom>();
        int maxAtoms = 10;

        for (int i = 0; i < maxAtoms; i++)
        {
            Atom atom = new Atom();
            if (!atom.Accept())
            {
                Console.WriteLine("No more valid inputs accepted.");
                break;
            }
            atoms.Add(atom);
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("No Sym Name Weight");
        Console.WriteLine("-----------------------------------");

        foreach (Atom atom in atoms)
        {
            atom.Display();
        }
    }
}
