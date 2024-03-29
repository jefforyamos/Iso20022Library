﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeData28.  ISO2002 ID# _ArgEdcK3EeuFNp8LZAnorg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reported trade transactions.
/// </summary>
[IsoId("_ArgEdcK3EeuFNp8LZAnorg")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData28
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the required transactions reconciliation or pairing.
    /// </summary>
    [IsoId("_AtBHYcK3EeuFNp8LZAnorg")]
    [DisplayName("Pairing Reconciliation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PairgRcncltnSts")]
    #endif
    [IsoXmlTag("PairgRcncltnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOfReportsPerStatus4? PairingReconciliationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOfReportsPerStatus4? PairingReconciliationStatus { get; init; } 
    #else
    public NumberOfReportsPerStatus4? PairingReconciliationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Data on transaction requiring reconciliation or pairing. 
    /// </summary>
    [IsoId("_AtBHY8K3EeuFNp8LZAnorg")]
    [DisplayName("Reconciliation Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnRpt")]
    #endif
    [IsoXmlTag("RcncltnRpt")]
    public ValueList<ReconciliationReport8> ReconciliationReport { get; init; } = new ValueList<ReconciliationReport8>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _AtBHY8K3EeuFNp8LZAnorg
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_AtBHZcK3EeuFNp8LZAnorg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
