class Cryptographer
{
	// Encrypts/decrypts string depends on parameter. If bool value is true -
	// function shall encrypt string, if false - shall decrypt
	public string Change(string value, int key, bool encrypt)
	{
		char[] result = value.ToCharArray();

		if (encrypt == true)
			for (int i = 0; i < result.Length; i++)
				result[i] = (char)(((int)result[i] + key) % 128);
		else
			for (int i = 0; i < result.Length; i++)
				result[i] = (char)(((int)result[i] - key) % 128);

		return result.ToString();
	}
}
