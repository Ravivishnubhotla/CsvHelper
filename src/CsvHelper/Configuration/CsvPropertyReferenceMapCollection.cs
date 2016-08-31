﻿#if !NET_2_0
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace CsvHelper.Configuration
{
	/// <summary>
	/// A collection that holds <see cref="CsvPropertyReferenceMap"/>'s.
	/// </summary>
	[DebuggerDisplay( "Count = {list.Count}" )]
	public class CsvPropertyReferenceMapCollection : IList<CsvPropertyReferenceMap>
    {
	    private readonly List<CsvPropertyReferenceMap> list = new List<CsvPropertyReferenceMap>();

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
		public virtual int Count => list.Count;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only; otherwise, false.</returns>
		public virtual bool IsReadOnly => false;

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <returns>The element at the specified index.</returns>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.Generic.IList`1" /> is read-only.</exception>
		public virtual CsvPropertyReferenceMap this[int index]
		{
			get { return list[index]; }
			set { list[index] = value; }
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual IEnumerator<CsvPropertyReferenceMap> GetEnumerator()
	    {
		    return list.GetEnumerator();
	    }

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		/// <filterpriority>2</filterpriority>
		IEnumerator IEnumerable.GetEnumerator()
	    {
		    return GetEnumerator();
	    }

		/// <summary>Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</exception>
		public virtual void Add( CsvPropertyReferenceMap item )
	    {
		    list.Add( item );
	    }

		/// <summary>Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only. </exception>
		public virtual void Clear()
	    {
		    list.Clear();
	    }

		/// <summary>Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.</summary>
		/// <returns>true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.</returns>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		public virtual bool Contains( CsvPropertyReferenceMap item )
	    {
		    return list.Contains( item );
	    }

		/// <summary>Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="arrayIndex" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.Generic.ICollection`1" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.</exception>
		public virtual void CopyTo( CsvPropertyReferenceMap[] array, int arrayIndex )
	    {
		    list.CopyTo( array, arrayIndex );
	    }

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <returns>true if <paramref name="item" /> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false. This method also returns false if <paramref name="item" /> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
		/// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</exception>
		public virtual bool Remove( CsvPropertyReferenceMap item )
	    {
		    return list.Remove( item );
	    }

		/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1" />.</summary>
		/// <returns>The index of <paramref name="item" /> if found in the list; otherwise, -1.</returns>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1" />.</param>
		public virtual int IndexOf( CsvPropertyReferenceMap item )
	    {
		    return list.IndexOf( item );
	    }

		/// <summary>Inserts an item to the <see cref="T:System.Collections.Generic.IList`1" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1" /> is read-only.</exception>
		public virtual void Insert( int index, CsvPropertyReferenceMap item )
	    {
		    list.Insert( index, item );
	    }

		/// <summary>Removes the <see cref="T:System.Collections.Generic.IList`1" /> item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1" /> is read-only.</exception>
		public virtual void RemoveAt( int index )
	    {
		    list.RemoveAt( index );
	    }

		/// <summary>
		/// Finds the <see cref="CsvPropertyReferenceMap"/> using the given property expression.
		/// </summary>
		/// <typeparam name="T">The <see cref="System.Type"/> the property is on.</typeparam>
		/// <param name="expression">The property expression.</param>
		/// <returns>The <see cref="CsvPropertyReferenceMap"/> for the given expression, or null if not found.</returns>
		public virtual CsvPropertyReferenceMap Find<T>( Expression<Func<T, object>> expression )
		{
			var property = ReflectionHelper.GetProperty( expression );
			return Find( property );
		}

		/// <summary>
		/// Finds the <see cref="CsvPropertyReferenceMap"/> using the given property.
		/// </summary>
		/// <param name="property">The property.</param>
		/// <returns>The <see cref="CsvPropertyReferenceMap"/> for the given expression, or null if not found.</returns>
		public virtual CsvPropertyReferenceMap Find( PropertyInfo property )
	    {
			var existingMap = list.SingleOrDefault( m =>
				m.Data.Property == property ||
				m.Data.Property.Name == property.Name &&
				(
					m.Data.Property.DeclaringType.IsAssignableFrom( property.DeclaringType ) ||
					property.DeclaringType.IsAssignableFrom( m.Data.Property.DeclaringType )
				)
			);

			return existingMap;
	    }
	}
}

#endif