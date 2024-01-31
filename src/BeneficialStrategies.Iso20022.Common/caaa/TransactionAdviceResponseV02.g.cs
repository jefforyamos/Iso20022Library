﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransactionAdviceResponseV02.  ISO2002 ID# __d4GQS1yEeuZtpnZJ4v-5Q.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.")]
public partial record TransactionAdviceResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxAdvcRspn";
    
    #nullable enable
    /// <summary>
    /// Completion advice message management information.
    /// </summary>
    [IsoId("__d4GQy1yEeuZtpnZJ4v-5Q")]
    [Description(@"Completion advice message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the transaction advice response.
    /// </summary>
    [IsoId("__d4GRS1yEeuZtpnZJ4v-5Q")]
    [Description(@"Information related to the transaction advice response.")]
    [DataMember(Name="TxAdvcRspn")]
    [XmlElement(ElementName="TxAdvcRspn")]
    [Required]
    public required AcceptorCompletionAdviceResponse9 TransactionAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("__d4GRy1yEeuZtpnZJ4v-5Q")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType27? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransactionAdviceResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransactionAdviceResponseV02Document ToDocument()
    {
        return new TransactionAdviceResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransactionAdviceResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransactionAdviceResponseV02Document : IOuterDocument<TransactionAdviceResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.021.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransactionAdviceResponseV02"/> is required.
    /// </summary>
    public required TransactionAdviceResponseV02 Message { get; init; }
}
