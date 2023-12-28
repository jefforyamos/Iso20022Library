﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PersonIdentificationType1Code.  ISO2002 ID# _aGcplNp-Ed-ak6NoX_4Aeg_1146103115.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aGcplNp-Ed-ak6NoX_4Aeg_1146103115")]
[Description(@"Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.")]
[DerivedFrom(typeof(PersonIdentificationTypeCode))]
public enum PersonIdentificationType1Code
{
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as "PassportNumber".
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_aGcpldp-Ed-ak6NoX_4Aeg_-962231662")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber,
    
    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as "CPFAccountNumber".
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_aGcpltp-Ed-ak6NoX_4Aeg_-962231602")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber,
    
    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as "SRSAccountNumber".
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_aGcpl9p-Ed-ak6NoX_4Aeg_-962231560")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber,
    
    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as "NationalRegistrationIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_aGcpmNp-Ed-ak6NoX_4Aeg_-962231259")]
    [Description(@"National registration identification number. In Singapore this is known as the NRIC.")]
    NationalRegistrationIdentificationNumber,
    
    /// <summary>
    /// Another type of identification type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aGmakNp-Ed-ak6NoX_4Aeg_-962231217")]
    [Description(@"Another type of identification type.")]
    Other,
    
    /// <summary>
    /// Number assigned by a license authority to a driver's license.
    /// Encoded/decoded by serializers as "DriversLicenseNumber".
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_aGmakdp-Ed-ak6NoX_4Aeg_-2107022610")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber,
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as "SocialSecurityNumber".
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_aGmaktp-Ed-ak6NoX_4Aeg_-2107022143")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "AlienRegistrationNumber".
    /// </summary>
    [EnumMember(Value = "AREG")]
    [IsoId("_aGmak9p-Ed-ak6NoX_4Aeg_-2107022083")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as "IdentityCardNumber".
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_aGmalNp-Ed-ak6NoX_4Aeg_-2106102034")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as "EmployerIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_aGmaldp-Ed-ak6NoX_4Aeg_-2106101948")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PersonIdentificationType1CodeMetadataExtensions
{
    private static readonly PersonIdentificationType1CodeDropdownSource _dropdownSource = new PersonIdentificationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPersonIdentificationType1CodeDropdownRow GetMetadata(this PersonIdentificationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


