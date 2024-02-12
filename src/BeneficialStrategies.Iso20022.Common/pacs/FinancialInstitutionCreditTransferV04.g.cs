﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstitutionCreditTransferV04.  ISO2002 ID# _dv-LESGnEeKjd4jizyIDGA.
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


namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.009.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionCreditTransfer message is sent by a debtor financial institution to a creditor financial institution, directly or through other agents and/or a payment clearing and settlement system.
/// It is used to move funds from a debtor account to a creditor, where both debtor and creditor are financial institutions.
/// Usage
/// The FinancialInstitutionCreditTransfer message is exchanged between agents and can contain one or more credit transfer instructions where debtor and creditor are both financial institutions.
/// The FinancialInstitutionCreditTransfer message does not allow for grouping: a CreditTransferTransactionInformation block must be present for each credit transfer transaction.
/// The FinancialInstitutionCreditTransfer message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(@"Scope|The FinancialInstitutionCreditTransfer message is sent by a debtor financial institution to a creditor financial institution, directly or through other agents and/or a payment clearing and settlement system.|It is used to move funds from a debtor account to a creditor, where both debtor and creditor are financial institutions.|Usage|The FinancialInstitutionCreditTransfer message is exchanged between agents and can contain one or more credit transfer instructions where debtor and creditor are both financial institutions.|The FinancialInstitutionCreditTransfer message does not allow for grouping: a CreditTransferTransactionInformation block must be present for each credit transfer transaction.|The FinancialInstitutionCreditTransfer message can be used in domestic and cross-border scenarios.")]
[IsoId("_dv-LESGnEeKjd4jizyIDGA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Institution Credit Transfer V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionCreditTransferV04 : IOuterRecord<FinancialInstitutionCreditTransferV04,FinancialInstitutionCreditTransferV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.009.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FICdtTrf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FinancialInstitutionCreditTransferV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstitutionCreditTransferV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstitutionCreditTransferV04( GroupHeader49 reqGroupHeader,CreditTransferTransaction8 reqCreditTransferTransactionInformation )
    {
        GroupHeader = reqGroupHeader;
        CreditTransferTransactionInformation = reqCreditTransferTransactionInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_dv-LLyGnEeKjd4jizyIDGA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader49 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GroupHeader49 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader49 GroupHeader { get; init; } 
    #else
    public GroupHeader49 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing information specific to the individual credit transfer(s).
    /// </summary>
    [IsoId("_dv-LMyGnEeKjd4jizyIDGA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Credit Transfer Transaction Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditTransferTransaction8 CreditTransferTransactionInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CreditTransferTransaction8 CreditTransferTransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransferTransaction8 CreditTransferTransactionInformation { get; init; } 
    #else
    public CreditTransferTransaction8 CreditTransferTransactionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_dv-LNyGnEeKjd4jizyIDGA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstitutionCreditTransferV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstitutionCreditTransferV04Document ToDocument()
    {
        return new FinancialInstitutionCreditTransferV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstitutionCreditTransferV04"/>.
/// </summary>
[Serializable]
public partial record FinancialInstitutionCreditTransferV04Document : IOuterDocument<FinancialInstitutionCreditTransferV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstitutionCreditTransferV04"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionCreditTransferV04 Message { get; init; }
    #else
    public FinancialInstitutionCreditTransferV04 Message { get; init; }
    #endif
}
