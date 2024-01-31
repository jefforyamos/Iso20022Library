﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FullPushThroughReportV04.  ISO2002 ID# _9e8ZUdNTEeK-v49t1oWkNA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// This record is an implementation of the tsmt.018.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FullPushThroughReport message is sent by the matching application to a party involved in a transaction.
/// This message is used to pass on information that the matching application has received from the submitter. The forwarded information can originate from an InitialBaselineSubmission or BaselineReSubmission or BaselineAmendmentRequest message.
/// Usage
/// The FullPushThroughReport message can be sent by the matching application to a party to convey
/// - the details of an InitialBaselineSubmission message that it has obtained, or
/// - the details of a BaselineResubmission message that it has obtained, or
/// - the details of a BaselineAmendmentRequest message that it has obtained.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FullPushThroughReport message is sent by the matching application to a party involved in a transaction.|This message is used to pass on information that the matching application has received from the submitter. The forwarded information can originate from an InitialBaselineSubmission or BaselineReSubmission or BaselineAmendmentRequest message.|Usage|The FullPushThroughReport message can be sent by the matching application to a party to convey|- the details of an InitialBaselineSubmission message that it has obtained, or|- the details of a BaselineResubmission message that it has obtained, or|- the details of a BaselineAmendmentRequest message that it has obtained.")]
public partial record FullPushThroughReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.018.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FullPushThrghRpt";
    
    #nullable enable
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_9e8ZU9NTEeK-v49t1oWkNA")]
    [Description(@"Identifies the report.")]
    [DataMember(Name="RptId")]
    [XmlElement(ElementName="RptId")]
    [Required]
    public required MessageIdentification1 ReportIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_9e8ZVdNTEeK-v49t1oWkNA")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_9e8ZV9NTEeK-v49t1oWkNA")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_9e8ZWdNTEeK-v49t1oWkNA")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    [Required]
    public required TransactionStatus4 TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the financial institution which submitted the baseline.
    /// </summary>
    [IsoId("_9e8ZW9NTEeK-v49t1oWkNA")]
    [Description(@"Reference to the transaction for the financial institution which submitted the baseline.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required IReadOnlyCollection<DocumentIdentification5> UserTransactionReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Specifies the type of report.
    /// </summary>
    [IsoId("_9e8ZXdNTEeK-v49t1oWkNA")]
    [Description(@"Specifies the type of report.")]
    [DataMember(Name="RptPurp")]
    [XmlElement(ElementName="RptPurp")]
    [Required]
    public required ReportType1 ReportPurpose { get; init; }
    
    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_9e9AYdNTEeK-v49t1oWkNA")]
    [Description(@"Specifies the commercial details of the underlying transaction.")]
    [DataMember(Name="PushdThrghBaseln")]
    [XmlElement(ElementName="PushdThrghBaseln")]
    [Required]
    public required Baseline4 PushedThroughBaseline { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_9e9AY9NTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in the organisation of the buyer.")]
    [DataMember(Name="BuyrCtctPrsn")]
    [XmlElement(ElementName="BuyrCtctPrsn")]
    public ContactIdentification1? BuyerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_9e9AZdNTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in the organisation of the seller.")]
    [DataMember(Name="SellrCtctPrsn")]
    [XmlElement(ElementName="SellrCtctPrsn")]
    public ContactIdentification1? SellerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the buyer's bank.
    /// </summary>
    [IsoId("_9e9AZ9NTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in the buyer's bank.")]
    [DataMember(Name="BuyrBkCtctPrsn")]
    [XmlElement(ElementName="BuyrBkCtctPrsn")]
    public ContactIdentification1? BuyerBankContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the seller's bank.
    /// </summary>
    [IsoId("_9e9AadNTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in the seller's bank.")]
    [DataMember(Name="SellrBkCtctPrsn")]
    [XmlElement(ElementName="SellrBkCtctPrsn")]
    public ContactIdentification1? SellerBankContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in another bank than the seller or buyer's bank.
    /// </summary>
    [IsoId("_9e9Aa9NTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in another bank than the seller or buyer's bank.")]
    [DataMember(Name="OthrBkCtctPrsn")]
    [XmlElement(ElementName="OthrBkCtctPrsn")]
    public ContactIdentification3? OtherBankContactPerson { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_9e9AbdNTEeK-v49t1oWkNA")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FullPushThroughReportV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FullPushThroughReportV04Document ToDocument()
    {
        return new FullPushThroughReportV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FullPushThroughReportV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FullPushThroughReportV04Document : IOuterDocument<FullPushThroughReportV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.018.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FullPushThroughReportV04"/> is required.
    /// </summary>
    public required FullPushThroughReportV04 Message { get; init; }
}
