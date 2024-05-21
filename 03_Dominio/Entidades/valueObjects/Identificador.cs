using System;

public class Identificador
{
	private Guid valor;

	public Identificador(Guid valor)
	{
		this.valor = valor;	
	}

	public Guid Valor() 
	{ 
		return valor; 
	}
}
