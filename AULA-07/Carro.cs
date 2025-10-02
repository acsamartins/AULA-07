public class Carro
{
    public int Id;
    public string marca;
    public string modelo;
    private string Placa;
    public string renavan;
    private string chassi;






    public void Setplaca(string placa)
    {
        if (char.IsLetter(placa[0]) &&
            char.IsLetter(placa[1]) &&
            char.IsLetter(placa[2]) &&
            char.IsNumber(placa[3]) && char.IsNumber(placa[2]) &&
       char.IsNumber(placa[3]))

        {
            Console.WriteLine("teste");
            Placa = placa;
        }
        else
        {
            throw new Exception("Placa ivalida");
        }



    }


    public string Getplaca()
    {
        return Placa;
    }



    public void SetChassi(string Chassi) /// colocar o atributo em private
    {
        chassi = chassi.ToLower();
        if (chassi.Length != 17 && !chassi.Contains("O") && !chassi.Contains("I") && !chassi.Contains("q")) ;

        {
            throw new Exception("Chassi inválido");
        }
        chassi = Chassi;
    }

    public string GetChassi()
    {
        return chassi;
    }

    public Carro(string chassi)
    {
        SetChassi(chassi);
    }


    public Carro(int id, string Marca, string Modelo, string Placa, string Renavan, string Chassi)
    {
        SetChassi(chassi);
        Id = id;
        marca = Marca;
        modelo = Modelo;
        this.Placa = Placa;
        renavan = Renavan;
        chassi = Chassi;
    }









}