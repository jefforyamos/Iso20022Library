﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PartyEventAdviceV01.  ISO2002 ID# _OTgzNTEy-AOSNFX-8224507.
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
/// The PartyEventAdvice message can be sent by any party to any other party. It is used for business letters containing information for which treatment is not formally defined in order to keep partners informed and to maintain business traces, for example confirmations of information exchanged out-of band such as announcing a postal letter, confirming a telephone call or the exchange of contractual information. It can also be sent to verify the technical interoperability of the communicating IT-systems.
/// The message can reference other message and include data from referenced messages.
/// The message can report several events.
/// The message can carry digital signatures if required by context.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The PartyEventAdvice message can be sent by any party to any other party. It is used for business letters containing information for which treatment is not formally defined in order to keep partners informed and to maintain business traces, for example confirmations of information exchanged out-of band such as announcing a postal letter, confirming a telephone call or the exchange of contractual information. It can also be sent to verify the technical interoperability of the communicating IT-systems.|The message can reference other message and include data from referenced messages.|The message can report several events.|The message can carry digital signatures if required by context.")]
public partial record PartyEventAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyEvtAdvc";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics that unambiguously identify the event, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNTEz-AOSNFX-8224507")]
    [Description(@"Set of characteristics that unambiguously identify the event, common parameters, documents and identifications.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required BusinessLetter1 Header { get; init; }
    
    /// <summary>
    /// Description of the event.
    /// </summary>
    [IsoId("_OTgzNTE0-AOSNFX-8224507")]
    [Description(@"Description of the event.")]
    [DataMember(Name="EvtNtce")]
    [XmlElement(ElementName="EvtNtce")]
    [Required]
    public required EventDescription1 EventNotice { get; init; }
    
    /// <summary>
    /// Number of events as control value.
    /// </summary>
    [IsoId("_OTgzNTE1-AOSNFX-8224507")]
    [Description(@"Number of events as control value.")]
    [DataMember(Name="EvtCnt")]
    [XmlElement(ElementName="EvtCnt")]
    public IsoMax15NumericText? EventCount { get; init; }
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNTE2-AOSNFX-8224507")]
    [Description(@"Referenced or related business message.")]
    [DataMember(Name="AttchdMsg")]
    [XmlElement(ElementName="AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PartyEventAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PartyEventAdviceV01Document ToDocument()
    {
        return new PartyEventAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PartyEventAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PartyEventAdviceV01Document : IOuterDocument<PartyEventAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.055.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PartyEventAdviceV01"/> is required.
    /// </summary>
    public required PartyEventAdviceV01 Message { get; init; }
}
