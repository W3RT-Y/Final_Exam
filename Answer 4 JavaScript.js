let a = 0, b = 1, result;
for (let i = 1; i <= 20; i++) 
{
    result = a + b;
    a = b;
    b = result;
    if((a<1000))
    {console.log(a);}
}