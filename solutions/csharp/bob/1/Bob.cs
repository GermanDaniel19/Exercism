public static class Bob
{
    public static string Response(string statement)
    {
        //1. limpiamos
        string clear = statement.Trim();

        //Pregunta?
        bool isQuestion = clear.EndsWith("?");
        //vacio?
        bool isSilence = string.IsNullOrWhiteSpace(clear);
        //minusculas?
        bool isShouting = clear.Any(char.IsLetter) && !clear.Any(char.IsLower);

        if (isSilence){
            return "Fine. Be that way!";
        }else if (isQuestion && isShouting){
            return "Calm down, I know what I'm doing!";
        }else if (isShouting ){
            return "Whoa, chill out!";
        }else if(!isShouting && isQuestion)
            return "Sure.";
        else{
            return "Whatever.";
        }
    }
}