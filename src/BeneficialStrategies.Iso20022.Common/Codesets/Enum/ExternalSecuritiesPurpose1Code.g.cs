﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalSecuritiesPurpose1Code.  ISO2002 ID# _P30nADceEeOA3chqL9a4Rw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason code for an SSI instruction, in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_P30nADceEeOA3chqL9a4Rw")]
[Description(@"Specifies the underlying reason code for an SSI instruction, in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalSecuritiesPurposeCode))]
public enum ExternalSecuritiesPurpose1Code
{
    /// <summary>
    /// Relates to collateral management.
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_uU8YS_RYEeuLhpyIdtJzwg")]
    [Description(@"Relates to collateral management.")]
    CollateralManagement = ExternalSecuritiesPurposeCode.CollateralManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to securities lending.
    /// Encoded/decoded by serializers as "SECL".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_uVGJQvRYEeuLhpyIdtJzwg")]
    [Description(@"Relates to securities lending.")]
    SecuritiesLending = ExternalSecuritiesPurposeCode.SecuritiesLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to settlements.
    /// Encoded/decoded by serializers as "STMT".
    /// </summary>
    [EnumMember(Value = "STMT")]
    [IsoId("_uVGJRfRYEeuLhpyIdtJzwg")]
    [Description(@"Relates to settlements.")]
    Settlements = ExternalSecuritiesPurposeCode.Settlements, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalSecuritiesPurpose1CodeMetadataExtensions
{
    private static readonly ExternalSecuritiesPurpose1CodeDropdownSource _dropdownSource = new ExternalSecuritiesPurpose1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalSecuritiesPurpose1CodeDropdownRow GetMetadata(this ExternalSecuritiesPurpose1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


