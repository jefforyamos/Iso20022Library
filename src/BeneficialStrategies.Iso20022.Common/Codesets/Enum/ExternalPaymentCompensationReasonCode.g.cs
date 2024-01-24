﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentCompensationReasonCode.  ISO2002 ID# _WyP5wYjXEeeDW7_wB-eK_g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for compensation for the processing of a payment, as published in an external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WyP5wYjXEeeDW7_wB-eK_g")]
[Description(@"Specifies the reason for compensation for the processing of a payment, as published in an external code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalPaymentCompensationReason1Code))]
public enum ExternalPaymentCompensationReasonCode
{
    /// <summary>
    /// Compensation requested for value date correction.
    /// Encoded/decoded by serializers as "VADA".
    /// </summary>
    [EnumMember(Value = "VADA")]
    [IsoId("_vvidwIjXEeeDW7_wB-eK_g")]
    [Description(@"Compensation requested for value date correction.")]
    ValueDateAdjustment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentCompensationReasonCodeMetadataExtensions
{
    private static readonly ExternalPaymentCompensationReasonCodeDropdownSource _dropdownSource = new ExternalPaymentCompensationReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentCompensationReasonCodeDropdownRow GetMetadata(this ExternalPaymentCompensationReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


