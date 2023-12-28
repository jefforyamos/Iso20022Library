﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionEventStageCode.  ISO2002 ID# _bD_P4Np-Ed-ak6NoX_4Aeg_-1886893264.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the stage of the CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bD_P4Np-Ed-ak6NoX_4Aeg_-1886893264")]
[Description(@"Specifies the stage of the CA event.")]
[Derivations(typeof(CorporateActionEventStage1Code),typeof(CorporateActionEventStage2Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionEventStageCode
{
    /// <summary>
    /// Approved at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as "APPD".
    /// </summary>
    [EnumMember(Value = "APPD")]
    [IsoId("_bD_P4dp-Ed-ak6NoX_4Aeg_-1858264134")]
    [Description(@"Approved at the relevant meeting, eg, dividend.")]
    Approved,
    
    /// <summary>
    /// The offer is closed for acceptance.
    /// Encoded/decoded by serializers as "CLDE".
    /// </summary>
    [EnumMember(Value = "CLDE")]
    [IsoId("_bD_P4tp-Ed-ak6NoX_4Aeg_-1858264083")]
    [Description(@"The offer is closed for acceptance.")]
    Deactivated,
    
    /// <summary>
    /// An original or supplemental lottery is being reversed.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_bD_P49p-Ed-ak6NoX_4Aeg_-422836046")]
    [Description(@"An original or supplemental lottery is being reversed.")]
    FullReversalLotteryNotification,
    
    /// <summary>
    /// The event/offer conditions have not been met and the event/offer is terminated or lapsed.
    /// Encoded/decoded by serializers as "LAPS".
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bD_P5Np-Ed-ak6NoX_4Aeg_-357266452")]
    [Description(@"The event/offer conditions have not been met and the event/offer is terminated or lapsed.")]
    Lapsed,
    
    /// <summary>
    /// Original call amount is reduced by the agent. The original announcement is cancelled and a new original lottery is issued.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_bD_P5dp-Ed-ak6NoX_4Aeg_-241824969")]
    [Description(@"Original call amount is reduced by the agent. The original announcement is cancelled and a new original lottery is issued.")]
    PartialReversalLotteryNotification,
    
    /// <summary>
    /// Open for acceptance until the next specified deadline in the announcement (if any).
    /// Encoded/decoded by serializers as "PWAL".
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_bD_P5tp-Ed-ak6NoX_4Aeg_-1858264144")]
    [Description(@"Open for acceptance until the next specified deadline in the announcement (if any).")]
    ActionPeriod,
    
    /// <summary>
    /// Original and or supplemental lottery details have changed and the lottery is being cancelled.
    /// Encoded/decoded by serializers as "RESC".
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_bD_P59p-Ed-ak6NoX_4Aeg_74019586")]
    [Description(@"Original and or supplemental lottery details have changed and the lottery is being cancelled.")]
    RescissionReversalLotteryNotification,
    
    /// <summary>
    /// Subject to approval at the relevant meeting, eg, dividend.
    /// Encoded/decoded by serializers as "SUAP".
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_bD_P6Np-Ed-ak6NoX_4Aeg_-1858264135")]
    [Description(@"Subject to approval at the relevant meeting, eg, dividend.")]
    SubjectToApproval,
    
    /// <summary>
    /// The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.
    /// Encoded/decoded by serializers as "UNAC".
    /// </summary>
    [EnumMember(Value = "UNAC")]
    [IsoId("_bD_P6dp-Ed-ak6NoX_4Aeg_-1858264113")]
    [Description(@"The required level of acceptances specified in the terms of the offer has been achieved but there are still outstanding conditions to fulfil.")]
    UnconditionalAsToAcceptance,
    
    /// <summary>
    /// Wholly unconditional; all conditions specified in the offer document have been satisfied.
    /// Encoded/decoded by serializers as "WHOU".
    /// </summary>
    [EnumMember(Value = "WHOU")]
    [IsoId("_bEJA4Np-Ed-ak6NoX_4Aeg_-1858264104")]
    [Description(@"Wholly unconditional; all conditions specified in the offer document have been satisfied.")]
    WhollyUnconditional,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionEventStageCodeMetadataExtensions
{
    private static readonly CorporateActionEventStageCodeDropdownSource _dropdownSource = new CorporateActionEventStageCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionEventStageCodeDropdownRow GetMetadata(this CorporateActionEventStageCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


