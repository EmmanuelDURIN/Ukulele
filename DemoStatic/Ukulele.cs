using System;

namespace DemoStatic
{
  class Ukulele
  {
    // bariton, ténor, ...
    public UkuleleSize Size { get; set; }
    public double Stress { get; set; }
    /// <summary>
    /// </summary>
    /// <returns>frequency</returns>
    public double Play(double impulse)
    {
      switch (Size)
      {
        case UkuleleSize.Tenor:
          return Stress * 5000 * impulse;
        case UkuleleSize.Bariton:
          return Stress * 1000 * impulse;
        case UkuleleSize.Soprano:
          return Stress * 2000 * impulse;
        case UkuleleSize.Concert:
          return Stress * 500 * impulse;
      }
      return 0;
    }

    // static n'est pas lié à une instance
    static void Main(string[] args)
    {
      // L'enum permet de déclarer des variables
      //en prenant des valeurs dans un ensemble fini
      //UkuleleSize size = UkuleleSize.Soprano; 

      // Pas bien car on n'a pas d'instance (pas d'objet)
      // les membres de la classe ne sont accessibles car ils sont
      // liés à une instance et dans le Main (static), il n'y a pas d'instance,
      // pas de this implicite
      //Size = UkuleleSize.Bariton;
      //Console.WriteLine(Size);
      //Play();

      Ukulele ukulele1 = new Ukulele();
      ukulele1.Size = UkuleleSize.Tenor;
      Console.WriteLine(ukulele1.Size);
      ukulele1.Play(100);

      Ukulele ukulele2 = new Ukulele();
      ukulele2.Size = UkuleleSize.Soprano;
      Console.WriteLine(ukulele2.Size);
      ukulele2.Play(1000);

      // fonction pure (fonction pas objet)
      // les méthodes statiques s'appellent sur la classe
      double x = Math.Abs(-3);
      double y = Math.Abs(-3);
      double z = Math.Abs(8);

      // si Abs n'était pas statique :
      Math2 m2 = new Math2();
      // les méthodes d'instance s'appellent sur d'objet
      double x1 = m2.Abs(-3);
      double y1 = m2.Abs(-3);
      double z1 = m2.Abs(8);

      Console.WriteLine("Hello World!");
    }
    // Quand utiliser static ?
    // 1) Fonctions
    //   a) Main statique car lorsqu'il appelé, il n'y a pas d'objet
    //   b) pour toutes les fonctions qui ne dépendent pas de l'état d'un objet
    //    Math.Cos DateTime.Now DateTime.Today
    // 2) Données (champs)
    //    a) les const (implicitement statiques)
    //    b) les variables globales ou partagées
  }
}
