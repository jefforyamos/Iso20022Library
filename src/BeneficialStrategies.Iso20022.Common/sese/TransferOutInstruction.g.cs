﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferOutInstruction.  ISO2002 ID# _K2NxmNE6Ed-BzquC8wXy7w_-47353492.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// The TransferOutInstruction message is sent by an instructing party, or an instructing party's designated agent, to the executing party.
/// This message is used to instruct the delivery of a financial instrument, free of payment, at a given date, to a specified party. This message can be used to instruct the transfer of a financial instrument to an own account or to a third party.
/// Usage
/// The TransferOutInstruction message is used by an instructing party to instruct the executing party to withdraw a financial instrument from one account and deliver it to either another account or to a third party.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The TransferOutInstruction message is sent by an instructing party, or an instructing party's designated agent, to the executing party.|This message is used to instruct the delivery of a financial instrument, free of payment, at a given date, to a specified party. This message can be used to instruct the transfer of a financial instrument to an own account or to a third party.|Usage|The TransferOutInstruction message is used by an instructing party to instruct the executing party to withdraw a financial instrument from one account and deliver it to either another account or to a third party.")]
public partial record TransferOutInstruction : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.001.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferOutInstructionDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferOutInstructionDocument ToDocument()
    {
        return new TransferOutInstructionDocument { Message = this };
    }
}

/// <summary>
/// Scope
/// The TransferOutInstruction message is sent by an instructing party, or an instructing party's designated agent, to the executing party.
/// This message is used to instruct the delivery of a financial instrument, free of payment, at a given date, to a specified party. This message can be used to instruct the transfer of a financial instrument to an own account or to a third party.
/// Usage
/// The TransferOutInstruction message is used by an instructing party to instruct the executing party to withdraw a financial instrument from one account and deliver it to either another account or to a third party.
/// This is the outer document that contains <seealso cref="TransferOutInstruction"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferOutInstructionDocument : IOuterDocument<TransferOutInstruction>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferOutInstruction"/> is required.
    /// </summary>
    public required TransferOutInstruction Message { get; init; }
}
