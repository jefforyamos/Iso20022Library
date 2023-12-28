﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason2Code.  ISO2002 ID# _Zkxf4tp-Ed-ak6NoX_4Aeg_-699938374.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zkxf4tp-Ed-ak6NoX_4Aeg_-699938374")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason2Code
{
    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zkxf49p-Ed-ak6NoX_4Aeg_-438583092")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// Issuer or Registrar has rejected the instruction.
    /// Encoded/decoded by serializers as "RejectedByIssuerOrRegistrar".
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_Zkxf5Np-Ed-ak6NoX_4Aeg_-413646475")]
    [Description(@"Issuer or Registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar,
    
    /// <summary>
    /// The instruction is irrevocable.
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_Zkxf5dp-Ed-ak6NoX_4Aeg_-354541132")]
    [Description(@"The instruction is irrevocable.")]
    InstructionIrrevocable,
    
    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Zkxf5tp-Ed-ak6NoX_4Aeg_-325913625")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Zkxf59p-Ed-ak6NoX_4Aeg_-43315191")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_Zkxf6Np-Ed-ak6NoX_4Aeg_-13761369")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_Zkxf6dp-Ed-ak6NoX_4Aeg_4708938")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason2CodeMetadataExtensions
{
    private static readonly RejectionReason2CodeDropdownSource _dropdownSource = new RejectionReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason2CodeDropdownRow GetMetadata(this RejectionReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


