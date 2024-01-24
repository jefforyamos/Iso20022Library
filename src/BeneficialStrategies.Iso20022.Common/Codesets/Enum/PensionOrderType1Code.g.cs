﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PensionOrderType1Code.  ISO2002 ID# _bGxkcLTqEeiENt6AoDfPXg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of order attached to a pension.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bGxkcLTqEeiENt6AoDfPXg")]
[Description(@"Specifies a type of order attached to a pension.")]
[DerivedFrom(typeof(PensionOrderTypeCode))]
public enum PensionOrderType1Code
{
    /// <summary>
    /// Pension policy, plan or scheme has been earmarked (set aside.)
    /// Encoded/decoded by serializers as "EARM".
    /// </summary>
    [EnumMember(Value = "EARM")]
    [IsoId("_j14EwbT5EeiENt6AoDfPXg")]
    [Description(@"Pension policy, plan or scheme has been earmarked (set aside.)")]
    Earmark = PensionOrderTypeCode.Earmark, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sharing order for the pension policy, plan or scheme has been issued by a court.
    /// Encoded/decoded by serializers as "SHAR".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_j7FU4bT5EeiENt6AoDfPXg")]
    [Description(@"Sharing order for the pension policy, plan or scheme has been issued by a court.")]
    Sharing = PensionOrderTypeCode.Sharing, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PensionOrderType1CodeMetadataExtensions
{
    private static readonly PensionOrderType1CodeDropdownSource _dropdownSource = new PensionOrderType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPensionOrderType1CodeDropdownRow GetMetadata(this PensionOrderType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


