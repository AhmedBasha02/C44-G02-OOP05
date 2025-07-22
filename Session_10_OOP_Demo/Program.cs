using Session_10_OOP_Demo.Abstraction;
using Session_10_OOP_Demo.Partial;
using Session_10_OOP_Demo.Sealed;
using Session_10_OOP_Demo.Static;
using System.Diagnostics;

namespace Session_10_OOP_Demo
{
    internal class Program
    {
        #region Abstraction
        // ha3ml method beta5od meny el shape swa2 hwa Sqaure 2w Rectangle 2w Circle
        // we tetba3loh el Area we el Perimeter bta3oh
        // we ha5ly el Parameter el hast2bl feh ykon mn el BaseClass 2w Parent Class ==> Shape
        // l2n dah men 5elaloh a22dr 24awr 3al ay wa7d mn dol swa2 hwa Sqaure 2w Rectangle 2w Circle
        // l2n law ma3mlt4 kdah kdah haro7 23ml function ll Square we function ll Rectangle we hakza
        // we dah 8alt el sa7 23ml function wa7da te2dr te4awr 3al kolh
        // we el Shape dah hwa direct Parent ll ==>Circle
        // we el Shape dah hwa Indirect Parent ll ==> Square and Rectangle
        // l2n el Square and Rectangle by inherit mn el RecSquBase el hwa by inherit mn el Shape
        // we bem 2n dah Abstarct Class el hwa yo3tabr zay interface
        // fa lazem 2t check el 2wl 2n el reference dah me4 be null we ba3den 2bd2a 2nafez el Code
        // we kdah ana 3aml el reference hwa mn el Shape we ha5ly el reference dah ta7t fe el Call bta3 el method
        // y4awr 3al el instance el ana 3ayzha swa2 Rectangle 2w Square 2w Circle

        // without using keyword ==> Static 
        // mean we need to create instance from Program to access this method
        public  void ProcessShapeWithoutKeyWordStatic(Shape shape)
        {
            if (shape is not null)
            {
                //// hean ana me4 3arf 27ot 2sm el shape ya3ny 3ayez 2a2olh 27sb el Area we el Perimeter
                //// ly el Square 2w el Rectangle 2w el Circle
                //Console.WriteLine($"Area of Shape ==> : {shape.Area()}");
                //Console.WriteLine();
                //Console.WriteLine($"Perimeter of Shape ==> : {shape.Perimeter}");
                //Console.WriteLine();

                // 3l4an 25leh ytba3 el 7aga el hwa by7sblha el area 2w el Perimeter ha3ml kdah
                // 3andy method 2smha ==> GetType() ==> kant betrag3ly el namespace we el type bta3y 
                // el hwa namespace we ba3d kdah 2sm el userdefined datatype
                // gwaha a22dr 2tal3 2w 2a access property el Name 2w el FullName 2w el NameSpace
                // we ana 3ayz el Name bta3 el Shape ely el reference by4awr 3aleh ka instance
                // ya3ny el el Reference by4awr 3al Shape el Rectangle yb2a 3ayze el Name dah yb2a Rectangle
                // we hakza 
                // el Name deh betrga3lk 2sm el Datatype 2w 2sm el instance ely el reference by refer 3aleh
                Console.WriteLine($"Area of {shape.GetType().Name} ==> : {shape.Area()}");
                Console.WriteLine();
                Console.WriteLine($"Perimeter of {shape.GetType().Name} ==> : {shape.Perimeter}");
                Console.WriteLine();
            }
        }

        // with using keyword ==> Static 
        // mean we don't need to create instance from Program to access this method
        // you can access it directly
        public static void ProcessShapeWithKeyWordStatic(Shape shape)
        {
            if (shape is not null)
            {
                //// hean ana me4 3arf 27ot 2sm el shape ya3ny 3ayez 2a2olh 27sb el Area we el Perimeter
                //// ly el Square 2w el Rectangle 2w el Circle
                //Console.WriteLine($"Area of Shape ==> : {shape.Area()}");
                //Console.WriteLine();
                //Console.WriteLine($"Perimeter of Shape ==> : {shape.Perimeter}");
                //Console.WriteLine();

                // 3l4an 25leh ytba3 el 7aga el hwa by7sblha el area 2w el Perimeter ha3ml kdah
                // 3andy method 2smha ==> GetType() ==> kant betrag3ly el namespace we el type bta3y 
                // el hwa namespace we ba3d kdah 2sm el userdefined datatype
                // gwaha a22dr 2tal3 2w 2a access property el Name 2w el FullName 2w el NameSpace
                // we ana 3ayz el Name bta3 el Shape ely el reference by4awr 3aleh ka instance
                // ya3ny el el Reference by4awr 3al Shape el Rectangle yb2a 3ayze el Name dah yb2a Rectangle
                // we hakza 
                // el Name deh betrga3lk 2sm el Datatype 2w 2sm el instance ely el reference by refer 3aleh
                Console.WriteLine($"Area of {shape.GetType().Name} ==> : {shape.Area()}");
                Console.WriteLine();
                Console.WriteLine($"Perimeter of {shape.GetType().Name} ==> : {shape.Perimeter}");
                Console.WriteLine();
            }
        }


        // 3amlt el interface l2n mo3zm el shapes el 3andy el hwa Rectangel , Square , Triangle , Circle
        // 3andohm behavior 2n homa y2drow ytresmoh be tare2 mn 2 ya 2D y 3D
        // fa haro7 bara 3and el program ha3ml 2 methods ==> Draw2DShape(); , Draw3DShape(); 
        // dol by5do menk el Shape el 3ayez ytresm 2D 2w 3D bs 5aly balk me4 kol el Shape bet ttersm
        // ya3ny el Circle msln hytresm => 2D we el Rectangle hytresm => 2D we 3D
        // we ba2y el Shapes me4 hattersm 
        // fa ma3na kdah el referenc el hab3toh ka parameter fe el methods mynfa34 ykon ==> Shape shape
        // l2n el Shape dah hwa parrent lykol el shapes el 3andy
        // el mafrod el refernce el hab3toh ykon 7aga 3and el shape tedol 2noh hytresm 2D 2w 3D
        // ma3na kdah 2ny lazem el refernce ykon hwa el interface we el Class el 3andoh by implement el interface
        // dah hwa el hytresm law me4 3andk yb2a me4 harsemk
        // fa ana hab3t fe el method el Draw2DShape(); ==> hab3t el reference bta3 el interface ITwoDShape iTwoDShape
        // we kdah el 3andoh by implement el interface dah hwa el hytresm bs ka 2D
        // we ha3ml nafs el 7ewar fe el method Draw3DShape();==> hab3t el reference bta3 el interface IThreeDShape iThreeDShape
        // we kdah el 3andoh by implement el interface dah hwa el hytresm bs ka 3D
        // we law 7ad by implement el 2 interfaces 5las hytresm ka 2D we 3D
        // zay el Rectangle by implement el 2 Interfaces
        // lakn el Circle bet implement 1 Interface el hwa 2D
        // we ba2y el shapes me4 betimplement dah 
        // we deh el 7ala el ha7tg feh el interface badl el abstarct class 
        public static void Draw2DShape(ITwoDShape iTwoDShape)
        {

        }

        public static void Draw3DShape(IThreeDShape iThreeDShape)   
        {

        }
        #endregion
        static void Main(string[] args)
        {
            #region Abstraction

            /***************************************************************************************
             * let's Test All Classes that inherit and implemnt from Abstract Class
             * by using Reference from same Class
             * *************************************************************************************/

            //// el Class Rectangle dah makona4 3amlen ay Constructor leh
            ////  fa 3l4an 23rf el dimesions hast5dm el Object Initializer we 2bd2 23rf feh 
            //Rectangle rectangle = new Rectangle() { Dimension1 = 10 , Dimension2 = 20 };
            //Console.WriteLine($"Area of Rectangle ==> : Dimension1 = {rectangle.Dimension1} * Dimension2 = {rectangle.Dimension2} * 2 = Area : {rectangle.Area()}");
            //Console.WriteLine();
            //Console.WriteLine($"Perimeter of Rectangle ==> : Dimension1 = {rectangle.Dimension1} * Dimension2 = {rectangle.Dimension2} Perimeter : {rectangle.Perimeter}");
            //Console.WriteLine();
            //Console.WriteLine();

            //// el Squre 3andoh Constructor fa lazem 2b3t el data fe leh 
            //// we me4 hanst5dm el Object Initializer l2n 3anden constructor mestany mny data
            //Square square = new Square(10);
            //Console.WriteLine($"Area of Square ==> : Dimension1 = {square.Dimension1} * Dimension2 = {square.Dimension2} = Area : {square.Area()}");
            //Console.WriteLine();
            //Console.WriteLine($"Perimeter of Square ==> : Dimension1 = {square.Dimension1} * 4 = Perimeter : {square.Perimeter}");
            //Console.WriteLine();
            //Console.WriteLine();

            //// hal7z 2n el Area bta3t el Square fe Class el Square hya hya el Area bta3t el Rectangle 
            //// fe Class el Rectangle we kdah dah me4 Clean Code l2n fe tekrar fe el Code 
            //// fa 3l4an kdah haro7 23ml layer maben el Rectangle we el Square ha7ot feha 
            //// method el area el bettkarr deh 
            //// we el Class dah 2smoh RecSquBase
            //// we el Class dah hy inherit mn el Shape el hwa Abstract Class
            //// bs hatwaghny mo4kel we hya 2ny me4 3ayez 2sln el abstract property el hya [Perimeter]
            //// 5las 4elha bs dah hyfdl ya3ml error
            //// we 3l4an n4el el error han3rf el Class el gded dah el hwa RecSquBase hykon Abstract
            //// ya3ny lysa fe 7agat han3mlh implementation me4 kolh gahz



            //// el Circle 3andoh Constructor fa lazem 2b3t el data fe leh 
            //// we me4 hanst5dm el Object Initializer l2n 3anden constructor mestany mny data
            //Circle circle = new Circle(10);
            //Console.WriteLine($"Area of Circle ==> : Dimension1 = {circle.Dimension1} * Dimension2 = {circle.Dimension2} * PI  = Area : {circle.Area()}");
            //Console.WriteLine();
            //Console.WriteLine($"Perimeter of Circle ==> : Dimension1 = {circle.Dimension1}  * 2 * PI : Perimeter : {circle.Perimeter}");
            //Console.WriteLine();
            //Console.WriteLine();

            /***************************************************************************************
             * let's Test All Classes that inherit and implemnt from Abstract Class
             * by using Reference from Base Class ==> Shape
             * *************************************************************************************/

            //Shape rectangle = new Rectangle() { Dimension1 = 10, Dimension2 = 20 };

            //// 3amlt el Reference mn el Program we 5alet el Reference dah y refer 3al instance mn el Program
            //// 3l4an kont 3aml el method fo2 3amlha non-static we 3l4an 2wslha yb2a lazem 23ml instance mn 
            //// el Program 3l4an 2wslha
            //// lakn law kant static kont wesltelha 3altol mn 8er ay 7aga wla instance wla 8eroh
            //Program program = new Program();

            //// law me7tage el reference el rectangle fe 7aga ba3d kdah fa 23ml el tare2 deh 
            //// 2nk te3rf reference we ba3den t5leh y refere 3al instance mo3yna we ba3den hanb3t el 
            //// reference dah fe call el method za ma 7asl hena ==>
            //program.ProcessShapeWithoutKeyWordStatic( rectangle );

            //// or

            //// lakn law me4 me7tag el refernce fe 7aga ba3d kdah 5las 2b3t el instance 3altol mn 8er reference
            //// zay a 7asl hena l2n me4 me7tag el address fe 7aga ana 3ayzoh ywsl ll instance 3altol 
            //// fa ba3t el instance 3altol hena mn 8er referecne
            //program.ProcessShapeWithoutKeyWordStatic(new Rectangle() { Dimension1 = 2 , Dimension2 = 5});

            //// law me7tage el reference el square fe 7aga ba3d kdah fa 23ml el tare2 deh 
            //// 2nk te3rf reference we ba3den t5leh y refere 3al instance mo3yna we ba3den hanb3t el 
            //// reference dah fe call el method za ma 7asl hena ==>
            //Shape square = new Square(10);
            //ProcessShapeWithKeyWordStatic(square);

            ////or

            //// lakn law me4 me7tag el refernce fe 7aga ba3d kdah 5las 2b3t el instance 3altol mn 8er reference
            //// zay a 7asl hena l2n me4 me7tag el address fe 7aga ana 3ayzoh ywsl ll instance 3altol 
            //// fa ba3t el instance 3altol hena mn 8er referecne
            //ProcessShapeWithKeyWordStatic(new Square(20));


            //// law me7tage el reference el circle fe 7aga ba3d kdah fa 23ml el tare2 deh 
            //// 2nk te3rf reference we ba3den t5leh y refere 3al instance mo3yna we ba3den hanb3t el 
            //// reference dah fe call el method za ma 7asl hena ==>
            //Shape circle = new Circle(15);
            //ProcessShapeWithKeyWordStatic(circle);

            ////or

            //// lakn law me4 me7tag el refernce fe 7aga ba3d kdah 5las 2b3t el instance 3altol mn 8er reference
            //// zay a 7asl hena l2n me4 me7tag el address fe 7aga ana 3ayzoh ywsl ll instance 3altol 
            //// fa ba3t el instance 3altol hena mn 8er referecne
            //ProcessShapeWithKeyWordStatic(new Circle(30));

            #endregion

            #region Abstract Class Vs Interface
            #endregion

            #region Static [Method - Attribute - Property]

            #region Ex - 1

            /*
             * Example 01: Define Utility Class
             * A Utility Class is used as a container for helper methods. This example includes:
             * - Convert from Meter to Cm
             * - Calculate Circle Area
             * Note on Methods:
             * A static method can only access other static members (fields, methods, etc.) of the class.
             * It cannot access instance members, because it does not operate on an instance of the class.
             */




            /************ First Try Non-Static Then make Static to show Difference when Call ************/

            /************************ Method ConvertMetersToCm *****************************/


            //// first Creaet reference from Utility to deal with him and make this reference refer or point
            //// to this class Utility
            //// we define X = 10 and Y = 20
            //Utility utility1 = new Utility(10, 20);
            //// then call method ConvertMetersToCm
            //Console.WriteLine($"After Convert From Meter To Cm ==> : {utility1.ConvertMetersToCm(1)}");
            //Console.WriteLine();

            //// let's change X  and  Y that belong to utility1
            //utility1.x = 50 ;
            //utility1.y = 80 ;
            //// then call method ConvertMetersToCm
            //Console.WriteLine("After Change X and Y");
            //Console.WriteLine($"After Convert From Meter To Cm ==> : {utility1.ConvertMetersToCm(1.2)}");
            //Console.WriteLine();

            //// hanlaez hena 2n kol ma ba8er el X 2w el Y dah me4 by2sr fe 7aga 3al el method el hya 
            //// ==> ConverMetersToCm 
            //// maham 8ayert fehom dah me4 by2r 3al el method fe 7aga
            //// el method deta5od el vlaue mn el user we te7welha ly Cm malha4 3elak bel X wla el Y 
            //// ya3ny mn el 25er ==>
            //// when you change the object state ==> Method will return the same Value
            //// 7ata law 3amlt reference gded mn nafs el instance bardo dah me4 hy2sr 3al el method fe 7aga
            ////  we hatefdl te3tmed bs 3al el value el bet5oha mn el user we mlha4 3elak b2a
            //// be ta8er el reference 2w ta8er el X and el Y
            //// we ta3ala n8er el reference 2ho 3l4an nesbt 2n mafe4 7aga 7aslt

            //// we define X = 30 and Y = 40
            //Utility utility2 = new Utility(30, 40);
            //// then call method ConvertMetersToCm
            //Console.WriteLine($"After Convert From Meter To Cm ==> : {utility2.ConvertMetersToCm(1.5)}");
            //Console.WriteLine();

            //// let's change X  and  Y that belong to utility1
            //utility1.x = 1000;
            //utility1.y = 80000;
            //// then call method ConvertMetersToCm
            //Console.WriteLine("After Change X and Y");
            //Console.WriteLine($"After Convert From Meter To Cm ==> : {utility1.ConvertMetersToCm(2.23)}");
            //Console.WriteLine();

            //// hanlaez hena 2n kol ma ba8er el X 2w el Y dah me4 by2sr fe 7aga 3al el method el hya 
            //// ==> ConverMetersToCm 
            //// maham 8ayert fehom dah me4 by2r 3al el method fe 7aga
            //// el method deta5od el vlaue mn el user we te7welha ly Cm malha4 3elak bel X wla el Y 
            //// ya3ny mn el 25er ==>
            //// when you change the object or instance ==> Method will return the same Value
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
            //// fa hatla7ez fo2 darb error ba3d ma 7awelt el method mn non-static ly static
            //// l2n fo2 kont bandy 3aleha mn 5elal reference we el reference dah by refer or point to instance
            //// by refer 3al instance or object mn el Utility we dah kan valid lma hya kant ==> Non-Static
            //// lakn ba3d ma ba2t Static Handy 3aleh mn 2sm el Class bs 




            /**************************** Method CalculateCircleArea ******************************/



            //// first Creaet reference from Utility to deal with him and make this reference refer or point
            //// to this class Utility
            //// we define X = 10 and Y = 20
            //Utility utility1 = new Utility(10, 20);
            //// then call method CalculateCircleArea
            //Console.WriteLine($"After Calaculate Area of Circle ==> : {utility1.CalculateCircleArea(1)}");
            //Console.WriteLine();

            //// let's change X  and  Y that belong to utility1
            //utility1.x = 50;
            //utility1.y = 80;
            //// then call method CalculateCircleArea
            //Console.WriteLine("After Change X and Y");
            //Console.WriteLine($"After Calaculate Area of Circle ==> : {utility1.CalculateCircleArea(1.2)}");
            //Console.WriteLine();

            //// hanlaez hena 2n kol ma ba8er el X 2w el Y dah me4 by2sr fe 7aga 3al el method el hya 
            //// ==> CalculateCircleArea 
            //// maham 8ayert fehom dah me4 by2r 3al el method fe 7aga
            //// el method deta5od el vlaue mn el user we te7welha ly Cm malha4 3elak bel X wla el Y 
            //// ya3ny mn el 25er ==>
            //// when you change the object state ==> Method will return the same Value
            //// 7ata law 3amlt reference gded mn nafs el instance bardo dah me4 hy2sr 3al el method fe 7aga
            ////  we hatefdl te3tmed bs 3al el value el bet5oha mn el user we mlha4 3elak b2a
            //// be ta8er el reference 2w ta8er el X and el Y
            //// we ta3ala n8er el reference 2ho 3l4an nesbt 2n mafe4 7aga 7aslt

            //// we define X = 30 and Y = 40
            //Utility utility2 = new Utility(30, 40);
            //// then call method CalculateCircleArea
            //Console.WriteLine($"After Calaculate Area of Circle ==> : {utility2.CalculateCircleArea(1.5)}");
            //Console.WriteLine();

            //// let's change X  and  Y that belong to utility1
            //utility1.x = 1000;
            //utility1.y = 80000;
            //// then call method CalculateCircleArea
            //Console.WriteLine("After Change X and Y");
            //Console.WriteLine($"After Calaculate Area of Circle ==> : {utility1.CalculateCircleArea(2.23)}");
            //Console.WriteLine();

            //// hanlaez hena 2n kol ma ba8er el X 2w el Y dah me4 by2sr fe 7aga 3al el method el hya 
            //// ==> CalculateCircleArea 
            //// maham 8ayert fehom dah me4 by2r 3al el method fe 7aga
            //// el method deta5od el vlaue mn el user we te7welha ly Cm malha4 3elak bel X wla el Y 
            //// ya3ny mn el 25er ==>
            //// when you change the object or instance ==> Method will return the same Value
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
            //// fa hatla7ez fo2 darb error ba3d ma 7awelt el method mn non-static ly static
            //// l2n fo2 kont bandy 3aleha mn 5elal reference we el reference dah by refer or point to instance
            //// by refer 3al instance or object mn el Utility we dah kan valid lma hya kant ==> Non-Static
            //// lakn ba3d ma ba2t Static Handy 3aleh mn 2sm el Class bs 






            /************** Second Try when make Method Static to show Difference when Call **************/



            /**************************** Method ConvertMetersToCm ******************************/



            //// then when Method don't depend on Object State like X and Y and don't depend of Instance
            //// when try to change reference 
            //// then make this method ==> [Static Method]
            //// me4 me7taga 2nadeky mn 5elal object 2w instance
            //// and when make it [Static]
            //// then you can call it directly by class name
            //// then you can call it like this in Program.cs ==> Utility.ConvertMetersToCm(2.5);
            //// then you can call it without creating any instance or object
            //// fa hatla7ez fo2 darb error ba3d ma 7awelt el method mn non-static ly static
            //// l2n fo2 kont bandy 3aleha mn 5elal reference we el reference dah by refer or point to instance
            //// by refer 3al instance or object mn el Utility we dah kan valid lma hya kant ==> Non-Static
            //// lakn ba3d ma ba2t Static Handy 3aleh mn 2sm el Class bs
            //// law 7awlt 23ml reference we instance we 2nady 3aleha hydrb error l2na ba2t Static
            //// we el Static Method leha 2sm we hwa ==> [Class Member Method]

            //Console.WriteLine($"After Make Method Static Then Call it by Using Class Name ==> : {Utility.ConvertMetersToCm(1.2)}");



            /**************************** Method CalculateCircleArea ******************************/



            //// then when Method don't depend on Object State like X and Y and don't depend of Instance
            //// when try to change reference 
            //// then make this method ==> [Static Method]
            //// me4 me7taga 2nadeky mn 5elal object 2w instance
            //// and when make it [Static]
            //// then you can call it directly by class name
            //// then you can call it like this in Program.cs ==> Utility.CalculateCircleArea(2.5);
            //// then you can call it without creating any instance or object
            //// fa hatla7ez fo2 darb error ba3d ma 7awelt el method mn non-static ly static
            //// l2n fo2 kont bandy 3aleha mn 5elal reference we el reference dah by refer or point to instance
            //// by refer 3al instance or object mn el Utility we dah kan valid lma hya kant ==> Non-Static
            //// lakn ba3d ma ba2t Static Handy 3aleh mn 2sm el Class bs
            //// law 7awlt 23ml reference we instance we 2nady 3aleha hydrb error l2na ba2t Static
            //// we el Static Method leha 2sm we hwa ==> [Class Member Method]

            //Console.WriteLine($"After Make Method Static Then Call it by Using Class Name ==> : {Utility.CalculateCircleArea(15)}");

            //// ba3d ma 3amln kdah fe el Property Pi3
            //// ne3mlha ==> Full Property 2shal
            //// kdah ==> private double pi3; ==> p is small
            //// then ==> public double Pi3 { get { return pi3 ; } set { pi3 = value; } } ==> P is Capital outside and is small inside
            //// we kdah ay 7ad mn bara y2dr y access el Pi3 we y7ot feh el Vlaue el hwa 3ayezha
            //// 7at law 2detha value hena fe el 2wl ka default vlaue kdah ==> private double pi3 = 3.14;
            //// 3ady mogard ma 7ad y accessha mn bara men 5ele 2noh y3ml instance mn el Class dah 
            //// we y access el Pi3 y2dr y7ot el value el hwa 3ayezha we 2oln y3ml instance
            //// l2n el Property deh hya Non-Static ya3ny [Object or instance member Property]
            //// Mean to Access it should make instance or object
            //// fa mogard ma 3amlt el instance we 3amlt access 3al el [Pi3] 2dert 28er el value mn 3.14
            //// ly 30
            //// we dah 8alt 2ny 25ly 7ad y8er feha 2sln el mafrod hya bekema sabta el hya 3.14
            //// tab3n mogard ma 28er el Full Property deh 3l4an tekon Static badl ma hya NonStatic
            //// hydrb error hena l2n lazem a3mlha access mn 5elal el Class name
            //// we lyas men 5elal el instance 2w object

            //Utility ui = new Utility(10, 20);
            //ui.Pi3 = 30;
            //Console.WriteLine(ui.Pi3);


            //// ba3d ma 3amln kdah fe el Property Pi3
            //// ne3mlha ==> Full Property 2shal
            //// we n5aleha Static fe el 2tnen tb leh ????
            //// fa 3l4an ne7l el Mo4kela deh han5ly el Property el hwa [pi3] dah ykon ==>[Static]
            //// we kman han5ly el public double Pi3 ==> yb2a Static bardo
            //// l2n mynfa34 2ny 25ly deh ==> private static double pi3 = 3.14; ==> teb2a Static
            //// we 27otha gwa Property deh ==> public double Pi3 { get { return pi3 ; } set { pi3 = value; } }
            //// we hya me4 Static ma kdah ba7ot Static gwa Non-Static we dah 8alt
            //// kman mynfa34 el 3aks el hwa deh teb2a ==> private  double pi3 = 3.14; ==> teb2a Non-Static
            //// we 27otha gwa Property deh ==> public static double Pi3 { get { return pi3 ; } set { pi3 = value; } }
            //// we hya Static ma kdah ba7ot Non-Static gwa NStatic we dah 8alt
            //// fa el sa7 yb2a kdah ==> el 2 Static 3l4an 23rf 2st5dmh gwa el Static Method el hya CalculateCircleArea
            //// kdah ==> private static double pi3; ==> p is small
            //// then ==> public static double Pi3 { get { return pi3 ; } set { pi3 = value; } } ==> P is Capital outside and is small inside
            //// we kdah ay 7ad mn bara y2dr y access el Pi3 we y7ot feh el Vlaue el hwa 3ayezha
            //// 7at law 2detha value hena fe el 2wl ka default vlaue kdah ==> private double pi3 = 3.14;
            //// 3ady mogard ma 7ad y accessha mn bara men 5ele 2noh y3ml 2w yst5dm el Class name dah 
            //// we y access el Pi3 y2dr y7ot el value el hwa 3ayezha we 2oln y3ml 2w yst5dm el Class name
            //// l2n el Property deh hya Static ya3ny [Class member Property]
            //// Mean to Access it should use Class name
            //// fa mogard ma 3amlt el Class name we 3amlt access 3al el [Pi3] 2dert 28er el value mn 3.14
            //// ly 50
            //// we dah 8alt 2ny 25ly 7ad y8er feha 2sln el mafrod hya bekema sabta el hya 3.14

            //Utility.Pi3 = 50;
            //Console.WriteLine(Utility.Pi3);

            #endregion

            #endregion

            #region Static [Class - Constructor]

            //// deh 2wl 7ala han3ml create ly instance mn Class Utility 3l4an nesbt 2n mogard ma ba3ml el instance 
            //// el CLR bynady 3al el Static Constructor 3altol we ynafezoh 3altol 
            //// we mogard ma 23ml el Instance we 2wl m Run hytb3 Msg ==>Hello From Static Constructor
            //// we dah el 7asl 

            //Utility utility = new Utility(10, 20);

            //// tany 7ala han3ml Class 2smoh Test hy inherit mn Class Utility
            //// we han3ml create ly instance mn Class Test 3l4an nesbt 2n mogard ma ba3ml el instance 
            //// el CLR bynady 3al el Static Constructor 3altol we ynafezoh 3altol 
            //// we mogard ma 23ml el Instance we 2wl m Run hytb3 Msg ==> Hello From Static Constructor
            //// we dah el 7asl 

            //Test test = new Test(30,40);

            //// 5aly balk law ba3ml el 7alten el fo2 dol ma3 ba3d hwa el Static Constructor hytnafez mara wa7da bs 
            //// ya3ny hytba3lk el msg dah ==> Hello From Static Constructor
            //// bs mara wa7da bs l2n el static Constructor bytnadah 3aleh mn el CLR mara wa7da tol ma el program
            //// by run
            //// fa law 3amlt el 7alten swa hytba3 el msg mara wa7da 
            //// we dah el 7asl

            //Utility utility = new Utility(10, 20);
            //Test test = new Test(30, 40);

            //// el 7ala el talta lma 2st5dm 7aga static zay el static method el hya ==> CalculateCircleArea
            //// bardo mogard ma 2st5dmha el CLR bynady 3al el Static Constructor 3altol we ynafezoh 3altol 
            //// we mogard ma 23ml el Call we 2wl m Run hytb3 Msg ==> Hello From Static Constructor
            //// we dah el 7asl 

            //Utility.CalculateCircleArea(10);


            //// 5aly balk law ba3ml el 3 7alat el fo2 dol ma3 ba3d hwa el Static Constructor hytnafez mara wa7da bs 
            //// ya3ny hytba3lk el msg dah ==> Hello From Static Constructor
            //// bs mara wa7da bs l2n el static Constructor bytnadah 3aleh mn el CLR mara wa7da tol ma el program
            //// by run
            //// fa law 3amlt el 3 7alat swa hytba3 el msg mara wa7da 
            //// we dah el 7asl

            //Utility utility = new Utility(10, 20);
            //Test test = new Test(30, 40);
            //Utility.CalculateCircleArea(10);

            #endregion

            #region Sealed

            //Parent parent = new Parent();
            //parent.Salary = 10;
            //Console.WriteLine($"Salary is : {parent.Salary}");
            //Console.WriteLine();
            //parent.MyFun();
            //Console.WriteLine();
            //Console.WriteLine();

            //Child child = new Child();
            //child.Salary = 20;
            //Console.WriteLine($"Salary is : {child.Salary}");
            //Console.WriteLine();
            //child.MyFun();
            //Console.WriteLine();
            //Console.WriteLine();

            //GrandChild grandChild = new GrandChild();
            //grandChild.Salary = 30;
            //Console.WriteLine($"Salary is : {grandChild.Salary}");
            //Console.WriteLine();
            //grandChild.MyFun();
            //Console.WriteLine();
            //Console.WriteLine();



            //// ta3la n4of hwa hena fe binding wla l2a 
            //// ta3la n2ol 2nena hanebd2 nenafz mawdo3 el binding dah 
            //// tb hwa fen el binding 2slan ??
            //// ma ana 3andy inheritance we el inheritance dah fe menhom 4wayet method mehom goz2 virtual
            //// fa 3ady momken 2nafez el binding
            


            ////// el GrandChild 3andoh el direct parent el hwa Child we el indirect Parant el hwa el Parant
            ////// fa ana ha3ml reference mn el Parent y4awr 3al instnace mn el GrandChild
            ////// el 7aga el mest5dmen feha keyword ==> Virtual ==> dah kdah Dynamic Binding
            ////// and this work ==> Call method Based on instance
            ////// we el 7aga el me4 mest5dmen feha keyword ==> Virtual ==> dah kdah Static Binding
            ////// and this work ==> Call method Based on Reference
            ////// make reference form Parent
            ////// this is Reference Type that CLR reserve 4 bytes in memory in stack
            ////// and this reference will point or refer to any instance from Parent
            ////// or any child class from Parent or any instance from class that inherits from Parent
            ////// this mean can refer to Class Parent or Child or GrandChild
            ////// this reference can access or update any thing in his class Parent only
            ////// but it can't update and access any value on any class inherits from Parent
            ////// becuase this is not personal scope
            ////// but it can only access the members that Parent has and update them in Class Parent only 
            ////// becuase this is personal scope for Parent
            
            //Parent grandChildRef = new GrandChild();
            //grandChildRef.Salary = 10000;

            ////// what happend ? it will happen dyanmic binding becuase we use keyword virtual
            ////// and this work ==> Call method Based on instance not based on reference
            ////// and Reference refer to Parent but instance refer to GrandChild 
            ////// when make this ==> grandChildRef = new GrandChild();
            ////// then it will call MyFun and Property Salary that in Scope of Child not in Parent or GrandChild
            ////// becuase this method is virtual in Parent and override in Child and this is Dynamic Binding
            ////// and when use keyword New in GrandChild 
            ////// then we break chain of this method MyFun and Property Salary 
            ////// and make new Chain for this method MyFun and Property Salary from GrandChild
            ////// then we have 2 types of chain 
            ////// 1st chain for this method MyFun and Property Salary  from Parent to Child and end in Child
            ////// 2nd chain start from GrandChild and end in GrandChild becuase we make it Sealed
            ////// mean not any class can inherit from it
            ////// when see o/p of call this method MyFun and Property Salary we will get 
            ////// the o/p is ==> Child ==> Hello i am child and Salary is : 13000 
            ////// becuase take salary from child and first go to base to parent and increase 1000
            ////// then return to child to increase 2000 then total 3000 on base salalry 10000 all 13000
            ////// this mean call method MyFun and Property Salary that in Child not in GrandChild
            ////// but instance refer to GrandChild not Child
            ////// then what happend ?
            ////// we say when use keyword [new] make a new chain then when use any reference
            ////// from any type not from GrandChild 
            ////// then it will call the last override method MyFun and Property Salary from 1st Chain 
            ////// this mean it call method MyFun and Property Salary in Child
            ////// becuase this is the last override method MyFun and Property Salary
            ////// or mean the last method in 1st chain becuase we break this chain when use new in GrandChild
            ////// and instance refer to GrandChild that make new chain on it this is the main reason 
            ////// So call last method MyFun and Property Salary from last chain before break it

            //Console.WriteLine($"Salary is : {grandChildRef.Salary}");
            //Console.WriteLine();
            //grandChildRef.MyFun();
            //Console.WriteLine();


            #endregion

            #region Partial

            //// hwa 4ayef kol 7aga 4ayf el 1 method we 4ayef el 3 Properties
            //// we law 4oftoh fe el debug hatl2eh da5l 3and el 2 Classes 3ady bs fe el 25er hwa 1 Class
            //// bs met2sm 3al 2 Files 
            //// File ll Properties
            //// we el File el Tany ll MEthod

            //Employee employee = new Employee();
            //employee.Name = "Ahmed";
            //employee.Age = 24;
            //employee.Id = 22;
            //employee.Print();
            //employee.DoSomeThing();

            //// han3mlha access bel Class name me4 mn el instance l2n dah static method
            //Employee.SayHello();

            #endregion

            #region Notes
            #endregion

        }
    }
}
