﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountHoldingInformationV07.  ISO2002 ID# _14iFkUyFEeir2sRRVd9XhA.
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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.018.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountHoldingInformation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party, for example, a (new) plan manager (transferee), to provide information about financial instruments held on behalf of a client.
/// Usage
/// The AccountHoldingInformation message is used to provide information the individual assets held in a client's account. The assets may be part of a tax efficient product, a pension of general investment product.
/// </summary>
[Description(@"Scope|The AccountHoldingInformation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party, for example, a (new) plan manager (transferee), to provide information about financial instruments held on behalf of a client.|Usage|The AccountHoldingInformation message is used to provide information the individual assets held in a client's account. The assets may be part of a tax efficient product, a pension of general investment product.")]
[IsoId("_14iFkUyFEeir2sRRVd9XhA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Account Holding Information V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountHoldingInformationV07 : IOuterRecord<AccountHoldingInformationV07,AccountHoldingInformationV07Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.018.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountHoldingInformationV07Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountHoldingInformationV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountHoldingInformationV07( MessageIdentification1 reqMessageReference,InvestmentAccount69 reqTransferorAccount,PartyIdentification132 reqTransferee,PortfolioTransfer2 reqProductTransfer )
    {
        MessageReference = reqMessageReference;
        TransferorAccount = reqTransferorAccount;
        Transferee = reqTransferee;
        ProductTransfer = reqProductTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_14iFn0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 MessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageReference { get; init; } 
    #else
    public MessageIdentification1 MessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_14iFoUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pool Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference11? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference11? PoolReference { get; init; } 
    #else
    public AdditionalReference11? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_14iFo0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? PreviousReference { get; init; } 
    #else
    public AdditionalReference10? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_14iFpUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? RelatedReference { get; init; } 
    #else
    public AdditionalReference10? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Business flow direction (assets to be delivered or received).
    /// </summary>
    [IsoId("_14iFp0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Business Flow Direction Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; } 
    #else
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_14iFqUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Primary Individual Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? PrimaryIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_14iFq0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Secondary Individual Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? SecondaryIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_14iFrUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Individual Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? OtherIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_14iFr0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Primary Corporate Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation36? PrimaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation36? PrimaryCorporateInvestor { get; init; } 
    #else
    public Organisation36? PrimaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_14iFsUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Secondary Corporate Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation36? SecondaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation36? SecondaryCorporateInvestor { get; init; } 
    #else
    public Organisation36? SecondaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_14iFs0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Corporate Investor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation36? OtherCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation36? OtherCorporateInvestor { get; init; } 
    #else
    public Organisation36? OtherCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_14iFtUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transferor Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount69 TransferorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InvestmentAccount69 TransferorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount69 TransferorAccount { get; init; } 
    #else
    public InvestmentAccount69 TransferorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_14iFt0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Nominee Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount69? NomineeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount69? NomineeAccount { get; init; } 
    #else
    public InvestmentAccount69? NomineeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.
    /// </summary>
    [IsoId("_14iFuUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transferee")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification132 Transferee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification132 Transferee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification132 Transferee { get; init; } 
    #else
    public PartyIdentification132 Transferee { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the portfolio and assets.
    /// </summary>
    [IsoId("_14iFu0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product Transfer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PortfolioTransfer2 ProductTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PortfolioTransfer2 ProductTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PortfolioTransfer2 ProductTransfer { get; init; } 
    #else
    public PortfolioTransfer2 ProductTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_14iFvUyFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Market Practice Version")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #else
    public MarketPracticeVersion1? MarketPracticeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_14iFv0yFEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Extension")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountHoldingInformationV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountHoldingInformationV07Document ToDocument()
    {
        return new AccountHoldingInformationV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountHoldingInformationV07"/>.
/// </summary>
[Serializable]
public partial record AccountHoldingInformationV07Document : IOuterDocument<AccountHoldingInformationV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.018.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountHoldingInformationV07"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountHoldingInformationV07 Message { get; init; }
    #else
    public AccountHoldingInformationV07 Message { get; init; }
    #endif
}
