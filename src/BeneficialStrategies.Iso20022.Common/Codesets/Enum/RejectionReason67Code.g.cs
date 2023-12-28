﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason67Code.  ISO2002 ID# _xqxxIBnzEeyroI8qKgB7Mg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xqxxIBnzEeyroI8qKgB7Mg")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason67Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GAiwYRn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_JxboERn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    InstructionIrrevocable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LLzUURn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    InvalidReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_MoMZ0Rn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Nr1oIRn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PEkVoRn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_RBhxkRn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedByIssuerAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_RxDxERn0EeyroI8qKgB7Mg")]
    [Description(@"??")]
    RejectedByIssuerAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason67CodeMetadataExtensions
{
    private static readonly RejectionReason67CodeDropdownSource _dropdownSource = new RejectionReason67CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason67CodeDropdownRow GetMetadata(this RejectionReason67Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


