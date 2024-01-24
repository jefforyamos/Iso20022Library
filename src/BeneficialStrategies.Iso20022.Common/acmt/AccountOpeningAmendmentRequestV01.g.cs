﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountOpeningAmendmentRequestV01.  ISO2002 ID# _tW9heNE9Ed-BzquC8wXy7w_-820634121.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// The AccountOpeningAmendmentRequest message is sent from an organisation to a financial institution as part of the account opening process. It is sent in response to a request from the financial institution to provide additional information.
/// Usage
/// This message should only be sent if additional information is requested as part of the account opening process.
/// It could be sent together with other related documents.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountOpeningAmendmentRequest message is sent from an organisation to a financial institution as part of the account opening process. It is sent in response to a request from the financial institution to provide additional information.|Usage|This message should only be sent if additional information is requested as part of the account opening process.|It could be sent together with other related documents.")]
public partial record AccountOpeningAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngAmdmntReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountOpeningAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountOpeningAmendmentRequestV01Document ToDocument()
    {
        return new AccountOpeningAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The AccountOpeningAmendmentRequest message is sent from an organisation to a financial institution as part of the account opening process. It is sent in response to a request from the financial institution to provide additional information.
/// Usage
/// This message should only be sent if additional information is requested as part of the account opening process.
/// It could be sent together with other related documents.
/// This is the outer document that contains <seealso cref="AccountOpeningAmendmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountOpeningAmendmentRequestV01Document : IOuterDocument<AccountOpeningAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountOpeningAmendmentRequestV01"/> is required.
    /// </summary>
    public required AccountOpeningAmendmentRequestV01 Message { get; init; }
}
