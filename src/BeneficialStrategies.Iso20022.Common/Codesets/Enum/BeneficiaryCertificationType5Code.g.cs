﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BeneficiaryCertificationType5Code.  ISO2002 ID# _zJAQsQE6EeG43uL-ROUO3A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of certification required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zJAQsQE6EeG43uL-ROUO3A")]
[Description(@"Specifies the type of certification required.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
public enum BeneficiaryCertificationType5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccreditedInvestor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zJKBtQE6EeG43uL-ROUO3A")]
    [Description(@"??")]
    AccreditedInvestor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonCompany".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zJKBuQE6EeG43uL-ROUO3A")]
    [Description(@"??")]
    NonCompany,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QIBCertification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zJKBvQE6EeG43uL-ROUO3A")]
    [Description(@"??")]
    QIBCertification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BeneficiaryCertificationType5CodeMetadataExtensions
{
    private static readonly BeneficiaryCertificationType5CodeDropdownSource _dropdownSource = new BeneficiaryCertificationType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBeneficiaryCertificationType5CodeDropdownRow GetMetadata(this BeneficiaryCertificationType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

