﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationCancellationV01.  ISO2002 ID# _RJ4jMOQXEeCGktPI9k4Dlw_1174499492.
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


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.
/// Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message.
/// </summary>
[Description(@"Scope|Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.|Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message.")]
[IsoId("_RJ4jMOQXEeCGktPI9k4Dlw_1174499492")]
[DisplayName("Securities Trade Confirmation Cancellation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeConfirmationCancellationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.029.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfCxl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.029.001.01";
    
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
    /// Constructs a SecuritiesTradeConfirmationCancellationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeConfirmationCancellationV01( TransactiontIdentification4 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationCancellation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_RJ4jMeQXEeCGktPI9k4Dlw_-1509857852")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactiontIdentification4 Identification { get; init; } 
    #else
    public TransactiontIdentification4 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_RJ4jMuQXEeCGktPI9k4Dlw_135409583")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages15? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages15? References { get; init; } 
    #else
    public Linkages15? References { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_RJ4jM-QXEeCGktPI9k4Dlw_588788110")]
    [DisplayName("Other Business Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBizPties")]
    #endif
    [IsoXmlTag("OthrBizPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherParties18? OtherBusinessParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherParties18? OtherBusinessParties { get; init; } 
    #else
    public OtherParties18? OtherBusinessParties { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RJ4jNOQXEeCGktPI9k4Dlw_-206107615")]
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


// Since SecuritiesTradeConfirmationCancellationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationCancellationV01.

