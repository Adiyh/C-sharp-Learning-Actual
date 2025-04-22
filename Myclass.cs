class Myclass{


Test1(){
for(int i=0;i<=10;i++)
{
Console.WriteLine(i);
}

Test2(){
for(int i=0;i<=50;i++)
{
Console.WriteLine(i);
if(i==30){
Console.WriteLine("Thread going to sleep");
Thread.Sleep(5000);
Console.WriteLine("Thread going to start");
}
}

Test3(){
for(int i=0;i<=10;i++)
{
Console.WriteLine(i);
}

}



public static void Main(String[] args){

Test1();
Test2();
Test3();




}




}