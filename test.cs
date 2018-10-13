using System; 
using System.Windows.Forms; 
using System.Net; 
using System.IO;

namespace sdf {


	internal sealed class Program
	{

		[STAThread]
		private static void Main(string[] args)
		{
			string a = "!4m12!1m3!1d13464.536813871084!2d121.0358505!3d14.741168649999999!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i40!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1sWFrBW_PRM9evoASJkbiYDQ%3A39!2zMWk6Mix0OjEyNjk2LGU6MSxwOldGckJXX1BSTTlldm9BU0prYmlZRFE6Mzk!4m1!2i12696!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sTop+rated!5e1!9s0ahUKEwir88O6sYLeAhXVdd4KHVzMC4QQ_KkBCJAEKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn";
			string b = "!4m12!1m3!1d13464.536813871084!2d121.0358505!3d14.741168649999999!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i20!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1sWFrBW_PRM9evoASJkbiYDQ%3A39!2zMWk6Mix0OjEyNjk2LGU6MSxwOldGckJXX1BSTTlldm9BU0prYmlZRFE6Mzk!4m1!2i12696!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sTop+rated!5e1!9s0ahUKEwiB5fWysYLeAhVG7mEKHX9mBvcQ_KkBCIAFKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn";

			for (int i = 0; i < a.Length; i++) {
				if (a [i] != b [i]) {
					Console.WriteLine (i.ToString()+","+a[i]+","+b[i]);
				}
			}
			
			WebClient wc = new WebClient();

			string theurl = "https://www.google.com/search?tbm=map&authuser=0&hl=ru&gl=ph&pb=!4m8!1m3!1d21822.08051138078!2d-96.8411262!3d46.868094!3m2!1i1024!2i768!4f13.1!7i20!8i20!10b1!12m15!2m3!5m1!6e2!20e3!6m8!4b1!7i1!23b1!26i1!27i1!41i2!45b1!49b1!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1szAbAW5SBOZH3hwO9g7PICg%3A21!2zMWk6Mix0OjEyNjk2LGU6MSxwOnpBYkFXNVNCT1pIM2h3TzlnN1BJQ2c6MjE!4m1!2i12696!7e81!24m20!2b1!5m5!2b1!3b1!5b1!6b1!7b0!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!43b0!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i768!1m6!1m2!1i974!2i0!2m2!1i1024!2i768!1m6!1m2!1i0!2i0!2m2!1i1024!2i20!1m6!1m2!1i0!2i748!2m2!1i1024!2i768!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4z0JvRg9GH0YjQuNC1INC-0YbQtdC90LrQuA!5e1!9s0ahUKEwjnu5S-7f_dAhWR-2EKHb3BDKkQ_KkBCOUEKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech="+args[1]+"&psi=zAbAW5SBOZH3hwO9g7PICg.1539311322783.1"; 


			//wc.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);
			//wc.DownloadDataAsync(new Uri(theurl));
			byte[] data = wc.DownloadData(new Uri(theurl));
			MemoryStream stream = new MemoryStream(data);
			string code = string.Empty;

			while(code.Length<=0){
			try{
			StreamReader sr = new StreamReader(stream);

			code = sr.ReadToEnd();
			Console.Write(code);
			sr.Close();
			

			}

			catch{

			}
			}

				
	
		}


				
	static void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
    {
        string filepath = "a.txt";
        System.IO.File.WriteAllBytes(filepath, e.Result);
        System.IO.StreamReader sr = new 
		System.IO.StreamReader(filepath);
        string s = sr.ReadToEnd();
        
        sr.Close();
     
    }


	}
}
