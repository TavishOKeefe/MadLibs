namespace MadLibs.Models
{
  public class WordVariable
  {
    private string _noun;
    private string _verb;
    private string _adjective;

    public string GetNoun(){
      return _noun;
    }
    public void SetNoun(string noun){
      _noun = noun;
    }
    public string GetVerb(){
      return _verb;
    }
    public void SetVerb(string verb){
      _verb = verb;
    }
    public string GetAdjective(){
      return _adjective;
    }
    public void SetAdjective(string adjective){
      _adjective = adjective;
    }
  }
}
