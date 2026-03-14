public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        string codificado = "";

        if(input.Length > 0){
            char letra_base = input[0];
            int cant = 0;
            for(int i = 0 ; i <= input.Length -1 ; i ++){
                
               if(letra_base == input[i]){
                    cant ++;
                }else{
                   if (cant == 1){
                        codificado += $"{letra_base}";
                   }else{
                        codificado += $"{cant}{letra_base}";
                   }
                   cant = 1;
                   letra_base = input[i];
                }
            }
            if (cant == 1){
                codificado += $"{letra_base}";
            }else{
                codificado += $"{cant}{letra_base}";
            }
        }

        return codificado;
    }

    public static string Decode(string input)
    {
        int cant = 1;
        string cantidad_string = "";
        string decodificado = "";

        for(int i = 0 ; i < input.Length ; i++)
        {
            
            if (char.IsDigit(input[i]) == true)
            {
                cantidad_string += $"{input[i]}";
            }else
            {
                if(cantidad_string.Length > 0){
                    cant = int.Parse(cantidad_string);
                }
                
                for(int j = 1; j <= cant ; j++)
                {
                    decodificado += $"{input[i]}";
                }

                cant = 1;
                cantidad_string = "";
            }
        }
        
        return decodificado;
    }
}
