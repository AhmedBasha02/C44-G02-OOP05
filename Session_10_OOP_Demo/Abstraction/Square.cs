namespace Session_10_OOP_Demo.Abstraction
{
    //// 5aly balk el Abstarct Class dah lma 7ad ha y inherit mnoh me4 ba2ol by inherit bs
    //// l2 kman dah hy implement l2n el abstract class dah gwah partial implementation 2w incomplete impementation
    //// fa lysa ha3ml implememnt
    //// fa 3l4an kdah ay Class hywrs mn el Absrtact Class hwa kdah by3ml ==> Inheritance & Implementation

    //// Class : Class ==> Called Inheritance
    //// Class : Interface ==> Called Implementation
    //// Class : Abstract Class ==> Called Inheritance & Implementation

    //// el Class el Square ==> Called [Concrete or Regular Class] ==> dah hwa [Fully Implemented Class]
    //// l2n dah el Class el hakml feh ba2y el implementation el na2s mn el Abstarct Class 
    ////  fa hyt7awl mn Partial implementation ly Fully Implemented 
    internal class Square : RecSquBase // ==> kona be inherit fe el 2wl mn el shape we ba3d kdah ba2ena
                                       // ben inherit mn el class el RecSquBase ly sabb 4ar7nah fe el Class el RecSquBase
    {
        //// el Square dah kol el Deminsion motsawya ya3ny kolhom wa7d 
        //// we ana 3andy bawrs 2 dimensions 
        //// fa 23ml eh 3l4an 25lehom 1 dimension l2n kol 2dla3 el square homa equals ly ba3d 
        //// ya3ny lazem dimension1 = dimension2
        //// ya3ny lazem 2gbr el user lma y create instance mn class el Square
        //// ybd2a ysta5dm el constructor el ana hagbroh 3aleh el hwa hy5od menoh 1 dimension bs
        //// el hwa el towl =  el 3ard 
        //// fa haro7 23ml constructor ll shape by5od 1 dimension
        //// we haswy el 1 dimesnion dah bel 2 dimesnions el 3and

        //// 5aly balk kan 2fdl 7al badl ma 23ml kol 4waya kdah constructor we 2sawy el diemsions be ba3d
        //// l2n dah ytwakf 3al 7asb el shape 
        //// fa kan el 2fdl fe abstract class bra3 el shape kont 3amlt 1 dimension only
        //// we kol class ba3d kdah hywrs mn el shape dah law 3ayez dimension kman yzawdoh mn 3anoh 27sn
        //// we kdah makont4 ha7tag 23ml el constructor dah hena fe class el Square wla fe Class el Circle
        //// fa dah el 7al el 2fdl ya3ny

        //// deh kont 3amlha 2bl ma 23ml ay constructor fe el shape swa2 Parameterless 2w parameterize ctor
        //// we kant 4a8la tmam
        //// bs lam 3amlt el parmeterize ctor deh 3amlt error we 3l4an 27eloh 
        //// kont me7tag 23ml el parameteless ctor
        //// 2w 23ml el code el ta7t 2ny 2st5dm el parmeterize ctor we 23ml el base chain
        //public Square(decimal side)
        //{
        //    Dimension1 = Dimension2 = side;
        //}

        //or
        // 3amlt dah l2n 3amlt henak fe el Shape Parmeterize Constructor
        // fa kan lazem 23ml kdah el base chain Constructor 
        // l2n kan hydrb error 
        // we 7alet el error be 2ny 3amlt el base dah 
        // 2w 23ml Parameterless Constructor fe el Shape we 2st5dm el Code el fo2
        // we hena bab3t el side marten l2n 3ayze dim1 = dim2 = side
        // bs hena hywaghny mo4kela 2n el Square bywrs mn el RecSquBase me4 mn el Shape
        // fa kdah me7tag 2ro7 23rf Constructor 3and el RecSquBase
        // we ha5ly el Constructor dah hy5od mn el constructor bta3 el shape we ya3ml el base chain ctor
        // we kdah 2b2a 7alet el error 
        // we 3amlt 7al kman 2ny 3amlt parameterless ctor 3l4an law me4 3ayez te3rf el parameter
        // bs ana hena me7tag el parameterize cotr 3l4an 25ly dim1 = dim2 = side
        public Square(decimal side):base(side , side)
        {
            
        }

        //// tb leh lma get 2kml el implemention leh 7at el KeyWord ==> [Override]
        //// leh 7atha we ana fe el Shape el hwa Abstract Class ma3mlt4 ay 7aga [Virtual] henak 
        //// leh 3aml kdah ????
        //// l2n el KeyWord ==> [Abstract] ==> lma test5dmha ma3 el Methods 2w Properties 
        //// fa by2oly 2n el [Abstract] ==> deh hya Implicitly Virtual 
        //// ya3ny ka2nha Virtual 3l4an kdah hen 3aml el Override lma geh ykaml ba2y el implementation
        //// lam el class el Rectangle geh y inherit and implement mn el abstract class shape
        //// fa lma nada 3ale el 7aga el hy3mlha implemenation 7at el keyword el 2smha ==> [Override]
        //// 3l4an ykaml ba2y el implementation we ykon ==> Fully Implemented 

        //// hwa ynfa3 mn barah 2ny 27ot el Perimeter ly ay shape l2a me4 me7tag
        //// and me7tag bs 2st5dm el [get{};] we ha4el el [set{};] 5als
        //// l2n hya Value mo3yna ana ba7sbha we me4 me7tag 25ly 7ad mn barah ya3ml set gwa el perimeter 
        //// we sa3tha el property deh hatkon kdah ==> [Read Only] ya3ny me4 me7tag el [set{};] fe 7aga
        //// kol el me7tagoh bs hwa el [get{};]
        //// bs law 3amlt el get{} kddah bs hena we ana henak m5leh ya5od get{} we Set{}
        //// kdah hydrab erro fa lazem 24el mn el abstract class kman el set{} 3l4an 24el el error
        //// we 5aly balk 27na 2olna ah el interface zay el abstract class 
        //// bs hy5lafo fe 7aga 
        //// henak fe el interface lma 7ad kan be implement el interface we zawd 7aga 3al el signature
        //// kan 3ady me4 hydrb error bs zawd fe el class 2w el object el be implement el interface
        ////  me4 zawd fe el interface
        //// lakn hena fe el abstract class hena lma class 2w object y inherit and implement mn abstract class
        //// lazem ykon nafs el 7aga wla yzawd wla yn2s l2noh me4 by implement ns l2 dah kman by inherit
        ////  we mdama by inherit yb2a nafs el 7aga wla tezawd wla ten2s 

        //// can make this

        //public override decimal Perimeter => Dimension1 * 4 ; // or Dimension2 *4 

        //// or this 
        public override decimal Perimeter   // ==> Readonly Property   
        {  
            get
            {
                //// 3ayzen nerg3 mo7et el square el hwa dimension1 * 4 or dimension2 * 4
                //// ma kdah kdah dimension1 hwa hwa dimension2 ba3d ma 3amlna el constructor
                //// we 5alenahom equal ly ba3d
                //// we 2dr tab3n y4of we y access el dimension1 w dimension2 l2noh by inherit mn el abstract class
                return Dimension1 * 4;
                
                ////or
                
                //return Dimension2 * 4
            }
        }

        //// 3amln el method deh Comment l2n hya bettkarr hena we fe class el Rectangle
        ////  fa 3l4an kdah ro7t 3amlt layer 2smha RecSquBase dah absstract class gwah el method
        //// badl ma 23mlha hena we 23mlha fe el Rectangle l2a y inherit 27sn mn el Class el RecSquBase
        //// we 4ar7 fe el RecSquBase kol 7aga 3l4n tefhm 

        //public override decimal Area()
        //{
        //    //// Dimension1 == Dimension2 becuase we make Constructor make them equal together
        //    //// so we can make taht ==> return Dimension1 * Dimension1 ;
        //    //// or ==> return Dimension2 * Dimension2;
        //    //// or ==> retuen Dimension1 * Dimension2;
        //    //// all correct becuase Dimension1 = Dimension2
        //    return Dimension1 * Dimension2;
        //}
    }
}
