﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForOrderStatusReportV02.  ISO2002 ID# _wWrFyNE7Ed-BzquC8wXy7w_-1373686594.
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
/// The RequestForOrderStatusReport is sent by an instructing party, eg, an investment manager or its authorised representative, to the executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party.
/// This message requests the status of one or several order instruction or order cancellation messages.
/// Usage
/// The RequestForOrderStatusReport message is used to request the status of:
/// - one or several order messages,
/// - one or several cancellation messages,
/// - one or several individual orders within a bulk or multiple order message.
/// If the RequestForOrderStatusReport message is used to request the status of several messages, then the instructing party will receive several reply messages from the executing party, ie, several OrderInstructionStatusReport messages and/or OrderCancellationStatusReport messages. The number of reply messages will match the number of references stated in the RequestForOrderStatusReport message.
/// The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RequestForOrderStatusReport is sent by an instructing party, eg, an investment manager or its authorised representative, to the executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party.|This message requests the status of one or several order instruction or order cancellation messages.|Usage|The RequestForOrderStatusReport message is used to request the status of:|- one or several order messages,|- one or several cancellation messages,|- one or several individual orders within a bulk or multiple order message.|If the RequestForOrderStatusReport message is used to request the status of several messages, then the instructing party will receive several reply messages from the executing party, ie, several OrderInstructionStatusReport messages and/or OrderCancellationStatusReport messages. The number of reply messages will match the number of references stated in the RequestForOrderStatusReport message.|The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.")]
public partial record RequestForOrderStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.018.001.02";
    
    #nullable enable
    /// <summary>
    /// Information to identify the order(s) for which the status is requested.
    /// </summary>
    [IsoId("_wWrFydE7Ed-BzquC8wXy7w_93958643")]
    [Description(@"Information to identify the order(s) for which the status is requested.")]
    [DataMember(Name="ReqDtls")]
    [XmlElement(ElementName="ReqDtls")]
    [Required]
    public required MessageAndBusinessReference2 RequestDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestForOrderStatusReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForOrderStatusReportV02Document ToDocument()
    {
        return new RequestForOrderStatusReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestForOrderStatusReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestForOrderStatusReportV02Document : IOuterDocument<RequestForOrderStatusReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.018.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestForOrderStatusReportV02"/> is required.
    /// </summary>
    public required RequestForOrderStatusReportV02 Message { get; init; }
}
