namespace Session_10_OOP_Demo.Sealed
{
    internal class Child : Parent
    {

        // 3ayez 25ly el method deh 25r tawres leha yb2a hena fe el child class
        // ya3ny el GrandChild class el mafrod my3rf4 y override 3al el method deh
        // fa 3l4an 23ml kdah we 2mn3 ay 7ad y override 3al el method deh
        // haro7 2st5dm el Modifier or Keyword "sealed" 3l4an 23mn3 ay 7ad y override 3al el method deh
        // tb ma kdah el Sealed kasrt el selsela bta3t el overriding bta3 el method deh

        // eh el far2 b2a ben el [Sealed] we el [new]??
        // el far2 2n el new lama komt ba3mlha ma3 el override dah by5aly 25er el selsela 3and el 2bly
        // ya3ny kdah el method deh 3nd el Parent class dah 25erha law kont 2st5dmt el new hena
        // we kdah habd2 selsela gdeda men 3and el child class
        // bas lama kont 2st5dm el Sealed dah by3ny 2n el method deh 25erha 3nd el child class
        // ya3ny el method hean m3aya ya3ny fe nafs el selsela el bta3t el overriding me4 25erha 
        // 3and el parent class l2 25erha hena 3and el class el 3amlt feh sealed el hwa Child Class
        // we bema 2en 3amlt Sealed 3l4an 23mn3 ay 7ad y override 3al el method deh
        // fa 3l4an kda el GrandChild class ma3rf4 y override 3al el method deh
        // 5las talma me4 hat2der te3ml override 3al el method deh fe el GrandChild class
        // 5las ro7 25feha 2w 2bd2a 23mlha selsela gdeda lwa7dha dah 2w dah hytm best5dam el ==> [new]
        // we kdah el MyFun method el fe el GrandChild class deh hateb2a fe selsela gdeda lwa7dha
        // me4 tab3 el child wla el parent classes 

        // we kdah 2st5dmt el Sealed 3l4an 23mn3 ay 7ad y override 3al el method 

        public sealed override void MyFun() //Sealed Keyword with method used to ==> prevent override on method in derives class
        {
            Console.WriteLine("Hello i am a child");
        }

        // el Salary property is inherited from Parent class
        // we 3l4an te2dr tet3aml ma3 el salary el attribute el fe el Parent class el hwa private 
        // fa hwa ra7 yt3aml ma3 el Property el Salary el fe el Parent class
        // we 3l4an 2n el Salary property fe el Parent class deh virtual
        // fa 3l4an kdah 2dert 23ml override 3al el Salary property fe el Child class
        // we lazem 23ml ==> base.Salary 3l4an 2der a3ml access lel Salary property el fe el Parent class
        // law 4elt el base kdah bat3aml ma3 el Salary property el fe el child class bta3y 
        // we kdah hand5ol fe infinite loop me4 han3rf no5rg menha 

        // bas hast5dm el Sealed dah y3ny 2n el Property deh 25erha 3nd el child class
        // ya3ny el Property hean m3aya ya3ny fe nafs el selsela el bta3t el overriding me4 25erha 
        // 3and el parent class l2 25erha hena 3and el class el 3amlt feh sealed el hwa Child Class
        // we bema 2en 3amlt Sealed 3l4an 23mn3 ay 7ad y override 3al el Property deh
        // fa 3l4an kda el GrandChild class ma3rf4 y override 3al el Property deh
        // 5las talma me4 hat2der te3ml override 3al el Property deh fe el GrandChild class
        // 5las ro7 25feha 2w 2bd2a 23mlha selsela gdeda lwa7dha dah 2w dah hytm best5dam el ==> [new]
        // we kdah el Property Salary el fe el GrandChild class deh hateb2a fe selsela gdeda lwa7dha
        // me4 tab3 el child wla el parent classes 

        // we kdah 2st5dmt el Sealed 3l4an 23mn3 ay 7ad y override 3al el Property 
        public sealed override int Salary //Sealed Keyword with Property used to ==> prevent override on Property in derives class
        { 
            get { return base.Salary;}
            set { base.Salary = value + 2000; }
        }
    }
  
}
