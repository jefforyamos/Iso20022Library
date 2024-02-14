﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MarginCallRequestV03.  ISO2002 ID# _EIYSoVnMEeSPgY23yCMQSQ.
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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MarginCallRequest message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager
/// This message is used to request new collateral at the initiation of an exposure or request additional collateral for an existing exposure. It can also be used to recall collateral upon the collateral giver or its collateral manager&apos;s request.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// When sent by the collateral taker the MarginCallRequest message is used to:
/// - request new collateral at the initiation of an exposure
/// - request additional collateral
/// When sent by the collateral giver the MarginCallRequest message is used to:
/// - request the return of collateral.
/// </summary>
[Description(@"Scope|The MarginCallRequest message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager|This message is used to request new collateral at the initiation of an exposure or request additional collateral for an existing exposure. It can also be used to recall collateral upon the collateral giver or its collateral manager's request.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When sent by the collateral taker the MarginCallRequest message is used to:|- request new collateral at the initiation of an exposure|- request additional collateral|When sent by the collateral giver the MarginCallRequest message is used to:|- request the return of collateral.")]
[IsoId("_EIYSoVnMEeSPgY23yCMQSQ")]
[DisplayName("Margin Call Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCallRequestV03 : IOuterRecord<MarginCallRequestV03,MarginCallRequestV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MarginCallRequestV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCallRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCallRequestV03( System.String reqTransactionIdentification,Obligation3 reqObligation,MarginCallResult3 reqMarginCallResult )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
        MarginCallResult = reqMarginCallResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_EIYSo1nMEeSPgY23yCMQSQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_EIYSpVnMEeSPgY23yCMQSQ")]
    [DisplayName("Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgtn")]
    #endif
    [IsoXmlTag("Oblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation3 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Obligation3 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation3 Obligation { get; init; } 
    #else
    public Obligation3 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_EIYSp1nMEeSPgY23yCMQSQ")]
    [DisplayName("Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agrmt")]
    #endif
    [IsoXmlTag("Agrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement2? Agreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement2? Agreement { get; init; } 
    #else
    public Agreement2? Agreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_EIYSqVnMEeSPgY23yCMQSQ")]
    [DisplayName("Margin Details Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnDtlsDueToA")]
    #endif
    [IsoXmlTag("MrgnDtlsDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCall1? MarginDetailsDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCall1? MarginDetailsDueToA { get; init; } 
    #else
    public MarginCall1? MarginDetailsDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_EIYSq1nMEeSPgY23yCMQSQ")]
    [DisplayName("Margin Details Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnDtlsDueToB")]
    #endif
    [IsoXmlTag("MrgnDtlsDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCall1? MarginDetailsDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCall1? MarginDetailsDueToB { get; init; } 
    #else
    public MarginCall1? MarginDetailsDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_EIYSrVnMEeSPgY23yCMQSQ")]
    [DisplayName("Requirement Details Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqrmntDtlsDueToA")]
    #endif
    [IsoXmlTag("RqrmntDtlsDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; } 
    #else
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_EIYSr1nMEeSPgY23yCMQSQ")]
    [DisplayName("Requirement Details Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqrmntDtlsDueToB")]
    #endif
    [IsoXmlTag("RqrmntDtlsDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; } 
    #else
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    [IsoId("_EIYSsVnMEeSPgY23yCMQSQ")]
    [DisplayName("Margin Call Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnCallRslt")]
    #endif
    [IsoXmlTag("MrgnCallRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginCallResult3 MarginCallResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarginCallResult3 MarginCallResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCallResult3 MarginCallResult { get; init; } 
    #else
    public MarginCallResult3 MarginCallResult { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_EIYSs1nMEeSPgY23yCMQSQ")]
    [DisplayName("Expected Collateral Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdCollDueToB")]
    #endif
    [IsoXmlTag("XpctdCollDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpectedCollateral1Choice_? ExpectedCollateralDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpectedCollateral1Choice_? ExpectedCollateralDueToB { get; init; } 
    #else
    public ExpectedCollateral1Choice_? ExpectedCollateralDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_EIYStVnMEeSPgY23yCMQSQ")]
    [DisplayName("Expected Collateral Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdCollDueToA")]
    #endif
    [IsoXmlTag("XpctdCollDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpectedCollateral1Choice_? ExpectedCollateralDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpectedCollateral1Choice_? ExpectedCollateralDueToA { get; init; } 
    #else
    public ExpectedCollateral1Choice_? ExpectedCollateralDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_EIYSt1nMEeSPgY23yCMQSQ")]
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
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;MarginCallRequestV03Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MarginCallRequestV03Document ToDocument()
    {
        return new MarginCallRequestV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;MarginCallRequestV03&quot;/&gt;.
/// </summary>
[Serializable]
public partial record MarginCallRequestV03Document : IOuterDocument<MarginCallRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;MarginCallRequestV03&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginCallRequestV03 Message { get; init; }
    #else
    public MarginCallRequestV03 Message { get; init; }
    #endif
}
