﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestSharp
{
	/// <summary>
	/// Container for files to be uploaded with requests
	/// </summary>
	public class FileParameter
	{
		/// <summary>
		/// Raw data for file
		/// </summary>
		public byte[] Data { get; set; }
		/// <summary>
		/// Name of the file to use when uploading
		/// </summary>
		public string FileName { get; set; }
		/// <summary>
		/// MIME content type of file
		/// </summary>
		public string ContentType { get; set; }
	}
}
