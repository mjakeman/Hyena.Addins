//
// DependencyCollection.cs
//
// Author:
//   Lluis Sanchez Gual
//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;

namespace Hyena.Addins.Description
{
	/// <summary>
	/// A collection of dependency definitions.
	/// </summary>
	public class DependencyCollection: ObjectDescriptionCollection<Dependency>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DependencyCollection"/> class.
		/// </summary>
		public DependencyCollection ()
		{
		}
		
		internal DependencyCollection (object owner): base (owner)
		{
		}
		
		/// <summary>
		/// Gets the <see cref="Dependency"/> at the specified index.
		/// </summary>
		/// <param name='n'>
		/// The idnex.
		/// </param>
		public Dependency this [int n] {
			get { return (Dependency) List [n]; }
		}
		
		/// <summary>
		/// Adds a dependency to the collection
		/// </summary>
		/// <param name='dep'>
		/// The dependency to add.
		/// </param>
		public void Add (Dependency dep)
		{
			List.Add (dep);
		}
		
		/// <summary>
		/// Remove the specified dependency.
		/// </summary>
		/// <param name='dep'>
		/// Dependency to remove.
		/// </param>
		public void Remove (Dependency dep)
		{
			List.Remove (dep);
		}
	}
}
