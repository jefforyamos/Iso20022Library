﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GDPRDataConsent1Code.  ISO2002 ID# _SQd7EJTWEemC09f0MxYkRg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SQd7EJTWEemC09f0MxYkRg")]
[Description(@"Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.")]
[DerivedFrom(typeof(GDPRDataConsentCode))]
public enum GDPRDataConsent1Code
{
    /// <summary>
    /// Consent to authorise the controller of personal data processing to process personal data for marketing purposes.
    /// Encoded/decoded by serializers as "ConsentMarketing".
    /// </summary>
    [EnumMember(Value = "DP00")]
    [IsoId("_0hh6cZUsEemIb43KZS2tHA")]
    [Description(@"Consent to authorise the controller of personal data processing to process personal data for marketing purposes.")]
    ConsentMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to process personal data for profiling purposes in order to formulate customised and targeted product and service offers.
    /// Encoded/decoded by serializers as "ConsentProfilingTargeted".
    /// </summary>
    [EnumMember(Value = "DP03")]
    [IsoId("_0wQ6AZUsEemIb43KZS2tHA")]
    [Description(@"Consent to authorise the controller of personal data processing to process personal data for profiling purposes in order to formulate customised and targeted product and service offers.")]
    ConsentProfilingTargeted,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to transfer personal data to other companies belonging to the same group for independent processing for marketing purposes.
    /// Encoded/decoded by serializers as "ConsentTransferSameMarketing".
    /// </summary>
    [EnumMember(Value = "DP01")]
    [IsoId("_01KoIZUsEemIb43KZS2tHA")]
    [Description(@"Consent to authorise the controller of personal data processing to transfer personal data to other companies belonging to the same group for independent processing for marketing purposes.")]
    ConsentTransferSameMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to transfer personal data to third party companies for independent processing for marketing purposes.
    /// Encoded/decoded by serializers as "ConsentTransferThirdPartyMarketing".
    /// </summary>
    [EnumMember(Value = "DP02")]
    [IsoId("_1E8JgZUsEemIb43KZS2tHA")]
    [Description(@"Consent to authorise the controller of personal data processing to transfer personal data to third party companies for independent processing for marketing purposes.")]
    ConsentTransferThirdPartyMarketing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GDPRDataConsent1CodeMetadataExtensions
{
    private static readonly GDPRDataConsent1CodeDropdownSource _dropdownSource = new GDPRDataConsent1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGDPRDataConsent1CodeDropdownRow GetMetadata(this GDPRDataConsent1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


