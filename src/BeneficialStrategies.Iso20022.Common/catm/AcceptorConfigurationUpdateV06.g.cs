﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV06.  ISO2002 ID# _wnsp0bAHEeah1_v59tW6Rg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.catm;


/// <summary>
/// Update of the acceptor configuration to be downloaded by the terminal management system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Update of the acceptor configuration to be downloaded by the terminal management system.")]
public partial record AcceptorConfigurationUpdateV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_wnsp1bAHEeah1_v59tW6Rg")]
    [Description(@"Set of characteristics related to the transfer of the acceptor parameters.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header27 Header { get; init; }
    
    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_wnsp17AHEeah1_v59tW6Rg")]
    [Description(@"Acceptor configuration to be downloaded from the terminal management system.")]
    [DataMember(Name="AccptrCfgtn")]
    [XmlElement(ElementName="AccptrCfgtn")]
    [Required]
    public required AcceptorConfiguration6 AcceptorConfiguration { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_wnsp2bAHEeah1_v59tW6Rg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType12? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorConfigurationUpdateV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV06Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorConfigurationUpdateV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorConfigurationUpdateV06Document : IOuterDocument<AcceptorConfigurationUpdateV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorConfigurationUpdateV06"/> is required.
    /// </summary>
    public required AcceptorConfigurationUpdateV06 Message { get; init; }
}
