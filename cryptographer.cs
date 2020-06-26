class Cryptographer
{
	char[] result;

	public Cryptographer(string value)
	{
		result = value.ToCharArray();
	}

	// Encrypts string by Caesar's chiphre
	public string Encrypt(string value, int key)
	{
		for (int i = 0; i < result.Length; i++)
			result[i] = (char)(((int)result[i] + key) % 128);

		return result.ToString();
	}

	public string Decrypt(string value, int key)
	{
		for (int i = 0; i < result.Length; i++)
			result[i] = (char)(((int)result[i] - key) % 128);

		return result.ToString();
	}
}
