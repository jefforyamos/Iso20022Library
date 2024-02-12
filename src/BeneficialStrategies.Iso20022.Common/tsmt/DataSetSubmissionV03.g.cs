﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DataSetSubmissionV03.  ISO2002 ID# _nQ9pAtE8Ed-BzquC8wXy7w_2054511397.
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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.014.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DataSetSubmission message is sent by a party involved in the transaction to the matching application.
/// This message is used to trigger either a match or a pre-match of the information submitted with the message.
/// Usage
/// The DataSetSubmission message can be sent by either party with the instruction pre-match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to the requester of the data set pre-match by sending a DataSetMatchReport message.
/// or
/// The DataSetSubmission message can be sent by the party specified in the baseline as data set submitter with the instruction match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to
/// - the parties involved in a transaction established in the push-through mode, or
/// - the initiator of a transaction established in the lodge mode.
/// The DataSetSubmission message can be used to submit multiple data sets for multiple transactions (baselines) at the same time. However, all transactions (baselines) covered by the message must be for the same parties, that is transaction initiator and counterparty, as well as for the same buyer and seller.
/// The DataSetSubmission message consists of data reflecting trade information related to the purchasing agreement covered by the transaction(s), for example shipment date, invoice amount.
/// </summary>
[Description(@"Scope|The DataSetSubmission message is sent by a party involved in the transaction to the matching application.|This message is used to trigger either a match or a pre-match of the information submitted with the message.|Usage|The DataSetSubmission message can be sent by either party with the instruction pre-match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to the requester of the data set pre-match by sending a DataSetMatchReport message.|or|The DataSetSubmission message can be sent by the party specified in the baseline as data set submitter with the instruction match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to|- the parties involved in a transaction established in the push-through mode, or|- the initiator of a transaction established in the lodge mode.|The DataSetSubmission message can be used to submit multiple data sets for multiple transactions (baselines) at the same time. However, all transactions (baselines) covered by the message must be for the same parties, that is transaction initiator and counterparty, as well as for the same buyer and seller.|The DataSetSubmission message consists of data reflecting trade information related to the purchasing agreement covered by the transaction(s), for example shipment date, invoice amount.")]
[IsoId("_nQ9pAtE8Ed-BzquC8wXy7w_2054511397")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Data Set Submission V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DataSetSubmissionV03 : IOuterRecord<DataSetSubmissionV03,DataSetSubmissionV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.014.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DataSetSubmissn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DataSetSubmissionV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DataSetSubmissionV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DataSetSubmissionV03( MessageIdentification1 reqSubmissionIdentification,DataSetSubmissionReferences3 reqRelatedTransactionReferences,SimpleIdentificationInformation reqCommonSubmissionReference,InstructionType3 reqInstruction,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank )
    {
        SubmissionIdentification = reqSubmissionIdentification;
        RelatedTransactionReferences = reqRelatedTransactionReferences;
        CommonSubmissionReference = reqCommonSubmissionReference;
        Instruction = reqInstruction;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_nQ9pA9E8Ed-BzquC8wXy7w_2054512310")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Submission Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 SubmissionIdentification { get; init; } 
    #else
    public MessageIdentification1 SubmissionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the transactions that this submission relates to and provides associated information.
    /// </summary>
    [IsoId("_nQ9pBNE8Ed-BzquC8wXy7w_2054512233")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Transaction References")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetSubmissionReferences3 RelatedTransactionReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DataSetSubmissionReferences3 RelatedTransactionReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetSubmissionReferences3 RelatedTransactionReferences { get; init; } 
    #else
    public DataSetSubmissionReferences3 RelatedTransactionReferences { get; set; } 
    #endif
    
    /// <summary>
    /// This reference must be used for all data sets belonging to the same submission group.
    /// </summary>
    [IsoId("_nQ9pBdE8Ed-BzquC8wXy7w_645845159")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Common Submission Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation CommonSubmissionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SimpleIdentificationInformation CommonSubmissionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation CommonSubmissionReference { get; init; } 
    #else
    public SimpleIdentificationInformation CommonSubmissionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the instruction given by the submitter.
    /// </summary>
    [IsoId("_nQ9pBtE8Ed-BzquC8wXy7w_2054512725")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionType3 Instruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InstructionType3 Instruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionType3 Instruction { get; init; } 
    #else
    public InstructionType3 Instruction { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nQ9pB9E8Ed-BzquC8wXy7w_2054511535")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Buyer Bank")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BICIdentification1 BuyerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 BuyerBank { get; init; } 
    #else
    public BICIdentification1 BuyerBank { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nQ9pCNE8Ed-BzquC8wXy7w_2054511830")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Seller Bank")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BICIdentification1 SellerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 SellerBank { get; init; } 
    #else
    public BICIdentification1 SellerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Commercial information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaANE8Ed-BzquC8wXy7w_2054511458")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Commercial Data Set")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommercialDataSet3? CommercialDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommercialDataSet3? CommercialDataSet { get; init; } 
    #else
    public CommercialDataSet3? CommercialDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Transport information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaAdE8Ed-BzquC8wXy7w_2054512430")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transport Data Set")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportDataSet3? TransportDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportDataSet3? TransportDataSet { get; init; } 
    #else
    public TransportDataSet3? TransportDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Insurance information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaAtE8Ed-BzquC8wXy7w_-215437655")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Insurance Data Set")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InsuranceDataSet1? InsuranceDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InsuranceDataSet1? InsuranceDataSet { get; init; } 
    #else
    public InsuranceDataSet1? InsuranceDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaA9E8Ed-BzquC8wXy7w_-73215564")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Data Set")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CertificateDataSet1? CertificateDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateDataSet1? CertificateDataSet { get; init; } 
    #else
    public CertificateDataSet1? CertificateDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Other certificate information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaBNE8Ed-BzquC8wXy7w_1984114743")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Certificate Data Set")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; init; } 
    #else
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DataSetSubmissionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DataSetSubmissionV03Document ToDocument()
    {
        return new DataSetSubmissionV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DataSetSubmissionV03"/>.
/// </summary>
[Serializable]
public partial record DataSetSubmissionV03Document : IOuterDocument<DataSetSubmissionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.014.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DataSetSubmissionV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetSubmissionV03 Message { get; init; }
    #else
    public DataSetSubmissionV03 Message { get; init; }
    #endif
}
