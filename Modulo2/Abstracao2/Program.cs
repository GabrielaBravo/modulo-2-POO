public abstract class Funcionario
{
    public abstract void getBonificacao();
}

public abstract class Secretaria : Funcionario
{

}

public class SecretariaAdministrativa : Secretaria
{
    public override void getBonificacao()
    {
        //..
    }
}

public class SecretariaAgencia : Secretaria
{
    public override void getBonificacao()
    {
        //..
    }
}

public class Presidente : Funcionario
{
    public override void getBonificacao()
    {
        //..
    }
}

public class Gerente : Funcionario
{
    public override void getBonificacao()
    {
        //..
    }
}

public class Diretor : Gerente
{

}