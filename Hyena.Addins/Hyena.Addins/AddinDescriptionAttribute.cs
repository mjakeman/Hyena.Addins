// 
// AddinDescriptionAttribute.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2011 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

namespace Hyena.Addins
{
	/// <summary>
	/// Describes the purpose of an add-in or add-in root
	/// </summary>
	[AttributeUsage (AttributeTargets.Assembly, AllowMultiple = true)]
	public class AddinDescriptionAttribute: Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddinDescriptionAttribute"/> class.
		/// </summary>
		/// <param name='description'>
		/// Description of the add-in
		/// </param>
		public AddinDescriptionAttribute (string description)
		{
			Description = description;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AddinDescriptionAttribute"/> class.
		/// </summary>
		/// <param name='description'>
		/// Description of the add-in
		/// </param>
		/// <param name='locale'>
		/// Locale of the description (for example, 'en-US', or 'en')
		/// </param>
		public AddinDescriptionAttribute (string description, string locale)
		{
			Description = description;
			Locale = locale;
		}
		
		/// <value>
		/// Description of the add-in
		/// </value>
		public string Description { get; set; }

		/// <summary>
		/// Locale of the description (for example, 'en-US', or 'en')
		/// </summary>
		public string Locale { get; set; }
	}
}

