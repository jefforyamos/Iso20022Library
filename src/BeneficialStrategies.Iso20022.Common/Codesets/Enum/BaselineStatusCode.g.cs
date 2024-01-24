﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BaselineStatusCode.  ISO2002 ID# _bc3p9dp-Ed-ak6NoX_4Aeg_-1712185588.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bc3p9dp-Ed-ak6NoX_4Aeg_-1712185588")]
[Description(@"Indicates the status of a baseline.")]
[Derivations(typeof(BaselineStatus1Code),typeof(BaselineStatus3Code),typeof(BaselineStatus2Code))]
public enum BaselineStatusCode
{
    /// <summary>
    /// Initial state of a baseline in the push-through model.
    /// Encoded/decoded by serializers as "PROP".
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_bc3p9tp-Ed-ak6NoX_4Aeg_-1469298786")]
    [Description(@"Initial state of a baseline in the push-through model.")]
    Proposed,
    
    /// <summary>
    /// Final state of a baseline, in which only reporting is allowed.
    /// Encoded/decoded by serializers as "CLSD".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_bc3p99p-Ed-ak6NoX_4Aeg_-1434202451")]
    [Description(@"Final state of a baseline, in which only reporting is allowed.")]
    Closed,
    
    /// <summary>
    /// State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties.
    /// Encoded/decoded by serializers as "PMTC".
    /// </summary>
    [EnumMember(Value = "PMTC")]
    [IsoId("_bc3p-Np-Ed-ak6NoX_4Aeg_-1050944645")]
    [Description(@"State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties.")]
    PartiallyMatched,
    
    /// <summary>
    /// State of the baseline when it has been agreed by all parties.
    /// Encoded/decoded by serializers as "ESTD".
    /// </summary>
    [EnumMember(Value = "ESTD")]
    [IsoId("_bdBa8Np-Ed-ak6NoX_4Aeg_-949355489")]
    [Description(@"State of the baseline when it has been agreed by all parties.")]
    Established,
    
    /// <summary>
    /// State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_bdBa8dp-Ed-ak6NoX_4Aeg_-911492852")]
    [Description(@"State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.")]
    Active,
    
    /// <summary>
    /// State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bdBa8tp-Ed-ak6NoX_4Aeg_-836687708")]
    [Description(@"State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.")]
    Complete,
    
    /// <summary>
    /// State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "AMRQ".
    /// </summary>
    [EnumMember(Value = "AMRQ")]
    [IsoId("_bdBa89p-Ed-ak6NoX_4Aeg_1357569004")]
    [Description(@"State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    AmendmentRequested,
    
    /// <summary>
    /// State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "RARQ".
    /// </summary>
    [EnumMember(Value = "RARQ")]
    [IsoId("_bdBa9Np-Ed-ak6NoX_4Aeg_1400048802")]
    [Description(@"State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    ReActivateRequested,
    
    /// <summary>
    /// State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "CLRQ".
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_bdBa9dp-Ed-ak6NoX_4Aeg_1657713966")]
    [Description(@"State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    CloseRequested,
    
    /// <summary>
    /// State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "SCRQ".
    /// </summary>
    [EnumMember(Value = "SCRQ")]
    [IsoId("_bdBa9tp-Ed-ak6NoX_4Aeg_843905679")]
    [Description(@"State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    CompleteRequested,
    
    /// <summary>
    /// State of a baseline when a status extension has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as "SERQ".
    /// </summary>
    [EnumMember(Value = "SERQ")]
    [IsoId("_bdBa99p-Ed-ak6NoX_4Aeg_-1361201210")]
    [Description(@"State of a baseline when a status extension has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    StatusExtensionRequested,
    
    /// <summary>
    /// State of a baseline, after establishment, when data set acceptance has been requested by the matching engine and not all responses have been received from the relevant party(ies).
    /// Encoded/decoded by serializers as "DARQ".
    /// </summary>
    [EnumMember(Value = "DARQ")]
    [IsoId("_bdBa-Np-Ed-ak6NoX_4Aeg_-1361201179")]
    [Description(@"State of a baseline, after establishment, when data set acceptance has been requested by the matching engine and not all responses have been received from the relevant party(ies).")]
    DataSetAcceptanceRequested,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BaselineStatusCodeMetadataExtensions
{
    private static readonly BaselineStatusCodeDropdownSource _dropdownSource = new BaselineStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBaselineStatusCodeDropdownRow GetMetadata(this BaselineStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


