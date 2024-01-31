﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SwitchOrderConfirmationCancellationInstructionV02.  ISO2002 ID# _Aab8CzbLEead9bDRE_1DAQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// Scope
/// The SwitchOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SwitchOrderConfirmation.
/// Usage
/// To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SwitchOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SwitchOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the switch order confirmation cancellation is to be followed by an amendment An amendment of a switch order confirmation is carried out by sending a SwitchOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SwitchOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SwitchOrderConfirmation.|Usage|To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SwitchOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SwitchOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the switch order confirmation cancellation is to be followed by an amendment An amendment of a switch order confirmation is carried out by sending a SwitchOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’.")]
public partial record SwitchOrderConfirmationCancellationInstructionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConfCxlInstr";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab8ETbLEead9bDRE_1DAQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab8EzbLEead9bDRE_1DAQ")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab8FTbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab8FzbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_8YrRs1AZEea5nPE5ezGuuw")]
    [Description(@"Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.")]
    [DataMember(Name="AmdmntInd")]
    [XmlElement(ElementName="AmdmntInd")]
    [Required]
    public required IsoYesNoIndicator AmendmentIndicator { get; init; }
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_8YrRtFAZEea5nPE5ezGuuw")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }
    
    /// <summary>
    /// Identification of the individual order confirmation to be cancelled.
    /// </summary>
    [IsoId("_8YrRtVAZEea5nPE5ezGuuw")]
    [Description(@"Identification of the individual order confirmation to be cancelled.")]
    [DataMember(Name="OrdrRefs")]
    [XmlElement(ElementName="OrdrRefs")]
    [Required]
    public required InvestmentFundOrder11 OrderReferences { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab8HTbLEead9bDRE_1DAQ")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SwitchOrderConfirmationCancellationInstructionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SwitchOrderConfirmationCancellationInstructionV02Document ToDocument()
    {
        return new SwitchOrderConfirmationCancellationInstructionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SwitchOrderConfirmationCancellationInstructionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SwitchOrderConfirmationCancellationInstructionV02Document : IOuterDocument<SwitchOrderConfirmationCancellationInstructionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.055.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SwitchOrderConfirmationCancellationInstructionV02"/> is required.
    /// </summary>
    public required SwitchOrderConfirmationCancellationInstructionV02 Message { get; init; }
}
