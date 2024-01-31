﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GDPRDataConsentCode.  ISO2002 ID# _aN8PUJTTEemC09f0MxYkRg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aN8PUJTTEemC09f0MxYkRg")]
[Description(@"Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.")]
[Derivations(typeof(GDPRDataConsent1Code))]
public enum GDPRDataConsentCode
{
    /// <summary>
    /// Consent to authorise the controller of personal data processing to process personal data for marketing purposes.
    /// Encoded/decoded by serializers as "DP00".
    /// </summary>
    [EnumMember(Value = "DP00")]
    [IsoId("_jLKpAJTTEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to process personal data for marketing purposes.")]
    ConsentMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to transfer personal data to other companies belonging to the same group for independent processing for marketing purposes.
    /// Encoded/decoded by serializers as "DP01".
    /// </summary>
    [EnumMember(Value = "DP01")]
    [IsoId("_CRy34JTWEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to transfer personal data to other companies belonging to the same group for independent processing for marketing purposes.")]
    ConsentTransferSameMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to transfer personal data to third party companies for independent processing for marketing purposes.
    /// Encoded/decoded by serializers as "DP02".
    /// </summary>
    [EnumMember(Value = "DP02")]
    [IsoId("_E15MUJTWEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to transfer personal data to third party companies for independent processing for marketing purposes.")]
    ConsentTransferThirdPartyMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to process personal data for profiling purposes in order to formulate customised and targeted product and service offers.
    /// Encoded/decoded by serializers as "DP03".
    /// </summary>
    [EnumMember(Value = "DP03")]
    [IsoId("_FJ-l8JTWEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to process personal data for profiling purposes in order to formulate customised and targeted product and service offers.")]
    ConsentProfilingTargeted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GDPRDataConsentCodeMetadataExtensions
{
    private static readonly GDPRDataConsentCodeDropdownSource _dropdownSource = new GDPRDataConsentCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGDPRDataConsentCodeDropdownRow GetMetadata(this GDPRDataConsentCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


