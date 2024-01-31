﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PersonIdentificationTypeV2Code.  ISO2002 ID# _aHCfdtp-Ed-ak6NoX_4Aeg_-1069011326.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHCfdtp-Ed-ak6NoX_4Aeg_-1069011326")]
[Description(@"Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.")]
[Derivations(typeof(PersonIdentificationType3Code))]
public enum PersonIdentificationTypeV2Code
{
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as "CCPT".
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_aHCfd9p-Ed-ak6NoX_4Aeg_-1026529330")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber,
    
    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as "CPFA".
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_aHCfeNp-Ed-ak6NoX_4Aeg_-1026529329")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber,
    
    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as "SRSA".
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_aHCfedp-Ed-ak6NoX_4Aeg_-1026529299")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber,
    
    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as "NRIN".
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_aHMQcNp-Ed-ak6NoX_4Aeg_-1026529268")]
    [Description(@"National registration identification number. In Singapore this is known as the NRIC.")]
    NationalRegistrationIdentificationNumber,
    
    /// <summary>
    /// Another type of identification type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aHMQcdp-Ed-ak6NoX_4Aeg_-1026529267")]
    [Description(@"Another type of identification type.")]
    Other,
    
    /// <summary>
    /// Number assigned by a license authority to a driver's license.
    /// Encoded/decoded by serializers as "DRLC".
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_aHMQctp-Ed-ak6NoX_4Aeg_-1026529238")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber,
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as "SOCS".
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_aHMQc9p-Ed-ak6NoX_4Aeg_-1026529207")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "ARNU".
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_aHMQdNp-Ed-ak6NoX_4Aeg_-1026528929")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as "IDCD".
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_aHMQddp-Ed-ak6NoX_4Aeg_-1026528898")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as "EMID".
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_aHMQdtp-Ed-ak6NoX_4Aeg_-1026528867")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber,
    
    /// <summary>
    /// Number assigned to a foreign investor (other than the alien number).
    /// Encoded/decoded by serializers as "FINN".
    /// </summary>
    [EnumMember(Value = "FINN")]
    [IsoId("_aHMQd9p-Ed-ak6NoX_4Aeg_-998823061")]
    [Description(@"Number assigned to a foreign investor (other than the alien number).")]
    ForeignInvestmentIdentityNumber,
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as "TXID".
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_aHMQeNp-Ed-ak6NoX_4Aeg_-998823000")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,
    
    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_aHWBcNp-Ed-ak6NoX_4Aeg_177812978")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PersonIdentificationTypeV2CodeMetadataExtensions
{
    private static readonly PersonIdentificationTypeV2CodeDropdownSource _dropdownSource = new PersonIdentificationTypeV2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPersonIdentificationTypeV2CodeDropdownRow GetMetadata(this PersonIdentificationTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


