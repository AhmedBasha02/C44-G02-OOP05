namespace Session_10_OOP_Demo.Abstraction
{
    internal abstract class Shape
    {
        // can make or Add Constructor , To initialize fully implemented Properties
        // we bykon el Access Modifier bta3oh hwa ==> Protected
        // l2n ana 2sln me4 ba3ml instance mn el Abstarct Class 
        // fe me4 ha7tg el Consttactor dah barah fe 7aga
        // ana ha7tagoh bs fe el Classes el bet inherit and implement el Abstarct Class dah 
        // zay Class el Triangle kdah badl ma 23rf 3andoh el dim1 we dim2
        // l2 el Abstract Class dah y3arfhom 3andoh we ana k triangle ha3rf el dim3 3andy
        // kol wa7d y3arf el 3andoh we y3ml access 3al el 3andoh 
        // bs dah hy3ml m4akel fe ba2y el Classess zay el Square we el Circle
        // fa ha7tag 23ml 7al mn 2
        // 1] 2ny 23ml el Parmeterless Constructor we kdah el dony hateb2a tmam
        // 2] 2ny 2ro7 gwa el Class el Circle we el Square 23ml Base Chain Constrauctor we 2zabt el donya
        protected Shape(decimal dim1 , decimal dim2) 
        {
            Dimension1 = dim1;
            Dimension2 = dim2;
        }

        // 1] 2ny 23ml el Parmeterless Constructor we kdah el dony hateb2a tmam
        protected Shape()
        {

        }

        public decimal Dimension1 { get; set; } //==>Fully Implemented Members
        public decimal Dimension2 { get; set; } //==>Fully Implemented Members

        //// ana me4 3arf 25leha t return eh belzabt 
        //// l2n el Shape law Triangule leha area lwa7doh 8er el ba2y
        //// w law Circle leha area lwa7doh 8er el ba2y
        //// w law Square leha area lwa7doh 8er el ba2y
        //// w law Rectangle leha area lwa7doh 8er el ba2y
        //// we mynfa34 23mlha ka signature bs kdah ==> public decimal Area() ;
        //// ya3ny malha4 body wla implementation we dah 8alt fe el class 
        //// dah ynfa3 bs fe el interface 
        //// we ana me4 3ayez 23ml el interface 
        //// l2n 3andy 2 properties el homa Dimension1 w Dimension2 we dol properties 3adyen 
        //// ya3ny me4 signature proerty l2 dol properties ana 3ayezha kda zay ma hya ya3ny el compiler
        //// y generate leha backing field 
        //// tb 23ml eh ??
        //// el 7al 2ny ha5ly el method Area() deh teb2a [abstract] ==>
        //// we kdah bafhmo 2n el method deh Area() hya partial implementation
        //// ya3ny fe 7ad lysa hy3ml el implementation bta3ha lma y inherit mn el class dah
        //// bs ba3d ma 5alet el method Area() teb2a [abstract] lesa za3lan 
        //// tb Za3lan leh ??
        //// l2n el absract swa2 kan ma3mol 3al method 2w property 2w indexer 2w event 2w class
        //// lazem yt7at gwa abstract type bardo mynfa34 yt7at fe [non abstract type]
        //// we hena ana 7atet el method Area() el hya ba2t abstarct fe el class Shape el hwa non abstract type
        //// fa kdah lazem 25ly el class Shape teb2a [abstract]
        //// we el class el hwa non abstract type dah 2smoh ==> Complete or Regular class
        //// we dah mynfa34 27ot feh abstract member gwa el class dah 
        //// lazem el abstract member deh teb2a feh [abstract type] ya3ny fe abstract class
        //// we kdah el error 2t7al
        abstract public decimal Area(); //==>Abstract Members [Abstract Method]

        //// el Abstract Class :-
        //// hwa [Container] for Common Code for other Classes 
        //// we el Abstract Class deh 2smoh [Base Class]
        //// we el Classes el hya inheriting mn el Abstract Class deh 2smoh [Derived Classes or Concrete or Regular Class]
        //// we el Abstract Class deh mynfa34 23ml mnoh instance 
        //// ya3ny law 7awlt te3ml kdah fe el Program.cs ==> Shape shape = new Shape();
        //// hydrab error l2n dah hwa abstract class mynfa34 23ml mnoh instance or object
        //// we el ysbt el klam dah kon 2oln fe bedayet el session 2n el abstarct fe menoh no3en
        //// 1] hwa Abstact Class , 2] hwa interface
        //// we el interface 2oln 3aleh mynfa34 23ml mnoh instance or object
        //// we dah ysbt kman 2n el abstract class mynfa34 23ml mnoh instance or object bardo
        //// 2sl hat3ml object 2w instance mn el abstract class deh leh 2sln 2sl el code el gwa
        //// el abstract class 2w el interface hwa malo4 implementation ya3ny partial implementation
        //// 2w el hwa incomplete implementation fa hat3ml menoh instance we test5doh fe eh ma hwa
        //// mafe4 implementation 2sln fa 3l4an kdah el abstract class deh mynfa34 23ml mnoh instance or object
        //// lakn te2dr te3ml Reference mn el abstract class dah 3ady ma 2olna zayoh zay el interface
        //// we el interface 2olna 3aleh 2n 2dr 23ml mnoh reference y4awr 3ala ay instance 8er el interface nafsoh
        //// el reference dah y2dr y4awr 3al ay instance bet implement el interface dah 
        //// kazalk nafs el 2mr fe el abstract class te2dr te3ml mnoh refernce y4awr 3al ay class by inherit mnoh
        //// lakn my2dr4 y4awr 3al nafso lakn y2dr y4awr 3al ay instance ay class be inherit mnoh
        //// Reference can refer to any object from class that implement  and inherit from abstract class 
        //// 5aly balk el Abstarct Class dah lma 7ad ha y inherit mnoh me4 ba2ol by inherit bs
        //// l2 kman dah hy implement l2n el abstract class dah gwah partial implementation 2w incomplete impementation
        //// fa lysa ha3ml implememnt
        //// fa 3l4an kdah ay Class hywrs mn el Absrtact Class hwa kdah by3ml ==> Inheritance & Implementation

        //// we el Abstract Class deh momken ya7twy 3al :-
        //// el Common Code dah ba2smoh ly 7agten 

        //// 1.] Fully Implemented Members ==> Deh ma3na el 7aga el me4 ma3molha abstract fa hya betkon
        ////     fully implemented ya3ny feha implementation zay el 2 properties el homa Dimension1 w Dimension2
        ////     we el 2 properties deh 3adyen ya3ny el compiler y generate leha backing field

        //// 2.] Abstract Members ==> Deh ma3na el 7aga el me4 ma3molha implementation el hya bem3na 2s7
        ////                          mets5dm m3aha el modifier 2w el keyword [abstract]
        ////                          we deh el 7aga el ana 3ayez 23mlha fe el derived classes
        //// 


        //// han3ml el Perimeter bs han3mlha ka property me4 method 3l4an neb2a 4ofna el abstract property
        //// ana lysa ma3rf4 el Preimeter hyb2a feh eh ya3ny lysa leh takmla fe mkan tany 
        ////  we mynfa34 2seboh kdah ==> public decimal Perimeter { get; set; }
        //// l2n kdah el compiler y generate leha backing field we hydeloh default value 0 we dah 8alt
        //// l2n ana me4 ha3ml kdah we 2n kol shape lsa 3ndo Perimeter mo5talf 3an el tany
        //// fa 3l4an kdah hwa yo3tabr partial implementation or incomplete implementation
        //// fa lazem 23mlha [abstract property]
        public abstract decimal Perimeter { get;} //==> Abstract Property




        
        //// leh 3amltoh Abstract Class l2n law 3amlto Class 3ady kdah ana mogbr 23ml
        //// el implementation bta3 el Method Area we el Property Perimeter
        //// we homa me4 wa7d fe kol el shape l2n kol shape leh el Area el 5asa be we kazalk el Perimeter
    }
}
