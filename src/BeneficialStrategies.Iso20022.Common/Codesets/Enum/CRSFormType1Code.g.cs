﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CRSFormType1Code.  ISO2002 ID# _TYFa4ENwEeaS-NnwLNvMPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Common Reporting Standard (CRS) form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TYFa4ENwEeaS-NnwLNvMPg")]
[Description(@"Specifies the type of Common Reporting Standard (CRS) form.")]
[DerivedFrom(typeof(CRSFormTypeCode))]
public enum CRSFormType1Code
{
    /// <summary>
    /// Certificate of Identification issued by a government.
    /// Encoded/decoded by serializers as "CER4".
    /// </summary>
    [EnumMember(Value = "CER4")]
    [IsoId("_VuWHoUNwEeaS-NnwLNvMPg")]
    [Description(@"Certificate of Identification issued by a government.")]
    CertificateIdentificationGovernment = CRSFormTypeCode.CertificateIdentificationGovernment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of residence.
    /// Encoded/decoded by serializers as "CER3".
    /// </summary>
    [EnumMember(Value = "CER3")]
    [IsoId("_V4BBAUNwEeaS-NnwLNvMPg")]
    [Description(@"Certificate of residence.")]
    CertificateOfResidence = CRSFormTypeCode.CertificateOfResidence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Official documentation issued by a government for the entity.
    /// Encoded/decoded by serializers as "CER5".
    /// </summary>
    [EnumMember(Value = "CER5")]
    [IsoId("_WBshcUNwEeaS-NnwLNvMPg")]
    [Description(@"Official documentation issued by a government for the entity.")]
    OfficialDocumentGovernmentForEntity = CRSFormTypeCode.OfficialDocumentGovernmentForEntity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial statement, third party credit report, bankruptcy filing or a securities regulator report.
    /// Encoded/decoded by serializers as "CER6".
    /// </summary>
    [EnumMember(Value = "CER6")]
    [IsoId("_WE0G4UNwEeaS-NnwLNvMPg")]
    [Description(@"Financial statement, third party credit report, bankruptcy filing or a securities regulator report.")]
    OtherDocumentOrReport = CRSFormTypeCode.OtherDocumentOrReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Publicly available information for the entity.
    /// Encoded/decoded by serializers as "CER8".
    /// </summary>
    [EnumMember(Value = "CER8")]
    [IsoId("_WUloQUNwEeaS-NnwLNvMPg")]
    [Description(@"Publicly available information for the entity.")]
    PublicInformationEntity = CRSFormTypeCode.PublicInformationEntity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Self certification as a separate document.
    /// Encoded/decoded by serializers as "CER1".
    /// </summary>
    [EnumMember(Value = "CER1")]
    [IsoId("_WeQhoUNwEeaS-NnwLNvMPg")]
    [Description(@"Self certification as a separate document.")]
    SelfCertificationSeparateDocument = CRSFormTypeCode.SelfCertificationSeparateDocument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Self certification as a document included into contract of the account opening.
    /// Encoded/decoded by serializers as "CER2".
    /// </summary>
    [EnumMember(Value = "CER2")]
    [IsoId("_WnxqAUNwEeaS-NnwLNvMPg")]
    [Description(@"Self certification as a document included into contract of the account opening.")]
    SelfCertificationWithAccountOpeningContract = CRSFormTypeCode.SelfCertificationWithAccountOpeningContract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standardised industry coding system for the entity.
    /// Encoded/decoded by serializers as "CER7".
    /// </summary>
    [EnumMember(Value = "CER7")]
    [IsoId("_WxTZcUNwEeaS-NnwLNvMPg")]
    [Description(@"Standardised industry coding system for the entity.")]
    Standardised = CRSFormTypeCode.Standardised, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CRSFormType1CodeMetadataExtensions
{
    private static readonly CRSFormType1CodeDropdownSource _dropdownSource = new CRSFormType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICRSFormType1CodeDropdownRow GetMetadata(this CRSFormType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


