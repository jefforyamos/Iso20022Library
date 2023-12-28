﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalAccountIdentification1Code.  ISO2002 ID# _amL5ktp-Ed-ak6NoX_4Aeg_-2079691647.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amL5ktp-Ed-ak6NoX_4Aeg_-2079691647")]
[Description(@"Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalAccountIdentificationCode))]
public enum ExternalAccountIdentification1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssuerIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_teaY4vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    IssuerIdentificationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BBANIdentifier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_teaY5fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BBANIdentifier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CHIPSUniversalIdentifier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_teaY6PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CHIPSUniversalIdentifier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UPICIdentifier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_teji0vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    UPICIdentifier,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalAccountIdentification1CodeMetadataExtensions
{
    private static readonly ExternalAccountIdentification1CodeDropdownSource _dropdownSource = new ExternalAccountIdentification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalAccountIdentification1CodeDropdownRow GetMetadata(this ExternalAccountIdentification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

