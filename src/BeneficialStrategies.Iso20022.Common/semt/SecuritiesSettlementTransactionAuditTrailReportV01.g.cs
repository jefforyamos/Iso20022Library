﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionAuditTrailReportV01.  ISO2002 ID# _0aI3cwlIEeGATtfOBToyew_1127428925.
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


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.022.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope||This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.|||Usage||The message may also be used to: ||- re-send a message sent by the market infrastructure to the direct participant,||- provide a third party with a copy of a message being sent by the market infrastructure for information,||- re-send to a third party a copy of a message being sent by the market infrastructure for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope||This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.|||Usage||The message may also be used to: ||- re-send a message sent by the market infrastructure to the direct participant,||- provide a third party with a copy of a message being sent by the market infrastructure for information,||- re-send to a third party a copy of a message being sent by the market infrastructure for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_0aI3cwlIEeGATtfOBToyew_1127428925")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Settlement Transaction Audit Trail Report V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionAuditTrailReportV01 : IOuterRecord<SecuritiesSettlementTransactionAuditTrailReportV01,SecuritiesSettlementTransactionAuditTrailReportV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.022.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAudtTrlRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionAuditTrailReportV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSettlementTransactionAuditTrailReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionAuditTrailReportV01( Pagination reqPagination,SecuritiesAccount13 reqSafekeepingAccount )
    {
        Pagination = reqPagination;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_0aI3dAlIEeGATtfOBToyew_770277104")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pagination")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Pagination Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination Pagination { get; init; } 
    #else
    public Pagination Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the SecuritiesStatusQuery message sent to request this report.
    /// </summary>
    [IsoId("_0aI3dQlIEeGATtfOBToyew_-104102326")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Query Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Identification1? QueryReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification1? QueryReference { get; init; } 
    #else
    public Identification1? QueryReference { get; set; } 
    #endif
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_0aSBYAlIEeGATtfOBToyew_651650250")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifications15? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications15? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifications15? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_0aSBYQlIEeGATtfOBToyew_-2138878469")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount13 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_0aSBYglIEeGATtfOBToyew_1026373226")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification36Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    ///  Provides the history of status and reasons for a pending, posted or cancelled transaction.
    /// </summary>
    [IsoId("_0aSBYwlIEeGATtfOBToyew_-65818240")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status Trail")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusTrail2? StatusTrail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusTrail2? StatusTrail { get; init; } 
    #else
    public StatusTrail2? StatusTrail { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionAuditTrailReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionAuditTrailReportV01Document ToDocument()
    {
        return new SecuritiesSettlementTransactionAuditTrailReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionAuditTrailReportV01"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionAuditTrailReportV01Document : IOuterDocument<SecuritiesSettlementTransactionAuditTrailReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.022.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionAuditTrailReportV01"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSettlementTransactionAuditTrailReportV01 Message { get; init; }
    #else
    public SecuritiesSettlementTransactionAuditTrailReportV01 Message { get; init; }
    #endif
}
