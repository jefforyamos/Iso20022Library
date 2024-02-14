﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountClosingAmendmentRequestV01.  ISO2002 ID# _nlQomNE9Ed-BzquC8wXy7w_1266077822.
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


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.
/// Usage
/// This message may only be sent in response to a request from the financial institution to send additional information.
/// It could be sent together with other related documents.
/// </summary>
[Description(@"Scope|The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.|Usage|This message may only be sent in response to a request from the financial institution to send additional information.|It could be sent together with other related documents.")]
[IsoId("_nlQomNE9Ed-BzquC8wXy7w_1266077822")]
[DisplayName("Account Closing Amendment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountClosingAmendmentRequestV01 : IOuterRecord<AccountClosingAmendmentRequestV01,AccountClosingAmendmentRequestV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.020.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctClsgAmdmntReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountClosingAmendmentRequestV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountClosingAmendmentRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountClosingAmendmentRequestV01( References4 reqReferences,AccountForAction1 reqAccountIdentification,BranchAndFinancialInstitutionIdentification4 reqAccountServicerIdentification,OrganisationIdentification6 reqOrganisationIdentification )
    {
        References = reqReferences;
        AccountIdentification = reqAccountIdentification;
        AccountServicerIdentification = reqAccountServicerIdentification;
        OrganisationIdentification = reqOrganisationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_nlQomdE9Ed-BzquC8wXy7w_-908345623")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References4 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References4 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References4 References { get; init; } 
    #else
    public References4 References { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_nlQomtE9Ed-BzquC8wXy7w_-1865223147")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountForAction1 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountForAction1 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountForAction1 AccountIdentification { get; init; } 
    #else
    public AccountForAction1 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_nlaZkNE9Ed-BzquC8wXy7w_-814283343")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_nlaZkdE9Ed-BzquC8wXy7w_1006271356")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgId")]
    #endif
    [IsoXmlTag("OrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification6 OrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_nlaZktE9Ed-BzquC8wXy7w_-53663536")]
    [DisplayName("Contract Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctDts")]
    #endif
    [IsoXmlTag("CtrctDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountContract4? ContractDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountContract4? ContractDates { get; init; } 
    #else
    public AccountContract4? ContractDates { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.
    /// </summary>
    [IsoId("_nlaZk9E9Ed-BzquC8wXy7w_-114881708")]
    [DisplayName("Balance Transfer Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrfAcct")]
    #endif
    [IsoXmlTag("BalTrfAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountForAction1? BalanceTransferAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountForAction1? BalanceTransferAccount { get; init; } 
    #else
    public AccountForAction1? BalanceTransferAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.
    /// </summary>
    [IsoId("_nlaZlNE9Ed-BzquC8wXy7w_258218512")]
    [DisplayName("Transfer Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfAcctSvcrId")]
    #endif
    [IsoXmlTag("TrfAcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? TransferAccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? TransferAccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? TransferAccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_nlaZldE9Ed-BzquC8wXy7w_-944215031")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature1? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature1? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature1? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AccountClosingAmendmentRequestV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountClosingAmendmentRequestV01Document ToDocument()
    {
        return new AccountClosingAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AccountClosingAmendmentRequestV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AccountClosingAmendmentRequestV01Document : IOuterDocument<AccountClosingAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.020.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AccountClosingAmendmentRequestV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountClosingAmendmentRequestV01 Message { get; init; }
    #else
    public AccountClosingAmendmentRequestV01 Message { get; init; }
    #endif
}
