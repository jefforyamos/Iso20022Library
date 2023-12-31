﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason11Code.  ISO2002 ID# _QcaXgeJxEd-Q6MzBzY5WkA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QcaXgeJxEd-Q6MzBzY5WkA")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason11Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as "CancelledByYourself".
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_q2JGtmtdEeCY4-KZ9JEyUQ_-816468203")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself,
    
    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as "CancelledByOther".
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_q2S3sGtdEeCY4-KZ9JEyUQ_1372396382")]
    [Description(@"Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.")]
    CancelledByOther,
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as "CancelledBySystem".
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_q2S3sWtdEeCY4-KZ9JEyUQ_-1844550576")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem,
    
    /// <summary>
    /// Instruction has been cancelled by the agent due to an event deadline extension.
    /// Encoded/decoded by serializers as "CancelledByAgent".
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_q2S3smtdEeCY4-KZ9JEyUQ_1453344367")]
    [Description(@"Instruction has been cancelled by the agent due to an event deadline extension.")]
    CancelledByAgent,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_q2S3s2tdEeCY4-KZ9JEyUQ_-486739620")]
    [Description(@"Other. See Narrative.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason11CodeMetadataExtensions
{
    private static readonly CancelledStatusReason11CodeDropdownSource _dropdownSource = new CancelledStatusReason11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason11CodeDropdownRow GetMetadata(this CancelledStatusReason11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


