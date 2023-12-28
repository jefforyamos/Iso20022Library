﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfIdentification1Code.  ISO2002 ID# _YwnfFdp-Ed-ak6NoX_4Aeg_-1079654789.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwnfFdp-Ed-ak6NoX_4Aeg_-1079654789")]
[Description(@"Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.")]
[DerivedFrom(typeof(TypeOfIdentificationCode))]
public enum TypeOfIdentification1Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "AlienRegistrationNumber".
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_YwnfFtp-Ed-ak6NoX_4Aeg_-632668460")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Number assigned by a passport authority.
    /// Encoded/decoded by serializers as "PassportNumber".
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_YwnfF9p-Ed-ak6NoX_4Aeg_-334369828")]
    [Description(@"Number assigned by a passport authority.")]
    PassportNumber,
    
    /// <summary>
    /// Number assigned to a tax exempt entity.
    /// Encoded/decoded by serializers as "TaxExemptIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "CHTY")]
    [IsoId("_YwxQENp-Ed-ak6NoX_4Aeg_-332526291")]
    [Description(@"Number assigned to a tax exempt entity.")]
    TaxExemptIdentificationNumber,
    
    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as "CorporateIdentification".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_YwxQEdp-Ed-ak6NoX_4Aeg_-332522818")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification,
    
    /// <summary>
    /// Number assigned to a driver's license.
    /// Encoded/decoded by serializers as "DriverLicenseNumber".
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_YwxQEtp-Ed-ak6NoX_4Aeg_-331599633")]
    [Description(@"Number assigned to a driver's license.")]
    DriverLicenseNumber,
    
    /// <summary>
    /// Number assigned to a foreign investor (other than the alien number).
    /// Encoded/decoded by serializers as "ForeignInvestmentIdentityNumber".
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("_YwxQE9p-Ed-ak6NoX_4Aeg_-330676223")]
    [Description(@"Number assigned to a foreign investor (other than the alien number).")]
    ForeignInvestmentIdentityNumber,
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as "TaxIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_YwxQFNp-Ed-ak6NoX_4Aeg_-329752873")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfIdentification1CodeMetadataExtensions
{
    private static readonly TypeOfIdentification1CodeDropdownSource _dropdownSource = new TypeOfIdentification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfIdentification1CodeDropdownRow GetMetadata(this TypeOfIdentification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


