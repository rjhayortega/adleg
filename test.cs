using System; 
using System.Windows.Forms; 
using System.Net; 
using System.IO;
using System.Collections.Generic;

namespace sdf {


	internal sealed class Program
	{


		[STAThread]
		private static void Main(string[] args)
		{

			Dictionary<int,string> links = new Dictionary<int, string> ();

		
		 links.Add (1, "https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m12!1m3!1d23431652.442613985!2d-133.42289803525819!3d34.738391294629004!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i0!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1stgjCW9OAE5fZhwOBmI7IDw%3A325!2zMWk6MSx0OjEyNjk3LGU6MCxwOnRnakNXOU9BRTVmWmh3T0JtSTdJRHc6MzI1!4m1!2i12697!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwj1goPa2IPeAhUEUd4KHUJqAmgQ_KkBCI8EKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=11&psi=tgjCW9OAE5fZhwOBmI7IDw.1539442878950.1");

			links.Add (2, "https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m12!1m3!1d23431652.442613985!2d-133.42289803525819!3d34.738391294629004!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i20!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1stgjCW9OAE5fZhwOBmI7IDw%3A325!2zMWk6MSx0OjEyNjk3LGU6MCxwOnRnakNXOU9BRTVmWmh3T0JtSTdJRHc6MzI1!4m1!2i12697!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwjXyqi92IPeAhUXUt4KHapyC0MQ_KkBCJ0EKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=10&psi=tgjCW9OAE5fZhwOBmI7IDw.1539442878950.1");

			links.Add (3, "https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m9!1m3!1d13462.982637975561!2d121.1538563!3d14.766283300000001!2m0!3m2!1i959!2i670!4f13.1!7i20!8i40!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1stgjCW9OAE5fZhwOBmI7IDw%3A38!2zMWk6Mix0OjEyNjk2LGU6MSxwOnRnakNXOU9BRTVmWmh3T0JtSTdJRHc6Mzg!4m1!2i12696!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwjA1Ynj14PeAhVB-WEKHUkPCmwQ_KkBCIgFKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=5&psi=tgjCW9OAE5fZhwOBmI7IDw.1539442878950.1");
			links.Add (4, "https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m12!1m3!1d23431652.442613985!2d-133.42289803525819!3d34.738391294629004!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i60!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1stgjCW9OAE5fZhwOBmI7IDw%3A325!2zMWk6Mix0OjEyNjk2LGU6MSxwOnRnakNXOU9BRTVmWmh3T0JtSTdJRHc6MzI1!4m1!2i12696!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwiOz4LO2YPeAhVCMt4KHTuoC_cQ_KkBCJ0EKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=14&psi=tgjCW9OAE5fZhwOBmI7IDw.1539442878950.1");


			zlinks.Add (5, "https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m12!1m3!1d1438534.0049523117!2d-116.24813196973172!3d36.17632324496905!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i60!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1stgjCW9OAE5fZhwOBmI7IDw%3A745!2zMWk6Mix0OjEyNjk2LGU6MSxwOnRnakNXOU9BRTVmWmh3T0JtSTdJRHc6NzQ1!4m1!2i12696!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwjJw9bY24PeAhUEa94KHa-TB7UQ_KkBCO8DKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=34&psi=tgjCW9OAE5fZhwOBmI7IDw.1539442878950.1");
			links.Add (6, "https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m12!1m3!1d1438534.0049523117!2d-116.24813196973172!3d36.17632324496905!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i80!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1stgjCW9OAE5fZhwOBmI7IDw%3A745!2zMWk6Mix0OjEyNjk2LGU6MSxwOnRnakNXOU9BRTVmWmh3T0JtSTdJRHc6NzQ1!4m1!2i12696!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwiYjvjj24PeAhUCa94KHd7PDJYQ_KkBCI0DKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=35&psi=tgjCW9OAE5fZhwOBmI7IDw.1539442878950.1");
			links.Add(7,"https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m12!1m3!1d1438534.0049523117!2d-116.24813196973172!3d36.17632324496905!2m3!1f0!2f0!3f0!3m2!1i959!2i670!4f13.1!7i20!8i100!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1stgjCW9OAE5fZhwOBmI7IDw%3A745!2zMWk6Mix0OjEyNjk2LGU6MSxwOnRnakNXOU9BRTVmWmh3T0JtSTdJRHc6NzQ1!4m1!2i12696!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwi6-86f3oPeAhXPAIgKHRtYDwYQ_KkBCJsEKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=44&psi=tgjCW9OAE5fZhwOBmI7IDw.1539442878950.1");

				
			links.Add (8, "https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m9!1m3!1d13465.981661476788!2d121.06217474999998!3d14.717783099999998!2m0!3m2!1i959!2i670!4f13.1!7i20!8i40!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1sVtTCW5_NNcT58QXszIjgCg%3A29!2zMWk6MSx0OjEyNjk3LGU6MCxwOlZ0VENXNV9OTmNUNThRWHN6SWpnQ2c6Mjk!4m1!2i12697!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwjWweaFmoXeAhWIbrwKHRNpCSkQ_KkBCLQDKBA!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=6&psi=VtTCW5_NNcT58QXszIjgCg.1539495009327.1");
			links.Add(9,"https://www.google.com/search?tbm=map&authuser=0&hl=fil&gl=ph&pb=!4m9!1m3!1d13465.981661476788!2d121.06217474999998!3d14.717783099999998!2m0!3m2!1i959!2i670!4f13.1!7i20!8i20!10b1!12m6!2m3!5m1!6e2!20e3!10b1!16b1!19m3!2m2!1i392!2i106!20m57!2m2!1i203!2i100!3m2!2i4!5b1!6m6!1m2!1i86!2i86!1m2!1i408!2i200!7m42!1m3!1e1!2b0!3e3!1m3!1e2!2b1!3e2!1m3!1e2!2b0!3e3!1m3!1e3!2b0!3e3!1m3!1e8!2b0!3e3!1m3!1e3!2b1!3e2!1m3!1e9!2b1!3e2!1m3!1e10!2b0!3e3!1m3!1e10!2b1!3e2!1m3!1e10!2b0!3e4!2b1!4b1!9b0!22m5!1sVtTCW5_NNcT58QXszIjgCg%3A29!2zMWk6MSx0OjEyNjk3LGU6MCxwOlZ0VENXNV9OTmNUNThRWHN6SWpnQ2c6Mjk!4m1!2i12697!7e81!24m18!2b1!5m4!2b1!3b1!5b1!6b1!10m1!8e3!14m1!3b1!17b1!24b1!25b1!26b1!30m1!2b1!36b1!52b1!26m3!2m2!1i80!2i92!30m28!1m6!1m2!1i0!2i0!2m2!1i458!2i670!1m6!1m2!1i909!2i0!2m2!1i959!2i670!1m6!1m2!1i0!2i0!2m2!1i959!2i20!1m6!1m2!1i0!2i650!2m2!1i959!2i670!34m5!3b1!4b1!6b1!8m1!1b1!37m1!1e81!42b1!46m1!1e10!47m0!49m1!3b1!50m12!1m11!2m7!1u2!4sMataas+na+rating!5e1!9s0ahUKEwiR1sGhmoXeAhVGw7wKHb5qC04Q_KkBCJ0EKBY!10m2!2m1!1e1!3m1!1u2!4BIAE!59BQ2dBd0Fn&q="+args[0]+"&tch=1&ech=7&psi=VtTCW5_NNcT58QXszIjgCg.1539495009327.1");

		



			WebClient wc = new WebClient();



			//wc.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);
			//wc.DownloadDataAsync(new Uri(theurl));
			byte[] data = wc.DownloadData(new Uri(links[int.Parse(args[1])]));

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
