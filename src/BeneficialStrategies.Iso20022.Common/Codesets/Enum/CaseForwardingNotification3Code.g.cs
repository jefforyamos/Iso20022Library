﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CaseForwardingNotification3Code.  ISO2002 ID# _a2bVAtp-Ed-ak6NoX_4Aeg_-1716921082.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the action requested when forwarding a case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2bVAtp-Ed-ak6NoX_4Aeg_-1716921082")]
[Description(@"Specifies the action requested when forwarding a case.")]
[DerivedFrom(typeof(CaseForwardingNotificationCode))]
public enum CaseForwardingNotification3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FurtherInvestigation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a2bVA9p-Ed-ak6NoX_4Aeg_-1716921080")]
    [Description(@"??")]
    FurtherInvestigation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RequestToCancel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a2bVBNp-Ed-ak6NoX_4Aeg_-1716921060")]
    [Description(@"??")]
    RequestToCancel,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RequestToModify".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a2bVBdp-Ed-ak6NoX_4Aeg_-1716921051")]
    [Description(@"??")]
    RequestToModify,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RequestDebitAuthorisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a2bVBtp-Ed-ak6NoX_4Aeg_-1716921029")]
    [Description(@"??")]
    RequestDebitAuthorisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SentAdditionalInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a2bVB9p-Ed-ak6NoX_4Aeg_-1716921020")]
    [Description(@"??")]
    SentAdditionalInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MineInvestigationCase".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a2bVCNp-Ed-ak6NoX_4Aeg_-1716921019")]
    [Description(@"??")]
    MineInvestigationCase,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CaseForwardingNotification3CodeMetadataExtensions
{
    private static readonly CaseForwardingNotification3CodeDropdownSource _dropdownSource = new CaseForwardingNotification3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICaseForwardingNotification3CodeDropdownRow GetMetadata(this CaseForwardingNotification3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

