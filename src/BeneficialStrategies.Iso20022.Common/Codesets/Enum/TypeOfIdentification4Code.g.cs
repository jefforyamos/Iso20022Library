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
    /// ??
    /// Encoded/decoded by serializers as "AlienRegistrationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VQxBcY6CEemzmeK8_tPygg")]
    [Description(@"??")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Concat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VbVSso6CEemzmeK8_tPygg")]
    [Description(@"??")]
    Concat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Viecgo6CEemzmeK8_tPygg")]
    [Description(@"??")]
    CorporateIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DriverLicenseNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vp6hQo6CEemzmeK8_tPygg")]
    [Description(@"??")]
    DriverLicenseNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IdentityCardNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XbksIY6CEemzmeK8_tPygg")]
    [Description(@"??")]
    IdentityCardNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NationalRegistrationIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Xk8qko6CEemzmeK8_tPygg")]
    [Description(@"??")]
    NationalRegistrationIdentificationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PassportNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Xrf-go6CEemzmeK8_tPygg")]
    [Description(@"??")]
    PassportNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SocialSecurityNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_X-PUUo6CEemzmeK8_tPygg")]
    [Description(@"??")]
    SocialSecurityNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yqk14Y6CEemzmeK8_tPygg")]
    [Description(@"??")]
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


