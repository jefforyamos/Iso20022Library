﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdjustmentDirection1Code.  ISO2002 ID# _bnKOYNp-Ed-ak6NoX_4Aeg_-559278803.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the adjustment is added or subtracted to the total amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnKOYNp-Ed-ak6NoX_4Aeg_-559278803")]
[Description(@"Specifies whether the adjustment is added or subtracted to the total amount.")]
[DerivedFrom(typeof(AdjustmentDirectionCode))]
public enum AdjustmentDirection1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Added".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bnKOYdp-Ed-ak6NoX_4Aeg_-512177233")]
    [Description(@"??")]
    Added,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Substracted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bnKOYtp-Ed-ak6NoX_4Aeg_-512177198")]
    [Description(@"??")]
    Substracted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdjustmentDirection1CodeMetadataExtensions
{
    private static readonly AdjustmentDirection1CodeDropdownSource _dropdownSource = new AdjustmentDirection1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdjustmentDirection1CodeDropdownRow GetMetadata(this AdjustmentDirection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

