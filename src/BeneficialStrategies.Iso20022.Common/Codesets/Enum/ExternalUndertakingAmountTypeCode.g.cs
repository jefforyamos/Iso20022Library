﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingAmountTypeCode.  ISO2002 ID# _-MhZA27iEeKo25nLKvGr8w_1180759625.
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
[IsoId("_-MhZA27iEeKo25nLKvGr8w_1180759625")]
[Description(@"Specifies the external undertaking amount type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalUndertakingAmountTypeCode
{
    /// <summary>
    /// Amount is an increase.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_uQxp-fRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is an increase.")]
    INCR,
    
    /// <summary>
    /// Amount is a reduction.
    /// </summary>
    [EnumMember(Value = "REDC")]
    [IsoId("_uQ7a8PRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is a reduction.")]
    REDC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUndertakingAmountTypeCodeMetadataExtensions
{
    private static readonly ExternalUndertakingAmountTypeCodeDropdownSource _dropdownSource = new ExternalUndertakingAmountTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUndertakingAmountTypeCodeDropdownRow GetMetadata(this ExternalUndertakingAmountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


