﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisplayMethodCode.  ISO2002 ID# _awUtAtp-Ed-ak6NoX_4Aeg_711015828.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Instructions for the use of display quantity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awUtAtp-Ed-ak6NoX_4Aeg_711015828")]
[Description(@"Instructions for the use of display quantity.")]
public enum DisplayMethodCode
{
    /// <summary>
    /// Indicates that original quantity must be used.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_awUtA9p-Ed-ak6NoX_4Aeg_751651641")]
    [Description(@"Indicates that original quantity must be used.")]
    INIT,
    
    /// <summary>
    /// Indicates that Quantity must be refreshed.
    /// </summary>
    [EnumMember(Value = "NEW1")]
    [IsoId("_awUtBNp-Ed-ak6NoX_4Aeg_1093354350")]
    [Description(@"Indicates that Quantity must be refreshed.")]
    NEW1,
    
    /// <summary>
    /// Randomize value.
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_awUtBdp-Ed-ak6NoX_4Aeg_1226340443")]
    [Description(@"Randomize value.")]
    RAND,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisplayMethodCodeMetadataExtensions
{
    private static readonly DisplayMethodCodeDropdownSource _dropdownSource = new DisplayMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisplayMethodCodeDropdownRow GetMetadata(this DisplayMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


