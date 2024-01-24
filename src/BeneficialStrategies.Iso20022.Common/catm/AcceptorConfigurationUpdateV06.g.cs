﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV06.  ISO2002 ID# _wnsp0bAHEeah1_v59tW6Rg.
//
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
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorConfigurationUpdateV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV06Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV06Document { Message = this };
    }
}

/// <summary>
/// Update of the acceptor configuration to be downloaded by the terminal management system.
/// This is the outer document that contains <seealso cref="AcceptorConfigurationUpdateV06"/>.
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
