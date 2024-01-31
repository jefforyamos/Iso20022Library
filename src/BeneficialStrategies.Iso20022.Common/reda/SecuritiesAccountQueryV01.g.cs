﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesAccountQueryV01.  ISO2002 ID# _KAu-wZ2fEem_Be8NuxvF7Q.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesAccountQuery message sent by an instructing party to the executing party to request the details related to the securities account.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesAccountQuery message sent by an instructing party to the executing party to request the details related to the securities account.")]
public partial record SecuritiesAccountQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctQry";
    
    #nullable enable
    /// <summary>
    /// Point to point reference elements, as assigned by the instructing party, to unambiguously identify the query message.
    /// </summary>
    [IsoId("_KAu-yZ2fEem_Be8NuxvF7Q")]
    [Description(@"Point to point reference elements, as assigned by the instructing party, to unambiguously identify the query message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public MessageHeader2? MessageHeader { get; init; }
    
    /// <summary>
    /// Defines the criteria to be used to query the securities account reference data by the executing system.
    /// </summary>
    [IsoId("_KAu-z52fEem_Be8NuxvF7Q")]
    [Description(@"Defines the criteria to be used to query the securities account reference data by the executing system.")]
    [DataMember(Name="SchCrit")]
    [XmlElement(ElementName="SchCrit")]
    [Required]
    public required SecuritiesAccountSearchCriteria2 SearchCriteria { get; init; }
    
    /// <summary>
    /// Defines the expected securities account reference data to be returned.
    /// </summary>
    [IsoId("_KAu-0Z2fEem_Be8NuxvF7Q")]
    [Description(@"Defines the expected securities account reference data to be returned.")]
    [DataMember(Name="RtrCrit")]
    [XmlElement(ElementName="RtrCrit")]
    public SecuritiesAccountReturnCriteria1? ReturnCriteria { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-052fEem_Be8NuxvF7Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesAccountQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesAccountQueryV01Document ToDocument()
    {
        return new SecuritiesAccountQueryV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesAccountQueryV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesAccountQueryV01Document : IOuterDocument<SecuritiesAccountQueryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.019.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesAccountQueryV01"/> is required.
    /// </summary>
    public required SecuritiesAccountQueryV01 Message { get; init; }
}
