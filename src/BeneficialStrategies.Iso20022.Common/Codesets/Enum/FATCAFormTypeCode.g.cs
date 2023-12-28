﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FATCAFormTypeCode.  ISO2002 ID# _qRYe4QjLEeS5F6qHcKOrew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qRYe4QjLEeS5F6qHcKOrew")]
[Description(@"Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.")]
public enum FATCAFormTypeCode
{
    /// <summary>
    /// Certificate of foreign status of beneficial owner (also known as IRS form W-8BEN).
    /// Encoded/decoded by serializers as "CER1".
    /// </summary>
    [EnumMember(Value = "CER1")]
    [IsoId("_t_uY4AjLEeS5F6qHcKOrew")]
    [Description(@"Certificate of foreign status of beneficial owner (also known as IRS form W-8BEN).")]
    CertificateForeignStatusBeneficialOwner,
    
    /// <summary>
    /// Certificate of loss of nationality.
    /// Encoded/decoded by serializers as "CER2".
    /// </summary>
    [EnumMember(Value = "CER2")]
    [IsoId("_7js7QAjLEeS5F6qHcKOrew")]
    [Description(@"Certificate of loss of nationality.")]
    CertificateLossNationality,
    
    /// <summary>
    /// Self certification.
    /// Encoded/decoded by serializers as "CER3".
    /// </summary>
    [EnumMember(Value = "CER3")]
    [IsoId("_HGZiYAjMEeS5F6qHcKOrew")]
    [Description(@"Self certification.")]
    SelfCertification,
    
    /// <summary>
    /// Self certificate of loss of nationality (also known as IRS form I-407).
    /// Encoded/decoded by serializers as "CER4".
    /// </summary>
    [EnumMember(Value = "CER4")]
    [IsoId("_Kd-iMAjMEeS5F6qHcKOrew")]
    [Description(@"Self certificate of loss of nationality (also known as IRS form I-407).")]
    SelfCertificationLossNationality,
    
    /// <summary>
    /// Certificate of foreign intermediary (also known as IRS form W-8IMY).
    /// Encoded/decoded by serializers as "CER5".
    /// </summary>
    [EnumMember(Value = "CER5")]
    [IsoId("_WkYTUAjMEeS5F6qHcKOrew")]
    [Description(@"Certificate of foreign intermediary (also known as IRS form W-8IMY).")]
    CertificateForeignIntermediary,
    
    /// <summary>
    /// Form is a request for taxpayer identification number and certification (also known as IRS form W9).
    /// Encoded/decoded by serializers as "CER6".
    /// </summary>
    [EnumMember(Value = "CER6")]
    [IsoId("_cDpYYAjMEeS5F6qHcKOrew")]
    [Description(@"Form is a request for taxpayer identification number and certification (also known as IRS form W9).")]
    TaxpayerIdentificationNumberRequest,
    
    /// <summary>
    /// Certificate of foreign person's claim that income is effectively connected with the conduct of a trade or business in the United States (also known as IRS form W-8BEN-E).
    /// Encoded/decoded by serializers as "CER7".
    /// </summary>
    [EnumMember(Value = "CER7")]
    [IsoId("_emRGIAjMEeS5F6qHcKOrew")]
    [Description(@"Certificate of foreign person's claim that income is effectively connected with the conduct of a trade or business in the United States (also known as IRS form W-8BEN-E).")]
    CertificateForeignPersonsClaim,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FATCAFormTypeCodeMetadataExtensions
{
    private static readonly FATCAFormTypeCodeDropdownSource _dropdownSource = new FATCAFormTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFATCAFormTypeCodeDropdownRow GetMetadata(this FATCAFormTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

