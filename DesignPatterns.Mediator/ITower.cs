namespace DesignPatterns.Mediator;

//Mediator step 1
public interface ITower
{
    List<Airplane> Airplanes { get; set; }
    void Register(Airplane airplane);
    void Remove(Airplane airplane);
    bool AllowChange();
}
