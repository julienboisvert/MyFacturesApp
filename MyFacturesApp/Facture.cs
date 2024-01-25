namespace MyFacturesApp;

public class Facture
{
    private string _description { get; set; }
    private float _prixFacture { get; set; }
    private DateTime _dateFacture { get; set; }
    
    public Facture(string description, float prixFacture, DateTime dateFacture)
    {
        _description = description;
        _prixFacture = prixFacture;
        _dateFacture = dateFacture;
    }
    
}