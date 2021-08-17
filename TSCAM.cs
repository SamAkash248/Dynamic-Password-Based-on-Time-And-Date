using System;
using System.Text;

public class TSCAM
{
	public static string SB(string data)
	{
		StringBuilder sb = new StringBuilder();
		foreach(char c in data.ToCharArray())
        {
			sb.Append(Convert.ToString(2, 0).PadLeft(8, '0'));
        }
		return sb.ToString();
	}
	public static string BS(string data)
    {
		List<Byte> bytelist = new List<byte>();

		for (int i = 0; i < data.Length; i += 8)
        {
			bytelist.Add(Convert.ToByte(data.Substring(i, 8), 2));
        }
		return Encoding.ASCII.GetString(bytelist.ToArray());
    }
}
