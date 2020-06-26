class Cryptographer
{
	char[] result;
	int key;

	public Cryptographer(string value, int key)
	{
		result = value.ToCharArray();
		this.key = key;
	}

	// Encrypts string by Caesar's chiphre
	public string Encrypt()
	{
		for (int i = 0; i < result.Length; i++)
			result[i] = (char)(((int)result[i] + key) % 128);

		return new System.String(result);
	}

	public string Decrypt()
	{
		for (int i = 0; i < result.Length; i++)
			result[i] = (char)(((int)result[i] - key) % 128);

		return new System.String(result);
	}
}
