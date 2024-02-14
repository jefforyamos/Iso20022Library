﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstitutionCreditTransferV10.  ISO2002 ID# _jMaBP9cBEeq_l4BJLVUF2Q.
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
/// This record is an implementation of the pacs.009.001.10 ISO standard message type.
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
[IsoId("_jMaBP9cBEeq_l4BJLVUF2Q")]
[DisplayName("Financial Institution Credit Transfer V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionCreditTransferV10 : IOuterRecord<FinancialInstitutionCreditTransferV10,FinancialInstitutionCreditTransferV10Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.009.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FICdtTrf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FinancialInstitutionCreditTransferV10Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstitutionCreditTransferV10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstitutionCreditTransferV10( GroupHeader96 reqGroupHeader,CreditTransferTransaction56 reqCreditTransferTransactionInformation )
    {
        GroupHeader = reqGroupHeader;
        CreditTransferTransactionInformation = reqCreditTransferTransactionInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_jMaBVdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader96 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader96 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader96 GroupHeader { get; init; } 
    #else
    public GroupHeader96 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing information specific to the individual credit transfer(s).
    /// </summary>
    [IsoId("_jMaBV9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Credit Transfer Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtTrfTxInf")]
    #endif
    [IsoXmlTag("CdtTrfTxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditTransferTransaction56 CreditTransferTransactionInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditTransferTransaction56 CreditTransferTransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransferTransaction56 CreditTransferTransactionInformation { get; init; } 
    #else
    public CreditTransferTransaction56 CreditTransferTransactionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jMaBWdcBEeq_l4BJLVUF2Q")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;FinancialInstitutionCreditTransferV10Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstitutionCreditTransferV10Document ToDocument()
    {
        return new FinancialInstitutionCreditTransferV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;FinancialInstitutionCreditTransferV10&quot;/&gt;.
/// </summary>
[Serializable]
public partial record FinancialInstitutionCreditTransferV10Document : IOuterDocument<FinancialInstitutionCreditTransferV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;FinancialInstitutionCreditTransferV10&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionCreditTransferV10 Message { get; init; }
    #else
    public FinancialInstitutionCreditTransferV10 Message { get; init; }
    #endif
}
