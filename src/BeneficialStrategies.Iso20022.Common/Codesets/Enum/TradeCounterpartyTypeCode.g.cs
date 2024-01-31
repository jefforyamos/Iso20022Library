﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeCounterpartyTypeCode.  ISO2002 ID# _5cohQCR7Ee2VuKUpJ7HXPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the trade counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5cohQCR7Ee2VuKUpJ7HXPg")]
[Description(@"Specifies the type of the trade counterparty.")]
[Derivations(typeof(TradeCounterpartyType1Code))]
public enum TradeCounterpartyTypeCode
{
    /// <summary>
    /// Specifies that party to the transaction is a Reporting Counterparty.
    /// Encoded/decoded by serializers as "REPC".
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_AgatECR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Reporting Counterparty.")]
    ReportingCounterparty,
    
    /// <summary>
    /// Specifies that party to the transaction is an Other Counterparty.
    /// Encoded/decoded by serializers as "OTHC".
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_DLsnkCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is an Other Counterparty.")]
    OtherCounterparty,
    
    /// <summary>
    /// Specifies that party to the transaction is a Broker.
    /// Encoded/decoded by serializers as "BROK".
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_OnUWUCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Broker.")]
    Broker,
    
    /// <summary>
    /// Specifies that party to the transaction is a Submitting Agent.
    /// Encoded/decoded by serializers as "SBMA".
    /// </summary>
    [EnumMember(Value = "SBMA")]
    [IsoId("_QITn8CR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Submitting Agent.")]
    SubmittingAgent,
    
    /// <summary>
    /// Specifies that party to the transaction is a Clearing Member.
    /// Encoded/decoded by serializers as "CLEM".
    /// </summary>
    [EnumMember(Value = "CLEM")]
    [IsoId("_R-ftgCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Clearing Member.")]
    ClearingMember,
    
    /// <summary>
    /// Specifies that party to the transaction is a Beneficiary.
    /// Encoded/decoded by serializers as "BENE".
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_T-wVECR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Beneficiary.")]
    Beneficiary,
    
    /// <summary>
    /// Specifies that party to the transaction is an Executing Agent.
    /// Encoded/decoded by serializers as "EXEA".
    /// </summary>
    [EnumMember(Value = "EXEA")]
    [IsoId("_WtZFkCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is an Executing Agent.")]
    ExecutingAgent,
    
    /// <summary>
    /// Specifies that party to the transaction is an Entity Responsible For Report.
    /// Encoded/decoded by serializers as "ERFR".
    /// </summary>
    [EnumMember(Value = "ERFR")]
    [IsoId("_xA_40CxqEe2xAdY9t5fB3g")]
    [Description(@"Specifies that party to the transaction is an Entity Responsible For Report.")]
    EntityResponsibleForReport,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeCounterpartyTypeCodeMetadataExtensions
{
    private static readonly TradeCounterpartyTypeCodeDropdownSource _dropdownSource = new TradeCounterpartyTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeCounterpartyTypeCodeDropdownRow GetMetadata(this TradeCounterpartyTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


