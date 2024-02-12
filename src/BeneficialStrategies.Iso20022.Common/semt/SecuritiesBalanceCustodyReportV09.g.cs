﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesBalanceCustodyReportV09.  ISO2002 ID# _YSMWRQCTEeW_3KiG8SEjHA.
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
/// This record is an implementation of the semt.002.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.
/// 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants, or
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer, or
/// - a transfer agent acting on behalf of a fund manager or an account owner's designated agent.
/// 
/// Usage
/// The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided. 
/// The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis. 
/// There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.
/// 
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants, or|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.||Usage|The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided. |The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis. |There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
[IsoId("_YSMWRQCTEeW_3KiG8SEjHA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Balance Custody Report V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesBalanceCustodyReportV09 : IOuterRecord<SecuritiesBalanceCustodyReportV09,SecuritiesBalanceCustodyReportV09Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.002.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalCtdyRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesBalanceCustodyReportV09Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesBalanceCustodyReportV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesBalanceCustodyReportV09( Pagination reqPagination,Statement45 reqStatementGeneralDetails,SecuritiesAccount26 reqSafekeepingAccount )
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
    [IsoId("_YSMWUwCTEeW_3KiG8SEjHA")]
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
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_YSMWVQCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Statement General Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement45 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Statement45 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement45 StatementGeneralDetails { get; init; } 
    #else
    public Statement45 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_YSMWVwCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification98? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification98? AccountOwner { get; init; } 
    #else
    public PartyIdentification98? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.
    /// </summary>
    [IsoId("_YSMWWQCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Servicer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification100? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100? AccountServicer { get; init; } 
    #else
    public PartyIdentification100? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_YSMWWwCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Safekeeping Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount26 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecuritiesAccount26 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount26 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount26 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_YSMWXQCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Intermediary Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(10)]
    #endif
    public ValueList<Intermediary32> IntermediaryInformation { get; init; } = new ValueList<Intermediary32>(){};
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_YSMWXwCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance For Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalanceInformation30? BalanceForAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalanceInformation30? BalanceForAccount { get; init; } 
    #else
    public AggregateBalanceInformation30? BalanceForAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_YSMWYQCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Account Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccountIdentification42? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccountIdentification42? SubAccountDetails { get; init; } 
    #else
    public SubAccountIdentification42? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_YSMWYwCTEeW_3KiG8SEjHA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Base Currency Total Amounts")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalValueInPageAndStatement1? AccountBaseCurrencyTotalAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalValueInPageAndStatement1? AccountBaseCurrencyTotalAmounts { get; init; } 
    #else
    public TotalValueInPageAndStatement1? AccountBaseCurrencyTotalAmounts { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesBalanceCustodyReportV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesBalanceCustodyReportV09Document ToDocument()
    {
        return new SecuritiesBalanceCustodyReportV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesBalanceCustodyReportV09"/>.
/// </summary>
[Serializable]
public partial record SecuritiesBalanceCustodyReportV09Document : IOuterDocument<SecuritiesBalanceCustodyReportV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesBalanceCustodyReportV09"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceCustodyReportV09 Message { get; init; }
    #else
    public SecuritiesBalanceCustodyReportV09 Message { get; init; }
    #endif
}
