﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BookPriorityIndicatorCode.  ISO2002 ID# _bVIDMtp-Ed-ak6NoX_4Aeg_335335591.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if a Cancel/Replace instruction has caused an order to loose its book priority.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVIDMtp-Ed-ak6NoX_4Aeg_335335591")]
[Description(@"Indicates if a Cancel/Replace instruction has caused an order to loose its book priority.")]
public enum BookPriorityIndicatorCode
{
    /// <summary>
    /// Indicates that the book priority is unchanged.
    /// Encoded/decoded by serializers as "UNCH".
    /// </summary>
    [EnumMember(Value = "UNCH")]
    [IsoId("_bVIDM9p-Ed-ak6NoX_4Aeg_335335592")]
    [Description(@"Indicates that the book priority is unchanged.")]
    Unchanged,
    
    /// <summary>
    /// Indicates that the book priority is lost as a result of an order change.
    /// Encoded/decoded by serializers as "LOST".
    /// </summary>
    [EnumMember(Value = "LOST")]
    [IsoId("_bVIDNNp-Ed-ak6NoX_4Aeg_335335601")]
    [Description(@"Indicates that the book priority is lost as a result of an order change.")]
    Lost,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BookPriorityIndicatorCodeMetadataExtensions
{
    private static readonly BookPriorityIndicatorCodeDropdownSource _dropdownSource = new BookPriorityIndicatorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBookPriorityIndicatorCodeDropdownRow GetMetadata(this BookPriorityIndicatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


