﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalOrganisationIdentification1Code.  ISO2002 ID# _ame0hNp-Ed-ak6NoX_4Aeg_-1667686354.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ame0hNp-Ed-ak6NoX_4Aeg_-1667686354")]
[Description(@"Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalOrganisationIdentificationCode))]
public enum ExternalOrganisationIdentification1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BankPartyIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsHdsvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BankPartyIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CentralBankIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsHdtfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CentralBankIdentificationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearingIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsHduPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ClearingIdentificationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CertificateOfIncorporationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsHdu_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CertificateOfIncorporationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CountryIdentificationCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsHdvvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CountryIdentificationCode,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustomerNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsROsvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CustomerNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DataUniversalNumberingSystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsROtfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DataUniversalNumberingSystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EmployerIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsROuPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    EmployerIdentificationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GS1GLNIdentifier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsROu_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    GS1GLNIdentifier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SIREN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsROvvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SIREN,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SIRET".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsaYovRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    SIRET,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tsaYpfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    TaxIdentificationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BusinessDomainIdentifier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kx6PsVEGEey6cYDbEubNXg")]
    [Description(@"??")]
    BusinessDomainIdentifier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BusinessOtherIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_k59YcVEGEey6cYDbEubNXg")]
    [Description(@"??")]
    BusinessOtherIdentification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalOrganisationIdentification1CodeMetadataExtensions
{
    private static readonly ExternalOrganisationIdentification1CodeDropdownSource _dropdownSource = new ExternalOrganisationIdentification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalOrganisationIdentification1CodeDropdownRow GetMetadata(this ExternalOrganisationIdentification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

