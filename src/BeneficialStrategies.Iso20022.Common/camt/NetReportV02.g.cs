﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NetReportV02.  ISO2002 ID# _kBNA9QM-Ee2nqoJcXIhTdw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.088.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.
/// </summary>
[Description(@"The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.")]
[IsoId("_kBNA9QM-Ee2nqoJcXIhTdw")]
[DisplayName("Net Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.088.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.088.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetReportV02( NetReportData2 reqNetReportData,PartyIdentification242Choice_ reqNetServiceParticipantIdentification,NetObligation2 reqNetObligation )
    {
        NetReportData = reqNetReportData;
        NetServiceParticipantIdentification = reqNetServiceParticipantIdentification;
        NetObligation = reqNetObligation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the meta data associated with the net report.
    /// </summary>
    [IsoId("_kBNA-QM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Report Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetRptData")]
    #endif
    [IsoXmlTag("NetRptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetReportData2 NetReportData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetReportData2 NetReportData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetReportData2 NetReportData { get; init; } 
    #else
    public NetReportData2 NetReportData { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_kBNA-wM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Service Participant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetSvcPtcptId")]
    #endif
    [IsoXmlTag("NetSvcPtcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; } 
    #else
    public PartyIdentification242Choice_ NetServiceParticipantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the counterparty participant involved in (all of) the obligations of the report.
    /// </summary>
    [IsoId("_kBNA_QM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Service Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetSvcCtrPtyId")]
    #endif
    [IsoXmlTag("NetSvcCtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; } 
    #else
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the amount, direct parties or netting groups involved in the obligation.
    /// </summary>
    [IsoId("_kBNA_wM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetOblgtn")]
    #endif
    [IsoXmlTag("NetOblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetObligation2 NetObligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetObligation2 NetObligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetObligation2 NetObligation { get; init; } 
    #else
    public NetObligation2 NetObligation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kBNBAQM-Ee2nqoJcXIhTdw")]
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


// Since NetReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetReportV02.

