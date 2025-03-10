﻿#region Using directives
#endregion

namespace Blazorise.DataGrid;

/// <summary>
/// Represents the base class for cancellable events when datagrid item is saving.
/// </summary>
/// <typeparam name="TItem">Model type param.</typeparam>
/// <typeparam name="TValues">Values type param.</typeparam>
public class CancellableRowChange<TItem, TValues> : CancellableRowChange<TItem>
{
    /// <summary>
    /// Initializes a new instance of the cancelable event argument.
    /// </summary>
    /// <param name="item">Saved item.</param>
    /// <param name="values">Edited values.</param>
    public CancellableRowChange( TItem item, TValues values )
        : base( item )
    {
        Values = values;
    }

    /// <summary>
    /// Values that are being edited by the datagrid.
    /// </summary>
    public TValues Values { get; }
}