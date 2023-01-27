using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Force
{
  class Program
  {
    static void Main( string[] args )
    {
      Point2DClass p3 = new Point2DClass();
      p3.y = 10;
      p3.x = new int[1] { 10 };
      Point2DClass p4 = p3;
      Console.WriteLine( "Point2DClass" );
      Console.WriteLine( "BEFORE CHANGE" );
      Console.Write( "p3 : " ); Console.WriteLine( p3.value );
      Console.Write( "p4 : " ); Console.WriteLine( p4.value );
      p3.y = 2;
      p3.x = new int[1] { 2 };
      Console.WriteLine( "AFTER CHANGE" );
      Console.Write( "p3 : " ); Console.WriteLine( p3.value );
      Console.Write( "p4 : " ); Console.WriteLine( p4.value );

      Point2DStruct p1 = new Point2DStruct();
      p1.y = 12;
      p1.x = new int[1] { 12 };
      Point2DStruct p2 = p1;
      Console.WriteLine();
      Console.WriteLine( "Point2DStruct" );
      Console.WriteLine( "BEFORE CHANGE" );
      Console.Write( "p1 : " ); Console.WriteLine( p1.value );
      Console.Write( "p2 : " ); Console.WriteLine( p2.value );
      p1.y = 2;
      p1.x = new int[1] { 2 };
      Console.WriteLine( "AFTER CHANGE" );
      Console.Write( "p1 : " ); Console.WriteLine( p1.value );
      Console.Write( "p2 : " ); Console.WriteLine( p2.value );

      Console.ReadLine();
    }
  }
}
