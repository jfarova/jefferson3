class cal:numeros{
    private int num1 {get;set;}
    private int num2 {get;set;}
    private int num3 {get;set;}
    private int num4 {get;set;}
    private int num5 {get;set;}
    private int num6 {get;set;}

    private int num7 {get;set;}
    private int num8 {get;set;}
 
    public cal(int num1,int num2,int num3,int num4,int num5,int num6,int num7,int num8 ):base(num1,num2,num3,num4,num5,num6,num7,num8){
    this.num1=num1;
    this.num2=num2;
    this.num3=num3; 
    this.num4=num4;
    this.num5=num5;
    this.num6=num6;
    this.num7=num7; 
    this.num8=num8;
    
}
public override double calculosuma(){
double suma;
suma=num1+num2+num3+num4+num5+num6+num7+num8;
return suma;
} 
}
