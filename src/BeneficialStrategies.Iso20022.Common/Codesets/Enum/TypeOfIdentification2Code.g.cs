﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfIdentification2Code.  ISO2002 ID# __ztF49ojEeC60axPepSq7g_97735513.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__ztF49ojEeC60axPepSq7g_97735513")]
[Description(@"Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.")]
[DerivedFrom(typeof(TypeOfIdentificationCode))]
public enum TypeOfIdentification2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AlienRegistrationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__ztF5NojEeC60axPepSq7g_1743002948")]
    [Description(@"??")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxExemptIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__ztF5dojEeC60axPepSq7g_-721218168")]
    [Description(@"??")]
    TaxExemptIdentificationNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__z224NojEeC60axPepSq7g_-1013175906")]
    [Description(@"??")]
    CorporateIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignInvestmentIdentityNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__z224dojEeC60axPepSq7g_-1896409193")]
    [Description(@"??")]
    ForeignInvestmentIdentityNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__z224tojEeC60axPepSq7g_-1718290521")]
    [Description(@"??")]
    TaxIdentificationNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfIdentification2CodeMetadataExtensions
{
    private static readonly TypeOfIdentification2CodeDropdownSource _dropdownSource = new TypeOfIdentification2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfIdentification2CodeDropdownRow GetMetadata(this TypeOfIdentification2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


