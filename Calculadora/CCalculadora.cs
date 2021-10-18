using System;

public class CCalculadora
{
	var operador1;
	var operador2;
	char operacion;

	public int calculadora(var operador1,var operador2,char operacion)
	{
		switch (operacion)
		{
			case "+":
					calculadora = Suma(operador1, operador2);
				break;
			case "-":
					calculadora = Resta(operador1, operador2);
				break;
			case "*":
					calculadora = Multiplicacion(operador1, operador2);
				break;
			case "/":
					calculadora = Division(operador1, operador2);
				break;
		}
	}

	private Suma(operador1, operador2)
	{
		var Suma = operador121 + operador2;
	}

	private Resta(operador1, operador2)
	{
		Resta = operador121 - operador2;
	}

	private Multiplicacion(operador1, operador2)
	{
		Multiplicacion = operador1 * operador2;
	}

	private Division(operador1, operador2)
	{
		Division = operador1 / operador2;
	}

}
