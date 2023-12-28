﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingReason16Code.  ISO2002 ID# _b44F4LLJEemDyeh7tbvg1w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b44F4LLJEemDyeh7tbvg1w")]
[Description(@"Specifies a reason why the instruction is pending.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum PendingReason16Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kz3q8bLJEemDyeh7tbvg1w")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AdditionalDocumentationMissing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zPni0bLJEemDyeh7tbvg1w")]
    [Description(@"??")]
    AdditionalDocumentationMissing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityDisagreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3mRaAbLJEemDyeh7tbvg1w")]
    [Description(@"??")]
    QuantityDisagreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeadlineToRegisterMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_C8coEbLKEemDyeh7tbvg1w")]
    [Description(@"??")]
    DeadlineToRegisterMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_HJ4R0bLKEemDyeh7tbvg1w")]
    [Description(@"??")]
    PendingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingOrInvalidPOA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YKdd8bLKEemDyeh7tbvg1w")]
    [Description(@"??")]
    MissingOrInvalidPOA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientThresholdPosition".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_lv5_8bLKEemDyeh7tbvg1w")]
    [Description(@"??")]
    InsufficientThresholdPosition,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4W2s8bLKEemDyeh7tbvg1w")]
    [Description(@"??")]
    LackOfSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5tcFYbLKEemDyeh7tbvg1w")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoRegisteredPosition".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F5UMYbLLEemDyeh7tbvg1w")]
    [Description(@"??")]
    NoRegisteredPosition,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegistrationDiscrepancy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GqtNEbLLEemDyeh7tbvg1w")]
    [Description(@"??")]
    RegistrationDiscrepancy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_IgGBYbLLEemDyeh7tbvg1w")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProxyCardDiscrepancy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViIUUbLLEemDyeh7tbvg1w")]
    [Description(@"??")]
    ProxyCardDiscrepancy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingReceipt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XtFI8bLLEemDyeh7tbvg1w")]
    [Description(@"??")]
    PendingReceipt,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingReason16CodeMetadataExtensions
{
    private static readonly PendingReason16CodeDropdownSource _dropdownSource = new PendingReason16CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingReason16CodeDropdownRow GetMetadata(this PendingReason16Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

