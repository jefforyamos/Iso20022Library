﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeniedReason1Code.  ISO2002 ID# _azv0eNp-Ed-ak6NoX_4Aeg_1343217133.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azv0eNp-Ed-ak6NoX_4Aeg_1343217133")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(DeniedReasonCode))]
public enum DeniedReason1Code
{
    /// <summary>
    /// Received after the account servicer's deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_az5lcNp-Ed-ak6NoX_4Aeg_1343217135")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as "CallDeniedSinceAlreadyApplied".
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_az5lcdp-Ed-ak6NoX_4Aeg_1343217164")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied,
    
    /// <summary>
    /// Cancellation request was denied since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "DeniedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_az5lctp-Ed-ak6NoX_4Aeg_1343217165")]
    [Description(@"Cancellation request was denied since the instruction has already been cancelled.")]
    DeniedSinceAlreadyCancelled,
    
    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as "DeniedSinceNotAllowed".
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_az5lc9p-Ed-ak6NoX_4Aeg_1343217195")]
    [Description(@"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.")]
    DeniedSinceNotAllowed,
    
    /// <summary>
    /// Cancellation request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as "DeniedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_az5ldNp-Ed-ak6NoX_4Aeg_1343217196")]
    [Description(@"Cancellation request was denied because the process of settlement is in progress.")]
    DeniedSinceInProgress,
    
    /// <summary>
    /// Cancellation request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as "DeniedSinceRepoEnded".
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_az5lddp-Ed-ak6NoX_4Aeg_1343217197")]
    [Description(@"Cancellation request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded,
    
    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as "DeniedSinceAlreadySettled".
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_az5ldtp-Ed-ak6NoX_4Aeg_1343217225")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled,
    
    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as "InstructionProcessed".
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("_az5ld9p-Ed-ak6NoX_4Aeg_1343217226")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    InstructionProcessed,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_az5leNp-Ed-ak6NoX_4Aeg_1343217227")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeniedReason1CodeMetadataExtensions
{
    private static readonly DeniedReason1CodeDropdownSource _dropdownSource = new DeniedReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeniedReason1CodeDropdownRow GetMetadata(this DeniedReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


