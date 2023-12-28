﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingAmountType1Code.  ISO2002 ID# _-MhZAm7iEeKo25nLKvGr8w_-1404704925.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external undertaking amount type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MhZAm7iEeKo25nLKvGr8w_-1404704925")]
[Description(@"Specifies the external undertaking amount type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUndertakingAmountTypeCode))]
public enum ExternalUndertakingAmountType1Code
{
    /// <summary>
    /// Amount is an increase.
    /// Encoded/decoded by serializers as "Increase".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_uQxp-_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount is an increase.")]
    Increase,
    
    /// <summary>
    /// Amount is a reduction.
    /// Encoded/decoded by serializers as "Reduction".
    /// </summary>
    [EnumMember(Value = "REDC")]
    [IsoId("_uQ7a8vRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is a reduction.")]
    Reduction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUndertakingAmountType1CodeMetadataExtensions
{
    private static readonly ExternalUndertakingAmountType1CodeDropdownSource _dropdownSource = new ExternalUndertakingAmountType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUndertakingAmountType1CodeDropdownRow GetMetadata(this ExternalUndertakingAmountType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


