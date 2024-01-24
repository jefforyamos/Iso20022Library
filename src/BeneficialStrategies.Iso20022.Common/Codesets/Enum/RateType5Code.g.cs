﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateType5Code.  ISO2002 ID# _ZZmKotp-Ed-ak6NoX_4Aeg_1481923249.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZmKotp-Ed-ak6NoX_4Aeg_1481923249")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType5Code
{
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZZmKo9p-Ed-ak6NoX_4Aeg_1553034192")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateType5CodeMetadataExtensions
{
    private static readonly RateType5CodeDropdownSource _dropdownSource = new RateType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateType5CodeDropdownRow GetMetadata(this RateType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


