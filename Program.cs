using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Text.RegularExpressions;

namespace PerformanceTest {



	public static class Program {
		public static void Main(string[] _) {
			BenchmarkRunner.Run<RemoveChars>();

		}
	}



	//[SimpleJob(RuntimeMoniker.Net462, baseline: true)]
	//[SimpleJob(RuntimeMoniker.Net48)]
	[SimpleJob(RuntimeMoniker.Net60)]
	[RPlotExporter]
	public class RemoveChars {
		private static readonly char[] _invalidChars = new[] { 'j', 'a', 'n' };
		private static readonly string _textToStrip = "The quick brown fox jumps over the lazy dog";

		private static readonly HashSet<char> _invalidHash = new(new[] { 'j', 'a', 'n' });


		[Benchmark]
		public string LinqToArray() {
			return new string(_textToStrip.Where(x => !_invalidChars.Contains(x)).ToArray());
		}


		[Benchmark]
		public string ForEach() {
			string ret = _textToStrip;
			foreach(char c in _invalidChars) {
				ret = ret.Replace(Convert.ToString(c), "");
			}
			return ret;
		}

		[Benchmark]
		public string Regexer() {
			return Regex.Replace(_textToStrip, $"[{new string(_invalidChars) }]", string.Empty);
		}

		[Benchmark]
		public string Hasher() {
			return new string(_textToStrip.Where(x => _invalidHash.Contains(x)).ToArray());
		}

		[Benchmark]

		public string Splitting() {
			return string.Join(string.Empty, _textToStrip.Split(_invalidChars, StringSplitOptions.RemoveEmptyEntries));
		}

		[Benchmark]
		public string Aggregate() {
			return _invalidChars.Aggregate(_textToStrip, (c1, c2) => c1.Replace(Convert.ToString(c2), ""));
		}
	}


}