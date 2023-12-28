﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType9Code.  ISO2002 ID# _qd8KkeEPEd-1Ktb5rVaajw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of price value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qd8KkeEPEd-1Ktb5rVaajw")]
[Description(@"Specifies a type of price value.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType9Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ToBeSpecified".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5bEM2tdEeCY4-KZ9JEyUQ_-401797513")]
    [Description(@"??")]
    ToBeSpecified,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unspecified".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5bENGtdEeCY4-KZ9JEyUQ_-519195689")]
    [Description(@"??")]
    Unspecified,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q5bENWtdEeCY4-KZ9JEyUQ_-1516268042")]
    [Description(@"??")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType9CodeMetadataExtensions
{
    private static readonly PriceValueType9CodeDropdownSource _dropdownSource = new PriceValueType9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType9CodeDropdownRow GetMetadata(this PriceValueType9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

