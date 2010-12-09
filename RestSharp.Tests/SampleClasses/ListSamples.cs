﻿using System.Collections.Generic;

namespace RestSharp.Tests.SampleClasses
{
	public class InlineListSample
	{
		public List<image> images { get; set; }
		public List<Image> Images { get; set; }
	}

	public class NestedListSample
	{
		public List<image> images { get; set; }
		public List<Image> Images { get; set; }
	}

    public class InlineArraySample
    {
        public image[] images { get; set; }
        public Image[] Images { get; set; }
    }

    public class NestedArraySample
    {
        public image[] images { get; set; }
        public Image[] Images { get; set; }
    }

	public class Image
	{
		public string Src { get; set; }
		public string Value { get; set; }
	}

	public class image
	{
		public string Src { get; set; }
		public string Value { get; set; }
	}
}
