﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BaselineStatus1Code.  ISO2002 ID# _VroEEtp-Ed-ak6NoX_4Aeg_-553164939.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VroEEtp-Ed-ak6NoX_4Aeg_-553164939")]
[Description(@"Indicates the status of a baseline.")]
[DerivedFrom(typeof(BaselineStatusCode))]
public enum BaselineStatus1Code
{
    /// <summary>
    /// Initial state of a baseline in the push-through model.
    /// Encoded/decoded by serializers as "Proposed".
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_VroEE9p-Ed-ak6NoX_4Aeg_-466355902")]
    [Description(@"Initial state of a baseline in the push-through model.")]
    Proposed,
    
    /// <summary>
    /// Final state of a baseline, in which only reporting is allowed.
    /// Encoded/decoded by serializers as "Closed".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_VroEFNp-Ed-ak6NoX_4Aeg_-466355652")]
    [Description(@"Final state of a baseline, in which only reporting is allowed.")]
    Closed,
    
    /// <summary>
    /// State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties.
    /// Encoded/decoded by serializers as "PartiallyMatched".
    /// </summary>
    [EnumMember(Value = "PMTC")]
    [IsoId("_VroEFdp-Ed-ak6NoX_4Aeg_-466355340")]
    [Description(@"State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties.")]
    PartiallyMatched,
    
    /// <summary>
    /// State of the baseline when it has been agreed by all parties.
    /// Encoded/decoded by serializers as "Established".
    /// </summary>
    [EnumMember(Value = "ESTD")]
    [IsoId("_VroEFtp-Ed-ak6NoX_4Aeg_-466354989")]
    [Description(@"State of the baseline when it has been agreed by all parties.")]
    Established,
    
    /// <summary>
    /// State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_VroEF9p-Ed-ak6NoX_4Aeg_-466354859")]
    [Description(@"State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.")]
    Active,
    
    /// <summary>
    /// State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.
    /// Encoded/decoded by serializers as "Complete".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_VroEGNp-Ed-ak6NoX_4Aeg_-466354782")]
    [Description(@"State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.")]
    Complete,
    
    /// <summary>
    /// State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "AmendmentRequested".
    /// </summary>
    [EnumMember(Value = "AMRQ")]
    [IsoId("_VroEGdp-Ed-ak6NoX_4Aeg_1702042057")]
    [Description(@"State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    AmendmentRequested,
    
    /// <summary>
    /// State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "ReActivateRequested".
    /// </summary>
    [EnumMember(Value = "RARQ")]
    [IsoId("_VrxOANp-Ed-ak6NoX_4Aeg_1729748001")]
    [Description(@"State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    ReActivateRequested,
    
    /// <summary>
    /// State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "CloseRequested".
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_VrxOAdp-Ed-ak6NoX_4Aeg_1755607224")]
    [Description(@"State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    CloseRequested,
    
    /// <summary>
    /// State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "CompleteRequested".
    /// </summary>
    [EnumMember(Value = "SCRQ")]
    [IsoId("_VrxOAtp-Ed-ak6NoX_4Aeg_1181914907")]
    [Description(@"State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    CompleteRequested,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BaselineStatus1CodeMetadataExtensions
{
    private static readonly BaselineStatus1CodeDropdownSource _dropdownSource = new BaselineStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBaselineStatus1CodeDropdownRow GetMetadata(this BaselineStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


