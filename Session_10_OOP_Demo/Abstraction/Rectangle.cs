namespace Session_10_OOP_Demo.Abstraction
{

    //// 5aly balk el Abstarct Class dah lma 7ad ha y inherit mnoh me4 ba2ol by inherit bs
    //// l2 kman dah hy implement l2n el abstract class dah gwah partial implementation 2w incomplete impementation
    //// fa lysa ha3ml implememnt
    //// fa 3l4an kdah ay Class hywrs mn el Absrtact Class hwa kdah by3ml ==> Inheritance & Implementation

    //// Class : Class ==> Called Inheritance
    //// Class : Interface ==> Called Implementation
    //// Class : Abstract Class ==> Called Inheritance & Implementation

    // el Class el Rectangle ==> Called [Concrete or Regular Class] ==> dah hwa [Fully Implemented Class]
    // l2n dah el Class el hakml feh ba2y el implementation el na2s mn el Abstarct Class 
    //  fa hyt7awl mn Partial implementation ly Fully Implemented 
    internal class Rectangle : RecSquBase , ITwoDShape , IThreeDShape 
                                           // ==> kona be inherit fe el 2wl mn el shape we ba3d kdah ba2ena
                                          // ben inherit mn el class el RecSquBase ly sabb 4ar7nah fe el Class el RecSquBase
    {

        // fe el bedya makont4 me7tag dah 5als me4 me7tag ll constructor dah 
        // bs 3l4na 3amlt el constructor fe el RecSquBase we 3amltoh fe el Shape
        // fa hena lazem 23ml kman el Constructor we 23ml el base chain cotr
        public Rectangle(decimal dim1, decimal dim2) : base(dim1, dim2)
        { }

        // tb leh lma get 2kml el implemention leh 7at el KeyWord ==> [Override]
        // leh 7atha we ana fe el Shape el hwa Abstract Class ma3mlt4 ay 7aga [Virtual] henak 
        // leh 3aml kdah ????
        // l2n el KeyWord ==> [Abstract] ==> lma test5dmha ma3 el Methods 2w Properties 
        // fa by2oly 2n el [Abstract] ==> deh hya Implicitly Virtual 
        // ya3ny ka2nha Virtual 3l4an kdah hen 3aml el Override lma geh ykaml ba2y el implementation
        // lam el class el Rectangle geh y inherit and implement mn el abstract class shape
        // fa lma nada 3ale el 7aga el hy3mlha implemenation 7at el keyword el 2smha ==> [Override]
        // 3l4an ykaml ba2y el implementation we ykon ==> Fully Implemented 


        // hwa ynfa3 mn barah 2ny 27ot el Perimeter ly ay shape l2a me4 me7tag
        // and me7tag bs 2st5dm el [get{};] we ha4el el [set{};] 5als
        // l2n hya Value mo3yna ana ba7sbha we me4 me7tag 25ly 7ad mn barah ya3ml set gwa el perimeter 
        // we sa3tha el property deh hatkon kdah ==> [Read Only] ya3ny me4 me7tag el [set{};] fe 7aga
        // kol el me7tagoh bs hwa el [get{};]
        // bs law 3amlt el get{} kddah bs hena we ana henak m5leh ya5od get{} we Set{}
        // kdah hydrab erro fa lazem 24el mn el abstract class kman el set{} 3l4an 24el el error
        // we 5aly balk 27na 2olna ah el interface zay el abstract class 
        // bs hy5lafo fe 7aga 
        // henak fe el interface lma 7ad kan be implement el interface we zawd 7aga 3al el signature
        // kan 3ady me4 hydrb error bs zawd fe el class 2w el object el be implement el interface
        //  me4 zawd fe el interface
        // lakn hena fe el abstract class hena lma class 2w object y inherit and implement mn abstract class
        // lazem ykon nafs el 7aga wla yzawd wla yn2s l2noh me4 by implement ns l2 dah kman by inherit
        // we mdama by inherit yb2a nafs el 7aga wla tezawd wla ten2s 

        //can make this 
        //public override decimal Perimeter => Dimension1 * Dimension2 * 2;

        //or this
        public override decimal Perimeter {  // ==> Readonly Property
            get 
            {
                // 3ayzen nerg3 mo7et el rectangle el hwa dimension1 * dimension2
                // we 2dr tab3n y4of we y access el dimension1 w dimension2 l2noh by inherit mn el abstract class
                return Dimension1 * Dimension2 * 2;
            } 
        }



        //// 3amln el method deh Comment l2n hya bettkarr hena we fe class el Rectangle
        ////  fa 3l4an kdah ro7t 3amlt layer 2smha RecSquBase dah absstract class gwah el method
        //// badl ma 23mlha hena we 23mlha fe el Rectangle l2a y inherit 27sn mn el Class el RecSquBase
        //// we 4ar7 fe el RecSquBase kol 7aga 3l4n tefhm 

        //public override decimal Area()
        //{
        //    return Dimension1 * Dimension2 ;
        //}


        // lazem 23ml el implement yb2a Explicitly l2n el 2 interfces 3andohm nafs el method
        // bs kol wa7d leh behaviour mo5talef fa 3l4an kdah 3amlt el implement explicity me implicity
        // law 3amltoh implicitly yb2a el 2 interfaces 3andohm nafs el behavior ly nafs el method
        void IThreeDShape.Draw()
        {
            throw new NotImplementedException();
        }

        void ITwoDShape.Draw()
        {
            throw new NotImplementedException();
        }
    }
}
