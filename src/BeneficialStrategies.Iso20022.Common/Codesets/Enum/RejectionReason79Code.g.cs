﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason79Code.  ISO2002 ID# __SMwITQWEe2o-K1dwNg8Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__SMwITQWEe2o-K1dwNg8Gg")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason79Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK04TQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK04zQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    InstructionIrrevocable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK05TQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    InvalidReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK05zQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK06TQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK06zQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK07TQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedByIssuerAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__tK07zQWEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    RejectedByIssuerAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingContact".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Jk02gTQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    MissingContact,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_K1S_4jQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_MmQAIjQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingProtectDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_OG894jQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    MissingProtectDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_S6EHkTQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingProtectIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UX8a0jQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    MissingProtectIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingTransactionType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_V1YCIjQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    MissingTransactionType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DuplicateInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XcDFAjQXEe2o-K1dwNg8Gg")]
    [Description(@"??")]
    DuplicateInstruction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason79CodeMetadataExtensions
{
    private static readonly RejectionReason79CodeDropdownSource _dropdownSource = new RejectionReason79CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason79CodeDropdownRow GetMetadata(this RejectionReason79Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

