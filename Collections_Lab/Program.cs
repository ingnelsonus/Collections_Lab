
//Retorna valor.
//Func<int,int> fnlambda = (a) => a * 2;
//Console.WriteLine(fnlambda(2));    


///No retorna ningun valor
//Action fnlamda = () => Console.WriteLine("Hola from lambda");
//fnlamda();

///Retorna un valor booleano.
//Predicate<int> fnbool = (a) => a>1?true:false;
//Console.WriteLine(fnbool(1));

//Mejorar apartir de c# 10
//var fn=bool(int a) => a>1?true:false;
//Console.WriteLine(fn(2));

//Comparativo c#9 suma vs c#10 sum2
//Func<int, int, int> suma = (a, b) => a + b;
//var sum2=(int a,int b)=>a+ b;

//guardar una funcion nativa.
//var pow = Math.Pow;

//retorno hibrido. retornamos 1 o "0"
//var p = object (bool e) => e ? 1 : "0";
//Console.WriteLine(p(false).GetType());

//var closure = Action (int n) =>
//{
//    int i = 0;

//    return () =>
//    {
//        i++;

//        if (i < n)
//            Console.WriteLine($"Se ejecuto {i}");
//        else
//            Console.WriteLine("Se terminaron las ejecuciones");        
//    };
//};

//var executor = closure(2);
//executor();
//executor();

