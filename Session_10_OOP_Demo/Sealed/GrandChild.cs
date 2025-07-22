namespace Session_10_OOP_Demo.Sealed
{
    // ana ha5ly el Class dah yb2a ==> Sealed
    // ya3ny mafe4 7ad y2dr y inherit mn el Class dah
    // we kdah Sealed Keyword with Class used to ==> prevent inheritance from this Class to another classes
    // lakn 3ady el GrandChild class yb2a inherit from any Class lakn ant other class cannot inherit from GrandChild class
    internal sealed class GrandChild : Child
    {

        // bas lama kont 2st5dm el Sealed dah by3ny 2n el method deh 25erha 3nd el child class
        // ya3ny el method hean m3aya ya3ny fe nafs el selsela el bta3t el overriding me4 25erha 
        // 3and el parent class l2 25erha hena 3and el class el 3amlt feh sealed el hwa Child Class
        // we bema 2en 3amlt Sealed 3l4an 23mn3 ay 7ad y override 3al el method deh
        // fa 3l4an kda el GrandChild class ma3rf4 y override 3al el method deh
        // 5las talma me4 hat2der te3ml override 3al el method deh fe el GrandChild class
        // 5las ro7 25feha 2w 2bd2a 23mlha selsela gdeda lwa7dha dah 2w dah hytm best5dam el ==> [new]
        // we kdah el MyFun method el fe el GrandChild class deh hateb2a fe selsela gdeda lwa7dha
        // me4 tab3 el child wla el parent classes 
        public new void MyFun()
        {
            Console.WriteLine("Hello i am a grand child");
        }

        // bas hast5dm el Sealed dah y3ny 2n el Property deh 25erha 3nd el child class
        // ya3ny el Property hean m3aya ya3ny fe nafs el selsela el bta3t el overriding me4 25erha 
        // 3and el parent class l2 25erha hena 3and el class el 3amlt feh sealed el hwa Child Class
        // we bema 2en 3amlt Sealed 3l4an 23mn3 ay 7ad y override 3al el Property deh
        // fa 3l4an kda el GrandChild class ma3rf4 y override 3al el Property deh
        // 5las talma me4 hat2der te3ml override 3al el Property deh fe el GrandChild class
        // 5las ro7 25feha 2w 2bd2a 23mlha selsela gdeda lwa7dha dah 2w dah hytm best5dam el ==> [new]
        // we kdah el Property Salary el fe el GrandChild class deh hateb2a fe selsela gdeda lwa7dha
        // me4 tab3 el child wla el parent classes 

        // we kdah 2st5dmt el Sealed 3l4an 23mn3 ay 7ad y override 3al el Property el 25erha fe Class Child
        public new int Salary 
        {
            get { return base.Salary; }
            set { base.Salary = value + 3000; }
        }
    }
}
