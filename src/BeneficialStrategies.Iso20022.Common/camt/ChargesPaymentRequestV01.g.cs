﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ChargesPaymentRequestV01.  ISO2002 ID# _Q2jcwKdBEeqY6dwgI6s5vg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.106.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ChargesPaymentRequest message is sent by a financial institution to another financial institution to request the payment of charges, interest and/or other expenses which are previously unknown to the receiver.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ChargesPaymentRequest message is sent by a financial institution to another financial institution to request the payment of charges, interest and/or other expenses which are previously unknown to the receiver.")]
public partial record ChargesPaymentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.106.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChrgsPmtReq";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics shared by all individual charges records included in the message.
    /// </summary>
    [IsoId("_jGeDASkYEeuBrrgCSpsocg")]
    [Description(@"Set of characteristics shared by all individual charges records included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader102 GroupHeader { get; init; }
    
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the underlying transaction.
    /// </summary>
    [IsoId("_5ShVQKdBEeqY6dwgI6s5vg")]
    [Description(@"Provides information on the charges to be paid by the charge bearer(s) related to the processing of the underlying transaction.")]
    [DataMember(Name="Chrgs")]
    [XmlElement(ElementName="Chrgs")]
    [Required]
    public required ChargesRecord5 Charges { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_fu1SMbR_Eeq3lpO-mRtrig")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ChargesPaymentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ChargesPaymentRequestV01Document ToDocument()
    {
        return new ChargesPaymentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ChargesPaymentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ChargesPaymentRequestV01Document : IOuterDocument<ChargesPaymentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.106.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ChargesPaymentRequestV01"/> is required.
    /// </summary>
    public required ChargesPaymentRequestV01 Message { get; init; }
}
