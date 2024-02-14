﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFICustomerDirectDebitV05.  ISO2002 ID# _fTgL6xPeEeSVo-TFVwFHvA.
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
/// This record is an implementation of the pacs.003.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the creditor agent to the debtor agent, directly or through other agents and/or a payment clearing and settlement system.
/// It is used to collect funds from a debtor account for a creditor.
/// Usage
/// The FItoFICustomerDirectDebit message can contain one or more customer direct debit instructions.
/// The FIToFICustomerDirectDebit message does not allow for grouping: the PaymentInformation block must be present once per occurrence of a DirectDebitTransactionInformation block.
/// The FItoFICustomerDirectDebit message may or may not contain mandate related information, i.e. extracts from a mandate, such as the MandateIdentification or DateOfSignature. The FIToFICustomerDirectDebit message must not be considered as a mandate.
/// The FItoFICustomerDirectDebit message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(@"Scope|The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the creditor agent to the debtor agent, directly or through other agents and/or a payment clearing and settlement system.|It is used to collect funds from a debtor account for a creditor.|Usage|The FItoFICustomerDirectDebit message can contain one or more customer direct debit instructions.|The FIToFICustomerDirectDebit message does not allow for grouping: the PaymentInformation block must be present once per occurrence of a DirectDebitTransactionInformation block.|The FItoFICustomerDirectDebit message may or may not contain mandate related information, i.e. extracts from a mandate, such as the MandateIdentification or DateOfSignature. The FIToFICustomerDirectDebit message must not be considered as a mandate.|The FItoFICustomerDirectDebit message can be used in domestic and cross-border scenarios.")]
[IsoId("_fTgL6xPeEeSVo-TFVwFHvA")]
[DisplayName("FI To FI Customer Direct Debit V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FIToFICustomerDirectDebitV05 : IOuterRecord<FIToFICustomerDirectDebitV05,FIToFICustomerDirectDebitV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.003.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFICstmrDrctDbt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FIToFICustomerDirectDebitV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FIToFICustomerDirectDebitV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FIToFICustomerDirectDebitV05( GroupHeader50 reqGroupHeader,DirectDebitTransactionInformation17 reqDirectDebitTransactionInformation )
    {
        GroupHeader = reqGroupHeader;
        DirectDebitTransactionInformation = reqDirectDebitTransactionInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_fTgL_RPeEeSVo-TFVwFHvA")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader50 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader50 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader50 GroupHeader { get; init; } 
    #else
    public GroupHeader50 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing information specific to the individual direct debit(s).
    /// </summary>
    [IsoId("_fTgL_xPeEeSVo-TFVwFHvA")]
    [DisplayName("Direct Debit Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtTxInf")]
    #endif
    [IsoXmlTag("DrctDbtTxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DirectDebitTransactionInformation17 DirectDebitTransactionInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DirectDebitTransactionInformation17 DirectDebitTransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DirectDebitTransactionInformation17 DirectDebitTransactionInformation { get; init; } 
    #else
    public DirectDebitTransactionInformation17 DirectDebitTransactionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_fTgMARPeEeSVo-TFVwFHvA")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;FIToFICustomerDirectDebitV05Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFICustomerDirectDebitV05Document ToDocument()
    {
        return new FIToFICustomerDirectDebitV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;FIToFICustomerDirectDebitV05&quot;/&gt;.
/// </summary>
[Serializable]
public partial record FIToFICustomerDirectDebitV05Document : IOuterDocument<FIToFICustomerDirectDebitV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.003.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;FIToFICustomerDirectDebitV05&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FIToFICustomerDirectDebitV05 Message { get; init; }
    #else
    public FIToFICustomerDirectDebitV05 Message { get; init; }
    #endif
}
