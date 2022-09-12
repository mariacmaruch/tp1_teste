namespace Tp1Teste
{
    public class Identifier
    {
		public bool ValidarIdentificador(string id)
		{
			char primeira = id[0];
			bool valido = true;
			if (ValidarPrimeira(primeira) && ((id.Length >= 1) && (id.Length <= 6)))
			{
				for (int i = 1; i < id.Length; i++)
				{
					if (!ValidarCaracteres(id[i]))
					{
						valido = false;
					}
				}
			}
			else
			{
				valido = false;
			}

			if (valido)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool ValidarPrimeira(char primeira)
		{
			char convert = char.ToUpper(primeira);
			if (convert >= 'A' && convert <= 'Z')
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool ValidarCaracteres(char ch)
		{
			char convert = char.ToUpper(ch);
			if ((convert >= 'A' && convert <= 'Z') || (ch >= '0' && ch <= '9'))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
