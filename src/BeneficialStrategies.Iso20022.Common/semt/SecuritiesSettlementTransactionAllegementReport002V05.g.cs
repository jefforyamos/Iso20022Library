﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionAllegementReport002V05.  ISO2002 ID# _6MjEUJNLEeWGlc8L7oPDIg.
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
/// This record is an implementation of the semt.019.002.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionAllegementReport to an account owner to provide, at a specified time, the status and details of pending settlement allegements, for all or selected securities in a specified safekeeping account.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionAllegementReport to an account owner to provide, at a specified time, the status and details of pending settlement allegements, for all or selected securities in a specified safekeeping account.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
[IsoId("_6MjEUJNLEeWGlc8L7oPDIg")]
[DisplayName("Securities Settlement Transaction Allegement Report 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionAllegementReport002V05 : IOuterRecord<SecuritiesSettlementTransactionAllegementReport002V05,SecuritiesSettlementTransactionAllegementReport002V05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.019.002.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAllgmtRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionAllegementReport002V05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSettlementTransactionAllegementReport002V05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionAllegementReport002V05( Pagination reqPagination,Statement53 reqStatementGeneralDetails,SecuritiesAccount27 reqSafekeepingAccount )
    {
        Pagination = reqPagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_6MjEVpNLEeWGlc8L7oPDIg")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination Pagination { get; init; } 
    #else
    public Pagination Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to report.
    /// </summary>
    [IsoId("_6MjEWJNLEeWGlc8L7oPDIg")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement53 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement53 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement53 StatementGeneralDetails { get; init; } 
    #else
    public Statement53 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_6MjEWpNLEeWGlc8L7oPDIg")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification109? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification109? AccountOwner { get; init; } 
    #else
    public PartyIdentification109? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_6MjEXJNLEeWGlc8L7oPDIg")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount27 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount27 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount27 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount27 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the allegement.
    /// </summary>
    [IsoId("_6MjEXpNLEeWGlc8L7oPDIg")]
    [DisplayName("Allegement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllgmtDtls")]
    #endif
    [IsoXmlTag("AllgmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTradeDetails61? AllegementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTradeDetails61? AllegementDetails { get; init; } 
    #else
    public SecuritiesTradeDetails61? AllegementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SecuritiesSettlementTransactionAllegementReport002V05Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionAllegementReport002V05Document ToDocument()
    {
        return new SecuritiesSettlementTransactionAllegementReport002V05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SecuritiesSettlementTransactionAllegementReport002V05&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionAllegementReport002V05Document : IOuterDocument<SecuritiesSettlementTransactionAllegementReport002V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.019.002.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SecuritiesSettlementTransactionAllegementReport002V05&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSettlementTransactionAllegementReport002V05 Message { get; init; }
    #else
    public SecuritiesSettlementTransactionAllegementReport002V05 Message { get; init; }
    #endif
}
