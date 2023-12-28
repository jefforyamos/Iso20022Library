﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeCounterpartyType1Code.  ISO2002 ID# _Y0Kk0CR8Ee2VuKUpJ7HXPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the trade counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y0Kk0CR8Ee2VuKUpJ7HXPg")]
[Description(@"Specifies the type of the trade counterparty.")]
[DerivedFrom(typeof(TradeCounterpartyTypeCode))]
public enum TradeCounterpartyType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Beneficiary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bZx8MCR8Ee2VuKUpJ7HXPg")]
    [Description(@"??")]
    Beneficiary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Broker".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bdHkESR8Ee2VuKUpJ7HXPg")]
    [Description(@"??")]
    Broker,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearingMember".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bhJIcSR8Ee2VuKUpJ7HXPg")]
    [Description(@"??")]
    ClearingMember,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExecutingAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bkTxMSR8Ee2VuKUpJ7HXPg")]
    [Description(@"??")]
    ExecutingAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherCounterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bngPISR8Ee2VuKUpJ7HXPg")]
    [Description(@"??")]
    OtherCounterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReportingCounterparty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bqNk4SR8Ee2VuKUpJ7HXPg")]
    [Description(@"??")]
    ReportingCounterparty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SubmittingAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_btzrcSR8Ee2VuKUpJ7HXPg")]
    [Description(@"??")]
    SubmittingAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EntityResponsibleForReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5Qm-kCxqEe2xAdY9t5fB3g")]
    [Description(@"??")]
    EntityResponsibleForReport,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeCounterpartyType1CodeMetadataExtensions
{
    private static readonly TradeCounterpartyType1CodeDropdownSource _dropdownSource = new TradeCounterpartyType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeCounterpartyType1CodeDropdownRow GetMetadata(this TradeCounterpartyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


