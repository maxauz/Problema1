using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class ChangeString
    {

            public static string build(string parametroEntrada){
    string salida="";
                char[] abecedario={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z'};
                char[] abecedarioMayuscula = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','V','W','X','Y','Z' };
                int cantidad=abecedario.Count();

                char[] arrayParametroEntrada = parametroEntrada.ToCharArray();


                foreach(char caracter in arrayParametroEntrada){


                    int posicion = 0;
                    if (Char.IsUpper(caracter))
                    {
                        
                        posicion=Array.IndexOf(abecedarioMayuscula, caracter);
                    }
                    else
                    {
                        
                        posicion=Array.IndexOf(abecedario, caracter);
                    }
                  


                    if ( posicion== -1)
                    {
                        salida += caracter;
                    }
                    else {
                        if (cantidad == posicion + 1)
                            posicion = 0;
                        else
                            posicion += 1;


                        if(Char.IsUpper(caracter)){
                            salida += abecedarioMayuscula[posicion];
                        }else{
                        salida += abecedario[posicion];
                        }

                        
                        
                    
                    }



                }
               

    return salida;

}

    

    }




}
