﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransactionAdviceV03.  ISO2002 ID# _6jZ9cU3iEey_VecAUE-C9Q.
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
/// The TransactionAdvice message is sent by the Acquirer (or Agent) to provide to the POI the outcome of a transaction processed outside of this protocol. 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The TransactionAdvice message is sent by the Acquirer (or Agent) to provide to the POI the outcome of a transaction processed outside of this protocol. ")]
public partial record TransactionAdviceV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxAdvc";
    
    #nullable enable
    /// <summary>
    /// Completion advice message management information.
    /// </summary>
    [IsoId("_6jZ9c03iEey_VecAUE-C9Q")]
    [Description(@"Completion advice message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the outcome of the transaction.
    /// </summary>
    [IsoId("_6jZ9dU3iEey_VecAUE-C9Q")]
    [Description(@"Information related to the outcome of the transaction.")]
    [DataMember(Name="TxAdvc")]
    [XmlElement(ElementName="TxAdvc")]
    [Required]
    public required AcceptorCompletionAdvice11 TransactionAdvice { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_6jZ9d03iEey_VecAUE-C9Q")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType31? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransactionAdviceV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransactionAdviceV03Document ToDocument()
    {
        return new TransactionAdviceV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransactionAdviceV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransactionAdviceV03Document : IOuterDocument<TransactionAdviceV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.020.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransactionAdviceV03"/> is required.
    /// </summary>
    public required TransactionAdviceV03 Message { get; init; }
}
