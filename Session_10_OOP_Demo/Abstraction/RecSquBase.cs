namespace Session_10_OOP_Demo.Abstraction
{
    // hal7z 2n el Area bta3t el Square fe Class el Square hya hya el Area bta3t el Rectangle 
    // fe Class el Rectangle we kdah dah me4 Clean Code l2n fe tekrar fe el Code 
    // fa 3l4an kdah haro7 23ml layer maben el Rectangle we el Square ha7ot feha 
    // method el area el bettkarr deh 
    // we el Class dah 2smoh RecSquBase
    // we el Class dah hy inherit mn el Shape el hwa Abstract Class
    // bs hatwaghny mo4kel we hya 2ny me4 3ayez 2sln el abstract property el hya [Perimeter]
    // 5las 4elha bs dah hyfdl ya3ml error
    // we 3l4an n4el el error han3rf el Class el gded dah el hwa RecSquBase hykon Abstract
    // ya3ny lysa fe 7agat han3mlh implementation me4 kolh gahz
    // ana me4 gway kol el implementation bta3 el abstarct class el hwa shape
    // ya3ny lesa fe 7agat n2sa ma 3amlt4 3aleha override el hya zay el [Perimeter]
    // l2n ana me4 me7tagh hena fa sa3tha lazem 2ro7 25ly el Class dah el hwa RecSquBase 
    // ykon abstract 3l4an nfahm el compiler 2n dah partial implementation or incomplete implementation
    // l2n me4 hast5dm el abstract proerty el hya [Perimeter] el fe Abstarct Class Shape
    // fa 3l4an kdah lazem 23mloh dah hwa abstacrt class l2n me4 kol 7aga gwah 
    // we kdah el error hyro7 5las
    // we ba3d kdah han3rf el method el Area()
    // we ne3mlha el implementation bta3h kolha hya kdah hatkon ==> Fully Implemented MEthod
    // ma 27na 2olna fe el beday 5als 2n el Abstract Class gwah y ==> Fully Implemented Members or Abstract Members

    // we ba3d kol dah lazem b2a 2ro7 3and Class el Square we Class el Rectangle el kan 3andohm 
    // mo4kelt 2ny bakrr method el Area we 3amlt lehom el Layer deh 3l4an 2mn3 el Tekrrar
    // fa haro7 ly kol Class fehom we badl ma kan bywrs mn el Shape l2 hywrs mn el RecSquBase
    // we dah me4 hydrb ay error hynak l2n el class RecSquBase hwa bywrs mn el shape bardo
    // fa ay 7aga gwa el Square 2w el Rectangle kant gay mn el Shape me4 hatedrb error
    // l2n homa hywrso mn el RecSquBase we hwa 2sln wars mn el Shape 
    // fa kdah el donya tmam we kdah man3t tekrra fe el Code 3andy 
    // we haro7 b2a 24el el Method el Area men henak 5las 
    internal abstract class RecSquBase : Shape
    {
        // 3amlt el Parameterless Constructor dah 3l4an law el bywrs mn el RecSquBase dah 
        // zay el Rectangle we el Squre law me4 3ayez ya3ml Constructor 5las
        // tb law 3ayez 5las 3amltol dah we el parameterize constructor ta7toh 3l4an y3arf el 7aga 
        protected RecSquBase() { }
        protected RecSquBase(decimal dim1 , decimal dim2):base(dim1 , dim2)
        { }
        public override decimal Area()   //==> Fully Implemented MEthod
        {
            return Dimension1 * Dimension2;
        }
    }
}
