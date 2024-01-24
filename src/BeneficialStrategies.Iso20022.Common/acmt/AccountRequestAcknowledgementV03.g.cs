﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountRequestAcknowledgementV03.  ISO2002 ID# _bfzgR22PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountRequestAcknowledgement message is sent from a financial institution to an organisation. This message is sent in response to a request message from the organisation. It is sent after the request has been validated from an authentication and authorisation point of view. The business content has not yet been validated at this stage.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountRequestAcknowledgement message is sent from a financial institution to an organisation. This message is sent in response to a request message from the organisation. It is sent after the request has been validated from an authentication and authorisation point of view. The business content has not yet been validated at this stage.")]
public partial record AccountRequestAcknowledgementV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctReqAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountRequestAcknowledgementV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountRequestAcknowledgementV03Document ToDocument()
    {
        return new AccountRequestAcknowledgementV03Document { Message = this };
    }
}

/// <summary>
/// The AccountRequestAcknowledgement message is sent from a financial institution to an organisation. This message is sent in response to a request message from the organisation. It is sent after the request has been validated from an authentication and authorisation point of view. The business content has not yet been validated at this stage.
/// This is the outer document that contains <seealso cref="AccountRequestAcknowledgementV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountRequestAcknowledgementV03Document : IOuterDocument<AccountRequestAcknowledgementV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.010.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountRequestAcknowledgementV03"/> is required.
    /// </summary>
    public required AccountRequestAcknowledgementV03 Message { get; init; }
}
