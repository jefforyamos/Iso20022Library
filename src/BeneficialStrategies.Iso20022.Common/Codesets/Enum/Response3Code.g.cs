﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Response3Code.  ISO2002 ID# _nY5LoHuGEeSZrqGdHyoIrw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the request message or advice message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nY5LoHuGEeSZrqGdHyoIrw")]
[Description(@"Result of the request message or advice message.")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response3Code
{
    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as "APPR".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_p-IvkXuGEeSZrqGdHyoIrw")]
    [Description(@"Service has been successfuly provided.")]
    Approved = ResponseCode.Approved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as "DECL".
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_qEZIkXuGEeSZrqGdHyoIrw")]
    [Description(@"Service is declined.")]
    Declined = ResponseCode.Declined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further action required to complete the transaction, for instance a referral.
    /// Encoded/decoded by serializers as "FRTH".
    /// </summary>
    [EnumMember(Value = "FRTH")]
    [IsoId("_qMJWYXuGEeSZrqGdHyoIrw")]
    [Description(@"Further action required to complete the transaction, for instance a referral.")]
    FurtherAction = ResponseCode.FurtherAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_rHtmwXuGEeSZrqGdHyoIrw")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved = ResponseCode.PartialApproved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice message is processed.
    /// Encoded/decoded by serializers as "PRCS".
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_rPm-gXuGEeSZrqGdHyoIrw")]
    [Description(@"Advice message is processed.")]
    Processed = ResponseCode.Processed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice message could not be processed.
    /// Encoded/decoded by serializers as "UNPR".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_QgeH4SxKEeW0Obqrzm1X8Q")]
    [Description(@"Advice message could not be processed.")]
    NotProcessed = ResponseCode.NotProcessed, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Response3CodeMetadataExtensions
{
    private static readonly Response3CodeDropdownSource _dropdownSource = new Response3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponse3CodeDropdownRow GetMetadata(this Response3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


