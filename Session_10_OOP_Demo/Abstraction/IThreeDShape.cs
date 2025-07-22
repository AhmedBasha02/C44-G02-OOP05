namespace Session_10_OOP_Demo.Abstraction
{
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
    internal interface IThreeDShape
    {
        void Draw();
    }
}
