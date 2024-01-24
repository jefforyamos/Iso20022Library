﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralEntryType1Code.  ISO2002 ID# _O0zXoHvLEemW9qhOy0scyg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the quantity or amount is to be delivered or received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O0zXoHvLEemW9qhOy0scyg")]
[Description(@"Specifies whether the quantity or amount is to be delivered or received.")]
[DerivedFrom(typeof(EntryTypeCode))]
public enum CollateralEntryType1Code
{
    /// <summary>
    /// Financial Instruments or amount are to be delivered out of Party A's account.
    /// Encoded/decoded by serializers as "DELI".
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_Qe13kXvLEemW9qhOy0scyg")]
    [Description(@"Financial Instruments or amount are to be delivered out of Party A's account.|")]
    Delivered = EntryTypeCode.Delivered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial Instruments  or amount are to be received in Party A's account.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_QjH6oXvLEemW9qhOy0scyg")]
    [Description(@"Financial Instruments  or amount are to be received in Party A's account.|")]
    Received = EntryTypeCode.Received, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralEntryType1CodeMetadataExtensions
{
    private static readonly CollateralEntryType1CodeDropdownSource _dropdownSource = new CollateralEntryType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralEntryType1CodeDropdownRow GetMetadata(this CollateralEntryType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


