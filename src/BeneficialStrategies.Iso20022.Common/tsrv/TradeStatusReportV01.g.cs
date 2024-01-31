﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TradeStatusReportV01.  ISO2002 ID# _9hy8JXltEeG7BsjMvd1mEw_-944920037.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsrv;


/// <summary>
/// This record is an implementation of the tsrv.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The TradeStatusReport message is exchanged between parties involved in the trade finance domain to report the transaction level status of a transaction previously received. It informs the sender about the positive or negative status of the referenced transaction, such as acceptance or rejection resulting from technical validation performed by the parser and/or front-office applications. It can be used, for example, to acknowledge receipt of a transaction, to report a syntactical error, to report an unrecognised digital signature, to indicate that further processing is pending, and to indicate that a transaction has been technically accepted for processing by the back-office application. Multiple TradeStatusReport messages may be progressively sent in response to the incremental processing of a single transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The TradeStatusReport message is exchanged between parties involved in the trade finance domain to report the transaction level status of a transaction previously received. It informs the sender about the positive or negative status of the referenced transaction, such as acceptance or rejection resulting from technical validation performed by the parser and/or front-office applications. It can be used, for example, to acknowledge receipt of a transaction, to report a syntactical error, to report an unrecognised digital signature, to indicate that further processing is pending, and to indicate that a transaction has been technically accepted for processing by the back-office application. Multiple TradeStatusReport messages may be progressively sent in response to the incremental processing of a single transaction.")]
public partial record TradeStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradStsRpt";
    
    #nullable enable
    /// <summary>
    /// Details of the trade status report.
    /// </summary>
    [IsoId("_9hy8JnltEeG7BsjMvd1mEw_-979867813")]
    [Description(@"Details of the trade status report.")]
    [DataMember(Name="TradStsAdvcDtls")]
    [XmlElement(ElementName="TradStsAdvcDtls")]
    [Required]
    public required TradeStatusReport1 TradeStatusAdviceDetails { get; init; }
    
    /// <summary>
    /// Digital signature of the report.
    /// </summary>
    [IsoId("_9hy8J3ltEeG7BsjMvd1mEw_-480119583")]
    [Description(@"Digital signature of the report.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TradeStatusReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TradeStatusReportV01Document ToDocument()
    {
        return new TradeStatusReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TradeStatusReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TradeStatusReportV01Document : IOuterDocument<TradeStatusReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.018.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TradeStatusReportV01"/> is required.
    /// </summary>
    public required TradeStatusReportV01 Message { get; init; }
}
