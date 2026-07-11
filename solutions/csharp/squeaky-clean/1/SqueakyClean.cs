using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var res = new StringBuilder(identifier.Length);
        for(int i = 0; i < identifier.Length; i++){
            if(identifier[i] == ' '){
                res.Append('_');
            }
            else if(char.IsControl(identifier[i])){
                res.Append("CTRL");
            }
            else if(identifier[i] == '-'){
                i++;
                res.Append(char.ToUpper(identifier[i]));
            }
            else if(!char.IsLetter(identifier[i])){
                continue;
            }
            else if(identifier[i] >= '\u03B1' && identifier[i] <= '\u03C9'){
                continue;
            }
            else{
                res.Append(identifier[i]);
            }
        }
        return res.ToString();
    }
}
