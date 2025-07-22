namespace Session_10_OOP_Demo.Static
{
    // if we make this Class to be Static Class
    // should all memebers be Static
    // and Static Class ==> Implicitly : Sealed ==> that mean not any class can inherit from it
    // and static Class ==> Can not inherit from any Class ==> me4 bywors mn 7ad
    // ya3ny el Static Class ==> wla bywres wla bywars
    // el Static Class by inherit only From Object but can not make any Override 
    internal class Utility
    {
        public Utility(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // This is a Static Constructor
        // not have access modifier and by default is Private
        // It will be called only once when the class is first used
        // It is used to initialize static members or perform any setup required for the class
        // CLR will deal with him and call it once in lifetime of app or program
        static Utility()
        {
            // ta3l hantb3 gomla 3l4an te4of 2noh hy4ta8l mogard ma ha create ly instance mn el class dah
            // fe el Program.cs
            Console.WriteLine("Hello From Static Constructor");

            // han3rf el Static Readonly Constructor el ma3rftho4 3al nafs el line 
            pi6 = 3.14;
        }

        public int x { get; set; }
        public int y { get; set; }

        //// hanlaez fe el Program.cs 2n kol ma ba8er el X 2w el Y dah me4 by2sr fe 7aga
        //// 3al el method el hya ==> ConverMetersToCm 
        //// maham 8ayert fehom dah me4 by2r 3al el method fe 7aga
        //// el method deta5od el vlaue mn el user we te7welha ly Cm malha4 3elak bel X wla el Y 
        //// ya3ny mn el 25er ==>
        //// when you change the object or instance or object state ==> Method will return the same Value
        //// 7ata law 3amlt reference gded mn nafs el instance bardo dah me4 hy2sr 3al el method fe 7aga
        //// we hatefdl te3tmed bs 3al el value el bet5oha mn el user we mlha4 3elak b2a
        //// be ta8er el reference 2w ta8er el X and el Y

        //// then when Method don't depend on Object State like X and Y and don't depend of Instance
        //// when try to change reference 
        //// then make this method ==> [Static Method]
        //// me4 me7taga 2nadeky mn 5elal object 2w instance 
        //// and when make it [Static]
        //// then you can call it directly by class name
        //// then you can call it like this in Program.cs ==> Utility.ConvertMetersToCm(2.5);
        //// then you can call it without creating any instance or object
        //// we el Static Method leha 2sm we hwa ==> [Class Member Method]
        //// we el Non Static Method leha 2sm we hwa ==> [Instance or Object Member Method]

        public static double ConvertMetersToCm(double meters)
        {
            return meters * 100;
        }

        //// hanlaez fe el Program.cs 2n kol ma ba8er el X 2w el Y dah me4 by2sr fe 7aga
        //// 3al el method el hya ==> CalculateCircleArea 
        //// maham 8ayert fehom dah me4 by2r 3al el method fe 7aga
        //// el method deta5od el vlaue mn el user we te7welha ly Cm malha4 3elak bel X wla el Y 
        //// ya3ny mn el 25er ==>
        //// when you change the object or instance or object state ==> Method will return the same Value
        //// 7ata law 3amlt reference gded mn nafs el instance bardo dah me4 hy2sr 3al el method fe 7aga
        //// we hatefdl te3tmed bs 3al el value el bet5oha mn el user we mlha4 3elak b2a
        //// be ta8er el reference 2w ta8er el X and el Y

        //// then when Method don't depend on Object State like X and Y and don't depend of Instance
        //// when try to change reference 
        //// then make this method ==> [Static Method]
        //// me4 me7taga 2nadeky mn 5elal object 2w instance 
        //// and when make it [Static]
        //// then you can call it directly by class name
        //// then you can call it like this in Program.cs ==> Utility.CalculateCircleArea(2.5);
        //// then you can call it without creating any instance or object
        //// we el Static Method leha 2sm we hwa ==> [Class Member Method]
        //// we el Non Static Method leha 2sm we hwa ==> [Instance or Object Member Method]

        //// 2bl ma 2def el static fa el method deh kanet 2smha ==> [Instance or Object Member Method]
        //// l2nha non-static Method
        //// 2bl ma 2def el static kan lazm 23ml instance mn el class 3l4an a22dr 2a call el method deh
        //// lakn ba3d ma 2def el static me4 lazem 23ml instance mn el class 3l4an a22dr 2a call el method deh
        //// ana mogard bs ha call el method mn el class name directlly




        /********************** Related to PI to Make it Constanct or Readonly *************************/



        //// 3ayzen nesabt el PI deh badl ma kol 4waya law 27tgnaha nro7 nektb 3.14
        //// l2 3ayzen nesbtha fe Attribute we nest5dhma 3altol fe ay w2t 
        //// fa law ro7t 3amlt kdah ==> private double pi = 3.14;
        //// we get 7atet el [pi] deh ta7t fe el return mkan el 3.14
        //// hydrb erro tb Leh ???
        //// l2n el private double pi = 3.14; dah hwa ==> [Object or instance member attribute]
        //// we el [Object or instance member attribute] dah hwa ==> Non-Static member attribute
        //// ya3ny kdah me7tag 2a create instance or object 3l4an 2wsl ll Pi
        //// we l2n el method el ana feha deh el hya CalculateCircleArea deh ==> Static Method
        //// we el Static method el hya ==> [Class Member Method]
        //// ya3ny me4 me7tag 2a create instance or object 3l4an 2wsl ll method l2 hwslaha direct mn el Class name
        //// fa 3l4an kdah lazem kol el gwaha swa2 method tanya 2w attribute 2w Properties
        //// lazem ykona ==> [Static]
        //// ma3na kdah 
        //// law el Method Static ==> Yb2a kol el Gwaha yb2a Static muynfa34 yb2a fe 7aga Non-Static
        //// law el Method Non-Static ==> Yb2a kol el Gwaha yb2a Non-Static muynfa34 yb2a fe 7aga Static
        //// fa 3l4an ne7l el Mo4kela deh han5ly el Atrribute el hwa [pi] dah ykon ==>[Static]
        //// ya3ny yb2a kdah ==> private static double pi = 3.14;
        //// we kdah law get 7atet el [pi] deh ta7t fe el return mkan el 3.14 hyb2a tmam we me4 hydrb error
        //// l2n kdah 7atet Static Attribute gwa Static Method

        private double pi1 = 3.14; //==>[Object or instance member attribute] el hwa ==> Non-Static Attribute
                                   //==> Mean to Access it should make instance or object 

        private static double pi2 = 3.14; //==>[Class member attribute] el hwa ==> Static Attribute
                                          //==> Mean to Access it should use Class name only
                                          // don't need to make instance or object



        //// tb 3ayzen ne3ml el [pi] deh teb2a Property 3l4an a2dr 2a set we get fe el property deh 
        //// 2sl tol ma hya attribute zay el fo2 kdah we get henak fe el Progam.cs
        //// 7awlt 23mlha access bel class name kdah ==> Utility.pi2;
        //// me4 ha3rf l2n el [pi2] deh hya [Private] we kamn me4 ha3rf 28er el Vlaue bet3tha 
        //// me4 ha2dr 23ml kdah ==> Utility.pi2 = 3.65; ==> inavlid becuase it's Private and attribute
        //// attribute l2n 7atet feha kema sabt hena el hea 3.14
        //// 5las hanro7 ne3mlha Property han3mlha kdah ==> public double pi3 { get; set; }
        //// we ha4of lesa ha3ml eh gwa el get we el set
        //// a2olk ta3la ne3mlha ==> Full Property 2shal
        //// kdah ==> private double pi3; ==> p is small
        //// then ==> public double Pi3 { get { return pi3 ; } set { pi3 = value; } } ==> P is Capital outside and is small inside
        //// we kdah ay 7ad mn bara y2dr y access el Pi3 we y7ot feh el Vlaue el hwa 3ayezha
        //// 7at law 2detha value hena fe el 2wl ka default vlaue kdah ==> private double pi3 = 3.14;
        //// 3ady mogard ma 7ad y accessha mn bara men 5ele 2noh y3ml instance mn el Class dah 
        //// we y access el Pi3 y2dr y7ot el value el hwa 3ayezha we 2oln y3ml instance
        //// l2n el Property deh hya Non-Static ya3ny [Object or instance member Property]
        //// Mean to Access it should make instance or object
        //// fa law get 7atet el [Pi3 ==> P is Capital] deh ta7t fe el return mkan el 3.14
        //// hydrb erro tb Leh ???
        //// l2n el public double Pi3 2w private double pi3 = 3.14; dah hwa ==> [Object or instance member attribute]
        //// we el [Object or instance member attribute] dah hwa ==> Non-Static member attribute
        //// ya3ny kdah me7tag 2a create instance or object 3l4an 2wsl ll Pi3
        //// we l2n el method el ana feha deh el hya CalculateCircleArea deh ==> Static Method
        //// we el Static method el hya ==> [Class Member Method]
        //// ya3ny me4 me7tag 2a create instance or object 3l4an 2wsl ll method l2 hwslaha direct mn el Class name
        //// fa 3l4an kdah lazem kol el gwaha swa2 method tanya 2w attribute 2w Properties
        //// lazem ykona ==> [Static]
        //// ma3na kdah 
        //// law el Method Static ==> Yb2a kol el Gwaha yb2a Static muynfa34 yb2a fe 7aga Non-Static
        //// law el Method Non-Static ==> Yb2a kol el Gwaha yb2a Non-Static muynfa34 yb2a fe 7aga Static
        //// fa 3l4an ne7l el Mo4kela deh han5ly el Property el hwa [pi3] dah ykon ==>[Static]
        //// we kman han5ly el public double Pi3 ==> yb2a Static bardo
        //// l2n mynfa34 2ny 25ly deh ==> private static double pi3 = 3.14; ==> teb2a Static
        //// we 27otha gwa Property deh ==> public double Pi3 { get { return pi3 ; } set { pi3 = value; } }
        //// we hya me4 Static ma kdah ba7ot Static gwa Non-Static we dah 8alt
        //// kman mynfa34 el 3aks el hwa deh teb2a ==> private  double pi3 = 3.14; ==> teb2a Non-Static
        //// we 27otha gwa Property deh ==> public static double Pi3 { get { return pi3 ; } set { pi3 = value; } }
        //// we hya Static ma kdah ba7ot Non-Static gwa Static we dah 8alt
        //// fa el sa7 yb2a kdah ==> el 2 Static 3l4an 23rf 2st5dmh gwa el Static Method el hya CalculateCircleArea
        //// ya3ny yb2a kdah ==> private static double pi3 = 3.14;
        //// ==> public static double Pi3 { get { return pi3 ; } set { pi3 = value; } } ==> P is Capital outside and is small inside
        //// we kdah law get 7atet el [Pi3] deh ta7t fe el return mkan el 3.14 hyb2a tmam we me4 hydrb error
        //// l2n kdah 7atet Static Property gwa Static Method

        private static double pi3 = 3.14; // ==> Static Attribute
        public static double Pi3  // ==> Static Property
        {
            get { return pi3; }
            set { pi3 = value; }
        }

        //// we dah 8alt 2ny 25ly 7ad y8er feha 2sln el mafrod hya bekema sabta el hya 3.14
        //// fa ma3na kdah ana me4 me7tag el Set 3l4an ma 25le4 7ad y8er feha 7aga fa ha4el el set
        //// we teb2a kdah ma7d4 hy2dr y8er feha we hatefdl sabta 3altol bel kema el ana 7atetha el hya 3.14
        //// we tab3n lazem ykona ==> [Static]
        //// ma3na kdah 
        //// law el Method Static ==> Yb2a kol el Gwaha yb2a Static muynfa34 yb2a fe 7aga Non-Static
        //// law el Method Non-Static ==> Yb2a kol el Gwaha yb2a Non-Static muynfa34 yb2a fe 7aga Static
        //// fa 3l4an ne7l el Mo4kela deh han5ly el Property el hwa [pi4] dah ykon ==>[Static]
        //// we kman han5ly el public double Pi4 ==> yb2a Static bardo
        //// l2n mynfa34 2ny 25ly deh ==> private static double pi4 = 3.14; ==> teb2a Static
        //// we 27otha gwa Property deh ==> public double Pi4 { get { return pi4 ; } }
        //// we hya me4 Static ma kdah ba7ot Static gwa Non-Static we dah 8alt
        //// kman mynfa34 el 3aks el hwa deh teb2a ==> private  double pi4 = 3.14; ==> teb2a Non-Static
        //// we 27otha gwa Property deh ==> public static double Pi4 { get { return pi4 ; }}
        //// we hya Static ma kdah ba7ot Non-Static gwa Static we dah 8alt
        //// fa el sa7 yb2a kdah ==> el 2 Static 3l4an 23rf 2st5dmh gwa el Static Method el hya CalculateCircleArea
        //// ya3ny yb2a kdah ==> private static double pi4 = 3.14;
        //// ==> public static double Pi4 { get { return pi4 ; }} ==> P is Capital outside and is small inside
        //// we kdah law get 7atet el [Pi4] deh ta7t fe el return mkan el 3.14 hyb2a tmam we me4 hydrb error
        //// l2n kdah 7atet Static Property gwa Static Method

        private static double pi4 = 3.14;  // ==> Static Attribute
        public static double Pi4 // ==> Static Property
        {
            get { return pi4; }
           
        }



        // El Static Method bett3anl gwaha ma3 ==> Static Attribute & Constant [ReadOnly Constant , Const]
        // El ==> Static Attribute zay dah ==> private static double pi4 = 3.14;
        // Tb belnesba ll Constant hwa eh ???
        // el Constant have 2 Types :-
        // 1]. ReadOnly Constant   ==> deh hwa RunTime Constant
        // 2]. Const               ==> deh hwa CompileTime Constant

        // 1]. ReadOnly Constant:-
        // deh hwa RunTime Constant
        // can't be defined inside body of method even if method is Static or Non-Static
        // momken 23rfoh be tare2ten >>>
        // 1.1] men 5elal 2deloh value 3altol 3al nafs el line kdah ==> Private static readonly double pi5 = 3.14;

        private static readonly double pi5 = 3.14;

        // 1.2] men 5elal ma 2delo4 value 3al nafs el line we hadeloh el value fe el ==> Constcuctor
        //      bs me4 ay Constructor l2n el Readonly Constant dah hwa hast5dmoh gwa Static Method
        //      fa hwa ma3mp Static kdah  ==> private readonly double pi5 ;
        //      we kdah lazem 23rfoh fe ==> [Static Constructor]
        //      me4 el Constructor el 3ady bta3n l2n el Constructor el 3ady dah hwa Non-Static
        //      ya3ny hwa Object Constructor mynfa34 23rf gwah 7aga Static
        //      el Non-Static Constructor yt3arf gwah el 7agagt el Non-Static me4 el Static
        //      we el Static Constructor yt3arf gwah el 7agagt el Static me4 el Non-Static
        // el CLR ==> will initialize the Static Members with the Default Value of it's data type
        // ya3ny law kont 3amlt kdah bs ==> private readonly double pi6 ; ma 7atet4 value 
        // kdah el CLR ==> will initialize the Static Members with the Default Value of it's data type
        // ya3ny el pi5 hatkon be ==> 0
        // we el kalm dah by7sal lma ==> Before first usage and first reference of this Class Utility
        // tb hwa 2emta ba2ol 2ny bad2t 2ny 2st5dm el Class 2sln ???
        // dah bytme fe 7ala men 3 7alat 2nk t2ol 2n el Class dah tam 2st5damoh
        // 1. te3ml Create Object or Instance mn el Class dah 
        // 2. law hatest5dm Static member of the Class
        // 3. law hate3ml Create ly instance or object mn Class we el Class dah
        //    by inherit mn el Class dah el ana feh el hwa el Utitlity
        // el talt 7alat dol mogard ma el CLR hy4ofhm hyro7 y3arf kol el Static Members bel Default value

        // haro7 23rfo fo2 fe el Static Constructor 
        private static readonly double pi6;

        // 2]. Const :-
        // deh hwa CompileTime Constant
        // can be defined inside body of method even if method is Static or Non-Static
        // becuase meaning of Const is  ==> Implicitly [Static]
        // then can be inside direct in body of Static method without writting keyword static
        // ba3rfo be tare2 wa7da bs la 8er 
        // we hya men 5elal 2deloh value 3altol 3al nafs el line kdah ==> Private const double pi7 = 3.14;

        private const double pi7 = 3.14;
        /***********************************************************************************************/
        public static double CalculateCircleArea(double radius)
        {
            //// me4 lazem 23ml Explicit Casting 3al el Math.PI l2nha double 
            //// we ana el Method deh hya betrag3 double bardo
            //// fa me4 kan lazem 23ml casting 2sln l2n el 3elka double be double

            //return radius * radius * Math.PI;

            ////or

            //// me4 hy3ml error law katbt 3.14 kdah bs me4 lazem 25leh teb2a decimal 
            //// 2w me4 lazem 2fhmoh 2nha decimal
            //// fa me4 lazem 27ot ==> [M or m] fe 25r el rakm 3l4an yfahm 2n deh decimal me4 me7tag le dah
            //// l2n el property deh hya double we el 3.14 deh hya double bardo by deafult

            //return radius * radius * 3.14;
            //return radius * radius * pi2;
            //return radius * radius * Pi3;
            return radius * radius * Pi4;


            ////or

            //// me4 hy3ml error fe el Math.Pow fe el parameter el hy5odh l2noh me4 by5od 8er double
            //// we ana bab3tloh el parameter el hwa radius dah hwa double bardo fa me4 me7tag 23ml Casting
            //// Me4 lazem 23ml Explicit Casting 3al el Math.PI we el Math.Pow l2nha double 
            //// we ana el Method deh hya betrag3 double bardo
            //// fa me4 lazem 23ml casting l2n el 3elka double be double

            //return Math.PI * Math.Pow(radius /*dah el 2sas*/ , 2 /*dah el 2os*/);
        }
    }
}
