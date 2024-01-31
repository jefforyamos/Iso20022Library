﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferOutConfirmationV02.  ISO2002 ID# _K162q9E6Ed-BzquC8wXy7w_-1621966121.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.003.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a transfer agent, sends the TransferOutConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to confirm the delivery of a financial instrument, free of payment, on a given date, to a specified party.
/// This message may also be used to confirm the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.
/// Usage
/// The TransferOutConfirmation message is used to confirm the withdrawal of a financial instrument from the owner's account and its delivery to another own account, or to a third party, has taken place.
/// The reference of the transfer confirmation is identified in TransferConfirmationReference. The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferOutInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, eg, a transfer agent, sends the TransferOutConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to confirm the delivery of a financial instrument, free of payment, on a given date, to a specified party.|This message may also be used to confirm the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.|Usage|The TransferOutConfirmation message is used to confirm the withdrawal of a financial instrument from the owner's account and its delivery to another own account, or to a third party, has taken place.|The reference of the transfer confirmation is identified in TransferConfirmationReference. The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferOutInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.")]
public partial record TransferOutConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.003.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutConfV02";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_K162rNE6Ed-BzquC8wXy7w_-1063236935")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K162rdE6Ed-BzquC8wXy7w_-1621965748")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_K162rtE6Ed-BzquC8wXy7w_-1621965713")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_K2EnoNE6Ed-BzquC8wXy7w_-1621965688")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_K2EnodE6Ed-BzquC8wXy7w_-1621966094")]
    [Description(@"General information related to the transfer of a financial instrument.")]
    [DataMember(Name="TrfDtls")]
    [XmlElement(ElementName="TrfDtls")]
    [Required]
    public required Transfer10 TransferDetails { get; init; }
    
    /// <summary>
    /// Information related to the financial instrument withdrawn.
    /// </summary>
    [IsoId("_K2EnotE6Ed-BzquC8wXy7w_-1621966060")]
    [Description(@"Information related to the financial instrument withdrawn.")]
    [DataMember(Name="FinInstrmDtls")]
    [XmlElement(ElementName="FinInstrmDtls")]
    [Required]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }
    
    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_K2Eno9E6Ed-BzquC8wXy7w_-1621966043")]
    [Description(@"Information related to the account from which the financial instrument was withdrawn.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required InvestmentAccount22 AccountDetails { get; init; }
    
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_K2EnpNE6Ed-BzquC8wXy7w_-1621965783")]
    [Description(@"Information related to the receiving side of the transfer.")]
    [DataMember(Name="SttlmDtls")]
    [XmlElement(ElementName="SttlmDtls")]
    [Required]
    public required ReceiveInformation4 SettlementDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_K2EnpdE6Ed-BzquC8wXy7w_-880610549")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_K2EnptE6Ed-BzquC8wXy7w_-1621045682")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferOutConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferOutConfirmationV02Document ToDocument()
    {
        return new TransferOutConfirmationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferOutConfirmationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferOutConfirmationV02Document : IOuterDocument<TransferOutConfirmationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferOutConfirmationV02"/> is required.
    /// </summary>
    public required TransferOutConfirmationV02 Message { get; init; }
}
