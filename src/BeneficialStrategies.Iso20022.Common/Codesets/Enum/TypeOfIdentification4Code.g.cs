﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfIdentification4Code.  ISO2002 ID# _RoFDgI6CEemzmeK8_tPygg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RoFDgI6CEemzmeK8_tPygg")]
[Description(@"Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.")]
[DerivedFrom(typeof(TypeOfIdentificationCode))]
public enum TypeOfIdentification4Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "AlienRegistrationNumber".
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_VQxBcY6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Number assigned by an issuer to identify a customer via the concatenation of the birthdate and characters of the first name and surname. 
    /// Encoded/decoded by serializers as "Concat".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_VbVSso6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by an issuer to identify a customer via the concatenation of the birthdate and characters of the first name and surname. ")]
    Concat,
    
    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as "CorporateIdentification".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_Viecgo6CEemzmeK8_tPygg")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification,
    
    /// <summary>
    /// Number assigned to a driver's license.
    /// Encoded/decoded by serializers as "DriverLicenseNumber".
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_Vp6hQo6CEemzmeK8_tPygg")]
    [Description(@"Number assigned to a driver's license.")]
    DriverLicenseNumber,
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as "IdentityCardNumber".
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_XbksIY6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,
    
    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as "NationalRegistrationIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_Xk8qko6CEemzmeK8_tPygg")]
    [Description(@"National registration identification number. In Singapore this is known as the NRIC.")]
    NationalRegistrationIdentificationNumber,
    
    /// <summary>
    /// Number assigned by a passport authority.
    /// Encoded/decoded by serializers as "PassportNumber".
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_Xrf-go6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a passport authority.")]
    PassportNumber,
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as "SocialSecurityNumber".
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_X-PUUo6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as "TaxIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_Yqk14Y6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfIdentification4CodeMetadataExtensions
{
    private static readonly TypeOfIdentification4CodeDropdownSource _dropdownSource = new TypeOfIdentification4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfIdentification4CodeDropdownRow GetMetadata(this TypeOfIdentification4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


