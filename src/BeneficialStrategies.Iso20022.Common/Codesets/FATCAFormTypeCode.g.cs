﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FATCAFormTypeCode.  ISO2002 ID# _qRYe4QjLEeS5F6qHcKOrew.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qRYe4QjLEeS5F6qHcKOrew")]
[Description(@"Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.")]
[Derivations(typeof(FATCAFormType1Code))]
public enum FATCAFormTypeCode
{
    /// <summary>
    /// Certificate of foreign status of beneficial owner (also known as IRS form W-8BEN).
    /// Encoded/decoded by serializers as &quot;CER1&quot;.
    /// </summary>
    [EnumMember(Value = "CER1")]
    [IsoId("_t_uY4AjLEeS5F6qHcKOrew")]
    [Description(@"Certificate of foreign status of beneficial owner (also known as IRS form W-8BEN).")]
    CertificateForeignStatusBeneficialOwner,
    
    /// <summary>
    /// Certificate of loss of nationality.
    /// Encoded/decoded by serializers as &quot;CER2&quot;.
    /// </summary>
    [EnumMember(Value = "CER2")]
    [IsoId("_7js7QAjLEeS5F6qHcKOrew")]
    [Description(@"Certificate of loss of nationality.")]
    CertificateLossNationality,
    
    /// <summary>
    /// Self certification.
    /// Encoded/decoded by serializers as &quot;CER3&quot;.
    /// </summary>
    [EnumMember(Value = "CER3")]
    [IsoId("_HGZiYAjMEeS5F6qHcKOrew")]
    [Description(@"Self certification.")]
    SelfCertification,
    
    /// <summary>
    /// Self certificate of loss of nationality (also known as IRS form I-407).
    /// Encoded/decoded by serializers as &quot;CER4&quot;.
    /// </summary>
    [EnumMember(Value = "CER4")]
    [IsoId("_Kd-iMAjMEeS5F6qHcKOrew")]
    [Description(@"Self certificate of loss of nationality (also known as IRS form I-407).")]
    SelfCertificationLossNationality,
    
    /// <summary>
    /// Certificate of foreign intermediary (also known as IRS form W-8IMY).
    /// Encoded/decoded by serializers as &quot;CER5&quot;.
    /// </summary>
    [EnumMember(Value = "CER5")]
    [IsoId("_WkYTUAjMEeS5F6qHcKOrew")]
    [Description(@"Certificate of foreign intermediary (also known as IRS form W-8IMY).")]
    CertificateForeignIntermediary,
    
    /// <summary>
    /// Form is a request for taxpayer identification number and certification (also known as IRS form W9).
    /// Encoded/decoded by serializers as &quot;CER6&quot;.
    /// </summary>
    [EnumMember(Value = "CER6")]
    [IsoId("_cDpYYAjMEeS5F6qHcKOrew")]
    [Description(@"Form is a request for taxpayer identification number and certification (also known as IRS form W9).")]
    TaxpayerIdentificationNumberRequest,
    
    /// <summary>
    /// Certificate of foreign person&apos;s claim that income is effectively connected with the conduct of a trade or business in the United States (also known as IRS form W-8BEN-E).
    /// Encoded/decoded by serializers as &quot;CER7&quot;.
    /// </summary>
    [EnumMember(Value = "CER7")]
    [IsoId("_emRGIAjMEeS5F6qHcKOrew")]
    [Description(@"Certificate of foreign person's claim that income is effectively connected with the conduct of a trade or business in the United States (also known as IRS form W-8BEN-E).")]
    CertificateForeignPersonsClaim,
    
}
